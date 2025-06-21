using KursProject.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProject.Services
{
    public class PriceService : BaseService<PriceList>
    {
        public PriceService() : base()
        {
        }


        public override bool Add(PriceList obj)
        {
            bool IsAdded = false;
            if (obj.Price <1000)
                throw new ArgumentException("Минимальная сумма для оплаты 1000 рублей");
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "udp_Insert_Price";
                objSqlCommand.Parameters.AddWithValue("@Price", obj.Price);
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
                objSqlCommand.CommandText = "udp_Delete_Price";
                objSqlCommand.Parameters.AddWithValue("@Id_Price", id);
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

        public override List<PriceList> GetAll()
        {
            List<PriceList> list = new List<PriceList>();
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "udp_SelectAllPrice";
                objSqlconnection.Open();
                var ObjSqlDataReader = objSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {
                    PriceList objPrice = null;
                    while (ObjSqlDataReader.Read())
                    {
                        objPrice = new PriceList();

                        objPrice.Id_Price = ObjSqlDataReader.GetInt32(0);
                        objPrice.Price = ObjSqlDataReader.GetDecimal(1);
                       
                        list.Add(objPrice);

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

        public override bool Update(PriceList obj)
        {
            bool IsUpdate = false;
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "udp_Update_Price";
                objSqlCommand.Parameters.AddWithValue("@Id_Price", obj.Id_Price);
                objSqlCommand.Parameters.AddWithValue("@Price", obj.Price);
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
