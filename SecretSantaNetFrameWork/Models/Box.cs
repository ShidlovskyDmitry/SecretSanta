using System;
using System.Collections.Generic;
using System.Linq;

namespace SecretSantaNetFrameWork.Models
{
    public class Box
    {

        public Box()
        {
            NoteList = new List<Note>();
            random = new Random();
        }

        public BoxValidationResult ValidateBox(string name)
        {
            if (NoteList.Count > 2)
            {
                return BoxValidationResult.Success;
            }


            if (NoteList.Count == 2)
            {
                if (NoteList.First().Name == NoteList.Last().ExcludedName)
                {
                    return BoxValidationResult.Failure;
                }
            }

            if (NoteList.Count == 1)
            {
                if (NoteList.Single().Name == name || NoteList.Single().ExcludedName == name)
                {
                    return BoxValidationResult.Failure;
                }
            }

            return BoxValidationResult.Success;
        }

        public void Add(Note note)
        {
            NoteList.Add(note);
        }

        public IEnumerable<string> GetListOfNames()
        {
            var list = NoteList.Select(item => (Note)item.Clone()).ToList().Select(note => note.Name).ToList();

            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                var value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }

        public Note GetRandomNote()
        {
            var r = random.Next(NoteList.Count);

            var note = NoteList[r];
            NoteList.Remove(note);

            return note;
        }

        public int NoteCount
        {
            get { return NoteList.Count; }
        }


        private Random random;
        private List<Note> NoteList;
    }
}