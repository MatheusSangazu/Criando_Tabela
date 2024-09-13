
namespace Tabela
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
            this.Btn_CriaTabela = new System.Windows.Forms.Button();
            this.GridTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_CriaTabela
            // 
            this.Btn_CriaTabela.Location = new System.Drawing.Point(27, 359);
            this.Btn_CriaTabela.Name = "Btn_CriaTabela";
            this.Btn_CriaTabela.Size = new System.Drawing.Size(102, 38);
            this.Btn_CriaTabela.TabIndex = 18;
            this.Btn_CriaTabela.Text = "Cria e Exibe tabela";
            this.Btn_CriaTabela.UseVisualStyleBackColor = true;
            this.Btn_CriaTabela.Click += new System.EventHandler(this.Btn_CriaTabela_Click);
            // 
            // GridTable
            // 
            this.GridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTable.Location = new System.Drawing.Point(27, 31);
            this.GridTable.Name = "GridTable";
            this.GridTable.RowTemplate.Height = 25;
            this.GridTable.Size = new System.Drawing.Size(761, 322);
            this.GridTable.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_CriaTabela);
            this.Controls.Add(this.GridTable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_CriaTabela;
        private System.Windows.Forms.DataGridView GridTable;
    }
}

