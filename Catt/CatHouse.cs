using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT
{
    internal class CatHouse
    {
        public string Name { get; set; }
        public List<Cat> Cats { get; set; } = new();
        public int CatCount { get => Cats.Count; }
        public void AddCat(Cat cat)
        {
            foreach (var item in Cats)
            {
                if (item.NickName == cat.NickName)
                    throw new Exception("There is cat with this name!");
            }
            Cats.Add(cat);
        }
        public void RemoveByNickname(string nickname)
        {
            Cat cat;
            foreach (var item in Cats)
            {
                if (item.NickName == nickname)
                    Cats.Remove(item);
            }
        }
    }
}
