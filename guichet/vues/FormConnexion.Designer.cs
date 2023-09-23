namespace guichet
{
    partial class FormConnexion
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
            lblTitre = new Label();
            lblNumeroCarte = new Label();
            lblNip = new Label();
            btnConnexion = new Button();
            txtNip = new TextBox();
            txtNumeroCarte = new TextBox();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitre.Location = new Point(12, 9);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(378, 128);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Guichet";
            // 
            // lblNumeroCarte
            // 
            lblNumeroCarte.AutoSize = true;
            lblNumeroCarte.Location = new Point(12, 137);
            lblNumeroCarte.Name = "lblNumeroCarte";
            lblNumeroCarte.Size = new Size(227, 38);
            lblNumeroCarte.TabIndex = 1;
            lblNumeroCarte.Text = "Numéro de carte";
            // 
            // lblNip
            // 
            lblNip.AutoSize = true;
            lblNip.Location = new Point(12, 226);
            lblNip.Name = "lblNip";
            lblNip.Size = new Size(61, 38);
            lblNip.TabIndex = 2;
            lblNip.Text = "NIP";
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(65, 318);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(254, 72);
            btnConnexion.TabIndex = 5;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // txtNip
            // 
            txtNip.Location = new Point(12, 267);
            txtNip.Name = "txtNip";
            txtNip.PasswordChar = '*';
            txtNip.Size = new Size(378, 45);
            txtNip.TabIndex = 7;
            // 
            // txtNumeroCarte
            // 
            txtNumeroCarte.Location = new Point(12, 178);
            txtNumeroCarte.Name = "txtNumeroCarte";
            txtNumeroCarte.Size = new Size(378, 45);
            txtNumeroCarte.TabIndex = 8;
            // 
            // FormConnexion
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 405);
            Controls.Add(txtNumeroCarte);
            Controls.Add(txtNip);
            Controls.Add(btnConnexion);
            Controls.Add(lblNip);
            Controls.Add(lblNumeroCarte);
            Controls.Add(lblTitre);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormConnexion";
            Text = "Connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitre;
        private Label lblNumeroCarte;
        private Label lblNip;
        private Button btnConnexion;
        private TextBox txtNip;
        private TextBox txtNumeroCarte;
    }
}