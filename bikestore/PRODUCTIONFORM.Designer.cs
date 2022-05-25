namespace bikestore
{
    partial class PRODUCTIONSFORM
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
            this.BRANDSBUTTON = new System.Windows.Forms.Button();
            this.STOCKSBUTTON = new System.Windows.Forms.Button();
            this.CATEGORIESBUTTON = new System.Windows.Forms.Button();
            this.PRODUCTSBUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BRANDSBUTTON
            // 
            this.BRANDSBUTTON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BRANDSBUTTON.Font = new System.Drawing.Font("TechnicLite", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.BRANDSBUTTON.Location = new System.Drawing.Point(50, 78);
            this.BRANDSBUTTON.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.BRANDSBUTTON.Name = "BRANDSBUTTON";
            this.BRANDSBUTTON.Size = new System.Drawing.Size(123, 34);
            this.BRANDSBUTTON.TabIndex = 0;
            this.BRANDSBUTTON.Text = "Brands";
            this.BRANDSBUTTON.UseVisualStyleBackColor = true;
            this.BRANDSBUTTON.Click += new System.EventHandler(this.BRANDSBUTTON_Click);
            // 
            // STOCKSBUTTON
            // 
            this.STOCKSBUTTON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.STOCKSBUTTON.Font = new System.Drawing.Font("TechnicLite", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.STOCKSBUTTON.Location = new System.Drawing.Point(205, 137);
            this.STOCKSBUTTON.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.STOCKSBUTTON.Name = "STOCKSBUTTON";
            this.STOCKSBUTTON.Size = new System.Drawing.Size(123, 34);
            this.STOCKSBUTTON.TabIndex = 1;
            this.STOCKSBUTTON.Text = "STOCKS";
            this.STOCKSBUTTON.UseVisualStyleBackColor = true;
            this.STOCKSBUTTON.Click += new System.EventHandler(this.STOCKSBUTTON_Click);
            // 
            // CATEGORIESBUTTON
            // 
            this.CATEGORIESBUTTON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CATEGORIESBUTTON.Font = new System.Drawing.Font("TechnicLite", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CATEGORIESBUTTON.Location = new System.Drawing.Point(205, 78);
            this.CATEGORIESBUTTON.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.CATEGORIESBUTTON.Name = "CATEGORIESBUTTON";
            this.CATEGORIESBUTTON.Size = new System.Drawing.Size(123, 34);
            this.CATEGORIESBUTTON.TabIndex = 2;
            this.CATEGORIESBUTTON.Text = "categories";
            this.CATEGORIESBUTTON.UseVisualStyleBackColor = true;
            this.CATEGORIESBUTTON.Click += new System.EventHandler(this.CATEGORIESBUTTON_Click);
            // 
            // PRODUCTSBUTTON
            // 
            this.PRODUCTSBUTTON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PRODUCTSBUTTON.Font = new System.Drawing.Font("TechnicLite", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.PRODUCTSBUTTON.Location = new System.Drawing.Point(50, 137);
            this.PRODUCTSBUTTON.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.PRODUCTSBUTTON.Name = "PRODUCTSBUTTON";
            this.PRODUCTSBUTTON.Size = new System.Drawing.Size(123, 34);
            this.PRODUCTSBUTTON.TabIndex = 3;
            this.PRODUCTSBUTTON.Text = "PRODUCTS";
            this.PRODUCTSBUTTON.UseVisualStyleBackColor = true;
            this.PRODUCTSBUTTON.Click += new System.EventHandler(this.PRODUCTSBUTTON_Click);
            // 
            // PRODUCTIONSFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(373, 249);
            this.Controls.Add(this.PRODUCTSBUTTON);
            this.Controls.Add(this.CATEGORIESBUTTON);
            this.Controls.Add(this.STOCKSBUTTON);
            this.Controls.Add(this.BRANDSBUTTON);
            this.Name = "PRODUCTIONSFORM";
            this.Opacity = 0.95D;
            this.Text = "PRODUCTIONS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BRANDSBUTTON;
        private System.Windows.Forms.Button STOCKSBUTTON;
        private System.Windows.Forms.Button CATEGORIESBUTTON;
        private System.Windows.Forms.Button PRODUCTSBUTTON;
    }
}