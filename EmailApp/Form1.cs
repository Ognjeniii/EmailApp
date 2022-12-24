using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace EmailApp
{
    public partial class frmEmail : Form
    {

       
        public frmEmail()
        {
            InitializeComponent();
        }
        frmLogin f1;
        public frmEmail(frmLogin frm1)
        {
            InitializeComponent();
            this.f1 = frm1;
        }

        static bool mailSent = false;
        bool kliknuto = false;
        string email;
        string pass;
        List<string> listaNeuspesnihStringova = new List<string>();
        string mika = "generatedPasswordFromGmail1"; // less secure apss
        string pera = "generatedPasswordFromGmail2"; // less secure apps
        string outPutPath = "stringPath"; // path for folder where pdf files goes if they are sent
        SqlConnection con = new SqlConnection("connectionString"); // connection with dataBase
        SqlCommand cmd1;
        public frmLogin form2;
        public string Value { get; set; }
        
        // method that complements listView
        private void Dopuni()
        {
            DataTable dt;
            SqlDataAdapter da;
            DataSet ds;

            con.Open();
            cmd1 = new SqlCommand("Select * from Zaposleni", con);
            da = new SqlDataAdapter(cmd1);
            ds = new DataSet();
            da.Fill(ds, "Zaposleni");


            dt = ds.Tables["Zaposleni"];
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                lvPodaci.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                lvPodaci.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                lvPodaci.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                lvPodaci.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                lvPodaci.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                lvPodaci.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                lvPodaci.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
            }

            con.Close();
        }
        
        // method for "refreshing" listView after any action
        private void Ucitaj()
        {
            DataTable dt;
            SqlDataAdapter da;
            DataSet ds;

            lvPodaci.Columns.Add("MaticniBroj", 70);
            lvPodaci.Columns.Add("Prezime", 70, HorizontalAlignment.Center);
            lvPodaci.Columns.Add("Ime", 70, HorizontalAlignment.Center);
            lvPodaci.Columns.Add("ImeRoditelja", 100, HorizontalAlignment.Center);
            lvPodaci.Columns.Add("Email", 170, HorizontalAlignment.Center);
            lvPodaci.Columns.Add("JMBG", 100, HorizontalAlignment.Center);
            lvPodaci.Columns.Add("Datum", 100, HorizontalAlignment.Center);
            lvPodaci.View = View.Details;

            con.Open();
            cmd1 = new SqlCommand("Select * from Zaposleni", con);
            da = new SqlDataAdapter(cmd1);
            ds = new DataSet();
            da.Fill(ds, "Zaposleni");
            

            dt = ds.Tables["Zaposleni"];
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                lvPodaci.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                lvPodaci.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                lvPodaci.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                lvPodaci.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                lvPodaci.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                lvPodaci.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                lvPodaci.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
            }

            con.Close();
        }
        
        
        // the method by which we enter feedback into the database.
        private void UpisiULog()
        {
            var br = lvPodaci.Items.Count;
            DirectoryInfo info = new DirectoryInfo("stringPath"); // path to folder with pdf files
            DirectoryInfo info2 = new DirectoryInfo("stringPath" + DateTime.Now.ToString("yyyy_MM_dd") + @"\"); // path to folder where pdf files goes if they are sent
            var files2 = info2.GetFiles();
            List<string> listaStringovaUPoslatim = new List<string>();
            List<int> listaIntovaUPoslatim = new List<int>();
            int brojac = 0;
            foreach (var infoo in files2)
            {
                listaStringovaUPoslatim.Add(infoo.FullName);
                var fn = infoo.FullName.ToString();
                var a = infoo.ToString();
                var isecen = a.Substring(20, 4);
                var intovi = int.Parse(isecen);
                listaIntovaUPoslatim.Add(intovi);
                brojac++;
            }
            var files = info.GetFiles();
            List<string> listaStringova = new List<string>();
            List<int> listaIntova = new List<int>();
            int k = 0;
            foreach (var infoo in files)
            {
                listaStringova.Add(infoo.FullName);
                var fn = infoo.FullName.ToString();
                var a = infoo.ToString();
                var isecen = a.Substring(20, 4);
                var intovi = int.Parse(isecen);
                listaIntova.Add(intovi);
                k++;
            }


            // for the files which are sent successfully
            List<int> listaBazaIntovi = new List<int>();
            List<string> listaBazaStringovi = new List<string>();
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < br; j++)
                {
                    if (listaIntova[i] == int.Parse(lvPodaci.Items[j].SubItems[0].Text))
                    {
                        listaBazaIntovi.Add(int.Parse(lvPodaci.Items[j].SubItems[0].Text));
                        listaBazaStringovi.Add(files[i].FullName);
                    }
                }
            }
            SqlCommand cmd = new SqlCommand("INSERT INTO Log1 VALUES(@MaticniBroj, @PdfFajl, @StatusPdfa, @StatusMaila, getdate())", con);
            con.Open();
            for (int i = 0; i < brojac; i++)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@MaticniBroj", listaIntovaUPoslatim[i]);
                cmd.Parameters.AddWithValue("@PdfFajl", listaStringovaUPoslatim[i]);
                cmd.Parameters.AddWithValue("@StatusPdfa", "Premesten");
                cmd.Parameters.AddWithValue("@StatusMaila", "Poslat");
                cmd.ExecuteNonQuery();
            }

            // for the files which are not sent successfully, no email adress in database
            List<int> listaNeuspenihIntova = new List<int>();
            listaNeuspenihIntova = listaIntova.Except(listaBazaIntovi).ToList();
            listaNeuspesnihStringova = listaStringova.Except(listaBazaStringovi).ToList();

            string greskaPoruka = "Greska - Nije poslat, zaposleni ne postoji";

            SqlCommand cmd1 = new SqlCommand("INSERT INTO Log1 VALUES(@MaticniBroj, @PdfFajl, @StatusPdfa, @StatusMaila, getdate())", con);
            for (int i = 0; i < listaNeuspenihIntova.Count; i++)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@MaticniBroj", listaNeuspenihIntova[i]);
                cmd.Parameters.AddWithValue("@PdfFajl", listaNeuspesnihStringova[i]);
                cmd.Parameters.AddWithValue("@StatusPdfa", "Nije premesten");
                cmd.Parameters.AddWithValue("@StatusMaila", greskaPoruka);
                cmd.ExecuteNonQuery();
            }

            con.Close();
        }
        
        // if "klinknuto" is true, in other method, we are calling sendAsyncCancel
        private void btnPrekiniSlanje_Click(object sender, EventArgs e)
        {
            kliknuto = true;
        }
        
        // form load
        private void Form1_Load(object sender, EventArgs e)
        {            
            tbAdresa.Text = f1.tbUser.Text;
            Ucitaj();
        }
        
        // the method which we fill the progress bar if all files are sent successfully
        private void ProgressBar()
        {
            DirectoryInfo info = new DirectoryInfo("stringPath"); // path to folder where pdf files are
            var files = info.GetFiles();
            int brojListica = 0;
            List<int> listaIntova = new List<int>();
            foreach (var item in files)
            {
                var isecen = item.ToString().Substring(20, 4);
                var intovi = int.Parse(isecen);
                listaIntova.Add(intovi);
            }
            foreach(var item in listaIntova)
            {
                for(int i = 0; i < lvPodaci.Items.Count; i++)
                {
                    if(item == int.Parse(lvPodaci.Items[i].SubItems[0].Text))
                    {
                        brojListica++;
                    }
                }
            }
            progressBar1.Maximum = brojListica;
            progressBar1.Step = 1;
            progressBar1.PerformStep();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                lbProcenat.Text = "100%";
            }
        }

        // the method for call back message
        private static void SendCompletedCallBack(object sender, AsyncCompletedEventArgs e)
        {
            //var token = (string)e.UserState;
            if (e.Cancelled)
            {
                MessageBox.Show("Slanje je prekinuto!");
            }
            else if (e.Error != null)
            {
                MessageBox.Show(e.Error.ToString());
            }
            else
            {
                //MessageBox.Show("Poruka poslata!");
            }
            mailSent = true;
        }

        // the method for initialization message
        private MailMessage InitialiseMessage(string emailTo, string fileName)
        {
            if (tbAdresa.Text == "emailAdress1")
            {
                email = "emailAdress1";
                pass = pera;
            }
            else if (tbAdresa.Text == "emailAdress2")
            {
                email = "emailAdress2";
                pass = mika;
            }

            MailMessage msg = new MailMessage(email, emailTo);
            Attachment att = new Attachment(fileName);
            msg.Attachments.Add(att);
            msg.Body = tbTekst.Text.ToString();
            msg.BodyEncoding = Encoding.UTF8;

            msg.Subject = tbNaslov.Text.ToString();
            msg.SubjectEncoding = Encoding.UTF8;
            
            return msg;
        }
        
        // method for sending a mail
        private async Task SendMail(MailMessage msg)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("stringPath"); // path for folder where the pdf files are
            int brojListica = 0;
            var files = directoryInfo.GetFiles();
            List<int> listaIntova = new List<int>();
            foreach(var item in files)
            {
                var isecen = item.ToString().Substring(20, 4);
                var intovi = int.Parse(isecen);
                listaIntova.Add(intovi);
                brojListica++;
            }

            var client = new SmtpClient(tbSmtp.Text)
            {
                Port = int.Parse(tbSmtpPort.Text),
                Credentials = new NetworkCredential(email, pass),
                EnableSsl = bool.Parse(tbSSL.Text)
            };
            
            using (client)
            { 
                if(kliknuto == true)
                {
                    client.SendAsyncCancel();
                }
                else
                {
                    await client.SendMailAsync(msg);
                }
                client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallBack);
            }
        }
        
        // the method for changing color of the text
        private void FormatText(RichTextBox richTextBox, string p, Color textColor, Color highColor)
        {
            string[] lines = richTextBox.Lines;
            richTextBox.Text = "";
            foreach(string line in lines)
            {
                richTextBox.SelectionColor = line.StartsWith(p) ? highColor : textColor;
                richTextBox.AppendText(line + "\n");
            }
        }

        // the method for calling other methods...Sending mails, moving pdf files to another folder, progres bar, database fill...
        private async void btnPosalji_Click(object sender, EventArgs e)
        {
            btnUnos.Enabled = false;
            btnIzmeni.Enabled = false;
            btnObrisi.Enabled = false;
            
            if (tbAdresa.Text == "emailAdress1")
            {
                email = "emailAdress1";
                pass = pera;
            }
            else if (tbAdresa.Text == "emailAdress2")
            {
                email = "emailAdress2";
                pass = mika;
            }

            var br = lvPodaci.Items.Count;

            DirectoryInfo info = new DirectoryInfo("stringPath"); // path for folder where pdf files are
            var files = info.GetFiles();
            int ukupanBrListica = 0;
            List<int> lista = new List<int>();
            int k = 0;
            foreach (var infoo in files)
            {
                var isecen = infoo.ToString().Substring(20, 4);
                var intovi = int.Parse(isecen);
                lista.Add(intovi);
                k++;
                ukupanBrListica++;
            }
            
            string putanja2 = tbPoslati.Text;
            string putanja1 = tbZaSlanje.Text;
            
            for (int i = 0; i < files.Length; i++)
            {   
                SqlCommand cmd = new SqlCommand("SELECT Email FROM Zaposleni WHERE MaticniBroj = '" + lista[i] + "'", con);
                con.Open();
                var emailZaSlanje = cmd.ExecuteScalar();
                con.Close();
                richTextBox1.Text = $"Broj pdf fajlova za slanje: {ukupanBrListica}\r\n\r\n";
                try
                {
                    if(emailZaSlanje == null)
                    {
                        continue;                       
                    }
                    else
                    {
                        
                        MailMessage msg = InitialiseMessage(emailZaSlanje.ToString(), files[i].FullName.ToString());
                        await Task.Run(() => SendMail(msg));
                        msg.Dispose();
                    }
                    ProgressBar();
                    emailZaSlanje = "";
                    
                    try
                    {
                        if (kliknuto == false)
                        {
                            MovePdf(files[i].ToString());
                        }
                        else { }
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.ToString());
                    } 

                    
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                    //continue;
                }
            }

            UpisiULog();

            if (kliknuto != true)
            { 
                for (int i = 0; i < k; i++)
                {
                    for (int j = 0; j < br; j++)
                    {
                        if (lista[i] == int.Parse(lvPodaci.Items[j].SubItems[0].Text))
                        {
                            if ((int)DeliveryNotificationOptions.OnSuccess == 1)
                            {
                                richTextBox1.Text += $"\r\nPoslat (Mail poslat) maticni broj:{int.Parse(lvPodaci.Items[j].SubItems[0].Text)}\r\n" +
                               $"Premesten fajl {files[i]}\r\n\r\n";
                            }
                        }
                    }
                }

                foreach(var item in listaNeuspesnihStringova)
                {
                    richTextBox1.Text += $"\r\nNe postoji mail adresa za listic: {item.Substring(29)}, mail nije poslat." +
                       $" Fajl nije premesten u folder za poslate\r\n";
                }

                FormatText(richTextBox1, "Ne", Color.Black, Color.Red);
            }
            else
            {
                richTextBox1.Text += "Slanje je prekinuto...";
            }

            btnUnos.Enabled = true;
            btnIzmeni.Enabled = true;
            btnObrisi.Enabled = true;
        }
        
        // the method for moving files in another folder
        private void MovePdf(string fileName)
        {
            string sourceFolder = "stringPath"; // path for folder where pdf files are
            string destinationFolder = outPutPath + DateTime.Now.ToString("yyyy_MM_dd") + @"\";
            string nameOfFile = fileName;
            string sourceFile = Path.Combine(sourceFolder, nameOfFile);
            string destinationFile = Path.Combine(destinationFolder, nameOfFile);
            DirectoryInfo directoryInfo = Directory.CreateDirectory(destinationFolder);
            if (File.Exists(destinationFolder))
            {
                File.Delete(destinationFolder);
                File.Move(sourceFile, destinationFile);

            }
            else
            {
            File.Move(sourceFile, destinationFile);
            }
        }
        
        // method for entering new people into the database
        private void btnUnos_Click(object sender, EventArgs e)
        {
            
            if (tbPrezime.Text == "" || tbIme.Text == "" || tbImeR.Text == "" || tbEmaill.Text == "" || tbJMBG.Text == "")
            {
                MessageBox.Show("Morate da unesete sve podatke!");
            }
            else if(tbJMBG.Text.Length > 13)
            {
                MessageBox.Show("JMBG ima vise od 13 cifara!");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Zaposleni VALUES (@Prezime, @Ime, @ImeRoditelja, @Email, @JMBG, getdate())", con);
                con.Open();

                cmd.Parameters.AddWithValue("@Prezime", tbPrezime.Text);
                cmd.Parameters.AddWithValue("@Ime", tbIme.Text);
                cmd.Parameters.AddWithValue("@ImeRoditelja", tbImeR.Text);
                cmd.Parameters.AddWithValue("@Email", tbEmaill.Text);
                cmd.Parameters.AddWithValue("@JMBG", tbJMBG.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uspesno dodato!");
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }

                con.Close();

                tbPrezime.Text = "";
                tbIme.Text = "";
                tbImeR.Text = "";
                tbEmaill.Text = "";
                tbJMBG.Text = "";

                lvPodaci.Items.RemoveAt(0);
                lvPodaci.Items.Clear();

                Dopuni();

                
            }
        }
        
        // method for changing people's informations in a database
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (tbMatBroj.Text == "" || richTextBox1.Text == "" || tbIme.Text == "" || tbPrezime.Text == "" || tbImeR.Text == "" || tbJMBG.Text == "")
            {
                MessageBox.Show("Morate uneti sva polja!!!");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Zaposleni set Prezime = '" + tbPrezime.Text + "', Ime = '" + tbIme.Text + "', ImeRoditelja = '" + tbImeR.Text + "'" +
                    ", Email = '" + tbEmaill.Text + "', JMBG = '" + tbJMBG.Text + "' where MaticniBroj = '" + int.Parse(tbMatBroj.Text) + "'", con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uspesno izmenjeno!");
                    tbEmaill.Text = "";
                    tbIme.Text = "";
                    tbPrezime.Text = "";
                    tbMatBroj.Text = "";
                    tbImeR.Text = "";
                    tbJMBG.Text = "";
                }
                catch (Exception ee) { MessageBox.Show(ee.ToString()); }
                con.Close();

                lvPodaci.Items.RemoveAt(0);
                lvPodaci.Items.Clear();
                Dopuni();
            }
        }

        // method for deleting people from database
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (tbMatBroj.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete Zaposleni where MaticniBroj = '" + int.Parse(tbMatBroj.Text) + "'", con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Uspesno obrisano!");
                    tbMatBroj.Text = "";

                    lvPodaci.Items.RemoveAt(0);
                    lvPodaci.Items.Clear();
                    con.Close();
                    Dopuni();

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Unesite matični broj u polje!");
                con.Close();
            }
        }

        // log out method
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //btnLogOut.BackColor = Color.FromArgb(255, 0, 0);
            //frmEmail frm = new frmEmail();
            this.Close();
            //frm.Show();
        }

        // exit application method
        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        // method for showing the log database, database with feedback
        private void btnLog_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(@"C:\Users\Ogi\Desktop\Listici\");

            var files = info.GetFiles();

            List<int> lista = new List<int>();
            int k = 0;
            foreach (var infoo in files)
            {
                var fn = infoo.FullName.ToString();
                var a = infoo.ToString();
                var isecen = a.Substring(20, 4);
                var intovi = int.Parse(isecen);
                lista.Add(intovi);
                k++;
            }
            
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Email from Zaposleni where MaticniBroj =" + 44, con);
            SqlDataReader poruka = cmd.ExecuteReader();
            MessageBox.Show(poruka.ToString());
            con.Close();
            
        }
    }
}
