using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TodoList.DataAccessLayer.Concrete;
using TodoList.MeditorLayer.MeditorPattern.Queries;
using TodoList.MeditorLayer.MeditorPattern.Results;

namespace TodoList.MeditorLayer.MeditorPattern.Handlers
{
    public class TodoListQueryHandler : IRequestHandler<GetTodoListQuery, List<GetTodoListQueryResult>>
    {
        readonly Context _context;

        public TodoListQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetTodoListQueryResult>> Handle(GetTodoListQuery request, CancellationToken cancellationToken)
        {
            return await _context.Todos.Select(x => new GetTodoListQueryResult
            {
                TodoName = x.TodoName,
                TodoDate = x.TodoDate

            }).AsNoTracking().ToListAsync();
        }
    }
}
