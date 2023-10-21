namespace guichet.vues
{
    partial class FormDepot
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
            lblTitre = new Label();
            grpComptes = new GroupBox();
            rdoEpargne = new RadioButton();
            rdoCheque = new RadioButton();
            numMontant = new NumericUpDown();
            btnDeposer = new Button();
            listBox1 = new ListBox();
            grpComptes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMontant).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitre.Location = new Point(13, 9);
            lblTitre.Margin = new Padding(4, 0, 4, 0);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(524, 81);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Effectuer un dépôt";
            // 
            // grpComptes
            // 
            grpComptes.Controls.Add(rdoEpargne);
            grpComptes.Controls.Add(rdoCheque);
            grpComptes.Location = new Point(64, 105);
            grpComptes.Name = "grpComptes";
            grpComptes.Size = new Size(152, 145);
            grpComptes.TabIndex = 1;
            grpComptes.TabStop = false;
            grpComptes.Text = "Comptes";
            // 
            // rdoEpargne
            // 
            rdoEpargne.AutoSize = true;
            rdoEpargne.Location = new Point(6, 92);
            rdoEpargne.Name = "rdoEpargne";
            rdoEpargne.Size = new Size(122, 36);
            rdoEpargne.TabIndex = 3;
            rdoEpargne.Text = "Épargne";
            rdoEpargne.UseVisualStyleBackColor = true;
            rdoEpargne.CheckedChanged += rdoEpargne_CheckedChanged;
            // 
            // rdoCheque
            // 
            rdoCheque.AutoSize = true;
            rdoCheque.Checked = true;
            rdoCheque.Location = new Point(6, 44);
            rdoCheque.Name = "rdoCheque";
            rdoCheque.Size = new Size(118, 36);
            rdoCheque.TabIndex = 2;
            rdoCheque.TabStop = true;
            rdoCheque.Text = "Chèque";
            rdoCheque.UseVisualStyleBackColor = true;
            rdoCheque.CheckedChanged += rdoCheque_CheckedChanged;
            // 
            // numMontant
            // 
            numMontant.Location = new Point(229, 261);
            numMontant.Margin = new Padding(4, 5, 4, 5);
            numMontant.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numMontant.Name = "numMontant";
            numMontant.Size = new Size(180, 39);
            numMontant.TabIndex = 2;
            // 
            // btnDeposer
            // 
            btnDeposer.Location = new Point(229, 314);
            btnDeposer.Name = "btnDeposer";
            btnDeposer.Size = new Size(180, 79);
            btnDeposer.TabIndex = 3;
            btnDeposer.Text = "Déposer";
            btnDeposer.UseVisualStyleBackColor = true;
            btnDeposer.Click += btnDeposer_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 31;
            listBox1.Location = new Point(255, 93);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(361, 128);
            listBox1.TabIndex = 4;
            // 
            // FormDepot
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 404);
            Controls.Add(listBox1);
            Controls.Add(btnDeposer);
            Controls.Add(numMontant);
            Controls.Add(grpComptes);
            Controls.Add(lblTitre);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormDepot";
            Text = "Dépôt";
            FormClosed += FormDepot_FormClosed;
            Load += FormDepot_Load;
            grpComptes.ResumeLayout(false);
            grpComptes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMontant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitre;
        private GroupBox grpComptes;
        private RadioButton rdoCheque;
        private RadioButton rdoEpargne;
        private NumericUpDown numMontant;
        private Button btnDeposer;
        private ListBox listBox1;
    }
}