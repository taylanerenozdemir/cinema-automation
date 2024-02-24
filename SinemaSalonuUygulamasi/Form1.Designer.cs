namespace SinemaSalonuUygulamasi
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_kalanKoltukSayisi = new DevExpress.XtraEditors.CalcEdit();
            this.txt_satilanKoltukSayisi = new DevExpress.XtraEditors.CalcEdit();
            this.txt_koltukSayisi = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_rezerveEdilen = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_temizle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sat = new DevExpress.XtraEditors.SimpleButton();
            this.listBoxRezervasyon = new DevExpress.XtraEditors.ListBoxControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kalanKoltukSayisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_satilanKoltukSayisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_koltukSayisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxRezervasyon)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(845, 664);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.txt_kalanKoltukSayisi);
            this.groupControl1.Controls.Add(this.txt_satilanKoltukSayisi);
            this.groupControl1.Controls.Add(this.txt_koltukSayisi);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txt_rezerveEdilen);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btn_temizle);
            this.groupControl1.Controls.Add(this.btn_sat);
            this.groupControl1.Controls.Add(this.listBoxRezervasyon);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(845, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(336, 664);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Rezerve Koltuklar";
            // 
            // txt_kalanKoltukSayisi
            // 
            this.txt_kalanKoltukSayisi.Location = new System.Drawing.Point(118, 596);
            this.txt_kalanKoltukSayisi.Name = "txt_kalanKoltukSayisi";
            this.txt_kalanKoltukSayisi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_kalanKoltukSayisi.Size = new System.Drawing.Size(100, 20);
            this.txt_kalanKoltukSayisi.TabIndex = 4;
            // 
            // txt_satilanKoltukSayisi
            // 
            this.txt_satilanKoltukSayisi.Location = new System.Drawing.Point(118, 567);
            this.txt_satilanKoltukSayisi.Name = "txt_satilanKoltukSayisi";
            this.txt_satilanKoltukSayisi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_satilanKoltukSayisi.Size = new System.Drawing.Size(100, 20);
            this.txt_satilanKoltukSayisi.TabIndex = 4;
            // 
            // txt_koltukSayisi
            // 
            this.txt_koltukSayisi.Location = new System.Drawing.Point(118, 536);
            this.txt_koltukSayisi.Name = "txt_koltukSayisi";
            this.txt_koltukSayisi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_koltukSayisi.Size = new System.Drawing.Size(100, 20);
            this.txt_koltukSayisi.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 601);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(92, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Kalan Koltuk Sayısı:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 570);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(98, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Satılan Koltuk Sayısı:";
            // 
            // txt_rezerveEdilen
            // 
            this.txt_rezerveEdilen.Location = new System.Drawing.Point(31, 539);
            this.txt_rezerveEdilen.Name = "txt_rezerveEdilen";
            this.txt_rezerveEdilen.Size = new System.Drawing.Size(75, 13);
            this.txt_rezerveEdilen.TabIndex = 3;
            this.txt_rezerveEdilen.Text = "Rezerve Edilen:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 560);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 13);
            this.labelControl1.TabIndex = 2;
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(167, 216);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(164, 90);
            this.btn_temizle.TabIndex = 1;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_sat
            // 
            this.btn_sat.Location = new System.Drawing.Point(5, 216);
            this.btn_sat.Name = "btn_sat";
            this.btn_sat.Size = new System.Drawing.Size(164, 90);
            this.btn_sat.TabIndex = 1;
            this.btn_sat.Text = "Sat";
            this.btn_sat.Click += new System.EventHandler(this.btn_sat_Click);
            // 
            // listBoxRezervasyon
            // 
            this.listBoxRezervasyon.Location = new System.Drawing.Point(0, 22);
            this.listBoxRezervasyon.Name = "listBoxRezervasyon";
            this.listBoxRezervasyon.Size = new System.Drawing.Size(336, 188);
            this.listBoxRezervasyon.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(85, 305);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(164, 90);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Satılanları İptal Et";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 664);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kalanKoltukSayisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_satilanKoltukSayisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_koltukSayisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxRezervasyon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxRezervasyon;
        private DevExpress.XtraEditors.SimpleButton btn_temizle;
        private DevExpress.XtraEditors.SimpleButton btn_sat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl txt_rezerveEdilen;
        private DevExpress.XtraEditors.CalcEdit txt_kalanKoltukSayisi;
        private DevExpress.XtraEditors.CalcEdit txt_satilanKoltukSayisi;
        private DevExpress.XtraEditors.CalcEdit txt_koltukSayisi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}

