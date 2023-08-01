using MediatR;
using System;

namespace TodoList.PresentationLayer.MeditorPattern.Commands
{
    public class CreateTodoListCommand:IRequest
    {
        public string TodoName { get; set; }
        public DateTime TodoDate { get; set; }
        public bool TodoStatus { get; set; }

    }
}
