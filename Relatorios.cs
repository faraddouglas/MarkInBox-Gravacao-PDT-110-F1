using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace MarkInBox_Gravação_PDT_110_F1 {
    public partial class Relatorios : MaterialForm {

        //conexão sql server
        public static SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-7RD1EDP\\SQLEXPRESS; Database=markinbox;Trusted_Connection=True;");
        public static SqlCommand dataCommand = new SqlCommand();
        public static SqlDataReader dataReader;

        public Relatorios() {
            InitializeComponent();
        }

        private void btnBuscarRelatorio_Click(object sender, EventArgs e) {
            buscarGravacoes();
        }

        private void Relatorios_Load(object sender, EventArgs e) {
            //tooltips
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.Info;
            t_Tip.AutoPopDelay = 7000;

            t_Tip.SetToolTip(tbMatricula, "Insira a matrícula que deseja consultar ou " +
                "a data inicial e final!");

            t_Tip.SetToolTip(tbDateTimeInicial, "Insira a matrícula que deseja consultar ou " +
                "a data inicial e final!");

            t_Tip.SetToolTip(tbDateTimeFinal, "Insira a matrícula que deseja consultar ou " +
                "a data inicial e final!");

            t_Tip.SetToolTip(btnBuscarRelatorio, "Após inserir a matrícula ou data inicial e final " +
                "clique no botão BUSCAR!");

            t_Tip.SetToolTip(btnExportarExcel, "Clique no botão exportar para gerar a planilha em " +
                "excel no caminho C:/Relatórios!");
        }

        private void buscarGravacoes() {
            try {
                if (tbMatricula.Text != string.Empty) {
                    sqlConnection.Open();

                    string strSql = $"SELECT * FROM historico_gravacao WHERE linha_01 LIKE '%{tbMatricula.Text}%' OR " +
                                                                    $"linha_02 LIKE '%{tbMatricula.Text}%' OR " +
                                                                    $"linha_03 LIKE '%{tbMatricula.Text}%' OR " +
                                                                    $"linha_04 LIKE '%{tbMatricula.Text}%' OR " +
                                                                    $"linha_05 LIKE '%{tbMatricula.Text}%'";

                    dataCommand.Connection = sqlConnection;
                    dataCommand.CommandText = strSql;
                    dataReader = dataCommand.ExecuteReader();

                    materialListView1.Items.Clear();

                    if (dataReader.HasRows) {

                        while (dataReader.Read()) {
                            ListViewItem item = new ListViewItem(dataReader["id"].ToString());
                            item.SubItems.Add(dataReader["desenho_motor"].ToString());
                            item.SubItems.Add(dataReader["receita_markinbox"].ToString());
                            item.SubItems.Add(dataReader["numero_linhas"].ToString());
                            item.SubItems.Add(dataReader["linha_01"].ToString());
                            item.SubItems.Add(dataReader["linha_02"].ToString());
                            item.SubItems.Add(dataReader["linha_03"].ToString());
                            item.SubItems.Add(dataReader["linha_04"].ToString());
                            item.SubItems.Add(dataReader["linha_05"].ToString());
                            item.SubItems.Add(dataReader["data_gravacao"].ToString());
                            materialListView1.Items.Add(item);
                        }
                    }
                    else {
                        MessageBox.Show("Não há gravações cadastradas com esta matrícula!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    sqlConnection.Close();
                    dataReader.Close();
                }
                else if (tbDateTimeInicial.Text != string.Empty && tbDateTimeInicial.Text != string.Empty) {
                    sqlConnection.Open();

                    string strSql = $"SELECT * FROM historico_gravacao WHERE data_gravacao " +
                                                                            $"BETWEEN '{tbDateTimeInicial.Text}' " +
                                                                            $"AND '{tbDateTimeFinal.Text}'";

                    dataCommand.Connection = sqlConnection;
                    dataCommand.CommandText = strSql;
                    dataReader = dataCommand.ExecuteReader();

                    materialListView1.Items.Clear();

                    if (dataReader.HasRows) {

                        while (dataReader.Read()) {
                            ListViewItem item = new ListViewItem(dataReader["id"].ToString());
                            item.SubItems.Add(dataReader["desenho_motor"].ToString());
                            item.SubItems.Add(dataReader["receita_markinbox"].ToString());
                            item.SubItems.Add(dataReader["numero_linhas"].ToString());
                            item.SubItems.Add(dataReader["linha_01"].ToString());
                            item.SubItems.Add(dataReader["linha_02"].ToString());
                            item.SubItems.Add(dataReader["linha_03"].ToString());
                            item.SubItems.Add(dataReader["linha_04"].ToString());
                            item.SubItems.Add(dataReader["linha_05"].ToString());
                            item.SubItems.Add(dataReader["data_gravacao"].ToString());
                            materialListView1.Items.Add(item);
                        }
                    }
                    else {
                        MessageBox.Show("Não há gravações cadastradas com esta data!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    sqlConnection.Close();
                    dataReader.Close();

                }
                else {
                    MessageBox.Show("Preencha a Matrícula ou as Datas Inicial e Final", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    sqlConnection.Close();
                    dataReader.Close();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ocorreu um erro ao buscar dados", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);

                sqlConnection.Close();
                dataReader.Close();
            }


        }

        private void btnExportarExcel_Click(object sender, EventArgs e) {
            exportarExcel();
        }

        private void exportarExcel() {
            try {
                if (materialListView1.Items.Count > 0) {
                    // Inicia o componente Excel
                    Excel.Application xlApp;
                    Excel.Workbook xlWorkBook;
                    Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;
                    //Cria uma planilha temporária na memória do computador
                    xlApp = new Excel.Application();
                    xlWorkBook = xlApp.Workbooks.Add(misValue);
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    ListViewItem items = new ListViewItem();

                    xlWorkSheet.Cells[1, 1] = "Desenho";
                    xlWorkSheet.Cells[1, 2] = "Receita de Gravação";
                    xlWorkSheet.Cells[1, 3] = "Número de Linhas";
                    xlWorkSheet.Cells[1, 4] = "Linha 01";
                    xlWorkSheet.Cells[1, 5] = "Linha 02";
                    xlWorkSheet.Cells[1, 6] = "Linha 03";
                    xlWorkSheet.Cells[1, 7] = "Linha 04";
                    xlWorkSheet.Cells[1, 8] = "Linha 05";
                    xlWorkSheet.Cells[1, 9] = "Data";

                    for (int i = 0; i < materialListView1.Items.Count; i++) {
                        xlWorkSheet.Cells[i + 2, 1] = "\t" + materialListView1.Items[i].SubItems[1].Text;
                        xlWorkSheet.Cells[i + 2, 2] = "\t" + materialListView1.Items[i].SubItems[2].Text;
                        xlWorkSheet.Cells[i + 2, 3] = "\t" + materialListView1.Items[i].SubItems[3].Text;
                        xlWorkSheet.Cells[i + 2, 4] = "\t" + materialListView1.Items[i].SubItems[4].Text;
                        xlWorkSheet.Cells[i + 2, 5] = "\t" + materialListView1.Items[i].SubItems[5].Text;
                        xlWorkSheet.Cells[i + 2, 6] = "\t" + materialListView1.Items[i].SubItems[6].Text;
                        xlWorkSheet.Cells[i + 2, 7] = "\t" + materialListView1.Items[i].SubItems[7].Text;
                        xlWorkSheet.Cells[i + 2, 8] = "\t" + materialListView1.Items[i].SubItems[8].Text;
                        xlWorkSheet.Cells[i + 2, 9] = "\t" + materialListView1.Items[i].SubItems[9].Text;
                    }

                    string agora = DateTime.Now.ToString("").Replace("/", "")
                                                            .Replace(":", "")
                                                            .Replace(" ", "");
                    string caminho = "C:\\Relarórios";

                    //Salva o arquivo de acordo com a documentação do Excel.
                    xlWorkBook.SaveAs($"{caminho}\\{agora}.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                    Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();

                    //o arquivo foi salvo na pasta Meus Documentos.
                    //Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    MessageBox.Show("Concluído. Verifique em " + caminho + $"\\{agora}.xls");
                }
                else {
                    MessageBox.Show("Não existem dados para serem exportados!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ocorreu um erro ao exportar planilha!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
