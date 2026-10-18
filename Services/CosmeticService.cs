
using dotnet.Models;
using dotnet.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace dotnet.Services
{
    public class CosmeticService : ICosmeticService
    {
         List<Cosmetic> _cosmetics{get;}
         int newId = 4; // Starting ID for new cosmetics

        public CosmeticService()
        {
            _cosmetics = new List<Cosmetic>(){
                new Cosmetic { Id = 1, Name = "Lipstick", Price = 19.99m },
                new Cosmetic { Id = 2, Name = "Foundation", Price = 29.99m },
                new Cosmetic { Id = 3, Name = "Mascara", Price = 14.99m }   
            };

        }

        public List<Cosmetic> GetAll()
        {
            return _cosmetics;
        }

        public Cosmetic? Get(int id)
        {
            return _cosmetics.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Cosmetic cosmetic)
        {
            cosmetic.Id = newId++;
            _cosmetics.Add(cosmetic);
        }

        public void Delete(int id)
        {
            var cosmetic = Get(id);
            if (cosmetic != null)
            {
                _cosmetics.Remove(cosmetic);
            }
        }

        public void Update(int id, Cosmetic cosmetic)
        {
            var existingCosmetic = Get(id);
            if (existingCosmetic != null)
            {
                existingCosmetic.Name = cosmetic.Name;
                existingCosmetic.Price = cosmetic.Price;
                // Update other properties as needed
            }
        }

        public int Count => _cosmetics.Count;
    }
}