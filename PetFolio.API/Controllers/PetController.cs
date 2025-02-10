using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pets.Register;
using PetFolio.Comunication.Requests;
using PetFolio.Comunication.Responses;

namespace PetFolio.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterPetJson), StatusCodes.Status201Created)]
    public IActionResult Register([FromBody] RequestPetJson request)
    {
        var response = new RegisterPetUseCase().Execute(request);
        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute]int id, [FromBody] RequestPetJson request)
    {
        return NoContent();
    }



}
