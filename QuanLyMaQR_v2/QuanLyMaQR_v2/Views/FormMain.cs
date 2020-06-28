using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyMaQR_v2.Controllers;
using QuanLyMaQR_v2.Models;
using ZXing;

namespace QuanLyMaQR_v2.Views
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            BindingSource source = new BindingSource();
            source.DataSource = QRController.getListProduct();
            this.dtgListProduct.DataSource = source;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyMaQRDataSet.ListProducts' table. You can move, or remove it, as needed.
            //this.listProductsTableAdapter.Fill(this.quanLyMaQRDataSet.Li;
            this.Size = new Size(579, 542);
            this.lblProductID.Visible = false;
            this.txtProductID.Location = new Point(109,36);
            this.txtProductID.Size = new Size(142, 20);
            this.btnDelete.Enabled = false;
            this.btnShow1D.Enabled = false;
            this.btnShow2D.Enabled = false;
        }
        private void cbxProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region rutgoncode
            if (this.cbxProductType.SelectedIndex == 0)
            {
                lblProductID.Text = "GD -";
                this.lblProductID.Visible = true;
                this.txtProductID.Size = new Size(116, 20);
                this.txtProductID.Location = new Point(135, 36);
            }
            else if (this.cbxProductType.SelectedIndex == 1)
            {
                lblProductID.Text = "LK -";
                this.lblProductID.Visible = true;
                this.txtProductID.Size = new Size(116, 20);
                this.txtProductID.Location = new Point(135, 36);
            }
            else if (this.cbxProductType.SelectedIndex == 2)
            {
                lblProductID.Text = "NU -";
                this.lblProductID.Visible = true;
                this.txtProductID.Size = new Size(116, 20);
                this.txtProductID.Location = new Point(135, 36);
            }
            else if (this.cbxProductType.SelectedIndex == 3)
            {
                lblProductID.Text = "TP -";
                this.lblProductID.Visible = true;
                this.txtProductID.Size = new Size(116, 20);
                this.txtProductID.Location = new Point(135, 36);
            }
            else if (this.cbxProductType.SelectedIndex == 4)
            {
                lblProductID.Text = "VP -";
                this.lblProductID.Visible = true;
                this.txtProductID.Size = new Size(116, 20);
                this.txtProductID.Location = new Point(135, 36);
            }
            else if (this.cbxProductType.SelectedIndex == 5)
            {
                lblProductID.Text = "KH -";
                this.lblProductID.Visible = true;
                this.txtProductID.Size = new Size(116, 20);
                this.txtProductID.Location = new Point(135, 36);
            }
            #endregion
        }
        private void cbxProductType_SelectedValueChanged(object sender, EventArgs e)
        {
            this.btnPrint.Enabled = true;
        }
        //
        private void cbxQRType_SelectedValueChanged(object sender, EventArgs e)
        {
            this.panelPreview.Enabled = true;

            if (this.cbxProductType.SelectedIndex != -1)
            {
                if (this.cbxQRType.SelectedItem.ToString() == "1D")
                {
                    this.picPreview2.Visible = false;
                    this.picPreview1.Visible = true;
                    this.btnPrint.Enabled = true;

                    this.txtHorizontal.Enabled = true;
                    this.txtVertical.Enabled = true;
                    this.cbxRowAndColumn.Enabled = true;
                }
                else if (this.cbxQRType.SelectedItem.ToString() == "2D")
                {
                    this.picPreview1.Visible = false;
                    this.picPreview2.Visible = true;
                    this.btnPrint.Enabled = true;

                    this.txtHorizontal.Enabled = true;
                    this.txtVertical.Enabled = true;
                    this.cbxRowAndColumn.Enabled = true;
                }
                else
                {
                    this.picPreview1.Visible = false;
                    this.picPreview2.Visible = false;
                    this.btnPrint.Enabled = false;
                }
            }
            else
            {
                //return;
            }
        }
        private void tạoQRMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lblProductID.Visible = false;
            this.cbxProductType.SelectedIndex = -1;
            this.cbxQRType.SelectedIndex = -1;
            this.txtProductID.Clear();
            this.txtProductName.Clear();
            this.txtProductID.Location = new Point(109, 36);
            this.txtProductID.Size = new Size(142, 20);
        }
        private void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region chinhsizeform
            if (this.Size == new Size(579, 542))
            {
                this.Size = new Size(1144, 542);
            }
            else
            {
                this.Size = new Size(579, 542);
            }
            #endregion
            this.panelPreview.Enabled = false;
        }
        private void txtVerticalAndHorizontal_TextChanged(object sender, EventArgs e)
        {
            this.cbxRowAndColumn.SelectedIndex = -1;
            this.cbxRowAndColumn.Enabled = false;
        }

        private void cbxRowAndColumn_TextChanged(object sender, EventArgs e)
        {
            this.txtHorizontal.Enabled = false;
            this.txtVertical.Enabled = false;
        }

        private void btnRowAndColumn_Click(object sender, EventArgs e)
        {
            this.txtHorizontal.Enabled = false;
            this.txtVertical.Enabled = false;

            this.cbxRowAndColumn.Enabled = true;
        }

        private void btnFreeSizePrint_Click(object sender, EventArgs e)
        {
            this.cbxRowAndColumn.SelectedIndex = -1;
            this.cbxRowAndColumn.Enabled = false;

            this.txtHorizontal.Enabled = true;
            this.txtVertical.Enabled = true;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtHorizontal.Text.Length <= 0 && txtVertical.Text.Length <= 0)
            {
                if (cbxQRType.SelectedItem.ToString() == "1D")
                {
                    if (txtProductID.Text.ToString().Length <= 0)
                    {
                        MessageBox.Show("Hãy nhập mã hàng", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    Zen.Barcode.Code128BarcodeDraw qrcode1d = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                    string lblProductIDCut = lblProductID.ToString().Replace(" ", "");
                    picResult.Image = qrcode1d.Draw(lblProductIDCut.Trim() + txtProductID.Text.Trim() + " | " + txtProductName.Text.ToString(), 100);



                    if (cbxRowAndColumn.Text.Length <= 0)
                    {
                        cbxRowAndColumn.SelectedIndex = 0;
                    }
                    if (cbxRowAndColumn.SelectedItem.ToString() == "1")
                    {
                        this.btnDetailedView.Enabled = false;
                    }
                    else if (cbxRowAndColumn.SelectedItem.ToString() == "2")
                    {
                        #region cotvadong=2
                        Image imgsmall = this.picResult.Image;
                        int width = 380;                                //adjustable
                        int height = 380;                              //adjustable
                        Bitmap imgFinal = new Bitmap(width, height);
                        xuLyIn(width, height, imgsmall, imgFinal);
                        #endregion
                    }
                    else if (cbxRowAndColumn.SelectedItem.ToString() == "3")
                    {
                        #region cotvadong=3
                        Image imgsmall = this.picResult.Image;
                        int width = 570;                                //adjustable
                        int height = 570;                              //adjustable
                        Bitmap imgFinal = new Bitmap(width, height);
                        xuLyIn(width, height, imgsmall, imgFinal);
                        #endregion
                    }
                    else if (cbxRowAndColumn.SelectedItem.ToString() == "4")
                    {
                        #region cotvadong=4
                        Image imgsmall = this.picResult.Image;
                        int width = 760;                                //adjustable
                        int height = 760;                              //adjustable
                        Bitmap imgFinal = new Bitmap(width, height);
                        xuLyIn(width, height, imgsmall, imgFinal);
                        #endregion
                    }

                    FormQRsInGrid frmQRsInGrid = new FormQRsInGrid(this.picResult1.Image, this.cbxRowAndColumn, this.txtHorizontal, this.txtVertical);
                    this.panelResult.Enabled = true;
                    this.picResult.Visible = true;
                    this.btnSave.Enabled = true;
                    if (this.cbxRowAndColumn.SelectedIndex != 0)
                        this.btnDetailedView.Enabled = true;
                }
                else if (cbxQRType.SelectedItem.ToString() == "2D")
                {
                    if (txtProductID.Text.ToString().Length <= 0)
                    {
                        MessageBox.Show("Hãy nhập mã hàng", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    Zen.Barcode.CodeQrBarcodeDraw qrcode2d = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                    string lblProductIDCut = lblProductID.Text.Replace(" ", "");
                    picResult.Image = qrcode2d.Draw(lblProductIDCut.Trim() + txtProductID.Text.Trim() + " | " + txtProductName.Text.ToString(), 50);

                    if (cbxRowAndColumn.Text.Length <= 0)
                    {
                        cbxRowAndColumn.SelectedIndex = 0;
                    }
                    if (cbxRowAndColumn.SelectedItem.ToString() == "1")
                    {
                        this.btnDetailedView.Enabled = false;
                    }
                    else if (cbxRowAndColumn.SelectedItem.ToString() == "2")
                    {
                        #region cotvadong=2
                        Image imgsmall = this.picResult.Image;
                        int width = 380;                                //adjustable
                        int height = 380;                              //adjustable
                        Bitmap imgFinal = new Bitmap(width, height);
                        xuLyIn(width, height, imgsmall, imgFinal);
                        #endregion
                    }
                    else if (cbxRowAndColumn.SelectedItem.ToString() == "3")
                    {
                        #region cotvadong=3
                        Image imgsmall = this.picResult.Image;
                        int width = 570;                                //adjustable
                        int height = 570;                              //adjustable
                        Bitmap imgFinal = new Bitmap(width, height);
                        xuLyIn(width, height, imgsmall, imgFinal);
                        #endregion
                    }
                    else if (cbxRowAndColumn.SelectedItem.ToString() == "4")
                    {
                        #region cotvadong=4
                        Image imgsmall = this.picResult.Image;
                        int width = 760;                                //adjustable
                        int height = 760;                              //adjustable
                        Bitmap imgFinal = new Bitmap(width, height);
                        xuLyIn(width, height, imgsmall, imgFinal);
                        #endregion
                    }
                    FormQRsInGrid frmQRsInGrid = new FormQRsInGrid(this.picResult1.Image, this.cbxRowAndColumn, this.txtHorizontal, this.txtVertical);
                    this.panelResult.Enabled = true;
                    this.picResult.Visible = true;
                    this.btnSave.Enabled = true;
                    if (this.cbxRowAndColumn.SelectedIndex != 0)
                        this.btnDetailedView.Enabled = true;
                }
            }
            else
            {
                
                //this.cbxRowAndColumn.SelectedIndex = 0;
                if (txtProductID.Text.ToString().Length <= 0)
                {
                    MessageBox.Show("Hãy nhập mã hàng", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                Zen.Barcode.CodeQrBarcodeDraw qrcode2d = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                string lblProductIDCut = lblProductID.Text.Replace(" ", "");
                picResult.Image = qrcode2d.Draw(lblProductIDCut.Trim() + txtProductID.Text.Trim() + " | " + txtProductName.Text.ToString(), 50);
                Image imgsmall = this.picResult.Image;
                int width = Convert.ToInt32(this.txtHorizontal.Text);
                int height = Convert.ToInt32(this.txtVertical.Text);
                Bitmap imgFinal = new Bitmap(width, height);
                xuLyIn(width, height, imgsmall, imgFinal);

                this.panelResult.Enabled = true;
                this.picResult.Visible = true;
                this.btnSave.Enabled = true;
                this.btnDetailedView.Enabled = true;
            }
        }
        void xuLyIn(int Width, int Height, Image Imgsmall, Bitmap Imgfinal)
        {
            Graphics g = Graphics.FromImage(Imgfinal);
            g.Clear(Color.WhiteSmoke);
            for (int i=5;i<=Width;i+=190)
            {
                for (int j=5;j<=Height;j+=190)
                {
                    g.DrawImage(Imgsmall, new Point(i, j));
                }
                this.picResult1.Image = Imgfinal;
            }
        }
        private void btnDetailedView_Click(object sender, EventArgs e)
        {
            FormQRsInGrid frmQRsInGrid = new FormQRsInGrid(this.picResult1.Image,this.cbxRowAndColumn,this.txtHorizontal,this.txtVertical);
            frmQRsInGrid.Show();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string lblProductIDCut = lblProductID.Text.Replace(" ", "");
            string ProductIDCut = lblProductIDCut.Trim() + txtProductID.Text;
            if (QRController.getProduct(ProductIDCut) != null)
            {
                MessageBox.Show("Sản phẩm này đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            ListProduct product = new ListProduct();
            product.ProductID = ProductIDCut;
            product.ProductType = this.cbxProductType.Text;
            product.ProductName = this.txtProductName.Text;
            if (QRController.AddProduct(product) == false)
            {
                MessageBox.Show("Lỗi thêm sản phẩm", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            BindingSource source = new BindingSource();
            source.DataSource = QRController.getListProduct();
            this.dtgListProduct.DataSource = source;
            this.btnSave.Enabled = false;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            source.DataSource = QRController.getListProduct();
            this.dtgListProduct.DataSource = source;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dtgListProduct.SelectedRows.Count <= 0)
                return;
            if (this.dtgListProduct.SelectedRows[0].Cells[1].Value is null)
            {
                MessageBox.Show("Không có giá trị để xoá", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                
                ListProduct product = QRController.getProduct(this.dtgListProduct.SelectedRows[0].Cells[1].Value.ToString());
                if (QRController.DeleteProduct(product) == false)
                {
                    MessageBox.Show("Lỗi xoá sản phẩm", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }

            BindingSource source = new BindingSource();
            source.DataSource = QRController.getListProduct();
            this.dtgListProduct.DataSource = source;

            this.btnDelete.Enabled = false;
        }


        private void dtgListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.btnDelete.Enabled = true;
                this.panelPreview.Enabled = false;
                this.picPreview1.Visible = false; this.picPreview2.Visible = false; this.picResult.Visible = false;
                this.btnShow1D.Enabled = true;
                this.btnShow2D.Enabled = true;

                if (dtgListProduct.SelectedRows.Count > 0)
                {
                    if (this.dtgListProduct.SelectedRows[0].Cells[1].Value is null)
                        this.dtgListProduct.SelectedRows[0].Cells[1].Value = "";
                    string chuoilblProductID = this.dtgListProduct.SelectedRows[0].Cells[1].Value.ToString().Substring(0, 3);


                    string chuoiProductID = this.dtgListProduct.SelectedRows[0].Cells[1].Value.ToString().Substring(chuoilblProductID.Length);
                    this.lblProductID.Text = chuoilblProductID;
                    this.txtProductID.Text = chuoiProductID;
                    this.txtProductName.Text = this.dtgListProduct.SelectedRows[0].Cells[3].Value.ToString();
                    this.txtProductID.Size = new Size(116, 20);
                    this.txtProductID.Location = new Point(135, 36);
                    this.lblProductID.Visible = true;
                    if (chuoilblProductID == "GD-")
                        this.cbxProductType.SelectedIndex = 0;
                    else if (chuoilblProductID == "LK-")
                        this.cbxProductType.SelectedIndex = 1;
                    else if (chuoilblProductID == "NU-")
                        this.cbxProductType.SelectedIndex = 2;
                    else if (chuoilblProductID == "TP-")
                        this.cbxProductType.SelectedIndex = 3;
                    else if (chuoilblProductID == "KH-")
                        this.cbxProductType.SelectedIndex = 4;
                }
            }
            catch
            {
                return;
            }
        }

        private void btnShow1D_Click(object sender, EventArgs e)
        {
            try
            {
                var prdID = this.dtgListProduct.SelectedRows[0].Cells[1].Value.ToString();
                Zen.Barcode.Code128BarcodeDraw qrcode1d = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                picResult.Image = qrcode1d.Draw(prdID.ToString() + " | " + this.dtgListProduct.SelectedRows[0].Cells[3].Value.ToString(), 50);
                this.picResult.Visible = true;
                this.panelResult.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Không có giá trị", "Thông báo", MessageBoxButtons.OK);
                return;
            }

        }

        private void btnShow2D_Click(object sender, EventArgs e)
        {
            try
            {
                var prdID = this.dtgListProduct.SelectedRows[0].Cells[1].Value.ToString();
                Zen.Barcode.CodeQrBarcodeDraw qrcode2d = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                picResult.Image = qrcode2d.Draw(prdID + " | " + this.dtgListProduct.SelectedRows[0].Cells[3].Value.ToString(), 50);
                this.picResult.Visible = true;
                this.panelResult.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Không có giá trị", "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void dtgListProduct_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ListProduct product = new ListProduct();
            product.STT = Convert.ToInt32(this.dtgListProduct.CurrentRow.Cells[0].Value.ToString());
            if (product.STT <= 0) return;
            if (this.dtgListProduct.CurrentRow.Cells[1].Value is null)
                this.dtgListProduct.CurrentRow.Cells[1].Value = "";
            product.ProductID = this.dtgListProduct.CurrentRow.Cells[1].Value.ToString();
            if (this.dtgListProduct.CurrentRow.Cells[2].Value is null)
                this.dtgListProduct.CurrentRow.Cells[2].Value = "";
            product.ProductType = this.dtgListProduct.CurrentRow.Cells[2].Value.ToString();
            if (this.dtgListProduct.CurrentRow.Cells[3].Value is null)
                this.dtgListProduct.CurrentRow.Cells[3].Value = "";
            product.ProductName = this.dtgListProduct.CurrentRow.Cells[3].Value.ToString();
            QRController.UpdateQRProduct(product);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DBQuanLyMaQREntities db = new DBQuanLyMaQREntities();
            if (this.txtSearch.Text.Trim().Length <= 0)
            {
                BindingSource source = new BindingSource();
                source.DataSource = QRController.getListProduct();
                this.dtgListProduct.DataSource = source;
            }
            else
            {
                dtgListProduct.DataSource = db.ListProduct.Where(x => x.ProductName.Contains(txtSearch.Text) || x.ProductID.Contains(txtSearch.Text)).ToList();
            }
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutUs frmAboutUs = new FormAboutUs();
            frmAboutUs.Show();
        }

        private void dtgListProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (this.dtgListProduct.SelectedRows.Count > 0)
                {
                    ListProduct product = QRController.getProduct(this.dtgListProduct.SelectedRows[0].Cells[1].Value.ToString());
                    if (QRController.DeleteProduct(product) == false)
                    {
                        MessageBox.Show("Lỗi xoá sản phẩm", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
        }
    }
}


/*//#region cotvadong=4
Image imgsmall = this.picResult.Image;
int width = 760;                                //adjustable
int height = 760;                              //adjustable
Bitmap imgFinal = new Bitmap(width, height);
/*Graphics g = Graphics.FromImage(imgFinal);
g.Clear(Color.WhiteSmoke);
for (int i = 5; i <= 760; i += 190)             //adjustable
{
    for (int j = 5; j <= 760; j += 190)        //adjustable
    {
        g.DrawImage(imgsmall, new Point(i, j));
    }
    picResult1.Image = imgFinal;
}
#endregion
xuLyIn(width, height, imgsmall, imgFinal);*/