namespace TPFinalNivel2
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aRTICULOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cATEGORIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mARCAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRTICULOToolStripMenuItem,
            this.cATEGORIAToolStripMenuItem,
            this.mARCAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aRTICULOToolStripMenuItem
            // 
            this.aRTICULOToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.aRTICULOToolStripMenuItem.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aRTICULOToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.aRTICULOToolStripMenuItem.Name = "aRTICULOToolStripMenuItem";
            this.aRTICULOToolStripMenuItem.Size = new System.Drawing.Size(106, 27);
            this.aRTICULOToolStripMenuItem.Text = "ARTICULO";
            // 
            // cATEGORIAToolStripMenuItem
            // 
            this.cATEGORIAToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cATEGORIAToolStripMenuItem.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cATEGORIAToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cATEGORIAToolStripMenuItem.Name = "cATEGORIAToolStripMenuItem";
            this.cATEGORIAToolStripMenuItem.Size = new System.Drawing.Size(118, 27);
            this.cATEGORIAToolStripMenuItem.Text = "CATEGORIA";
            // 
            // mARCAToolStripMenuItem
            // 
            this.mARCAToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.mARCAToolStripMenuItem.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mARCAToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mARCAToolStripMenuItem.Name = "mARCAToolStripMenuItem";
            this.mARCAToolStripMenuItem.Size = new System.Drawing.Size(84, 27);
            this.mARCAToolStripMenuItem.Text = "MARCA";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(881, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maxi Programa";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1080, 672);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1084, 711);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRABAJO PRACTICO FINAL";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aRTICULOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cATEGORIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mARCAToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

