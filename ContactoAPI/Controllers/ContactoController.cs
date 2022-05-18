using Mantenimiento.Models;
using Mantenimientos.Logic;
using Microsoft.AspNetCore.Mvc;

namespace ContactoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactoController: ControllerBase
    {
        public ResponseModel<Contacto> GetContatos()
        {
            return ContactoLogic.GetContatos();
        }        
        
        public ResponseModel<Contacto> DeleteContactoById([FromBody] int Id)
        {
            return ContactoLogic.DeleteContactoById(Id);
        }        
        
        public ResponseModel<Contacto> GetContatos(Contacto model)
        {
            return ContactoLogic.InsertContacto(model);
        }
    }
}
