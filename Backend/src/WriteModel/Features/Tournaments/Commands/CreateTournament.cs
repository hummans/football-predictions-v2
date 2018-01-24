using MediatR;
using WriteModel.Features.Tournaments.Dtos;

namespace WriteModel.Features.Tournaments.Commands
{
    public class CreateTournament : IRequest<bool>
    {
        public TournamentInfoWriteDto TournamentInfo { get; private set; }
    }
}