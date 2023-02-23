using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MarkInBox_Gravação_PDT_110_F1 {
    public partial class CadastrarEditarReceitas : MaterialForm {

        //conexão sql server
        public SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-7RD1EDP\\SQLEXPRESS; Database=markinbox;Trusted_Connection=True;");
        public SqlCommand dataCommand = new SqlCommand();
        public SqlDataReader dataReader;

        public Principal principal;

        private bool comboReceitasMarkinboxClicked = true;

        public CadastrarEditarReceitas(Principal _principal) {
            InitializeComponent();
            buscarReceitasMarkinbox();
            principal = _principal;
        }

        private void CadastrarEditarReceitas_Load(object sender, EventArgs e) {
            //tooltips
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.Info;
            t_Tip.AutoPopDelay = 7000;

            t_Tip.SetToolTip(desenhoMotor, "Insira o desenho que quer cadastrar ou alterar!");

            t_Tip.SetToolTip(comboReceitas, "Selecione a receita padrão da gravadora!");

            t_Tip.SetToolTip(btnBuscarReceita, "Esse botão busca uma receita já cadastrada " +
                "é necessário inserir o desenho do motor!");

            t_Tip.SetToolTip(btnCadastrarReceitas, "Esse botão salva uma nova receita ou " +
                "atualiza uma receita já existente!");

            t_Tip.SetToolTip(btnDeletarReceita, "Esse botão apaga uma receita, basta " +
                "inserir o desenho e clicar em DELETAR!");
        }

        private void buscarReceitasMarkinbox() {
            try {
                sqlConnection.Open();
                string strSql = "SELECT * FROM receitas_mark";
                dataCommand.Connection = sqlConnection;
                dataCommand.CommandText = strSql;
                dataReader = dataCommand.ExecuteReader();

                if (dataReader.HasRows) {
                    while (dataReader.Read()) {
                        comboReceitas.Items.Add(dataReader["nome_receita"].ToString());
                    }
                }
                else {
                    MessageBox.Show("Não existem receitas markinbox cadasdtradas, " +
                        "Favor cadastrar receitas markinbox!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                sqlConnection.Close();
                dataReader.Close();
            }
            catch {
                MessageBox.Show("Ocorreu um erro ao buscar as receitas markinbox!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);

                sqlConnection.Close();
                dataReader.Close();
            }
        }

        private void btnBuscarReceita_Click(object sender, EventArgs e) {
            try {
                if (desenhoMotor.Text.Length == 0) {
                    MessageBox.Show("Peencha o desenho do motor!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sqlConnection.Open();

                string strSql = $"SELECT * FROM receitas WHERE desenho_motor = '{desenhoMotor.Text}'";
                dataCommand.Connection = sqlConnection;
                dataCommand.CommandText = strSql;
                dataReader = dataCommand.ExecuteReader();

                if (dataReader.HasRows) {
                    while (dataReader.Read()) {
                        string _linha01 = dataReader["linha_01"].ToString();
                        string _linha02 = dataReader["linha_02"].ToString();
                        string _linha03 = dataReader["linha_03"].ToString();
                        string _linha04 = dataReader["linha_04"].ToString();
                        string _linha05 = dataReader["linha_05"].ToString();

                        this.comboReceitasMarkinboxClicked = false;

                        comboReceitas.Text = dataReader["receita_markinbox"].ToString();
                        comboReceitas.Refresh();

                        if (!dataReader.IsClosed) { dataReader.Close(); }

                        strSql = $"SELECT * FROM receitas_mark WHERE nome_receita = '{comboReceitas.Text}'";
                        dataCommand.Connection = sqlConnection;
                        dataCommand.CommandText = strSql;
                        dataReader = dataCommand.ExecuteReader();

                        if (dataReader.HasRows) {
                            while (dataReader.Read()) {
                                switch (dataReader["numero_linhas"].ToString()) {
                                    case "1":
                                        panel1.Visible = true;
                                        panel2.Visible = false;
                                        panel3.Visible = false;
                                        panel4.Visible = false;
                                        panel5.Visible = false;

                                        linha01.Text = _linha01;
                                        linha01.Enabled = dataReader["linha_01"].ToString() == "Texto Livre" ? true : false;

                                        linha02.Text = null;
                                        linha03.Text = null;
                                        linha04.Text = null;
                                        linha05.Text = null;

                                        break;
                                    case "2":
                                        panel1.Visible = true;
                                        panel2.Visible = true;
                                        panel3.Visible = false;
                                        panel4.Visible = false;
                                        panel5.Visible = false;

                                        linha01.Text = _linha01;
                                        linha01.Enabled = dataReader["linha_01"].ToString() == "Texto Livre" ? true : false;
                                        linha02.Text = _linha02;
                                        linha02.Enabled = dataReader["linha_02"].ToString() == "Texto Livre" ? true : false;

                                        linha03.Text = null;
                                        linha04.Text = null;
                                        linha05.Text = null;
                                        break;
                                    case "3":
                                        panel1.Visible = true;
                                        panel2.Visible = true;
                                        panel3.Visible = true;
                                        panel4.Visible = false;
                                        panel5.Visible = false;

                                        linha01.Text = _linha01;
                                        linha01.Enabled = dataReader["linha_01"].ToString() == "Texto Livre" ? true : false;
                                        linha02.Text = _linha02;
                                        linha02.Enabled = dataReader["linha_02"].ToString() == "Texto Livre" ? true : false;
                                        linha03.Text = _linha03;
                                        linha03.Enabled = dataReader["linha_03"].ToString() == "Texto Livre" ? true : false;

                                        linha04.Text = null;
                                        linha05.Text = null;
                                        break;
                                    case "4":
                                        panel1.Visible = true;
                                        panel2.Visible = true;
                                        panel3.Visible = true;
                                        panel4.Visible = true;
                                        panel5.Visible = false;

                                        linha01.Text = _linha01;
                                        linha01.Enabled = dataReader["linha_01"].ToString() == "Texto Livre" ? true : false;
                                        linha02.Text = _linha02;
                                        linha02.Enabled = dataReader["linha_02"].ToString() == "Texto Livre" ? true : false;
                                        linha03.Text = _linha03;
                                        linha03.Enabled = dataReader["linha_03"].ToString() == "Texto Livre" ? true : false;
                                        linha04.Text = _linha04;
                                        linha04.Enabled = dataReader["linha_04"].ToString() == "Texto Livre" ? true : false;

                                        linha05.Text = null;
                                        break;
                                    case "5":
                                        panel1.Visible = true;
                                        panel2.Visible = true;
                                        panel3.Visible = true;
                                        panel4.Visible = true;
                                        panel5.Visible = true;

                                        linha01.Text = _linha01;
                                        linha01.Enabled = dataReader["linha_01"].ToString() == "Texto Livre" ? true : false;
                                        linha02.Text = _linha02;
                                        linha02.Enabled = dataReader["linha_02"].ToString() == "Texto Livre" ? true : false;
                                        linha03.Text = _linha03;
                                        linha03.Enabled = dataReader["linha_03"].ToString() == "Texto Livre" ? true : false;
                                        linha04.Text = _linha04;
                                        linha04.Enabled = dataReader["linha_04"].ToString() == "Texto Livre" ? true : false;
                                        linha05.Text = _linha05;
                                        linha05.Enabled = dataReader["linha_05"].ToString() == "Texto Livre" ? true : false;
                                        break;
                                }
                            }
                        }

                    }
                }
                else {
                    MessageBox.Show("Esse motor não está cadastrado!", "Motor cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.comboReceitasMarkinboxClicked = true;
                sqlConnection.Close();
                dataReader.Close();
            }
            catch (Exception ex) {
                this.comboReceitasMarkinboxClicked = true;
                MessageBox.Show("Ocorreu um erro ao buscar o motor!", "Motor cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sqlConnection.Close();
                dataReader.Close();
            }
        }

        private void btnCadastrarReceitas_Click(object sender, EventArgs e) {
            try {
                if (desenhoMotor.Text.Length == 0) {
                    MessageBox.Show("Peencha o desenho do motor!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (linha01.Text.Length == 0 && linha02.Text.Length == 0 &&
                        linha03.Text.Length == 0 && linha04.Text.Length == 0) {
                    MessageBox.Show("Peencha pelo menos uma linha!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sqlConnection.Open();
                string strSql = $"SELECT * FROM receitas WHERE desenho_motor = '{desenhoMotor.Text}'";
                dataCommand.Connection = sqlConnection;
                dataCommand.CommandText = strSql;
                dataReader = dataCommand.ExecuteReader();

                if (dataReader.HasRows) {
                    if (!dataReader.IsClosed) { dataReader.Close(); }

                    strSql = $"UPDATE receitas SET desenho_motor = '{desenhoMotor.Text}', " +
                                                 $"receita_markinbox = '{comboReceitas.Text}', " +
                                                 $"linha_01 = '{linha01.Text}', " +
                                                 $"linha_02 = '{linha02.Text}', " +
                                                 $"linha_03 = '{linha03.Text}', " +
                                                 $"linha_04 = '{linha04.Text}', " +
                                                 $"linha_05 = '{linha05.Text}' " +
                                                 $"WHERE desenho_motor = '{desenhoMotor.Text}'";
                    dataCommand.Connection = sqlConnection;
                    dataCommand.CommandText = strSql;

                    dataCommand.ExecuteNonQuery();

                    principal.updateMaterialListView1();

                    MessageBox.Show("Receita atualizada com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    if (!dataReader.IsClosed) { dataReader.Close(); }

                    strSql = $"INSERT INTO receitas VALUES('{desenhoMotor.Text.ToString()}', '{comboReceitas.Text.ToString()}', " +
                                                            $"'{linha01.Text.ToString()}', '{linha02.Text.ToString()}', " +
                                                            $"'{linha03.Text.ToString()}', '{linha04.Text.ToString()}', " +
                                                            $"'{linha05.Text.ToString()}')";

                    dataCommand.Connection = sqlConnection;
                    dataCommand.CommandText = strSql;

                    dataCommand.ExecuteNonQuery();

                    principal.updateMaterialListView1();

                    MessageBox.Show("Receita cadastrada com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                sqlConnection.Close();
                dataReader.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Ocorreu um erro ao cadastrar/atualizar receita!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection.Close();
                dataReader.Close();
            }
        }

        private void comboReceitas_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                if (this.comboReceitasMarkinboxClicked == true) {
                    if (comboReceitas.Text.Length != 0) {
                        sqlConnection.Open();
                        string strSql = $"SELECT * FROM receitas_mark WHERE nome_receita = '{comboReceitas.Text.ToString()}'";
                        dataCommand.Connection = sqlConnection;
                        dataCommand.CommandText = strSql;
                        dataReader = dataCommand.ExecuteReader();

                        if (dataReader.HasRows) {
                            while (dataReader.Read()) {
                                switch (dataReader["numero_linhas"].ToString()) {
                                    case "1":
                                        panel1.Visible = true;
                                        panel2.Visible = false;
                                        panel3.Visible = false;
                                        panel4.Visible = false;
                                        panel5.Visible = false;

                                        linha01.Text = dataReader["linha_01"].ToString();
                                        linha01.Enabled = dataReader["linha_01"].ToString() == "Texto Livre" ? true : false;

                                        linha02.Text = null;
                                        linha03.Text = null;
                                        linha04.Text = null;
                                        linha05.Text = null;

                                        break;
                                    case "2":
                                        panel1.Visible = true;
                                        panel2.Visible = true;
                                        panel3.Visible = false;
                                        panel4.Visible = false;
                                        panel5.Visible = false;

                                        linha01.Text = dataReader["linha_01"].ToString();
                                        linha01.Enabled = dataReader["linha_01"].ToString() == "Texto Livre" ? true : false;
                                        linha02.Text = dataReader["linha_02"].ToString();
                                        linha02.Enabled = dataReader["linha_02"].ToString() == "Texto Livre" ? true : false;

                                        linha03.Text = null;
                                        linha04.Text = null;
                                        linha05.Text = null;
                                        break;
                                    case "3":
                                        panel1.Visible = true;
                                        panel2.Visible = true;
                                        panel3.Visible = true;
                                        panel4.Visible = false;
                                        panel5.Visible = false;

                                        linha01.Text = dataReader["linha_01"].ToString();
                                        linha01.Enabled = dataReader["linha_01"].ToString() == "Texto Livre" ? true : false;
                                        linha02.Text = dataReader["linha_02"].ToString();
                                        linha02.Enabled = dataReader["linha_02"].ToString() == "Texto Livre" ? true : false;
                                        linha03.Text = dataReader["linha_03"].ToString();
                                        linha03.Enabled = dataReader["linha_03"].ToString() == "Texto Livre" ? true : false;

                                        linha04.Text = null;
                                        linha05.Text = null;
                                        break;
                                    case "4":
                                        panel1.Visible = true;
                                        panel2.Visible = true;
                                        panel3.Visible = true;
                                        panel4.Visible = true;
                                        panel5.Visible = false;

                                        linha01.Text = dataReader["linha_01"].ToString();
                                        linha01.Enabled = dataReader["linha_01"].ToString() == "Texto Livre" ? true : false;
                                        linha02.Text = dataReader["linha_02"].ToString();
                                        linha02.Enabled = dataReader["linha_02"].ToString() == "Texto Livre" ? true : false;
                                        linha03.Text = dataReader["linha_03"].ToString();
                                        linha03.Enabled = dataReader["linha_03"].ToString() == "Texto Livre" ? true : false;
                                        linha04.Text = dataReader["linha_04"].ToString();
                                        linha04.Enabled = dataReader["linha_04"].ToString() == "Texto Livre" ? true : false;

                                        linha05.Text = null;
                                        break;
                                    case "5":
                                        panel1.Visible = true;
                                        panel2.Visible = true;
                                        panel3.Visible = true;
                                        panel4.Visible = true;
                                        panel5.Visible = true;

                                        linha01.Text = dataReader["linha_01"].ToString();
                                        linha01.Enabled = dataReader["linha_01"].ToString() == "Texto Livre" ? true : false;
                                        linha02.Text = dataReader["linha_02"].ToString();
                                        linha02.Enabled = dataReader["linha_02"].ToString() == "Texto Livre" ? true : false;
                                        linha03.Text = dataReader["linha_03"].ToString();
                                        linha03.Enabled = dataReader["linha_03"].ToString() == "Texto Livre" ? true : false;
                                        linha04.Text = dataReader["linha_04"].ToString();
                                        linha04.Enabled = dataReader["linha_04"].ToString() == "Texto Livre" ? true : false;
                                        linha05.Text = dataReader["linha_05"].ToString();
                                        linha05.Enabled = dataReader["linha_05"].ToString() == "Texto Livre" ? true : false;
                                        break;
                                }
                            }
                        }
                        sqlConnection.Close();
                        dataReader.Close();
                    }
                    else {
                        MessageBox.Show("Receita markinbox não cadastrada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch {
                MessageBox.Show("Ocorreu um erro ao buscar a receita markinbox!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection.Close();
                dataReader.Close();
            }

        }

        private void btnDeletarReceita_Click(object sender, EventArgs e) {
            try {
                DialogResult dr;
                dr = MessageBox.Show($"Tem certeza que quer deletar a receta {desenhoMotor.Text}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes) {
                    if (!dataReader.IsClosed) { dataReader.Close(); }

                    sqlConnection.Open();

                    string strSql = $"DELETE receitas WHERE desenho_motor = '{desenhoMotor.Text.ToString()}'";
                    dataCommand.Connection = sqlConnection;
                    dataCommand.CommandText = strSql;

                    dataCommand.ExecuteNonQuery();

                    sqlConnection.Close();

                    this.principal.updateMaterialListView1();
                }
            }
            catch {
                MessageBox.Show("Ocorreu um erro ao deletar receita!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection.Close();
            }
        }
    }
}
