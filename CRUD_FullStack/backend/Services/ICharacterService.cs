
using Backend.Models.Character;

namespace Backend.Services
{
    public interface ICharacterService
    {
        Task<IEnumerable<CharacterResponse>> GetAllCharacters();
        Task<CharacterResponse> GetCharacter(Guid id);
        Task<CharacterResponse> AddCharacter(CharacterRequest request);
        Task<CharacterResponse> UpdateCharacter(Guid id, CharacterRequest request);
        Task<CharacterResponse> DeleteCharacter(Guid id);
    }
}