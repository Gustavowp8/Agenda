using MySql.Data.MySqlClient;

namespace Agenda
{
    public partial class Form1 : Form
    {
        //Esta e a string de conexão
        private MySqlConnection Conecxao;
        private string data_source = "datasource=localhost;username=root;password=123456;database=db_agenda";


        public Form1()
        {
            InitializeComponent();

            lstConstatos.View = View.Details;
            lstConstatos.LabelEdit = true;
            lstConstatos.AllowColumnReorder = true;
            lstConstatos.FullRowSelect = true;
            lstConstatos.GridLines = true;

            lstConstatos.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lstConstatos.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lstConstatos.Columns.Add("Email", 150, HorizontalAlignment.Left);
            lstConstatos.Columns.Add("Telefone", 30, HorizontalAlignment.Left);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Função para inserir os dados no MySql
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Conecxao = new MySqlConnection(data_source);

                Conecxao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conecxao;

                cmd.CommandText = "INSERT INTO contato (nome, email, telefone) VALUES (@nome, @email, @telefone) ";

                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);

                cmd.ExecuteNonQuery();

                Conecxao.Close();

                MessageBox.Show("Contato Inserido com Sucesso!",
                                "Sucesso!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Number + " Tipo do erro: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conecxao.Close();
            }
        }

        //Buscar dados no MySql
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "'%" + txtBuscar.Text + "%'";

                //Criar conexão com MySql
                Conecxao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                    "FROM contato " +
                    "WHERE nome LIKE " + q + "OR email LIKE " + q;

                Conecxao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conecxao);

                MySqlDataReader reader = comando.ExecuteReader();

                lstConstatos.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };
                    var linha_listview = new ListViewItem(row);
                    lstConstatos.Items.Add(linha_listview);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conecxao.Close();
            }
        }
    }
}

//Terceira aula inicio