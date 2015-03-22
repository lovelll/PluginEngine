namespace dataPreMenuBar
{
    partial class GetSymbolByControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxStyleClass = new System.Windows.Forms.ComboBox();
            this.cbxStyles = new System.Windows.Forms.ComboBox();
            this.btnOtherStyles = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "选择符号类：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "选择样式库：";
            // 
            // cbxStyleClass
            // 
            this.cbxStyleClass.FormattingEnabled = true;
            this.cbxStyleClass.Items.AddRange(new object[] {
            "Reference Systems",
            "Maplex Labels",
            "Shadows",
            "Area Patches",
            "Line Patches",
            "Labels",
            "North Arrows",
            "Scale Bars",
            "Legend Items",
            "Scale Texts",
            "Color Ramps",
            "Borders",
            "Backgrounds",
            "Colors",
            "Vectorization Settings",
            "Fill Symbols",
            "Line Symbols",
            "Marker Symbols",
            "Text Symbols",
            "Hatches"});
            this.cbxStyleClass.Location = new System.Drawing.Point(104, 47);
            this.cbxStyleClass.Name = "cbxStyleClass";
            this.cbxStyleClass.Size = new System.Drawing.Size(305, 20);
            this.cbxStyleClass.TabIndex = 19;
            // 
            // cbxStyles
            // 
            this.cbxStyles.FormattingEnabled = true;
            this.cbxStyles.Location = new System.Drawing.Point(104, 19);
            this.cbxStyles.Name = "cbxStyles";
            this.cbxStyles.Size = new System.Drawing.Size(305, 20);
            this.cbxStyles.TabIndex = 20;
            // 
            // btnOtherStyles
            // 
            this.btnOtherStyles.Location = new System.Drawing.Point(415, 17);
            this.btnOtherStyles.Name = "btnOtherStyles";
            this.btnOtherStyles.Size = new System.Drawing.Size(40, 25);
            this.btnOtherStyles.TabIndex = 17;
            this.btnOtherStyles.Text = "其它";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(24, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 310);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Symbology";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(474, 293);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(65, 25);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "确 定";
            // 
            // GetSymbolByControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 409);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxStyleClass);
            this.Controls.Add(this.cbxStyles);
            this.Controls.Add(this.btnOtherStyles);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnOK);
            this.Name = "GetSymbolByControl";
            this.Text = "GetSymbolByControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxStyleClass;
        private System.Windows.Forms.ComboBox cbxStyles;
        private System.Windows.Forms.Button btnOtherStyles;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOK;
    }
}