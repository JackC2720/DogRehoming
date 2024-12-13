using DogRehoming.Core.Models.CustomModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;


namespace DogRehoming.Core.Controllers.Surface
{
    public class DogSearchSurfaceController : SurfaceController
    {
        public DogSearchSurfaceController(IUmbracoContextAccessor umbracoContextAccessor, 
            IUmbracoDatabaseFactory databaseFactory, 
            ServiceContext services, 
            AppCaches appCaches, 
            IProfilingLogger profilingLogger, 
            IPublishedUrlProvider publishedUrlProvider) : 
            base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {

        }
        public IActionResult AddDog([Bind(Prefix = "AddDogSurface")] AddDogSurfaceModel model)
        {
            var name = model.Name;


            return Ok();
            //throw new NotImplementedException(); - enables compilation
        }
    }
}
