namespace EmailApp
{
    partial class frmEmail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbProcenat = new System.Windows.Forms.Label();
            this.lbImePos = new System.Windows.Forms.Label();
            this.lbPoslati = new System.Windows.Forms.Label();
            this.lbZaSlanje = new System.Windows.Forms.Label();
            this.tbZaSlanje = new System.Windows.Forms.TextBox();
            this.tbPoslati = new System.Windows.Forms.TextBox();
            this.tbImePos = new System.Windows.Forms.TextBox();
            this.btnPrekiniSlanje = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tbSSL = new System.Windows.Forms.TextBox();
            this.lbSSL = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbSmtpPort = new System.Windows.Forms.TextBox();
            this.tbSmtp = new System.Windows.Forms.TextBox();
            this.lbAdresa = new System.Windows.Forms.Label();
            this.lbSmtpPort = new System.Windows.Forms.Label();
            this.lbSmtp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTekst = new System.Windows.Forms.TextBox();
            this.tbNaslov = new System.Windows.Forms.TextBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.tbMatBroj = new System.Windows.Forms.TextBox();
            this.lbMatBroj = new System.Windows.Forms.Label();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnUnos = new System.Windows.Forms.Button();
            this.tbJMBG = new System.Windows.Forms.TextBox();
            this.tbEmaill = new System.Windows.Forms.TextBox();
            this.tbImeR = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.lbJMBG = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbImeR = new System.Windows.Forms.Label();
            this.lbIme = new System.Windows.Forms.Label();
            this.lbPrezime = new System.Windows.Forms.Label();
            this.lvPodaci = new System.Windows.Forms.ListView();
            this.zaposleniDataSet = new EmailApp.ZaposleniDataSet();
            this.zaposleniDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.logTableAdapter = new EmailApp.ZaposleniDataSet8TableAdapters.LogTableAdapter();
            this.log1TableAdapter = new EmailApp.ZaposleniDataSet7TableAdapters.Log1TableAdapter();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(104, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1334, 691);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.OldLace;
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.lbProcenat);
            this.tabPage1.Controls.Add(this.lbImePos);
            this.tabPage1.Controls.Add(this.lbPoslati);
            this.tabPage1.Controls.Add(this.lbZaSlanje);
            this.tabPage1.Controls.Add(this.tbZaSlanje);
            this.tabPage1.Controls.Add(this.tbPoslati);
            this.tabPage1.Controls.Add(this.tbImePos);
            this.tabPage1.Controls.Add(this.btnPrekiniSlanje);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.tbSSL);
            this.tabPage1.Controls.Add(this.lbSSL);
            this.tabPage1.Controls.Add(this.tbAdresa);
            this.tabPage1.Controls.Add(this.tbSmtpPort);
            this.tabPage1.Controls.Add(this.tbSmtp);
            this.tabPage1.Controls.Add(this.lbAdresa);
            this.tabPage1.Controls.Add(this.lbSmtpPort);
            this.tabPage1.Controls.Add(this.lbSmtp);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbTekst);
            this.tabPage1.Controls.Add(this.tbNaslov);
            this.tabPage1.Controls.Add(this.btnPosalji);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1326, 662);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Slanje mailova";
            // 
            // lbProcenat
            // 
            this.lbProcenat.AutoSize = true;
            this.lbProcenat.BackColor = System.Drawing.Color.Transparent;
            this.lbProcenat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcenat.Location = new System.Drawing.Point(1256, 490);
            this.lbProcenat.Name = "lbProcenat";
            this.lbProcenat.Size = new System.Drawing.Size(0, 17);
            this.lbProcenat.TabIndex = 20;
            // 
            // lbImePos
            // 
            this.lbImePos.AutoSize = true;
            this.lbImePos.Location = new System.Drawing.Point(35, 194);
            this.lbImePos.Name = "lbImePos";
            this.lbImePos.Size = new System.Drawing.Size(101, 17);
            this.lbImePos.TabIndex = 19;
            this.lbImePos.Text = "Ime posaljioca:";
            // 
            // lbPoslati
            // 
            this.lbPoslati.AutoSize = true;
            this.lbPoslati.Location = new System.Drawing.Point(23, 56);
            this.lbPoslati.Name = "lbPoslati";
            this.lbPoslati.Size = new System.Drawing.Size(113, 17);
            this.lbPoslati.TabIndex = 19;
            this.lbPoslati.Text = "Putanja poslatih:";
            // 
            // lbZaSlanje
            // 
            this.lbZaSlanje.AutoSize = true;
            this.lbZaSlanje.Location = new System.Drawing.Point(16, 26);
            this.lbZaSlanje.Name = "lbZaSlanje";
            this.lbZaSlanje.Size = new System.Drawing.Size(120, 17);
            this.lbZaSlanje.TabIndex = 19;
            this.lbZaSlanje.Text = "Putanja za slanje:";
            // 
            // tbZaSlanje
            // 
            this.tbZaSlanje.Location = new System.Drawing.Point(149, 23);
            this.tbZaSlanje.Name = "tbZaSlanje";
            this.tbZaSlanje.Size = new System.Drawing.Size(373, 22);
            this.tbZaSlanje.TabIndex = 18;
            this.tbZaSlanje.Text = " C:\\\\Users\\\\Ogi\\\\Desktop\\\\Listici";
            // 
            // tbPoslati
            // 
            this.tbPoslati.Location = new System.Drawing.Point(149, 51);
            this.tbPoslati.Name = "tbPoslati";
            this.tbPoslati.Size = new System.Drawing.Size(373, 22);
            this.tbPoslati.TabIndex = 18;
            this.tbPoslati.Text = "C:\\\\Users\\\\Ogi\\\\Desktop\\\\Poslati";
            // 
            // tbImePos
            // 
            this.tbImePos.Location = new System.Drawing.Point(149, 191);
            this.tbImePos.Name = "tbImePos";
            this.tbImePos.Size = new System.Drawing.Size(373, 22);
            this.tbImePos.TabIndex = 18;
            // 
            // btnPrekiniSlanje
            // 
            this.btnPrekiniSlanje.BackColor = System.Drawing.Color.Red;
            this.btnPrekiniSlanje.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrekiniSlanje.ForeColor = System.Drawing.Color.Gray;
            this.btnPrekiniSlanje.Location = new System.Drawing.Point(552, 599);
            this.btnPrekiniSlanje.Name = "btnPrekiniSlanje";
            this.btnPrekiniSlanje.Size = new System.Drawing.Size(188, 49);
            this.btnPrekiniSlanje.TabIndex = 17;
            this.btnPrekiniSlanje.Text = "Prekini slanje";
            this.btnPrekiniSlanje.UseVisualStyleBackColor = false;
            this.btnPrekiniSlanje.Click += new System.EventHandler(this.btnPrekiniSlanje_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(552, 448);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(745, 39);
            this.progressBar1.TabIndex = 16;
            // 
            // tbSSL
            // 
            this.tbSSL.Location = new System.Drawing.Point(149, 135);
            this.tbSSL.Name = "tbSSL";
            this.tbSSL.Size = new System.Drawing.Size(373, 22);
            this.tbSSL.TabIndex = 15;
            this.tbSSL.Text = "true";
            // 
            // lbSSL
            // 
            this.lbSSL.AutoSize = true;
            this.lbSSL.Location = new System.Drawing.Point(98, 140);
            this.lbSSL.Name = "lbSSL";
            this.lbSSL.Size = new System.Drawing.Size(38, 17);
            this.lbSSL.TabIndex = 14;
            this.lbSSL.Text = "SSL:";
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(149, 163);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(373, 22);
            this.tbAdresa.TabIndex = 13;
            this.tbAdresa.Text = "\r\n";
            // 
            // tbSmtpPort
            // 
            this.tbSmtpPort.Location = new System.Drawing.Point(149, 107);
            this.tbSmtpPort.Name = "tbSmtpPort";
            this.tbSmtpPort.Size = new System.Drawing.Size(373, 22);
            this.tbSmtpPort.TabIndex = 12;
            this.tbSmtpPort.Text = "587";
            // 
            // tbSmtp
            // 
            this.tbSmtp.Location = new System.Drawing.Point(149, 79);
            this.tbSmtp.Name = "tbSmtp";
            this.tbSmtp.Size = new System.Drawing.Size(373, 22);
            this.tbSmtp.TabIndex = 11;
            this.tbSmtp.Text = "smtp.gmail.com\r\n";
            // 
            // lbAdresa
            // 
            this.lbAdresa.AutoSize = true;
            this.lbAdresa.Location = new System.Drawing.Point(42, 168);
            this.lbAdresa.Name = "lbAdresa";
            this.lbAdresa.Size = new System.Drawing.Size(94, 17);
            this.lbAdresa.TabIndex = 10;
            this.lbAdresa.Text = "Email adresa:";
            // 
            // lbSmtpPort
            // 
            this.lbSmtpPort.AutoSize = true;
            this.lbSmtpPort.Location = new System.Drawing.Point(57, 112);
            this.lbSmtpPort.Name = "lbSmtpPort";
            this.lbSmtpPort.Size = new System.Drawing.Size(79, 17);
            this.lbSmtpPort.TabIndex = 9;
            this.lbSmtpPort.Text = "SMTP port:";
            // 
            // lbSmtp
            // 
            this.lbSmtp.AutoSize = true;
            this.lbSmtp.Location = new System.Drawing.Point(86, 84);
            this.lbSmtp.Name = "lbSmtp";
            this.lbSmtp.Size = new System.Drawing.Size(50, 17);
            this.lbSmtp.TabIndex = 8;
            this.lbSmtp.Text = "SMTP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tekst:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naslov:";
            // 
            // tbTekst
            // 
            this.tbTekst.Location = new System.Drawing.Point(149, 252);
            this.tbTekst.Multiline = true;
            this.tbTekst.Name = "tbTekst";
            this.tbTekst.Size = new System.Drawing.Size(373, 401);
            this.tbTekst.TabIndex = 5;
            this.tbTekst.Text = "Postovani,\r\n\r\nSrdacno,\r\nMika Mikić\r\n";
            // 
            // tbNaslov
            // 
            this.tbNaslov.Location = new System.Drawing.Point(149, 219);
            this.tbNaslov.Name = "tbNaslov";
            this.tbNaslov.Size = new System.Drawing.Size(373, 22);
            this.tbNaslov.TabIndex = 4;
            // 
            // btnPosalji
            // 
            this.btnPosalji.BackColor = System.Drawing.Color.Green;
            this.btnPosalji.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosalji.Location = new System.Drawing.Point(1109, 597);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(188, 51);
            this.btnPosalji.TabIndex = 1;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = false;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.OldLace;
            this.tabPage2.Controls.Add(this.btnObrisi);
            this.tabPage2.Controls.Add(this.tbMatBroj);
            this.tabPage2.Controls.Add(this.lbMatBroj);
            this.tabPage2.Controls.Add(this.btnIzmeni);
            this.tabPage2.Controls.Add(this.btnUnos);
            this.tabPage2.Controls.Add(this.tbJMBG);
            this.tabPage2.Controls.Add(this.tbEmaill);
            this.tabPage2.Controls.Add(this.tbImeR);
            this.tabPage2.Controls.Add(this.tbIme);
            this.tabPage2.Controls.Add(this.tbPrezime);
            this.tabPage2.Controls.Add(this.lbJMBG);
            this.tabPage2.Controls.Add(this.lbEmail);
            this.tabPage2.Controls.Add(this.lbImeR);
            this.tabPage2.Controls.Add(this.lbIme);
            this.tabPage2.Controls.Add(this.lbPrezime);
            this.tabPage2.Controls.Add(this.lvPodaci);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1326, 662);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Baza";
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.LightGray;
            this.btnObrisi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnObrisi.Location = new System.Drawing.Point(1154, 599);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(153, 36);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // tbMatBroj
            // 
            this.tbMatBroj.Location = new System.Drawing.Point(1081, 24);
            this.tbMatBroj.Name = "tbMatBroj";
            this.tbMatBroj.Size = new System.Drawing.Size(226, 22);
            this.tbMatBroj.TabIndex = 7;
            // 
            // lbMatBroj
            // 
            this.lbMatBroj.AutoSize = true;
            this.lbMatBroj.Location = new System.Drawing.Point(983, 24);
            this.lbMatBroj.Name = "lbMatBroj";
            this.lbMatBroj.Size = new System.Drawing.Size(84, 17);
            this.lbMatBroj.TabIndex = 6;
            this.lbMatBroj.Text = "Maticni broj:";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.LightGray;
            this.btnIzmeni.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnIzmeni.Location = new System.Drawing.Point(1154, 541);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(153, 33);
            this.btnIzmeni.TabIndex = 5;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnUnos
            // 
            this.btnUnos.BackColor = System.Drawing.Color.LightGray;
            this.btnUnos.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUnos.Location = new System.Drawing.Point(1154, 482);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(153, 32);
            this.btnUnos.TabIndex = 4;
            this.btnUnos.Text = "Dodaj";
            this.btnUnos.UseVisualStyleBackColor = false;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // tbJMBG
            // 
            this.tbJMBG.Location = new System.Drawing.Point(1081, 242);
            this.tbJMBG.Name = "tbJMBG";
            this.tbJMBG.Size = new System.Drawing.Size(226, 22);
            this.tbJMBG.TabIndex = 3;
            // 
            // tbEmaill
            // 
            this.tbEmaill.Location = new System.Drawing.Point(1081, 194);
            this.tbEmaill.Name = "tbEmaill";
            this.tbEmaill.Size = new System.Drawing.Size(226, 22);
            this.tbEmaill.TabIndex = 3;
            // 
            // tbImeR
            // 
            this.tbImeR.Location = new System.Drawing.Point(1081, 148);
            this.tbImeR.Name = "tbImeR";
            this.tbImeR.Size = new System.Drawing.Size(226, 22);
            this.tbImeR.TabIndex = 3;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(1081, 104);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(226, 22);
            this.tbIme.TabIndex = 3;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(1081, 61);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(226, 22);
            this.tbPrezime.TabIndex = 3;
            // 
            // lbJMBG
            // 
            this.lbJMBG.AutoSize = true;
            this.lbJMBG.Location = new System.Drawing.Point(983, 247);
            this.lbJMBG.Name = "lbJMBG";
            this.lbJMBG.Size = new System.Drawing.Size(50, 17);
            this.lbJMBG.TabIndex = 2;
            this.lbJMBG.Text = "JMBG:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(983, 199);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 17);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "EMail:";
            // 
            // lbImeR
            // 
            this.lbImeR.AutoSize = true;
            this.lbImeR.Location = new System.Drawing.Point(983, 148);
            this.lbImeR.Name = "lbImeR";
            this.lbImeR.Size = new System.Drawing.Size(88, 17);
            this.lbImeR.TabIndex = 2;
            this.lbImeR.Text = "Ime roditelja:";
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Location = new System.Drawing.Point(983, 104);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(34, 17);
            this.lbIme.TabIndex = 2;
            this.lbIme.Text = "Ime:";
            // 
            // lbPrezime
            // 
            this.lbPrezime.AutoSize = true;
            this.lbPrezime.Location = new System.Drawing.Point(983, 61);
            this.lbPrezime.Name = "lbPrezime";
            this.lbPrezime.Size = new System.Drawing.Size(63, 17);
            this.lbPrezime.TabIndex = 1;
            this.lbPrezime.Text = "Prezime:";
            // 
            // lvPodaci
            // 
            this.lvPodaci.HideSelection = false;
            this.lvPodaci.Location = new System.Drawing.Point(0, 0);
            this.lvPodaci.Name = "lvPodaci";
            this.lvPodaci.Size = new System.Drawing.Size(933, 662);
            this.lvPodaci.TabIndex = 0;
            this.lvPodaci.UseCompatibleStateImageBehavior = false;
            // 
            // zaposleniDataSet
            // 
            this.zaposleniDataSet.DataSetName = "ZaposleniDataSet";
            this.zaposleniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zaposleniDataSetBindingSource
            // 
            this.zaposleniDataSetBindingSource.DataSource = this.zaposleniDataSet;
            this.zaposleniDataSetBindingSource.Position = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Khaki;
            this.btnLogOut.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(12, 589);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(86, 37);
            this.btnLogOut.TabIndex = 18;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.BackColor = System.Drawing.Color.Khaki;
            this.btnIzadji.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzadji.ForeColor = System.Drawing.Color.Black;
            this.btnIzadji.Location = new System.Drawing.Point(12, 641);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(86, 37);
            this.btnIzadji.TabIndex = 19;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = false;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Khaki;
            this.btnLog.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(12, 12);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(86, 37);
            this.btnLog.TabIndex = 20;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // logTableAdapter
            // 
            this.logTableAdapter.ClearBeforeFill = true;
            // 
            // log1TableAdapter
            // 
            this.log1TableAdapter.ClearBeforeFill = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(552, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(745, 410);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // frmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1439, 690);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTekst;
        private System.Windows.Forms.TextBox tbNaslov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvPodaci;
        private System.Windows.Forms.Label lbPrezime;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbImeR;
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.Label lbJMBG;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.TextBox tbJMBG;
        private System.Windows.Forms.TextBox tbEmaill;
        private System.Windows.Forms.TextBox tbImeR;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.TextBox tbMatBroj;
        private System.Windows.Forms.Label lbMatBroj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.BindingSource zaposleniDataSetBindingSource;
        private ZaposleniDataSet zaposleniDataSet;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbSmtpPort;
        private System.Windows.Forms.TextBox tbSmtp;
        private System.Windows.Forms.Label lbAdresa;
        private System.Windows.Forms.Label lbSmtpPort;
        private System.Windows.Forms.Label lbSmtp;
        private System.Windows.Forms.TextBox tbSSL;
        private System.Windows.Forms.Label lbSSL;
        private System.Windows.Forms.Button btnPrekiniSlanje;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Label lbImePos;
        private System.Windows.Forms.Label lbPoslati;
        private System.Windows.Forms.Label lbZaSlanje;
        private System.Windows.Forms.TextBox tbZaSlanje;
        private System.Windows.Forms.TextBox tbPoslati;
        private System.Windows.Forms.TextBox tbImePos;
        private System.Windows.Forms.Label lbProcenat;
        private System.Windows.Forms.Button btnLog;
        private ZaposleniDataSet8TableAdapters.LogTableAdapter logTableAdapter;
        private ZaposleniDataSet7TableAdapters.Log1TableAdapter log1TableAdapter;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

