using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TodoList.DataAccessLayer.Concrete;
using TodoList.PresentationLayer.MeditorPattern.Commands;

namespace TodoList.PresentationLayer.MeditorPattern.Handlers
{
    public class RemoveTodoListCommandHandler : IRequestHandler<RemoveTodoListCommand>
    {
        readonly Context _context;

        public RemoveTodoListCommandHandler(Context context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(RemoveTodoListCommand request, CancellationToken cancellationToken)
        {
            var foundId = _context.Todos.Find(request.TodoId);
            _context.Todos.Remove(foundId);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
