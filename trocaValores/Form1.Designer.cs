namespace trocaValores
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
            Btn1 = new Button();
            LblValor1 = new Label();
            LblValor2 = new Label();
            TxtValor1 = new TextBox();
            TxtValor2 = new TextBox();
            SuspendLayout();
            // 
            // Btn1
            // 
            Btn1.BackColor = SystemColors.Control;
            Btn1.Image = Properties.Resources.swap;
            Btn1.Location = new Point(237, 52);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(84, 68);
            Btn1.TabIndex = 0;
            Btn1.UseVisualStyleBackColor = false;
            Btn1.Click += btn1_Click;
            // 
            // LblValor1
            // 
            LblValor1.AutoSize = true;
            LblValor1.Location = new Point(35, 38);
            LblValor1.Name = "LblValor1";
            LblValor1.Size = new Size(42, 15);
            LblValor1.TabIndex = 1;
            LblValor1.Text = "Valor1:";
            LblValor1.Click += label1_Click;
            // 
            // LblValor2
            // 
            LblValor2.AutoSize = true;
            LblValor2.Location = new Point(35, 105);
            LblValor2.Name = "LblValor2";
            LblValor2.Size = new Size(42, 15);
            LblValor2.TabIndex = 2;
            LblValor2.Text = "Valor2:";
            // 
            // TxtValor1
            // 
            TxtValor1.Location = new Point(83, 35);
            TxtValor1.Name = "TxtValor1";
            TxtValor1.Size = new Size(100, 23);
            TxtValor1.TabIndex = 3;
            TxtValor1.TextChanged += TxtValor1_TextChanged;
            // 
            // TxtValor2
            // 
            TxtValor2.Location = new Point(83, 105);
            TxtValor2.Name = "TxtValor2";
            TxtValor2.Size = new Size(100, 23);
            TxtValor2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 184);
            Controls.Add(TxtValor2);
            Controls.Add(TxtValor1);
            Controls.Add(LblValor2);
            Controls.Add(LblValor1);
            Controls.Add(Btn1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn1;
        private Label LblValor1;
        private Label LblValor2;
        private TextBox TxtValor1;
        private TextBox TxtValor2;
    }
}
