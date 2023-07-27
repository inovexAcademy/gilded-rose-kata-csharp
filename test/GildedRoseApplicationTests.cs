namespace GildedRoseTests
{

    using GildedRose;
    using NUnit.Framework;

    public class GildedRoseApplicationTests
    {
        private const String testFileName = "test.txt";
        private const String goldenMasterFileName = "GoldenMaster.txt";
        private TextWriter defaultConsoleOut = Console.Out;
        private FileStream fileStream;
        private StreamWriter streamWriter;

        [Test]
        public void Run_ComparedToGoldenMaster_ShouldReturnSameValues()
        {
            RedirectConsoleOutToFile();
            GildedRoseApplication app = new GildedRoseApplication();

            app.Run();

            CleanupRedirection();
            string actualOutput = File.ReadAllText(testFileName);
            string goldenMaster = File.ReadAllText(goldenMasterFileName);
            Assert.AreEqual(goldenMaster, actualOutput);
        }

        private void RedirectConsoleOutToFile()
        {
            fileStream = new FileStream(testFileName, FileMode.OpenOrCreate, FileAccess.Write);
            streamWriter = new StreamWriter(fileStream);

            Console.SetOut(streamWriter);
        }

        private void CleanupRedirection()
        {
            streamWriter.Close();
            fileStream.Close();
            Console.SetOut(defaultConsoleOut);
        }
    }
}