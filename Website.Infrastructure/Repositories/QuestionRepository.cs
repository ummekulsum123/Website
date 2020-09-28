using Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Website.Domain.Abstractions.Repositories;
using Website.Domain.Entities;

namespace Website.Infrastructure.Repositories
{
	/// <summary>
	/// Представляет репозиторий для работы с вопросами.
	/// </summary>
	internal class QuestionRepository : IQuestionRepository
	{
		private readonly WebsiteDbContext _websiteDbContext;

		public QuestionRepository(WebsiteDbContext websiteDbContext)
		{
			_websiteDbContext = websiteDbContext ?? throw new ArgumentNullException(nameof(websiteDbContext));
		}

		///<inheritdoc/>
		public Task CreateQuestionAsync(Question question)
		{
			_websiteDbContext.Questions.Add(question);
			return _websiteDbContext.SaveChangesAsync();
		}
		///<inheritdoc/>
		public async Task<Question> GetQuestionAsync(Guid questionId)
		{
			return await _websiteDbContext.Questions.FindAsync(questionId);
		}
		///<inheritdoc/>
		public async Task<CollectionResult<Question>> GetQuestionsAsync(int offset, int count)
		{
			int totalCount = await _websiteDbContext.Questions.CountAsync();
			Question[] questions = await _websiteDbContext.Questions.OrderByDescending(x => x.Date).Skip(offset).Take(count).ToArrayAsync();
			return new CollectionResult<Question>(totalCount, questions);
		}
	}
}