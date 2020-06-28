namespace QuanLyMaQR_v2.Views
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /*protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFreeSizePrint = new System.Windows.Forms.Button();
            this.btnRowAndColumn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHorizontal = new System.Windows.Forms.TextBox();
            this.txtVertical = new System.Windows.Forms.TextBox();
            this.cbxRowAndColumn = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelResult = new System.Windows.Forms.Panel();
            this.picResult1 = new System.Windows.Forms.PictureBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDetailedView = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPreview = new System.Windows.Forms.Panel();
            this.picPreview2 = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.picPreview1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProductID = new System.Windows.Forms.Label();
            this.cbxProductType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxQRType = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoQRMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyMaQRDataSet = new QuanLyMaQR_v2.QuanLyMaQRDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.listProductsTableAdapter = new QuanLyMaQR_v2.QuanLyMaQRDataSetTableAdapters.ListProductsTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dtgListProduct = new System.Windows.Forms.DataGridView();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShow1D = new System.Windows.Forms.Button();
            this.btnShow2D = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.panelResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.panelPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyMaQRDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnFreeSizePrint);
            this.panel2.Controls.Add(this.btnRowAndColumn);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtHorizontal);
            this.panel2.Controls.Add(this.txtVertical);
            this.panel2.Controls.Add(this.cbxRowAndColumn);
            this.panel2.Location = new System.Drawing.Point(8, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 40);
            this.panel2.TabIndex = 35;
            // 
            // btnFreeSizePrint
            // 
            this.btnFreeSizePrint.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFreeSizePrint.Location = new System.Drawing.Point(261, 8);
            this.btnFreeSizePrint.Name = "btnFreeSizePrint";
            this.btnFreeSizePrint.Size = new System.Drawing.Size(142, 23);
            this.btnFreeSizePrint.TabIndex = 46;
            this.btnFreeSizePrint.Text = "In theo kích thước? Nhập:";
            this.btnFreeSizePrint.UseVisualStyleBackColor = false;
            this.btnFreeSizePrint.Click += new System.EventHandler(this.btnFreeSizePrint_Click);
            // 
            // btnRowAndColumn
            // 
            this.btnRowAndColumn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRowAndColumn.Location = new System.Drawing.Point(5, 9);
            this.btnRowAndColumn.Name = "btnRowAndColumn";
            this.btnRowAndColumn.Size = new System.Drawing.Size(118, 23);
            this.btnRowAndColumn.TabIndex = 21;
            this.btnRowAndColumn.Text = "Chọn số hàng và cột";
            this.btnRowAndColumn.UseVisualStyleBackColor = false;
            this.btnRowAndColumn.Click += new System.EventHandler(this.btnRowAndColumn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(466, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "x";
            // 
            // txtHorizontal
            // 
            this.txtHorizontal.Location = new System.Drawing.Point(484, 11);
            this.txtHorizontal.Name = "txtHorizontal";
            this.txtHorizontal.Size = new System.Drawing.Size(52, 20);
            this.txtHorizontal.TabIndex = 45;
            // 
            // txtVertical
            // 
            this.txtVertical.Location = new System.Drawing.Point(412, 11);
            this.txtVertical.Name = "txtVertical";
            this.txtVertical.Size = new System.Drawing.Size(52, 20);
            this.txtVertical.TabIndex = 44;
            // 
            // cbxRowAndColumn
            // 
            this.cbxRowAndColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRowAndColumn.FormattingEnabled = true;
            this.cbxRowAndColumn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbxRowAndColumn.Location = new System.Drawing.Point(133, 11);
            this.cbxRowAndColumn.Name = "cbxRowAndColumn";
            this.cbxRowAndColumn.Size = new System.Drawing.Size(116, 21);
            this.cbxRowAndColumn.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tuỳ chọn in";
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.Color.White;
            this.panelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResult.Controls.Add(this.picResult1);
            this.panelResult.Controls.Add(this.picResult);
            this.panelResult.Controls.Add(this.btnSave);
            this.panelResult.Controls.Add(this.btnDetailedView);
            this.panelResult.Controls.Add(this.label11);
            this.panelResult.Enabled = false;
            this.panelResult.Location = new System.Drawing.Point(299, 196);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(258, 300);
            this.panelResult.TabIndex = 31;
            // 
            // picResult1
            // 
            this.picResult1.Location = new System.Drawing.Point(52, 244);
            this.picResult1.Name = "picResult1";
            this.picResult1.Size = new System.Drawing.Size(153, 17);
            this.picResult1.TabIndex = 20;
            this.picResult1.TabStop = false;
            this.picResult1.Visible = false;
            // 
            // picResult
            // 
            this.picResult.BackColor = System.Drawing.Color.White;
            this.picResult.Location = new System.Drawing.Point(37, 54);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(180, 180);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResult.TabIndex = 18;
            this.picResult.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(176, 267);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDetailedView
            // 
            this.btnDetailedView.Location = new System.Drawing.Point(95, 267);
            this.btnDetailedView.Name = "btnDetailedView";
            this.btnDetailedView.Size = new System.Drawing.Size(75, 23);
            this.btnDetailedView.TabIndex = 15;
            this.btnDetailedView.Text = "Xem chi tiết";
            this.btnDetailedView.UseVisualStyleBackColor = true;
            this.btnDetailedView.Click += new System.EventHandler(this.btnDetailedView_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "QR Code";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(307, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "Kết quả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Điền thông tin";
            // 
            // panelPreview
            // 
            this.panelPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPreview.Controls.Add(this.picPreview2);
            this.panelPreview.Controls.Add(this.btnPrint);
            this.panelPreview.Controls.Add(this.picPreview1);
            this.panelPreview.Controls.Add(this.label8);
            this.panelPreview.Location = new System.Drawing.Point(6, 196);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(258, 300);
            this.panelPreview.TabIndex = 33;
            // 
            // picPreview2
            // 
            this.picPreview2.Image = ((System.Drawing.Image)(resources.GetObject("picPreview2.Image")));
            this.picPreview2.Location = new System.Drawing.Point(36, 54);
            this.picPreview2.Name = "picPreview2";
            this.picPreview2.Size = new System.Drawing.Size(180, 180);
            this.picPreview2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview2.TabIndex = 20;
            this.picPreview2.TabStop = false;
            this.picPreview2.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(176, 267);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // picPreview1
            // 
            this.picPreview1.Image = ((System.Drawing.Image)(resources.GetObject("picPreview1.Image")));
            this.picPreview1.Location = new System.Drawing.Point(36, 54);
            this.picPreview1.Name = "picPreview1";
            this.picPreview1.Size = new System.Drawing.Size(180, 180);
            this.picPreview1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview1.TabIndex = 17;
            this.picPreview1.TabStop = false;
            this.picPreview1.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "QR sau khi in sẽ trông như thế này";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "Xem trước";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblProductID);
            this.panel1.Controls.Add(this.cbxProductType);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbxQRType);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.txtProductID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 63);
            this.panel1.TabIndex = 28;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(106, 39);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(65, 13);
            this.lblProductID.TabIndex = 16;
            this.lblProductID.Text = "lblProductID";
            this.lblProductID.Visible = false;
            // 
            // cbxProductType
            // 
            this.cbxProductType.BackColor = System.Drawing.SystemColors.Window;
            this.cbxProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProductType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbxProductType.FormattingEnabled = true;
            this.cbxProductType.Items.AddRange(new object[] {
            "Đồ gia dụng",
            "Linh kiện - Điện tử",
            "Nước uống",
            "Thực phẩm",
            "Văn phòng phẩm",
            "Khác"});
            this.cbxProductType.Location = new System.Drawing.Point(109, 5);
            this.cbxProductType.Name = "cbxProductType";
            this.cbxProductType.Size = new System.Drawing.Size(142, 21);
            this.cbxProductType.TabIndex = 1;
            this.cbxProductType.SelectedIndexChanged += new System.EventHandler(this.cbxProductType_SelectedIndexChanged);
            this.cbxProductType.SelectedValueChanged += new System.EventHandler(this.cbxProductType_SelectedValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Loại hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Chọn định dạng QR";
            // 
            // cbxQRType
            // 
            this.cbxQRType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQRType.FormattingEnabled = true;
            this.cbxQRType.Items.AddRange(new object[] {
            "1D",
            "2D"});
            this.cbxQRType.Location = new System.Drawing.Point(396, 5);
            this.cbxQRType.Name = "cbxQRType";
            this.cbxQRType.Size = new System.Drawing.Size(142, 21);
            this.cbxQRType.TabIndex = 4;
            this.cbxQRType.SelectedValueChanged += new System.EventHandler(this.cbxQRType_SelectedValueChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(396, 36);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(142, 20);
            this.txtProductName.TabIndex = 3;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(135, 36);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(116, 20);
            this.txtProductID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên sản phẩm (không dấu)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã sản phẩm";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.xemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1128, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoQRMớiToolStripMenuItem,
            this.thoátToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tạoQRMớiToolStripMenuItem
            // 
            this.tạoQRMớiToolStripMenuItem.Name = "tạoQRMớiToolStripMenuItem";
            this.tạoQRMớiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tạoQRMớiToolStripMenuItem.Text = "Tạo QR mới";
            this.tạoQRMớiToolStripMenuItem.Click += new System.EventHandler(this.tạoQRMớiToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // xemToolStripMenuItem
            // 
            this.xemToolStripMenuItem.Name = "xemToolStripMenuItem";
            this.xemToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.xemToolStripMenuItem.Text = "Ẩn/ Hiện Danh Sách";
            this.xemToolStripMenuItem.Click += new System.EventHandler(this.xemToolStripMenuItem_Click);
            // 
            // listProductsBindingSource
            // 
            this.listProductsBindingSource.DataMember = "ListProducts";
            this.listProductsBindingSource.DataSource = this.quanLyMaQRDataSet;
            // 
            // quanLyMaQRDataSet
            // 
            this.quanLyMaQRDataSet.DataSetName = "QuanLyMaQRDataSet";
            this.quanLyMaQRDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Danh sách sản phẩm";
            // 
            // listProductsTableAdapter
            // 
            this.listProductsTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1041, 474);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(579, 474);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 23);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtgListProduct
            // 
            this.dtgListProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgListProduct.AutoGenerateColumns = false;
            this.dtgListProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTTDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn});
            this.dtgListProduct.DataSource = this.listProductsBindingSource;
            this.dtgListProduct.Location = new System.Drawing.Point(579, 53);
            this.dtgListProduct.Name = "dtgListProduct";
            this.dtgListProduct.Size = new System.Drawing.Size(537, 415);
            this.dtgListProduct.TabIndex = 39;
            this.dtgListProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListProduct_CellClick);
            this.dtgListProduct.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListProduct_CellEndEdit);
            this.dtgListProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgListProduct_KeyDown);
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            this.sTTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTTDataGridViewTextBoxColumn.Width = 50;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            this.productTypeDataGridViewTextBoxColumn.Width = 180;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // btnShow1D
            // 
            this.btnShow1D.Location = new System.Drawing.Point(865, 474);
            this.btnShow1D.Name = "btnShow1D";
            this.btnShow1D.Size = new System.Drawing.Size(82, 23);
            this.btnShow1D.TabIndex = 40;
            this.btnShow1D.Text = "Show QR 1D";
            this.btnShow1D.UseVisualStyleBackColor = true;
            this.btnShow1D.Click += new System.EventHandler(this.btnShow1D_Click);
            // 
            // btnShow2D
            // 
            this.btnShow2D.Location = new System.Drawing.Point(953, 474);
            this.btnShow2D.Name = "btnShow2D";
            this.btnShow2D.Size = new System.Drawing.Size(82, 23);
            this.btnShow2D.TabIndex = 41;
            this.btnShow2D.Text = "Show QR 2D";
            this.btnShow2D.UseVisualStyleBackColor = true;
            this.btnShow2D.Click += new System.EventHandler(this.btnShow2D_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(898, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(953, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(163, 20);
            this.txtSearch.TabIndex = 42;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1128, 503);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnShow2D);
            this.Controls.Add(this.btnShow1D);
            this.Controls.Add(this.dtgListProduct);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panelPreview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Mã QR";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResult1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.panelPreview.ResumeLayout(false);
            this.panelPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyMaQRDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelResult;
        public System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDetailedView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPreview;
        private System.Windows.Forms.PictureBox picPreview2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PictureBox picPreview1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxProductType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxQRType;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoQRMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemToolStripMenuItem;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label label4;
        private QuanLyMaQRDataSet quanLyMaQRDataSet;
        private System.Windows.Forms.BindingSource listProductsBindingSource;
        private System.ComponentModel.IContainer components;
        private QuanLyMaQRDataSetTableAdapters.ListProductsTableAdapter listProductsTableAdapter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dtgListProduct;
        private System.Windows.Forms.Button btnShow1D;
        private System.Windows.Forms.Button btnShow2D;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbxRowAndColumn;
        private System.Windows.Forms.PictureBox picResult1;
        private System.Windows.Forms.TextBox txtHorizontal;
        private System.Windows.Forms.TextBox txtVertical;
        private System.Windows.Forms.Button btnFreeSizePrint;
        private System.Windows.Forms.Button btnRowAndColumn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
    }
}

