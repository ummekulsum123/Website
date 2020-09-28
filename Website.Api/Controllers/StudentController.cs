using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Website.Domain.Abstractions.Repositories;
using Website.Domain.Entities;

namespace Website.Api.Controllers
{
	/// <summary>
	/// Представляет API для работы со студентами.
	/// </summary>
	[Route("[controller]")]
	[ApiController]
	public class StudentController : ControllerBase
	{
		private readonly IStudentRepository _studentRepository;

		public StudentController(IStudentRepository studentRepository) => _studentRepository = studentRepository ?? throw new ArgumentNullException(nameof(studentRepository));

		/// <summary>
		/// Создаёт студента.
		/// </summary>
		/// <param name="studentEntity">Модель студента.</param>
		[HttpPost]
		public Task CreateStudent(Student student) => _studentRepository.CreateStudent(student);
		/// <summary>
		/// Возвращает модель студента.
		/// </summary>
		/// <param name="studentId">Идентификатор студента.</param>
		/// <returns>Модель студента.</returns>
		[HttpGet("studentId")]
		public Task<Student> GetStudent(int studentId) => _studentRepository.GetStudent(studentId);
	}
}