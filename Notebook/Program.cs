using System.Collections.Generic;

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
                Menu mainMenu = new Menu(options);
                int selectedIndex = mainMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        //ReadNotesFromFile();
                        break;
                    case 1:
                        //WriteNotesToFile();
                        break;
                    case 2:
                        Exit();
                        break;
                }
            } 
        }

        static string _path = Path.Combine(Environment.CurrentDirectory, "Notes.txt");

        // zapis do pliku
        static void SaveToFile(string text)
        {
            File.WriteAllText(_path, text);
        }

        // odczytywanie z pliku
        static string ReadFromFile()
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

        // wyswietlanie zapisanej notatki
        public static void ShowNotes()
        {
            Console.WriteLine("Wyswietlono notatke");
            string note = ReadFromFile();
            Console.WriteLine(note);
        }

        // dodawanie nowej notatki
        public static void AddNotes()
        {
            Console.WriteLine("Wpisz treść notatki");
            string? content = Console.ReadLine();
            SaveToFile(content);
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