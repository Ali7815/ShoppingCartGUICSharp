
namespace PDShoppingCart
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblShirtTotal = new System.Windows.Forms.Label();
            this.lblShirtPrice = new System.Windows.Forms.Label();
            this.txtShirtQunatity = new System.Windows.Forms.TextBox();
            this.lblShirt = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblShoesTotal = new System.Windows.Forms.Label();
            this.lblShoesPrice = new System.Windows.Forms.Label();
            this.txtShoesQuantity = new System.Windows.Forms.TextBox();
            this.lblShoes = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblPantsTotal = new System.Windows.Forms.Label();
            this.lblPantsPrice = new System.Windows.Forms.Label();
            this.txtPantsQuantity = new System.Windows.Forms.TextBox();
            this.lblPants = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemoveShirtQuantity = new System.Windows.Forms.Button();
            this.btnRemoveShoesQuantity = new System.Windows.Forms.Button();
            this.btnRemovePantsQuantity = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Modern No. 20", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(124, 23);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(274, 44);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Shopping Cart";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.lblHeader);
            this.groupBox1.Location = new System.Drawing.Point(239, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBox1.Size = new System.Drawing.Size(516, 91);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(22, 23);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(104, 25);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(243, 24);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(84, 25);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(457, 22);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 25);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            this.lblPrice.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(686, 22);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 25);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.lblPrice);
            this.groupBox2.Controls.Add(this.lblQuantity);
            this.groupBox2.Controls.Add(this.lblDescription);
            this.groupBox2.Location = new System.Drawing.Point(77, 167);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBox2.Size = new System.Drawing.Size(825, 62);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.btnRemoveShirtQuantity);
            this.groupBox3.Controls.Add(this.lblShirtTotal);
            this.groupBox3.Controls.Add(this.lblShirtPrice);
            this.groupBox3.Controls.Add(this.txtShirtQunatity);
            this.groupBox3.Controls.Add(this.lblShirt);
            this.groupBox3.Location = new System.Drawing.Point(76, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(825, 75);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // lblShirtTotal
            // 
            this.lblShirtTotal.AutoSize = true;
            this.lblShirtTotal.Location = new System.Drawing.Point(693, 28);
            this.lblShirtTotal.Name = "lblShirtTotal";
            this.lblShirtTotal.Size = new System.Drawing.Size(0, 20);
            this.lblShirtTotal.TabIndex = 4;
            // 
            // lblShirtPrice
            // 
            this.lblShirtPrice.AutoSize = true;
            this.lblShirtPrice.Location = new System.Drawing.Point(460, 28);
            this.lblShirtPrice.Name = "lblShirtPrice";
            this.lblShirtPrice.Size = new System.Drawing.Size(45, 20);
            this.lblShirtPrice.TabIndex = 3;
            this.lblShirtPrice.Text = "300";
            // 
            // txtShirtQunatity
            // 
            this.txtShirtQunatity.Location = new System.Drawing.Point(244, 23);
            this.txtShirtQunatity.Name = "txtShirtQunatity";
            this.txtShirtQunatity.Size = new System.Drawing.Size(83, 27);
            this.txtShirtQunatity.TabIndex = 2;
            this.txtShirtQunatity.TextChanged += new System.EventHandler(this.lblShirtQunatity_TextChanged);
            // 
            // lblShirt
            // 
            this.lblShirt.AutoSize = true;
            this.lblShirt.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShirt.Location = new System.Drawing.Point(23, 23);
            this.lblShirt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblShirt.Name = "lblShirt";
            this.lblShirt.Size = new System.Drawing.Size(55, 25);
            this.lblShirt.TabIndex = 1;
            this.lblShirt.Text = "Shirt";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.btnRemoveShoesQuantity);
            this.groupBox4.Controls.Add(this.lblShoesTotal);
            this.groupBox4.Controls.Add(this.lblShoesPrice);
            this.groupBox4.Controls.Add(this.txtShoesQuantity);
            this.groupBox4.Controls.Add(this.lblShoes);
            this.groupBox4.Location = new System.Drawing.Point(76, 300);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(825, 75);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // lblShoesTotal
            // 
            this.lblShoesTotal.AutoSize = true;
            this.lblShoesTotal.Location = new System.Drawing.Point(693, 28);
            this.lblShoesTotal.Name = "lblShoesTotal";
            this.lblShoesTotal.Size = new System.Drawing.Size(0, 20);
            this.lblShoesTotal.TabIndex = 4;
            // 
            // lblShoesPrice
            // 
            this.lblShoesPrice.AutoSize = true;
            this.lblShoesPrice.Location = new System.Drawing.Point(460, 28);
            this.lblShoesPrice.Name = "lblShoesPrice";
            this.lblShoesPrice.Size = new System.Drawing.Size(45, 20);
            this.lblShoesPrice.TabIndex = 3;
            this.lblShoesPrice.Text = "200";
            // 
            // txtShoesQuantity
            // 
            this.txtShoesQuantity.Location = new System.Drawing.Point(244, 23);
            this.txtShoesQuantity.Name = "txtShoesQuantity";
            this.txtShoesQuantity.Size = new System.Drawing.Size(83, 27);
            this.txtShoesQuantity.TabIndex = 2;
            // 
            // lblShoes
            // 
            this.lblShoes.AutoSize = true;
            this.lblShoes.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoes.Location = new System.Drawing.Point(23, 23);
            this.lblShoes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblShoes.Name = "lblShoes";
            this.lblShoes.Size = new System.Drawing.Size(61, 25);
            this.lblShoes.TabIndex = 1;
            this.lblShoes.Text = "Shoes";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Controls.Add(this.lblPantsTotal);
            this.groupBox5.Controls.Add(this.lblPantsPrice);
            this.groupBox5.Controls.Add(this.txtPantsQuantity);
            this.groupBox5.Controls.Add(this.lblPants);
            this.groupBox5.Location = new System.Drawing.Point(76, 366);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(825, 75);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // lblPantsTotal
            // 
            this.lblPantsTotal.AutoSize = true;
            this.lblPantsTotal.Location = new System.Drawing.Point(693, 28);
            this.lblPantsTotal.Name = "lblPantsTotal";
            this.lblPantsTotal.Size = new System.Drawing.Size(0, 20);
            this.lblPantsTotal.TabIndex = 4;
            // 
            // lblPantsPrice
            // 
            this.lblPantsPrice.AutoSize = true;
            this.lblPantsPrice.Location = new System.Drawing.Point(460, 28);
            this.lblPantsPrice.Name = "lblPantsPrice";
            this.lblPantsPrice.Size = new System.Drawing.Size(45, 20);
            this.lblPantsPrice.TabIndex = 3;
            this.lblPantsPrice.Text = "100";
            // 
            // txtPantsQuantity
            // 
            this.txtPantsQuantity.Location = new System.Drawing.Point(244, 23);
            this.txtPantsQuantity.Name = "txtPantsQuantity";
            this.txtPantsQuantity.Size = new System.Drawing.Size(83, 27);
            this.txtPantsQuantity.TabIndex = 2;
            this.txtPantsQuantity.TextChanged += new System.EventHandler(this.txtPantsQuantity_TextChanged);
            // 
            // lblPants
            // 
            this.lblPants.AutoSize = true;
            this.lblPants.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPants.Location = new System.Drawing.Point(23, 23);
            this.lblPants.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPants.Name = "lblPants";
            this.lblPants.Size = new System.Drawing.Size(55, 25);
            this.lblPants.TabIndex = 1;
            this.lblPants.Text = "Pants";
            this.lblPants.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox6.Controls.Add(this.btnClear);
            this.groupBox6.Controls.Add(this.btnUpdate);
            this.groupBox6.Controls.Add(this.lblTotalMoney);
            this.groupBox6.Controls.Add(this.lblTotalPrice);
            this.groupBox6.Location = new System.Drawing.Point(77, 442);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(825, 52);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(18, 15);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 31);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.AutoSize = true;
            this.lblTotalMoney.Location = new System.Drawing.Point(710, 23);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(0, 20);
            this.lblTotalMoney.TabIndex = 1;
            this.lblTotalMoney.Click += new System.EventHandler(this.lblTotalMoney_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(601, 23);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(103, 20);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "Total :";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(174, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 31);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear\r\n";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemoveShirtQuantity
            // 
            this.btnRemoveShirtQuantity.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveShirtQuantity.Location = new System.Drawing.Point(333, 39);
            this.btnRemoveShirtQuantity.Name = "btnRemoveShirtQuantity";
            this.btnRemoveShirtQuantity.Size = new System.Drawing.Size(76, 27);
            this.btnRemoveShirtQuantity.TabIndex = 5;
            this.btnRemoveShirtQuantity.Text = "Remove";
            this.btnRemoveShirtQuantity.UseVisualStyleBackColor = true;
            this.btnRemoveShirtQuantity.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoveShoesQuantity
            // 
            this.btnRemoveShoesQuantity.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveShoesQuantity.Location = new System.Drawing.Point(333, 33);
            this.btnRemoveShoesQuantity.Name = "btnRemoveShoesQuantity";
            this.btnRemoveShoesQuantity.Size = new System.Drawing.Size(76, 27);
            this.btnRemoveShoesQuantity.TabIndex = 6;
            this.btnRemoveShoesQuantity.Text = "Remove";
            this.btnRemoveShoesQuantity.UseVisualStyleBackColor = true;
            this.btnRemoveShoesQuantity.Click += new System.EventHandler(this.btnRemoveShoesQuantity_Click);
            // 
            // btnRemovePantsQuantity
            // 
            this.btnRemovePantsQuantity.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePantsQuantity.Location = new System.Drawing.Point(409, 419);
            this.btnRemovePantsQuantity.Name = "btnRemovePantsQuantity";
            this.btnRemovePantsQuantity.Size = new System.Drawing.Size(76, 22);
            this.btnRemovePantsQuantity.TabIndex = 7;
            this.btnRemovePantsQuantity.Text = "Remove";
            this.btnRemovePantsQuantity.UseVisualStyleBackColor = true;
            this.btnRemovePantsQuantity.Click += new System.EventHandler(this.btnRemovePantsQuantity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 563);
            this.Controls.Add(this.btnRemovePantsQuantity);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Engravers MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblShirtPrice;
        private System.Windows.Forms.TextBox txtShirtQunatity;
        private System.Windows.Forms.Label lblShirt;
        private System.Windows.Forms.Label lblShirtTotal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblShoesTotal;
        private System.Windows.Forms.Label lblShoesPrice;
        private System.Windows.Forms.TextBox txtShoesQuantity;
        private System.Windows.Forms.Label lblShoes;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblPantsTotal;
        private System.Windows.Forms.Label lblPantsPrice;
        private System.Windows.Forms.TextBox txtPantsQuantity;
        private System.Windows.Forms.Label lblPants;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemoveShirtQuantity;
        private System.Windows.Forms.Button btnRemoveShoesQuantity;
        private System.Windows.Forms.Button btnRemovePantsQuantity;
    }
}

