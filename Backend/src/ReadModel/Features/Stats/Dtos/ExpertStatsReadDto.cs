﻿using System.Diagnostics.Contracts;
using Domain.Models;

namespace ReadModel.Features.Stats.Dtos
{
    public class ExpertStatsReadDto
    {
        public int ExpertId { get; }
        public string Nickname { get; }

        public int Outcomes { get; }
        public int Differences { get; }
        public int Scores { get; }
        public int Sum { get; }

        public ExpertStatsReadDto(Expert expert, PredictionsResultAccumulator predictionsResult, int sum)
        {
            ExpertId = expert.Id;
            Nickname = expert.Nickname;

            Outcomes = predictionsResult.Outcomes;
            Differences = predictionsResult.Differences;
            Scores = predictionsResult.Scores;

            Sum = sum;
        }
    }
}
