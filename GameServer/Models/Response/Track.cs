using System.Collections.Generic;
using System.Xml.Serialization;

namespace GameServer.Models.Response
{
    [XmlType(TypeName = "comment")]    // TODO: Can we change this to XmlRoot?
    public class Comment 
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
        [XmlAttribute("player_id")]
        public int PlayerId { get; set; }
        [XmlAttribute("username")]
        public string Username { get; set; }
        [XmlAttribute("body")]
        public string Body { get; set; }
        [XmlAttribute("rating_up")]
        public int RatingUp { get; set; }
        [XmlAttribute("rated_by_me")]
        public bool RatedByMe { get; set; }
        [XmlAttribute("updated_at")]
        public string UpdatedAt { get; set; }
    }

    [XmlType(TypeName = "track")]    // TODO: Can we change this to XmlRoot?
    public class Track
    {
        [XmlAttribute("ai")]
        public bool Ai { get; set; }
        [XmlAttribute("associated_item_ids")]
        public string AssociatedItemIds { get; set; }
        [XmlAttribute("auto_reset")]
        public bool AutoReset { get; set; }
        [XmlAttribute("battle_friendly_fire")]
        public bool BattleFriendlyFire { get; set; }
        [XmlAttribute("battle_kill_count")]
        public int BattleKillCount { get; set; }
        [XmlAttribute("battle_time_limit")]
        public int BattleTimeLimit { get; set; }
        [XmlAttribute("coolness")]
        public float Coolness { get; set; }
        [XmlAttribute("created_at")]
        public string CreatedAt { get; set; }
        [XmlAttribute("description")]
        public string Description { get; set; }
        [XmlAttribute("difficulty")]
        public string Difficulty { get; set; }
        [XmlAttribute("dlc_keys")]
        public string DlcKeys { get; set; }
        [XmlAttribute("downloads")]
        public int Downloads { get; set; }
        [XmlAttribute("downloads_last_week")]
        public int DownloadsLastWeek { get; set; }
        [XmlAttribute("downloads_this_week")]
        public int DownloadsThisWeek { get; set; }
        [XmlAttribute("first_published")]
        public string FirstPublished { get; set; }
        [XmlAttribute("hearted_by_me")]
        public string HeartedByMe { get; set; }
        [XmlAttribute("hearts")]
        public int Hearts { get; set; }
        [XmlAttribute("id")]
        public int Id { get; set; }
        [XmlAttribute("is_remixable")]
        public bool IsRemixable { get; set; }
        [XmlAttribute("is_team_pick")]
        public bool IsTeamPick { get; set; }
        [XmlAttribute("last_published")]
        public string LastPublished { get; set; }
        [XmlAttribute("level_mode")]
        public int LevelMode { get; set; }
        [XmlAttribute("longest_drift")]
        public float LongestDrift { get; set; }
        [XmlAttribute("longest_hang_time")]
        public float LongestHangTime { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
        [XmlAttribute("num_laps")]
        public int NumLaps { get; set; }
        [XmlAttribute("num_racers")]
        public int NumRacers { get; set; }
        [XmlAttribute("max_humans")]
        public int MaxHumans { get; set; }
        [XmlAttribute("platform")]
        public string Platform { get; set; }
        [XmlAttribute("player_creation_type")]
        public string PlayerCreationType { get; set; }
        [XmlAttribute("player_id")]
        public int PlayerId { get; set; }
        [XmlAttribute("queued_by_me")]
        public string QueuedByMe { get; set; }
        [XmlAttribute("race_type")]
        public string RaceType { get; set; }
        [XmlAttribute("races_finished")]
        public int RacesFinished { get; set; }
        [XmlAttribute("races_started")]
        public int RacesStarted { get; set; }
        [XmlAttribute("races_started_this_month")]
        public int RacesStartedThisMonth { get; set; }
        [XmlAttribute("races_started_this_week")]
        public int RacesStartedThisWeek { get; set; }
        [XmlAttribute("races_won")]
        public int RacesWon { get; set; }
        [XmlAttribute("rank")]
        public int Rank { get; set; }
        [XmlAttribute("rating_down")]
        public int RatingDown { get; set; }
        [XmlAttribute("rating_up")]
        public int RatingUp { get; set; }
        [XmlAttribute("reviewed_by_me")]
        public string ReviewedByMe { get; set; }
        [XmlAttribute("scoreboard_mode")]
        public int ScoreboardMode { get; set; }
        [XmlAttribute("speed")]
        public string Speed { get; set; }
        [XmlAttribute("tags")]
        public string Tags { get; set; }
        [XmlAttribute("track_theme")]
        public int TrackTheme { get; set; }
        [XmlAttribute("unique_racer_count")]
        public int UniqueRacerCount { get; set; }
        [XmlAttribute("updated_at")]
        public string UpdatedAt { get; set; }
        [XmlAttribute("user_tags")]
        public string UserTags { get; set; }
        [XmlAttribute("username")]
        public string Username { get; set; }
        [XmlAttribute("version")]
        public int Version { get; set; }
        [XmlAttribute("views")]
        public int Views { get; set; }
        [XmlAttribute("views_last_week")]
        public int ViewsLastWeek { get; set; }
        [XmlAttribute("views_this_week")]
        public int ViewsThisWeek { get; set; }
        [XmlAttribute("votes")]
        public int Votes { get; set; }
        [XmlAttribute("weapon_set")]
        public string WeaponSet { get; set; }
        [XmlElement("comments")]
        public List<Comment> Comments { get; set; }
        [XmlElement("reviews")]
        public List<Reviews> Reviews { get; set; }
        [XmlElement("activities")]
        public List<Activities> Activities { get; set; }
        [XmlElement("photos")]
        public List<Photos> Photos { get; set; }
        [XmlElement("leaderboard")]
        public List<SubLeaderboard> Leaderboard { get; set; }
    }
}