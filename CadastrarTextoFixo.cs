using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Principal;

namespace MarkInBox_Gravação_PDT_110_F1 {
    public partial class CadastrarTextoFixo : MaterialForm {

        //conexão sql server
        public SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-7RD1EDP\\SQLEXPRESS; Database=markinbox;Trusted_Connection=True;");
        public SqlCommand dataCommand = new SqlCommand();
        public SqlDataReader dataReader;

        public Principal principal;

        public CadastrarTextoFixo(Principal _principal) {
            InitializeComponent();
            this.principal = _principal;
        }

        private void CadastrarTextoFixo_Load(object sender, EventArgs e) {
            //tooltips
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.Info;
            t_Tip.AutoPopDelay = 7000;

            t_Tip.SetToolTip(tbNumeroTextoFixo, "Insira o número do texto fixo, na sequência após " +
                "o último cadastrado!");

            t_Tip.SetToolTip(tbTextoFixo, "Insira o texto livre com até 20 caracteres!");

            t_Tip.SetToolTip(btnBuscarTexoFixo, "Esse botão busca um texto fixo já cadastrado " +
                "é necessário inserir o número do texto fixo!");

            t_Tip.SetToolTip(btnSalvarTextoFixo, "Esse botão salva um novo texto fixo ou " +
                "atualiza um já existente!");

            t_Tip.SetToolTip(btnDeletarTextoFixo, "Esse botão apaga um texto fixo, basta " +
                "inserir o número correspondente e clicar em DELETAR!");
        }

        private void btnBuscarTexoFixo_Click(object sender, EventArgs e) {
            this.buscarReceitaMarkinbox();
        }

        private void btnSalvarTextoFixo_Click(object sender, EventArgs e) {
            this.cadastrarTextoFixo();
        }

        private void btnDeletarTextoFixo_Click(object sender, EventArgs e) {
            this.deletarTextoFixo();
        }

        private void buscarReceitaMarkinbox() {
            try {
                if (tbTextoFixo.Text.Length == 0 && tbNumeroTextoFixo.Text.Length == 0) {
                    MessageBox.Show("Peencha o nome ou o número do texto fixo!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sqlConnection.Open();
                string strSql = $"SELECT * FROM textos_fixos WHERE numero_texto_fixo = '{tbNumeroTextoFixo.Text}'";
                dataCommand.Connection = sqlConnection;
                dataCommand.CommandText = strSql;
                dataReader = dataCommand.ExecuteReader();

                if (dataReader.HasRows) {
                    while (dataReader.Read()) {
                        tbNumeroTextoFixo.Text = dataReader["numero_texto_fixo"].ToString();
                        tbTextoFixo.Text = dataReader["nome_texto_fixo"].ToString(); 
                    }

                }
                else {
                    MessageBox.Show("Texto fixo não cadastrado!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                sqlConnection.Close();
                dataReader.Close();
            }
            catch {
                MessageBox.Show("Ocorreu um erro ao buscar texto fixo!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection.Close();
                dataReader.Close();
            }
        }

        private void cadastrarTextoFixo() {
            try {
                if (tbTextoFixo.Text.Length == 0) {
                    MessageBox.Show("Peencha o texto fixo!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (tbNumeroTextoFixo.Text.Length == 0) {
                    MessageBox.Show("Peencha o numero do texto fixo!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sqlConnection.Open();

                int receitaMarkinbox = int.Parse(tbNumeroTextoFixo.Text);
                string strSql = $"SELECT * FROM textos_fixos WHERE numero_texto_fixo = '{tbNumeroTextoFixo.Text}'";
                dataCommand.Connection = sqlConnection;
                dataCommand.CommandText = strSql;
                dataReader = dataCommand.ExecuteReader();


                if (dataReader.HasRows) {
                    if (!dataReader.IsClosed) { dataReader.Close(); }

                    strSql = $"UPDATE textos_fixos SET numero_texto_fixo = '{tbNumeroTextoFixo.Text.ToString()}', " +
                                             $"nome_texto_fixo = '{tbTextoFixo.Text.ToString()}' " +
                                             $"WHERE numero_texto_fixo = '{tbNumeroTextoFixo.Text.ToString()}'";
                    dataCommand.Connection = sqlConnection;
                    dataCommand.CommandText = strSql;

                    dataCommand.ExecuteNonQuery();

                    this.principal.updateMaterialListView3();

                    MessageBox.Show("Texto fixo atualizado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    if (!dataReader.IsClosed) { dataReader.Close(); }

                    strSql = $"SELECT * FROM textos_fixos WHERE nome_texto_fixo = '{tbTextoFixo.Text}'";
                    dataCommand.Connection = sqlConnection;
                    dataCommand.CommandText = strSql;
                    dataReader = dataCommand.ExecuteReader();

                    if (dataReader.HasRows) {
                        MessageBox.Show($"O texto fixo: {tbTextoFixo.Text} já existe!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!dataReader.IsClosed) { dataReader.Close(); }

                    strSql = $"INSERT INTO textos_fixos VALUES('{tbNumeroTextoFixo.Text.ToString()}', '{tbTextoFixo.Text.ToString()}')";
                    dataCommand.Connection = sqlConnection;
                    dataCommand.CommandText = strSql;

                    dataCommand.ExecuteNonQuery();

                    this.principal.updateMaterialListView3();

                    MessageBox.Show("Texto fixo cadastrado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                sqlConnection.Close();
                dataReader.Close();
            }
            catch {
                MessageBox.Show("Ocorreu um erro ao cadastrar texto fixo!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection.Close();
                dataReader.Close();
            }
        }

        private void deletarTextoFixo() {
            try {
                DialogResult dr;
                dr = MessageBox.Show($"Tem certeza que quer deletar a texto fixo {tbNumeroTextoFixo.Text}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes) {
                    sqlConnection.Open();

                    string strSql = $"DELETE textos_fixos WHERE numero_texto_fixo = '{tbNumeroTextoFixo.Text}'";
                    dataCommand.Connection = sqlConnection;
                    dataCommand.CommandText = strSql;

                    dataCommand.ExecuteNonQuery();

                    sqlConnection.Close();

                    this.principal.updateMaterialListView3();
                }
            }
            catch {
                MessageBox.Show("Ocorreu um erro ao deletar receita markinbox!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection.Close();
            }
        }
    }
}
