﻿using NUnit.Framework;
using System.IO;

namespace NavyPqsWindows.Services.Tests
{
    public class FileHelperTests
    {
        [TearDown]
		public void TearDown()
		{
			FileIoForTests.TearDown();
		}

        [Test]
		public void CreatesFileInExistingDirectory()
		{
			FileIoForTests.CreateTestDirectory();
			FileIoForTests.TestFileFullName = Path.Combine(FileIoForTests.TestDirectory,
				FileIoForTests.TestFileName + ".txt");

			FileHelper.WriteTo(FileIoForTests.TestFileFullName, "Hello World");
			bool actual = File.Exists(FileIoForTests.TestFileFullName);

			Assert.IsTrue(actual);
		}

		[Test]
		public void CreatesFileInNonExistingDirectory()
		{
			// Setup
			FileIoForTests.CleanUpTestDirectory();
			FileIoForTests.TestFileFullName = Path.Combine(FileIoForTests.TestDirectory,
				FileIoForTests.TestFileName + ".txt");
			FileIoForTests.deleteDirectory = true;

			FileHelper.WriteTo(FileIoForTests.TestFileFullName, "Hello World");
			bool actual = File.Exists(FileIoForTests.TestFileFullName);

			Assert.IsTrue(actual);
		}

		[Test]
		public void WritesOverFile()
		{
			// Setup
			FileIoForTests.CreateTestFile(".txt");
			string contents = "Hello World.";
			string newContents = "And Universe.";
			FileHelper.WriteTo(FileIoForTests.TestFileFullName, contents);
			var actual = FileIoForTests.ReadTestFileContents();

			Assert.AreEqual(contents, actual);

			FileHelper.WriteOver(FileIoForTests.TestFileFullName, newContents);

			actual = FileIoForTests.ReadTestFileContents();
			Assert.AreEqual(newContents, actual);
		}

		[Test]
		public void AppendsToFile()
		{
			// Setup
			FileIoForTests.CreateTestFile(".txt");
			string contents = "Hello World.";
			string newContents = "And Universe.";
			FileHelper.WriteTo(FileIoForTests.TestFileFullName, contents);
			var actual = FileIoForTests.ReadTestFileContents();

			Assert.AreEqual(contents, actual);

			FileHelper.WriteTo(FileIoForTests.TestFileFullName, newContents);

			actual = FileIoForTests.ReadTestFileContents();
			Assert.AreEqual(contents + newContents, actual);
		}
	}
}
