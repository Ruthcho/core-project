using dotnet.Models;
using System.Collections.Generic;
using System.Linq;
namespace dotnet.Interfaces{
    public interface ICosmeticService{
         List<Cosmetic> GetAll();

        Cosmetic? Get(int id);

        void Add(Cosmetic cosmetic );

        void Delete(int id);

        void Update(int id, Cosmetic cosmetic);

        int Count { get; }
    }
}