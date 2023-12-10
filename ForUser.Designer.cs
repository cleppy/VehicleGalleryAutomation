namespace finalotomasyon
{
    partial class ForUser
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
            this.tabControlUser = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_User = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_bring = new System.Windows.Forms.Button();
            this.txt_SCarID = new System.Windows.Forms.TextBox();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.lbl_km = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlUser.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlUser
            // 
            this.tabControlUser.Controls.Add(this.tabPage1);
            this.tabControlUser.Controls.Add(this.tabPage2);
            this.tabControlUser.Location = new System.Drawing.Point(12, 12);
            this.tabControlUser.Name = "tabControlUser";
            this.tabControlUser.SelectedIndex = 0;
            this.tabControlUser.Size = new System.Drawing.Size(1710, 837);
            this.tabControlUser.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_User);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1702, 811);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Car Showdown";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_User
            // 
            this.dgv_User.AllowUserToAddRows = false;
            this.dgv_User.AllowUserToDeleteRows = false;
            this.dgv_User.AllowUserToResizeColumns = false;
            this.dgv_User.AllowUserToResizeRows = false;
            this.dgv_User.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_User.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_User.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_User.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgv_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_User.Location = new System.Drawing.Point(6, 6);
            this.dgv_User.Name = "dgv_User";
            this.dgv_User.ReadOnly = true;
            this.dgv_User.RowHeadersVisible = false;
            this.dgv_User.RowHeadersWidth = 192;
            this.dgv_User.Size = new System.Drawing.Size(1690, 799);
            this.dgv_User.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_price);
            this.tabPage2.Controls.Add(this.lbl_year);
            this.tabPage2.Controls.Add(this.lbl_km);
            this.tabPage2.Controls.Add(this.lbl_color);
            this.tabPage2.Controls.Add(this.lbl_Category);
            this.tabPage2.Controls.Add(this.lbl_model);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.lbl_brand);
            this.tabPage2.Controls.Add(this.txt_SCarID);
            this.tabPage2.Controls.Add(this.btn_bring);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1702, 811);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Selection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_bring
            // 
            this.btn_bring.Location = new System.Drawing.Point(280, 54);
            this.btn_bring.Name = "btn_bring";
            this.btn_bring.Size = new System.Drawing.Size(124, 51);
            this.btn_bring.TabIndex = 6;
            this.btn_bring.Text = "Bring Car Data";
            this.btn_bring.UseVisualStyleBackColor = true;
            this.btn_bring.Click += new System.EventHandler(this.btn_bring_Click);
            // 
            // txt_SCarID
            // 
            this.txt_SCarID.Location = new System.Drawing.Point(85, 70);
            this.txt_SCarID.Name = "txt_SCarID";
            this.txt_SCarID.Size = new System.Drawing.Size(137, 20);
            this.txt_SCarID.TabIndex = 7;
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Location = new System.Drawing.Point(82, 243);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(0, 13);
            this.lbl_brand.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(230, 296);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 145);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Location = new System.Drawing.Point(82, 281);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(0, 13);
            this.lbl_model.TabIndex = 10;
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Location = new System.Drawing.Point(82, 320);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(0, 13);
            this.lbl_Category.TabIndex = 11;
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(82, 361);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(0, 13);
            this.lbl_color.TabIndex = 12;
            // 
            // lbl_km
            // 
            this.lbl_km.AutoSize = true;
            this.lbl_km.Location = new System.Drawing.Point(82, 400);
            this.lbl_km.Name = "lbl_km";
            this.lbl_km.Size = new System.Drawing.Size(0, 13);
            this.lbl_km.TabIndex = 13;
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(82, 442);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(0, 13);
            this.lbl_year.TabIndex = 14;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(82, 484);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(0, 13);
            this.lbl_price.TabIndex = 15;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(finalotomasyon.Car);
            // 
            // ForUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1734, 861);
            this.Controls.Add(this.tabControlUser);
            this.Name = "ForUser";
            this.Text = "ForUser";
            this.tabControlUser.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlUser;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_User;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_bring;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.TextBox txt_SCarID;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Label lbl_km;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_model;
    }
}