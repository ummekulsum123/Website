using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Website.Data;
using Website.Data.Entities;

namespace Website.Api.Controllers
{
	/// <summary>
	/// Представляет API для работы со студентами.
	/// </summary>
	[Route("[controller]")]
	[ApiController]
	public class StudentController : ControllerBase
	{
		private readonly WebsiteDbContext _websiteDbContext;

		public StudentController(WebsiteDbContext websiteDbContext)
		{
			_websiteDbContext = websiteDbContext ?? throw new ArgumentNullException(nameof(websiteDbContext));
		}
	
		/// <summary>
		/// Создаёт студента.
		/// </summary>
		/// <param name="studentEntity">Модель студента.</param>
		[HttpPost]
		public Task CreateStudent(StudentEntity studentEntity)
		{
			_websiteDbContext.Add(studentEntity);
			_websiteDbContext.SaveChanges();
			return Task.CompletedTask;
		}

		/// <summary>
		/// Возвращает модель студента.
		/// </summary>
		/// <param name="studentId">Идентификатор студента.</param>
		/// <returns>Модель студента.</returns>
		[HttpGet("studentId")]
		public async Task<StudentEntity> GetStudent(int studentId)
		{
			return await _websiteDbContext.FindAsync<StudentEntity>(studentId);
		}
	}
}