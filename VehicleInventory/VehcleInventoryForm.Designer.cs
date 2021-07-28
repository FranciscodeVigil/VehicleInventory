
namespace VehicleInventory
{
    partial class VehcleInventoryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNewVehicle = new System.Windows.Forms.TabPage();
            this.txbResults = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbVIN = new System.Windows.Forms.TextBox();
            this.txbLicense = new System.Windows.Forms.TextBox();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.TbxSummary = new System.Windows.Forms.TextBox();
            this.LbInventory = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabNewVehicle.SuspendLayout();
            this.tabInventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Controls.Add(this.tabNewVehicle);
            this.tabControl1.Controls.Add(this.tabInventory);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 413);
            this.tabControl1.TabIndex = 0;
            // 
            // tabNewVehicle
            // 
            this.tabNewVehicle.Controls.Add(this.txbResults);
            this.tabNewVehicle.Controls.Add(this.btnAdd);
            this.tabNewVehicle.Controls.Add(this.cbType);
            this.tabNewVehicle.Controls.Add(this.label5);
            this.tabNewVehicle.Controls.Add(this.label4);
            this.tabNewVehicle.Controls.Add(this.label3);
            this.tabNewVehicle.Controls.Add(this.label2);
            this.tabNewVehicle.Controls.Add(this.label1);
            this.tabNewVehicle.Controls.Add(this.txbVIN);
            this.tabNewVehicle.Controls.Add(this.txbLicense);
            this.tabNewVehicle.Location = new System.Drawing.Point(4, 4);
            this.tabNewVehicle.Name = "tabNewVehicle";
            this.tabNewVehicle.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewVehicle.Size = new System.Drawing.Size(755, 405);
            this.tabNewVehicle.TabIndex = 0;
            this.tabNewVehicle.Text = "New Vehicle Form";
            this.tabNewVehicle.UseVisualStyleBackColor = true;
            // 
            // txbResults
            // 
            this.txbResults.Location = new System.Drawing.Point(233, 267);
            this.txbResults.Multiline = true;
            this.txbResults.Name = "txbResults";
            this.txbResults.ReadOnly = true;
            this.txbResults.Size = new System.Drawing.Size(312, 75);
            this.txbResults.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(353, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Sedan",
            "Truck"});
            this.cbType.Location = new System.Drawing.Point(322, 146);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(151, 28);
            this.cbType.TabIndex = 7;
            this.cbType.Text = "Sedan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "License";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "VIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Vehicle Form";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, -114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ehicle Forms";
            // 
            // txbVIN
            // 
            this.txbVIN.Location = new System.Drawing.Point(322, 111);
            this.txbVIN.Name = "txbVIN";
            this.txbVIN.Size = new System.Drawing.Size(125, 27);
            this.txbVIN.TabIndex = 1;
            // 
            // txbLicense
            // 
            this.txbLicense.Location = new System.Drawing.Point(322, 78);
            this.txbLicense.Name = "txbLicense";
            this.txbLicense.Size = new System.Drawing.Size(125, 27);
            this.txbLicense.TabIndex = 0;
            this.txbLicense.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.TbxSummary);
            this.tabInventory.Controls.Add(this.LbInventory);
            this.tabInventory.Location = new System.Drawing.Point(4, 4);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(755, 405);
            this.tabInventory.TabIndex = 1;
            this.tabInventory.Text = "Inventory List";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // TbxSummary
            // 
            this.TbxSummary.Location = new System.Drawing.Point(0, 311);
            this.TbxSummary.Multiline = true;
            this.TbxSummary.Name = "TbxSummary";
            this.TbxSummary.ReadOnly = true;
            this.TbxSummary.Size = new System.Drawing.Size(755, 91);
            this.TbxSummary.TabIndex = 1;
            // 
            // LbInventory
            // 
            this.LbInventory.FormattingEnabled = true;
            this.LbInventory.ItemHeight = 20;
            this.LbInventory.Location = new System.Drawing.Point(-4, 0);
            this.LbInventory.Name = "LbInventory";
            this.LbInventory.Size = new System.Drawing.Size(759, 304);
            this.LbInventory.TabIndex = 0;
            this.LbInventory.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.LbInventory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LbInventory_MouseDoubleClick);
            // 
            // VehcleInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "VehcleInventoryForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabNewVehicle.ResumeLayout(false);
            this.tabNewVehicle.PerformLayout();
            this.tabInventory.ResumeLayout(false);
            this.tabInventory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNewVehicle;
        private System.Windows.Forms.TextBox txbLicense;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbVIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LbInventory;
        private System.Windows.Forms.TextBox TbxSummary;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbResults;
    }
}

