using Core.Models;
using Core.Services.Contracts;
using Theatre.Models;

namespace Theatre.Services
{
    internal class ZalManager : ICrudService , IPrintService
    {
        private Zal[] _zal = new Zal[10];
        private int _currentIndex = 0;

        public void Add(Entity entity)
        {
         if (_currentIndex > _zal.Length)
            {
                Console.WriteLine("There are only 10 Halls enable");
                return;
            }
            _zal[_currentIndex] = (Zal)entity;
            Console.WriteLine("Hall succesfuly added");
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < _zal.Length; i++)
            {
                if (_zal[i] == null)
                    continue;

                if (_zal[i].Id == id)
                {
                    return _zal[i];
                }
            }

            Console.WriteLine("Hall not found");
            return null;
        }

        public Entity[] GetAll()
        {
            return _zal;
        }

        public void Print()
        {
            foreach (var item in _zal)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

        public void Update(int id, Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
