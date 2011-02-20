﻿namespace ToBeSeen.Controllers
{
	using System.Web.Mvc;

	using ToBeSeen.Repositories;

	public class EventsController : Controller
	{
		private readonly IEventRepository events;

		public EventsController(IEventRepository events)
		{
			this.events = events;
		}

		public ActionResult Index(int? page)
		{
			var eventPage = events.GetPage(page.GetValueOrDefault(1));
			return View(eventPage);
		}
	}
}