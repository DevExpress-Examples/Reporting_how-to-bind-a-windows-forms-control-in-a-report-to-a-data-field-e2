namespace BindWinControl {
    partial class XtraReport1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.nwindDataSet1 = new BindWinControl.nwindDataSet();
            this.categoriesTableAdapter = new BindWinControl.nwindDataSetTableAdapters.CategoriesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.winControlContainer1 = new DevExpress.XtraReports.UI.WinControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.winControlContainer1});
            this.Detail.Height = 57;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // nwindDataSet1
            // 
            this.nwindDataSet1.DataSetName = "nwindDataSet";
            this.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // winControlContainer1
            // 
            this.winControlContainer1.Location = new System.Drawing.Point(8, 8);
            this.winControlContainer1.Name = "winControlContainer1";
            this.winControlContainer1.Size = new System.Drawing.Size(167, 42);
            this.winControlContainer1.WinControl = this.button1;
            this.winControlContainer1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.winControlContainer1_BeforePrint);
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
            this.DataAdapter = this.categoriesTableAdapter;
            this.DataMember = "Categories";
            this.DataSource = this.nwindDataSet1;
            this.Version = "8.3";
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private nwindDataSet nwindDataSet1;
        private BindWinControl.nwindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private DevExpress.XtraReports.UI.WinControlContainer winControlContainer1;
        private System.Windows.Forms.Button button1;
    }
}
