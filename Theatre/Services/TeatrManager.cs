using Core.Models;
using Core.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Theatre.Models;

namespace Theatre.Services
{
    internal class TeatrManager : ICrudService , IPrintService
    {
        private Teatr[] _theatre = new Teatr[2];
        private int _currentindex = 0;

        public void Add(Entity entity)
        {
            if (_currentindex > 2)
            {
                Console.WriteLine("There are only 2 Theatres");
                return;
            }

            _theatre[_currentindex++] = (Teatr)entity;
            Console.WriteLine("Theatre succesfuly added");
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < _theatre.Length; i++)
            {
                if (_theatre[i] == null)
                    continue;

                if (_theatre[i].Id == id)
                {
                    return _theatre[i];
                }
            }

            Console.WriteLine("Theatres now found");
            return null;
        }

        public Entity[] GetAll()
        {
            return _theatre;
        }

        public void Print()
        {
            foreach (var item in _theatre)
            {
                if (item == null)
                    continue;

                foreach (var zal in item.Zals) 
                {
                    if (zal is null)
                        continue;

                    Console.WriteLine(zal);
                }

                
            }
        }

        public void Update(int id, Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
