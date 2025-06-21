using KursProject.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProject.Services
{
    public class DiscountService : BaseService<Discount>
    {
        public override bool Add(Discount obj)
        {
            bool IsAdded = false;
          try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "udp_Insert_Discount";
                objSqlCommand.Parameters.AddWithValue("@Present", obj.Present);
                objSqlconnection.Open();
                int addRows = objSqlCommand.ExecuteNonQuery();
                IsAdded = addRows > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                objSqlconnection.Close();
            }
            return IsAdded;

            
        }

        public override bool Delete(int id)
        {
            bool IsDeleted = false;
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "udp_Delete_Discount";
                objSqlCommand.Parameters.AddWithValue("@Id_Discount", id);
                objSqlconnection.Open();
                int delRows = objSqlCommand.ExecuteNonQuery();
                IsDeleted = delRows > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                objSqlconnection.Close();
            }
            return IsDeleted;
        }

        public override List<Discount> GetAll()
        {
            List<Discount> list = new List<Discount>();
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "udp_Select_All_Discount";
                objSqlconnection.Open();
                var ObjSqlDataReader = objSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {
                    Discount objDiscount = null;
                    while (ObjSqlDataReader.Read())
                    {
                        objDiscount = new Discount();

                        objDiscount.Id_Discount= ObjSqlDataReader.GetInt32(0);
                        objDiscount.Present = ObjSqlDataReader.GetDecimal(1);

                        list.Add(objDiscount);

                    }
                }
                ObjSqlDataReader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                objSqlconnection.Close();
            }
            return list;
        }

        public override bool Update(Discount obj)
        {
            bool IsUpdate = false;
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "udp_Update_Discount";
                objSqlCommand.Parameters.AddWithValue("@Id_Discount", obj.Id_Discount);
                objSqlCommand.Parameters.AddWithValue("@Present", obj.Present);
                objSqlconnection.Open();
                int updateRows = objSqlCommand.ExecuteNonQuery();
                IsUpdate = updateRows > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                objSqlconnection.Close();
            }
            return IsUpdate;
        }
    }
}
