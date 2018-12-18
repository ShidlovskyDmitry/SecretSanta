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

        public void Add(Note note)
        {
            NoteList.Add(note);
        }

        public IEnumerable<string> GetListOfNames()
        {
            return NoteList.Select(item => (Note)item.Clone()).ToList().Select(note => note.Name);
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