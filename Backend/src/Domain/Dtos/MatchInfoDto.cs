using System;
using System.Collections.Generic;
using Predictions.Domain;
using Predictions.Domain.Models;

namespace Predictions.Domain.Dtos
{
    public class MatchInfoDto
    {
        public string Id { get; private set; }
        public DateTime Date { get; private set; }
        public string HomeTeamTitle { get; private set; }
        public string AwayTeamTitle { get; private set; }
        public string Result { get; private set; }
    }
}