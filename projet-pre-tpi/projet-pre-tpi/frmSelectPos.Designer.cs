namespace projet_pre_tpi
{
    partial class frmSelectPos
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
            this.lbPos = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPos
            // 
            this.lbPos.FormattingEnabled = true;
            this.lbPos.Items.AddRange(new object[] {
            "test",
            "test2",
            "test3"});
            this.lbPos.Location = new System.Drawing.Point(12, 12);
            this.lbPos.Name = "lbPos";
            this.lbPos.Size = new System.Drawing.Size(260, 238);
            this.lbPos.TabIndex = 0;
            this.lbPos.SelectedIndexChanged += new System.EventHandler(this.lbPos_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLoad.Enabled = false;
            this.btnLoad.Location = new System.Drawing.Point(12, 256);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(260, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Charger...";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // frmSelectPos
            // 
            this.AcceptButton = this.btnLoad;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbPos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectPos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmSelectPos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPos;
        private System.Windows.Forms.Button btnLoad;
    }
}