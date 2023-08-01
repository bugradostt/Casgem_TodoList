using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TodoList.DataAccessLayer.Concrete;
using TodoList.PresentationLayer.MeditorPattern.Commands;

namespace TodoList.PresentationLayer.MeditorPattern.Handlers
{
    public class UpdateTodoListCommandHandler : IRequestHandler<UpdateTodoListCommand>
    {
        readonly Context _context;

        public UpdateTodoListCommandHandler(Context context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(UpdateTodoListCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Todos.Find(request.TodoId);
            values.TodoName = request.TodoName;
            values.TodoDate = request.TodoDate;
            await _context.SaveChangesAsync();
            return Unit.Value; ;
        }
    }
}
