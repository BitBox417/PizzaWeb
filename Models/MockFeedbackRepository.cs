
namespace PizzaKing.Models;

public class MockFeedbackRepository : IFeedbackRepository
{
	private List<Feedback> _feedbackList = new();

	public MockFeedbackRepository() 
	{
		InitializeFeedback();
	}

    public void AddFeedback(Feedback feedback)
    {
		_feedbackList.Add(feedback);
    }

    public IEnumerable<Feedback> GetAllFeedbacks()
    {
        return _feedbackList;
    }

	private void InitializeFeedback()
	{
		_feedbackList =
        [
            new() { Id = 1, Name = "阿莱克斯", Email = "noname1@hotmail.com", Comments = "真不错", CreateTimeUTC = DateTime.UtcNow},
			new() { Id = 2, Name = "莱克斯", Email = "noname2@hotmail.com", Comments = "还是挺好吃的", CreateTimeUTC = DateTime.UtcNow},
			new() { Id = 3, Name = "克斯", Email = "noname3@hotmail.com", Comments = "啥轮七八糟的", CreateTimeUTC = DateTime.UtcNow},
			new() { Id = 4, Name = "克斯", Email = "noname4@hotmail.com", Comments = "厚切的才有嚼劲", CreateTimeUTC = DateTime.UtcNow},
		];
	}

}
