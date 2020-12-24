using System;
using System.Collections.Generic;
using System.Linq;
using NavyPqs.Models;
using NavyPqs.Models.Cwo;
using NavyPqs.Services;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace NavyPqsWindowsTests.Services
{
    [TestFixture]
    public class CwoPqs2Ato2BTests
    {
        private static bool IsConversionReportEqual(ConversionReport a, ConversionReport b)
        {
            if (a.FullChecked.Count != b.FullChecked.Count) return false;
            if (a.Partial.Count != b.Partial.Count) return false;
            if (a.Notes.Count != b.Notes.Count) return false;

            for (int i = 0; i < a.FullChecked.Count; i++)
            {
                if (a.FullChecked[i].NewItem != b.FullChecked[i].NewItem || a.FullChecked[i].OldItem != b.FullChecked[i].OldItem) return false;
            }

            for (int j = 0; j < a.Partial.Count; j++)
            {
                if (a.Partial[j].Item1.NewItem != b.Partial[j].Item1.NewItem || a.Partial[j].Item1.OldItem != b.Partial[j].Item1.OldItem || a.Partial[j].Item2 != b.Partial[j].Item2) return false;
            }

            for (int k = 0; k < a.Notes.Count; k++)
            {
                if (a.Notes[k] != b.Notes[k]) return false;
            }

            return true;
        }

        private static void SetSignatureFor(string section, IPqs pqs)
        {

            string[] sectionSplit = section.Split('.');

            string sectionNumber = sectionSplit[0];
            string signatureItem = sectionSplit[1];

            var linq = pqs.Sections
                    .Where(
                        x => x.Number == sectionNumber);

            var sectionIndex = pqs.Sections.FindIndex(a => a.Number == sectionNumber);
            var signedIndex = Array.IndexOf(pqs.Sections[sectionIndex].LineItem, signatureItem);

            pqs.Sections[sectionIndex].Signed[signedIndex] = true;
        }
        
        [Test]
        public void DoesSomething()
        {
            var z = (
                new ConversionDetails("103.1", "103.1"),
                @"DISS;DODCAF;SCATTERED CASTLES;NP2/EQIP;Classification Advisory Officer;Adds /DCA to OCA"
            );
            var expected = new ConversionReport()
            {
                Notes = new List<string>
                {
                    "This conversion is only for 2A to 2B"
        },
                FullChecked = new List<ConversionDetails>
                {
                    new ConversionDetails("101.1", "101.1"),
                    new ConversionDetails("101.2", "101.2"),
                    new ConversionDetails("101.3", "101.3")
                },
                Partial = new List<(ConversionDetails, string)> { z }
            };
            var twoAlpha = new TwoAlpha();
            var twoBravo = new TwoBravo();
            

            SetSignatureFor("101.1", twoAlpha);
            SetSignatureFor("101.2", twoAlpha);
            SetSignatureFor("101.3", twoAlpha);
            SetSignatureFor("103.1", twoAlpha);

            var actual = ConvertPqs.Convert(twoAlpha, twoBravo, new CwoPqs2Ato2B());

            Assert.True(twoBravo.Sections[0].Signed[0]);
            Assert.True(twoBravo.Sections[0].Signed[1]);
            Assert.True(twoBravo.Sections[0].Signed[2]);
            Assert.True(IsConversionReportEqual(expected, actual));
        }

        [Test]
        public void DoesSomething2()
        {
            var expected = new ConversionReport()
            {
                Notes = new List<string>
                {
                    "This conversion is only for 2A to 2B"
                },
                FullChecked = new List<ConversionDetails>
                {
                    new ConversionDetails("123.1 & 123.2", "112.16")
                },
                Partial = new List<(ConversionDetails, string)>()
            };
            var twoAlpha = new TwoAlpha();
            var twoBravo = new TwoBravo();


            SetSignatureFor("123.1", twoAlpha);
            SetSignatureFor("123.2", twoAlpha);

            var actual = ConvertPqs.Convert(twoAlpha, twoBravo, new CwoPqs2Ato2B());

            Assert.True(twoBravo.Sections[11].Signed[15]);
            Assert.True(IsConversionReportEqual(expected, actual));
        }
    }
}
