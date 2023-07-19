using AutoMapper;
using Backend.Data;
using Backend.Models.Character;
using Microsoft.EntityFrameworkCore;

namespace Backend.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly KimetsuNoYaibaContext _context;
        private readonly IMapper _mapper;
        public CharacterService(KimetsuNoYaibaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CharacterResponse> AddCharacter(CharacterRequest request)
        {
            var characterRequest = _mapper.Map<Character>(request);
            await _context.AddAsync(characterRequest);
            await _context.SaveChangesAsync();

            var response = _mapper.Map<CharacterResponse>(characterRequest);
            return response;
        }

        public async Task<CharacterResponse> DeleteCharacter(Guid id)
        {
            var character = _context.Characters.FirstOrDefault(c => c.Id == id);
            if (character == null)
            {
                throw new Exception("Character not found");
            }

            _context.Characters.Remove(character);
            _context.SaveChanges();

            var response = _mapper.Map<CharacterResponse>(character);
            return response;
        }

        public async Task<IEnumerable<CharacterResponse>> GetAllCharacters()
        {
            var characters = await _context.Characters.ToListAsync();
            var response = _mapper.Map<IEnumerable<CharacterResponse>>(characters);
            return response;
        }

        public async Task<CharacterResponse> GetCharacter(Guid id)
        {
            var character = _context.Characters.FirstOrDefault(c => c.Id == id);
            if (character == null)
            {
                throw new Exception("Character not found");
            }

            var response = _mapper.Map<CharacterResponse>(character);
            return response;
        }

        public async Task<CharacterResponse> UpdateCharacter(Guid id, CharacterRequest request)
        {
            var character = _context.Characters.FirstOrDefault(c => c.Id == id);
            if (character == null)
            {
                throw new Exception("Character not found");
            }

            character.Name = request.Name;
            character.Gender = request.Gender;
            character.BirthDay = request.BirthDay;
            character.Height = request.Height;
            character.Weight = request.Weight;
            character.Image = request.Image;

            _context.SaveChanges();

            var response = _mapper.Map<CharacterResponse>(character);
            return response;
        }
    }
}