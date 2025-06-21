using KursProject.Model;
using KursProject.View;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProject.Services
{
    public class ClientService : BaseService<Client>
    {

        public ClientService():base()
            { 
        }


        public override bool Add(Client obj)
        {bool IsAdded = false;
            if (obj.Experience<0)
                throw new ArgumentException("Без стажа не положено арендовать авто");
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "udp_Insert_Client";
                objSqlCommand.Parameters.AddWithValue("@FIO",obj.FIO);
                objSqlCommand.Parameters.AddWithValue("@Email", obj.Email);
                objSqlCommand.Parameters.AddWithValue("@Experience", obj.Experience);
                objSqlCommand.Parameters.AddWithValue("@Validity_Period", obj.Validity_Period);
                objSqlCommand.Parameters.AddWithValue("@BirthDate", obj.BirthDate);
                objSqlCommand.Parameters.AddWithValue("@countCar", obj.Count_Car);
                objSqlCommand.Parameters.AddWithValue("@License", obj.Number_License);
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
                objSqlCommand.CommandText = "udp_Delete_Client";
                objSqlCommand.Parameters.AddWithValue("@Id_Client", id);
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

        public override List<Client> GetAll()
        {
            List<Client> list = new List<Client>();
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "udp_SelectAll";
                objSqlconnection.Open();
                var ObjSqlDataReader = objSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {
                    Client objClient = null;
                    while (ObjSqlDataReader.Read())
                    {
                        objClient = new Client();
                        objClient.Id_Client = ObjSqlDataReader.GetInt32(0);
                        objClient.FIO = ObjSqlDataReader.GetString(1);
                        objClient.Email = ObjSqlDataReader.GetString(2);
                        objClient.Experience = ObjSqlDataReader.GetInt32(3);
                        objClient.Validity_Period = ObjSqlDataReader.GetInt32(4);
                        objClient.BirthDate = ObjSqlDataReader.GetDateTime(5);
                        objClient.Status = ObjSqlDataReader.IsDBNull(6) ? false : ObjSqlDataReader.GetBoolean(6);
                        objClient.Count_Car = ObjSqlDataReader.GetInt32(7);
                        objClient.Number_License = ObjSqlDataReader.GetString(8);
                        list.Add(objClient);

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
        
        public override bool Update(Client obj)
        {
            bool IsUpdate = false;
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "udp_Update_Client";
                objSqlCommand.Parameters.AddWithValue("@Id_Client", obj.Id_Client);
                objSqlCommand.Parameters.AddWithValue("@FIO", obj.FIO);
                objSqlCommand.Parameters.AddWithValue("@Email", obj.Email);
                objSqlCommand.Parameters.AddWithValue("@Experience", obj.Experience);
                objSqlCommand.Parameters.AddWithValue("@Validity_Period", obj.Validity_Period);
                objSqlCommand.Parameters.AddWithValue("@BirthDate", obj.BirthDate);
                objSqlCommand.Parameters.AddWithValue("@Count_Car", obj.Count_Car);
                objSqlCommand.Parameters.AddWithValue("@Number_License", obj.Number_License);


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
