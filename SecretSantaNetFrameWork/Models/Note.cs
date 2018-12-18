using System;
namespace SecretSantaNetFrameWork.Models
{
    public class Note : ICloneable
    {

        public Note(string name, string excludedName)
        {
            Name = name;
            ExcludedName = excludedName;
        }

        public Note(string name)
        {
            Name = name;
        }

        public string Name;

        public string ExcludedName;

        public object Clone()
        {
            return new Note(Name, ExcludedName);
        }
    }
}