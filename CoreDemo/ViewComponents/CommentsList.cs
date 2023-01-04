using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
	public class CommentsList:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{
				new UserComment
				{
					Id=1,
					UserName="Burcu"
				},

				new UserComment
				{
					Id=2,
					UserName="Aslı"
				},

				new UserComment
				{
					Id=3,
					UserName="Merve"
				}
			};

			return View(commentvalues);
		}
	}
}
