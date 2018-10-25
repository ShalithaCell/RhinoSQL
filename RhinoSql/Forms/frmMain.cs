using MaterialSkin;
using MaterialSkin.Controls;
using Poral.Model;
using Prtal.BIZ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RhinoSql.Forms
{
    public partial class frmMain : MaterialForm
    {
        public frmMain()
        {
            InitializeComponent();
            
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }



        #region User define Methods (Author : Shalitha Senanayaka)

        //ListBox lstbox = new ListBox();

        private void IntelliSenseDo(DataTable dt, string keyWord)
        {

            txtbxQuery.KeyUp += (s, e) =>
            {
                List<string> list = dt.AsEnumerable()
                           .Select(r => r.Field<string>(keyWord))
                           .ToList();
                clsIntelliSense.AutoCompleteTextBox(txtbxQuery, listBox1, list, e);




            };


        }
        private void BindComboValues(string DB)
        {
            DataTable dt = clsSystem.getSqlDataTypes(DB);

            DataGridViewComboBoxColumn dcombo;
            dcombo = (DataGridViewComboBoxColumn)dgvParams.Columns["Type"];
            dcombo.DataSource = dt;
            dcombo.DisplayMember = "MSSQL";
            dcombo.ValueMember = "ID";
            
        }
         
        private void textBoxPlaceHolder()
        {
            if (txtProcedureName.Text != string.Empty)
                return;

            txtProcedureName.ForeColor = Color.FromArgb(176, 171, 171);
            txtProcedureName.Text = "Enter procedure name";
        }

        private void GetParameterList()
        {
            int counter = 0;

            dgvParams.AllowUserToAddRows = false;

            Tuple<string[], string[], string[], bool[]> paramListTuple = new Tuple<string[], string[], string[], bool[]> { };

            foreach (DataGridViewRow row in dgvParams.Rows)
            {
                if (row.Cells[0].Value.ToString() != string.Empty && row.Cells[1].Value.ToString() != string.Empty)
                {
                    paramListTuple.Item1[counter] = row.Cells[0].Value.ToString();


                }

                counter++;
            }

            dgvParams.AllowUserToAddRows = true;


        }

        private void CreatingProcedure()
        {
            txtView.Text = string.Empty;

            //Variables
            string footer = string.Empty;

            if (txtProcedureName.Text != string.Empty && txtProcedureName.Text == "Enter procedure name")
                return;

            //CheckIdErrorControlled
            if (chkBoxMSSQL.Checked && chkErrorHandle.Checked)
            {
                footer = QueryTemplates.createMSSQLcatchPart(txtProcedureName.Text);
            }

            //Creating 
            txtView.Text = QueryTemplates.createMSSQLheader(txtProcedureName.Text) + Environment.NewLine +
                                "(" + Environment.NewLine + Environment.NewLine +
                                ")" + Environment.NewLine
                                + "AS" + Environment.NewLine
                                + "BEGIN" + Environment.NewLine + Environment.NewLine
                                + "END" + Environment.NewLine
                                + footer; 
                                

        }

        private Tuple<bool,int> checkParameterIsAlreadyPlaced(string paramName)
        {
            dgvParams.AllowUserToAddRows = false;
            if (dgvParams.Rows.Count == 0)
            {
                dgvParams.AllowUserToAddRows = true;
                return Tuple.Create(false, 0);
            }
                

            foreach (DataGridViewRow row in dgvParams.Rows)
            {
                if (row.Cells[0].Value.ToString().Contains("result"))
                {
                    dgvParams.AllowUserToAddRows = true;
                    return Tuple.Create(true, row.Index);
                }
                    
                    
            }
            dgvParams.AllowUserToAddRows = true;
            return Tuple.Create(false, 0);

        }

        #endregion


        private void chkBoxMSSQL_CheckedChanged(object sender, EventArgs e)
        {
            chkBoxMySQl.Checked = !chkBoxMSSQL.Checked ;

        }

        private void chkBoxMySQl_CheckedChanged(object sender, EventArgs e)
        {

            chkBoxMSSQL.Checked = !chkBoxMySQl.Checked;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //styling
            dgvParams.BorderStyle = BorderStyle.FixedSingle;
            dgvParams.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvParams.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvParams.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvParams.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvParams.BackgroundColor = Color.FromArgb(51, 51, 51);

            dgvParams.EnableHeadersVisualStyles = false;
            dgvParams.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvParams.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvParams.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            txtbxQuery.BackColor = Color.FromArgb(78, 78, 78);

            if (chkBoxMSSQL.Checked)
                BindComboValues("MSSQL");
            else
                BindComboValues("MYSQL");

            DataTable dt = clsSystem.getSqlDataTypes("MSSQL");
            IntelliSenseDo(dt, "MSSQL");

            textBoxPlaceHolder();

            CreatingProcedure();
        }

        private void txtProcedureName_Enter(object sender, EventArgs e)
        {
            if (txtProcedureName.Text != string.Empty && txtProcedureName.Text == "Enter procedure name")
            {
                txtProcedureName.Text = string.Empty;
                txtProcedureName.ForeColor = Color.FromArgb(93, 92, 92);
            }
            
        }

        private void txtProcedureName_Leave(object sender, EventArgs e)
        {
            textBoxPlaceHolder();
            CreatingProcedure();
        }

        private void txtProcedureName_TextChanged(object sender, EventArgs e)
        {
            CreatingProcedure();
        }

        private void chkErrorHandle_CheckedChanged(object sender, EventArgs e)
        {
            if (! chkErrorHandle.Checked)
                if (checkParameterIsAlreadyPlaced("result").Item1)
                {
                    dgvParams.Rows.RemoveAt(checkParameterIsAlreadyPlaced("result").Item2);
                    dgvParams.Refresh();
                    CreatingProcedure();
                    return;
                }

            if (!checkParameterIsAlreadyPlaced("result").Item1)
            {
                this.dgvParams.Rows.Add("result", "INT", "0", true);
                dgvParams.Rows[checkParameterIsAlreadyPlaced("result").Item2].ReadOnly = true;
            }
            

            dgvParams.Refresh();

            CreatingProcedure();

        }

        private void dgvParams_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            return;
        }

        

        private void dgvParams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var x = "s";
        }

        private void dgvParams_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var x = "s";
        }
    }
}
