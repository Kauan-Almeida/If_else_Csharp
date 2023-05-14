namespace WinFormsApp5
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
            lblNota1 = new Label();
            lblNota2 = new Label();
            lblNota3 = new Label();
            lblMéd = new Label();
            lblMedia = new Label();
            lblSit = new Label();
            lblSituacao = new Label();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(14, 23);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(42, 15);
            lblNota1.TabIndex = 0;
            lblNota1.Text = "Nota 1";
            lblNota1.Click += label1_Click;
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Location = new Point(14, 52);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(42, 15);
            lblNota2.TabIndex = 1;
            lblNota2.Text = "Nota 2";
            // 
            // lblNota3
            // 
            lblNota3.AutoSize = true;
            lblNota3.Location = new Point(14, 86);
            lblNota3.Name = "lblNota3";
            lblNota3.Size = new Size(42, 15);
            lblNota3.TabIndex = 2;
            lblNota3.Text = "Nota 3";
            // 
            // lblMéd
            // 
            lblMéd.AutoSize = true;
            lblMéd.Location = new Point(14, 131);
            lblMéd.Name = "lblMéd";
            lblMéd.Size = new Size(40, 15);
            lblMéd.TabIndex = 3;
            lblMéd.Text = "Média";
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Location = new Point(74, 131);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(38, 15);
            lblMedia.TabIndex = 4;
            lblMedia.Text = "label5";
            // 
            // lblSit
            // 
            lblSit.AutoSize = true;
            lblSit.Location = new Point(14, 158);
            lblSit.Name = "lblSit";
            lblSit.Size = new Size(52, 15);
            lblSit.TabIndex = 5;
            lblSit.Text = "Situação";
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(74, 158);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(38, 15);
            lblSituacao.TabIndex = 6;
            lblSituacao.Text = "label7";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(74, 23);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(100, 23);
            txtNota1.TabIndex = 7;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(74, 52);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(100, 23);
            txtNota2.TabIndex = 8;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(74, 86);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(100, 23);
            txtNota3.TabIndex = 9;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(74, 196);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 329);
            Controls.Add(btnCalcular);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(lblSituacao);
            Controls.Add(lblSit);
            Controls.Add(lblMedia);
            Controls.Add(lblMéd);
            Controls.Add(lblNota3);
            Controls.Add(lblNota2);
            Controls.Add(lblNota1);
            Name = "Form1";
            Text = "Calcular Media";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNota1;
        private Label lblNota2;
        private Label lblNota3;
        private Label lblMéd;
        private Label lblMedia;
        private Label lblSit;
        private Label lblSituacao;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private Button btnCalcular;
    }
}