namespace guichet.vues
{
    partial class FormMenu
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
            lblChoisirOption = new Label();
            btnDepot = new Button();
            btnRetrait = new Button();
            btnQuitter = new Button();
            SuspendLayout();
            // 
            // lblChoisirOption
            // 
            lblChoisirOption.AutoSize = true;
            lblChoisirOption.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblChoisirOption.Location = new Point(12, 9);
            lblChoisirOption.Name = "lblChoisirOption";
            lblChoisirOption.Size = new Size(626, 96);
            lblChoisirOption.TabIndex = 0;
            lblChoisirOption.Text = "Choisir une option";
            // 
            // btnDepot
            // 
            btnDepot.Location = new Point(174, 108);
            btnDepot.Name = "btnDepot";
            btnDepot.Size = new Size(150, 100);
            btnDepot.TabIndex = 1;
            btnDepot.Text = "Dépôt";
            btnDepot.UseVisualStyleBackColor = true;
            btnDepot.Click += btnDepot_Click;
            // 
            // btnRetrait
            // 
            btnRetrait.Location = new Point(330, 108);
            btnRetrait.Name = "btnRetrait";
            btnRetrait.Size = new Size(150, 100);
            btnRetrait.TabIndex = 2;
            btnRetrait.Text = "Retrait";
            btnRetrait.UseVisualStyleBackColor = true;
            btnRetrait.Click += btnRetrait_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.Location = new Point(174, 214);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(306, 100);
            btnQuitter.TabIndex = 3;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 348);
            Controls.Add(btnQuitter);
            Controls.Add(btnRetrait);
            Controls.Add(btnDepot);
            Controls.Add(lblChoisirOption);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormMenu";
            Text = "Menu";
            FormClosed += FormMenu_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblChoisirOption;
        private Button btnDepot;
        private Button btnRetrait;
        private Button btnQuitter;
    }
}