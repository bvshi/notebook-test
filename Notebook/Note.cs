using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Notebook
{
    public class Note
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Content { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }


        public Note(string noteTitle, string noteDescription, string noteContent)
        {
            Title = noteTitle;
            Description = noteDescription;
            Content = noteContent;
        }

        public Note(string noteTitle, string noteDescription, string noteContent, DateTime creationDate, DateTime modificationDate)
        {
            Title = noteTitle;
            Description = noteDescription;
            Content = noteContent;
            CreationDate = creationDate;
            ModificationDate = modificationDate;
        }

        public Note()
        {

        }



    }

}