using KursProject.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProject.Services
{
    public class RentingService : BaseService<Renting>
    {
        public override bool Add(Renting obj)
        {
            bool IsAdded = false;
          
            try
            {
                if (obj.Data_Return<=obj.Data_Rent)
                {
                    throw new ArgumentException("Неправильный ыыод даты");
                }
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "udp_Insert_Renting";
                objSqlCommand.Parameters.AddWithValue("@Id_Car", obj.Id_Car);
                objSqlCommand.Parameters.AddWithValue("@Id_Client", obj.Id_Client);
                objSqlCommand.Parameters.AddWithValue("@Data_Rent", obj.Data_Rent);
                objSqlCommand.Parameters.AddWithValue("@Data_Return", obj.Data_Return);
                objSqlCommand.Parameters.AddWithValue("@RentalDays", obj.RentalDays);
                objSqlCommand.Parameters.AddWithValue("@Id_Service1", obj.Id_Service1);
                objSqlCommand.Parameters.AddWithValue("@Id_Service2", obj.Id_Service2);
                objSqlCommand.Parameters.AddWithValue("@Id_Service3", obj.Id_Service3);


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
                objSqlCommand.CommandText = "udp_Delete_Renting";
                objSqlCommand.Parameters.AddWithValue("@Id_Renting", id);
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

        public override List<Renting> GetAll()
        {
            List<Renting> list = new List<Renting>();
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "udp_Select_All_Renting";
                objSqlconnection.Open();
                var ObjSqlDataReader = objSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {
                    Renting objRent = null;
                    while (ObjSqlDataReader.Read())
                    {
                        objRent = new Renting();
                        objRent.Id_Renting = ObjSqlDataReader.GetInt32(0);
                        objRent.Id_Client = ObjSqlDataReader.GetInt32(1);
                        objRent.Id_Car = ObjSqlDataReader.GetInt32(2);
                        objRent.Data_Rent   =ObjSqlDataReader.GetDateTime(3);
                        objRent.Data_Return =ObjSqlDataReader.GetDateTime(4);
                        objRent.Amount = ObjSqlDataReader.GetDecimal(5);
                        objRent.RentalDays = ObjSqlDataReader.GetInt32(6);
                        objRent.Id_Service1 = ObjSqlDataReader.GetInt32(7);
                        objRent.Id_Service2 = ObjSqlDataReader.GetInt32(8);
                        objRent.Id_Service3 = ObjSqlDataReader.GetInt32(9);
                        list.Add(objRent);
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

        public override bool Update(Renting obj)
        {
            if (obj.Data_Rent >= obj.Data_Return)
            {
                throw new ArgumentException("Неправильный ввод даты аренды илли возрата");
                
            }
            bool IsUpdate = false;
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "udp_Update_Renting";
                objSqlCommand.Parameters.AddWithValue("@Id_Renting", obj.Id_Renting);
                objSqlCommand.Parameters.AddWithValue("@Id_Client", obj.Id_Client);
                objSqlCommand.Parameters.AddWithValue("@Id_Car", obj.Id_Car);
                objSqlCommand.Parameters.AddWithValue("@Data_Rent", obj.Data_Rent);
                objSqlCommand.Parameters.AddWithValue("@Data_Return", obj.Data_Return);
                objSqlCommand.Parameters.AddWithValue("@RentalDays", obj.RentalDays);
                objSqlCommand.Parameters.AddWithValue("@Id_Service1", obj.Id_Service1);
                objSqlCommand.Parameters.AddWithValue("@Id_Service2", obj.Id_Service2);
                objSqlCommand.Parameters.AddWithValue("@Id_Service3", obj.Id_Service3);
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
