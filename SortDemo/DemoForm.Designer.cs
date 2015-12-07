﻿namespace SortDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bubbleSortPanel
            // 
            this.bubbleSortPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bubbleSortPanel.Location = new System.Drawing.Point(12, 46);
            this.bubbleSortPanel.Name = "bubbleSortPanel";
            this.bubbleSortPanel.Size = new System.Drawing.Size(261, 301);
            this.bubbleSortPanel.TabIndex = 0;
            this.bubbleSortPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bubbleSortPanel_Paint);
            // 
            // insertionSortPanel
            // 
            this.insertionSortPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.insertionSortPanel.Location = new System.Drawing.Point(279, 46);
            this.insertionSortPanel.Name = "insertionSortPanel";
            this.insertionSortPanel.Size = new System.Drawing.Size(261, 301);
            this.insertionSortPanel.TabIndex = 1;
            this.insertionSortPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.insertionSortPanel_Paint);
            // 
            // quickSortPanel
            // 
            this.quickSortPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quickSortPanel.Location = new System.Drawing.Point(546, 46);
            this.quickSortPanel.Name = "quickSortPanel";
            this.quickSortPanel.Size = new System.Drawing.Size(261, 301);
            this.quickSortPanel.TabIndex = 2;
            this.quickSortPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.quickSortPanel_Paint);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Insertion Sort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bubble Sort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quick Sort";
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 609);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quickSortPanel);
            this.Controls.Add(this.insertionSortPanel);
            this.Controls.Add(this.bubbleSortPanel);
            this.Name = "DemoForm";
            this.Text = "Sort Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel bubbleSortPanel;
        private System.Windows.Forms.Panel insertionSortPanel;
        private System.Windows.Forms.Panel quickSortPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

