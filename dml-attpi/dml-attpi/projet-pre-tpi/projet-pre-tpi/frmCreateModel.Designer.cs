namespace projet_pre_tpi
{
    partial class frmCreateModel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.pbxPinky = new System.Windows.Forms.PictureBox();
            this.pbxRing = new System.Windows.Forms.PictureBox();
            this.pbxMiddle = new System.Windows.Forms.PictureBox();
            this.pbxIndex = new System.Windows.Forms.PictureBox();
            this.pbxThumb = new System.Windows.Forms.PictureBox();
            this.tbxNamePos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPinky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxThumb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pouce";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Index";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Majeur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Annulaire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Auriculaire";
            // 
            // btnValidate
            // 
            this.btnValidate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnValidate.Enabled = false;
            this.btnValidate.Location = new System.Drawing.Point(439, 131);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(100, 30);
            this.btnValidate.TabIndex = 10;
            this.btnValidate.Text = "Valider";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // pbxPinky
            // 
            this.pbxPinky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxPinky.Location = new System.Drawing.Point(439, 25);
            this.pbxPinky.Name = "pbxPinky";
            this.pbxPinky.Size = new System.Drawing.Size(100, 100);
            this.pbxPinky.TabIndex = 4;
            this.pbxPinky.TabStop = false;
            this.pbxPinky.Tag = "4";
            this.pbxPinky.Click += new System.EventHandler(this.pbx_Click);
            // 
            // pbxRing
            // 
            this.pbxRing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxRing.Location = new System.Drawing.Point(333, 25);
            this.pbxRing.Name = "pbxRing";
            this.pbxRing.Size = new System.Drawing.Size(100, 100);
            this.pbxRing.TabIndex = 3;
            this.pbxRing.TabStop = false;
            this.pbxRing.Tag = "3";
            this.pbxRing.Click += new System.EventHandler(this.pbx_Click);
            // 
            // pbxMiddle
            // 
            this.pbxMiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxMiddle.Location = new System.Drawing.Point(227, 25);
            this.pbxMiddle.Name = "pbxMiddle";
            this.pbxMiddle.Size = new System.Drawing.Size(100, 100);
            this.pbxMiddle.TabIndex = 2;
            this.pbxMiddle.TabStop = false;
            this.pbxMiddle.Tag = "2";
            this.pbxMiddle.Click += new System.EventHandler(this.pbx_Click);
            // 
            // pbxIndex
            // 
            this.pbxIndex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxIndex.Location = new System.Drawing.Point(121, 25);
            this.pbxIndex.Name = "pbxIndex";
            this.pbxIndex.Size = new System.Drawing.Size(100, 100);
            this.pbxIndex.TabIndex = 1;
            this.pbxIndex.TabStop = false;
            this.pbxIndex.Tag = "1";
            this.pbxIndex.Click += new System.EventHandler(this.pbx_Click);
            // 
            // pbxThumb
            // 
            this.pbxThumb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxThumb.Location = new System.Drawing.Point(15, 25);
            this.pbxThumb.Name = "pbxThumb";
            this.pbxThumb.Size = new System.Drawing.Size(100, 100);
            this.pbxThumb.TabIndex = 0;
            this.pbxThumb.TabStop = false;
            this.pbxThumb.Tag = "0";
            this.pbxThumb.Click += new System.EventHandler(this.pbx_Click);
            // 
            // tbxNamePos
            // 
            this.tbxNamePos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNamePos.Location = new System.Drawing.Point(227, 131);
            this.tbxNamePos.Multiline = true;
            this.tbxNamePos.Name = "tbxNamePos";
            this.tbxNamePos.Size = new System.Drawing.Size(206, 30);
            this.tbxNamePos.TabIndex = 11;
            this.tbxNamePos.TextChanged += new System.EventHandler(this.tbxNamePos_TextChanged);
            // 
            // frmCreateModel
            // 
            this.AcceptButton = this.btnValidate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 173);
            this.Controls.Add(this.tbxNamePos);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxPinky);
            this.Controls.Add(this.pbxRing);
            this.Controls.Add(this.pbxMiddle);
            this.Controls.Add(this.pbxIndex);
            this.Controls.Add(this.pbxThumb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreateModel";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Créer un modèle";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPinky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxThumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxThumb;
        private System.Windows.Forms.PictureBox pbxIndex;
        private System.Windows.Forms.PictureBox pbxMiddle;
        private System.Windows.Forms.PictureBox pbxRing;
        private System.Windows.Forms.PictureBox pbxPinky;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox tbxNamePos;
    }
}