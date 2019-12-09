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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.contactesRB = new System.Windows.Forms.RadioButton();
            this.emailsRB = new System.Windows.Forms.RadioButton();
            this.telefonsRB = new System.Windows.Forms.RadioButton();
            this.attr1 = new System.Windows.Forms.TextBox();
            this.attr2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.Button();
            this.sorter = new System.Windows.Forms.GroupBox();
            this.modify = new System.Windows.Forms.Button();
            this.dataGridEmails = new System.Windows.Forms.DataGridView();
            this.dataGridTelefons = new System.Windows.Forms.DataGridView();
            this.searchName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameRB = new System.Windows.Forms.RadioButton();
            this.search = new System.Windows.Forms.GroupBox();
            this.label64 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.searchMail = new System.Windows.Forms.TextBox();
            this.searchTlf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.sorter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTelefons)).BeginInit();
            this.search.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(110, 12);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(343, 317);
            this.dataGrid.TabIndex = 0;
            // 
            // contactesRB
            // 
            this.contactesRB.AutoSize = true;
            this.contactesRB.Checked = true;
            this.contactesRB.Location = new System.Drawing.Point(7, 10);
            this.contactesRB.Name = "contactesRB";
            this.contactesRB.Size = new System.Drawing.Size(73, 17);
            this.contactesRB.TabIndex = 1;
            this.contactesRB.TabStop = true;
            this.contactesRB.Text = "Contactes";
            this.contactesRB.UseVisualStyleBackColor = true;
            // 
            // emailsRB
            // 
            this.emailsRB.AutoSize = true;
            this.emailsRB.Location = new System.Drawing.Point(7, 77);
            this.emailsRB.Name = "emailsRB";
            this.emailsRB.Size = new System.Drawing.Size(55, 17);
            this.emailsRB.TabIndex = 2;
            this.emailsRB.Text = "Emails";
            this.emailsRB.UseVisualStyleBackColor = true;
            // 
            // telefonsRB
            // 
            this.telefonsRB.AutoSize = true;
            this.telefonsRB.Location = new System.Drawing.Point(7, 43);
            this.telefonsRB.Name = "telefonsRB";
            this.telefonsRB.Size = new System.Drawing.Size(66, 17);
            this.telefonsRB.TabIndex = 3;
            this.telefonsRB.Text = "Telefons";
            this.telefonsRB.UseVisualStyleBackColor = true;
            // 
            // attr1
            // 
            this.attr1.Location = new System.Drawing.Point(463, 12);
            this.attr1.Name = "attr1";
            this.attr1.Size = new System.Drawing.Size(100, 20);
            this.attr1.TabIndex = 4;
            // 
            // attr2
            // 
            this.attr2.Location = new System.Drawing.Point(463, 38);
            this.attr2.Name = "attr2";
            this.attr2.Size = new System.Drawing.Size(100, 20);
            this.attr2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(459, 306);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 23);
            this.remove.TabIndex = 7;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            // 
            // sorter
            // 
            this.sorter.Controls.Add(this.contactesRB);
            this.sorter.Controls.Add(this.emailsRB);
            this.sorter.Controls.Add(this.telefonsRB);
            this.sorter.Location = new System.Drawing.Point(12, 21);
            this.sorter.Name = "sorter";
            this.sorter.Size = new System.Drawing.Size(92, 106);
            this.sorter.TabIndex = 8;
            this.sorter.TabStop = false;
            this.sorter.Enter += new System.EventHandler(this.sorter_Enter);
            // 
            // modify
            // 
            this.modify.Location = new System.Drawing.Point(459, 277);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(75, 23);
            this.modify.TabIndex = 9;
            this.modify.Text = "Modify";
            this.modify.UseVisualStyleBackColor = true;
            // 
            // dataGridEmails
            // 
            this.dataGridEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmails.Location = new System.Drawing.Point(737, 244);
            this.dataGridEmails.MultiSelect = false;
            this.dataGridEmails.Name = "dataGridEmails";
            this.dataGridEmails.ReadOnly = true;
            this.dataGridEmails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmails.Size = new System.Drawing.Size(343, 134);
            this.dataGridEmails.TabIndex = 11;
            // 
            // dataGridTelefons
            // 
            this.dataGridTelefons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTelefons.Location = new System.Drawing.Point(737, 98);
            this.dataGridTelefons.MultiSelect = false;
            this.dataGridTelefons.Name = "dataGridTelefons";
            this.dataGridTelefons.ReadOnly = true;
            this.dataGridTelefons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTelefons.Size = new System.Drawing.Size(343, 140);
            this.dataGridTelefons.TabIndex = 12;
            // 
            // searchName
            // 
            this.searchName.Location = new System.Drawing.Point(627, 21);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(100, 20);
            this.searchName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Search by name";
            // 
            // nameRB
            // 
            this.nameRB.AutoSize = true;
            this.nameRB.Checked = true;
            this.nameRB.Location = new System.Drawing.Point(6, 19);
            this.nameRB.Name = "nameRB";
            this.nameRB.Size = new System.Drawing.Size(14, 13);
            this.nameRB.TabIndex = 17;
            this.nameRB.TabStop = true;
            this.nameRB.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Controls.Add(this.radioButton2);
            this.search.Controls.Add(this.radioButton1);
            this.search.Controls.Add(this.nameRB);
            this.search.Location = new System.Drawing.Point(594, 6);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(27, 121);
            this.search.TabIndex = 19;
            this.search.TabStop = false;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(749, 33);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(19, 18);
            this.label64.TabIndex = 20;
            this.label64.Text = "id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(809, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "nom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(939, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "cognoms";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 58);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 94);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // searchMail
            // 
            this.searchMail.Location = new System.Drawing.Point(627, 61);
            this.searchMail.Name = "searchMail";
            this.searchMail.Size = new System.Drawing.Size(100, 20);
            this.searchMail.TabIndex = 27;
            // 
            // searchTlf
            // 
            this.searchTlf.Location = new System.Drawing.Point(627, 99);
            this.searchTlf.Name = "searchTlf";
            this.searchTlf.Size = new System.Drawing.Size(100, 20);
            this.searchTlf.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(624, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Search by email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(624, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Search by telefon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 399);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchTlf);
            this.Controls.Add(this.searchMail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label64);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchName);
            this.Controls.Add(this.dataGridTelefons);
            this.Controls.Add(this.dataGridEmails);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.sorter);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attr2);
            this.Controls.Add(this.attr1);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.sorter.ResumeLayout(false);
            this.sorter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTelefons)).EndInit();
            this.search.ResumeLayout(false);
            this.search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGrid;
        public System.Windows.Forms.RadioButton contactesRB;
        public System.Windows.Forms.RadioButton emailsRB;
        public System.Windows.Forms.RadioButton telefonsRB;
        public System.Windows.Forms.TextBox attr1;
        public System.Windows.Forms.TextBox attr2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button remove;
        public System.Windows.Forms.GroupBox sorter;
        public System.Windows.Forms.Button modify;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.GroupBox search;
        public System.Windows.Forms.DataGridView dataGridEmails;
        public System.Windows.Forms.DataGridView dataGridTelefons;
        public System.Windows.Forms.TextBox searchName;
        public System.Windows.Forms.RadioButton nameRB;
        public System.Windows.Forms.Label label64;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.TextBox searchMail;
        public System.Windows.Forms.TextBox searchTlf;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label7;
    }
}

