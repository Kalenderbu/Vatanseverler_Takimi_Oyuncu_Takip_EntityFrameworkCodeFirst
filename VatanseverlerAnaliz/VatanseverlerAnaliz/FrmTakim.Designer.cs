
namespace VatanseverlerAnaliz
{
    partial class FrmTakim
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
            this.txtArama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOyuncusli = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblToplamOyuncu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtArama
            // 
            this.txtArama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtArama.Location = new System.Drawing.Point(13, 20);
            this.txtArama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(101, 23);
            this.txtArama.TabIndex = 1;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(875, 361);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnOyuncusli
            // 
            this.btnOyuncusli.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnOyuncusli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOyuncusli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOyuncusli.Location = new System.Drawing.Point(9, 384);
            this.btnOyuncusli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOyuncusli.Name = "btnOyuncusli";
            this.btnOyuncusli.Size = new System.Drawing.Size(113, 47);
            this.btnOyuncusli.TabIndex = 3;
            this.btnOyuncusli.Text = "Seçili Oyuncuyu Sil";
            this.btnOyuncusli.UseVisualStyleBackColor = false;
            this.btnOyuncusli.Click += new System.EventHandler(this.btnOyuncusli_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtArama);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(382, 384);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(124, 47);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oyuncu Ara";
            // 
            // lblToplamOyuncu
            // 
            this.lblToplamOyuncu.AutoSize = true;
            this.lblToplamOyuncu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamOyuncu.Location = new System.Drawing.Point(745, 373);
            this.lblToplamOyuncu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplamOyuncu.Name = "lblToplamOyuncu";
            this.lblToplamOyuncu.Size = new System.Drawing.Size(47, 15);
            this.lblToplamOyuncu.TabIndex = 5;
            this.lblToplamOyuncu.Text = "label1";
            // 
            // FrmTakim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(893, 440);
            this.Controls.Add(this.lblToplamOyuncu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOyuncusli);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.Name = "FrmTakim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Takım Oyuncuları";
            this.Load += new System.EventHandler(this.FrmTakim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOyuncusli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblToplamOyuncu;
    }
}