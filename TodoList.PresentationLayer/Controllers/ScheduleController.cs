using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using MediatR;
using System.Threading.Tasks;
using TodoList.MeditorLayer.MeditorPattern.Queries;
using Newtonsoft.Json;

namespace TodoList.PresentationLayer.Controllers
{
    public class ScheduleController : Controller
    {
        readonly IMediator _mediator;

        public ScheduleController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public IActionResult Index()
        {
            return View();
          
        }

     
        public async Task<IActionResult> List()
        {
            var values = await _mediator.Send(new GetTodoListQuery());
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }

     
    }
}
