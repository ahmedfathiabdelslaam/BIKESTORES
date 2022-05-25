namespace bikestore
{
    partial class SALESFORM
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
            this.CUSTOMERS = new System.Windows.Forms.Button();
            this.ORDERITEMSBUTTON = new System.Windows.Forms.Button();
            this.ORDERSBUTTON = new System.Windows.Forms.Button();
            this.STAFFSBUTTON = new System.Windows.Forms.Button();
            this.STORESBUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CUSTOMERS
            // 
            this.CUSTOMERS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CUSTOMERS.Font = new System.Drawing.Font("TechnicLite", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CUSTOMERS.Location = new System.Drawing.Point(40, 68);
            this.CUSTOMERS.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.CUSTOMERS.Name = "CUSTOMERS";
            this.CUSTOMERS.Size = new System.Drawing.Size(314, 34);
            this.CUSTOMERS.TabIndex = 1;
            this.CUSTOMERS.Text = "CUSTOMERS";
            this.CUSTOMERS.UseVisualStyleBackColor = true;
            this.CUSTOMERS.Click += new System.EventHandler(this.CUSTOMERS_Click);
            // 
            // ORDERITEMSBUTTON
            // 
            this.ORDERITEMSBUTTON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ORDERITEMSBUTTON.Font = new System.Drawing.Font("TechnicLite", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ORDERITEMSBUTTON.Location = new System.Drawing.Point(37, 126);
            this.ORDERITEMSBUTTON.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.ORDERITEMSBUTTON.Name = "ORDERITEMSBUTTON";
            this.ORDERITEMSBUTTON.Size = new System.Drawing.Size(148, 34);
            this.ORDERITEMSBUTTON.TabIndex = 2;
            this.ORDERITEMSBUTTON.Text = "ORDER ITEMS";
            this.ORDERITEMSBUTTON.UseVisualStyleBackColor = true;
            this.ORDERITEMSBUTTON.Click += new System.EventHandler(this.ORDERITEMSBUTTON_Click);
            // 
            // ORDERSBUTTON
            // 
            this.ORDERSBUTTON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ORDERSBUTTON.Font = new System.Drawing.Font("TechnicLite", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ORDERSBUTTON.Location = new System.Drawing.Point(212, 126);
            this.ORDERSBUTTON.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.ORDERSBUTTON.Name = "ORDERSBUTTON";
            this.ORDERSBUTTON.Size = new System.Drawing.Size(142, 34);
            this.ORDERSBUTTON.TabIndex = 3;
            this.ORDERSBUTTON.Text = "ORDERS";
            this.ORDERSBUTTON.UseVisualStyleBackColor = true;
            this.ORDERSBUTTON.Click += new System.EventHandler(this.ORDERSBUTTON_Click);
            // 
            // STAFFSBUTTON
            // 
            this.STAFFSBUTTON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.STAFFSBUTTON.Font = new System.Drawing.Font("TechnicLite", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.STAFFSBUTTON.Location = new System.Drawing.Point(40, 180);
            this.STAFFSBUTTON.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.STAFFSBUTTON.Name = "STAFFSBUTTON";
            this.STAFFSBUTTON.Size = new System.Drawing.Size(145, 34);
            this.STAFFSBUTTON.TabIndex = 4;
            this.STAFFSBUTTON.Text = "STAFFS";
            this.STAFFSBUTTON.UseVisualStyleBackColor = true;
            this.STAFFSBUTTON.Click += new System.EventHandler(this.STAFFSBUTTON_Click);
            // 
            // STORESBUTTON
            // 
            this.STORESBUTTON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.STORESBUTTON.Font = new System.Drawing.Font("TechnicLite", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.STORESBUTTON.Location = new System.Drawing.Point(212, 180);
            this.STORESBUTTON.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.STORESBUTTON.Name = "STORESBUTTON";
            this.STORESBUTTON.Size = new System.Drawing.Size(145, 34);
            this.STORESBUTTON.TabIndex = 5;
            this.STORESBUTTON.Text = "STORES";
            this.STORESBUTTON.UseVisualStyleBackColor = true;
            this.STORESBUTTON.Click += new System.EventHandler(this.STORESBUTTON_Click);
            // 
            // SALESFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(389, 286);
            this.Controls.Add(this.STORESBUTTON);
            this.Controls.Add(this.STAFFSBUTTON);
            this.Controls.Add(this.ORDERSBUTTON);
            this.Controls.Add(this.ORDERITEMSBUTTON);
            this.Controls.Add(this.CUSTOMERS);
            this.Name = "SALESFORM";
            this.Text = "SALESFORM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CUSTOMERS;
        private System.Windows.Forms.Button ORDERITEMSBUTTON;
        private System.Windows.Forms.Button ORDERSBUTTON;
        private System.Windows.Forms.Button STAFFSBUTTON;
        private System.Windows.Forms.Button STORESBUTTON;
    }
}