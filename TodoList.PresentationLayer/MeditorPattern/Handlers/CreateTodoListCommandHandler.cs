using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TodoList.DataAccessLayer.Concrete;
using TodoList.PresentationLayer.Dal.Concrete;
using TodoList.PresentationLayer.MeditorPattern.Commands;

namespace TodoList.PresentationLayer.MeditorPattern.Handlers
{
    public class CreateTodoListCommandHandler : IRequestHandler<CreateTodoListCommand>
    {
        readonly Context _context;

        public CreateTodoListCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateTodoListCommand request, CancellationToken cancellationToken)
        {
            _context.Todos.Add(new Todo
            {
                TodoName = request.TodoName,
                TodoDate = request.TodoDate,
                TodoStatus = true
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
