using API.Barramento.Application.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace API.Barramento.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropostaController : ControllerBase
    {
        public PropostaController()
        {

        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Post(PropostaBaseDto propostaDto)
        {
            try
            {

                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }

        }
    }
}
