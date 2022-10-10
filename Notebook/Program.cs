using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Notebook
{
    class Program

    {
        static void Main(string[] args)
        {
            // aplikacja konsolowa
            // opcje - wyswietl wszystkie notatki, dodaj nowa notatke, usun notatke, edytuj notatke, wyjdz z programu
            // przechowywanie notatek - zapis i odczyt do/z pliku
            //* interaktywne menu - poruszanie sie strzalkami po menu


            {

                string[] options = new string[] { "Wyświetl notatki\t", "Dodaj nową notatkę\t", "Wyjdź z programu\t" };
                List<Note> notes = new List<Note>();
                Menu mainMenu = new Menu(options);
                
                int selectedIndex = mainMenu.Run();
                
                
                switch (selectedIndex)
                {
                    case 0:
                        NoteIO.ReadNotesFromFile(_path);
                        
                        break; 

                    case 1:

                        NoteIO.WriteNotesToFile(notes, _path);
                        break;

                    case 2:
                        {
                            Exit();
                            break;
                        }
                }

            }
        }
        private static string _path = Path.Combine(Environment.CurrentDirectory, "Notes.json");


        // odczytywanie z pliku
        static string InitializeData()
        {
            if (File.Exists(_path))
            {
                return File.ReadAllText(_path);
            }
            else
            {
                return "brak notatek";
            }

        }

        // wyjscie z programu
        public static void Exit()
        {
            Console.WriteLine("Wciśnij dowolny klawisz aby wyjść");
            Console.ReadKey(true);
            Environment.Exit(0);
        }

    }
}