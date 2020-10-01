using System;
using System.Threading.Tasks;
using Website.Domain.Abstractions.Repositories;
using Website.Domain.Entities;

namespace Website.Infrastructure.Repositories
{
	/// <summary>
	/// Представляет репозиторий для работы с пациентами.
	/// </summary>
	internal class StudentRepository : IStudentRepository
	{
		private readonly WebsiteDbContext _websiteDbContext;

		public StudentRepository(WebsiteDbContext websiteDbContext)
		{
			_websiteDbContext = websiteDbContext ?? throw new ArgumentNullException(nameof(websiteDbContext));
		}

		///<inheritdoc/>
		public Task CreateStudent(Student student)
		{
			_websiteDbContext.Students.Add(student);
			return _websiteDbContext.SaveChangesAsync();
		}
		///<inheritdoc/>
		public async Task<Student> GetStudent(Guid studentId)
		{
			return await _websiteDbContext.Students.FindAsync(studentId);
		}
	}
}