namespace KutuphaneProjesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbKitap = new ComboBox();
            btnOduncAl = new Button();
            lblOdunVerilenkitap = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnİade = new Button();
            txtTCKN = new TextBox();
            label4 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            btnİncele = new Button();
            grpSecilen = new GroupBox();
            btnCikis = new Button();
            lstSecilen = new ListBox();
            btnSil = new Button();
            btnOnayla = new Button();
            grpUyeGiris = new GroupBox();
            groupBox1.SuspendLayout();
            grpSecilen.SuspendLayout();
            grpUyeGiris.SuspendLayout();
            SuspendLayout();
            // 
            // cmbKitap
            // 
            cmbKitap.AllowDrop = true;
            cmbKitap.CausesValidation = false;
            cmbKitap.FormattingEnabled = true;
            cmbKitap.Location = new Point(13, 50);
            cmbKitap.Name = "cmbKitap";
            cmbKitap.Size = new Size(210, 24);
            cmbKitap.TabIndex = 0;
            // 
            // btnOduncAl
            // 
            btnOduncAl.Font = new Font("RomanT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOduncAl.ForeColor = Color.Black;
            btnOduncAl.Location = new Point(13, 83);
            btnOduncAl.Name = "btnOduncAl";
            btnOduncAl.Size = new Size(210, 23);
            btnOduncAl.TabIndex = 1;
            btnOduncAl.Text = "SEÇ";
            btnOduncAl.UseVisualStyleBackColor = true;
            btnOduncAl.Click += btnOduncAl_Click;
            // 
            // lblOdunVerilenkitap
            // 
            lblOdunVerilenkitap.AccessibleRole = AccessibleRole.RadioButton;
            lblOdunVerilenkitap.AutoSize = true;
            lblOdunVerilenkitap.BackColor = SystemColors.GradientInactiveCaption;
            lblOdunVerilenkitap.Font = new Font("Segoe Fluent Icons", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblOdunVerilenkitap.ForeColor = Color.SaddleBrown;
            lblOdunVerilenkitap.Location = new Point(13, 120);
            lblOdunVerilenkitap.Name = "lblOdunVerilenkitap";
            lblOdunVerilenkitap.Size = new Size(97, 15);
            lblOdunVerilenkitap.TabIndex = 2;
            lblOdunVerilenkitap.Text = "Seçilen Kitaplar";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.ForeColor = Color.Black;
            flowLayoutPanel1.Location = new Point(13, 147);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 0, 5, 0);
            flowLayoutPanel1.Size = new Size(210, 100);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnİade
            // 
            btnİade.Font = new Font("RomanT", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnİade.ForeColor = Color.Black;
            btnİade.Location = new Point(24, 237);
            btnİade.Name = "btnİade";
            btnİade.Size = new Size(103, 22);
            btnİade.TabIndex = 4;
            btnİade.Text = "KİTAP İADE";
            btnİade.UseVisualStyleBackColor = true;
            btnİade.Click += btnİade_Click;
            // 
            // txtTCKN
            // 
            txtTCKN.Location = new Point(101, 25);
            txtTCKN.Name = "txtTCKN";
            txtTCKN.Size = new Size(115, 23);
            txtTCKN.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 28);
            label4.Name = "label4";
            label4.Size = new Size(43, 16);
            label4.TabIndex = 11;
            label4.Text = "TCKN";
            // 
            // button1
            // 
            button1.Font = new Font("RomanT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(132, 54);
            button1.Name = "button1";
            button1.Size = new Size(84, 23);
            button1.TabIndex = 12;
            button1.Text = "GİRİŞ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnİncele);
            groupBox1.Controls.Add(grpSecilen);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnOnayla);
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(lblOdunVerilenkitap);
            groupBox1.Controls.Add(cmbKitap);
            groupBox1.Controls.Add(btnOduncAl);
            groupBox1.Controls.Add(grpUyeGiris);
            groupBox1.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.SaddleBrown;
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 288);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "HALK KÜTÜPHANESİ";
            // 
            // btnİncele
            // 
            btnİncele.Font = new Font("RomanT", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnİncele.ForeColor = Color.Black;
            btnİncele.Location = new Point(151, 259);
            btnİncele.Name = "btnİncele";
            btnİncele.Size = new Size(72, 23);
            btnİncele.TabIndex = 15;
            btnİncele.Text = "İncele:)";
            btnİncele.UseVisualStyleBackColor = true;
            btnİncele.Click += btnİncele_Click;
            // 
            // grpSecilen
            // 
            grpSecilen.Controls.Add(btnCikis);
            grpSecilen.Controls.Add(lstSecilen);
            grpSecilen.Controls.Add(btnİade);
            grpSecilen.Location = new Point(243, 22);
            grpSecilen.Name = "grpSecilen";
            grpSecilen.Size = new Size(253, 266);
            grpSecilen.TabIndex = 13;
            grpSecilen.TabStop = false;
            // 
            // btnCikis
            // 
            btnCikis.Font = new Font("RomanT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikis.ForeColor = Color.Black;
            btnCikis.ImageAlign = ContentAlignment.BottomCenter;
            btnCikis.Location = new Point(133, 237);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(75, 23);
            btnCikis.TabIndex = 14;
            btnCikis.Text = "ÇIKIŞ";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // lstSecilen
            // 
            lstSecilen.FormattingEnabled = true;
            lstSecilen.ItemHeight = 16;
            lstSecilen.Items.AddRange(new object[] { "." });
            lstSecilen.Location = new Point(24, 29);
            lstSecilen.Name = "lstSecilen";
            lstSecilen.Size = new Size(184, 196);
            lstSecilen.TabIndex = 7;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("RomanT", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.ForeColor = Color.Black;
            btnSil.Location = new Point(13, 255);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(48, 28);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnOnayla
            // 
            btnOnayla.Font = new Font("RomanT", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnOnayla.ForeColor = Color.Black;
            btnOnayla.Location = new Point(67, 258);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(78, 25);
            btnOnayla.TabIndex = 5;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = true;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // grpUyeGiris
            // 
            grpUyeGiris.Controls.Add(button1);
            grpUyeGiris.Controls.Add(label4);
            grpUyeGiris.Controls.Add(txtTCKN);
            grpUyeGiris.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpUyeGiris.ForeColor = Color.SaddleBrown;
            grpUyeGiris.Location = new Point(243, 22);
            grpUyeGiris.Name = "grpUyeGiris";
            grpUyeGiris.Size = new Size(226, 94);
            grpUyeGiris.TabIndex = 2;
            grpUyeGiris.TabStop = false;
            grpUyeGiris.Text = "ÜYE GİRİŞİ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(522, 361);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpSecilen.ResumeLayout(false);
            grpUyeGiris.ResumeLayout(false);
            grpUyeGiris.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public ComboBox cmbKitap;
        private Button btnOduncAl;
        private Label lblOdunVerilenkitap;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnİade;
        private TextBox txtTCKN;
        private Label label4;
        private Button button1;
        private GroupBox groupBox1;
        private Button btnOnayla;
        private Button btnSil;
        public GroupBox grpUyeGiris;
        private ListBox lstSecilen;
        private GroupBox grpSecilen;
        private Button btnCikis;
        private Button btnİncele;
    }
}