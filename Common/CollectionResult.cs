using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Common
{
    /// <summary>
    /// Контейнер для коллекции объектов
    /// </summary>
    /// <typeparam name="TData">Тип объектов</typeparam>
    public class CollectionResult<TData>
    {
        /// <summary>
        /// Контейнер для коллекции объектов
        /// </summary>
        /// <remarks> Атрибут конструктора нужен для обратной десериализации из JSON </remarks>
        [JsonConstructor]
        public CollectionResult(int totalCount, IEnumerable<TData> data)
        {
            TotalCount = totalCount;
            Data = data;
        }
        /// <summary>
        /// Контейнер для коллекции объектов
        /// </summary>
        public CollectionResult(IEnumerable<TData> data) : this(data.Count(), data) { }
        /// <summary>
        /// Контейнер для коллекции объектов
        /// </summary>
        public CollectionResult(TData data) : this(1, new[] { data ?? throw new ArgumentNullException(nameof(data)) }) { }

        /// <summary>
        /// Пустая коллекция с результирующими данными
        /// </summary>
        public static CollectionResult<TData> Empty { get; } = new CollectionResult<TData>(new TData[0]);
        /// <summary>
        /// Общее количество найденных объектов
        /// </summary>
        public int TotalCount { get; }
        /// <summary>
        /// Список объектов
        /// </summary>
        public IEnumerable<TData> Data { get; }
    }
}