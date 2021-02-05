using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaker
{
    public partial class Form1 : Form
    {

        DataTable table;

        public Form1()
        {
            InitializeComponent();
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));

            dGrid.DataSource = table;
            dGrid.Columns[1].Visible = false; // set message section of column to hidden
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            // new implies clear boxes and create new text file
            titleTxt.Clear();
            msgTxt.Clear();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            // save message to grid and erase text boxes
            table.Rows.Add(titleTxt.Text, msgTxt.Text); // add data to table
            titleTxt.Clear();
            msgTxt.Clear();
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            // grab index
            int index;
            try
            {
                index = dGrid.CurrentCell.RowIndex;
            }
            catch(NullReferenceException exc)
            {
                Console.WriteLine(exc.GetBaseException()); // send error message to console
                index = -1;
            }

            // if index is present (>-1) perform loading
            if (index>-1)
            {
                titleTxt.Text = table.Rows[index].ItemArray[0].ToString();
                msgTxt.Text = table.Rows[index].ItemArray[1].ToString();

            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            // grab index
            int index;
            try
            {
                index = dGrid.CurrentCell.RowIndex;   
            }
            catch(NullReferenceException exc)
            {
                Console.WriteLine(exc.GetBaseException()); // send error message to console
                index = -1;
            }

            // if index is present (>-1) perform loading
            if (index > -1)
            {
                table.Rows[index].Delete();
            }
        }
    }
}
