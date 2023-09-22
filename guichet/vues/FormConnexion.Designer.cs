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
            numNumeroCarte = new NumericUpDown();
            txtNip = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numNumeroCarte).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitre.Location = new Point(12, 9);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(254, 86);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Guichet";
            // 
            // lblNumeroCarte
            // 
            lblNumeroCarte.AutoSize = true;
            lblNumeroCarte.Location = new Point(53, 95);
            lblNumeroCarte.Name = "lblNumeroCarte";
            lblNumeroCarte.Size = new Size(154, 25);
            lblNumeroCarte.TabIndex = 1;
            lblNumeroCarte.Text = "Numéro de carte";
            // 
            // lblNip
            // 
            lblNip.AutoSize = true;
            lblNip.Location = new Point(53, 158);
            lblNip.Name = "lblNip";
            lblNip.Size = new Size(42, 25);
            lblNip.TabIndex = 2;
            lblNip.Text = "NIP";
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(12, 224);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(254, 72);
            btnConnexion.TabIndex = 5;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // numNumeroCarte
            // 
            numNumeroCarte.Location = new Point(53, 123);
            numNumeroCarte.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numNumeroCarte.Minimum = new decimal(new int[] { 11111, 0, 0, 0 });
            numNumeroCarte.Name = "numNumeroCarte";
            numNumeroCarte.Size = new Size(154, 32);
            numNumeroCarte.TabIndex = 6;
            numNumeroCarte.Value = new decimal(new int[] { 11111, 0, 0, 0 });
            // 
            // txtNip
            // 
            txtNip.Location = new Point(53, 186);
            txtNip.Name = "txtNip";
            txtNip.PasswordChar = '*';
            txtNip.Size = new Size(154, 32);
            txtNip.TabIndex = 7;
            // 
            // FormConnexion
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 304);
            Controls.Add(txtNip);
            Controls.Add(numNumeroCarte);
            Controls.Add(btnConnexion);
            Controls.Add(lblNip);
            Controls.Add(lblNumeroCarte);
            Controls.Add(lblTitre);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormConnexion";
            Text = "Connexion";
            ((System.ComponentModel.ISupportInitialize)numNumeroCarte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitre;
        private Label lblNumeroCarte;
        private Label lblNip;
        private Button btnConnexion;
        private NumericUpDown numNumeroCarte;
        private TextBox txtNip;
    }
}