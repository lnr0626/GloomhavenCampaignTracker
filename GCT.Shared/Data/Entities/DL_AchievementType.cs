﻿using System.Collections.Generic;
using GloomhavenCampaignTracker.Shared.Business;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace GloomhavenCampaignTracker.Shared.Data.Entities
{
    [Table("DL_AchievementType")]
    public class DL_AchievementType : IEntity, ISpinneritem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int InternalNumber { get; set; }

        [MaxLength(250), Unique]
        public string Name { get; set; }

        public int Steps { get; set; }

        [ManyToMany(typeof(DL_CampaignGlobalAchievement), CascadeOperations = CascadeOperation.CascadeRead)]
        public List<DL_Campaign> Campaigns { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<DL_Achievement> Achievements { get; set; }

        public string Spinnerdisplayvalue => Name;
    }
}