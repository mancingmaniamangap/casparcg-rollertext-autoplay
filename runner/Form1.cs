using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using System.IO;
using Svt.Caspar;


namespace runner
{
    public partial class frmMain : Form
    {
        System.Net.Sockets.TcpClient casparClient = new System.Net.Sockets.TcpClient();
        CasparDevice caspar_ = new CasparDevice();
        CasparCGDataCollection cgData = new CasparCGDataCollection();

        public frmMain()
        {
            InitializeComponent();

            btnMulai.Enabled = false;
            btnBerhenti.Enabled = false;
            btnLoop.Enabled = false;
            btnBuka.Enabled = false;
            btnDiscon.Enabled = false;
        }

        public void open()
        {
            DataSet dsResult = new DataSet();
            dsResult.ReadXml(@"CNN4.xml");
            if(dsResult.Tables.Count != 0)
            {
                if(dsResult.Tables[0].Rows.Count > 0)
                {
                    dgvData.DataSource = dsResult.Tables[0];
                }
            }
        }

        public void konek()
        {
            try
            {
                if (!caspar_.IsConnected)
                {
                    caspar_.Settings.Hostname = txtSerAdd.Text;
                    caspar_.Settings.Port = int.Parse(txtPort.Text);
                    caspar_.Connect();
                    lblStatus.Text = "CONNECTED";
                    lblStatus.ForeColor = Color.Green;
                    txtKonsol.Text += Environment.NewLine + "Caspar Server Connected!" + Environment.NewLine;
                }
                else
                {
                    caspar_.Disconnect();
                    lblStatus.Text = "NOT CONNECTED";
                    lblStatus.ForeColor = Color.Red;
                    txtKonsol.Text += Environment.NewLine + "Unable to Connect to Caspar Server!" + Environment.NewLine;
                }
            }
            catch (Exception)
            {
                txtKonsol.Text += Environment.NewLine + "Unable to Connect to Caspar Server, Server Refused!" + Environment.NewLine;
            }  
        }

        public void openopen()
        {
            DataGridView dgvData = new DataGridView();
            //dataGridView1.Dock = DockStyle.Fill;

            //Read the data from text file
            string[] textData = System.IO.File.ReadAllLines(@"ROLLINGTEXT.txt");
            string[] headers = textData[0].Split('|');

            //Create and populate DataTable
            DataTable dataTable1 = new DataTable();
            foreach (string header in headers)
                dataTable1.Columns.Add(header, typeof(string), null);
            for (int i = 1; i < textData.Length; i++)
                dataTable1.Rows.Add(textData[i]);//.Split('.'));

            //Set the DataSource of DataGridView to the DataTable
            this.dgvData.DataSource = dataTable1;
            //form1.Controls.Add(dataGridView1);
            //form1.ShowDialog();
        }

        private void btnBuka_Click(object sender, EventArgs e)
        {
            //open();
            openopen();
            btnMulai.Enabled = true;
        }

        private void btnKonek_Click(object sender, EventArgs e)
        {
            konek();
            btnBuka.Enabled = true;
            if(lblStatus.Text == "CONNECTED")
            {
                btnKonek.Enabled = false;
                btnDiscon.Enabled = true;
                txtSerAdd.Enabled = false;
                txtPort.Enabled = false;
            }
            else
            {
                btnKonek.Enabled = true;
                txtSerAdd.Enabled = true;
                txtPort.Enabled = true;
            }
        }

        private void btnMulai_Click(object sender, EventArgs e)
        {
            try
            {
                cgData.Clear();
                cgData.SetData("f0", dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                //cgData.SetData("f0", txtCommand.Text);
                caspar_.Channels[0].CG.Add(22, 1, "CNN_ROLL", true, cgData);
            }
            catch (Exception)
            {
                txtKonsol.Text += Environment.NewLine + "Something Wrong." + Environment.NewLine;
            }
            btnBerhenti.Enabled = true;
            btnLoop.Enabled = true;
            btnMulai.Enabled = false;
            btnBuka.Enabled = false;
            dgvData.Enabled = false;
        }

        private void btnBerhenti_Click(object sender, EventArgs e)
        {
            try
            {
                caspar_.Channels[0].CG.Stop(22, 1);
                caspar_.Channels[0].CG.Clear();
                timer1.Stop();
            }
            catch (Exception)
            {
                txtKonsol.Text += Environment.NewLine + "Something Wrong." + Environment.NewLine;
            }
            
            //dgvData.MultiSelect = false;
            //dgvData.MultiSelect = true;
            //dgvData.Refresh;
            //dgvData.ClearSelection();
            openopen();
            btnMulai.Enabled = true;
            btnBerhenti.Enabled = false;
            btnLoop.Enabled = false;
            dgvData.Enabled = true;
            //btnBuka.Enabled = true;
            //dgvData.Rows[0].Selected = true;
            //dgvData.Columns[0].Selected = true;
        }
         
        private void txtKonsol_TextChanged(object sender, EventArgs e)
        {
            txtKonsol.SelectionStart = txtKonsol.TextLength;
            txtKonsol.ScrollToCaret();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i;
            //i = dgvData.SelectedCells[0].RowIndex;
            //txtCommand.Text = dgvData.Rows[i].Cells[0].Value.ToString();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnBuka.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(dgvData.Rows.Count > 0)
            {
                int counter = dgvData.CurrentRow.Index + 1;
                DataGridViewRow nextRow = new DataGridViewRow();
                if (counter == dgvData.RowCount)
                {
                    nextRow = dgvData.Rows[0];
                }
                else
                {
                    nextRow = dgvData.Rows[counter];
                }
                dgvData.CurrentCell = nextRow.Cells[0];
                nextRow.Selected = true;
                cgData.Clear();
                cgData.SetData("f0", dgvData.Rows[dgvData.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                caspar_.Channels[0].CG.Update(22, 1, cgData);
                caspar_.Channels[0].CG.Next(22, 1);
            }
        }

        private void btnDiscon_Click(object sender, EventArgs e)
        {
            caspar_.Channels[0].CG.Stop(22, 1);
            caspar_.Channels[0].CG.Clear();
            timer1.Stop();

            caspar_.Disconnect();
            lblStatus.Text = "NOT CONNECTED";
            lblStatus.ForeColor = Color.Red;
            txtKonsol.Text += Environment.NewLine + "Disconnected from Server!" + Environment.NewLine;

            btnKonek.Enabled = true;
            btnDiscon.Enabled = false;
            btnBuka.Enabled = false;
            btnBerhenti.Enabled = false;
            btnLoop.Enabled = false;
            btnMulai.Enabled = false;
            txtSerAdd.Enabled = true;
            txtPort.Enabled = true;
            dgvData.Columns.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtCommand_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSerAdd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
