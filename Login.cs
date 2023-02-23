using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkInBox_Gravação_PDT_110_F1 {
    public partial class Login : MaterialForm {

        //conexão sql server
        public static SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-7RD1EDP\\SQLEXPRESS; Database=markinbox;Trusted_Connection=True;");
        public static SqlCommand dataCommand = new SqlCommand();
        public static SqlDataReader dataReader;

        //variáveis passadas pela instância principal
        private int numeroTela;
        Principal principal;

        public Login(Principal _principal, int _numeroTela) {
            InitializeComponent();
            this.principal = _principal;
            this.numeroTela = _numeroTela;
        }

        public Login(Principal _principal) {
            InitializeComponent();
            this.principal = _principal;
        }


        private void buscarUsuario() {
            try {
                if (tbUsuario.Text == string.Empty) {
                    MessageBox.Show("É nescessário preencher o usuário!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (tbSenha.Text == string.Empty) {
                    MessageBox.Show("É nescessário preencher a senha!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sqlConnection.Open();
                string strSql = $"SELECT * FROM login WHERE usuario = '{tbUsuario.Text.ToString()}' " +
                                                        $"AND senha = '{tbSenha.Text.ToString()}'";
                dataCommand.Connection = sqlConnection;
                dataCommand.CommandText = strSql;
                dataReader = dataCommand.ExecuteReader();

                if (this.numeroTela == 1) {
                    if (dataReader.HasRows) {
                        this.principal.abrirTelaCadastrarEditarReceitas(this);
                    }
                    else {
                        MessageBox.Show("Usuário e/ou senha incorretos!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (this.numeroTela == 2) {
                    if (dataReader.HasRows) {
                        this.principal.abrirTelaEditarCadastrarReceitasMarkinbox(this);
                    }
                    else {
                        MessageBox.Show("Usuário e/ou senha incorretos!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (this.numeroTela == 3) {
                    if (dataReader.HasRows) {
                        this.principal.abrirTelaCadastrarTextoFixo(this);
                    }
                    else {
                        MessageBox.Show("Usuário e/ou senha incorretos!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (this.numeroTela == 4) {
                    if (dataReader.HasRows) {
                        this.principal.changeCheckBoxStartAutomaticToChecked(this);
                    }
                    else {
                        this.principal.changeCheckBoxStartAutomaticToUnChecked(this);
                        MessageBox.Show("Usuário e/ou senha incorretos!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (this.numeroTela == 5) {
                    if (dataReader.HasRows) {
                        this.principal.changeCheckBoxGravarMatriculaRepetidaToChecked(this);
                    }
                    else {
                        this.principal.changeCheckBoxGravarMatriculaRepetidaToUnChecked(this);
                        MessageBox.Show("Usuário e/ou senha incorretos!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                sqlConnection.Close();
                dataReader.Close();
            }
            catch {
                MessageBox.Show("Ocorreu um erro ao fazer login!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection.Close();
                dataReader.Close();
            }
        }
        private void btnLogin_Click(object sender, EventArgs e) {
            this.buscarUsuario();
        }
        private void btnLogout_Click(object sender, EventArgs e) {
            this.Hide();
        }
        public void Login_VisibleChanged(object sender, EventArgs e) {
            tbUsuario.Clear();
            tbSenha.Clear();
        }
    }
}
