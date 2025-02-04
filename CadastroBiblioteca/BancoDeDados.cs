using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using CadastroDePessoas;
using System.Runtime.Serialization;
using System.Threading;
using CadastroBiblioteca;

namespace CadastroBiblioteca
{
    [DataContract]
    public class BancoDeDados
    {

        //Atributos
        [DataMember]
        private List<Cadastros> listaDeCadastros;
        private string enderecoBancoDeDados;

        private Mutex mutexLista;
        private Mutex mutexArquivo;
        private bool baseDiponivel;

        //Construtor
        public BancoDeDados(string pEnderecoBancoDeDados)
        {
            enderecoBancoDeDados = pEnderecoBancoDeDados;
            mutexArquivo = new Mutex();
            mutexLista = new Mutex();
            baseDiponivel = true;

            new Thread(() =>
            {
                baseDiponivel = false;
                mutexArquivo.WaitOne();
                BancoDeDados bancoDeDadosTemp = Serializador.Desserialização(pEnderecoBancoDeDados);
                mutexArquivo.ReleaseMutex();

                mutexLista.WaitOne();
                if (bancoDeDadosTemp != null)
                {
                    listaDeCadastros = bancoDeDadosTemp.listaDeCadastros;
                }
                else
                    listaDeCadastros = new List<Cadastros>();
                mutexLista.ReleaseMutex();
                baseDiponivel = true;
            }).Start();
        }

        //Metodos
        public void addPessoas(Cadastros cadastro)
        {
            mutexLista.WaitOne();
            listaDeCadastros.Add(cadastro);
            mutexLista.ReleaseMutex();
            new Thread(() =>
            {
                baseDiponivel = false;
                mutexArquivo.WaitOne();
                Serializador.Serializa(enderecoBancoDeDados, this);
                mutexArquivo.ReleaseMutex();
                baseDiponivel = true;
            }).Start();
        }

        public List<Cadastros> PesquisaCadastro(string pDocumento)
        {
            mutexLista.WaitOne();
            List<Cadastros> listaTemp = listaDeCadastros.Where(x => x.Documento == pDocumento).ToList();
            mutexLista.ReleaseMutex();
            if (listaTemp.Count > 0)
                return listaTemp;
            else return null;
        }

        public List<Cadastros> DeletaCadastro(string pDocumento)
        {
            mutexLista.WaitOne();
            List<Cadastros> listaTemp = listaDeCadastros.Where(x => x.Documento == pDocumento).ToList();
            mutexLista.WaitOne();
            if (listaTemp.Count > 0)
            {
                foreach (Cadastros pessoa in listaTemp)
                {
                    mutexLista.WaitOne();
                    listaDeCadastros.Remove(pessoa);
                    mutexLista.WaitOne();
                }
                new Thread(() =>
                {
                    baseDiponivel = false;
                    mutexArquivo.WaitOne();
                    Serializador.Serializa(enderecoBancoDeDados, this);
                    mutexArquivo.ReleaseMutex();
                    baseDiponivel = true;
                }).Start();
                return listaTemp;

            }
            else
            {
                return null;
            }
        }

        public bool BaseDisponivel
        {
            get { return baseDiponivel; }
        }
    }
}
