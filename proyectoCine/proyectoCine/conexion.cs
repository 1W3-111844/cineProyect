using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proyectoCine
{
    public class conexion
    {
        string connectionString = @"Data Source=BANGHO;Initial Catalog = CINE_TPI; Integrated Security = True";
        SqlConnection connection;
        SqlCommand comando;
        SqlDataReader dr;
        string log;
        public string pLog
        {
            get { return log;}
            set { log = value; }
        }
        
        public SqlDataReader pDr
        {
            get { return dr; }
            set { dr = value; }
        }  
        public conexion()
        {
            connection = new SqlConnection(connectionString); 
        }
        public conexion(string stringConn)
        {
            connectionString = stringConn;
            connection = new SqlConnection(connectionString);
        }
        public void ConnectTo(string DataSource, string InitialCatalog)
        {
            connection.ConnectionString = @"Data Source=BANGHO;Initial Catalog = CINE_TPI; Integrated Security = True";
            try
            {
                connection.Open();
                MessageBox.Show("Conexion exitosa", "Conexión...");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public bool verificarConexion()
        {
            bool band = false;
            try
            {
                connection.Open();
                band = connection.State == ConnectionState.Open;
                connection.Close();
                
            }
            catch(Exception exc)
            {
                log = exc.ToString();
            }
            return band;

        }
        public DataTable consultaDT(string consulta)
        {
            comando = new SqlCommand(consulta,connection);
            connection.Open();
            SqlDataReader myReader = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(myReader);
            myReader.Close();
            connection.Close();
            return dt;
        }
        public string GetTableFields(string TableName)
        {
            if (connection.State == ConnectionState.Open)
            {
                DataTable CurTable = new DataTable("ConnectedTab");
                SqlDataAdapter DBAdapt;
                try
                {
                    DBAdapt = new SqlDataAdapter("SELECT * FROM " + TableName, connection);
                    DBAdapt.Fill(CurTable);
                }
                catch (Exception e)
                {
                    throw e;
                }
                string ResStr = "";
                int ColCount = CurTable.Columns.Count;
                for (int i = 0; i < ColCount; i++)
                {
                    string StrCon = ", ";
                    if (i == ColCount - 1)
                        StrCon = ";";
                    ResStr += CurTable.Columns[i].ColumnName + "[" +
                              CurTable.Columns[i].DataType.Name + "]" + StrCon;
                }
                return ResStr;
            }
            else return null;
        }

        public DataTable SQLRequest(string RequestStr)
        {
            if (connection.State == ConnectionState.Open)
            {
                DataTable ResultTab = new DataTable("SQLresult");
                SqlDataAdapter DBAdapt;
                try
                {
                    DBAdapt = new SqlDataAdapter(RequestStr, connection);
                    DBAdapt.Fill(ResultTab);
                }
                catch (Exception e)
                {
                    throw e;
                }
                return ResultTab;
            }
            else
                return null;
        }
        public void consultaDR(string consulta)
        {
            comando = new SqlCommand(consulta, connection);
            if(connection.State != ConnectionState.Open) connection.Open();
            dr = comando.ExecuteReader();

        }
        public void desconectar()
        {
            
                connection.Close();
        }
        public void insert_update(string consulta)
        {
            comando = new SqlCommand(consulta, connection);
            connection.Open();
            comando.ExecuteNonQuery();
            connection.Close();
        }

    }
}
