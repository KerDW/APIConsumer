using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using View;
using static Model.Model1;

namespace Controller
{
    public class Controller1
    {

        Form1 f;
        Model1 m;

        public Controller1()
        {
            f = new Form1();
            m = new Model1();
            
            InitListeners();
            InitData();

            Application.Run(f);
        }

        private void InitData()
        {
            if(Repository.GetContactesTot() != null)
            {
                f.dataGrid.DataSource = Repository.GetContactesTot();
            }

            hideCols();

        }

        private void hideCols()
        {
            try{

                f.dataGrid.Columns[3].Visible = false;
                f.dataGrid.Columns[4].Visible = false;
                f.phones.Columns[3].Visible = false;
                f.phones.Columns[4].Visible = false;
                f.mails.Columns[3].Visible = false;
                f.mails.Columns[4].Visible = false;

            } catch(Exception e)
            {

            }
            
        }

        private void InitListeners()
        {
            f.telefonsRB.CheckedChanged += changeTableSource;
            f.emailsRB.CheckedChanged += changeTableSource;
            f.contactesRB.CheckedChanged += changeTableSource;

            f.insertContacteRB.CheckedChanged += changeInsertLabelText;
            f.insertTelefonRB.CheckedChanged += changeInsertLabelText;
            f.insertEmailRB.CheckedChanged += changeInsertLabelText;

            f.searchButton.Click += searchContacte;
            f.insertButton.Click += insertValues;

            f.dataGrid.SelectionChanged += grid_SelectionChanged;

            f.remove.Click += removeGridItem;
            f.modify.Click += modifyGridItem;
        }
        private void changeInsertLabelText(object sender, EventArgs e)
        {
            RadioButton rb = (sender as RadioButton);

            switch (rb.Name)
            {
                case "insertContacteRB":
                    f.insert_field_1_label.Text = "Nom";
                    f.insert_field_2_label.Text = "Cognom";
                    break;
                case "insertTelefonRB":
                    f.insert_field_1_label.Text = "Telefon";
                    f.insert_field_2_label.Text = "Tipus";
                    break;
                case "insertEmailRB":
                    f.insert_field_1_label.Text = "Email";
                    f.insert_field_2_label.Text = "Tipus";
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
        private void cleanSecondaryGrids()
        {
            f.phones.DataSource = null;
            f.mails.DataSource = null;
        }

        private void insertValues(object sender, EventArgs e)
        {
            int id = int.Parse(f.dataGrid.CurrentRow.Cells[0].FormattedValue.ToString());

            string field_1 = f.insert_field_1.Text.ToString();
            string field_2 = f.insert_field_2.Text.ToString();

            String insertWhich = f.whichInsert.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Name;

            switch (insertWhich)
            {
                case "insertContacteRB":
                    Repository.InsertContacte(field_1, field_2);
                    break;
                case "insertTelefonRB":
                    if(f.sorter.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Name.Equals("contactesRB"))
                    {
                        Repository.InsertTelefon(id, field_1, field_2);
                    }
                    else
                    {
                        MessageBox.Show("Select a contacte to insert a telefon.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                case "insertEmailRB":
                    if (f.sorter.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Name.Equals("contactesRB"))
                    {
                        Repository.InsertEmail(id, field_1, field_2);
                    } else
                    {
                        MessageBox.Show("Select a contacte to insert an email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }

        private void searchContacte(object sender, EventArgs e)
        {
            String searchType = f.search.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Name;

            string name = f.searchName.Text.ToString();
            string nameTot = f.searchNameTot.Text.ToString();
            string email = f.searchMail.Text.ToString();
            string tlf = f.searchTlf.Text.ToString();

            switch (searchType)
            {
                case "searchNameRB":
                    cleanSecondaryGrids();
                    f.dataGrid.DataSource = Repository.GetContactesByName(name);
                    hideCols();
                    break;
                case "searchNameTotRB":
                    cleanSecondaryGrids();

                    List<contacte> c = Repository.GetContactesTotByName(nameTot);
                    List<telefon> ph = new List<telefon>();
                    List<email> em = new List<email>();

                    foreach (contacte co in c)
                    {
                        if(co.telefons != null)
                        {
                            ph.AddRange(co.telefons);
                        }
                        if (co.emails != null)
                        {
                            em.AddRange(co.emails);
                        }
                    }

                    f.dataGrid.DataSource = c;
                    f.phones.DataSource = ph;
                    f.mails.DataSource = em;

                    hideCols();
                    break;
                case "searchMailRB":
                    cleanSecondaryGrids();
                    f.dataGrid.DataSource = Repository.GetContactesByEmail(email);
                    f.mails.DataSource = Repository.GetEmailsByEmail(email);
                    hideCols();
                    break;
                case "searchTlfRB":
                    cleanSecondaryGrids();
                    f.dataGrid.DataSource = Repository.GetContactesByPhone(tlf);
                    f.phones.DataSource = Repository.GetPhonesByPhone(tlf);
                    hideCols();
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }

        private void modifyGridItem(object sender, EventArgs e)
        {
            String grid_table = f.sorter.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Name;
            // f.dataGrid.CurrentCell = f.dataGrid[0, 0];
            int currentIndex = f.dataGrid.CurrentCell.RowIndex;
            int id = int.Parse(f.dataGrid.CurrentRow.Cells[0].FormattedValue.ToString());
            String attr1 = f.attr1.Text.ToString();
            String attr2 = f.attr2.Text.ToString();

            switch (grid_table)
            {
                case "contactesRB":
                    Repository.ModifyContacte(id, attr1, attr2);
                    f.dataGrid.DataSource = Repository.GetContactesTot();
                    break;
                case "telefonsRB":
                    Repository.ModifyTelefon(id, attr1, attr2);
                    f.dataGrid.DataSource = Repository.GetTelefons();
                    break;
                case "emailsRB":
                    Repository.ModifyEmail(id, attr1, attr2);
                    f.dataGrid.DataSource = Repository.GetEmails();
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            f.dataGrid.CurrentCell = f.dataGrid.Rows[currentIndex].Cells[0];
            f.dataGrid.Rows[currentIndex].Selected = true;
            assignAttrValues();
        }

        private void removeGridItem(object sender, EventArgs e)
        {
            String grid_table = f.sorter.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Name;
            int id = int.Parse(f.dataGrid.CurrentRow.Cells[0].FormattedValue.ToString());

            switch (grid_table)
            {
                case "contactesRB":
                    Repository.DeleteContacte(id);
                    f.dataGrid.DataSource = Repository.GetContactesTot();
                    break;
                case "telefonsRB":
                    Repository.DeleteTelefon(id);
                    f.dataGrid.DataSource = Repository.GetTelefons();
                    break;
                case "emailsRB":
                    Repository.DeleteEmail(id);
                    f.dataGrid.DataSource = Repository.GetEmails();
                    break;
                default:
                    Console.WriteLine("error");
                    break; 
            }
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {

            cleanSecondaryGrids();

            if (f.dataGrid.Rows.Count == 0)
            {
                f.attr1.Text = "";
                f.attr2.Text = "";
                return;
            }

            assignAttrValues();

        }

        private void changeTableSource(object sender, EventArgs e)
        {
            RadioButton rb = (sender as RadioButton);

            //need to make the columns visible again due to conflicts between the tables
            foreach (DataGridViewColumn col in f.dataGrid.Columns)
            {
                col.Visible = true;
            }

            switch (rb.Name)
            {
                case "contactesRB":
                    f.dataGrid.DataSource = Repository.GetContactesTot();
                    break;
                case "telefonsRB":
                    f.dataGrid.DataSource = Repository.GetTelefons();
                    break;
                case "emailsRB":
                    f.dataGrid.DataSource = Repository.GetEmails();
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            assignAttrValues();
            f.dataGrid.Columns[3].Visible = false;
            f.dataGrid.Columns[4].Visible = false;

            f.dataGrid.CurrentCell = f.dataGrid[0, 0];
            f.dataGrid.CurrentCell = f.dataGrid.Rows[0].Cells[0];
            f.dataGrid.Rows[0].Selected = true;

        }

        private void assignAttrValues()
        {
            f.attr1.Text =

            string.IsNullOrEmpty(f.dataGrid.CurrentRow.Cells[1].FormattedValue.ToString())

            ?

            ""

            :

            f.dataGrid.CurrentRow.Cells[1].FormattedValue.ToString();

            f.attr2.Text =

            string.IsNullOrEmpty(f.dataGrid.CurrentRow.Cells[2].FormattedValue.ToString())

            ?

            ""

            :

            f.dataGrid.CurrentRow.Cells[2].FormattedValue.ToString();
        }
    }
}
