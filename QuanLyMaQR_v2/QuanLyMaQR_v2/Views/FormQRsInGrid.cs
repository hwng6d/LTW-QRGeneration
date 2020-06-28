using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMaQR_v2.Views
{
    public partial class FormQRsInGrid : Form
    {
        public FormQRsInGrid(Image getPicResult1, ComboBox cbxRowAndColumnText, TextBox getHorizontal, TextBox getVertical)
        {
            InitializeComponent();
            this.picDetailedView.Image = getPicResult1;
            string giatri = cbxRowAndColumnText.Text.ToString();
            if (giatri == "2")
            {
                this.picDetailedView.Size = new Size(380, 380);
                this.btnSaveTo.Location = new Point(305,5);
                this.Size = new Size(415,459);
            }
            else if (giatri == "3")
            {
                this.picDetailedView.Size = new Size(570, 570);
                this.btnSaveTo.Location = new Point(505, 5);
                this.Size = new Size(606, 653);
            }
            else if (giatri == "4")
            {
                this.picDetailedView.Size = new Size(760, 760);
                this.btnSaveTo.Location = new Point(684, 5);
                this.Size = new Size(790, 837);
            }
            else
            {
                this.picDetailedView.Size = new Size(760, 760);
                this.btnSaveTo.Location = new Point(684, 5);
                this.Size = new Size(790, 837);
            }
        }

        private void FormQRsInGrid_Load(object sender, EventArgs e)
        {
            this.btnSaveTo.Enabled = true;
        }

        private void btnSaveTo_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPG(*.JPG)|*.jpg";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                picDetailedView.Image.Save(sf.FileName);
                MessageBox.Show("Đã lưu", "Thông báo", MessageBoxButtons.OK);
                this.btnSaveTo.Enabled = false;
            }
            else
            {
                this.btnSaveTo.Enabled = true;
            }
        }
    }
}
