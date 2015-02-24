namespace WindowsFormsApplication1
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
            this.temizle_buton = new System.Windows.Forms.Button();
            this.programiYukle_button = new System.Windows.Forms.Button();
            this.calistir_buton = new System.Windows.Forms.Button();
            this.ac_label = new System.Windows.Forms.Label();
            this.mar_label = new System.Windows.Forms.Label();
            this.mbr_label = new System.Windows.Forms.Label();
            this.ir_label = new System.Windows.Forms.Label();
            this.pc_label = new System.Windows.Forms.Label();
            this.outReg_label = new System.Windows.Forms.Label();
            this.inRegDeger_textBox = new System.Windows.Forms.TextBox();
            this.inReg_label = new System.Windows.Forms.Label();
            this.acDeger_label = new System.Windows.Forms.Label();
            this.marDeger_label = new System.Windows.Forms.Label();
            this.mbrDeger_label = new System.Windows.Forms.Label();
            this.irDeger_label = new System.Windows.Forms.Label();
            this.pcDeger_label = new System.Windows.Forms.Label();
            this.outRegDeger_label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.bellek_listView = new System.Windows.Forms.ListView();
            this.adres_sutun = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.icerik_sutun = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label15 = new System.Windows.Forms.Label();
            this.etiket_listView = new System.Windows.Forms.ListView();
            this.degisken = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deger = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // temizle_buton
            // 
            this.temizle_buton.Location = new System.Drawing.Point(133, 286);
            this.temizle_buton.Name = "temizle_buton";
            this.temizle_buton.Size = new System.Drawing.Size(75, 36);
            this.temizle_buton.TabIndex = 1;
            this.temizle_buton.Text = "Temizle";
            this.temizle_buton.UseVisualStyleBackColor = true;
            this.temizle_buton.Click += new System.EventHandler(this.button1_Click);
            // 
            // programiYukle_button
            // 
            this.programiYukle_button.Location = new System.Drawing.Point(214, 286);
            this.programiYukle_button.Name = "programiYukle_button";
            this.programiYukle_button.Size = new System.Drawing.Size(75, 36);
            this.programiYukle_button.TabIndex = 2;
            this.programiYukle_button.Text = "Programı Yükle";
            this.programiYukle_button.UseVisualStyleBackColor = true;
            this.programiYukle_button.Click += new System.EventHandler(this.programiYukle_button_Click);
            // 
            // calistir_buton
            // 
            this.calistir_buton.Location = new System.Drawing.Point(295, 286);
            this.calistir_buton.Name = "calistir_buton";
            this.calistir_buton.Size = new System.Drawing.Size(75, 36);
            this.calistir_buton.TabIndex = 3;
            this.calistir_buton.Text = "Çalıştır";
            this.calistir_buton.UseVisualStyleBackColor = true;
            this.calistir_buton.Click += new System.EventHandler(this.calistir_buton_Click);
            // 
            // ac_label
            // 
            this.ac_label.AutoSize = true;
            this.ac_label.Location = new System.Drawing.Point(0, 287);
            this.ac_label.Name = "ac_label";
            this.ac_label.Size = new System.Drawing.Size(27, 13);
            this.ac_label.TabIndex = 4;
            this.ac_label.Text = "AC: ";
            // 
            // mar_label
            // 
            this.mar_label.AutoSize = true;
            this.mar_label.Location = new System.Drawing.Point(0, 309);
            this.mar_label.Name = "mar_label";
            this.mar_label.Size = new System.Drawing.Size(34, 13);
            this.mar_label.TabIndex = 5;
            this.mar_label.Text = "MAR:";
            // 
            // mbr_label
            // 
            this.mbr_label.AutoSize = true;
            this.mbr_label.Location = new System.Drawing.Point(0, 331);
            this.mbr_label.Name = "mbr_label";
            this.mbr_label.Size = new System.Drawing.Size(34, 13);
            this.mbr_label.TabIndex = 6;
            this.mbr_label.Text = "MBR:";
            // 
            // ir_label
            // 
            this.ir_label.AutoSize = true;
            this.ir_label.Location = new System.Drawing.Point(0, 355);
            this.ir_label.Name = "ir_label";
            this.ir_label.Size = new System.Drawing.Size(21, 13);
            this.ir_label.TabIndex = 7;
            this.ir_label.Text = "IR:";
            // 
            // pc_label
            // 
            this.pc_label.AutoSize = true;
            this.pc_label.Location = new System.Drawing.Point(0, 378);
            this.pc_label.Name = "pc_label";
            this.pc_label.Size = new System.Drawing.Size(24, 13);
            this.pc_label.TabIndex = 8;
            this.pc_label.Text = "PC:";
            // 
            // outReg_label
            // 
            this.outReg_label.AutoSize = true;
            this.outReg_label.Location = new System.Drawing.Point(0, 401);
            this.outReg_label.Name = "outReg_label";
            this.outReg_label.Size = new System.Drawing.Size(47, 13);
            this.outReg_label.TabIndex = 9;
            this.outReg_label.Text = "OutReg:";
            // 
            // inRegDeger_textBox
            // 
            this.inRegDeger_textBox.Location = new System.Drawing.Point(247, 445);
            this.inRegDeger_textBox.Name = "inRegDeger_textBox";
            this.inRegDeger_textBox.Size = new System.Drawing.Size(42, 20);
            this.inRegDeger_textBox.TabIndex = 10;
            this.inRegDeger_textBox.Text = "0000";
            // 
            // inReg_label
            // 
            this.inReg_label.AutoSize = true;
            this.inReg_label.Location = new System.Drawing.Point(202, 448);
            this.inReg_label.Name = "inReg_label";
            this.inReg_label.Size = new System.Drawing.Size(39, 13);
            this.inReg_label.TabIndex = 11;
            this.inReg_label.Text = "InReg:";
            // 
            // acDeger_label
            // 
            this.acDeger_label.AutoSize = true;
            this.acDeger_label.Location = new System.Drawing.Point(33, 287);
            this.acDeger_label.Name = "acDeger_label";
            this.acDeger_label.Size = new System.Drawing.Size(31, 13);
            this.acDeger_label.TabIndex = 12;
            this.acDeger_label.Text = "0000";
            // 
            // marDeger_label
            // 
            this.marDeger_label.AutoSize = true;
            this.marDeger_label.Location = new System.Drawing.Point(33, 309);
            this.marDeger_label.Name = "marDeger_label";
            this.marDeger_label.Size = new System.Drawing.Size(25, 13);
            this.marDeger_label.TabIndex = 13;
            this.marDeger_label.Text = "000";
            // 
            // mbrDeger_label
            // 
            this.mbrDeger_label.AutoSize = true;
            this.mbrDeger_label.Location = new System.Drawing.Point(33, 331);
            this.mbrDeger_label.Name = "mbrDeger_label";
            this.mbrDeger_label.Size = new System.Drawing.Size(31, 13);
            this.mbrDeger_label.TabIndex = 14;
            this.mbrDeger_label.Text = "0000";
            // 
            // irDeger_label
            // 
            this.irDeger_label.AutoSize = true;
            this.irDeger_label.Location = new System.Drawing.Point(33, 355);
            this.irDeger_label.Name = "irDeger_label";
            this.irDeger_label.Size = new System.Drawing.Size(31, 13);
            this.irDeger_label.TabIndex = 15;
            this.irDeger_label.Text = "0000";
            // 
            // pcDeger_label
            // 
            this.pcDeger_label.AutoSize = true;
            this.pcDeger_label.Location = new System.Drawing.Point(33, 378);
            this.pcDeger_label.Name = "pcDeger_label";
            this.pcDeger_label.Size = new System.Drawing.Size(25, 13);
            this.pcDeger_label.TabIndex = 16;
            this.pcDeger_label.Text = "000";
            // 
            // outRegDeger_label
            // 
            this.outRegDeger_label.AutoSize = true;
            this.outRegDeger_label.Location = new System.Drawing.Point(33, 401);
            this.outRegDeger_label.Name = "outRegDeger_label";
            this.outRegDeger_label.Size = new System.Drawing.Size(31, 13);
            this.outRegDeger_label.TabIndex = 17;
            this.outRegDeger_label.Text = "0000";
            // 
            // label14
            // 
            this.label14.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(431, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Bellek";
            // 
            // bellek_listView
            // 
            this.bellek_listView.BackColor = System.Drawing.Color.White;
            this.bellek_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.adres_sutun,
            this.icerik_sutun});
            this.bellek_listView.Location = new System.Drawing.Point(382, 18);
            this.bellek_listView.Name = "bellek_listView";
            this.bellek_listView.Size = new System.Drawing.Size(152, 192);
            this.bellek_listView.TabIndex = 22;
            this.bellek_listView.UseCompatibleStateImageBehavior = false;
            this.bellek_listView.View = System.Windows.Forms.View.Details;
            // 
            // adres_sutun
            // 
            this.adres_sutun.Text = "Adres(Hex)";
            this.adres_sutun.Width = 65;
            // 
            // icerik_sutun
            // 
            this.icerik_sutun.Text = "İçerik";
            this.icerik_sutun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.icerik_sutun.Width = 65;
            // 
            // label15
            // 
            this.label15.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(433, 222);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Etiket";
            // 
            // etiket_listView
            // 
            this.etiket_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.degisken,
            this.deger});
            this.etiket_listView.Location = new System.Drawing.Point(382, 238);
            this.etiket_listView.Name = "etiket_listView";
            this.etiket_listView.Size = new System.Drawing.Size(152, 91);
            this.etiket_listView.TabIndex = 24;
            this.etiket_listView.UseCompatibleStateImageBehavior = false;
            this.etiket_listView.View = System.Windows.Forms.View.Details;
            // 
            // degisken
            // 
            this.degisken.Text = "Değişken";
            // 
            // deger
            // 
            this.deger.Text = "Değer";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(373, 278);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.editor_richTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 481);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.etiket_listView);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.bellek_listView);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.outRegDeger_label);
            this.Controls.Add(this.pcDeger_label);
            this.Controls.Add(this.irDeger_label);
            this.Controls.Add(this.mbrDeger_label);
            this.Controls.Add(this.marDeger_label);
            this.Controls.Add(this.acDeger_label);
            this.Controls.Add(this.inReg_label);
            this.Controls.Add(this.inRegDeger_textBox);
            this.Controls.Add(this.outReg_label);
            this.Controls.Add(this.pc_label);
            this.Controls.Add(this.ir_label);
            this.Controls.Add(this.mbr_label);
            this.Controls.Add(this.mar_label);
            this.Controls.Add(this.ac_label);
            this.Controls.Add(this.calistir_buton);
            this.Controls.Add(this.programiYukle_button);
            this.Controls.Add(this.temizle_buton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "MARIE SİMÜLATÖRÜ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button temizle_buton;
        private System.Windows.Forms.Button programiYukle_button;
        private System.Windows.Forms.Button calistir_buton;
        private System.Windows.Forms.Label ac_label;
        private System.Windows.Forms.Label mar_label;
        private System.Windows.Forms.Label mbr_label;
        private System.Windows.Forms.Label ir_label;
        private System.Windows.Forms.Label pc_label;
        private System.Windows.Forms.Label outReg_label;
        private System.Windows.Forms.TextBox inRegDeger_textBox;
        private System.Windows.Forms.Label inReg_label;
        private System.Windows.Forms.Label acDeger_label;
        private System.Windows.Forms.Label marDeger_label;
        private System.Windows.Forms.Label mbrDeger_label;
        private System.Windows.Forms.Label irDeger_label;
        private System.Windows.Forms.Label pcDeger_label;
        private System.Windows.Forms.Label outRegDeger_label;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListView bellek_listView;
        private System.Windows.Forms.ColumnHeader adres_sutun;
        private System.Windows.Forms.ColumnHeader icerik_sutun;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListView etiket_listView;
        private System.Windows.Forms.ColumnHeader degisken;
        private System.Windows.Forms.ColumnHeader deger;
        private System.Windows.Forms.RichTextBox richTextBox1;
       
    }
}

