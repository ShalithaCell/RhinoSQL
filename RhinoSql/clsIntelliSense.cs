using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RhinoSql
{
    class clsIntelliSense
    {
        [DllImport("user32")]
        private extern static int GetCaretPos(out Point p);

        /// <summary>
        /// <para>AutoCompleteTextBox is the method to popups when typing the keywords on TextBox to avoid the mistakes.</para>
        /// <para>Type 1:</para>
        /// <para>&#160;&#160;&#160;&#160;List&lt;string&gt; ISList = new List&lt;string&gt;(new string[] { "SELECT", "CREATE", "TABLE" }); </para>
        /// <para>&#160;&#160;&#160;&#160;AutoCompleteTextBox(textBox1,listBox1, ISList,e);</para>
        /// <para></para>
        /// <para>Type 2:</para>
        /// <para>&#160;&#160;&#160;&#160;AutoCompleteTextBox(textBox1,listBox1,new List&lt;string&gt;(new string[] { "SELECT", "CREATE", "TABLE" }),e);</para>
        /// <para></para>
        /// <para>Type 3:</para>
        /// <para>&#160;&#160;&#160;&#160;AutoCompleteTextBox(textBox1,listBox1,new string[] { "SELECT", "CREATE", "TABLE" }.ToList(),e);</para>
        /// <para>Note: Don't Use Two Words in Dictonary List. Ex. "AUDI CAR" </para>
        /// </summary>
        /// <param name="txtControl">Text Box Name</param>
        /// <param name="lstControl">List Box Name</param>
        /// <param name="lstAutoCompleteList">Dictornary List</param>
        /// <param name="txtControlKEA">Text Box Key Up Event Args.</param>
        /// 
        public static void AutoCompleteTextBox(TextBox txtControl, ListBox lstControl, List<string> lstAutoCompleteList, KeyEventArgs txtControlKEA)
        {
            Point cp;
            GetCaretPos(out cp);
            List<string> lstTemp = new List<string>();
            //Positioning the Listbox on TextBox by Type Insertion Cursor position
            lstControl.SetBounds(cp.X + txtControl.Left, cp.Y + txtControl.Top + 20, 150, 50);

            var TempFilteredList = lstAutoCompleteList.Where(n => n.StartsWith(GetLastString(txtControl.Text).ToUpper())).Select(r => r);

            lstTemp = TempFilteredList.ToList<string>();
            if (lstTemp.Count != 0 && GetLastString(txtControl.Text) != "")
            {
                lstControl.DataSource = lstTemp;
                lstControl.Show();
            }
            else
            {
                lstControl.Hide();
            }

            //Code for focusing ListBox Items While Pressing Down and UP Key. 
            if (txtControlKEA.KeyCode == Keys.Down)
            {
                lstControl.SelectedIndex = 0;
                lstControl.Focus();
                txtControlKEA.Handled = true;
            }
            else if (txtControlKEA.KeyCode == Keys.Up)
            {
                lstControl.SelectedIndex = lstControl.Items.Count - 1;
                lstControl.Focus();
                txtControlKEA.Handled = true;
            }

            //text box key press event
            txtControl.KeyPress += (s, kpeArgs) =>
            {

                if (kpeArgs.KeyChar == (char)Keys.Enter)
                {
                    if (lstControl.Visible == true)
                    {
                        lstControl.Focus();
                    }
                    kpeArgs.Handled = true;
                }
                else if (kpeArgs.KeyChar == (char)Keys.Escape)
                {
                    lstControl.Visible = false;
                    kpeArgs.Handled = true;
                }
            };

            //listbox keyup event
            lstControl.KeyUp += (s, kueArgs) =>
            {
                if (kueArgs.KeyCode == Keys.Enter)
                {
                    string StrLS = GetLastString(txtControl.Text);
                    int LIOLS = txtControl.Text.LastIndexOf(StrLS);
                    string TempStr = txtControl.Text.Remove(LIOLS);
                    txtControl.Text = TempStr + ((ListBox)s).SelectedItem.ToString();
                    txtControl.Select(txtControl.Text.Length, 0);
                    txtControl.Focus();
                    lstControl.Hide();
                }
                else if (kueArgs.KeyCode == Keys.Escape)
                {
                    lstControl.Hide();
                    txtControl.Focus();
                }
            };

        }


        private static string GetLastString(string s)
        {
            string[] strArray = s.Split(' ');
            return strArray[strArray.Length - 1];
        }

    }
}
