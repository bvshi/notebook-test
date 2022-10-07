using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Notebook
{
    class NoteIO
    {
        public static void WriteNotesToFile(List<Note> notes, string _path) // gdzie utworzyc sciezke _path? w metodzie, poza nia w tej samej klasie czy w Program.cs?
        {
            List<Note> noteList = new List<Note>();
            Console.WriteLine("Podaj tytuł notatki");
            string? noteTitle = Console.ReadLine();
            Console.WriteLine("Wpisz opis notatki");
            string? noteDescription = Console.ReadLine();
            Console.WriteLine("Wpisz treść notatki");
            string? noteContent = Console.ReadLine();

            Note newNote = new Note (noteTitle, noteDescription, noteContent);
            noteList.Add (newNote);

            string noteJson = JsonConvert.SerializeObject(noteList);

            string filePath = @"C:\json.txt";
            
            File.AppendAllText(filePath, noteJson); // co zwracać zamiast noteJson jeśli użyję AppendAllLines? chciałbym aby notatki zapisywaly sie w pliku jedna pod druga

        }


        public List<Note> ReadNotesFromFile(string _path)
        {
           
        }
    }
}
