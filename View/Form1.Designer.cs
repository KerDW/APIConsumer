namespace View
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
            this.magatzem1cb = new System.Windows.Forms.ComboBox();
            this.magatzem1dgv = new System.Windows.Forms.DataGridView();
            this.magatzem2dgv = new System.Windows.Forms.DataGridView();
            this.magatzem2cb = new System.Windows.Forms.ComboBox();
            this.sendQtyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.magatzem1dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magatzem2dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // magatzem1cb
            // 
            this.magatzem1cb.FormattingEnabled = true;
            this.magatzem1cb.Location = new System.Drawing.Point(12, 41);
            this.magatzem1cb.Name = "magatzem1cb";
            this.magatzem1cb.Size = new System.Drawing.Size(274, 21);
            this.magatzem1cb.TabIndex = 0;
            // 
            // magatzem1dgv
            // 
            this.magatzem1dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.magatzem1dgv.Location = new System.Drawing.Point(12, 68);
            this.magatzem1dgv.MultiSelect = false;
            this.magatzem1dgv.Name = "magatzem1dgv";
            this.magatzem1dgv.ReadOnly = true;
            this.magatzem1dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.magatzem1dgv.Size = new System.Drawing.Size(274, 282);
            this.magatzem1dgv.TabIndex = 1;
            // 
            // magatzem2dgv
            // 
            this.magatzem2dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.magatzem2dgv.Location = new System.Drawing.Point(513, 68);
            this.magatzem2dgv.MultiSelect = false;
            this.magatzem2dgv.Name = "magatzem2dgv";
            this.magatzem2dgv.ReadOnly = true;
            this.magatzem2dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.magatzem2dgv.Size = new System.Drawing.Size(301, 282);
            this.magatzem2dgv.TabIndex = 3;
            // 
            // magatzem2cb
            // 
            this.magatzem2cb.FormattingEnabled = true;
            this.magatzem2cb.Location = new System.Drawing.Point(513, 41);
            this.magatzem2cb.Name = "magatzem2cb";
            this.magatzem2cb.Size = new System.Drawing.Size(301, 21);
            this.magatzem2cb.TabIndex = 2;
            // 
            // sendQtyButton
            // 
            this.sendQtyButton.Location = new System.Drawing.Point(367, 196);
            this.sendQtyButton.Name = "sendQtyButton";
            this.sendQtyButton.Size = new System.Drawing.Size(75, 23);
            this.sendQtyButton.TabIndex = 4;
            this.sendQtyButton.Text = "-->";
            this.sendQtyButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quantitat:";
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(367, 160);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(75, 20);
            this.qty.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 362);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendQtyButton);
            this.Controls.Add(this.magatzem2dgv);
            this.Controls.Add(this.magatzem2cb);
            this.Controls.Add(this.magatzem1dgv);
            this.Controls.Add(this.magatzem1cb);
            this.Name = "Form1";
            this.Text = "Insert";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.magatzem1dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magatzem2dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox magatzem1cb;
        public System.Windows.Forms.DataGridView magatzem1dgv;
        public System.Windows.Forms.DataGridView magatzem2dgv;
        public System.Windows.Forms.ComboBox magatzem2cb;
        public System.Windows.Forms.Button sendQtyButton;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox qty;
    }
}

