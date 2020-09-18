using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class DBHelper
{
    private static string strconn = "Data Source=.;Initial Catalog=StudentsDB;Persist Security Info=True;User ID=sa;Password=123456";
    private static SqlCommand cmd = null;
    private static SqlDataAdapter adp = null;
    private static SqlConnection conn = null;

    public static int OperationSQL(string sql)
    {
        int nRet = -1;
        try
        {
            conn = new SqlConnection(strconn);
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            nRet = cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            ShowErrorMessage(ex.Message);
        }
        return nRet;
    }

    public static DataTable Select(string sql)
    {
        DataTable dt = new DataTable();
        try
        {
            conn = new SqlConnection(strconn);
            conn.Open();
            adp = new SqlDataAdapter(sql, conn);
            adp.Fill(dt);
        }
        catch (Exception ex)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            ShowErrorMessage(ex.Message);
        }
        return dt;
    }

    private static void ShowErrorMessage(string error)
    {
        MessageBox.Show(error, "提示！", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

