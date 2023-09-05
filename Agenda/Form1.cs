using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace Agenda
{
    public partial class Form1 : Form
    {
        //Esta e a string de conexão
        private MySqlConnection Conecxao;
        private string data_source = "datasource=localhost;username=root;password=123456;database=db_agenda";

        private int? id_contato_selecionado = null;


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
            lstConstatos.Columns.Add("Telefone", 150, HorizontalAlignment.Left);

            carregar_contatos();
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

                if (id_contato_selecionado == null)
                {
                    //insert
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
                else
                {
                    //update
                    cmd.CommandText = "UPDATE contato SET nome=@nome, email=@email, telefone=@telefone " +
                        "WHERE id=@id ";

                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@id", id_contato_selecionado);

                    cmd.ExecuteNonQuery();

                    Conecxao.Close();

                    MessageBox.Show("Contato Atualizado com Sucesso!",
                                    "Sucesso!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

                id_contato_selecionado = null;
                txtNome.Text = String.Empty;
                txtEmail.Text = "";
                txtTelefone.Text = "";

                carregar_contatos();

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
                Conecxao = new MySqlConnection(data_source);

                Conecxao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conecxao;

                cmd.CommandText = "SELECT * FROM contato WHERE nome LIKE @q OR email LIKE @q ";

                cmd.Parameters.AddWithValue("@q", "%" + txtBuscar.Text + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

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

                    lstConstatos.Items.Add(new ListViewItem(row));
                }

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

        private void carregar_contatos()
        {
            try
            {
                Conecxao = new MySqlConnection(data_source);

                Conecxao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conecxao;

                cmd.CommandText = "SELECT * FROM contato ORDER BY id DESC ";

                MySqlDataReader reader = cmd.ExecuteReader();

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

                    lstConstatos.Items.Add(new ListViewItem(row));
                }

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

        private void lstConstatos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lstConstatos.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                id_contato_selecionado = Convert.ToInt32(item.SubItems[0].Text);


                txtNome.Text = item.SubItems[1].Text;
                txtEmail.Text = item.SubItems[2].Text;
                txtTelefone.Text = item.SubItems[3].Text;

                btnExcluir.Visible = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            id_contato_selecionado = null;
            txtNome.Text = String.Empty;
            txtEmail.Text = "";
            txtTelefone.Text = "";

            txtNome.Focus();

            btnExcluir.Visible = false;
        }

        private void ExcuirContato_Click(object sender, EventArgs e)
        {
            excluir_contato();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluir_contato();
        }

        private void excluir_contato()
        {
            try
            {

                DialogResult conf = MessageBox.Show("Tem certeza que deseja excluir o registro ?",
                    "Ops, tem certeza", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (conf == DialogResult.Yes)
                {
                    //excluir no id
                    Conecxao = new MySqlConnection(data_source);

                    Conecxao.Open();

                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = Conecxao;

                    cmd.CommandText = "DELETE FROM contato WHERE id=@id ";

                    cmd.Parameters.AddWithValue("@id", id_contato_selecionado);

                    cmd.ExecuteNonQuery();

                    Conecxao.Close();

                    MessageBox.Show("Contato excluido com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    carregar_contatos();

                    id_contato_selecionado = null;
                    txtNome.Text = String.Empty;
                    txtEmail.Text = "";
                    txtTelefone.Text = "";

                    txtNome.Focus();

                    btnExcluir.Visible = false;

                }

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
    }
}

//Terceira aula inicio