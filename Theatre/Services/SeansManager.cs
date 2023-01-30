using Core.Models;
using Core.Services.Contracts;
using Theatre.Models;

namespace Theatre.Services
{
    public class SeansManager : ICrudService , IPrintService
    {
        private Seans[] _seans = new Seans[3];
        private int _currentIndex = 0;
        public void Add(Entity entity)
        {
            if (_currentIndex >2)
            {
                Console.WriteLine("Only 3 Session enable");
                return;
            }

            _seans[_currentIndex++] = (Seans)entity;
            Console.WriteLine("Session succesfuly added");
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Entity Get(int id)
        {
            foreach (var item in _seans)
            {
                if (item == null)
                    continue;

                if(item.Id == id) return item;
            }
            Console.WriteLine("Session not found");
            return null;
        }

        public Entity[] GetAll()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            foreach (var item in _seans)
            {
                if(item == null)
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
