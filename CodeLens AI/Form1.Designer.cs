namespace CodeLens_AI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtInputCode = new System.Windows.Forms.RichTextBox();
            this.txtOutputCode = new System.Windows.Forms.RichTextBox();
            this.txtExplanation = new System.Windows.Forms.RichTextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblOutputCode = new System.Windows.Forms.Label();
            this.lblOutputExplain = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Size = new System.Drawing.Size(1000, 80);

            // Form Settings
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeLens AI - v1.0";

            // lblHeader
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblHeader.Location = new System.Drawing.Point(25, 15);
            this.lblHeader.Text = "CodeLens AI";

            // txtInputCode
            this.txtInputCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtInputCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInputCode.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtInputCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtInputCode.Location = new System.Drawing.Point(30, 110);
            this.txtInputCode.Size = new System.Drawing.Size(940, 220);

            // btnAnalyze
            this.btnAnalyze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyze.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAnalyze.ForeColor = System.Drawing.Color.White;
            this.btnAnalyze.Location = new System.Drawing.Point(30, 345);
            this.btnAnalyze.Size = new System.Drawing.Size(220, 50);
            this.btnAnalyze.Text = "Generate Logic →";
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);

            // txtOutputCode
            this.txtOutputCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtOutputCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutputCode.Font = new System.Drawing.Font("Consolas", 10.5F);
            this.txtOutputCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.txtOutputCode.Location = new System.Drawing.Point(30, 440);
            this.txtOutputCode.ReadOnly = true;
            this.txtOutputCode.Size = new System.Drawing.Size(460, 210);

            // txtExplanation
            this.txtExplanation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtExplanation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExplanation.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.txtExplanation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(186)))), ((int)(((byte)(125)))));
            this.txtExplanation.Location = new System.Drawing.Point(520, 440);
            this.txtExplanation.ReadOnly = true;
            this.txtExplanation.Size = new System.Drawing.Size(450, 210);

            // lblStatus
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(85)))));
            this.lblStatus.Location = new System.Drawing.Point(30, 665);
            this.lblStatus.Text = "● Ready";

            // lblOutputCode & lblOutputExplain
            this.lblOutputCode.ForeColor = System.Drawing.Color.Gray;
            this.lblOutputCode.Location = new System.Drawing.Point(30, 415);
            this.lblOutputCode.Text = "DOCUMENTED CODE";
            this.lblOutputCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.lblOutputExplain.ForeColor = System.Drawing.Color.Gray;
            this.lblOutputExplain.Location = new System.Drawing.Point(520, 415);
            this.lblOutputExplain.Text = "EXPLANATION";
            this.lblOutputExplain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblOutputCode);
            this.Controls.Add(this.lblOutputExplain);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtExplanation);
            this.Controls.Add(this.txtOutputCode);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.txtInputCode);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RichTextBox txtInputCode;
        private System.Windows.Forms.RichTextBox txtOutputCode;
        private System.Windows.Forms.RichTextBox txtExplanation;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblOutputCode;
        private System.Windows.Forms.Label lblOutputExplain;
        private System.Windows.Forms.Panel panelHeader;
    }
}