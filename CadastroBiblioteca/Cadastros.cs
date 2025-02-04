using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CadastroBiblioteca
{
    [DataContract]
    public class Cadastros
    {
        public Cadastros(string _nome, string _documento, DateTime _nascimento, string _rua, UInt32 _numDaCasa)
        {
            this.Nome = _nome;
            this.Documento = _documento;
            this.Nascimento = _nascimento;
            this.Rua = _rua;
            this.NumDaCasa = _numDaCasa;
        }

        //Atributos-----------------------------------------------------
        [DataMember]
        private string _nome;
        [DataMember]
        private string _documento;
        [DataMember]
        private DateTime _nascimento;
        [DataMember]
        private string _rua;
        [DataMember]
        private UInt32 _numDaCasa;

        //Propriedades--------------------------------------------------
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Documento
        {
            get { return _documento; }
            set { _documento = value; }
        }
        public DateTime Nascimento
        {
            get { return _nascimento; }
            set { _nascimento = value; }
        }

        public string Rua
        {
            get { return _rua; }
            set { _rua = value; }
        }

        public UInt32 NumDaCasa
        {
            get { return _numDaCasa; }
            set { _numDaCasa = value; }
        }


    }


}
