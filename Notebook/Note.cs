using System;
using System.Collections.Generic;
using System.Linq;
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

        public Note(string title, string description, string content, DateTime creationDate, DateTime modificationDate)
        {
            Title = title;
            Description = description;
            Content = content;
            CreationDate = creationDate;
            ModificationDate = modificationDate;
        }

    }
}
