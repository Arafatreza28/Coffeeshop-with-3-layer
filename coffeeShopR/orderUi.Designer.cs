﻿namespace coffeeShopR
{
    partial class orderUi
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
            this.showButton = new System.Windows.Forms.Button();
            this.showdataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.totalpriceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.itemnameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.showdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(211, 428);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(88, 23);
            this.showButton.TabIndex = 34;
            this.showButton.Text = "Show All";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // showdataGridView
            // 
            this.showdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdataGridView.Location = new System.Drawing.Point(412, 87);
            this.showdataGridView.Name = "showdataGridView";
            this.showdataGridView.RowTemplate.Height = 24;
            this.showdataGridView.Size = new System.Drawing.Size(489, 431);
            this.showdataGridView.TabIndex = 33;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(110, 495);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(85, 23);
            this.searchButton.TabIndex = 29;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(39, 428);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(85, 23);
            this.updateButton.TabIndex = 30;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(211, 353);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 23);
            this.deleteButton.TabIndex = 31;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(39, 353);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(85, 23);
            this.addButton.TabIndex = 32;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // totalpriceTextBox
            // 
            this.totalpriceTextBox.Location = new System.Drawing.Point(207, 293);
            this.totalpriceTextBox.Name = "totalpriceTextBox";
            this.totalpriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalpriceTextBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Total Price";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(207, 101);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "Order Detail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "ID";
            // 
            // customernameTextBox
            // 
            this.customernameTextBox.Location = new System.Drawing.Point(207, 148);
            this.customernameTextBox.Name = "customernameTextBox";
            this.customernameTextBox.Size = new System.Drawing.Size(100, 22);
            this.customernameTextBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Quantity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(207, 239);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 22);
            this.quantityTextBox.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Item Name";
            // 
            // itemnameTextBox
            // 
            this.itemnameTextBox.Location = new System.Drawing.Point(207, 190);
            this.itemnameTextBox.Name = "itemnameTextBox";
            this.itemnameTextBox.Size = new System.Drawing.Size(100, 22);
            this.itemnameTextBox.TabIndex = 28;
            // 
            // orderUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 564);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.showdataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.totalpriceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemnameTextBox);
            this.Controls.Add(this.customernameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "orderUi";
            this.Text = "orderUi";
            ((System.ComponentModel.ISupportInitialize)(this.showdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.DataGridView showdataGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox totalpriceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox customernameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itemnameTextBox;
    }
}