﻿using System.Collections.Generic;
using System.Linq;

namespace NavyPqsWindows.Models
{
    public class CwoPqs
    {
        private readonly string[] twoBravoSectionsByLine =
        {
            "Safety Precautions Fundamentals;101;1;2;3;4;5;6;7;8",
            "Maintenance Fundamentals;102;1;2;3;4;5;6",
            "Security Fundamentals;103;1;2;3;4;5;6;7;8",
            "Leadership Fundamentals;104;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;16;17;18;19;20",
            "Terminology Fundamentals;105;1",
            "U.S. Navy Org. and Naval/Joint Platforms;106;1;2;3;4;5;6.a;6.b;6.c;6.d;6.e;6.f;6.g;6.h;6.i;6.j;7;8;9;10;11;12",
            "Navy Planning Process Fundamentals;107;1;2;3;4;5;6;7;8;9;10;11;12;13",
            "Roe and Authorities Fundamentals;108;1;2;3;4;5;6;7",
            "Intelligence Oversight Fundamentals;109;1;2;3;4;5;6",
            "Radio Prop and Signal Char. Fundamentals;110;1;2;3;4;5;6;7;8;9;10;11",
            "Radar Fundamentals;111;1;2;3;4;5;6;7;8;9",
            "Electronic Warfare Fundamentals;112;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;16;17",
            "Antiship Ship Missile Defense (ASMD) Fundamentals;113;1;2;3;4;5;6;7;8;9;10",
            "Countering Intelligence, Surveillance, Reconnaissance, and Targeting (C-ISRT) Fundamentals;114;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;16",
            "National Collection Management Fundamentals;115;1;2;3;4;5;6;7;8;9;10;11",
            "Distributed Signals Intelligence (SIGINT) Operations (DSO) Fundamentals;116;1;2;3;4;5;6;7;8",
            "Direction Finding and Geolocation Fundamentals;117;1;2;3;4;5;6;7;8",
            "Signal Intelligence (SIGINT) Reporting Fundamentals;118;1;2;3;4;5;6;7",
            "Cryptologic Warfare Systems Fundamentals;119;1;2;3;4;5;6;7",
            "Communications Fundamentals;120;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15",
            "Networking Fundamentals;121;1;2;3;4;5;6;7;8;9;10;11",
            "Cybersecurity Fundamentals;122;1;2;3;4;5;6;7",
            "Cyberspace Operations Fundamentals;123;1;2;3;4;5;6;7;8;9",
            "National/Theater Level Support Fundamentals;124;1;2;3;4;5;6",
            "Fleet Cryptologic Operations Fundamentals;125;1;2;3;4;5;6;7;8;9;10",
            "Naval Special Warfare Tactical Information Operations (TIO) Fundamentals;126;1;2;3;4;5;6",
            "Information Operations Fundamentals;127;1;2;3;4;5;6;7",
            "Military Deception (MILDEC) Fundamentals;128;1;2;3;4;5;6;7;8;9;10;11;12",
            "Military Information Support Operations (MISO) Fundamentals;129;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15",
            "Operations Security (OPSEC) Fundamentals;130;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;16",
            "Publications and Mission Associated Directives Fundamentals;131;1;2;3;4;5"
        };

        public string Name { get; set; }

        public List<Section> Sections { get; set; }

        public static CwoPqs NewTwoBravo()
        {
            var newTwoBravo = new CwoPqs
            {
                Name = "NAVEDTRA 43357-2B - 14 March 2020",
                Sections = new List<Section>()
            };
            return NewPqs(newTwoBravo, newTwoBravo.twoBravoSectionsByLine);
        }

        private static CwoPqs NewPqs(CwoPqs pqs, string[] a)
        {
            AddSections(pqs, a);
            return pqs;
        }

        private static void AddSections(CwoPqs pqs, string[] a)
        {
            int sectionCounter = 0;
            for (int j = 0; j < a.Count(); j++)
            {
                var values = a[j].Split(';');
                pqs.Sections.Add(new Section
                {
                    Name = values[0],
                    Number = values[1]
                });

                var signatureCount = values.Count() - 2;
                pqs.Sections[sectionCounter].LineItem = new string[signatureCount];
                pqs.Sections[sectionCounter].Signed = new bool[signatureCount];

                for (int i = 0; i < signatureCount; i++)
                {
                    pqs.Sections[sectionCounter].LineItem[i] = values[i + 2];
                    pqs.Sections[sectionCounter].Signed[i] = false;
                }

                sectionCounter++;
            }
        }
    }
}
