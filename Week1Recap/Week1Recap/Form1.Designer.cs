namespace Week1Recap
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
            this.picItem = new System.Windows.Forms.PictureBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.cboQty = new System.Windows.Forms.ComboBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.SuspendLayout();
            // 
            // picItem
            // 
            this.picItem.Location = new System.Drawing.Point(211, 31);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(88, 84);
            this.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem.TabIndex = 0;
            this.picItem.TabStop = false;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(29, 45);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(106, 21);
            this.cboCategory.TabIndex = 1;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(27, 100);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(107, 56);
            this.lstItems.TabIndex = 2;
            this.lstItems.Click += new System.EventHandler(this.lstItems_Click);
            // 
            // cboQty
            // 
            this.cboQty.FormattingEnabled = true;
            this.cboQty.Location = new System.Drawing.Point(194, 144);
            this.cboQty.Name = "cboQty";
            this.cboQty.Size = new System.Drawing.Size(56, 21);
            this.cboQty.TabIndex = 3;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(194, 227);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(104, 33);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(267, 144);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 21);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 289);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.cboQty);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.picItem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picItem;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.ComboBox cboQty;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnAdd;
    }
}

