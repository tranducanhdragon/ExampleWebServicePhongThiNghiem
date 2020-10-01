using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Webservice
{
    /// <summary>
    /// Summary description for WebServicePhongThiNghiem
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServicePhongThiNghiem : System.Web.Services.WebService
    {
        SqlConnection conn = new SqlConnection();
        public string ConnString = "data source=LAPTOP-041JLBKQ\\SQLEXPRESS;initial catalog=PhongThiNghiem;integrated security=True";
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        //Liệt kê các thiết bị theo mã danh mục
        [WebMethod]
        public DataSet GetThietBiByDM()
        {
            conn.ConnectionString = ConnString;
            SqlCommand cmd = new SqlCommand("select MaDMThietBi, TenThietBi from ThietBi group by MaDMThietBi, TenThietBi", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "ThietBiTheoDM");
            conn.Close();
            return (ds);
        }
        //Liệt kê các thiết bị sắp tới hạn trả 5 ngày
        [WebMethod]
        public DataSet GetThietBiToiHan5Ngay()
        {
            conn.ConnectionString = ConnString;
            SqlCommand cmd = new SqlCommand("select * from ThietBi, MuonTra Where ThietBi.MaThietBi = MuonTra.MaThietBi and DATEDIFF(day, ThoiGianTra, GetDate()) < 5", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "ThietBiToiHan");
            conn.Close();
            return (ds);
        }
        //Liệt kê các thiết bị sắp tới hạn trả 5 ngày
        [WebMethod]
        public DataSet GetThietBiHetHan()
        {
            conn.ConnectionString = ConnString;
            SqlCommand cmd = new SqlCommand("select * from ThietBi, MuonTra Where ThietBi.MaThietBi = MuonTra.MaThietBi and DATEDIFF(day, ThoiGianTra, GetDate()) < 0", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "ThietBiHetHan");
            conn.Close();
            return (ds);
        }
        //Liệt kê bài thí nghiệm theo ID giáo viên
        [WebMethod]
        public DataSet GetBaiTNByIdGiaoVien(int idgv)
        {
            conn.ConnectionString = ConnString;
            SqlCommand cmd = new SqlCommand("select TenBaiTN from GiaoVien where MaGiaoVien = @idgv", conn);           
            SqlParameter para = new SqlParameter("@idgv", idgv);
            cmd.Parameters.Add(para);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds,"BaiTN");
            conn.Close();
            return (ds);
        }
    }
}
