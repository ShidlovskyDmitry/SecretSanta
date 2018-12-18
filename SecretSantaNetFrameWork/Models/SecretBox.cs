
namespace SecretSantaNetFrameWork.Models
{
    public static class SecretBox
    {
        static SecretBox()
        {
            couples = new Couples();
        }

        public static string GetName(string name)
        {
            return couples.GetCouple(name);
        }

        public static void Shuffle()
        {
            bool shuffled = false;

            var Dima = "дима";
            var Andrew = "андрей";
            var Jenya = "женя";
            var Oxana = "оксана";
            var Sasha = "саша";

            var AndrewNote = new Note(Andrew, Jenya);
            var DimaNote = new Note(Dima);
            var JenyaNote = new Note(Jenya, Andrew);
            var OxanaNote = new Note(Oxana, Sasha);
            var SashaNote = new Note(Sasha, Oxana);

            while (!shuffled)
            {
                couples = new Couples();
                var box = new Box();

                box.Add(AndrewNote);
                box.Add(JenyaNote);
                box.Add(OxanaNote);
                box.Add(SashaNote);
                box.Add(DimaNote);

                foreach (var name in box.GetListOfNames())
                {
                    if (box.ValidateBox(name) == BoxValidationResult.Failure)
                    {
                        break;
                    }

                    while (box.NoteCount != 0)
                    {

                        if (box.ValidateBox(name) == BoxValidationResult.Failure)
                        {
                            break;
                        }

                        var note = box.GetRandomNote();
                        if (note.ExcludedName == name || note.Name == name)
                        {
                            box.Add(note);
                            continue;
                        }

                        couples.Add(name, note.Name);

                        break;
                    }

                    if (box.NoteCount == 0)
                    {
                        shuffled = true;
                    }
                }
            }

        }

        private static Couples couples;
    }
}