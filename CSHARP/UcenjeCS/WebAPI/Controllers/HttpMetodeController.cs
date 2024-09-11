using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HttpMetodeController : ControllerBase
    {

        // ovdje počinje ruta
        [HttpGet]
        public string Pozdravi()
        {
            return "Hello world";
        }

        // ovdje završava ruta





        // ovdje počinje ruta
        [HttpGet]
        [Route("Pozdravi")]
        public string Pozdravi(string ime)
        {
            return "Hello " + ime;
        }


        // ovdje završava ruta

        // DZ: Kreirajte rutu naziva Zbroj koja prima dva cijela broja i vraća nazad njihov zbroj


        // ovdje počinje ruta
        [HttpGet]
        [Route("Hello")]
        public IActionResult Pozdravi(int id, string ime)
        {
            return Ok(new { id = id, ime = ime });
        }

        // ovdje završava ruta



        // ovdje počinje ruta

        [HttpPost]
        public IActionResult Post()
        {
            return BadRequest(new { greska = true, poruka = "Nešto ne valja" });
        }

        // ovdje završava ruta



        // ovdje počinje ruta
        [HttpPut]
        public IActionResult Put(Osoba osoba)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { greska = true, poruka = "Nije dobar parametar" });
            }
            osoba.Prezime = "g. " + osoba.Prezime;
            return StatusCode(StatusCodes.Status206PartialContent, osoba);
        }
        // ovdje završava ruta



        // ovdje počinje ruta

        [HttpDelete]
        public IActionResult Delete(int id)
        {

            return NotFound(new { id = id, poruka = "Ne mogu pronaći", greska = true });

        }

        // ovdje završava ruta

    }
}
