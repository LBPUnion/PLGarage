﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameServer.Models.PlayerData
{
    public class GriefReportData
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        public string Context { get; set; }
        public string Reason { get; set; }
        public string Comments { get; set; }
        public string BadRectTop { get; set; }
        public string BadRectBottom { get; set; }
    }
}
