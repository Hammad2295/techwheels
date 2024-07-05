
namespace TournamentTrackerOne.PAL
{
    partial class ShoowTeamsinScore
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTTClose = new System.Windows.Forms.Button();
            this.grdTeamsinScore = new System.Windows.Forms.DataGridView();
            this.cmbTeamsinScore = new System.Windows.Forms.ComboBox();
            this.cmbtournamentInScore = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTeamsinScore)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.btnTTClose);
            this.panel1.Controls.Add(this.grdTeamsinScore);
            this.panel1.Controls.Add(this.cmbTeamsinScore);
            this.panel1.Controls.Add(this.cmbtournamentInScore);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 603);
            this.panel1.TabIndex = 0;
            // 
            // btnTTClose
            // 
            this.btnTTClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTTClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnTTClose.Location = new System.Drawing.Point(495, 531);
            this.btnTTClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTTClose.Name = "btnTTClose";
            this.btnTTClose.Size = new System.Drawing.Size(159, 43);
            this.btnTTClose.TabIndex = 54;
            this.btnTTClose.Text = "Close";
            this.btnTTClose.UseVisualStyleBackColor = false;
            this.btnTTClose.Click += new System.EventHandler(this.btnTTClose_Click);
            // 
            // grdTeamsinScore
            // 
            this.grdTeamsinScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTeamsinScore.Location = new System.Drawing.Point(291, 319);
            this.grdTeamsinScore.Margin = new System.Windows.Forms.Padding(4);
            this.grdTeamsinScore.Name = "grdTeamsinScore";
            this.grdTeamsinScore.RowHeadersWidth = 51;
            this.grdTeamsinScore.Size = new System.Drawing.Size(542, 185);
            this.grdTeamsinScore.TabIndex = 6;
            this.grdTeamsinScore.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTeamsinScore_CellContentClick);
            // 
            // cmbTeamsinScore
            // 
            this.cmbTeamsinScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeamsinScore.FormattingEnabled = true;
            this.cmbTeamsinScore.Location = new System.Drawing.Point(404, 239);
            this.cmbTeamsinScore.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTeamsinScore.Name = "cmbTeamsinScore";
            this.cmbTeamsinScore.Size = new System.Drawing.Size(384, 33);
            this.cmbTeamsinScore.TabIndex = 5;
            this.cmbTeamsinScore.SelectedIndexChanged += new System.EventHandler(this.cmbTeamsinScore_SelectedIndexChanged);
            // 
            // cmbtournamentInScore
            // 
            this.cmbtournamentInScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtournamentInScore.FormattingEnabled = true;
            this.cmbtournamentInScore.Location = new System.Drawing.Point(413, 154);
            this.cmbtournamentInScore.Margin = new System.Windows.Forms.Padding(4);
            this.cmbtournamentInScore.Name = "cmbtournamentInScore";
            this.cmbtournamentInScore.Size = new System.Drawing.Size(384, 33);
            this.cmbtournamentInScore.TabIndex = 4;
            this.cmbtournamentInScore.SelectedIndexChanged += new System.EventHandler(this.cmbtournamentInScore_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Team ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Tournament ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 106);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(439, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 39);
            this.label5.TabIndex = 3;
            this.label5.Text = "View Teams";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShoowTeamsinScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 603);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShoowTeamsinScore";
            this.Text = "ShoowTeamsinScore";
            this.Load += new System.EventHandler(this.ShoowTeamsinScore_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTeamsinScore)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbTeamsinScore;
        private System.Windows.Forms.ComboBox cmbtournamentInScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdTeamsinScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTTClose;
    }
}