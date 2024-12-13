using DogRehoming.Core.Models.PublishedModels;
using DogRehoming.Core.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;

namespace DogRehoming.Core.Controllers.Render
{
	public class HomeController : RenderController
	{
		private readonly IPublishedValueFallback _publishedValueFallback;
		public HomeController(
			ILogger<RenderController> logger, 
			ICompositeViewEngine compositeViewEngine, 
			IUmbracoContextAccessor umbracoContextAccessor, 
			IPublishedValueFallback publishedValueFallback) : // pass in dependency so Umbraco knows what's needed to construct an instance of home controller
			base(logger, compositeViewEngine, umbracoContextAccessor)
		{
			_publishedValueFallback = publishedValueFallback;
		}
		public override IActionResult Index() //hijacking the index method that comes out of the box with renderController
		{
			var currentPage = CurrentPage as Home; // safe casting current page (which is a default property for render controllers).
			var model = new HomeViewModel(currentPage, _publishedValueFallback);
			return CurrentTemplate(model); //CurrentTemplate is an umbraco method that returns a view
		}

	}
}
