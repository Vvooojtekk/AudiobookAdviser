using System;
using System.Linq;
namespace AudiobookAdviser

{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labeltytul = new System.Windows.Forms.Label();
            this.labelczyta = new System.Windows.Forms.Label();
            this.labelepoka = new System.Windows.Forms.Label();
            this.labelautor = new System.Windows.Forms.Label();
            this.labelgatunek = new System.Windows.Forms.Label();
            this.gatunek = new System.Windows.Forms.Label();
            this.autor = new System.Windows.Forms.Label();
            this.epoka = new System.Windows.Forms.Label();
            this.czyta = new System.Windows.Forms.Label();
            this.tytul = new System.Windows.Forms.Label();
            this.labelLektor = new System.Windows.Forms.Label();
            this.lektor = new System.Windows.Forms.Label();
            this.aut = new System.Windows.Forms.Label();
            this.labelaut = new System.Windows.Forms.Label();
            this.labelgat = new System.Windows.Forms.Label();
            this.gat = new System.Windows.Forms.Label();
            this.labelepo = new System.Windows.Forms.Label();
            this.epo = new System.Windows.Forms.Label();
            this.czas = new System.Windows.Forms.Label();
            this.labelczas = new System.Windows.Forms.Label();
            this.labelsre = new System.Windows.Forms.Label();
            this.sre = new System.Windows.Forms.Label();
            this.pro = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propozycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAutorzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPracyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 36);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(492, 100);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 154);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(492, 147);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // labeltytul
            // 
            this.labeltytul.AutoSize = true;
            this.labeltytul.Location = new System.Drawing.Point(5, 2);
            this.labeltytul.Name = "labeltytul";
            this.labeltytul.Size = new System.Drawing.Size(37, 15);
            this.labeltytul.TabIndex = 2;
            this.labeltytul.Text = "tytuł:";
            this.labeltytul.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelczyta
            // 
            this.labelczyta.AutoSize = true;
            this.labelczyta.Location = new System.Drawing.Point(5, 90);
            this.labelczyta.Name = "labelczyta";
            this.labelczyta.Size = new System.Drawing.Size(38, 15);
            this.labelczyta.TabIndex = 3;
            this.labelczyta.Text = "czyta:";
            // 
            // labelepoka
            // 
            this.labelepoka.AutoSize = true;
            this.labelepoka.Location = new System.Drawing.Point(5, 46);
            this.labelepoka.Name = "labelepoka";
            this.labelepoka.Size = new System.Drawing.Size(44, 15);
            this.labelepoka.TabIndex = 5;
            this.labelepoka.Text = "epoka:";
            // 
            // labelautor
            // 
            this.labelautor.AutoSize = true;
            this.labelautor.Location = new System.Drawing.Point(5, 24);
            this.labelautor.Name = "labelautor";
            this.labelautor.Size = new System.Drawing.Size(41, 15);
            this.labelautor.TabIndex = 6;
            this.labelautor.Text = "autor:";
            // 
            // labelgatunek
            // 
            this.labelgatunek.AutoSize = true;
            this.labelgatunek.Location = new System.Drawing.Point(5, 68);
            this.labelgatunek.Name = "labelgatunek";
            this.labelgatunek.Size = new System.Drawing.Size(55, 15);
            this.labelgatunek.TabIndex = 7;
            this.labelgatunek.Text = "gatunek:";
            // 
            // gatunek
            // 
            this.gatunek.AutoSize = true;
            this.gatunek.Location = new System.Drawing.Point(238, 68);
            this.gatunek.Name = "gatunek";
            this.gatunek.Size = new System.Drawing.Size(0, 15);
            this.gatunek.TabIndex = 12;
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.Location = new System.Drawing.Point(238, 24);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(0, 15);
            this.autor.TabIndex = 11;
            // 
            // epoka
            // 
            this.epoka.AutoSize = true;
            this.epoka.Location = new System.Drawing.Point(238, 46);
            this.epoka.Name = "epoka";
            this.epoka.Size = new System.Drawing.Size(0, 15);
            this.epoka.TabIndex = 10;
            // 
            // czyta
            // 
            this.czyta.AutoSize = true;
            this.czyta.Location = new System.Drawing.Point(238, 90);
            this.czyta.Name = "czyta";
            this.czyta.Size = new System.Drawing.Size(0, 15);
            this.czyta.TabIndex = 9;
            // 
            // tytul
            // 
            this.tytul.AutoSize = true;
            this.tytul.Location = new System.Drawing.Point(238, 2);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(0, 15);
            this.tytul.TabIndex = 8;
            // 
            // labelLektor
            // 
            this.labelLektor.AutoSize = true;
            this.labelLektor.Location = new System.Drawing.Point(5, 2);
            this.labelLektor.Name = "labelLektor";
            this.labelLektor.Size = new System.Drawing.Size(174, 15);
            this.labelLektor.TabIndex = 13;
            this.labelLektor.Text = "ostatnio często słuchany lektor";
            this.labelLektor.Click += new System.EventHandler(this.labelLektor_Click);
            // 
            // lektor
            // 
            this.lektor.AutoSize = true;
            this.lektor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lektor.Location = new System.Drawing.Point(238, 2);
            this.lektor.Name = "lektor";
            this.lektor.Size = new System.Drawing.Size(0, 15);
            this.lektor.TabIndex = 14;
            // 
            // aut
            // 
            this.aut.AutoSize = true;
            this.aut.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.aut.Location = new System.Drawing.Point(238, 24);
            this.aut.Name = "aut";
            this.aut.Size = new System.Drawing.Size(0, 15);
            this.aut.TabIndex = 15;
            // 
            // labelaut
            // 
            this.labelaut.AutoSize = true;
            this.labelaut.Location = new System.Drawing.Point(5, 24);
            this.labelaut.Name = "labelaut";
            this.labelaut.Size = new System.Drawing.Size(175, 15);
            this.labelaut.TabIndex = 16;
            this.labelaut.Text = "ostatnio często słuchany autor:";
            // 
            // labelgat
            // 
            this.labelgat.AutoSize = true;
            this.labelgat.Location = new System.Drawing.Point(5, 46);
            this.labelgat.Name = "labelgat";
            this.labelgat.Size = new System.Drawing.Size(189, 15);
            this.labelgat.TabIndex = 18;
            this.labelgat.Text = "ostatnio często słuchany gatunek:";
            // 
            // gat
            // 
            this.gat.AutoSize = true;
            this.gat.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gat.Location = new System.Drawing.Point(238, 46);
            this.gat.Name = "gat";
            this.gat.Size = new System.Drawing.Size(0, 15);
            this.gat.TabIndex = 17;
            // 
            // labelepo
            // 
            this.labelepo.AutoSize = true;
            this.labelepo.Location = new System.Drawing.Point(5, 68);
            this.labelepo.Name = "labelepo";
            this.labelepo.Size = new System.Drawing.Size(178, 15);
            this.labelepo.TabIndex = 20;
            this.labelepo.Text = "ostatnio często słuchana epoka:";
            // 
            // epo
            // 
            this.epo.AutoSize = true;
            this.epo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.epo.Location = new System.Drawing.Point(238, 68);
            this.epo.Name = "epo";
            this.epo.Size = new System.Drawing.Size(0, 15);
            this.epo.TabIndex = 19;
            // 
            // czas
            // 
            this.czas.AutoSize = true;
            this.czas.Location = new System.Drawing.Point(238, 112);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(0, 15);
            this.czas.TabIndex = 22;
            // 
            // labelczas
            // 
            this.labelczas.AutoSize = true;
            this.labelczas.Location = new System.Drawing.Point(5, 112);
            this.labelczas.Name = "labelczas";
            this.labelczas.Size = new System.Drawing.Size(32, 15);
            this.labelczas.TabIndex = 21;
            this.labelczas.Text = "czas:";
            // 
            // labelsre
            // 
            this.labelsre.AutoSize = true;
            this.labelsre.Location = new System.Drawing.Point(5, 90);
            this.labelsre.Name = "labelsre";
            this.labelsre.Size = new System.Drawing.Size(225, 15);
            this.labelsre.TabIndex = 24;
            this.labelsre.Text = "sredni czas trwania sluchanych utworów";
            // 
            // sre
            // 
            this.sre.AutoSize = true;
            this.sre.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sre.Location = new System.Drawing.Point(238, 90);
            this.sre.Name = "sre";
            this.sre.Size = new System.Drawing.Size(0, 15);
            this.sre.TabIndex = 23;
            // 
            // pro
            // 
            this.pro.Enabled = false;
            this.pro.Location = new System.Drawing.Point(226, 312);
            this.pro.Name = "pro";
            this.pro.Size = new System.Drawing.Size(76, 23);
            this.pro.TabIndex = 25;
            this.pro.Text = "Propozycja";
            this.pro.UseVisualStyleBackColor = true;
            this.pro.Click += new System.EventHandler(this.pro_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 341);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(492, 82);
            this.listBox2.TabIndex = 26;
            this.listBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lektor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sre, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelsre, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.aut, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelgat, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gat, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelepo, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.epo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelaut, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelLektor, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(541, 189);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(468, 112);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labeltytul, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tytul, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelautor, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.autor, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.czas, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelepoka, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelczas, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.epoka, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.czyta, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.gatunek, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelczyta, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelgatunek, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 6);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(541, 36);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(468, 135);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(5, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 14);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propozycjaToolStripMenuItem,
            this.toolStripSeparator1,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // propozycjaToolStripMenuItem
            // 
            this.propozycjaToolStripMenuItem.Enabled = false;
            this.propozycjaToolStripMenuItem.Name = "propozycjaToolStripMenuItem";
            this.propozycjaToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.propozycjaToolStripMenuItem.Text = "Propozycja";
            this.propozycjaToolStripMenuItem.Click += new System.EventHandler(this.propozycjaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oAutorzeToolStripMenuItem,
            this.oPracyToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // oAutorzeToolStripMenuItem
            // 
            this.oAutorzeToolStripMenuItem.Name = "oAutorzeToolStripMenuItem";
            this.oAutorzeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oAutorzeToolStripMenuItem.Text = "O autorze";
            this.oAutorzeToolStripMenuItem.Click += new System.EventHandler(this.oAutorzeToolStripMenuItem_Click);
            // 
            // oPracyToolStripMenuItem
            // 
            this.oPracyToolStripMenuItem.Name = "oPracyToolStripMenuItem";
            this.oPracyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oPracyToolStripMenuItem.Text = "O pracy";
            this.oPracyToolStripMenuItem.Click += new System.EventHandler(this.oPracyToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AudiobookAdviser.Properties.Resources.audiobook_2160367123;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.pro);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Form1";
            this.Text = "Audiobook Adviser";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labeltytul;
        private System.Windows.Forms.Label labelczyta;
        private System.Windows.Forms.Label labelepoka;
        private System.Windows.Forms.Label labelautor;
        private System.Windows.Forms.Label labelgatunek;
        private System.Windows.Forms.Label gatunek;
        private System.Windows.Forms.Label autor;
        private System.Windows.Forms.Label epoka;
        private System.Windows.Forms.Label czyta;
        private System.Windows.Forms.Label tytul;
        private System.Windows.Forms.Label labelLektor;
        private System.Windows.Forms.Label lektor;
       
        

       public string Dominanta(string[] tab)
       {
     
          string dominanta = tab.GroupBy(v => v).OrderByDescending(g => g.Count()).First().Key;
          return dominanta;
       }

 

       private System.Windows.Forms.Label aut;
       private System.Windows.Forms.Label labelaut;
       private System.Windows.Forms.Label labelgat;
       private System.Windows.Forms.Label gat;
       private System.Windows.Forms.Label labelepo;
       private System.Windows.Forms.Label epo;
       private System.Windows.Forms.Label czas;
       private System.Windows.Forms.Label labelczas;
       private System.Windows.Forms.Label labelsre;
       private System.Windows.Forms.Label sre;
       public System.Windows.Forms.Button pro;
       private System.Windows.Forms.ListBox listBox2;
       private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
       private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
       private System.Windows.Forms.Panel panel1;
       private System.Windows.Forms.Panel panel2;
       private System.Windows.Forms.Panel panel3;
       private System.Windows.Forms.Panel panel4;
       private System.Windows.Forms.MenuStrip menuStrip1;
       private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
       private System.Windows.Forms.ToolStripMenuItem propozycjaToolStripMenuItem;
       private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
       private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
       private System.Windows.Forms.ToolStripMenuItem oAutorzeToolStripMenuItem;
       private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
       private System.Windows.Forms.ToolStripMenuItem oPracyToolStripMenuItem;
    }
}

