
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

namespace proyectoCine
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
          
            bool Connected = false;
            Cursor = Cursors.WaitCursor;
           
            try
            {
                UserReq.desconectar();
                UserReq.ConnectTo(tbDatSource.Text, tbInitCat.Text);
                Connected = true;
            }
            catch (Exception e1)
            {
                MessageBox.Show(this, e1.Message, "Connection Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Connected = false;
            }
            if (Connected)
            {
             
                tbRequest.Enabled = true;
                btnRequest.Enabled = true;
                datGridSQLResult.Enabled = true;
                datGridDBTables.Enabled = true;
            }
            else
            { 
                tbRequest.Enabled = false;
                btnRequest.Enabled = false;
                datGridSQLResult.Enabled = false;
                datGridDBTables.Enabled = false;
            }
            Cursor = Cursors.Arrow;
            try
            {
                StructTab.Clear();
                RequestTab.Clear();
            }
            catch
            {
            }
        }

        private conexion UserReq;
        private DataTable RequestTab;  
        private DataTable StructTab;    
        
        private string LastTabName;

        private void MainForm_Load(object sender, EventArgs e)
        {
            UserReq = new conexion();   
            StructTab = new DataTable("TabFields");
            DataColumn NewDatCol = new DataColumn("Tables", Type.GetType("System.String"));
            NewDatCol.AllowDBNull = false;
            NewDatCol.Unique = true;
            StructTab.Columns.Add(NewDatCol);
            NewDatCol = new DataColumn("Fields", Type.GetType("System.String"));
            NewDatCol.AllowDBNull = false;
            NewDatCol.DefaultValue = "none;";
            StructTab.Columns.Add(NewDatCol);
            datGridDBTables.DataSource = StructTab;

            datGridDBTables.ReadOnly = false;
            datGridSQLResult.DataSource = RequestTab;

            //conecta el controlador de eventos de cambio de fila a la tabla
            
            StructTab.RowChanged += new DataRowChangeEventHandler(StructTab_OnRowChanged);
        }

        private void StructTab_OnRowChanged(object sender, DataRowChangeEventArgs e)
        {
            try
            {
                if (LastTabName != (string)e.Row["Tables"])
                {
                    LastTabName = (string)e.Row["Tables"];
                    string Fields = UserReq.GetTableFields(LastTabName);
                    e.Row["Fields"] = Fields;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                RequestTab = UserReq.SQLRequest(tbRequest.Text);
                datGridSQLResult.DataSource = RequestTab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor = Cursors.Arrow;
        }

        private void DatGridDBTables_MouseUp(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo HitInfo = datGridDBTables.HitTest(e.X, e.Y);//HitTest(e.X, e.Y);
            if ((HitInfo.RowIndex >= 0) && (HitInfo.RowIndex < StructTab.Rows.Count))
            {
                tbRequest.Text = "SELECT * FROM " + (string)StructTab.Rows[HitInfo.RowIndex][
                "Tables"];
                btnRequest_Click(this, null);
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
          

        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
          

        }
    }
}
