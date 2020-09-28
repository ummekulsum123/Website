using System.Threading.Tasks;
using Website.Domain.Entities;

namespace Website.Domain.Abstractions.Repositories
{
	/// <summary>
	/// Представляет репозиторий для работы со студентами.
	/// </summary>
	public interface IStudentRepository
	{
		/// <summary>
		/// Создаёт студента.
		/// </summary>
		/// <param name="student">Модель студента.</param>
		public Task CreateStudent(Student student);
		/// <summary>
		/// Возвращает модель студента.
		/// </summary>
		/// <param name="studentId">Идентификатор студента.</param>
		/// <returns>Модель студента.</returns>
		public Task<Student> GetStudent(int studentId);
	}
}