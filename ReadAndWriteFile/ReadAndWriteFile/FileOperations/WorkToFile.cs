namespace ReadAndWriteFile.FileOperations
{
    public static class WorkToFile
    {
        /// <summary>
        /// Создаем дерикторию
        /// </summary>
        /// <param name="path"></param>
        public static void CreateDirectory(string path)
        {
            try
            {
                var dir1 = new DirectoryInfo(path);
                if (!dir1.Exists)
                {
                    dir1.Create();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Создаем файл
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="fileNames"></param>
        public static void CreateFiles(string directory, IEnumerable<string> fileNames)
        {
            foreach (var fileName in fileNames)
            {
                try
                {
                    using var streamWriter = File.CreateText(Path.Combine(directory, fileName));
                    streamWriter.WriteLine(fileName);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// Дополнить текущей датой
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="fileNames"></param>
        public static void UpdateFiles(string directory, IEnumerable<string> fileNames)
        {
                       
            foreach (var fileName in fileNames)
            {
                try
                {
                    using var streamWriter = File.AppendText(Path.Combine(directory, fileName));
                    streamWriter.WriteLine(DateTime.Now);
                   
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// Прочитать все файлы и вывести на консоль
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="fileNames"></param>
        public static void ReadFiles(string directory, IEnumerable<string> fileNames)
        {
            foreach (var fileName in fileNames)
            {
                try
                {
                    var fullPath = Path.Combine(directory, fileName);
                    using var streamReader = File.OpenText(fullPath);
                    Console.WriteLine($"Full filename: {fullPath}, content:\n{streamReader.ReadToEnd()}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

    }
}