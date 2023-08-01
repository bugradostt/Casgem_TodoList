using MediatR;

namespace TodoList.PresentationLayer.MeditorPattern.Commands
{
    public class RemoveTodoListCommand : IRequest
    {
        public RemoveTodoListCommand(int id)
        {
            TodoId = id;
        }

        public int TodoId { get; set; }
    }
}
