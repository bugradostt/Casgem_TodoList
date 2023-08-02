using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TodoList.MeditorLayer.MeditorPattern.Queries;
using TodoList.PresentationLayer.MeditorPattern.Commands;

namespace TodoList.PresentationLayer.Controllers
{
    public class TodoController : Controller
    {
        readonly IMediator _mediator;

        public TodoController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetTodoListQuery());
            return View(values);
        }


        [HttpPost]
        public async Task<IActionResult> AddTodoList(CreateTodoListCommand p)
        {
            p.TodoStatus = true;
            await _mediator.Send(p);
            return RedirectToAction("Index", "Schedule");
        }

        public async Task<IActionResult> DeleteTodoList(int id)
        {
            await _mediator.Send(new RemoveTodoListCommand(id));
            return RedirectToAction("Index", "Schedule");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTodoList(UpdateTodoListCommand p)
        {
            await _mediator.Send(p);
            return RedirectToAction("Index", "Schedule");
        }

      
        public async Task<IActionResult> StatusFalseTodoList(int id,StatusTodoListCommand p)
        {
            p.TodoId= id;
            p.TodoStatus = false;
            await _mediator.Send(p);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> StatusTrueTodoList(int id, StatusTodoListCommand p)
        {
            p.TodoId = id;
            p.TodoStatus = true;
            await _mediator.Send(p);
            return RedirectToAction("Index");
        }
    }
}
