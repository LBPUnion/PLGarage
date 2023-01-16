﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameServer.Models.PlayerData.Games
{
    public class GamePlayerStatsData
    {
        [Key]
        public int Id { get; set; }
        public int GameId { get; set; }

        [ForeignKey(nameof(GameId))]
        public GameData Game { get; set; }

        public bool IsComplete { get; set; }
        public int Stat1 { get; set; }
        public int Stat2 { get; set; }
        public float Score { get; set; }
        public int IsWinner { get; set; }
        public int FinishPlace { get; set; }
        public float FinishTime { get; set; }
        public int LapsCompleted { get; set; }
        public float Points { get; set; }
        public float Volatility { get; set; }
        public float Deviation { get; set; }
        public int PlaygroupSize { get; set; }
        public int NumKills { get; set; }
    }
}
