using MediatR;
using System.Threading.Tasks;
using System.Threading;
using TodoList.DataAccessLayer.Concrete;
using TodoList.PresentationLayer.MeditorPattern.Commands;

namespace TodoList.PresentationLayer.MeditorPattern.Handlers
{
    public class StatusTodoListCommandHandler : IRequestHandler<StatusTodoListCommand>
    {
        readonly Context _context;

        public StatusTodoListCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(StatusTodoListCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Todos.Find(request.TodoId);
            values.TodoStatus = request.TodoStatus;
            await _context.SaveChangesAsync();
            return Unit.Value; ;
        }
    }
}
