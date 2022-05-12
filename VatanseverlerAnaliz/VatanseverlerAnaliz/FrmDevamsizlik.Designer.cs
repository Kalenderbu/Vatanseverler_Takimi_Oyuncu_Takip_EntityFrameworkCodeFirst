
namespace VatanseverlerAnaliz
{
    partial class FrmDevamsizlik
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEkipman = new System.Windows.Forms.Label();
            this.btnEkipmanSil = new System.Windows.Forms.Button();
            this.btnEkipmanekle = new System.Windows.Forms.Button();
            this.txtmultiEkipman = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmultiDevamsizlik = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDevamsizlikSil = new System.Windows.Forms.Button();
            this.btnDevamsizlikEkle = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDisiplin = new System.Windows.Forms.Label();
            this.btnDisiplinSil = new System.Windows.Forms.Button();
            this.txtmultiDisiplin = new System.Windows.Forms.TextBox();
            this.btnDisiplinEkle = new System.Windows.Forms.Button();
            this.lblToplamOyuncu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(904, 354);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtArama);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(922, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 58);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oyuncu Ara";
            // 
            // txtArama
            // 
            this.txtArama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtArama.Location = new System.Drawing.Point(17, 25);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(133, 27);
            this.txtArama.TabIndex = 1;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEkipman);
            this.groupBox2.Controls.Add(this.btnEkipmanSil);
            this.groupBox2.Controls.Add(this.btnEkipmanekle);
            this.groupBox2.Controls.Add(this.txtmultiEkipman);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 384);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 151);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seçili Oyuncuya Ekipman Ekle\\Sil";
            // 
            // lblEkipman
            // 
            this.lblEkipman.AutoSize = true;
            this.lblEkipman.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEkipman.Location = new System.Drawing.Point(228, 77);
            this.lblEkipman.Name = "lblEkipman";
            this.lblEkipman.Size = new System.Drawing.Size(0, 17);
            this.lblEkipman.TabIndex = 9;
            // 
            // btnEkipmanSil
            // 
            this.btnEkipmanSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkipmanSil.Location = new System.Drawing.Point(230, 104);
            this.btnEkipmanSil.Name = "btnEkipmanSil";
            this.btnEkipmanSil.Size = new System.Drawing.Size(87, 41);
            this.btnEkipmanSil.TabIndex = 2;
            this.btnEkipmanSil.Text = "SİL";
            this.btnEkipmanSil.UseVisualStyleBackColor = true;
            this.btnEkipmanSil.Click += new System.EventHandler(this.btnEkipmanSil_Click);
            // 
            // btnEkipmanekle
            // 
            this.btnEkipmanekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkipmanekle.Location = new System.Drawing.Point(231, 25);
            this.btnEkipmanekle.Name = "btnEkipmanekle";
            this.btnEkipmanekle.Size = new System.Drawing.Size(87, 41);
            this.btnEkipmanekle.TabIndex = 1;
            this.btnEkipmanekle.Text = "EKLE";
            this.btnEkipmanekle.UseVisualStyleBackColor = true;
            this.btnEkipmanekle.Click += new System.EventHandler(this.btnEkipmanekle_Click);
            // 
            // txtmultiEkipman
            // 
            this.txtmultiEkipman.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmultiEkipman.Location = new System.Drawing.Point(7, 26);
            this.txtmultiEkipman.Multiline = true;
            this.txtmultiEkipman.Name = "txtmultiEkipman";
            this.txtmultiEkipman.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtmultiEkipman.Size = new System.Drawing.Size(217, 119);
            this.txtmultiEkipman.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtmultiDevamsizlik);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.btnDevamsizlikSil);
            this.groupBox3.Controls.Add(this.btnDevamsizlikEkle);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(748, 384);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 151);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seçili Oyuncuya Devamsızlık Ekle\\Sil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(171, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 9;
            // 
            // txtmultiDevamsizlik
            // 
            this.txtmultiDevamsizlik.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmultiDevamsizlik.Location = new System.Drawing.Point(6, 25);
            this.txtmultiDevamsizlik.Multiline = true;
            this.txtmultiDevamsizlik.Name = "txtmultiDevamsizlik";
            this.txtmultiDevamsizlik.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtmultiDevamsizlik.Size = new System.Drawing.Size(162, 120);
            this.txtmultiDevamsizlik.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(174, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 24);
            this.button3.TabIndex = 8;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDevamsizlikSil
            // 
            this.btnDevamsizlikSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevamsizlikSil.Location = new System.Drawing.Point(273, 104);
            this.btnDevamsizlikSil.Name = "btnDevamsizlikSil";
            this.btnDevamsizlikSil.Size = new System.Drawing.Size(65, 37);
            this.btnDevamsizlikSil.TabIndex = 6;
            this.btnDevamsizlikSil.Text = "SİL";
            this.btnDevamsizlikSil.UseVisualStyleBackColor = true;
            this.btnDevamsizlikSil.Click += new System.EventHandler(this.btnDevamsizlikSil_Click);
            // 
            // btnDevamsizlikEkle
            // 
            this.btnDevamsizlikEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevamsizlikEkle.Location = new System.Drawing.Point(174, 104);
            this.btnDevamsizlikEkle.Name = "btnDevamsizlikEkle";
            this.btnDevamsizlikEkle.Size = new System.Drawing.Size(81, 37);
            this.btnDevamsizlikEkle.TabIndex = 5;
            this.btnDevamsizlikEkle.Text = "EKLE";
            this.btnDevamsizlikEkle.UseVisualStyleBackColor = true;
            this.btnDevamsizlikEkle.Click += new System.EventHandler(this.btnDevamsizlikEkle_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(212, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 24);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDisiplin);
            this.groupBox4.Controls.Add(this.btnDisiplinSil);
            this.groupBox4.Controls.Add(this.txtmultiDisiplin);
            this.groupBox4.Controls.Add(this.btnDisiplinEkle);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(359, 384);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(366, 151);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seçili Oyuncuya Disiplin Cezası Ekle\\Sil";
            // 
            // lblDisiplin
            // 
            this.lblDisiplin.AutoSize = true;
            this.lblDisiplin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDisiplin.Location = new System.Drawing.Point(229, 74);
            this.lblDisiplin.Name = "lblDisiplin";
            this.lblDisiplin.Size = new System.Drawing.Size(0, 17);
            this.lblDisiplin.TabIndex = 9;
            // 
            // btnDisiplinSil
            // 
            this.btnDisiplinSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisiplinSil.Location = new System.Drawing.Point(240, 105);
            this.btnDisiplinSil.Name = "btnDisiplinSil";
            this.btnDisiplinSil.Size = new System.Drawing.Size(87, 40);
            this.btnDisiplinSil.TabIndex = 4;
            this.btnDisiplinSil.Text = "SİL";
            this.btnDisiplinSil.UseVisualStyleBackColor = true;
            this.btnDisiplinSil.Click += new System.EventHandler(this.btnDisiplinSil_Click);
            // 
            // txtmultiDisiplin
            // 
            this.txtmultiDisiplin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmultiDisiplin.Location = new System.Drawing.Point(6, 26);
            this.txtmultiDisiplin.Multiline = true;
            this.txtmultiDisiplin.Name = "txtmultiDisiplin";
            this.txtmultiDisiplin.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtmultiDisiplin.Size = new System.Drawing.Size(217, 119);
            this.txtmultiDisiplin.TabIndex = 1;
            // 
            // btnDisiplinEkle
            // 
            this.btnDisiplinEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisiplinEkle.Location = new System.Drawing.Point(241, 26);
            this.btnDisiplinEkle.Name = "btnDisiplinEkle";
            this.btnDisiplinEkle.Size = new System.Drawing.Size(87, 41);
            this.btnDisiplinEkle.TabIndex = 3;
            this.btnDisiplinEkle.Text = "EKLE";
            this.btnDisiplinEkle.UseVisualStyleBackColor = true;
            this.btnDisiplinEkle.Click += new System.EventHandler(this.btnDisiplinEkle_Click);
            // 
            // lblToplamOyuncu
            // 
            this.lblToplamOyuncu.AutoSize = true;
            this.lblToplamOyuncu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamOyuncu.Location = new System.Drawing.Point(919, 349);
            this.lblToplamOyuncu.Name = "lblToplamOyuncu";
            this.lblToplamOyuncu.Size = new System.Drawing.Size(0, 17);
            this.lblToplamOyuncu.TabIndex = 8;
            // 
            // FrmDevamsizlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 544);
            this.Controls.Add(this.lblToplamOyuncu);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.MinimizeBox = false;
            this.Name = "FrmDevamsizlik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devamsızlık ve Disiplin Cezası Bilgileri";
            this.Load += new System.EventHandler(this.FrmDevamsizlik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtmultiEkipman;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtmultiDisiplin;
        private System.Windows.Forms.Button btnEkipmanSil;
        private System.Windows.Forms.Button btnEkipmanekle;
        private System.Windows.Forms.Button btnDevamsizlikSil;
        private System.Windows.Forms.Button btnDevamsizlikEkle;
        private System.Windows.Forms.Button btnDisiplinSil;
        private System.Windows.Forms.Button btnDisiplinEkle;
        private System.Windows.Forms.Label lblToplamOyuncu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtmultiDevamsizlik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEkipman;
        private System.Windows.Forms.Label lblDisiplin;
    }
}