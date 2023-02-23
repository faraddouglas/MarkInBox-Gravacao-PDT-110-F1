using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkInBox_Gravação_PDT_110_F1 {
    public partial class CadastrarReceitaMarkinBox : MaterialForm {

        //conexão sql server
        public SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-7RD1EDP\\SQLEXPRESS; Database=markinbox;Trusted_Connection=True;");
        public SqlCommand dataCommand = new SqlCommand();
        public SqlDataReader dataReader;

        public Principal principal;

        public CadastrarReceitaMarkinBox(Principal _principal) {
            InitializeComponent();
            this.principal = _principal;
            this.buscarTextosFixos();
        }

        private void CadastrarReceitaMarkinBox_Load(object sender, EventArgs e) {
            //tooltips
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.Info;
            t_Tip.AutoPopDelay = 7000;

            t_Tip.SetToolTip(tbNumeroReceitaMarkinbox, "Insira o número da receita, esse número " +
                "deve ser o mesmo da receita criada na Markinbox!");

            t_Tip.SetToolTip(tbNomeReceitaMarkinbox, "Insira o nome da receita, sugerimos que o " +
                "nome tenha relação com o nome da receita na Markinbox!");

            t_Tip.SetToolTip(tbNumeroDeLinhas, "Insira o número de linhas da receita, esse número " +
                "deve ser o igual ao número de linhas da receita correspondente na Markinbox!");

            t_Tip.SetToolTip(comboTipoLinha01, "Selecione o tipo de dados correspondente a " +
                "linha 01 da gravação!");

            t_Tip.SetToolTip(comboTipoLinha02, "Selecione o tipo de dados correspondente a " +
                "linha 02 da gravação!");

            t_Tip.SetToolTip(comboTipoLinha03, "Selecione o tipo de dados correspondente a " +
                "linha 03 da gravação!");

            t_Tip.SetToolTip(comboTipoLinha04, "Selecione o tipo de dados correspondente a " +
                "linha 04 da gravação!");

            t_Tip.SetToolTip(comboTipoLinha05, "Selecione o tipo de dados correspondente a " +
                "linha 05 da gravação!");

            t_Tip.SetToolTip(btnBuscarReceitasMarkinbox, "Esse botão busca uma receita já cadastrada " +
                "é necessário inserir o número da receita!");

            t_Tip.SetToolTip(btnCadastrarEditarReceitasMarkinbox, "Esse botão salva uma nova receita ou " +
                "atualiza uma já existente!");

            t_Tip.SetToolTip(btnDeletarReceita, "Esse botão apaga uma receita, basta " +
                "inserir o número correspondente e clicar em DELETAR!");
        }

        private void btnBuscarReceitasMarkinbox_Click(object sender, EventArgs e) {
            buscarReceitaMarkinbox();
        }

        private void btnCadastrarEditarReceitasMarkinbox_Click(object sender, EventArgs e) {
            cadastrarReceitasMarkinbox();
        }

        private void btnDeletarReceita_Click(object sender, EventArgs e) {
            this.deletarReceitaMarkinbox();
        }

        private void buscarReceitaMarkinbox() {
            try {
                if (tbNomeReceitaMarkinbox.Text.Length == 0 && tbNumeroReceitaMarkinbox.Text.Length == 0) {
                    MessageBox.Show("Peencha o nome ou o número da receita!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sqlConnection.Open();
                string strSql = $"SELECT * FROM receitas_mark WHERE numero_receita = '{tbNumeroReceitaMarkinbox.Text}'";
                dataCommand.Connection = sqlConnection;
                dataCommand.CommandText = strSql;
                dataReader = dataCommand.ExecuteReader();

                if (dataReader.HasRows) {
                    while (dataReader.Read()) {

                        tbNomeReceitaMarkinbox.Text = dataReader["nome_receita"].ToString();
                        tbNumeroDeLinhas.Text = dataReader["numero_linhas"].ToString();

                        string comboTextoTipoLinha01 = dataReader["tipo_linha_01"].ToString();
                        string comboTextoTipoLinha02 = dataReader["tipo_linha_02"].ToString();
                        string comboTextoTipoLinha03 = dataReader["tipo_linha_03"].ToString();
                        string comboTextoTipoLinha04 = dataReader["tipo_linha_04"].ToString();
                        string comboTextoTipoLinha05 = dataReader["tipo_linha_05"].ToString();

                        string comboTextolinha01 = dataReader["linha_01"].ToString();
                        string comboTextolinha02 = dataReader["linha_02"].ToString();
                        string comboTextolinha03 = dataReader["linha_03"].ToString();
                        string comboTextolinha04 = dataReader["linha_04"].ToString();
                        string comboTextolinha05 = dataReader["linha_05"].ToString();

                        comboTipoLinha01.SelectedItem = comboTextoTipoLinha01 != "" ? comboTextoTipoLinha01 : null;
                        panel1.Visible = comboTipoLinha01.SelectedItem == null ? false : true;

                        comboTipoLinha02.SelectedItem = comboTextoTipoLinha02 != "" ? comboTextoTipoLinha02 : null;
                        panel2.Visible = comboTipoLinha02.SelectedItem == null ? false : true;

                        comboTipoLinha03.SelectedItem = comboTextoTipoLinha03 != "" ? comboTextoTipoLinha03 : null;
                        panel3.Visible = comboTipoLinha03.SelectedItem == null ? false : true;

                        comboTipoLinha04.SelectedItem = comboTextoTipoLinha04 != "" ? comboTextoTipoLinha04 : null;
                        panel4.Visible = comboTipoLinha04.SelectedItem == null ? false : true;

                        comboTipoLinha05.SelectedItem = comboTextoTipoLinha05 != "" ? comboTextoTipoLinha05 : null;
                        panel5.Visible = comboTipoLinha05.SelectedItem == null ? false : true;

                        comboTextolinha01Fixa.SelectedItem = comboTextolinha01;
                        comboTextolinha02Fixa.SelectedItem = comboTextolinha02;
                        comboTextolinha03Fixa.SelectedItem = comboTextolinha03;
                        comboTextolinha04Fixa.SelectedItem = comboTextolinha04;
                        comboTextolinha05Fixa.SelectedItem = comboTextolinha05;
                    }
                }
                else {
                    MessageBox.Show("Receita markinbox não cadastrada!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                sqlConnection.Close();
                dataReader.Close();
            }
            catch (Exception e) {
                MessageBox.Show("Ocorreu um erro ao buscar a receita!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection.Close();
                dataReader.Close();
            }


        }

        private void buscarTextosFixos() {
            try {
                sqlConnection.Open();

                string strSql = $"SELECT * FROM textos_fixos";
                dataCommand.Connection = sqlConnection;
                dataCommand.CommandText = strSql;
                dataReader = dataCommand.ExecuteReader();


                if (dataReader.HasRows) {
                    while (dataReader.Read()) {
                        comboTextolinha01Fixa.Items.Add(dataReader["nome_texto_fixo"].ToString());
                        comboTextolinha02Fixa.Items.Add(dataReader["nome_texto_fixo"].ToString());
                        comboTextolinha03Fixa.Items.Add(dataReader["nome_texto_fixo"].ToString());
                        comboTextolinha04Fixa.Items.Add(dataReader["nome_texto_fixo"].ToString());
                        comboTextolinha05Fixa.Items.Add(dataReader["nome_texto_fixo"].ToString());
                    }
                }

                sqlConnection.Close();
                dataReader.Close();
            }
            catch {
                MessageBox.Show("Ocorreu um erro ao buscar textos fixos!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection.Close();
                dataReader.Close();
            }


        }

        private void cadastrarReceitasMarkinbox() {
            try {
                if (tbNomeReceitaMarkinbox.Text.Length == 0) {
                    MessageBox.Show("Peencha o nome da receita!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (tbNumeroReceitaMarkinbox.Text.Length == 0) {
                    MessageBox.Show("Peencha o numero da receita markinbox!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (tbNumeroDeLinhas.Text.Length == 0) {
                    MessageBox.Show("Peencha o numero de linhas!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sqlConnection.Open();

                string strSql = $"SELECT * FROM receitas_mark WHERE numero_receita = '{tbNumeroReceitaMarkinbox.Text}'";
                dataCommand.Connection = sqlConnection;
                dataCommand.CommandText = strSql;
                dataReader = dataCommand.ExecuteReader();

                
                if (dataReader.HasRows) {

                    string comboTextoTipoLinha01 = comboTipoLinha01.Text.ToString();
                    string comboTextoTipoLinha02 = comboTipoLinha02.Text.ToString();
                    string comboTextoTipoLinha03 = comboTipoLinha03.Text.ToString();
                    string comboTextoTipoLinha04 = comboTipoLinha04.Text.ToString();
                    string comboTextoTipoLinha05 = comboTipoLinha05.Text.ToString();

                    string comboTextolinha01 = comboTipoLinha01.Text.ToString() == "Texto Fixo" ? comboTextolinha01Fixa.Text.ToString() : comboTipoLinha01.Text.ToString();
                    string comboTextolinha02 = comboTipoLinha02.Text.ToString() == "Texto Fixo" ? comboTextolinha02Fixa.Text.ToString() : comboTipoLinha02.Text.ToString();
                    string comboTextolinha03 = comboTipoLinha03.Text.ToString() == "Texto Fixo" ? comboTextolinha03Fixa.Text.ToString() : comboTipoLinha03.Text.ToString();
                    string comboTextolinha04 = comboTipoLinha04.Text.ToString() == "Texto Fixo" ? comboTextolinha04Fixa.Text.ToString() : comboTipoLinha04.Text.ToString();
                    string comboTextolinha05 = comboTipoLinha05.Text.ToString() == "Texto Fixo" ? comboTextolinha05Fixa.Text.ToString() : comboTipoLinha05.Text.ToString();

                    if (!dataReader.IsClosed) { dataReader.Close(); }

                    strSql = $"UPDATE receitas_mark SET numero_receita = '{tbNumeroReceitaMarkinbox.Text.ToString()}', " +
                                             $"nome_receita = '{tbNomeReceitaMarkinbox.Text.ToString()}', " +
                                             $"numero_linhas = '{tbNumeroDeLinhas.Text.ToString()}', " +
                                             $"tipo_linha_01 = '{comboTextoTipoLinha01}', " +
                                             $"linha_01 = '{comboTextolinha01}', " +
                                             $"tipo_linha_02 = '{comboTextoTipoLinha02}', " +
                                             $"linha_02 = '{comboTextolinha02}', " +
                                             $"tipo_linha_03 = '{comboTextoTipoLinha03}', " +
                                             $"linha_03 = '{comboTextolinha03}', " +
                                             $"tipo_linha_04 = '{comboTextoTipoLinha04}', " +
                                             $"linha_04 = '{comboTextolinha04}', " +
                                             $"tipo_linha_05 = '{comboTextoTipoLinha05}', " +
                                             $"linha_05 = '{comboTextolinha05}' " +
                                             $"WHERE numero_receita = '{tbNumeroReceitaMarkinbox.Text.ToString()}'";

                    dataCommand.Connection = sqlConnection;
                    dataCommand.CommandText = strSql;

                    dataCommand.ExecuteNonQuery();

                    this.principal.updateMaterialListView2();

                    MessageBox.Show("Receita markinbox atualizada com sucesso!", "Motor cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    if (!dataReader.IsClosed) { dataReader.Close(); }

                    strSql = $"SELECT * FROM receitas_mark WHERE nome_receita = '{tbNomeReceitaMarkinbox.Text}'";
                    dataCommand.Connection = sqlConnection;
                    dataCommand.CommandText = strSql;
                    dataReader = dataCommand.ExecuteReader();

                    if (dataReader.HasRows) {
                        MessageBox.Show($"O nome da receita: {tbNomeReceitaMarkinbox.Text} já existe!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string comboTextoTipoLinha01 = comboTipoLinha01.Text.ToString();
                    string comboTextoTipoLinha02 = comboTipoLinha02.Text.ToString();
                    string comboTextoTipoLinha03 = comboTipoLinha03.Text.ToString();
                    string comboTextoTipoLinha04 = comboTipoLinha04.Text.ToString();
                    string comboTextoTipoLinha05 = comboTipoLinha05.Text.ToString();

                    string comboTextolinha01 = comboTipoLinha01.Text.ToString() == "Texto Fixo" ? comboTextolinha01Fixa.Text.ToString() : comboTipoLinha01.Text.ToString();
                    string comboTextolinha02 = comboTipoLinha02.Text.ToString() == "Texto Fixo" ? comboTextolinha02Fixa.Text.ToString() : comboTipoLinha02.Text.ToString();
                    string comboTextolinha03 = comboTipoLinha03.Text.ToString() == "Texto Fixo" ? comboTextolinha03Fixa.Text.ToString() : comboTipoLinha03.Text.ToString();
                    string comboTextolinha04 = comboTipoLinha04.Text.ToString() == "Texto Fixo" ? comboTextolinha04Fixa.Text.ToString() : comboTipoLinha04.Text.ToString();
                    string comboTextolinha05 = comboTipoLinha05.Text.ToString() == "Texto Fixo" ? comboTextolinha05Fixa.Text.ToString() : comboTipoLinha05.Text.ToString();

                    if (!dataReader.IsClosed) { dataReader.Close(); }

                    strSql = $"INSERT INTO receitas_mark VALUES('{tbNumeroReceitaMarkinbox.Text.ToString()}', '{tbNomeReceitaMarkinbox.Text.ToString()}', " +
                                                                $"'{tbNumeroDeLinhas.Text.ToString()}', " +
                                                                $"'{comboTextoTipoLinha01}', '{comboTextolinha01}', " +
                                                                $"'{comboTextoTipoLinha02}', '{comboTextolinha02}', " +
                                                                $"'{comboTextoTipoLinha03}', '{comboTextolinha03}', " +
                                                                $"'{comboTextoTipoLinha04}', '{comboTextolinha04}', " +
                                                                $"'{comboTextoTipoLinha05}', '{comboTextolinha05}')";

                    dataCommand.Connection = sqlConnection;
                    dataCommand.CommandText = strSql;

                    dataCommand.ExecuteNonQuery();

                    this.principal.updateMaterialListView2();

                    MessageBox.Show("Receita markinbox cadastrada com sucesso!", "Motor cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                sqlConnection.Close();
                dataReader.Close();
            }
            catch (Exception e){
                MessageBox.Show("Ocorreu um erro ao cadastrar/atualizar receita!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection.Close();
                dataReader.Close();
            }
        }

        private void deletarReceitaMarkinbox() {
            try {
                DialogResult dr;
                dr = MessageBox.Show($"Tem certeza que quer deletar a receta {tbNumeroReceitaMarkinbox.Text}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes) {
                    if (!dataReader.IsClosed) { dataReader.Close(); }

                    sqlConnection.Open();

                    string strSql = $"DELETE receitas_mark WHERE numero_receita = '{tbNumeroReceitaMarkinbox.Text}'";
                    dataCommand.Connection = sqlConnection;
                    dataCommand.CommandText = strSql;

                    dataCommand.ExecuteNonQuery();

                    sqlConnection.Close();

                    this.principal.updateMaterialListView2();
                }
            }
            catch {
                MessageBox.Show("Ocorreu um erro ao deletar receita markinbox!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection.Close();
            }
        }

        private void comboTipoLinha01_SelectedIndexChanged(object sender, EventArgs e) {
            switch (comboTipoLinha01.Text.ToString()) {
                case "Texto Livre":
                    comboTextolinha01Fixa.SelectedItem = null;
                    comboTextolinha01Fixa.Refresh();
                    comboTextolinha01Fixa.Enabled = false;
                    break;
                case "Texto Fixo":
                    comboTextolinha01Fixa.SelectedItem = null;
                    comboTextolinha01Fixa.Refresh();
                    comboTextolinha01Fixa.Enabled = true;
                    break;
                case "Matrícula":
                    comboTextolinha01Fixa.SelectedItem = null;
                    comboTextolinha01Fixa.Refresh();
                    comboTextolinha01Fixa.Enabled = false;
                    break;
                case "Classificação":
                    comboTextolinha01Fixa.SelectedItem = null;
                    comboTextolinha01Fixa.Refresh();
                    comboTextolinha01Fixa.Enabled = false;
                    break;
            }
            
        }

        private void comboTipoLinha02_SelectedIndexChanged(object sender, EventArgs e) {
            switch (comboTipoLinha02.Text.ToString()) {
                case "Texto Livre":
                    comboTextolinha02Fixa.SelectedItem = null;
                    comboTextolinha02Fixa.Refresh();
                    comboTextolinha02Fixa.Enabled = false;
                    break;
                case "Texto Fixo":
                    comboTextolinha02Fixa.SelectedItem = null;
                    comboTextolinha02Fixa.Refresh();
                    comboTextolinha02Fixa.Enabled = true;
                    break;
                case "Matrícula":
                    comboTextolinha02Fixa.SelectedItem = null;
                    comboTextolinha02Fixa.Refresh();
                    comboTextolinha02Fixa.Enabled = false;
                    break;
                case "Classificação":
                    comboTextolinha02Fixa.SelectedItem = null;
                    comboTextolinha02Fixa.Refresh();
                    comboTextolinha02Fixa.Enabled = false;
                    break;
            }

        }

        private void comboTipoLinha03_SelectedIndexChanged(object sender, EventArgs e) {
            switch (comboTipoLinha03.Text.ToString()) {
                case "Texto Livre":
                    comboTextolinha03Fixa.SelectedItem = null;
                    comboTextolinha03Fixa.Refresh();
                    comboTextolinha03Fixa.Enabled = false;
                    break;
                case "Texto Fixo":
                    comboTextolinha03Fixa.SelectedItem = null;
                    comboTextolinha03Fixa.Refresh();
                    comboTextolinha03Fixa.Enabled = true;
                    break;
                case "Matrícula":
                    comboTextolinha03Fixa.SelectedItem = null;
                    comboTextolinha03Fixa.Refresh();
                    comboTextolinha03Fixa.Enabled = false;
                    break;
                case "Classificação":
                    comboTextolinha03Fixa.SelectedItem = null;
                    comboTextolinha03Fixa.Refresh();
                    comboTextolinha03Fixa.Enabled = false;
                    break;
            }

        }

        private void comboTipoLinha04_SelectedIndexChanged(object sender, EventArgs e) {
            switch (comboTipoLinha04.Text.ToString()) {
                case "Texto Livre":
                    comboTextolinha04Fixa.SelectedItem = null;
                    comboTextolinha04Fixa.Refresh();
                    comboTextolinha04Fixa.Enabled = false;
                    break;
                case "Texto Fixo":
                    comboTextolinha04Fixa.SelectedItem = null;
                    comboTextolinha04Fixa.Refresh();
                    comboTextolinha04Fixa.Enabled = true;
                    break;
                case "Matrícula":
                    comboTextolinha04Fixa.SelectedItem = null;
                    comboTextolinha04Fixa.Refresh();
                    comboTextolinha04Fixa.Enabled = false;
                    break;
                case "Classificação":
                    comboTextolinha04Fixa.SelectedItem = null;
                    comboTextolinha04Fixa.Refresh();
                    comboTextolinha04Fixa.Enabled = false;
                    break;
            }

        }

        private void comboTipoLinha05_SelectedIndexChanged(object sender, EventArgs e) {
            switch (comboTipoLinha05.Text.ToString()) {
                case "Texto Livre":
                    comboTextolinha05Fixa.SelectedItem = null;
                    comboTextolinha05Fixa.Refresh();
                    comboTextolinha05Fixa.Enabled = false;
                    break;
                case "Texto Fixo":
                    comboTextolinha05Fixa.SelectedItem = null;
                    comboTextolinha05Fixa.Refresh();
                    comboTextolinha05Fixa.Enabled = true;
                    break;
                case "Matrícula":
                    comboTextolinha05Fixa.SelectedItem = null;
                    comboTextolinha05Fixa.Refresh();
                    comboTextolinha05Fixa.Enabled = false;
                    break;
                case "Classificação":
                    comboTextolinha05Fixa.SelectedItem = null;
                    comboTextolinha05Fixa.Refresh();
                    comboTextolinha05Fixa.Enabled = false;
                    break;
            }

        }

        private void tbNumeroDeLinhas_TextChanged(object sender, EventArgs e) {
            switch (tbNumeroDeLinhas.Text.ToString()) {
                case "1":
                    panel1.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel4.Visible = false;
                    panel5.Visible = false;
                    comboTipoLinha02.SelectedItem = null;
                    comboTextolinha02Fixa.SelectedItem = null;
                    comboTipoLinha03.SelectedItem = null;
                    comboTextolinha03Fixa.SelectedItem = null;
                    comboTipoLinha04.SelectedItem = null;
                    comboTextolinha04Fixa.SelectedItem = null;
                    comboTipoLinha05.SelectedItem = null;
                    comboTextolinha05Fixa.SelectedItem = null;
                    break;
                case "2":
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = false;
                    panel4.Visible = false;
                    panel5.Visible = false;
                    comboTipoLinha03.SelectedItem = null;
                    comboTextolinha03Fixa.SelectedItem = null;
                    comboTipoLinha04.SelectedItem = null;
                    comboTextolinha04Fixa.SelectedItem = null;
                    comboTipoLinha05.SelectedItem = null;
                    comboTextolinha05Fixa.SelectedItem = null;
                    break;
                case "3":
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    panel4.Visible = false;
                    panel5.Visible = false;
                    comboTipoLinha04.SelectedItem = null;
                    comboTextolinha04Fixa.SelectedItem = null;
                    comboTipoLinha05.SelectedItem = null;
                    comboTextolinha05Fixa.SelectedItem = null;
                    break;
                case "4":
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    panel4.Visible = true;
                    panel5.Visible = false;
                    comboTipoLinha05.SelectedItem = null;
                    comboTextolinha05Fixa.SelectedItem = null;
                    break;
                case "5":
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    panel4.Visible = true;
                    panel5.Visible = true;
                    break;
            }
        }
    }
}
