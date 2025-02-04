using CadastroBiblioteca;
using System.Windows.Forms;

namespace Cadastro_de_Pessoas
{
    public partial class Form1 : Form
    {
        BancoDeDados bancoDeDados;
        public Form1()
        {
            InitializeComponent();
            bancoDeDados = new BancoDeDados("BancoDeDados.xml");
        }

        public void limpaLabels()
        {
            labelNome.Text = "-";
            labelNascimento.Text = "-";
            labelNascimento.Text = "-";
            labelRua.Text = "-";
            labelNumRua.Text = "-";
        }

        private void Save1_Click(object sender, EventArgs e)
        {
            Cadastros cadastro = new Cadastros(textBoxNome.Text, textBoxDocumento.Text, Convert.ToDateTime(textBoxNascimento.Text), textBoxNomeRua.Text, Convert.ToUInt32(textBoxNumRua.Text));
            bancoDeDados.addPessoas(cadastro);
            MessageBox.Show("Cadastro salvo com sucesso", "Cadastro realizado", MessageBoxButtons.OK);
            limpaLabels();
        }

        private void buttonBusca_Click(object sender, EventArgs e)
        {
            List<Cadastros> listaDeCadastros = bancoDeDados.PesquisaCadastro(textBoxBuscaDoc.Text);
            if(listaDeCadastros != null && listaDeCadastros.Count > 0)
            {
                labelNome.Text = listaDeCadastros[0].Nome;
                labelNascimento.Text = listaDeCadastros[0].Nascimento.ToString();
                labelRua.Text = listaDeCadastros[0].Rua;
                labelNumRua.Text = listaDeCadastros[0].NumDaCasa.ToString();
            }
            else
            {
                MessageBox.Show("Cadastro não encontrado", "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDeleta_Click(object sender, EventArgs e)
        {
            List<Cadastros> listaDeCadastros = bancoDeDados.DeletaCadastro(textBoxBuscaDoc.Text);
            if (listaDeCadastros != null && listaDeCadastros.Count > 0)
            {
                labelNome.Text = listaDeCadastros[0].Nome;
                labelNascimento.Text = listaDeCadastros[0].Nascimento.ToString();
                labelRua.Text = listaDeCadastros[0].Rua;
                labelNumRua.Text = listaDeCadastros[0].NumDaCasa.ToString();
                MessageBox.Show("Usuário deletado com sucesso.", "Remoção concluída");
                limpaLabels();
            }
            else
            {
                MessageBox.Show("Cadastro não encontrado", "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
