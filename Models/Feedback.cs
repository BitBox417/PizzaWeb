using System.ComponentModel.DataAnnotations;

namespace PizzaKing.Models;

public class Feedback 
{
	public int Id {get;set;}
	[Required(ErrorMessage = "请留下你的名字")]
	[StringLength(50, ErrorMessage = "名字不能超过50个字符")]
	public required string Name {get;set;}
	[Required(ErrorMessage = "请留下你的email")]
	[StringLength(50, ErrorMessage = "email不能超过50个字符")]
	// [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
	// 	, ErrorMessage = "请填写正确的email格式")]
	[DataType(DataType.EmailAddress, ErrorMessage = "请填写正确的email格式")]
	public required string Email {get;set;}
	public required DateTime CreateTimeUTC {get;set;}
	[Required(ErrorMessage = "请留下你的评价")]
	[StringLength(500, ErrorMessage = "评价不能超过500个字符")]
	public required string Comments {get;set;}
}