using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using CadastroBiblioteca;

namespace CadastroBiblioteca
{
    public static class Serializador
    {
        static private DataContractSerializer serializador = new DataContractSerializer(typeof(BancoDeDados));

        public static void Serializa(string pEnderecoXml, BancoDeDados pBancoDeDados)
        {

            XmlWriterSettings configXml = new XmlWriterSettings();
            StringBuilder construtorStringXml = new StringBuilder();
            XmlWriter escritorXML = XmlWriter.Create(construtorStringXml, configXml);
            serializador.WriteObject(escritorXML, pBancoDeDados);
            escritorXML.Flush();
            string strSerializada = construtorStringXml.ToString();
            escritorXML.Close();

            FileStream arquivoXMl = File.Create(pEnderecoXml);
            arquivoXMl.Close();

            File.WriteAllText(pEnderecoXml, strSerializada);
        }
        public static BancoDeDados Desserialização(string pEnderecoXml)
        {
            try
            {
                if (File.Exists(pEnderecoXml))
                {
                    string dentroArquivo = File.ReadAllText(pEnderecoXml);
                    StringReader leitorString = new StringReader(dentroArquivo);
                    XmlReader leitorXml = XmlReader.Create(leitorString);
                    BancoDeDados bancoDeDadosTemp = (BancoDeDados)serializador.ReadObject(leitorXml);
                    return bancoDeDadosTemp;
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }


    }
}
