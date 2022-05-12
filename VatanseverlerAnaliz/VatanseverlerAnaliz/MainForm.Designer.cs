
namespace VatanseverlerAnaliz
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDevamsizlik = new System.Windows.Forms.Button();
            this.btnTakim = new System.Windows.Forms.Button();
            this.btnOyuncuekle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDevamsizlik);
            this.panel1.Controls.Add(this.btnTakim);
            this.panel1.Controls.Add(this.btnOyuncuekle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 78);
            this.panel1.TabIndex = 0;
            // 
            // btnDevamsizlik
            // 
            this.btnDevamsizlik.BackColor = System.Drawing.SystemColors.Control;
            this.btnDevamsizlik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevamsizlik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDevamsizlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDevamsizlik.Location = new System.Drawing.Point(281, 10);
            this.btnDevamsizlik.Name = "btnDevamsizlik";
            this.btnDevamsizlik.Size = new System.Drawing.Size(279, 53);
            this.btnDevamsizlik.TabIndex = 2;
            this.btnDevamsizlik.Text = "DEVAMSIZLIK VE DİSİPLİN CEZALARI";
            this.btnDevamsizlik.UseVisualStyleBackColor = false;
            this.btnDevamsizlik.Click += new System.EventHandler(this.btnDevamsizlik_Click);
            // 
            // btnTakim
            // 
            this.btnTakim.BackColor = System.Drawing.SystemColors.Control;
            this.btnTakim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTakim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTakim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTakim.Location = new System.Drawing.Point(638, 10);
            this.btnTakim.Name = "btnTakim";
            this.btnTakim.Size = new System.Drawing.Size(187, 53);
            this.btnTakim.TabIndex = 3;
            this.btnTakim.Text = "TAKIM OYUNCULARI";
            this.btnTakim.UseVisualStyleBackColor = false;
            this.btnTakim.Click += new System.EventHandler(this.btnTakim_Click);
            // 
            // btnOyuncuekle
            // 
            this.btnOyuncuekle.BackColor = System.Drawing.SystemColors.Control;
            this.btnOyuncuekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOyuncuekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOyuncuekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOyuncuekle.Location = new System.Drawing.Point(16, 10);
            this.btnOyuncuekle.Name = "btnOyuncuekle";
            this.btnOyuncuekle.Size = new System.Drawing.Size(187, 53);
            this.btnOyuncuekle.TabIndex = 1;
            this.btnOyuncuekle.Text = "OYUNCU EKLE";
            this.btnOyuncuekle.UseVisualStyleBackColor = false;
            this.btnOyuncuekle.Click += new System.EventHandler(this.btnOyuncuekle_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1250, 718);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vatanseverler Takım Analiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing_1);
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate_1);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDevamsizlik;
        private System.Windows.Forms.Button btnTakim;
        private System.Windows.Forms.Button btnOyuncuekle;
    }
}

