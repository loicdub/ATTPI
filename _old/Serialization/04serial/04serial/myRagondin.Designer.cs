namespace _04serial
{
    partial class myRagondin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxWeight = new System.Windows.Forms.TextBox();
            this.tbxSize = new System.Windows.Forms.TextBox();
            this.tbxColor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poids (kg) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Taille (cm) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Couleur :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 116);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(257, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(78, 12);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(194, 20);
            this.tbxName.TabIndex = 0;
            // 
            // tbxWeight
            // 
            this.tbxWeight.Location = new System.Drawing.Point(78, 38);
            this.tbxWeight.Name = "tbxWeight";
            this.tbxWeight.Size = new System.Drawing.Size(194, 20);
            this.tbxWeight.TabIndex = 1;
            // 
            // tbxSize
            // 
            this.tbxSize.Location = new System.Drawing.Point(78, 64);
            this.tbxSize.Name = "tbxSize";
            this.tbxSize.Size = new System.Drawing.Size(194, 20);
            this.tbxSize.TabIndex = 2;
            // 
            // tbxColor
            // 
            this.tbxColor.Location = new System.Drawing.Point(78, 90);
            this.tbxColor.Name = "tbxColor";
            this.tbxColor.Size = new System.Drawing.Size(194, 20);
            this.tbxColor.TabIndex = 3;
            // 
            // myRagondin
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.tbxColor);
            this.Controls.Add(this.tbxSize);
            this.Controls.Add(this.tbxWeight);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "myRagondin";
            this.Text = "Mon ragondin";
            this.Load += new System.EventHandler(this.myRagondin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxWeight;
        private System.Windows.Forms.TextBox tbxSize;
        private System.Windows.Forms.TextBox tbxColor;
    }
}

