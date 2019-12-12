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
                f.phonesOrMails.Columns[3].Visible = false;
                f.phonesOrMails.Columns[4].Visible = false;

            } catch(Exception e)
            {

            }
            
        }

        private void InitListeners()
        {
            f.telefonsRB.CheckedChanged += changeTableSource;
            f.emailsRB.CheckedChanged += changeTableSource;
            f.contactesRB.CheckedChanged += changeTableSource;

            f.searchButton.Click += searchContacte;

            f.dataGrid.SelectionChanged += grid_SelectionChanged;

            f.remove.Click += removeGridItem;
            f.modify.Click += modifyGridItem;
        }

        private void searchContacte(object sender, EventArgs e)
        {
            String searchType = f.search.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Name;

            string name = f.searchName.Text.ToString();
            string email = f.searchMail.Text.ToString();
            string tlf = f.searchTlf.Text.ToString();

            switch (searchType)
            {
                case "searchNameRB":
                    f.dataGrid.DataSource = Repository.GetContactesTotByName(name);
                    hideCols();
                    break;
                case "searchMailRB":
                    f.dataGrid.DataSource = Repository.GetContactesByEmail(email);
                    f.phonesOrMails.DataSource = Repository.GetEmailsByEmail(email);
                    hideCols();
                    break;
                case "searchTlfRB":
                    f.dataGrid.DataSource = Repository.GetContactesByPhone(tlf);
                    f.phonesOrMails.DataSource = Repository.GetPhonesByPhone(tlf);
                    hideCols();
                    break;
                case "noFilter":
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }

        private void modifyGridItem(object sender, EventArgs e)
        {
            String grid_table = f.sorter.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Name;
            f.dataGrid.CurrentCell = f.dataGrid[0, 0];
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
