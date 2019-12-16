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
        List<String> magatzems = new List<String>();
        List<String> magatzems2 = new List<String>();

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
            if(Repository.GetMagatzems() != null)
            {
                foreach (Magatzem m in Repository.GetMagatzems())
                {
                    magatzems.Add(m.nom);
                    magatzems2.Add(m.nom);
                }

                f.magatzem1cb.DataSource = magatzems;
                f.magatzem2cb.DataSource = magatzems2;
                f.magatzem2cb.SelectedIndex = 1;
            }

            f.magatzem1dgv.DataSource = Repository.GetMagatzemStock(1);
            f.magatzem2dgv.DataSource = Repository.GetMagatzemStock(2);

            hideCols();
        }

        private void hideCols()
        {
            try
            {

                f.magatzem1dgv.Columns[1].Visible = false;
                f.magatzem1dgv.Columns[4].Visible = false;
                f.magatzem1dgv.Columns[0].Visible = false;

                f.magatzem2dgv.Columns[1].Visible = false;
                f.magatzem2dgv.Columns[4].Visible = false;
                f.magatzem2dgv.Columns[0].Visible = false;

            }
            catch (Exception e)
            {

            }

        }

        private void InitListeners()
        {
            f.magatzem1cb.SelectionChangeCommitted += changeMagatzem;
            f.magatzem2cb.SelectionChangeCommitted += changeMagatzem2;
            f.sendQtyButton.Click += moveStock;
        }

        private void moveStock(object sender, EventArgs e)
        {
            try
            {
                int prod_id = int.Parse(f.magatzem1dgv.CurrentRow.Cells[0].FormattedValue.ToString());
                int sender_id = f.magatzem1cb.SelectedIndex+1;
                int receiver_id = f.magatzem2cb.SelectedIndex+1;
                int qty = int.Parse(f.qty.Text);

                if (!Repository.moveStock(receiver_id, sender_id, prod_id, qty))
                {
                    MessageBox.Show("There is not enough stock.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                reloadData();

            } catch(Exception ex)
            {

            }
        }

        private void reloadData()
        {
            f.magatzem1dgv.DataSource = Repository.GetMagatzemStock(f.magatzem1cb.SelectedIndex + 1);
            f.magatzem2dgv.DataSource = Repository.GetMagatzemStock(f.magatzem2cb.SelectedIndex + 1);

            hideCols();

        }

        private void changeMagatzem(object sender, EventArgs e)
        {
            ComboBox c = (sender as ComboBox);

            f.magatzem1dgv.DataSource = Repository.GetMagatzemStock(c.SelectedIndex+1);

            hideCols();
        }
        private void changeMagatzem2(object sender, EventArgs e)
        {
            ComboBox c = (sender as ComboBox);

            f.magatzem2dgv.DataSource = Repository.GetMagatzemStock(c.SelectedIndex + 1);

            hideCols();
        }

    }
}
