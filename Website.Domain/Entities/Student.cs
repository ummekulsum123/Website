using System;

namespace Website.Domain.Entities
{
	/// <summary>
	/// Представляет сущность студента.
	/// </summary>
	public class Student
	{
		/// <summary>
		/// Идентификатор.
		/// </summary>
		public Guid Id { get; set; }
		/// <summary>
		/// ФИО студента.
		/// </summary>
		public string FullName { get; set; }
		/// <summary>
		/// Дата рождения.
		/// </summary>
		public DateTime Birthdate { get; set; }
	}
}