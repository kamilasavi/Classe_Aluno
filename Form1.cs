using MySql.Data.MySqlClient;
namespace Classe_Aluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string mysqlcon = "server=localhost;user=root;database=database;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);

            try
            {
                mySqlConnection.Open(); 
                MessageBox.Show("Sucesso"); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        Aluno novoAluno = new Aluno();

        private void lbClasse_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                novoAluno.setNome(txbNome.Text);
                novoAluno.setEndereco(txbEndereco.Text);
                novoAluno.setDataNasc(dateTimePicker1.Value);
                novoAluno.setNota1(double.Parse(txbNota1.Text));
                novoAluno.setNota2(double.Parse(txbNota2.Text));
                novoAluno.setNota3(double.Parse(txbNota3.Text));

                MessageBox.Show("Aluno cadastrado com sucesso!", "Aviso");

                lblClasseAluno.Text = ("Informações do Aluno: " + novoAluno.getNome());
                lblClasseAluno.Text += ("\n\n Reside no endereço " + novoAluno.getEndereco());
                lblClasseAluno.Text += ("\n\n Sua data de nascimento é: " + novoAluno.getDataNasc().ToString("dd MMMM yyyy"));
                
                if (txbNome.TextLength > 0 && txbEndereco.TextLength > 0 && txbNota1.TextLength > 0 && txbNota2.TextLength > 0 && txbNota3.TextLength > 0)
                {
                    btnCalcular.Enabled = true;
                }
                
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro de Conversão", "Falha no Cadastro");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                novoAluno.calculamedia();

                novoAluno.verificarAprova();

                lblClasseAluno.Text += ("\n\n Média: " + novoAluno.getMedia().ToString());
                lblClasseAluno.Text += ("\n\n Resultado: " + novoAluno.getResultado().ToString());
            }

            catch (FormatException)
            {
                MessageBox.Show("Erro de Conversão", "Falha no Cálculo");
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Text = "";
            txbEndereco.Text = "";
            txbNota1.Text = "";
            txbNota2.Text = "";
            txbNota3.Text = "";
            lblClasseAluno.Text = "";
        }

        private void Form1_EnabledChanged(object sender, EventArgs e)
        {
            
        }
    }
}