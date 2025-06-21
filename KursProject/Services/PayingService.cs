using KursProject.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProject.Services
{
    public class PayingService : BaseService<Paying>
    {
        public override bool Add(Paying obj)
        {
            bool IsAdded = false;
           
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "udp_Add_Paying";
                objSqlCommand.Parameters.AddWithValue("@Id_Renting", obj.Id_Renting);
                objSqlCommand.Parameters.AddWithValue("@DatePayment", obj.Date_Payment);
                objSqlCommand.Parameters.AddWithValue("@Type_Pay", obj.Type_Pay);
                objSqlCommand.Parameters.AddWithValue("@Payment", obj.Payment);

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
                objSqlCommand.CommandText = "udp_Delete_Paying";
                objSqlCommand.Parameters.AddWithValue("@Id_Paying", id);
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

        public override List<Paying> GetAll()
        {
            List<Paying> list = new List<Paying>();
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "udp_select_All_Payments";
                objSqlconnection.Open();
                var ObjSqlDataReader = objSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {
                    Paying objPay = null;
                    while (ObjSqlDataReader.Read())
                    {
                        objPay = new Paying();

                        objPay.Id_Paying = ObjSqlDataReader.GetInt32(0);
                        objPay.Id_Renting = ObjSqlDataReader.GetInt32(1);
                        objPay.Date_Payment = ObjSqlDataReader.GetDateTime(2);
                        objPay.Type_Pay = ObjSqlDataReader.GetString(3);
                        objPay.Payment = ObjSqlDataReader.GetDecimal(4);

                        list.Add(objPay);

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

        public override bool Update(Paying obj)
        {
            throw new NotImplementedException();
        }
    }
}
