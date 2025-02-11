using PetFolio.Comunication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;
public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "Bryan",
            Type = PetFolio.Comunication.Enums.PetType.Dog,
            Birthday = new DateTime(year: 2023, month: 01, day: 01)
        };
    }
}
