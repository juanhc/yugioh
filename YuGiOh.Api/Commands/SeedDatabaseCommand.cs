using MediatR;
using System;

namespace YuGiOh.Api.Commands
{
    public class SeedDatabaseCommand : IRequest<bool>
    {
        public readonly DateTime Date;
        public SeedDatabaseCommand() => Date = DateTime.Now;
    }
}
