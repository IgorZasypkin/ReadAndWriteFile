namespace ReadAndWriteFile.FileOperations
{
    public class RunOperation
    {
        
        private static readonly string Dir1 = Path.Combine("c:", "Otus", "TestDir1");
        private static readonly string Dir2 = Path.Combine("c:", "Otus", "TestDir2");
        private static readonly IEnumerable<string> FileNames = Enumerable.Range(1, 10).Select(n => $"File{n}.txt");

        public void RunOperationsToFile()
        {
            WorkToFile.CreateDirectory(Dir1);
            WorkToFile.CreateDirectory(Dir2);

            WorkToFile.CreateFiles(Dir1, FileNames);
            WorkToFile.CreateFiles(Dir2, FileNames);

            WorkToFile.UpdateFiles(Dir1, FileNames);
            WorkToFile.UpdateFiles(Dir2, FileNames);

            WorkToFile.ReadFiles(Dir1, FileNames);
            WorkToFile.ReadFiles(Dir2, FileNames);
        }

        
    }
}
