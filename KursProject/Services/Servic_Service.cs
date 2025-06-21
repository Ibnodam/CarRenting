using KursProject.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProject.Services
{
    public class Servic_Service : BaseService<Servic>
    {
        public override bool Add(Servic obj)
        {
            bool IsAdded = false;
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "udp_Insert_Servic";
                objSqlCommand.Parameters.AddWithValue("@Name_Service", obj.Name_Service);
                objSqlCommand.Parameters.AddWithValue("@Price_Service", obj.@Price_Service);
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
                objSqlCommand.CommandText = "udp_Delete_Service";
                objSqlCommand.Parameters.AddWithValue("@Id_Service",id );
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

        public override List<Servic> GetAll()
        {
            List<Servic> list = new List<Servic>();
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "udp_Select_All_Services";
                objSqlconnection.Open();
                var ObjSqlDataReader = objSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {
                    Servic objService = null;
                    while (ObjSqlDataReader.Read())
                    {
                        objService = new Servic();

                        objService.Id_Service = ObjSqlDataReader.GetInt32(0);
                        objService.Name_Service = ObjSqlDataReader.GetString(1);
                        objService.Price_Service = ObjSqlDataReader.GetDecimal(2);

                        list.Add(objService);

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

        public override bool Update(Servic obj)
        {
            bool IsUpdate = false;
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "udp_Update_Services";
                objSqlCommand.Parameters.AddWithValue("@Id_Service", obj.Id_Service);
                objSqlCommand.Parameters.AddWithValue("@Name_Service", obj.Name_Service);
                objSqlCommand.Parameters.AddWithValue("@Price_Service", obj.Price_Service);

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
