using System;
using System.Collections.Generic;
using Predictions.Domain;
using Predictions.Domain.Models;

namespace Predictions.ReadModel.Features.Tournaments.Dtos
{
    public class TournamentInfoReadDto
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
    }
}