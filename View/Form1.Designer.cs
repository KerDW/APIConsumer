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
            this.searchNameTot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchNameTotRB = new System.Windows.Forms.RadioButton();
            this.search = new System.Windows.Forms.GroupBox();
            this.searchTlfRB = new System.Windows.Forms.RadioButton();
            this.searchMailRB = new System.Windows.Forms.RadioButton();
            this.searchMail = new System.Windows.Forms.TextBox();
            this.searchTlf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.phones = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.mails = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.searchName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.searchNameRB = new System.Windows.Forms.RadioButton();
            this.insert_field_1 = new System.Windows.Forms.TextBox();
            this.insert_field_2 = new System.Windows.Forms.TextBox();
            this.whichInsert = new System.Windows.Forms.GroupBox();
            this.insertContacteRB = new System.Windows.Forms.RadioButton();
            this.insertEmailRB = new System.Windows.Forms.RadioButton();
            this.insertTelefonRB = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.insert_field_1_label = new System.Windows.Forms.Label();
            this.insert_field_2_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.sorter.SuspendLayout();
            this.search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mails)).BeginInit();
            this.whichInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(159, 12);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(346, 317);
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
            this.attr1.Location = new System.Drawing.Point(525, 12);
            this.attr1.Name = "attr1";
            this.attr1.Size = new System.Drawing.Size(103, 20);
            this.attr1.TabIndex = 4;
            // 
            // attr2
            // 
            this.attr2.Location = new System.Drawing.Point(525, 38);
            this.attr2.Name = "attr2";
            this.attr2.Size = new System.Drawing.Size(103, 20);
            this.attr2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(521, 306);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(78, 23);
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
            this.modify.Location = new System.Drawing.Point(521, 277);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(78, 23);
            this.modify.TabIndex = 9;
            this.modify.Text = "Modify";
            this.modify.UseVisualStyleBackColor = true;
            // 
            // searchNameTot
            // 
            this.searchNameTot.Location = new System.Drawing.Point(45, 182);
            this.searchNameTot.Name = "searchNameTot";
            this.searchNameTot.Size = new System.Drawing.Size(100, 20);
            this.searchNameTot.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Search by name (tot) ";
            // 
            // searchNameTotRB
            // 
            this.searchNameTotRB.AutoSize = true;
            this.searchNameTotRB.Checked = true;
            this.searchNameTotRB.Location = new System.Drawing.Point(6, 55);
            this.searchNameTotRB.Name = "searchNameTotRB";
            this.searchNameTotRB.Size = new System.Drawing.Size(14, 13);
            this.searchNameTotRB.TabIndex = 17;
            this.searchNameTotRB.TabStop = true;
            this.searchNameTotRB.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Controls.Add(this.searchNameRB);
            this.search.Controls.Add(this.searchTlfRB);
            this.search.Controls.Add(this.searchMailRB);
            this.search.Controls.Add(this.searchNameTotRB);
            this.search.Location = new System.Drawing.Point(12, 130);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(27, 151);
            this.search.TabIndex = 19;
            this.search.TabStop = false;
            // 
            // searchTlfRB
            // 
            this.searchTlfRB.AutoSize = true;
            this.searchTlfRB.Location = new System.Drawing.Point(6, 131);
            this.searchTlfRB.Name = "searchTlfRB";
            this.searchTlfRB.Size = new System.Drawing.Size(14, 13);
            this.searchTlfRB.TabIndex = 20;
            this.searchTlfRB.UseVisualStyleBackColor = true;
            // 
            // searchMailRB
            // 
            this.searchMailRB.AutoSize = true;
            this.searchMailRB.Location = new System.Drawing.Point(6, 94);
            this.searchMailRB.Name = "searchMailRB";
            this.searchMailRB.Size = new System.Drawing.Size(14, 13);
            this.searchMailRB.TabIndex = 19;
            this.searchMailRB.UseVisualStyleBackColor = true;
            // 
            // searchMail
            // 
            this.searchMail.Location = new System.Drawing.Point(45, 221);
            this.searchMail.Name = "searchMail";
            this.searchMail.Size = new System.Drawing.Size(100, 20);
            this.searchMail.TabIndex = 27;
            // 
            // searchTlf
            // 
            this.searchTlf.Location = new System.Drawing.Point(45, 259);
            this.searchTlf.Name = "searchTlf";
            this.searchTlf.Size = new System.Drawing.Size(100, 20);
            this.searchTlf.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Search by email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Search by telefon";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(57, 286);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 31;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // phones
            // 
            this.phones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phones.Location = new System.Drawing.Point(634, 31);
            this.phones.MultiSelect = false;
            this.phones.Name = "phones";
            this.phones.ReadOnly = true;
            this.phones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.phones.Size = new System.Drawing.Size(373, 135);
            this.phones.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(633, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Phones";
            // 
            // mails
            // 
            this.mails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mails.Location = new System.Drawing.Point(634, 193);
            this.mails.MultiSelect = false;
            this.mails.Name = "mails";
            this.mails.ReadOnly = true;
            this.mails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mails.Size = new System.Drawing.Size(373, 135);
            this.mails.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(633, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Emails";
            // 
            // searchName
            // 
            this.searchName.Location = new System.Drawing.Point(45, 146);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(100, 20);
            this.searchName.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Search by name";
            // 
            // searchNameRB
            // 
            this.searchNameRB.AutoSize = true;
            this.searchNameRB.Location = new System.Drawing.Point(6, 19);
            this.searchNameRB.Name = "searchNameRB";
            this.searchNameRB.Size = new System.Drawing.Size(14, 13);
            this.searchNameRB.TabIndex = 22;
            this.searchNameRB.UseVisualStyleBackColor = true;
            // 
            // insert_field_1
            // 
            this.insert_field_1.Location = new System.Drawing.Point(246, 354);
            this.insert_field_1.Name = "insert_field_1";
            this.insert_field_1.Size = new System.Drawing.Size(100, 20);
            this.insert_field_1.TabIndex = 39;
            // 
            // insert_field_2
            // 
            this.insert_field_2.Location = new System.Drawing.Point(352, 354);
            this.insert_field_2.Name = "insert_field_2";
            this.insert_field_2.Size = new System.Drawing.Size(100, 20);
            this.insert_field_2.TabIndex = 40;
            // 
            // whichInsert
            // 
            this.whichInsert.Controls.Add(this.insertContacteRB);
            this.whichInsert.Controls.Add(this.insertEmailRB);
            this.whichInsert.Controls.Add(this.insertTelefonRB);
            this.whichInsert.Location = new System.Drawing.Point(12, 306);
            this.whichInsert.Name = "whichInsert";
            this.whichInsert.Size = new System.Drawing.Size(27, 116);
            this.whichInsert.TabIndex = 41;
            this.whichInsert.TabStop = false;
            // 
            // insertContacteRB
            // 
            this.insertContacteRB.AutoSize = true;
            this.insertContacteRB.Checked = true;
            this.insertContacteRB.Location = new System.Drawing.Point(6, 19);
            this.insertContacteRB.Name = "insertContacteRB";
            this.insertContacteRB.Size = new System.Drawing.Size(14, 13);
            this.insertContacteRB.TabIndex = 22;
            this.insertContacteRB.TabStop = true;
            this.insertContacteRB.UseVisualStyleBackColor = true;
            // 
            // insertEmailRB
            // 
            this.insertEmailRB.AutoSize = true;
            this.insertEmailRB.Location = new System.Drawing.Point(6, 94);
            this.insertEmailRB.Name = "insertEmailRB";
            this.insertEmailRB.Size = new System.Drawing.Size(14, 13);
            this.insertEmailRB.TabIndex = 19;
            this.insertEmailRB.UseVisualStyleBackColor = true;
            // 
            // insertTelefonRB
            // 
            this.insertTelefonRB.AutoSize = true;
            this.insertTelefonRB.Location = new System.Drawing.Point(6, 55);
            this.insertTelefonRB.Name = "insertTelefonRB";
            this.insertTelefonRB.Size = new System.Drawing.Size(14, 13);
            this.insertTelefonRB.TabIndex = 17;
            this.insertTelefonRB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Insert contacte";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Insert telefon to the selected contacte";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Insert email to the selected contacte";
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(246, 389);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(78, 23);
            this.insert.TabIndex = 45;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            // 
            // insert_field_1_label
            // 
            this.insert_field_1_label.AutoSize = true;
            this.insert_field_1_label.Location = new System.Drawing.Point(243, 338);
            this.insert_field_1_label.Name = "insert_field_1_label";
            this.insert_field_1_label.Size = new System.Drawing.Size(29, 13);
            this.insert_field_1_label.TabIndex = 46;
            this.insert_field_1_label.Text = "Nom";
            // 
            // insert_field_2_label
            // 
            this.insert_field_2_label.AutoSize = true;
            this.insert_field_2_label.Location = new System.Drawing.Point(352, 338);
            this.insert_field_2_label.Name = "insert_field_2_label";
            this.insert_field_2_label.Size = new System.Drawing.Size(46, 13);
            this.insert_field_2_label.TabIndex = 47;
            this.insert_field_2_label.Text = "Cognom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 424);
            this.Controls.Add(this.insert_field_2_label);
            this.Controls.Add(this.insert_field_1_label);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.whichInsert);
            this.Controls.Add(this.insert_field_2);
            this.Controls.Add(this.insert_field_1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.searchName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mails);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phones);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchTlf);
            this.Controls.Add(this.searchMail);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchNameTot);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.sorter);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attr2);
            this.Controls.Add(this.attr1);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form1";
            this.Text = "Insert";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.sorter.ResumeLayout(false);
            this.sorter.PerformLayout();
            this.search.ResumeLayout(false);
            this.search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mails)).EndInit();
            this.whichInsert.ResumeLayout(false);
            this.whichInsert.PerformLayout();
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
        public System.Windows.Forms.TextBox searchNameTot;
        public System.Windows.Forms.RadioButton searchNameTotRB;
        public System.Windows.Forms.RadioButton searchTlfRB;
        public System.Windows.Forms.RadioButton searchMailRB;
        public System.Windows.Forms.TextBox searchMail;
        public System.Windows.Forms.TextBox searchTlf;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button searchButton;
        public System.Windows.Forms.DataGridView phones;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView mails;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox searchName;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.RadioButton searchNameRB;
        public System.Windows.Forms.TextBox insert_field_1;
        public System.Windows.Forms.TextBox insert_field_2;
        public System.Windows.Forms.GroupBox whichInsert;
        public System.Windows.Forms.RadioButton insertContacteRB;
        public System.Windows.Forms.RadioButton insertEmailRB;
        public System.Windows.Forms.RadioButton insertTelefonRB;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button insert;
        public System.Windows.Forms.Label insert_field_1_label;
        public System.Windows.Forms.Label insert_field_2_label;
    }
}

