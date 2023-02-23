using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Diagnostics;
using System.Data;
using System.Data.Common;
using System.Linq.Expressions;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.VisualBasic.Logging;


namespace MarkInBox_Gravação_PDT_110_F1 {
    public partial class Principal : MaterialForm {
        static SerialPort _serialPort;

        //conexão sql server
        public static SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-7RD1EDP\\SQLEXPRESS; Database=markinbox;Trusted_Connection=True;");
        public static SqlCommand dataCommand = new SqlCommand();
        public static SqlDataReader dataReader;

        //variáveis seguênciais da leitura
        bool leituraDesenho = false;
        bool leituraMatricula = false;
        bool leituraClassificacao = false;

        //numero da receita
        int numeroReceita = 0;

        //variável que rotorna se a serial está conectada
        bool serialConectada = false;
        bool scanearportarSeriais = true;

        public Principal() {
            InitializeComponent();

            tbLeituraDesenho.Focus();
            tbLeituraDesenho.SelectAll();

            _serialPort = new SerialPort();
            timerCOM.Enabled = true;

            this.atualizaListaCOMs();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Green700, TextShade.WHITE);
        }

        private void Principal_Load(object sender, EventArgs e) {
            tbLeituraDesenho.ResetText();
            tbLeituraDesenho.Focus();


            //tooltips
            ToolTip t_Tip = new ToolTip();
            t_Tip.Active = true;
            t_Tip.IsBalloon = true;
            t_Tip.ToolTipIcon = ToolTipIcon.Info;
            t_Tip.AutoPopDelay = 7000;

            t_Tip.SetToolTip(comboBox1, "Escolha a porta de comunicação com a gravadora " +
                "e clique em CONECTAR!");

            t_Tip.SetToolTip(btnStartGravacao, "Depois de carregar os dados, O botão " +
                "Start Gravação inicia a gravação!");

            t_Tip.SetToolTip(btnConectar, "Este botão serve para fazer a conexão entre " +
                "o computador e a gravadora!");

            t_Tip.SetToolTip(btnTelaRelatorios, "Este botão abre a tela para gerar relatórios!");

            t_Tip.SetToolTip(btnZerarValores, "Este botão zera todos os valores carregados acima!");

            t_Tip.SetToolTip(tbLeituraDesenho, "Aqui é inserido o desenho do motor!");
            t_Tip.SetToolTip(tbLeituraMatricula, "Aqui é inserido a matrícula!");
            t_Tip.SetToolTip(tbLeituraClassificacao, "Aqui é inserido a classificação, " +
                "etiqueta colada no bloco do motor!");


        }

        private void atualizaListaCOMs() {
            try {
                int i;
                bool quantDiferente;    //flag para sinalizar que a quantidade de portas mudou

                i = 0;
                quantDiferente = false;

                //se a quantidade de portas mudou
                if (comboBox1.Items.Count == SerialPort.GetPortNames().Length) {
                    foreach (string s in SerialPort.GetPortNames()) {
                        if (comboBox1.Items[i++].Equals(s) == false) {
                            quantDiferente = true;
                        }
                    }
                }
                else {
                    quantDiferente = true;
                }

                if (_serialPort.IsOpen == false && serialConectada == true) {
                    serialConectada = false;
                    MessageBox.Show("Você desconectou o cabo de comunicação com a " +
                        "gravadora conectada, para evitar problemas de gravação " +
                        "o programa será fechado. Abra o programa novamente " +
                        "clicando no ícone na área de trabalho!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

                //Se não foi detectado diferença
                if (quantDiferente == false) {
                    //retorna
                    return;
                }

                //limpa comboBox
                comboBox1.Items.Clear();

                //adiciona todas as COM diponíveis na lista
                foreach (string s in SerialPort.GetPortNames()) {
                    comboBox1.Items.Add(s);
                }

                //seleciona a primeira posição da lista
                comboBox1.SelectedIndex = 0;
                comboBox1.Refresh();
            }
            catch {
                Debug.WriteLine("Ocorreu um erro ao atualizar as portas seriais!");
                comboBox1.Refresh();
            }
        }

        private void timerCOM_Tick(object sender, EventArgs e) {
            this.atualizaListaCOMs();
        }

        private void btnConectar_Click(object sender, EventArgs e) {
            if (_serialPort.IsOpen == false) {
                try {
                    if (comboBox1.SelectedIndex >= 0) {
                        _serialPort.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                        _serialPort.BaudRate = 115200;
                        _serialPort.Parity = Parity.None;
                        _serialPort.DataBits = 8;
                        _serialPort.StopBits = StopBits.One;
                        _serialPort.Handshake = Handshake.None;
                        _serialPort.ReadTimeout = 2000;
                        _serialPort.WriteTimeout = 2000;

                        _serialPort.Open();

                        _serialPort.Write("\x40\x02\x33\x33\x30\x35\x30\x30\x30\x03");

                        string message = _serialPort.ReadTo("\x03");
                    }
                    else {
                        MessageBox.Show("Por favor selecione uma porta serial. " +
                            "Se não aparecer nenhuma porta para conexão, " +
                            "verifique o cabo serial!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (TimeoutException tmex) {
                    if (tmex.ToString() != "") {
                        MessageBox.Show("Erro de timeout de conexão com a gravadora!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _serialPort.Close();
                        comboBox1.Enabled = true;
                        btnConectar.Text = "Conectar";
                        serialConectada = false;
                        return;
                    }

                    MessageBox.Show("Erro inesperado, não foi possível conectar!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboBox1.Enabled = true;
                    btnConectar.Text = "Conectar";
                    serialConectada = false;

                    _serialPort.Close();
                    return;
                }
                if (_serialPort.IsOpen) {
                    btnConectar.Text = "Desconectar";
                    comboBox1.Enabled = false;
                    serialConectada = true;
                }
            }
            else {
                try {
                    _serialPort.Close();
                    comboBox1.Enabled = true;
                    btnConectar.Text = "Conectar";
                    serialConectada = false;
                }
                catch {
                    return;
                }

            }
        }

        private void Principal_Closed(object sender, EventArgs e) {
            if (_serialPort.IsOpen == true) {
                _serialPort.Close();
            }
        }

        private void btnCadastrarEditarReceitas_Click(object sender, EventArgs e) {
            this.abrirLogin(this, 1);
        }

        public void abrirTelaCadastrarEditarReceitas(Login login) {
            try {
                login.Hide();
                CadastrarEditarReceitas cadastrarReceitas = new CadastrarEditarReceitas(this);
                cadastrarReceitas.ShowDialog();
            }
            catch {
                MessageBox.Show("Ocorreu um erro ao abrir o cadastro de receitas!");
                return;
            }
        }

        private void btnTelaCadastrarTextoFixo_Click(object sender, EventArgs e) {
            this.abrirLogin(this, 3);
        }

        public void abrirTelaCadastrarTextoFixo(Login login) {
            try {
                login.Hide();
                CadastrarTextoFixo cadastrarTextoFixo = new CadastrarTextoFixo(this);
                cadastrarTextoFixo.ShowDialog();
            }
            catch {
                MessageBox.Show("Ocorreu um erro ao abrir cadastro de textos fixos!");
                return;
            }
        }

        private void btnTelaEditarCadastrarReceitasMarkinbox_Click(object sender, EventArgs e) {
            this.abrirLogin(this, 2);
        }

        public void abrirTelaEditarCadastrarReceitasMarkinbox(Login login) {
            try {
                login.Hide();
                CadastrarReceitaMarkinBox cadastrarReceitasMarkinbox = new CadastrarReceitaMarkinBox(this);
                cadastrarReceitasMarkinbox.ShowDialog();
            }
            catch {
                MessageBox.Show("Ocorreu um erro ao abrir cadastro de receitas markinbox!");
                return;
            }
        }

        private void abrirLogin(Principal principal, int numeroTela) {
            try {
                Login login = new Login(principal, numeroTela);
                login.ShowDialog();
                login.Close();
            }
            catch {
                MessageBox.Show("Ocorreu um erro ao abrir o login!");
                return;
            }
        }



        private void btnStartGravacao_Click(object sender, EventArgs e) {
            try {
                startGravacao();
            }
            catch {
                MessageBox.Show("Erro na resposta da gravadora. " +
                    "Verifique o cabo serial ou se a gravadora " +
                    "está ligada!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void preparaDadosParaGravacao(int receita, int linha, string textoDeMarcacao) {
            try {
                if (_serialPort.IsOpen == true) {
                    string fileNo = receita.ToString("D3");
                    string fieldNo = linha.ToString("D2");
                    string numberOfCharacteres = textoDeMarcacao.Length.ToString("D2");
                    string data = fileNo + fieldNo + numberOfCharacteres + textoDeMarcacao;

                    string startingCode = "\x40\x02";
                    string packageNo = "\x30\x30";
                    string command = "\x30\x39";
                    string dataLength = data.Length.ToString("D2");
                    string etx = "\x03";

                    _serialPort.Write(String.Format(startingCode + packageNo +
                            command + "0" + dataLength + data + etx));

                    _serialPort.ReadTo("\x03");

                }
                else {
                    MessageBox.Show("Porta serial não está conectada!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception();
                }
            }
            catch (TimeoutException tmex) {
                if (tmex.ToString() != "") {
                    MessageBox.Show("Erro de timeout de conexão com a gravadora, A porta serial será desconectada!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboBox1.Enabled = true;
                    btnConectar.Text = "Conectar";
                    _serialPort.Close();
                    return;
                }
                MessageBox.Show("Erro inesperado ao enviar dados para gravação!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void startGravacao() {
            try {
                if (_serialPort.IsOpen) {

                    _serialPort.Write("\x40\x02\x33\x33\x30\x35\x30\x30\x30\x03");
                    string resp = _serialPort.ReadTo("\x03");
                    if (resp.Substring(9, 2) == "99") {
                        MessageBox.Show("Gravadora está em alarme!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (resp.Substring(9, 2) == " 1") {
                        MessageBox.Show("Gravadora está em marcação, aguarde!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (resp.Substring(9, 2) == " 2") {
                        MessageBox.Show("Gravadora ainda está em movimento, aguarde!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (resp.Substring(9, 2) == " 3") {
                        MessageBox.Show("Gravadora está retornando para a origem, aguarde!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    bool matricula = true;

                    sqlConnection.Open();
                    string strSql = $"SELECT * FROM receitas_mark WHERE nome_receita = '{tbLeituraReceita.Text}'";
                    dataCommand.Connection = sqlConnection;
                    dataCommand.CommandText = strSql;
                    dataReader = dataCommand.ExecuteReader();

                    if (dataReader.HasRows) {
                        while (dataReader.Read()) {
                            if (dataReader["linha_01"].ToString() != "Matrícula" &&
                                dataReader["linha_02"].ToString() != "Matrícula" &&
                                dataReader["linha_03"].ToString() != "Matrícula" &&
                                dataReader["linha_04"].ToString() != "Matrícula" &&
                                dataReader["linha_05"].ToString() != "Matrícula") {
                                matricula = false;
                            }
                        }
                    }

                    if (this.leituraDesenho == true &&
                            (this.leituraMatricula == true || matricula == false) &&
                            this.leituraClassificacao == true) {
                        if (_serialPort.IsOpen) {
                            string _numeroReceita = numeroReceita.ToString("D3");
                            string comandoDeStart = $"\x40\x02\x30\x30\x31\x31\x30\x30\x33{_numeroReceita}\x03";
                            _serialPort.Write(comandoDeStart);

                            string resposta = _serialPort.ReadTo("\x03");

                            if (resposta.Contains("61")) {
                                sqlConnection.Close();
                                dataReader.Close();
                                MessageBox.Show($"A receita: {_numeroReceita} " +
                                    "não está cadastrada na Markinbox!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                _serialPort.Write("\x40\x02\x33\x33\x30\x35\x30\x30\x30\x03");
                                _serialPort.ReadTo("\x03");
                                return;
                            }
                            this.salvarDadosDeGravacao();
                        }
                        else {
                            MessageBox.Show("Porta serial não está conectada", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        this.leituraDesenho = false;
                        this.leituraMatricula = false;
                        this.leituraClassificacao = false;
                    }
                    else {
                        if (this.leituraDesenho != true) {
                            MessageBox.Show("É necessário entrar com o desenho do motor " +
                                "para iniciar a gravação!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            sqlConnection.Close();
                            dataReader.Close();
                            return;
                        }
                        if (this.leituraMatricula != true) {
                            MessageBox.Show("Faça a leitura da matrícula corretamente!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            sqlConnection.Close();
                            dataReader.Close();
                            return;
                        }
                        if (this.leituraClassificacao != true) {
                            sqlConnection.Close();
                            dataReader.Close();
                            MessageBox.Show("Faça a leitura da classificação corretamente!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }



                    sqlConnection.Close();
                    dataReader.Close();
                }
                else {
                    sqlConnection.Close();
                    dataReader.Close();
                    MessageBox.Show("A gravadora não está conectada, " +
                        "verifique o cabo ou se ela está ligada!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch {
                sqlConnection.Close();
                dataReader.Close();
                MessageBox.Show("Erro inesperado ao iniciar a gravação", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tabPage1_Enter(object sender, EventArgs e) {
            tbLeituraDesenho.Focus();
            tbLeituraDesenho.SelectAll();
        }

        private void tabPage2_Enter(object sender, EventArgs e) {
            updateMaterialListView1();
        }

        private void tabPage3_Enter(object sender, EventArgs e) {
            updateMaterialListView2();
            updateMaterialListView3();
        }

        public void updateMaterialListView1() {
            try {
                sqlConnection.Open();
                string strSql = "SELECT * FROM receitas";
                dataCommand.Connection = sqlConnection;
                dataCommand.CommandText = strSql;
                dataReader = dataCommand.ExecuteReader();

                materialListView1.Items.Clear();

                if (dataReader.HasRows) {
                    while (dataReader.Read()) {
                        ListViewItem item = new ListViewItem(dataReader["id"].ToString());
                        item.SubItems.Add(dataReader["desenho_motor"].ToString());
                        item.SubItems.Add(dataReader["receita_markinbox"].ToString());
                        item.SubItems.Add(dataReader["linha_01"].ToString());
                        item.SubItems.Add(dataReader["linha_02"].ToString());
                        item.SubItems.Add(dataReader["linha_03"].ToString());
                        item.SubItems.Add(dataReader["linha_04"].ToString());
                        item.SubItems.Add(dataReader["linha_05"].ToString());
                        materialListView1.Items.Add(item);
                    }
                }
                else {
                    MessageBox.Show("Não há receitas cadastradas!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                sqlConnection.Close();
                dataReader.Close();
            }
            catch {
                MessageBox.Show("Ocorreu um erro ao listar receitas!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection.Close();
                dataReader.Close();
            }
        }

        public void updateMaterialListView2() {
            try {
                sqlConnection.Open();
                string strSql = "SELECT * FROM receitas_mark";
                dataCommand.Connection = sqlConnection;
                dataCommand.CommandText = strSql;
                dataReader = dataCommand.ExecuteReader();

                materialListView2.Items.Clear();

                if (dataReader.HasRows) {
                    while (dataReader.Read()) {
                        ListViewItem item = new ListViewItem(dataReader["id"].ToString());
                        item.SubItems.Add(dataReader["numero_receita"].ToString());
                        item.SubItems.Add(dataReader["nome_receita"].ToString());
                        item.SubItems.Add(dataReader["numero_linhas"].ToString());
                        item.SubItems.Add(dataReader["linha_01"].ToString());
                        item.SubItems.Add(dataReader["linha_02"].ToString());
                        item.SubItems.Add(dataReader["linha_03"].ToString());
                        item.SubItems.Add(dataReader["linha_04"].ToString());
                        item.SubItems.Add(dataReader["linha_05"].ToString());

                        materialListView2.Items.Add(item);
                    }
                }
                else {
                    MessageBox.Show("Não há receitas markinbox cadastradas!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                sqlConnection.Close();
                dataReader.Close();
            }
            catch {
                MessageBox.Show("Ocorreu um erro ao listar receitas markinbox!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection.Close();
                dataReader.Close();
            }
        }

        public void updateMaterialListView3() {
            try {
                sqlConnection.Open();
                string strSql = "SELECT * FROM textos_fixos";
                dataCommand.Connection = sqlConnection;
                dataCommand.CommandText = strSql;
                dataReader = dataCommand.ExecuteReader();

                materialListView3.Items.Clear();

                if (dataReader.HasRows) {
                    while (dataReader.Read()) {
                        ListViewItem item = new ListViewItem(dataReader["id"].ToString());
                        item.SubItems.Add(dataReader["numero_texto_fixo"].ToString());
                        item.SubItems.Add(dataReader["nome_texto_fixo"].ToString());

                        materialListView3.Items.Add(item);
                    }
                }
                else {
                    MessageBox.Show("Não há textos fixos cadastrados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                sqlConnection.Close();
                dataReader.Close();
            }
            catch {
                MessageBox.Show("Ocorreu um erro ao listar textos fixos!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection.Close();
                dataReader.Close();
            }
        }

        private void tbLeituraDesenho_KeyPress(object sender, KeyPressEventArgs e) {

            if (e.KeyChar == (char)13) {
                if (tbLeituraDesenho.Text.Length == 15) {

                    try {
                        bool matricula = true;

                        sqlConnection.Open();
                        string strSql = $"SELECT * FROM receitas WHERE desenho_motor = '{tbLeituraDesenho.Text}'";
                        dataCommand.Connection = sqlConnection;
                        dataCommand.CommandText = strSql;
                        dataReader = dataCommand.ExecuteReader();

                        if (dataReader.HasRows) {
                            while (dataReader.Read()) {
                                tbLeituraReceita.Text = dataReader["receita_markinbox"].ToString();
                                tbLeituraLinha01.Text = dataReader["linha_01"].ToString();
                                tbLeituraLinha02.Text = dataReader["linha_02"].ToString();
                                tbLeituraLinha03.Text = dataReader["linha_03"].ToString();
                                tbLeituraLinha04.Text = dataReader["linha_04"].ToString();
                                tbLeituraLinha05.Text = dataReader["linha_05"].ToString();
                            }

                            this.leituraDesenho = true;

                            if (!dataReader.IsClosed) { dataReader.Close(); }

                            strSql = $"SELECT * FROM receitas_mark WHERE nome_receita = '{tbLeituraReceita.Text}'";
                            dataCommand.Connection = sqlConnection;
                            dataCommand.CommandText = strSql;
                            dataReader = dataCommand.ExecuteReader();

                            if (dataReader.HasRows) {
                                while (dataReader.Read()) {
                                    if (dataReader["linha_01"].ToString() != "Matrícula" &&
                                        dataReader["linha_02"].ToString() != "Matrícula" &&
                                        dataReader["linha_03"].ToString() != "Matrícula" &&
                                        dataReader["linha_04"].ToString() != "Matrícula" &&
                                        dataReader["linha_05"].ToString() != "Matrícula") {
                                        matricula = false;
                                    }
                                }
                            }

                            if (matricula == true) {
                                tbLeituraMatricula.Enabled = true;
                                tbLeituraMatricula.ResetText();
                                tbLeituraClassificacao.ResetText();
                                tbLeituraMatricula.Focus();

                            }
                            else {
                                tbLeituraMatricula.Enabled = false;
                                tbLeituraMatricula.ResetText();
                                tbLeituraClassificacao.ResetText();
                                tbLeituraClassificacao.Focus();
                            }
                        }
                        else {
                            MessageBox.Show("Esse motor não está cadastrado!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        sqlConnection.Close();
                        dataReader.Close();
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Ocorreu um erro ao buscar o motor!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        sqlConnection.Close();
                        dataReader.Close();
                    }
                }
                else {
                    MessageBox.Show("Leitura do desenho incorreta! " +
                            "Aponte para o campo certo, ou leia desenho correto " +
                            "na ficha do motor!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbLeituraMatricula_KeyPress(object sender, KeyPressEventArgs e) {

            try {
                if (e.KeyChar == (char)13) {
                    if (tbLeituraMatricula.Text.Length == 11 &&
                        tbLeituraMatricula.Text.Substring(0, 4) == "4002") {

                        tbLeituraClassificacao.ResetText();
                        tbLeituraClassificacao.Focus();

                        string matricula = "*" + tbLeituraMatricula.Text.Replace("4002", "") + "*";

                        tbLeituraLinha01.Text = tbLeituraLinha01.Text.ToString() == "Matrícula" ? matricula : tbLeituraLinha01.Text.ToString();
                        tbLeituraLinha02.Text = tbLeituraLinha02.Text.ToString() == "Matrícula" ? matricula : tbLeituraLinha02.Text.ToString();
                        tbLeituraLinha03.Text = tbLeituraLinha03.Text.ToString() == "Matrícula" ? matricula : tbLeituraLinha03.Text.ToString();
                        tbLeituraLinha04.Text = tbLeituraLinha04.Text.ToString() == "Matrícula" ? matricula : tbLeituraLinha04.Text.ToString();
                        tbLeituraLinha05.Text = tbLeituraLinha05.Text.ToString() == "Matrícula" ? matricula : tbLeituraLinha05.Text.ToString();

                        this.leituraMatricula = true;
                    }
                    else {
                        MessageBox.Show("Leitura da matrícula incorreta! " +
                            "Aponte para o campo certo, ou leia a matrícula correta " +
                            "na ficha do motor!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }

                sqlConnection.Close();
                dataReader.Close();
            }
            catch {
                MessageBox.Show("Ocorreu um erro ao carregar a matrícula! ", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);

                sqlConnection.Close();
                dataReader.Close();
            }
        }

        private void tbLeituraClassificacao_KeyPress(object sender, KeyPressEventArgs e) {

            try {
                if (e.KeyChar == (char)13) {
                    if (tbLeituraClassificacao.Text.Length == 14) {
                        string cassificacao01 = tbLeituraClassificacao.Text.Substring(0, 4);
                        string cassificacao02 = tbLeituraClassificacao.Text.Substring(9, 5);
                        string classificacao = cassificacao01 + "-" + cassificacao02;

                        string[] textosLinhas = new string[5];

                        tbLeituraLinha01.Text = tbLeituraLinha01.Text.ToString() == "Classificação" ? classificacao : tbLeituraLinha01.Text.ToString();
                        tbLeituraLinha02.Text = tbLeituraLinha02.Text.ToString() == "Classificação" ? classificacao : tbLeituraLinha02.Text.ToString();
                        tbLeituraLinha03.Text = tbLeituraLinha03.Text.ToString() == "Classificação" ? classificacao : tbLeituraLinha03.Text.ToString();
                        tbLeituraLinha04.Text = tbLeituraLinha04.Text.ToString() == "Classificação" ? classificacao : tbLeituraLinha04.Text.ToString();
                        tbLeituraLinha05.Text = tbLeituraLinha05.Text.ToString() == "Classificação" ? classificacao : tbLeituraLinha05.Text.ToString();

                        textosLinhas[0] = tbLeituraLinha01.Text;
                        textosLinhas[1] = tbLeituraLinha02.Text;
                        textosLinhas[2] = tbLeituraLinha03.Text;
                        textosLinhas[3] = tbLeituraLinha04.Text;
                        textosLinhas[4] = tbLeituraLinha05.Text;

                        sqlConnection.Open();
                        string strSql = $"SELECT * FROM receitas_mark WHERE nome_receita = '{tbLeituraReceita.Text}'";
                        dataCommand.Connection = sqlConnection;
                        dataCommand.CommandText = strSql;
                        dataReader = dataCommand.ExecuteReader();

                        numeroReceita = 0;
                        int numeroLinhas = 0;

                        if (dataReader.HasRows) {
                            while (dataReader.Read()) {
                                numeroReceita = int.Parse(dataReader["numero_receita"].ToString());
                                numeroLinhas = int.Parse(dataReader["numero_linhas"].ToString());
                            }
                        }

                        if (!dataReader.IsClosed) { dataReader.Close(); }

                        string matricula = tbLeituraMatricula.Text.Replace("4002", "");

                        strSql = $"SELECT * FROM historico_gravacao WHERE linha_01 = '*{matricula}*' OR " +
                                                                        $"linha_02 = '*{matricula}*' OR " +
                                                                        $"linha_03 = '*{matricula}*' OR " +
                                                                        $"linha_04 = '*{matricula}*' OR " +
                                                                        $"linha_05 = '*{matricula}*'";
                        dataCommand.Connection = sqlConnection;
                        dataCommand.CommandText = strSql;
                        dataReader = dataCommand.ExecuteReader();

                        if (checkGravarMatriculaRepetida.Checked == false) {
                            if (dataReader.HasRows) {
                                sqlConnection.Close();
                                dataReader.Close();

                                tbLeituraDesenho.Focus();
                                tbLeituraDesenho.SelectAll();

                                MessageBox.Show("Matrícula já gravada!,"
                                                , "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else {
                                this.leituraClassificacao = true;

                                for (int i = 1; i <= numeroLinhas; i++) {
                                    this.preparaDadosParaGravacao(numeroReceita, i, textosLinhas[i - 1]);
                                    textosLinhas[i - 1] = "";
                                }

                                if (checkStartAutomatico.Checked == true) {
                                    this.startGravacao();
                                }

                                sqlConnection.Close();
                                dataReader.Close();

                                //MessageBox.Show("Dados da gravação salvos no banco!", "Atencção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else {
                            this.leituraClassificacao = true;

                            for (int i = 1; i <= numeroLinhas; i++) {
                                this.preparaDadosParaGravacao(numeroReceita, i, textosLinhas[i - 1]);
                                textosLinhas[i - 1] = "";
                            }

                            if (checkStartAutomatico.Checked == true) {
                                this.startGravacao();
                            }

                            sqlConnection.Close();
                            dataReader.Close();
                        }

                        tbLeituraDesenho.Focus();
                        tbLeituraDesenho.SelectAll();

                        sqlConnection.Close();
                        dataReader.Close();
                    }
                    else {
                        MessageBox.Show("Leitura da classificação incorreta! " +
                            "Aponte para o campo certo, ou leita a classificação no bloco!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex) {
                tbLeituraDesenho.Focus();
                tbLeituraDesenho.SelectAll();

                MessageBox.Show("Ocorreu um erro ao enviar dados para a gravadora!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);

                sqlConnection.Close();
                dataReader.Close();
            }
        }

        public void checkStartAutomatico_Click(object sender, EventArgs e) {
            if (checkStartAutomatico.Checked == false) {
                checkStartAutomatico.Checked = false;
                btnStartGravacao.Enabled = true;
            }
            else {
                checkStartAutomatico.Checked = false;
                abrirLogin(this, 4);
            }
        }

        public void changeCheckBoxStartAutomaticToChecked(Login login) {
            login.Hide();
            checkStartAutomatico.Checked = true;
            btnStartGravacao.Enabled = false;
            MessageBox.Show("Marcando o Start Automático como verdadeiro," +
                " a gravação iniciará automaticamente após a leitura" +
                " do desenho e da matrícula!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void changeCheckBoxStartAutomaticToUnChecked(Login login) {
            login.Hide();
            checkStartAutomatico.Checked = false;
            btnStartGravacao.Enabled = true;
        }

        private void checkGravarMatriculaRepetida_Click(object sender, EventArgs e) {
            if (checkGravarMatriculaRepetida.Checked == false) {
                checkGravarMatriculaRepetida.Checked = false;
                checkGravarMatriculaRepetida.Enabled = true;
            }
            else {
                checkGravarMatriculaRepetida.Checked = false;
                abrirLogin(this, 5);
            }
        }

        public void changeCheckBoxGravarMatriculaRepetidaToChecked(Login login) {
            login.Hide();
            checkGravarMatriculaRepetida.Checked = true;
            MessageBox.Show("Marcando o Gravar Matrícula Repetida como verdadeiro," +
                " Você poderá gravar Matrículas de já foram gravadas!"
                , "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void changeCheckBoxGravarMatriculaRepetidaToUnChecked(Login login) {
            login.Hide();
            checkGravarMatriculaRepetida.Checked = false;
        }

        public void salvarDadosDeGravacao() {
            try {
                if (!dataReader.IsClosed) { dataReader.Close(); }

                string desenhomotor = tbLeituraDesenho.Text.ToString();
                string receitaMarkinbox = "";
                string numeroLinhas = "";
                string tipoCampoLinha01 = "";
                string tipoCampoLinha02 = "";
                string tipoCampoLinha03 = "";
                string tipoCampoLinha04 = "";
                string tipoCampoLinha05 = "";

                sqlConnection.Open();
                string strSql = $"SELECT * FROM receitas_mark WHERE nome_receita = '{tbLeituraReceita.Text}'";
                dataCommand.Connection = sqlConnection;
                dataCommand.CommandText = strSql;
                dataReader = dataCommand.ExecuteReader();


                if (dataReader.HasRows) {
                    while (dataReader.Read()) {
                        receitaMarkinbox = dataReader["nome_receita"].ToString();
                        numeroLinhas = dataReader["numero_receita"].ToString();
                        tipoCampoLinha01 = dataReader["tipo_linha_01"].ToString();
                        tipoCampoLinha02 = dataReader["tipo_linha_02"].ToString();
                        tipoCampoLinha03 = dataReader["tipo_linha_03"].ToString();
                        tipoCampoLinha04 = dataReader["tipo_linha_04"].ToString();
                        tipoCampoLinha05 = dataReader["tipo_linha_05"].ToString();
                    }
                }
                else {
                    return;
                }

                if (checkGravarMatriculaRepetida.Checked == false) {
                    if (tipoCampoLinha01 == "Matrícula") {
                        if (!dataReader.IsClosed) { dataReader.Close(); }

                        strSql = $"SELECT * FROM historico_gravacao WHERE linha_01 = '{tbLeituraLinha01.Text}'";
                        dataCommand.Connection = sqlConnection;
                        dataCommand.CommandText = strSql;
                        dataReader = dataCommand.ExecuteReader();


                        if (dataReader.HasRows) {
                            return;
                        }
                        else {
                            if (!dataReader.IsClosed) { dataReader.Close(); }

                            strSql = $"INSERT INTO historico_gravacao VALUES('{desenhomotor}', '{receitaMarkinbox}', " +
                                                                            $"'{numeroLinhas}', '{tipoCampoLinha01}', " +
                                                                            $"'{tbLeituraLinha01.Text}', '{tipoCampoLinha02}', " +
                                                                            $"'{tbLeituraLinha02.Text}', '{tipoCampoLinha03}', " +
                                                                            $"'{tbLeituraLinha03.Text}', '{tipoCampoLinha04}', " +
                                                                            $"'{tbLeituraLinha04.Text}', '{tipoCampoLinha05}', " +
                                                                            $"'{tbLeituraLinha05.Text}', GETDATE())";
                            dataCommand.Connection = sqlConnection;
                            dataCommand.CommandText = strSql;

                            dataCommand.ExecuteNonQuery();
                        }
                    }
                    else if (tipoCampoLinha02 == "Matrícula") {
                        if (!dataReader.IsClosed) { dataReader.Close(); }

                        strSql = $"SELECT * FROM historico_gravacao WHERE linha_02 = '{tbLeituraLinha02.Text}'";
                        dataCommand.Connection = sqlConnection;
                        dataCommand.CommandText = strSql;
                        dataReader = dataCommand.ExecuteReader();

                        if (dataReader.HasRows) {
                            return;
                        }
                        else {
                            if (!dataReader.IsClosed) { dataReader.Close(); }

                            strSql = $"INSERT INTO historico_gravacao VALUES('{desenhomotor}', '{receitaMarkinbox}', " +
                                                                            $"'{numeroLinhas}', '{tipoCampoLinha01}', " +
                                                                            $"'{tbLeituraLinha01.Text}', '{tipoCampoLinha02}', " +
                                                                            $"'{tbLeituraLinha02.Text}', '{tipoCampoLinha03}', " +
                                                                            $"'{tbLeituraLinha03.Text}', '{tipoCampoLinha04}', " +
                                                                            $"'{tbLeituraLinha04.Text}', '{tipoCampoLinha05}', " +
                                                                            $"'{tbLeituraLinha05.Text}', GETDATE())";
                            dataCommand.Connection = sqlConnection;
                            dataCommand.CommandText = strSql;

                            dataCommand.ExecuteNonQuery();
                        }
                    }
                    else if (tipoCampoLinha03 == "Matrícula") {
                        if (!dataReader.IsClosed) { dataReader.Close(); }

                        strSql = $"SELECT * FROM historico_gravacao WHERE linha_02 = '{tbLeituraLinha02.Text}'";
                        dataCommand.Connection = sqlConnection;
                        dataCommand.CommandText = strSql;
                        dataReader = dataCommand.ExecuteReader();

                        if (dataReader.HasRows) {
                            return;
                        }
                        else {
                            if (!dataReader.IsClosed) { dataReader.Close(); }

                            strSql = $"INSERT INTO historico_gravacao VALUES('{desenhomotor}', '{receitaMarkinbox}', " +
                                                                            $"'{numeroLinhas}', '{tipoCampoLinha01}', " +
                                                                            $"'{tbLeituraLinha01.Text}', '{tipoCampoLinha02}', " +
                                                                            $"'{tbLeituraLinha02.Text}', '{tipoCampoLinha03}', " +
                                                                            $"'{tbLeituraLinha03.Text}', '{tipoCampoLinha04}', " +
                                                                            $"'{tbLeituraLinha04.Text}', '{tipoCampoLinha05}', " +
                                                                            $"'{tbLeituraLinha05.Text}', GETDATE())";
                            dataCommand.Connection = sqlConnection;
                            dataCommand.CommandText = strSql;

                            dataCommand.ExecuteNonQuery();
                        }
                    }
                    else if (tipoCampoLinha04 == "Matrícula") {
                        if (!dataReader.IsClosed) { dataReader.Close(); }

                        strSql = $"SELECT * FROM historico_gravacao WHERE linha_02 = '{tbLeituraLinha02.Text}'";
                        dataCommand.Connection = sqlConnection;
                        dataCommand.CommandText = strSql;
                        dataReader = dataCommand.ExecuteReader();

                        if (dataReader.HasRows) {
                            return;
                        }
                        else {
                            if (!dataReader.IsClosed) { dataReader.Close(); }

                            strSql = $"INSERT INTO historico_gravacao VALUES('{desenhomotor}', '{receitaMarkinbox}', " +
                                                                            $"'{numeroLinhas}', '{tipoCampoLinha01}', " +
                                                                            $"'{tbLeituraLinha01.Text}', '{tipoCampoLinha02}', " +
                                                                            $"'{tbLeituraLinha02.Text}', '{tipoCampoLinha03}', " +
                                                                            $"'{tbLeituraLinha03.Text}', '{tipoCampoLinha04}', " +
                                                                            $"'{tbLeituraLinha04.Text}', '{tipoCampoLinha05}', " +
                                                                            $"'{tbLeituraLinha05.Text}', GETDATE())";
                            dataCommand.Connection = sqlConnection;
                            dataCommand.CommandText = strSql;

                            dataCommand.ExecuteNonQuery();
                        }
                    }
                    else if (tipoCampoLinha05 == "Matrícula") {
                        if (!dataReader.IsClosed) { dataReader.Close(); }

                        strSql = $"SELECT * FROM historico_gravacao WHERE linha_02 = '{tbLeituraLinha02.Text}'";
                        dataCommand.Connection = sqlConnection;
                        dataCommand.CommandText = strSql;
                        dataReader = dataCommand.ExecuteReader();

                        if (dataReader.HasRows) {
                            return;
                        }
                        else {
                            if (!dataReader.IsClosed) { dataReader.Close(); }

                            strSql = $"INSERT INTO historico_gravacao VALUES('{desenhomotor}', '{receitaMarkinbox}', " +
                                                                            $"'{numeroLinhas}', '{tipoCampoLinha01}', " +
                                                                            $"'{tbLeituraLinha01.Text}', '{tipoCampoLinha02}', " +
                                                                            $"'{tbLeituraLinha02.Text}', '{tipoCampoLinha03}', " +
                                                                            $"'{tbLeituraLinha03.Text}', '{tipoCampoLinha04}', " +
                                                                            $"'{tbLeituraLinha04.Text}', '{tipoCampoLinha05}', " +
                                                                            $"'{tbLeituraLinha05.Text}', GETDATE())";
                            dataCommand.Connection = sqlConnection;
                            dataCommand.CommandText = strSql;

                            dataCommand.ExecuteNonQuery();
                        }
                    }
                    else {

                    }
                }
                else {
                    if (!dataReader.IsClosed) { dataReader.Close(); }

                    strSql = $"INSERT INTO historico_gravacao VALUES('{desenhomotor}', '{receitaMarkinbox}', " +
                                                                    $"'{numeroLinhas}', '{tipoCampoLinha01}', " +
                                                                    $"'{tbLeituraLinha01.Text}', '{tipoCampoLinha02}', " +
                                                                    $"'{tbLeituraLinha02.Text}', '{tipoCampoLinha03}', " +
                                                                    $"'{tbLeituraLinha03.Text}', '{tipoCampoLinha04}', " +
                                                                    $"'{tbLeituraLinha04.Text}', '{tipoCampoLinha05}', " +
                                                                    $"'{tbLeituraLinha05.Text}', GETDATE())";
                    dataCommand.Connection = sqlConnection;
                    dataCommand.CommandText = strSql;

                    dataCommand.ExecuteNonQuery();
                }

                sqlConnection.Close();
                dataReader.Close();

            }
            catch (Exception ex) {

                MessageBox.Show("Ocorreu um erro ao salvar gravação no banco de dados!", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);

                sqlConnection.Close();
                dataReader.Close();
            }
        }

        private void btnTelaRelatorios_Click(object sender, EventArgs e) {
            try {
                Relatorios relatorios = new Relatorios();
                relatorios.ShowDialog();
            }
            catch {
                MessageBox.Show("Ocorreu um erro ao abrir a tela de relatórios!");
                return;
            }
        }

        private void btnZerarValores_Click(object sender, EventArgs e) {
            tbLeituraDesenho.ResetText();
            tbLeituraMatricula.ResetText();
            tbLeituraClassificacao.ResetText();
            tbLeituraReceita.ResetText();
            tbLeituraLinha01.ResetText();
            tbLeituraLinha02.ResetText();
            tbLeituraLinha03.ResetText();
            tbLeituraLinha04.ResetText();
            tbLeituraLinha05.ResetText();

            this.leituraDesenho = false;
            this.leituraMatricula = false;
            this.leituraClassificacao = false;

            tbLeituraDesenho.Focus();
        }
    }
}