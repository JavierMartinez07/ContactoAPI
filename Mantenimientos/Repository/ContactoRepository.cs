using Mantenimiento.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mantenimientos.Repository
{
    public class ContactoRepository: BaseRepository
    {
        public static List<Contacto> GetContactos()
        {
            try
            {
                string query = "select * from Contacto";
                var result =  Query<Contacto>(query);
                return result;
            }
            catch (Exception e)
            {
                throw e;
                
            }
        }
        
       public static void DeleteContactoById(int Id)
        {
            try
            {
                string query = "delete from Contacto where Id = @Id";
                var result =  Query<Contacto>(query, new { Id });
            }
            catch (Exception e)
            {
                throw e;
            }
        }        


       public static void InsertContacto(Contacto model)
        {
            try
            {
                string query = @"
                insert into Contacto(Nombre, Apellido, Email, Telefono) 
                values (@Nombre, @Apellido, @Email, @Telefono) ";

                var result =  Query<Contacto>(query, model);
            }
            catch (Exception e)
            {
                throw e;
            }
        }



    }
}
