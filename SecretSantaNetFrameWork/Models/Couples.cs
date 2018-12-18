using System.Collections.Generic;

namespace SecretSantaNetFrameWork.Models
{
    public class Couples
    {
        public Couples()
        {
            NameDictionary = new Dictionary<string, string>();
        }
        public void Add(string sourceName, string coupleName)
        {
            NameDictionary.Add(sourceName, coupleName);
        }

        public string GetCouple(string name)
        {
            if(NameDictionary.Count == 0)
            {
                return "Пары ещё не расчитаны. Перемешайте коробку";
            }

            if(!NameDictionary.ContainsKey(name))
            {
                return "Извините, у вас нет пары";
            }

            var coupleName = NameDictionary[name];


            return coupleName;
        }

        private Dictionary<string, string> NameDictionary;
    }
}