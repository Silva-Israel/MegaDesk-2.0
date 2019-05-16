namespace MegaDesk_Silva
{
    partial class AddQuote
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
            this.getQuote = new System.Windows.Forms.Button();
            this.deskWidthLabel = new System.Windows.Forms.Label();
            this.deskDepthLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.TextBox();
            this.numberDrawersLabel = new System.Windows.Forms.Label();
            this.numberOfDrawers = new System.Windows.Forms.ComboBox();
            this.surfaceMaterialLabel = new System.Windows.Forms.Label();
            this.desktopMaterial = new System.Windows.Forms.ComboBox();
            this.rushOrderLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // getQuote
            // 
            this.getQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getQuote.Location = new System.Drawing.Point(233, 379);
            this.getQuote.Name = "getQuote";
            this.getQuote.Size = new System.Drawing.Size(92, 31);
            this.getQuote.TabIndex = 7;
            this.getQuote.Text = "Get Quote";
            this.getQuote.UseVisualStyleBackColor = true;
            // 
            // deskWidthLabel
            // 
            this.deskWidthLabel.AutoSize = true;
            this.deskWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskWidthLabel.Location = new System.Drawing.Point(82, 135);
            this.deskWidthLabel.Name = "deskWidthLabel";
            this.deskWidthLabel.Size = new System.Drawing.Size(81, 18);
            this.deskWidthLabel.TabIndex = 2;
            this.deskWidthLabel.Text = "Desk width";
            // 
            // deskDepthLabel
            // 
            this.deskDepthLabel.AutoSize = true;
            this.deskDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskDepthLabel.Location = new System.Drawing.Point(222, 135);
            this.deskDepthLabel.Name = "deskDepthLabel";
            this.deskDepthLabel.Size = new System.Drawing.Size(83, 18);
            this.deskDepthLabel.TabIndex = 4;
            this.deskDepthLabel.Text = "Desk depth";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.fullNameLabel.Location = new System.Drawing.Point(82, 83);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(72, 18);
            this.fullNameLabel.TabIndex = 6;
            this.fullNameLabel.Text = "Full name";
            // 
            // fullName
            // 
            this.fullName.Location = new System.Drawing.Point(85, 104);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(240, 20);
            this.fullName.TabIndex = 1;
            // 
            // numberDrawersLabel
            // 
            this.numberDrawersLabel.AutoSize = true;
            this.numberDrawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberDrawersLabel.Location = new System.Drawing.Point(82, 190);
            this.numberDrawersLabel.Name = "numberDrawersLabel";
            this.numberDrawersLabel.Size = new System.Drawing.Size(135, 18);
            this.numberDrawersLabel.TabIndex = 8;
            this.numberDrawersLabel.Text = "Number of drawers";
            // 
            // numberOfDrawers
            // 
            this.numberOfDrawers.FormattingEnabled = true;
            this.numberOfDrawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.numberOfDrawers.Location = new System.Drawing.Point(85, 211);
            this.numberOfDrawers.Name = "numberOfDrawers";
            this.numberOfDrawers.Size = new System.Drawing.Size(100, 21);
            this.numberOfDrawers.TabIndex = 4;
            this.numberOfDrawers.Text = "Choose";
            // 
            // surfaceMaterialLabel
            // 
            this.surfaceMaterialLabel.AutoSize = true;
            this.surfaceMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMaterialLabel.Location = new System.Drawing.Point(82, 245);
            this.surfaceMaterialLabel.Name = "surfaceMaterialLabel";
            this.surfaceMaterialLabel.Size = new System.Drawing.Size(173, 18);
            this.surfaceMaterialLabel.TabIndex = 10;
            this.surfaceMaterialLabel.Text = "Desktop surface material";
            // 
            // desktopMaterial
            // 
            this.desktopMaterial.FormattingEnabled = true;
            this.desktopMaterial.Location = new System.Drawing.Point(85, 266);
            this.desktopMaterial.Name = "desktopMaterial";
            this.desktopMaterial.Size = new System.Drawing.Size(100, 21);
            this.desktopMaterial.TabIndex = 5;
            this.desktopMaterial.Text = "Choose";
            // 
            // rushOrderLabel
            // 
            this.rushOrderLabel.AutoSize = true;
            this.rushOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushOrderLabel.Location = new System.Drawing.Point(82, 301);
            this.rushOrderLabel.Name = "rushOrderLabel";
            this.rushOrderLabel.Size = new System.Drawing.Size(112, 18);
            this.rushOrderLabel.TabIndex = 12;
            this.rushOrderLabel.Text = "Production time";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "3 days (Mega Rush)",
            "5 days (Super Rush)",
            "7 days (Rush)",
            "14 days (Classic)"});
            this.comboBox1.Location = new System.Drawing.Point(85, 322);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Choose";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(85, 156);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(225, 156);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "New Quote";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rushOrderLabel);
            this.Controls.Add(this.desktopMaterial);
            this.Controls.Add(this.surfaceMaterialLabel);
            this.Controls.Add(this.numberOfDrawers);
            this.Controls.Add(this.numberDrawersLabel);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.deskDepthLabel);
            this.Controls.Add(this.deskWidthLabel);
            this.Controls.Add(this.getQuote);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getQuote;
        private System.Windows.Forms.Label deskWidthLabel;
        private System.Windows.Forms.Label deskDepthLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.Label numberDrawersLabel;
        private System.Windows.Forms.ComboBox numberOfDrawers;
        private System.Windows.Forms.Label surfaceMaterialLabel;
        private System.Windows.Forms.ComboBox desktopMaterial;
        private System.Windows.Forms.Label rushOrderLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
    }
}