namespace runner
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gbKonek = new System.Windows.Forms.GroupBox();
            this.btnDiscon = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnKonek = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.txtSerAdd = new System.Windows.Forms.TextBox();
            this.lbSerAdd = new System.Windows.Forms.Label();
            this.lblCommand = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnMulai = new System.Windows.Forms.Button();
            this.btnBerhenti = new System.Windows.Forms.Button();
            this.btnBuka = new System.Windows.Forms.Button();
            this.txtKonsol = new System.Windows.Forms.TextBox();
            this.lblKonsol = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnLoop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbKonek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKonek
            // 
            this.gbKonek.Controls.Add(this.btnDiscon);
            this.gbKonek.Controls.Add(this.lblStatus);
            this.gbKonek.Controls.Add(this.btnKonek);
            this.gbKonek.Controls.Add(this.txtPort);
            this.gbKonek.Controls.Add(this.lbPort);
            this.gbKonek.Controls.Add(this.txtSerAdd);
            this.gbKonek.Controls.Add(this.lbSerAdd);
            this.gbKonek.Location = new System.Drawing.Point(12, 7);
            this.gbKonek.Name = "gbKonek";
            this.gbKonek.Size = new System.Drawing.Size(694, 53);
            this.gbKonek.TabIndex = 1;
            this.gbKonek.TabStop = false;
            this.gbKonek.Text = "Connection";
            // 
            // btnDiscon
            // 
            this.btnDiscon.Location = new System.Drawing.Point(392, 13);
            this.btnDiscon.Name = "btnDiscon";
            this.btnDiscon.Size = new System.Drawing.Size(57, 31);
            this.btnDiscon.TabIndex = 4;
            this.btnDiscon.Text = "&Discon...";
            this.btnDiscon.UseVisualStyleBackColor = true;
            this.btnDiscon.Click += new System.EventHandler(this.btnDiscon_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(459, 14);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(226, 29);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "NOT CONNECTED";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKonek
            // 
            this.btnKonek.Location = new System.Drawing.Point(329, 13);
            this.btnKonek.Name = "btnKonek";
            this.btnKonek.Size = new System.Drawing.Size(57, 31);
            this.btnKonek.TabIndex = 2;
            this.btnKonek.Text = "&Connect";
            this.btnKonek.UseVisualStyleBackColor = true;
            this.btnKonek.Click += new System.EventHandler(this.btnKonek_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(261, 19);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(52, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "5250";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(229, 22);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(26, 13);
            this.lbPort.TabIndex = 2;
            this.lbPort.Text = "Port";
            // 
            // txtSerAdd
            // 
            this.txtSerAdd.AutoCompleteCustomSource.AddRange(new string[] {
            "172.19.54.3",
            "172.19.54.4",
            "172.19.54.5",
            "172.19.54.6",
            "172.19.54.7",
            "172.19.54.8",
            "172.19.54.9",
            "172.19.51.13",
            "172.19.51.11",
            "localhost"});
            this.txtSerAdd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSerAdd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSerAdd.Location = new System.Drawing.Point(91, 19);
            this.txtSerAdd.Name = "txtSerAdd";
            this.txtSerAdd.Size = new System.Drawing.Size(127, 20);
            this.txtSerAdd.TabIndex = 1;
            this.txtSerAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSerAdd.TextChanged += new System.EventHandler(this.txtSerAdd_TextChanged);
            // 
            // lbSerAdd
            // 
            this.lbSerAdd.AutoSize = true;
            this.lbSerAdd.Location = new System.Drawing.Point(6, 22);
            this.lbSerAdd.Name = "lbSerAdd";
            this.lbSerAdd.Size = new System.Drawing.Size(79, 13);
            this.lbSerAdd.TabIndex = 0;
            this.lbSerAdd.Text = "Server Address";
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Location = new System.Drawing.Point(9, 65);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(54, 13);
            this.lblCommand.TabIndex = 2;
            this.lblCommand.Text = "Command";
            // 
            // txtCommand
            // 
            this.txtCommand.Enabled = false;
            this.txtCommand.Location = new System.Drawing.Point(12, 81);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(694, 20);
            this.txtCommand.TabIndex = 3;
            this.txtCommand.TextChanged += new System.EventHandler(this.txtCommand_TextChanged);
            // 
            // btnMulai
            // 
            this.btnMulai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMulai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulai.Location = new System.Drawing.Point(12, 107);
            this.btnMulai.Name = "btnMulai";
            this.btnMulai.Size = new System.Drawing.Size(60, 38);
            this.btnMulai.TabIndex = 4;
            this.btnMulai.Text = "&Start";
            this.btnMulai.UseVisualStyleBackColor = false;
            this.btnMulai.Click += new System.EventHandler(this.btnMulai_Click);
            // 
            // btnBerhenti
            // 
            this.btnBerhenti.BackColor = System.Drawing.Color.Red;
            this.btnBerhenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBerhenti.Location = new System.Drawing.Point(144, 107);
            this.btnBerhenti.Name = "btnBerhenti";
            this.btnBerhenti.Size = new System.Drawing.Size(60, 38);
            this.btnBerhenti.TabIndex = 5;
            this.btnBerhenti.Text = "&Stop";
            this.btnBerhenti.UseVisualStyleBackColor = false;
            this.btnBerhenti.Click += new System.EventHandler(this.btnBerhenti_Click);
            // 
            // btnBuka
            // 
            this.btnBuka.Location = new System.Drawing.Point(606, 116);
            this.btnBuka.Name = "btnBuka";
            this.btnBuka.Size = new System.Drawing.Size(100, 29);
            this.btnBuka.TabIndex = 6;
            this.btnBuka.Text = "&Open File";
            this.btnBuka.UseVisualStyleBackColor = true;
            this.btnBuka.Click += new System.EventHandler(this.btnBuka_Click);
            // 
            // txtKonsol
            // 
            this.txtKonsol.BackColor = System.Drawing.Color.Black;
            this.txtKonsol.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKonsol.ForeColor = System.Drawing.Color.Lime;
            this.txtKonsol.Location = new System.Drawing.Point(12, 164);
            this.txtKonsol.Multiline = true;
            this.txtKonsol.Name = "txtKonsol";
            this.txtKonsol.Size = new System.Drawing.Size(215, 122);
            this.txtKonsol.TabIndex = 7;
            this.txtKonsol.Text = "Idle . . .";
            this.txtKonsol.TextChanged += new System.EventHandler(this.txtKonsol_TextChanged);
            // 
            // lblKonsol
            // 
            this.lblKonsol.AutoSize = true;
            this.lblKonsol.Location = new System.Drawing.Point(9, 148);
            this.lblKonsol.Name = "lblKonsol";
            this.lblKonsol.Size = new System.Drawing.Size(80, 13);
            this.lblKonsol.TabIndex = 8;
            this.lblKonsol.Text = "Console Debug";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(233, 107);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(365, 175);
            this.dgvData.TabIndex = 9;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLoop
            // 
            this.btnLoop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoop.Location = new System.Drawing.Point(78, 107);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(60, 38);
            this.btnLoop.TabIndex = 10;
            this.btnLoop.Text = "&Loop";
            this.btnLoop.UseVisualStyleBackColor = false;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(606, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gold;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(606, 148);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(718, 294);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoop);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lblKonsol);
            this.Controls.Add(this.txtKonsol);
            this.Controls.Add(this.btnBuka);
            this.Controls.Add(this.btnBerhenti);
            this.Controls.Add(this.btnMulai);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.gbKonek);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rolling Text CNN Indonesia";
            this.gbKonek.ResumeLayout(false);
            this.gbKonek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbKonek;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnKonek;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox txtSerAdd;
        private System.Windows.Forms.Label lbSerAdd;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnMulai;
        private System.Windows.Forms.Button btnBerhenti;
        private System.Windows.Forms.Button btnBuka;
        private System.Windows.Forms.TextBox txtKonsol;
        private System.Windows.Forms.Label lblKonsol;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.Button btnDiscon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
    }
}

