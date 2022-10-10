using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace Notebook
{
    class NoteIO
    {
        public static void WriteNotesToFile(List<Note> notes, string path)
        {
            
            Console.WriteLine("Podaj tytuł notatki");
            string? noteTitle = Console.ReadLine();
            Console.WriteLine("Wpisz opis notatki");
            string? noteDescription = Console.ReadLine();
            Console.WriteLine("Wpisz treść notatki");
            string? noteContent = Console.ReadLine();

            Note newNote = new Note (noteTitle, noteDescription, noteContent);
            notes.Add (newNote);

            string serializeNote = JsonConvert.SerializeObject(notes);


            File.AppendAllText(path, serializeNote);

        }


        public static List<Note> ReadNotesFromFile(string path)
        {
            string readSerializedNote = File.ReadAllText(path);
            List<Note> deserializedNote = JsonConvert.DeserializeObject<List<Note>>(readSerializedNote);
            
            return deserializedNote;
        }
         
    }
}
