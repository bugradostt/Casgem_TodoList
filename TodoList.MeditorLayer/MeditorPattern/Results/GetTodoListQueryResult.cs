using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.MeditorLayer.MeditorPattern.Results
{
    public class GetTodoListQueryResult
    {
        public int TodoId { get; set; }
        public string TodoName { get; set; }
        public DateTime TodoDate { get; set; }
    }
}
