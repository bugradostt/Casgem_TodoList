using MediatR;

namespace TodoList.PresentationLayer.MeditorPattern.Commands
{
    public class StatusTodoListCommand : IRequest
    {
        public int TodoId { get; set; }
        public bool TodoStatus { get; set; }

    }

}
