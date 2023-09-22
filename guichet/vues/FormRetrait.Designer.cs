namespace guichet.vues
{
    partial class FormRetrait
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
            btnRetrait20 = new Button();
            btnRetrait40 = new Button();
            btnRetrait60 = new Button();
            btnRetrait80 = new Button();
            btnRetrait100 = new Button();
            btnRetrait200 = new Button();
            btnRetraitAutre = new Button();
            numRetraitAutre = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numRetraitAutre).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitre.Location = new Point(13, 9);
            lblTitre.Margin = new Padding(4, 0, 4, 0);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(338, 199);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Effectuer un retrait";
            // 
            // btnRetrait20
            // 
            btnRetrait20.Location = new Point(13, 211);
            btnRetrait20.Name = "btnRetrait20";
            btnRetrait20.Size = new Size(100, 80);
            btnRetrait20.TabIndex = 1;
            btnRetrait20.Text = "20 $";
            btnRetrait20.UseVisualStyleBackColor = true;
            btnRetrait20.Click += btnRetrait20_Click;
            // 
            // btnRetrait40
            // 
            btnRetrait40.Location = new Point(132, 211);
            btnRetrait40.Name = "btnRetrait40";
            btnRetrait40.Size = new Size(100, 80);
            btnRetrait40.TabIndex = 2;
            btnRetrait40.Text = "40 $";
            btnRetrait40.UseVisualStyleBackColor = true;
            btnRetrait40.Click += btnRetrait40_Click;
            // 
            // btnRetrait60
            // 
            btnRetrait60.Location = new Point(251, 211);
            btnRetrait60.Name = "btnRetrait60";
            btnRetrait60.Size = new Size(100, 80);
            btnRetrait60.TabIndex = 3;
            btnRetrait60.Text = "60 $";
            btnRetrait60.UseVisualStyleBackColor = true;
            btnRetrait60.Click += btnRetrait60_Click;
            // 
            // btnRetrait80
            // 
            btnRetrait80.Location = new Point(13, 297);
            btnRetrait80.Name = "btnRetrait80";
            btnRetrait80.Size = new Size(100, 80);
            btnRetrait80.TabIndex = 4;
            btnRetrait80.Text = "80 $";
            btnRetrait80.UseVisualStyleBackColor = true;
            btnRetrait80.Click += btnRetrait80_Click;
            // 
            // btnRetrait100
            // 
            btnRetrait100.Location = new Point(132, 297);
            btnRetrait100.Name = "btnRetrait100";
            btnRetrait100.Size = new Size(100, 80);
            btnRetrait100.TabIndex = 5;
            btnRetrait100.Text = "100 $";
            btnRetrait100.UseVisualStyleBackColor = true;
            btnRetrait100.Click += btnRetrait100_Click;
            // 
            // btnRetrait200
            // 
            btnRetrait200.Location = new Point(251, 297);
            btnRetrait200.Name = "btnRetrait200";
            btnRetrait200.Size = new Size(100, 80);
            btnRetrait200.TabIndex = 6;
            btnRetrait200.Text = "200 $";
            btnRetrait200.UseVisualStyleBackColor = true;
            btnRetrait200.Click += btnRetrait200_Click;
            // 
            // btnRetraitAutre
            // 
            btnRetraitAutre.Location = new Point(12, 383);
            btnRetraitAutre.Name = "btnRetraitAutre";
            btnRetraitAutre.Size = new Size(150, 100);
            btnRetraitAutre.TabIndex = 7;
            btnRetraitAutre.Text = "Autre montant";
            btnRetraitAutre.UseVisualStyleBackColor = true;
            btnRetraitAutre.Click += btnRetraitAutre_Click;
            // 
            // numRetraitAutre
            // 
            numRetraitAutre.Location = new Point(171, 412);
            numRetraitAutre.Margin = new Padding(4, 5, 4, 5);
            numRetraitAutre.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numRetraitAutre.Name = "numRetraitAutre";
            numRetraitAutre.Size = new Size(180, 45);
            numRetraitAutre.TabIndex = 8;
            // 
            // FormRetrait
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 493);
            Controls.Add(numRetraitAutre);
            Controls.Add(btnRetraitAutre);
            Controls.Add(btnRetrait200);
            Controls.Add(btnRetrait100);
            Controls.Add(btnRetrait80);
            Controls.Add(btnRetrait60);
            Controls.Add(btnRetrait40);
            Controls.Add(btnRetrait20);
            Controls.Add(lblTitre);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormRetrait";
            Text = "Retrait";
            ((System.ComponentModel.ISupportInitialize)numRetraitAutre).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitre;
        private Button btnRetrait20;
        private Button btnRetrait40;
        private Button btnRetrait60;
        private Button btnRetrait80;
        private Button btnRetrait100;
        private Button btnRetrait200;
        private Button btnRetraitAutre;
        private NumericUpDown numRetraitAutre;
    }
}