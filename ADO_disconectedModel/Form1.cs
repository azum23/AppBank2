using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_disconectedModel
{
    public partial class Form1 : Form
    {
        DataTable customersTable, creditsTable, paymentsTable;

        public Form1()
        {
            InitializeComponent();
            CreateCustomers();
            CreateCredits();
            CreatePayments();
            CreateDB();


        }

        private void CreateDB()
        {

        }

        private void CreatePayments()
        {
            creditsTable = new DataTable();
        }



        private void CreateCredits()
        {
            paymentsTable = new DataTable();

            DataColumn dataColumn = new DataColumn();
            dataColumn.ColumnName = "Id";
            dataColumn.DataType = typeof(Guid);
            dataColumn.Caption = "Credit Id";
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = false;
            creditsTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("CustomerId", typeof(Guid));
            dataColumn.AllowDBNull = false;
            dataColumn.Caption = "Customer Id";
            dataColumn.ReadOnly = true;
            creditsTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("Amount", typeof(decimal));
            dataColumn.AllowDBNull = false;
            dataColumn.Caption = "Credit Amount";
            dataColumn.ReadOnly = false;
            creditsTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("Balance", typeof(decimal));
            dataColumn.AllowDBNull = false;
            dataColumn.Caption = "Credit Balance";
            dataColumn.ReadOnly = false;
            creditsTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn("OpenDate", typeof(DateTime));
            dataColumn.AllowDBNull = false;
            dataColumn.Caption = "Credit Open Date";
            dataColumn.ReadOnly = false;
            creditsTable.Columns.Add(dataColumn);
        }

        private void CreateCustomers()
        {
            DataColumn idColumn = new DataColumn();
            idColumn.ColumnName = "Id";
            idColumn.DataType = typeof(Guid);
            idColumn.Caption = "Customer Id";
            idColumn.AllowDBNull = false;
            idColumn.ReadOnly = true;
            idColumn.Unique = true;
            idColumn.AutoIncrement = false;

            DataColumn nameColumn = new DataColumn("Name", typeof(string));
            nameColumn.AllowDBNull = false;
            nameColumn.Caption = "Customer Name";

            DataColumn UQNumColumn = new DataColumn("UQNum", typeof(string));
            UQNumColumn.AllowDBNull = false;
            UQNumColumn.Caption = "Customer Inn";

            DataColumn phoneColumn = new DataColumn("Phone", typeof(string));
            UQNumColumn.AllowDBNull = true;
            UQNumColumn.Caption = "Customer Phone";

            customersTable = new DataTable("Customers");
            customersTable.Columns.AddRange(new[] { idColumn, nameColumn, UQNumColumn, phoneColumn });

            DataRow row = customersTable.NewRow();
            row["Id"] = Guid.NewGuid();
            row["Name"] = "Alex Znamensky";
            row["UQNum"] = "2308-1983";
            row["Phone"] = "9159567333";
            customersTable.Rows.Add(row);
            customersTable.AcceptChanges();
        }

        private void btn_LinkData_Click(object sender, EventArgs e)
        {
            dgv_Customers.DataSource = customersTable;
            dgv_Credits.DataSource = creditsTable;
        }

        private void btn_GetCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"DataTable row count: {customersTable.Rows.Count}", "Info", MessageBoxButtons.OK);
        }

        private void btn_AddRow_Click(object sender, EventArgs e)
        {
            DataRow row = customersTable.NewRow();
            row["Id"] = Guid.NewGuid();
            row["Name"] = "";
            row["UQNum"] = "";
            row["Phone"] = null;
            customersTable.Rows.Add(row);
        }

        private void btn_RowState_Click(object sender, EventArgs e)
        {
            string s = string.Empty;
            foreach (DataRow row in customersTable.Rows)
            {
                s += row.RowState.ToString() + Environment.NewLine;
            }
            MessageBox.Show(s);
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            customersTable.AcceptChanges();
        }

        private void btn_Reject_Click(object sender, EventArgs e)
        {
            customersTable.RejectChanges();
        }
    }
}
