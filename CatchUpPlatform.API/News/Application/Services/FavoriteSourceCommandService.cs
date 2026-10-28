using CatchUpPlatform.API.News.Application.Errors;
using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Domain.Model.Commands;
using CatchUpPlatform.API.News.Infrastructure.Persistence.EntityFrameworkCore;
using CatchUpPlatform.API.Shared.Application.Patterns;
using Microsoft.EntityFrameworkCore;

namespace CatchUpPlatform.API.News.Application.Services;

public class FavoriteSourceCommandService
{
    public class FavoritSourceCommandService()
    {
        public async Task<Result<FavoriteSource,CreateFavoriteSourceError>>Handle(CreateFavoriteSourceCommand command,CancellationToken cancellationToken = default)
        var existingSource = await FavoriteSourceRepository.FindByNewsApiKeyAndSourceIdAsync(command.NewsApiKey)
    }
}

