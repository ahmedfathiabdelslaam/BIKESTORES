namespace bikestore
{
    partial class BIKESTOREFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BIKESTOREFORM));
            this.sales = new System.Windows.Forms.PictureBox();
            this.products = new System.Windows.Forms.PictureBox();
            this.PRODUCTIONS_BUTTON = new System.Windows.Forms.Button();
            this.SALES_BUTTON = new System.Windows.Forms.Button();
            this.MAP_BIKESTORE = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sales
            // 
            this.sales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sales.BackgroundImage")));
            this.sales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sales.Location = new System.Drawing.Point(701, 96);
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(155, 128);
            this.sales.TabIndex = 0;
            this.sales.TabStop = false;
            // 
            // products
            // 
            this.products.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.products.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("products.BackgroundImage")));
            this.products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.products.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.products.Location = new System.Drawing.Point(419, 96);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(155, 128);
            this.products.TabIndex = 1;
            this.products.TabStop = false;
            // 
            // PRODUCTIONS_BUTTON
            // 
            this.PRODUCTIONS_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PRODUCTIONS_BUTTON.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRODUCTIONS_BUTTON.Location = new System.Drawing.Point(419, 230);
            this.PRODUCTIONS_BUTTON.Name = "PRODUCTIONS_BUTTON";
            this.PRODUCTIONS_BUTTON.Size = new System.Drawing.Size(155, 38);
            this.PRODUCTIONS_BUTTON.TabIndex = 4;
            this.PRODUCTIONS_BUTTON.Text = "PRODUCTIONS";
            this.PRODUCTIONS_BUTTON.UseVisualStyleBackColor = false;
            this.PRODUCTIONS_BUTTON.Click += new System.EventHandler(this.PRODUCTIONS_BUTTON_Click);
            // 
            // SALES_BUTTON
            // 
            this.SALES_BUTTON.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SALES_BUTTON.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SALES_BUTTON.Location = new System.Drawing.Point(701, 230);
            this.SALES_BUTTON.Name = "SALES_BUTTON";
            this.SALES_BUTTON.Size = new System.Drawing.Size(155, 38);
            this.SALES_BUTTON.TabIndex = 5;
            this.SALES_BUTTON.Text = "SALES";
            this.SALES_BUTTON.UseVisualStyleBackColor = false;
            this.SALES_BUTTON.Click += new System.EventHandler(this.SALES_BUTTON_Click);
            // 
            // MAP_BIKESTORE
            // 
            this.MAP_BIKESTORE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MAP_BIKESTORE.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAP_BIKESTORE.Location = new System.Drawing.Point(115, 230);
            this.MAP_BIKESTORE.Name = "MAP_BIKESTORE";
            this.MAP_BIKESTORE.Size = new System.Drawing.Size(155, 38);
            this.MAP_BIKESTORE.TabIndex = 6;
            this.MAP_BIKESTORE.Text = "MAP";
            this.MAP_BIKESTORE.UseVisualStyleBackColor = false;
            this.MAP_BIKESTORE.Click += new System.EventHandler(this.MAP_BIKESTORE_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(115, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 128);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // BIKESTOREFORM
            // 
            this.AccessibleName = "BIKESTOREFORM";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 473);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MAP_BIKESTORE);
            this.Controls.Add(this.SALES_BUTTON);
            this.Controls.Add(this.PRODUCTIONS_BUTTON);
            this.Controls.Add(this.products);
            this.Controls.Add(this.sales);
            this.Name = "BIKESTOREFORM";
            this.Text = "BIKESTORE";
            ((System.ComponentModel.ISupportInitialize)(this.sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sales;
        private System.Windows.Forms.PictureBox products;
        private System.Windows.Forms.Button PRODUCTIONS_BUTTON;
        private System.Windows.Forms.Button SALES_BUTTON;
        private System.Windows.Forms.Button MAP_BIKESTORE;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

