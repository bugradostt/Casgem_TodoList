using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.PresentationLayer.Dal.Concrete
{
    public class Todo
    {
        public int TodoId { get; set; }
        public string TodoName { get; set; }
        public DateTime TodoDate { get; set; }
        public bool TodoStatus { get; set; }
    }
}
