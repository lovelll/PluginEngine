namespace BaseMenuBar
{
    partial class featureRenderFrm
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
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("单一符号");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("要素", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("唯一值");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("类别", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("分级色彩");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("分级符号");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("比例符号");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("点密度");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("数量", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("饼图");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("条形图/柱状图");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("堆叠图");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("图表", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24,
            treeNode25});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(featureRenderFrm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SimpleRender = new System.Windows.Forms.GroupBox();
            this.btnSymbolize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LayerGroup = new System.Windows.Forms.GroupBox();
            this.cbxLayers2Symbolize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UniqueValueRender = new System.Windows.Forms.GroupBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SimpleRender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LayerGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SimpleRender);
            this.splitContainer1.Panel2.Controls.Add(this.UniqueValueRender);
            this.splitContainer1.Panel2.Controls.Add(this.LayerGroup);
            this.splitContainer1.Size = new System.Drawing.Size(558, 341);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode14.Name = "SimpleRender";
            treeNode14.Text = "单一符号";
            treeNode15.Name = "Feature";
            treeNode15.Text = "要素";
            treeNode16.Name = "UniqueValueRender";
            treeNode16.Text = "唯一值";
            treeNode17.Name = "Classes";
            treeNode17.Text = "类别";
            treeNode18.Name = "ClassBreaksRenderByC";
            treeNode18.Text = "分级色彩";
            treeNode19.Name = "ClassBreaksRenderByS";
            treeNode19.Text = "分级符号";
            treeNode20.Name = "PropSymbolRender";
            treeNode20.Text = "比例符号";
            treeNode21.Name = "DotDensityRender";
            treeNode21.Text = "点密度";
            treeNode22.Name = "Number";
            treeNode22.Text = "数量";
            treeNode23.Name = "PieChartRender";
            treeNode23.Text = "饼图";
            treeNode24.Name = "BarChartRender";
            treeNode24.Text = "条形图/柱状图";
            treeNode25.Name = "StackChartRender";
            treeNode25.Text = "堆叠图";
            treeNode26.Name = "Chart";
            treeNode26.Text = "图表";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode17,
            treeNode22,
            treeNode26});
            this.treeView1.Size = new System.Drawing.Size(186, 341);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // SimpleRender
            // 
            this.SimpleRender.Controls.Add(this.btnSymbolize);
            this.SimpleRender.Controls.Add(this.pictureBox1);
            this.SimpleRender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimpleRender.Location = new System.Drawing.Point(0, 45);
            this.SimpleRender.Name = "SimpleRender";
            this.SimpleRender.Size = new System.Drawing.Size(368, 296);
            this.SimpleRender.TabIndex = 1;
            this.SimpleRender.TabStop = false;
            this.SimpleRender.Text = "单一符号";
            // 
            // btnSymbolize
            // 
            this.btnSymbolize.Location = new System.Drawing.Point(247, 48);
            this.btnSymbolize.Name = "btnSymbolize";
            this.btnSymbolize.Size = new System.Drawing.Size(66, 23);
            this.btnSymbolize.TabIndex = 15;
            this.btnSymbolize.Text = "符号化";
            this.btnSymbolize.UseVisualStyleBackColor = true;
            this.btnSymbolize.Click += new System.EventHandler(this.btnSymbolize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // LayerGroup
            // 
            this.LayerGroup.Controls.Add(this.cbxLayers2Symbolize);
            this.LayerGroup.Controls.Add(this.label2);
            this.LayerGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.LayerGroup.Location = new System.Drawing.Point(0, 0);
            this.LayerGroup.Name = "LayerGroup";
            this.LayerGroup.Size = new System.Drawing.Size(368, 45);
            this.LayerGroup.TabIndex = 0;
            this.LayerGroup.TabStop = false;
            // 
            // cbxLayers2Symbolize
            // 
            this.cbxLayers2Symbolize.FormattingEnabled = true;
            this.cbxLayers2Symbolize.Location = new System.Drawing.Point(172, 17);
            this.cbxLayers2Symbolize.Name = "cbxLayers2Symbolize";
            this.cbxLayers2Symbolize.Size = new System.Drawing.Size(162, 20);
            this.cbxLayers2Symbolize.TabIndex = 11;
            this.cbxLayers2Symbolize.SelectedIndexChanged += new System.EventHandler(this.cbxLayers2Symbolize_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "选择符号化图层：";
            // 
            // UniqueValueRender
            // 
            this.UniqueValueRender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UniqueValueRender.Location = new System.Drawing.Point(0, 45);
            this.UniqueValueRender.Name = "UniqueValueRender";
            this.UniqueValueRender.Size = new System.Drawing.Size(368, 296);
            this.UniqueValueRender.TabIndex = 16;
            this.UniqueValueRender.TabStop = false;
            this.UniqueValueRender.Text = "UniqueValueRender";
            this.UniqueValueRender.Visible = false;
            // 
            // featureRenderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 341);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Name = "featureRenderFrm";
            this.Text = "featureRenderFrm";
            this.Load += new System.EventHandler(this.featureRenderFrm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.SimpleRender.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LayerGroup.ResumeLayout(false);
            this.LayerGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox SimpleRender;
        private System.Windows.Forms.GroupBox LayerGroup;
        private System.Windows.Forms.Button btnSymbolize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbxLayers2Symbolize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox UniqueValueRender;

    }
}