using MediatR;
using System;

namespace TodoList.PresentationLayer.MeditorPattern.Commands
{
    public class UpdateTodoListCommand : IRequest
    {
        public int TodoId { get; set; }
        public string TodoName { get; set; }
        public DateTime TodoDate { get; set; }

    }
}
