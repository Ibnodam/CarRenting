using KursProject.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProject.Services
{
    public class CarService : BaseService<Cars>
    {
        public override bool Add(Cars obj)
        {
            bool IsAdded = false;
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "udp_Insert_Car";
                objSqlCommand.Parameters.AddWithValue("Id_Price", obj.Id_Price);
                objSqlCommand.Parameters.AddWithValue("Marka", obj.Marka);
                objSqlCommand.Parameters.AddWithValue("Model", obj.Model);
                objSqlCommand.Parameters.AddWithValue("Year_Realize", obj.Year_Realize);
                objSqlCommand.Parameters.AddWithValue("Reliability", obj.Reliability);
                objSqlCommand.Parameters.AddWithValue("Type_Body", obj.Type_Body);
                objSqlCommand.Parameters.AddWithValue("Number_Car", obj.Number_Car);
                objSqlconnection.Open();
                int addRows= objSqlCommand.ExecuteNonQuery();
                IsAdded = addRows>0;
     

            }
            catch (Exception ex) 
            {
                throw ex;
            }
            finally
            {
                objSqlconnection?.Close();
            }
            return IsAdded;

           
        }

        public override bool Delete(int id)
        {

            bool IsDeleted = false;
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "udp_Delete_Car";
                objSqlCommand.Parameters.AddWithValue("@Id_Car", id);
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

        public override List<Cars> GetAll()
        {
            List<Cars> list = new List<Cars>();
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "udp_Select_All_Cars";
                objSqlconnection.Open();
                var ObjSqlDataReader = objSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {
                    Cars objCar = null;
                    while (ObjSqlDataReader.Read())
                    {
                        objCar = new Cars();
                        objCar.Id_Car = ObjSqlDataReader.GetInt32(0);
                        objCar.Id_Price = ObjSqlDataReader.GetInt32(1);
                        objCar.Marka = ObjSqlDataReader.GetString(2);
                        objCar.Model = ObjSqlDataReader.GetString(3);
                        objCar.Year_Realize = ObjSqlDataReader.GetInt32(4);
                        objCar.Reliability = ObjSqlDataReader.GetBoolean(5);
                        objCar.Type_Body = ObjSqlDataReader.GetString(6);
                        objCar.Number_Car = ObjSqlDataReader.GetString(7);
                        list.Add(objCar);

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

        public override bool Update(Cars obj)
        {
            bool IsUpdate = false;
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "udp_Update_Car";
                objSqlCommand.Parameters.AddWithValue("@Id_Car", obj.Id_Car);
                objSqlCommand.Parameters.AddWithValue("@Id_Price", obj.Id_Price);
                objSqlCommand.Parameters.AddWithValue("@Marka", obj.Marka);
                objSqlCommand.Parameters.AddWithValue("@Model", obj.Model);
                objSqlCommand.Parameters.AddWithValue("@Year_Realize", obj.Year_Realize);
                objSqlCommand.Parameters.AddWithValue("@Reliability", obj.Reliability);
                objSqlCommand.Parameters.AddWithValue("@Type_Body", obj.Type_Body);
                objSqlCommand.Parameters.AddWithValue("@Number_Car", obj.Number_Car);
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
