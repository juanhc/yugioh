using AutoMapper;
using MediatR;
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
                var cardDtoList = await _http.GetCards();

                _context.Cards.RemoveRange(_context.Cards);

                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<CardDto, Card>()
                    .Ignore(x => x.CardSets)
                    .Ignore(x => x.CardImages)
                    .Ignore(x => x.CardPrices);

                    cfg.CreateMap<CardDtoPrice, CardPrice>();
                    cfg.CreateMap<CardDtoImage, CardImage>();
                    cfg.CreateMap<CardDtoSet, CardSet>();
                });

                var mapper = configuration.CreateMapper();

                List<Card> cardList = new List<Card>();

                foreach (var cardDto in cardDtoList)
                {
                    Card card = mapper.Map<Card>(cardDto);

                    card.Id = 0;

                    if(cardDto.CardSets != null)
                    {
                        foreach (var cardSetDto in cardDto.CardSets)
                        {
                            card.CardSets.Add(mapper.Map<CardSet>(cardSetDto));
                        }
                    }

                    if (cardDto.CardImages != null)
                    {
                        foreach (var cardImageDto in cardDto.CardImages)
                        {
                            var cardImage = mapper.Map<CardImage>(cardImageDto);

                            cardImage.Id = 0;

                            card.CardImages.Add(cardImage);
                        }
                    }

                    if (cardDto.CardPrices != null)
                    {
                        foreach (var cardPriceDto in cardDto.CardPrices)
                        {
                            card.CardPrices.Add(mapper.Map<CardPrice>(cardPriceDto));
                        }
                    }

                    cardList.Add(card);
                }

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
