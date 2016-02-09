using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CentennialCollegeStudentTracker
{
    public partial class Form1 : Form
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want quit the program?", "Quit Notification", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Good Bye~ See you soon~", "Good Bye!");
                this.Close();
            }
        }

        private void btn_add_student_Click(object sender, EventArgs e)
        {
            //If the user keeps any one of these fields (or both) empty and try to add, it will generate an appropriate error message
            if (string.IsNullOrWhiteSpace(tb_student_id.Text) || string.IsNullOrWhiteSpace(tb_student_name.Text))
            {
                //MessageBox.Show("Must input Student ID and Name both", "Error Notification");
                tb_system_window.Text += "[ERR] Must input Student ID and Name both" + Environment.NewLine;
            }
            else
            {
                // Add Student Data to Dictionary.
                dict.Add(int.Parse(tb_student_id.Text), tb_student_name.Text);
                tb_system_window.Text += "[ADD] StudentID: " + tb_student_id.Text + ", StudentName: " + tb_student_name.Text + Environment.NewLine;

                //success and clear text box.
                tb_student_id.Clear();
                tb_student_name.Clear();
            }
        }

        private void btn_display_all_Click(object sender, EventArgs e)
        {
            tb_system_window.Text += "[CLK] Dictionary Item Count: " + dict.Count + Environment.NewLine;

            lv_result_window.Items.Clear();
            lb_result_window.Items.Clear();

            if (dict.Count > 0)
            { 
                foreach (KeyValuePair<int, string> pair in dict)
                {
                    // Add data to ListView.
                    ListViewItem newList = new ListViewItem(pair.Key.ToString());
                    newList.SubItems.Add(pair.Value.ToString());
                    lv_result_window.Items.Add(newList);

                    // Add data to ListBox.
                    lb_result_window.Items.Add("ID: " + pair.Key.ToString() + ", Name: " + pair.Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("Dictionary Item is 0", "Error Notification");
            }
        }

        private void btn_clear_display_screen_Click(object sender, EventArgs e)
        {
            if (lb_result_window.Items.Count > 0)
            { 
                // Clear ListView data.
                lv_result_window.Items.Clear();

                // Clear ListBox data.
                lb_result_window.Items.Clear();

                tb_system_window.Text = "[CLR] Display Screen All" + Environment.NewLine;
            }
            else
            {
                tb_system_window.Text = "[ERR] There is nothing to clear" + Environment.NewLine;
                MessageBox.Show("There is nothing to clear", "Error Notification");
            }
        }

        private void btn_delete_all_record_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want DELETE ALL RECORD?", "Delete Notification", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                //check the dictionary is already null or not.
                if (dict.Count > 0)
                { 
                    // Remove all item from Dictionary
                    dict.Clear();
                    tb_system_window.Text += "[DEL] Delete All Record" + Environment.NewLine;
                }
                else
                {
                    tb_system_window.Text += "[ERR] Dictionary object is already empty" + Environment.NewLine;
                }
            }
        }

        private void btn_delete_record_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_student_id.Text))
            {
                //MessageBox.Show("Must input Student ID and Name both", "Error Notification");
                tb_system_window.Text += "[ERR] Must input Student ID for Delete Function" + Environment.NewLine;
            }
            else
            {
                //if key doe
                if( dict.Remove(int.Parse(tb_student_id.Text)) )
                {
                    //refresh display data.
                    btn_display_all_Click(sender, e);
                    
                    //success and clear text box.
                    tb_student_id.Clear();
                    tb_student_name.Clear();
                }
                else
                {
                    tb_system_window.Text += "[ERR] MustNo Record to Delete" + Environment.NewLine;
                }
            }
        }

        private void btn_search_with_id_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb_student_id.Text))
            {
                if (dict.ContainsKey(int.Parse(tb_student_id.Text)) == true)
                {
                    //if u find data, show up!
                    ListViewItem newList = new ListViewItem(tb_student_id.Text.ToString());
                    newList.SubItems.Add(dict[int.Parse(tb_student_id.Text)].ToString());
                    lv_result_window.Items.Add(newList);

                    // Add data to ListBox.
                    lb_result_window.Items.Add("ID: " + tb_student_id.Text.ToString() + ", Name: " + dict[int.Parse(tb_student_id.Text)].ToString());
                }
                else
                {
                    tb_system_window.Text += "[ERR] Key does not exist" + Environment.NewLine;
                    MessageBox.Show("Key does not exist", "Error Notification");
                }
            }
            else
            {
                tb_system_window.Text += "[ERR] Must input Student ID for Searching Student Function" + Environment.NewLine;
            }
        }

        private void tb_student_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            // e.KeyChar 8 is backspace.
            if(!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
