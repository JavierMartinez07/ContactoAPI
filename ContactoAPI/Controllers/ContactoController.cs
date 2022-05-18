using Mantenimiento.Models;
using Mantenimientos.Logic;
using Microsoft.AspNetCore.Mvc;

namespace ContactoAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ContactoController: ControllerBase
    {
        [HttpGet]
        public ResponseModel<Contacto> GetContatos()
        {
            return ContactoLogic.GetContatos();
        }

        [HttpDelete]
        public ResponseModel<Contacto> DeleteContactoById([FromBody] int Id)
        {
            return ContactoLogic.DeleteContactoById(Id);
        }

        [HttpPost]
        public ResponseModel<Contacto> InsertContacto(Contacto model)
        {
            return ContactoLogic.InsertContacto(model);
        }        
        
        [HttpPost]
        public ResponseModel<Contacto> VerifyEmailContacto(Contacto model)
        {
            return ContactoLogic.VerifyEmailContacto(model);
        }
    }
}
