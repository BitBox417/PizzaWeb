using Microsoft.AspNetCore.Mvc;
using PizzaKing.Models;

namespace PizzaKing.Controllers;

[Controller]
public class FeedbackController : Controller
{
	private readonly IFeedbackRepository _feedbackRepo;

	public FeedbackController(IFeedbackRepository feedbackRepository)
	{
		_feedbackRepo = feedbackRepository;
	}

	public ActionResult Index() 
	{
		return View();
	}

	[HttpPost]
	public ActionResult CreateFeedback(Feedback feedback) 
	{
		//就是POST请求中请求主体的键值对的集合
		//当用户请求数据有误的时候，它还可以提供错误提示信息
		// ModelState 存在目的
		// 1. 存储和提交 POST 请求主体
		// 2. 验证错误信息
		if(ModelState.IsValid) 
		{
			_feedbackRepo.AddFeedback(feedback);
			return Redirect("FeedbackCompleted");
		}
		
		return View("Index");
	}

	public ActionResult FeedbackCompleted() 
	{
		return View();
	}
}