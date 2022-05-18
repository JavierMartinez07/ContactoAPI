using Mantenimiento.Models;
using Mantenimientos.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mantenimientos.Logic
{
    public class ContactoLogic
    {
        public static ResponseModel<Contacto> GetContatos()
        {
            var response = new ResponseModel<Contacto>();
            try
            {
                var result = ContactoRepository.GetContactos();
                response.Records.AddRange(result);
            }
            catch (Exception e)
            {
                response.OK = false;
                response.Message.Add(e.Message);
                response.Message.Add(e.StackTrace);

            }
            return response;
        }        
        
        public static ResponseModel<Contacto> DeleteContactoById(int Id)
        {
            var response = new ResponseModel<Contacto>();
            try
            {
                ContactoRepository.DeleteContactoById(Id);
            }
            catch (Exception e)
            {
                response.OK = false;
                response.Message.Add(e.Message);
                response.Message.Add(e.StackTrace);

            }
            return response;
        }        
        public static ResponseModel<Contacto> InsertContacto(Contacto model)
        {
            var response = new ResponseModel<Contacto>();
            try
            {
                 ContactoRepository.InsertContacto(model);
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
