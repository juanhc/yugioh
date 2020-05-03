using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using YuGiOh.Api.Configuration;
using YuGiOh.Api.Dto;
using YuGiOh.Domain;
using YuGiOh.Infraestructure;

namespace YuGiOh.Api.Commands
{
    public class SeedDatabaseCommandHandler : IRequestHandler<SeedDatabaseCommand, bool>
    {
        private readonly ApplicationDbContext _context;
        private readonly YuGiOhApiClient _http;
        private readonly ILogger<SeedDatabaseCommandHandler> _logger;

        public SeedDatabaseCommandHandler(ApplicationDbContext context, YuGiOhApiClient http,
            ILogger<SeedDatabaseCommandHandler> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _http = http ?? throw new ArgumentNullException(nameof(http));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<bool> Handle(SeedDatabaseCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var cardDtoList = await _http.GetCards<IEnumerable<CardDto>>();

                var cards = _context.Cards
                    .Include(x => x.CardImages)
                    .Include(x => x.CardPrices)
                    .Include(x => x.CardSets);

                _context.Cards.RemoveRange(cards);

                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<CardDto, Card>().ForMember(card => card.OriginalId, cardDto => cardDto.MapFrom(c => c.Id)).Ignore(c => c.Id);
                    cfg.CreateMap<CardDtoPrice, CardPrice>().Ignore(c => c.Id);
                    cfg.CreateMap<CardDtoImage, CardImage>().Ignore(c => c.Id);
                    cfg.CreateMap<CardDtoSet, CardSet>().Ignore(c => c.Id);
                });

                var mapper = configuration.CreateMapper();

                var cardList = mapper.Map<IEnumerable<Card>>(cardDtoList);

                await _context.Cards.AddRangeAsync(cardList);

                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"SeedDatabaseCommandHandler --- Error --- {ex.Message}");

                return false;
            }
        }
    }
}
