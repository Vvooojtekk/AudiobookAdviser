using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;


namespace AudiobookAdviser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string [] dirs;
        
        string[] lektorzy = new string[5];
        string[] autorzy = new string[5];
        string[] gatunki = new string[5];
        string[] epoki = new string[5];

        int minuty;
        int sekundy;
        int summinuty=0;
        int sumsekundy=0;
        int sredniamin;
        int sredniasek;

        string srednia;

        int licznik=0;
        int licznik2 = 0;
        
        private void Open_Click(object sender, EventArgs e)
        {
            
        }
        
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            dirs = Directory.GetFiles(Directory.GetCurrentDirectory()+@"\audio\", "*"); 
            foreach (string dir in dirs)
            {
            listBox1.Items.Add(dir.Substring(dir.LastIndexOf('\\')+1 , dir.Length - dir.LastIndexOf('\\') - 1) );
            }
            
       }



        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.URL = dirs[listBox1.SelectedIndex];


            XmlDocument doc = new XmlDocument();
            doc.Load(Directory.GetCurrentDirectory() + @"\baza\baza_audiobook.xml");


            XmlNode root = doc.DocumentElement;

            autor.Text = root.SelectSingleNode("//abook[@nazwa='" + listBox1.SelectedItem.ToString() + "']/autor/text()").OuterXml;
            tytul.Text = root.SelectSingleNode("//abook[@nazwa='" + listBox1.SelectedItem.ToString() + "']/tytul/text()").OuterXml;
            czyta.Text = root.SelectSingleNode("//abook[@nazwa='" + listBox1.SelectedItem.ToString() + "']/lektor/text()").OuterXml;
            gatunek.Text = root.SelectSingleNode("//abook[@nazwa='" + listBox1.SelectedItem.ToString() + "']/gatunek/text()").OuterXml;
            epoka.Text = root.SelectSingleNode("//abook[@nazwa='" + listBox1.SelectedItem.ToString() + "']/epoka/text()").OuterXml;
            czas.Text = root.SelectSingleNode("//abook[@nazwa='" + listBox1.SelectedItem.ToString() + "']/czas/text()").OuterXml;


            lektorzy[licznik] = czyta.Text;
            autorzy[licznik] = autor.Text;
            gatunki[licznik] = gatunek.Text;
            epoki[licznik] = epoka.Text;

            minuty = int.Parse(czas.Text.Substring(0, czas.Text.IndexOf(':')));
            sekundy = int.Parse(czas.Text.Substring(czas.Text.IndexOf(':') + 1, czas.Text.Length - czas.Text.IndexOf(':') - 1));


            lektor.Text = Dominanta(lektorzy);
            aut.Text = Dominanta(autorzy);
            gat.Text = Dominanta(gatunki);
            epo.Text = Dominanta(epoki);



            licznik++;
            if (licznik == 5)
                licznik = 0;

            licznik2++;
            summinuty = summinuty + minuty;
            sumsekundy = sumsekundy + sekundy;
            sredniamin = ((summinuty * 60 + sumsekundy) / licznik2 / 60);
            sredniasek = ((summinuty * 60 + sumsekundy) / licznik2 % 60);

            srednia = sredniamin.ToString() + ":" + sredniasek.ToString();
            if (sredniasek < 10)
                srednia = sredniamin.ToString() + ":0" + sredniasek.ToString();
            sre.Text = srednia;

            if (lektor.Text != "" && aut.Text != "" && gat.Text != "" && epo.Text != "")
            {
                pro.Enabled = true;
                propozycjaToolStripMenuItem.Enabled=true;
            }
        }
        
        private void pro_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string[] propsautor = new string[50];
            string[] propsepoka = new string[50];
            string[] propslektor = new string[50];
            string[] propsgatunek = new string[50];
            int x=0;
            int przelacznik = 0;
            
            XmlDocument doc = new XmlDocument();
            doc.Load(Directory.GetCurrentDirectory() + @"\baza\baza_audiobook.xml");


            
            XmlElement root = doc.DocumentElement;


            XmlNodeList nodeList;

            
            nodeList = root.SelectNodes("//abook[autor='" + aut.Text + "']/nazwa/text()");

            foreach (XmlNode isbn in nodeList)
            {
                propsautor[x] = isbn.OuterXml;
                x++;
            }
            x = 0;
            nodeList = root.SelectNodes("//abook[epoka='" + epo.Text + "']/nazwa/text()");

            foreach (XmlNode isbn in nodeList)
            {
                propsepoka[x] = isbn.OuterXml;
                x++;
            }
            x = 0;
            nodeList = root.SelectNodes("//abook[lektor='" + lektor.Text + "']/nazwa/text()");

            foreach (XmlNode isbn in nodeList)
            {
                propslektor[x] = isbn.OuterXml;
                x++;
            }
            x = 0;
            nodeList = root.SelectNodes("//abook[gatunek='" + gat.Text + "']/nazwa/text()");
           
            foreach (XmlNode isbn in nodeList)
            {
                propsgatunek[x] = isbn.OuterXml;
                x++;
            }
            
            var wspolne4 = propsgatunek.Intersect(propslektor.Intersect(propsautor.Intersect(propsepoka)));
            if (wspolne4 != null)
                przelacznik = 4;

            var wspolne3 = propslektor.Intersect(propsautor.Intersect(propsepoka));
            wspolne3 = wspolne3.Union(propsgatunek.Intersect(propsautor.Intersect(propsepoka)));
            wspolne3 = wspolne3.Union(propsautor.Intersect(propsgatunek.Intersect(propslektor)));
            wspolne3 = wspolne3.Union(propslektor.Intersect(propsgatunek.Intersect(propsepoka)));
            if (wspolne3 != null)
                przelacznik = 3;

            var wspolne2 = propsautor.Intersect(propsepoka);
            wspolne2 = wspolne2.Union(propsautor.Intersect(propsgatunek));
            wspolne2 = wspolne2.Union(propsautor.Intersect(propslektor));
            wspolne2 = wspolne2.Union(propsepoka.Intersect(propsgatunek));
            wspolne2 = wspolne2.Union(propsepoka.Intersect(propslektor));
            wspolne2 = wspolne2.Union(propsgatunek.Intersect(propslektor));
            if (wspolne2 != null)
                przelacznik = 2;
          

            switch (przelacznik)
            {
                case 0:

                    nodeList = root.SelectNodes("//abook[autor='" + aut.Text + "']/nazwa/text()");

                    foreach (XmlNode isbn in nodeList)
                    {
                        listBox2.Items.Add(isbn.OuterXml);

                    }
                    break;

                case 4:

                    foreach (var n in wspolne4)
                    {
                        if (n != null)
                            listBox2.Items.Add(n);
                    }
                    break;

                case 3:

                    foreach (var n in wspolne3)
                    {
                        if (n != null)
                            listBox2.Items.Add(n);
                    }
                    break;
                case 2:

                    foreach (var n in wspolne2)
                    {
                        if (n != null)
                            listBox2.Items.Add(n);
                    }
                    break;


            }


        }
        
        
        
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void labelLektor_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            axWindowsMediaPlayer1.URL = dirs[listBox1.Items.IndexOf(listBox2.SelectedItem)];
            listBox1.SelectedItem = listBox2.SelectedItem;

            XmlDocument doc = new XmlDocument();
            doc.Load(Directory.GetCurrentDirectory() + @"\baza\baza_audiobook.xml");


            XmlNode root = doc.DocumentElement;

            autor.Text = root.SelectSingleNode("//abook[@nazwa='" + listBox1.SelectedItem.ToString() + "']/autor/text()").OuterXml;
            tytul.Text = root.SelectSingleNode("//abook[@nazwa='" + listBox1.SelectedItem.ToString() + "']/tytul/text()").OuterXml;
            czyta.Text = root.SelectSingleNode("//abook[@nazwa='" + listBox1.SelectedItem.ToString() + "']/lektor/text()").OuterXml;
            gatunek.Text = root.SelectSingleNode("//abook[@nazwa='" + listBox1.SelectedItem.ToString() + "']/gatunek/text()").OuterXml;
            epoka.Text = root.SelectSingleNode("//abook[@nazwa='" + listBox1.SelectedItem.ToString() + "']/epoka/text()").OuterXml;
            czas.Text = root.SelectSingleNode("//abook[@nazwa='" + listBox1.SelectedItem.ToString() + "']/czas/text()").OuterXml;


            lektorzy[licznik] = czyta.Text;
            autorzy[licznik] = autor.Text;
            gatunki[licznik] = gatunek.Text;
            epoki[licznik] = epoka.Text;

            minuty = int.Parse(czas.Text.Substring(0, czas.Text.IndexOf(':')));
            sekundy = int.Parse(czas.Text.Substring(czas.Text.IndexOf(':') + 1, czas.Text.Length - czas.Text.IndexOf(':') - 1));


            lektor.Text = Dominanta(lektorzy);
            aut.Text = Dominanta(autorzy);
            gat.Text = Dominanta(gatunki);
            epo.Text = Dominanta(epoki);



            licznik++;
            if (licznik == 5)
                licznik = 0;

            licznik2++;
            summinuty = summinuty + minuty;
            sumsekundy = sumsekundy + sekundy;
            sredniamin = ((summinuty * 60 + sumsekundy) / licznik2 / 60);
            sredniasek = ((summinuty * 60 + sumsekundy) / licznik2 % 60);

            srednia = sredniamin.ToString() + ":" + sredniasek.ToString();
            if (sredniasek < 10)
                srednia = sredniamin.ToString() + ":0" + sredniasek.ToString();
            sre.Text = srednia;

            if (lektor.Text != "" && aut.Text != "" && gat.Text != "" && epo.Text != "")
                pro.Enabled = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void propozycjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pro_Click(sender,e);
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oAutorzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wojciech Gadaszewski "+Environment.NewLine+" wojciech92@gmail.com");
            
        }

        private void oPracyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program jest częścią pracy licencjackiej: " + Environment.NewLine + "Aplikacja doradzająca wybór audiobooka na podstawie"+Environment.NewLine+"analizy statystycznej");
            
        }

        

    }
}
