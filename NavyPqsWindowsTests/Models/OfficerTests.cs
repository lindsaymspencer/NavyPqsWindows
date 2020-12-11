using NavyPqsWindows.Models;
using NUnit.Framework;

namespace NavyPqsTestFixture.Models
{
    public class OfficerTests
    {
        [TearDown]
        public void TearDown()
        {
            NavyPqsWindows.Services.Tests.FileIoForTests.TearDown();
        }

        [Test]
        public void CreatesTwoBravoPqs()
        {
            var expected = "{\"Rank\":\"LTJG\",\"FirstName\":\"Lindsay\",\"LastName\":\"Spencer\",\"CWO.TwoBravo\":{\"Sections\":[{\"Number\":\"101\",\"Signed\":[false,false,false,false,false,false,false,false]},{\"Number\":\"102\",\"Signed\":[false,false,false,false,false,false]},{\"Number\":\"103\",\"Signed\":[false,false,false,false,false,false,false,false]},{\"Number\":\"104\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"105\",\"Signed\":[false]},{\"Number\":\"106\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"107\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"108\",\"Signed\":[false,false,false,false,false,false,false]},{\"Number\":\"109\",\"Signed\":[false,false,false,false,false,false]},{\"Number\":\"110\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"111\",\"Signed\":[false,false,false,false,false,false,false,false,false]},{\"Number\":\"112\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"113\",\"Signed\":[false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"114\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"115\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"116\",\"Signed\":[false,false,false,false,false,false,false,false]},{\"Number\":\"117\",\"Signed\":[false,false,false,false,false,false,false,false]},{\"Number\":\"118\",\"Signed\":[false,false,false,false,false,false,false]},{\"Number\":\"119\",\"Signed\":[false,false,false,false,false,false,false]},{\"Number\":\"120\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"121\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"122\",\"Signed\":[false,false,false,false,false,false,false]},{\"Number\":\"123\",\"Signed\":[false,false,false,false,false,false,false,false,false]},{\"Number\":\"124\",\"Signed\":[false,false,false,false,false,false]},{\"Number\":\"125\",\"Signed\":[false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"126\",\"Signed\":[false,false,false,false,false,false]},{\"Number\":\"127\",\"Signed\":[false,false,false,false,false,false,false]},{\"Number\":\"128\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"129\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"130\",\"Signed\":[false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false]},{\"Number\":\"131\",\"Signed\":[false,false,false,false,false]}]}}";
            var officer = new Officer {Rank = "LTJG", FirstName = "Lindsay", LastName = "Spencer"};
            var actual = officer.ToJson();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ExportsTwoBravoPqs()
        {
            NavyPqsWindows.Services.Tests.FileIoForTests.CreateTestDirectory();
            var officer = new Officer();
            var actual = officer.Export(
                NavyPqsWindows.Services.Tests.FileIoForTests.TestDirectory);

            Assert.IsTrue(actual);
        }
    }
}