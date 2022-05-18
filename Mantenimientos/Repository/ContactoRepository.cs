using Mantenimiento.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mantenimientos.Repository
{
    public class ContactoRepository: BaseRepository
    {
        public ResponseModel<Contacto> GetContactos()
        {
            var response = new ResponseModel<Contacto>();
            try
            {
                string query = "select * from contacto";
                var resuls =  Query<Contacto>(query);
                response.Records.AddRange(resuls);
            }
            catch (Exception e)
            {
                response.OK = false;
                response.Message.Add(e.Message);
                response.Message.Add(e.StackTrace);

                
            }
            return response;
        }
    }
}
