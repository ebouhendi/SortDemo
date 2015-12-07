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
            this.bubbleSortPanel = new System.Windows.Forms.Panel();
            this.insertionSortPanel = new System.Windows.Forms.Panel();
            this.quickSortPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bubbleSortPanel
            // 
            this.bubbleSortPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bubbleSortPanel.Location = new System.Drawing.Point(12, 12);
            this.bubbleSortPanel.Name = "bubbleSortPanel";
            this.bubbleSortPanel.Size = new System.Drawing.Size(261, 301);
            this.bubbleSortPanel.TabIndex = 0;
            this.bubbleSortPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bubbleSortPanel_Paint);
            // 
            // insertionSortPanel
            // 
            this.insertionSortPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.insertionSortPanel.Location = new System.Drawing.Point(279, 12);
            this.insertionSortPanel.Name = "insertionSortPanel";
            this.insertionSortPanel.Size = new System.Drawing.Size(261, 301);
            this.insertionSortPanel.TabIndex = 1;
            this.insertionSortPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.insertionSortPanel_Paint);
            // 
            // quickSortPanel
            // 
            this.quickSortPanel.Location = new System.Drawing.Point(546, 12);
            this.quickSortPanel.Name = "quickSortPanel";
            this.quickSortPanel.Size = new System.Drawing.Size(261, 301);
            this.quickSortPanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 609);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quickSortPanel);
            this.Controls.Add(this.insertionSortPanel);
            this.Controls.Add(this.bubbleSortPanel);
            this.Name = "DemoForm";
            this.Text = "Sort Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bubbleSortPanel;
        private System.Windows.Forms.Panel insertionSortPanel;
        private System.Windows.Forms.Panel quickSortPanel;
        private System.Windows.Forms.Button button1;
    }
}

