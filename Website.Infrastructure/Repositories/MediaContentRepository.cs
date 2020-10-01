using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Website.Domain.Abstractions.Repositories;
using Website.Domain.Entities;

namespace Website.Infrastructure.Repositories
{
	/// <summary>
	/// Представляет репозиторий для работы с медиаконтентом. 
	/// </summary>
	internal class MediaContentRepository : IMediaContentRepository
	{
		private readonly WebsiteDbContext _websiteDbContext;

		public MediaContentRepository(WebsiteDbContext websiteDbContext)
		{
			_websiteDbContext = websiteDbContext ?? throw new ArgumentNullException(nameof(websiteDbContext));
		}

		///<inheritdoc/>
		public Task CreateMediaContent(MediaContent mediaContent)
		{
			_websiteDbContext.MediaContents.Add(mediaContent);
			return _websiteDbContext.SaveChangesAsync();
		}

		///<inheritdoc/>
		public async Task<MediaContent> GetMediaContent(Guid id)
		{
			return await _websiteDbContext.MediaContents.FindAsync(id);
		}
	}
}