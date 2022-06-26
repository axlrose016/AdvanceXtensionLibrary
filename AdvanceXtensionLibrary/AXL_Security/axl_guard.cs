using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceXtensionLibrary.AXL_Security
{
    public class axl_guard
    {
        public static string generateSalt(int size)
        {
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }
        public static string HashSHA256(string value, string salt)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(value + salt);
            System.Security.Cryptography.SHA256Managed shaMan = new SHA256Managed();
            byte[] hash = shaMan.ComputeHash(bytes);
            return ByteArrayToHexString(hash);
        }

        public static string ByteArrayToHexString(byte[] ba)
        {
            StringBuilder sb = new StringBuilder(ba.Length * 2);
            foreach(byte b in ba)
            {
                sb.AppendFormat("{0:x2}", b);
            }
            return sb.ToString();
        }
        public static void login_axl_security(string connection_string, string tblName, string strUname, string strUid,string username, string password, out string outUsername, out int userId)
        {
            //tblName is the name of table in sql database where the username, salt and hash_code stored.
            //strUname is the name of username field in database.
            outUsername = string.Empty;
            //userId = new Guid("00000000-0000-0000-0000-000000000000");
            userId = -1;
            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();
                string query = $"SELECT salt,hash_code,{strUid} from {tblName} WHERE {strUname} = @username AND (is_deleted = 0 OR is_deleted IS NULL)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        string salt = dr.GetString(0).ToString();
                        string hash_code = dr.GetString(1).ToString();
                        byte[] passWithSalt = UTF8Encoding.UTF8.GetBytes(password + salt);
                        SHA256Managed shaMan = new SHA256Managed();
                        byte[] hashedPassword = shaMan.ComputeHash(passWithSalt);
                        string hashed_code = ByteArrayToHexString(hashedPassword);
                        if (hashed_code == hash_code)
                        {
                            outUsername = username;
                            userId = dr.GetInt32(2);
                        }
                    }
                }
                conn.Close();
            }
        }
    }
}
