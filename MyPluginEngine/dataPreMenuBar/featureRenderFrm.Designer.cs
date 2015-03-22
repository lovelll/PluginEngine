namespace dataPreMenuBar
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("单一符号");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("要素", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("唯一值");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("类别", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("分级色彩");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("分级符号");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("比例符号");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("点密度");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("数量", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("饼图");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("条形图/柱状图");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("堆叠图");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("图表", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(featureRenderFrm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SimpleRender = new System.Windows.Forms.GroupBox();
            this.LayerGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxLayers2Symbolize = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSymbolize = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SimpleRender.SuspendLayout();
            this.LayerGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            treeNode1.Name = "SimpleRender";
            treeNode1.Text = "单一符号";
            treeNode2.Name = "Feature";
            treeNode2.Text = "要素";
            treeNode3.Name = "UniqueValueRender";
            treeNode3.Text = "唯一值";
            treeNode4.Name = "Classes";
            treeNode4.Text = "类别";
            treeNode5.Name = "ClassBreaksRenderByC";
            treeNode5.Text = "分级色彩";
            treeNode6.Name = "ClassBreaksRenderByS";
            treeNode6.Text = "分级符号";
            treeNode7.Name = "PropSymbolRender";
            treeNode7.Text = "比例符号";
            treeNode8.Name = "DotDensityRender";
            treeNode8.Text = "点密度";
            treeNode9.Name = "Number";
            treeNode9.Text = "数量";
            treeNode10.Name = "PieChartRender";
            treeNode10.Text = "饼图";
            treeNode11.Name = "BarChartRender";
            treeNode11.Text = "条形图/柱状图";
            treeNode12.Name = "StackChartRender";
            treeNode12.Text = "堆叠图";
            treeNode13.Name = "Chart";
            treeNode13.Text = "图表";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode9,
            treeNode13});
            this.treeView1.Size = new System.Drawing.Size(186, 341);
            this.treeView1.TabIndex = 0;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "选择符号化图层：";
            // 
            // cbxLayers2Symbolize
            // 
            this.cbxLayers2Symbolize.FormattingEnabled = true;
            this.cbxLayers2Symbolize.Location = new System.Drawing.Point(172, 17);
            this.cbxLayers2Symbolize.Name = "cbxLayers2Symbolize";
            this.cbxLayers2Symbolize.Size = new System.Drawing.Size(162, 20);
            this.cbxLayers2Symbolize.TabIndex = 11;
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
            // btnSymbolize
            // 
            this.btnSymbolize.Location = new System.Drawing.Point(247, 48);
            this.btnSymbolize.Name = "btnSymbolize";
            this.btnSymbolize.Size = new System.Drawing.Size(66, 23);
            this.btnSymbolize.TabIndex = 15;
            this.btnSymbolize.Text = "符号化";
            this.btnSymbolize.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.SimpleRender.ResumeLayout(false);
            this.LayerGroup.ResumeLayout(false);
            this.LayerGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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

    }
}