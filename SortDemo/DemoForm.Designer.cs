namespace SortDemo
{
    partial class DemoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quickSortPanel = new System.Windows.Forms.Panel();
            this.insertionSortPanel = new System.Windows.Forms.Panel();
            this.bubbleSortPanel = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.runButton = new System.Windows.Forms.ToolStripButton();
            this.pauseButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Quick Sort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Bubble Sort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Insertion Sort";
            // 
            // quickSortPanel
            // 
            this.quickSortPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quickSortPanel.Location = new System.Drawing.Point(552, 78);
            this.quickSortPanel.Name = "quickSortPanel";
            this.quickSortPanel.Size = new System.Drawing.Size(261, 301);
            this.quickSortPanel.TabIndex = 15;
            this.quickSortPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.quickSortPanel_Paint);
            // 
            // insertionSortPanel
            // 
            this.insertionSortPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.insertionSortPanel.Location = new System.Drawing.Point(285, 78);
            this.insertionSortPanel.Name = "insertionSortPanel";
            this.insertionSortPanel.Size = new System.Drawing.Size(261, 301);
            this.insertionSortPanel.TabIndex = 14;
            this.insertionSortPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.insertionSortPanel_Paint);
            // 
            // bubbleSortPanel
            // 
            this.bubbleSortPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bubbleSortPanel.Location = new System.Drawing.Point(18, 78);
            this.bubbleSortPanel.Name = "bubbleSortPanel";
            this.bubbleSortPanel.Size = new System.Drawing.Size(261, 301);
            this.bubbleSortPanel.TabIndex = 13;
            this.bubbleSortPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bubbleSortPanel_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runButton,
            this.pauseButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(825, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // runButton
            // 
            this.runButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.runButton.Image = ((System.Drawing.Image)(resources.GetObject("runButton.Image")));
            this.runButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(23, 22);
            this.runButton.Text = "Run";
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pauseButton.Image = ((System.Drawing.Image)(resources.GetObject("pauseButton.Image")));
            this.pauseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(23, 22);
            this.pauseButton.Text = "Pause";
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 609);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quickSortPanel);
            this.Controls.Add(this.insertionSortPanel);
            this.Controls.Add(this.bubbleSortPanel);
            this.Name = "DemoForm";
            this.Text = "Sort Demo";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel quickSortPanel;
        private System.Windows.Forms.Panel insertionSortPanel;
        private System.Windows.Forms.Panel bubbleSortPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton runButton;
        private System.Windows.Forms.ToolStripButton pauseButton;
    }
}

