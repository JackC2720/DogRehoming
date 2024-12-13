using DogRehoming.Core.Models.CustomModels;
using DogRehoming.Core.Models.PublishedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace DogRehoming.Core.Models.ViewModels
{
	public class HomeViewModel : Home
	{
		public HomeViewModel(
			Home content, 
			IPublishedValueFallback publishedValueFallback) : base(content, publishedValueFallback)
		{
			Content = content;
		}
		public Home Content { get; set; }
		public AddDogSurfaceModel AddDogSurface { get; set; }
	}
}
