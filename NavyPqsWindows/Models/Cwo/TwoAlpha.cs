using System.Collections.Generic;
using NavyPqsWindows.Services;
using Newtonsoft.Json;

namespace NavyPqsWindows.Models.Cwo
{
    public class TwoAlpha : IPqs
    {
        [JsonIgnore] private readonly string[] twoAlphaSectionsByLine =
        {
            "Safety Precautions;101;1;2;3;4;5;6;7;8;9;10",
            "Maintenance;102;1;2;3;4;5;6",
            "Security;103;1;2;3;4;5;6;7;8",
            "Intelligence Oversight;104;1;2;3;4;5;6;7;8",
            "Leadership;105;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;16;17;18;19",
            "Terminology;106;1",
            "U.S.Navy Organizations and Supporting Platforms;107;1;2;3;4;5;6;7;8",
            "Naval and Joint Platforms;108;1;2",
            "Rules of Engagement (ROE) and Weapons Release;109;1;2;3;4;5;6;7",
            "Amphibious Task Force/Task Group Organization and Operations;110;1;2;3;4;5;6;7",
            "Command and Control for Joint Operations;111;1;2",
            "National/Theater Level Support;112;1;2;3;4;5",
            "Fleet Support Operations;113;1;2;3;4;5;6;7;8;9",
            "Intelligence Support;114;1;2;3;4;5;6",
            "Radio Propagation and Signal Characteristics;115;1;2;3;4;5;6;7;8;9;10;11;12;13;14",
            "Signal Intelligence (SIGINT) Reporting;116;1;2;3;4;5;6;7;8",
            "Direction Finding and Geolocation;117;1;2;3;4;5;6;7;8;9",
            "Radar;118;1;2;3;4;5;6;7;8;9;10",
            "National Collection Management;119;1;2;3;4;5;6;7;8;9;10;11",
            "Electronic Warfare (EW);120;1;2;3;4;5;6;7;8;9",
            "Electronic Warfare Support (ES);121;1;2;3;4;5",
            "Electronic Attack (EA);122;1;2;3;4;5;6;7;8;9;10;11",
            "Electronic Protect (EP);123;1;2;3;4;5;6;7;8;9",
            "Cyberspace Operations (CO);124;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;16;17;18",
            "Networking;125;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;16;17",
            "Military Deception (MILDEC);126;1;2;3;4;5;6;7;8;9",
            "Military Information Support Operations (MISO);127;1;2;3;4;5;6;7;8",
            "Information Assurance (IA);128;1;2;3;4;5;6;7;8;9;10;11;12;13;14",
            "Operations Security (OPSEC);129;1;2;3;4;5;6;7;8;9;10",
            "Publications and Mission Associated Directives;130;1;2;3;4;5",
            "Communications – General – Information Warfare;131;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;16;17;18;19;20;21;22;23;24;25;26;27;28",
            "Naval Special Warfare Tactical Information Operations (TIO);132;1;2;3;4;5;6;7;8;9;10;11",
            "Administrative, Readiness and Logistical Reporting Fundamentals;133;1;2;3;4;5;6;7;8"
        };

        [JsonIgnore]
        public string Name
        {
            get => "NAVEDTRA 43357-2A";
            set { }
        }

        [JsonIgnore]
        public string Date
        {
            get => "November 2016";
            set { }
        }

        public List<Section> Sections { get; set; }

        public TwoAlpha()
        {
            Sections = new List<Section>();
            PqsHelpers.AddSections(Sections, twoAlphaSectionsByLine);
        }

        public string ToJson() => JsonConvert.SerializeObject(this);
    }
}
