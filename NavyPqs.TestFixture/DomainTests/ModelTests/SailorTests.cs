﻿using NavyPqs.Domain.Models;
using NUnit.Framework;

namespace NavyPqs.TestFixture.DomainTests.ModelTests
{
    public class SailorTests
    {

        [Test]
        public void CreatesWithTwoAlphaPqs()
        {
            var expected = "{\"Rank\":\"LTJG\",\"FirstName\":\"Jane\",\"LastName\":\"Doe\",\"Pqses\":[{\"Pqs\":\"CWO\",\"Version\":\"2A\",\"Sections\":[{\"Number\":\"101\",\"Signed\":[false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"102\",\"Signed\":[false,false,false,false,false,false]},{\"Number\":\"103\",\"Signed\":[false,false,false,false,false,false,false,false]},{\"Number\":\"104\",\"Signed\":[false,false,false,false,false,false,false,false]},{\"Number\":\"105\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"106\",\"Signed\":[false]},{\"Number\":\"107\",\"Signed\":[false,false,false,false,false,false,false,false]},{\"Number\":\"108\",\"Signed\":[false,false]},{\"Number\":\"109\",\"Signed\":[false,false,false,false,false,false,false]},{\"Number\":\"110\",\"Signed\":[false,false,false,false,false,false,false]},{\"Number\":\"111\",\"Signed\":[false,false]},{\"Number\":\"112\",\"Signed\":[false,false,false,false,false]},{\"Number\":\"113\",\"Signed\":[false,false,false,false,false,false,false,false,false]},{\"Number\":\"114\",\"Signed\":[false,false,false,false,false,false]},{\"Number\":\"115\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"116\",\"Signed\":[false,false,false,false,false,false,false,false]},{\"Number\":\"117\",\"Signed\":[false,false,false,false,false,false,false,false,false]},{\"Number\":\"118\",\"Signed\":[false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"119\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"120\",\"Signed\":[false,false,false,false,false,false,false,false,false]},{\"Number\":\"121\",\"Signed\":[false,false,false,false,false]},{\"Number\":\"122\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"123\",\"Signed\":[false,false,false,false,false,false,false,false,false]},{\"Number\":\"124\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"125\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"126\",\"Signed\":[false,false,false,false,false,false,false,false,false]},{\"Number\":\"127\",\"Signed\":[false,false,false,false,false,false,false,false]},{\"Number\":\"128\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"129\",\"Signed\":[false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"130\",\"Signed\":[false,false,false,false,false]},{\"Number\":\"131\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"132\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"133\",\"Signed\":[false,false,false,false,false,false,false,false]}]}]}";
            var sailor = new Sailor(0, "LTJG", "Jane", "Doe");
            sailor.Pqses.Add(new Domain.Models.Cwo.TwoAlpha());
            var actual = sailor.ToJson();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CreatesWithTwoBravoPqs()
        {
            var expected = "{\"Rank\":\"LTJG\",\"FirstName\":\"Jane\",\"LastName\":\"Doe\",\"Pqses\":[{\"Pqs\":\"CWO\",\"Version\":\"2B\",\"Sections\":[{\"Number\":\"101\",\"Signed\":[false,false,false,false,false,false,false,false]},{\"Number\":\"102\",\"Signed\":[false,false,false,false,false,false]},{\"Number\":\"103\",\"Signed\":[false,false,false,false,false,false,false,false]},{\"Number\":\"104\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"105\",\"Signed\":[false]},{\"Number\":\"106\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"107\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"108\",\"Signed\":[false,false,false,false,false,false,false]},{\"Number\":\"109\",\"Signed\":[false,false,false,false,false,false]},{\"Number\":\"110\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"111\",\"Signed\":[false,false,false,false,false,false,false,false,false]},{\"Number\":\"112\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"113\",\"Signed\":[false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"114\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"115\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"116\",\"Signed\":[false,false,false,false,false,false,false,false]},{\"Number\":\"117\",\"Signed\":[false,false,false,false,false,false,false,false]},{\"Number\":\"118\",\"Signed\":[false,false,false,false,false,false,false]},{\"Number\":\"119\",\"Signed\":[false,false,false,false,false,false,false]},{\"Number\":\"120\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"121\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"122\",\"Signed\":[false,false,false,false,false,false,false]},{\"Number\":\"123\",\"Signed\":[false,false,false,false,false,false,false,false,false]},{\"Number\":\"124\",\"Signed\":[false,false,false,false,false,false]},{\"Number\":\"125\",\"Signed\":[false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"126\",\"Signed\":[false,false,false,false,false,false]},{\"Number\":\"127\",\"Signed\":[false,false,false,false,false,false,false]},{\"Number\":\"128\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"129\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"130\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"131\",\"Signed\":[false,false,false,false,false]}]}]}";
            var sailor = new Sailor(0, "LTJG", "Jane", "Doe");
            sailor.Pqses.Add(new Domain.Models.Cwo.TwoBravo());
            var actual = sailor.ToJson();

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void CreatesWithBothCwoPqs()
        {
            var expected = "{\"Rank\":\"LTJG\",\"FirstName\":\"Jane\",\"LastName\":\"Doe\",\"Pqses\":[{\"Pqs\":\"CWO\",\"Version\":\"2A\",\"Sections\":[{\"Number\":\"101\",\"Signed\":[false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"102\",\"Signed\":[false,false,false,false,false,false]},{\"Number\":\"103\",\"Signed\":[false,false,false,false,false,false,false,false]},{\"Number\":\"104\",\"Signed\":[false,false,false,false,false,false,false,false]},{\"Number\":\"105\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"106\",\"Signed\":[false]},{\"Number\":\"107\",\"Signed\":[false,false,false,false,false,false,false,false]},{\"Number\":\"108\",\"Signed\":[false,false]},{\"Number\":\"109\",\"Signed\":[false,false,false,false,false,false,false]},{\"Number\":\"110\",\"Signed\":[false,false,false,false,false,false,false]},{\"Number\":\"111\",\"Signed\":[false,false]},{\"Number\":\"112\",\"Signed\":[false,false,false,false,false]},{\"Number\":\"113\",\"Signed\":[false,false,false,false,false,false,false,false,false]},{\"Number\":\"114\",\"Signed\":[false,false,false,false,false,false]},{\"Number\":\"115\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"116\",\"Signed\":[false,false,false,false,false,false,false,false]},{\"Number\":\"117\",\"Signed\":[false,false,false,false,false,false,false,false,false]},{\"Number\":\"118\",\"Signed\":[false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"119\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"120\",\"Signed\":[false,false,false,false,false,false,false,false,false]},{\"Number\":\"121\",\"Signed\":[false,false,false,false,false]},{\"Number\":\"122\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"123\",\"Signed\":[false,false,false,false,false,false,false,false,false]},{\"Number\":\"124\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"125\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"126\",\"Signed\":[false,false,false,false,false,false,false,false,false]},{\"Number\":\"127\",\"Signed\":[false,false,false,false,false,false,false,false]},{\"Number\":\"128\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"129\",\"Signed\":[false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"130\",\"Signed\":[false,false,false,false,false]},{\"Number\":\"131\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"132\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"133\",\"Signed\":[false,false,false,false,false,false,false,false]}]},{\"Pqs\":\"CWO\",\"Version\":\"2B\",\"Sections\":[{\"Number\":\"101\",\"Signed\":[false,false,false,false,false,false,false,false]},{\"Number\":\"102\",\"Signed\":[false,false,false,false,false,false]},{\"Number\":\"103\",\"Signed\":[false,false,false,false,false,false,false,false]},{\"Number\":\"104\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"105\",\"Signed\":[false]},{\"Number\":\"106\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"107\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"108\",\"Signed\":[false,false,false,false,false,false,false]},{\"Number\":\"109\",\"Signed\":[false,false,false,false,false,false]},{\"Number\":\"110\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"111\",\"Signed\":[false,false,false,false,false,false,false,false,false]},{\"Number\":\"112\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"113\",\"Signed\":[false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"114\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"115\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"116\",\"Signed\":[false,false,false,false,false,false,false,false]},{\"Number\":\"117\",\"Signed\":[false,false,false,false,false,false,false,false]},{\"Number\":\"118\",\"Signed\":[false,false,false,false,false,false,false]},{\"Number\":\"119\",\"Signed\":[false,false,false,false,false,false,false]},{\"Number\":\"120\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"121\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"122\",\"Signed\":[false,false,false,false,false,false,false]},{\"Number\":\"123\",\"Signed\":[false,false,false,false,false,false,false,false,false]},{\"Number\":\"124\",\"Signed\":[false,false,false,false,false,false]},{\"Number\":\"125\",\"Signed\":[false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"126\",\"Signed\":[false,false,false,false,false,false]},{\"Number\":\"127\",\"Signed\":[false,false,false,false,false,false,false]},{\"Number\":\"128\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"129\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"130\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"131\",\"Signed\":[false,false,false,false,false]}]}]}";
            var sailor = new Sailor(0, "LTJG", "Jane", "Doe");
            sailor.Pqses.Add(new Domain.Models.Cwo.TwoAlpha());
            sailor.Pqses.Add(new Domain.Models.Cwo.TwoBravo());
            var actual = sailor.ToJson();

            Assert.AreEqual(expected, actual);
        }
    }
}
