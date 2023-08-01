using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using MediatR;

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

     
    }
}
