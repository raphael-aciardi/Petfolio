using PetFolio.Comunication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetAll;
public class GetAllPetsUseCase
{
    public ReponseAllPetsJson Execute()
    {
        return new ReponseAllPetsJson
        {
            Pets = new List<ResponseShortPetJson>
            {
                new ResponseShortPetJson
                {
                    Id = 1,
                    Name = "Charlie",
                    Type = PetFolio.Comunication.Enums.PetType.Dog,
                }
            }
        };
        }

}
