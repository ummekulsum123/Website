namespace Website.Api.Models.Questions
{
	/// <summary>
	/// Представляет модель вопроса.
	/// </summary>
	public class QuestionFm
	{
		/// <summary>
		/// Имя спрашивающего.
		/// </summary>
		public string QuestionerName { get; set; }
		/// <summary>
		/// Контактные данные.
		/// </summary>
		public string Contact { get; set; }
		/// <summary>
		/// Контент вопроса.
		/// </summary>
		public string Content { get; set; }
	}
}