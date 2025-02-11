using PetFolio.Comunication.Requests;
using PetFolio.Comunication.Responses;

namespace Petfolio.Application.UseCases.Pets.Register;
public class RegisterPetUseCase
{
    public ResponseRegisteredPetJson Execute(RequestPetJson request)
    {
        return new ResponseRegisteredPetJson
        {
            Id = 7,
            Name = request.Name
        };
    }
}
