using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hybridapp.Data
{
    // Definition of the TodoItem class representing each todo item
    public class TodoItem
    {
        // Property to store the text of the todo item
        public string Text { get; set; }
        // Property to store whether the todo item is checked or not
        public bool IsChecked { get; set; } = true;
        // Property to store date and time
        public DateTime Date { get; set; }
    }
}
