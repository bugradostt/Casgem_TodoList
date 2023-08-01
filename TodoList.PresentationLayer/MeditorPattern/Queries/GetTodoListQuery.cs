using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.MeditorLayer.MeditorPattern.Results;

namespace TodoList.MeditorLayer.MeditorPattern.Queries
{
    public class GetTodoListQuery: IRequest<List<GetTodoListQueryResult>>
    {
    }
}
