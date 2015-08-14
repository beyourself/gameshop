namespace Server
{
    partial class GameShop
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
            this.GameShopListBox = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.GoldPrice_textbox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.GPPrice_textbox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.Quantity_textbox = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Catagory_combo = new System.Windows.Forms.ComboBox();
            this.Page1Priority_checkbox = new System.Windows.Forms.CheckBox();
            this.Class_combo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalQuantity_textbox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DealofDay_checkbox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameShopListBox
            // 
            this.GameShopListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GameShopListBox.FormattingEnabled = true;
            this.GameShopListBox.Location = new System.Drawing.Point(12, 25);
            this.GameShopListBox.Name = "GameShopListBox";
            this.GameShopListBox.Size = new System.Drawing.Size(156, 433);
            this.GameShopListBox.TabIndex = 11;
            this.GameShopListBox.SelectedIndexChanged += new System.EventHandler(this.GameShopListBox_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 90;
            this.label14.Text = "GOLD PRICE:";
            // 
            // GoldPrice_textbox
            // 
            this.GoldPrice_textbox.Location = new System.Drawing.Point(86, 23);
            this.GoldPrice_textbox.MaxLength = 3;
            this.GoldPrice_textbox.Name = "GoldPrice_textbox";
            this.GoldPrice_textbox.Size = new System.Drawing.Size(173, 20);
            this.GoldPrice_textbox.TabIndex = 86;
            this.GoldPrice_textbox.TextChanged += new System.EventHandler(this.GoldPrice_textbox_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 13);
            this.label21.TabIndex = 91;
            this.label21.Text = "GP PRICE:";
            // 
            // GPPrice_textbox
            // 
            this.GPPrice_textbox.Location = new System.Drawing.Point(86, 50);
            this.GPPrice_textbox.MaxLength = 3;
            this.GPPrice_textbox.Name = "GPPrice_textbox";
            this.GPPrice_textbox.Size = new System.Drawing.Size(173, 20);
            this.GPPrice_textbox.TabIndex = 87;
            this.GPPrice_textbox.TextChanged += new System.EventHandler(this.GPPrice_textbox_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(15, 82);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 13);
            this.label25.TabIndex = 92;
            this.label25.Text = "QUANTITY:";
            // 
            // Quantity_textbox
            // 
            this.Quantity_textbox.Location = new System.Drawing.Point(87, 79);
            this.Quantity_textbox.MaxLength = 3;
            this.Quantity_textbox.Name = "Quantity_textbox";
            this.Quantity_textbox.Size = new System.Drawing.Size(52, 20);
            this.Quantity_textbox.TabIndex = 88;
            this.Quantity_textbox.TextChanged += new System.EventHandler(this.Quantity_textbox_TextChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 25);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(74, 13);
            this.label29.TabIndex = 93;
            this.label29.Text = "Class Section;";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.GoldPrice_textbox);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.GPPrice_textbox);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.Quantity_textbox);
            this.groupBox1.Location = new System.Drawing.Point(174, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 115);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Details";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.Catagory_combo);
            this.groupBox2.Controls.Add(this.Page1Priority_checkbox);
            this.groupBox2.Controls.Add(this.Class_combo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TotalQuantity_textbox);
            this.groupBox2.Location = new System.Drawing.Point(174, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 153);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GameShop Item Settings";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Catagory_combo
            // 
            this.Catagory_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Catagory_combo.FormattingEnabled = true;
            this.Catagory_combo.Items.AddRange(new object[] {
            "Experience",
            "Cosmetic",
            "Items",
            "Consumables"});
            this.Catagory_combo.Location = new System.Drawing.Point(9, 87);
            this.Catagory_combo.Name = "Catagory_combo";
            this.Catagory_combo.Size = new System.Drawing.Size(92, 21);
            this.Catagory_combo.TabIndex = 107;
            this.Catagory_combo.SelectedIndexChanged += new System.EventHandler(this.Catagory_combo_SelectedIndexChanged);
            // 
            // Page1Priority_checkbox
            // 
            this.Page1Priority_checkbox.AutoSize = true;
            this.Page1Priority_checkbox.Location = new System.Drawing.Point(154, 41);
            this.Page1Priority_checkbox.Name = "Page1Priority_checkbox";
            this.Page1Priority_checkbox.Size = new System.Drawing.Size(94, 17);
            this.Page1Priority_checkbox.TabIndex = 106;
            this.Page1Priority_checkbox.Text = "Page 1 Priority";
            this.Page1Priority_checkbox.UseVisualStyleBackColor = true;
            this.Page1Priority_checkbox.CheckedChanged += new System.EventHandler(this.Page1Priority_checkbox_CheckedChanged);
            // 
            // Class_combo
            // 
            this.Class_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Class_combo.FormattingEnabled = true;
            this.Class_combo.Items.AddRange(new object[] {
            "Taoist",
            "Warrior",
            "Wizard",
            "Archer",
            "Assassin",
            "ALL"});
            this.Class_combo.Location = new System.Drawing.Point(9, 41);
            this.Class_combo.Name = "Class_combo";
            this.Class_combo.Size = new System.Drawing.Size(92, 21);
            this.Class_combo.TabIndex = 105;
            this.Class_combo.SelectedIndexChanged += new System.EventHandler(this.Class_combo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 106;
            this.label4.Text = "Catagory;";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "TOTAL QUANTITY:";
            // 
            // TotalQuantity_textbox
            // 
            this.TotalQuantity_textbox.Location = new System.Drawing.Point(115, 118);
            this.TotalQuantity_textbox.MaxLength = 3;
            this.TotalQuantity_textbox.Name = "TotalQuantity_textbox";
            this.TotalQuantity_textbox.Size = new System.Drawing.Size(74, 20);
            this.TotalQuantity_textbox.TabIndex = 88;
            this.TotalQuantity_textbox.TextChanged += new System.EventHandler(this.TotalQuantity_textbox_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.DealofDay_checkbox);
            this.groupBox3.Location = new System.Drawing.Point(174, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 153);
            this.groupBox3.TabIndex = 105;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other";
            // 
            // DealofDay_checkbox
            // 
            this.DealofDay_checkbox.AutoSize = true;
            this.DealofDay_checkbox.Location = new System.Drawing.Point(18, 35);
            this.DealofDay_checkbox.Name = "DealofDay_checkbox";
            this.DealofDay_checkbox.Size = new System.Drawing.Size(100, 17);
            this.DealofDay_checkbox.TabIndex = 105;
            this.DealofDay_checkbox.Text = "Deal of the Day";
            this.DealofDay_checkbox.UseVisualStyleBackColor = true;
            // 
            // GameShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 472);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GameShopListBox);
            this.Name = "GameShop";
            this.Text = "GameShop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameShop_FormClosed);
            this.Load += new System.EventHandler(this.GameShop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox GameShopListBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox GoldPrice_textbox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox GPPrice_textbox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox Quantity_textbox;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotalQuantity_textbox;
        private System.Windows.Forms.ComboBox Catagory_combo;
        private System.Windows.Forms.ComboBox Class_combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox DealofDay_checkbox;
        private System.Windows.Forms.CheckBox Page1Priority_checkbox;
    }
}