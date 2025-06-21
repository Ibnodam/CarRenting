using KursProject.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProject.Services
{
    public class TopCarService : BaseService<TopCars>
    {
        public override bool Add(TopCars obj)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<TopCars> GetAll()
        {
            List<TopCars> list = new List<TopCars>();
            try
            {
                objSqlCommand.Parameters.Clear();
                objSqlCommand.CommandText = "udp_Top_Cars";
                objSqlconnection.Open();
                var ObjSqlDataReader = objSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {
                    TopCars objPay = null;
                    while (ObjSqlDataReader.Read())
                    {
                        objPay = new TopCars();

                        objPay.IdCar = ObjSqlDataReader.GetInt32(0);
                        objPay.Marka = ObjSqlDataReader.GetString(1);
                        objPay.Model = ObjSqlDataReader.GetString(2);
                        objPay.RentalCount = ObjSqlDataReader.GetInt32(3);

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

        public override bool Update(TopCars obj)
        {
            throw new NotImplementedException();
        }
    }
}
