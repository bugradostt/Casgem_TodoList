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
            return await _context.Todos.OrderByDescending(x=>x.TodoDate)
                .OrderByDescending(x=>x.TodoStatus)
                .Select(x => new GetTodoListQueryResult
            {
                TodoId = x.TodoId,
                TodoName = x.TodoName,
                TodoDate = x.TodoDate,
                TodoStatus = x.TodoStatus
            }).AsNoTracking().ToListAsync();
        }
    }
}
