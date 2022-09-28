using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    class NoteIO
    {
        public void WriteNotesToFile(List notes, string _path)
        {
            List<string> lines = File.ReadAllLines(_path).ToList();

            Console.WriteLine("wpisz cos:");

            string? notatka = Console.ReadLine();
            lines.Add(notatka);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            File.WriteAllLines(_path, lines);

            Console.ReadLine();
        }


            public List ReadNotesFromFile(string _path)
        {
            List<Note> notes = new List<Note>();
            List<string> lines = File.ReadAllLines(_path).ToList();

            foreach (string line in lines)
            {
                string[] elements = line.Split('|');
                Note newNote = new Note();
                newNote.Title = elements[0];
                newNote.Description = elements[1];
                newNote.Content = elements[2];

                notes.Add(newNote);

                foreach (var note in notes)
                {
                    Console.WriteLine($"{note.Title} {note.Description} {note.Content}");
                }
            }
        }
    }
}
