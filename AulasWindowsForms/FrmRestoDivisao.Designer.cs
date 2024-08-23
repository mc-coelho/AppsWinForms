namespace AulasWindowsForms
{
    partial class FrmRestoDaDivisao
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
            txtDividendo = new TextBox();
            txtDivisor = new TextBox();
            lblDivisor = new Label();
            lblDividendo = new Label();
            btnDivisao = new Button();
            lblResto = new Label();
            txtResto = new TextBox();
            SuspendLayout();
            // 
            // txtDividendo
            // 
            txtDividendo.Location = new Point(200, 78);
            txtDividendo.Name = "txtDividendo";
            txtDividendo.Size = new Size(100, 23);
            txtDividendo.TabIndex = 0;
            // 
            // txtDivisor
            // 
            txtDivisor.Location = new Point(430, 78);
            txtDivisor.Name = "txtDivisor";
            txtDivisor.Size = new Size(100, 23);
            txtDivisor.TabIndex = 1;
            txtDivisor.TextChanged += textBox2_TextChanged;
            // 
            // lblDivisor
            // 
            lblDivisor.AutoSize = true;
            lblDivisor.Location = new Point(381, 78);
            lblDivisor.Name = "lblDivisor";
            lblDivisor.Size = new Size(43, 15);
            lblDivisor.TabIndex = 2;
            lblDivisor.Text = "Divisor";
            // 
            // lblDividendo
            // 
            lblDividendo.AutoSize = true;
            lblDividendo.Location = new Point(133, 86);
            lblDividendo.Name = "lblDividendo";
            lblDividendo.Size = new Size(61, 15);
            lblDividendo.TabIndex = 3;
            lblDividendo.Text = "Dividendo";
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(191, 136);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(100, 37);
            btnDivisao.TabIndex = 2;
            btnDivisao.Text = "Realizar Divisão";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // lblResto
            // 
            lblResto.AutoSize = true;
            lblResto.Location = new Point(332, 147);
            lblResto.Name = "lblResto";
            lblResto.Size = new Size(92, 15);
            lblResto.TabIndex = 5;
            lblResto.Text = "Resto da divisão";
            // 
            // txtResto
            // 
            txtResto.Enabled = false;
            txtResto.Location = new Point(430, 144);
            txtResto.Name = "txtResto";
            txtResto.ReadOnly = true;
            txtResto.Size = new Size(100, 23);
            txtResto.TabIndex = 6;
            txtResto.TabStop = false;
            // 
            // FrmRestoDaDivisao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 255);
            Controls.Add(txtResto);
            Controls.Add(lblResto);
            Controls.Add(btnDivisao);
            Controls.Add(lblDividendo);
            Controls.Add(lblDivisor);
            Controls.Add(txtDivisor);
            Controls.Add(txtDividendo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRestoDaDivisao";
            Text = "Resto da Divisão";
            Load += FrmRestoDivisao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDividendo;
        private TextBox txtDivisor;
        private Label lblDivisor;
        private Label lblDividendo;
        private Button btnDivisao;
        private Label lblResto;
        private TextBox txtResto;
    }
}