﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.MLB
{
    [DataContract(Namespace="", Name="DfsSlateGame")]
    [Serializable]
    public partial class DfsSlateGame
    {
        /// <summary>
        /// Unique ID of a SlateGame (assigned by FantasyData).
        /// </summary>
        [Description("Unique ID of a SlateGame (assigned by FantasyData).")]
        [DataMember(Name = "SlateGameID", Order = 1)]
        public int SlateGameID { get; set; }

        /// <summary>
        /// The SlateID that this SlateGame refers to.
        /// </summary>
        [Description("The SlateID that this SlateGame refers to.")]
        [DataMember(Name = "SlateID", Order = 2)]
        public int SlateID { get; set; }

        /// <summary>
        /// The FantasyData GameID that this SlateGame refers to. This points to data in the respective sports' schedule/game/box score feeds.
        /// </summary>
        [Description("The FantasyData GameID that this SlateGame refers to. This points to data in the respective sports' schedule/game/box score feeds.")]
        [DataMember(Name = "GameID", Order = 3)]
        public int? GameID { get; set; }

        /// <summary>
        /// Unique ID of a SlateGame (assigned by the operator).
        /// </summary>
        [Description("Unique ID of a SlateGame (assigned by the operator).")]
        [DataMember(Name = "OperatorGameID", Order = 4)]
        public int? OperatorGameID { get; set; }

    }
}
