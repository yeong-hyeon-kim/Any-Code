namespace PFolderFile
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(ReletivePath("../PFolderFile.exe"));
            Console.WriteLine(ReletivePath("../../PFolderFile.exe"));
            Console.WriteLine(ReletivePath("../../../PFolderFile.exe"));
        }

        /// <summary>
        /// 상대 경로를 절대 경로로 반환합니다.
        /// </summary>
        /// <param name="InternalPath"></param>
        /// <returns></returns>
        static string ReletivePath(string InternalPath = "")
        {
            InternalPath = InternalPath.Replace("/", @"\");
            return Path.GetFullPath(InternalPath);
        }

        #region 파일(File)

        /// <summary>
        /// 파일 존재 여부를 확인합니다.
        /// </summary>
        /// <param name="sPath">경로(Path)</param>
        /// <returns></returns>
        static bool CheckFile(string sPath)
        {
            return File.Exists(sPath);
        }

        /// <summary>
        /// 파일을 생성합니다.
        /// </summary>
        /// <param name="sPath">확장자를 포함한 파일 경로(Path)</param>
        /// <param name="Content"></param>
        static void CreateFile(string sPath)
        {
            File.Create(sPath);
        }

        /// <summary>
        /// 파일을 읽어옵니다.
        /// </summary>
        /// <param name="sPath">경로(Path)</param>
        /// <param name="sValue">파일 내용</param>
        static void ReadFile(string sPath, out string sValue)
        {
            sValue = File.ReadAllText(sPath);
        }

        /// <summary>
        /// 파일에 내용을 씁니다.
        /// </summary>
        /// <param name="sPath">경로(Path)</param>
        /// <param name="Method">쓰기 방법(Method) 선택</param>
        /// <param name="sContent">값(Value)</param>
        static void WriteFile(string sPath, string Method, string sContent)
        {
            switch (Method)
            {
                case "Append":
                    File.AppendAllText(sPath, sContent);
                    break;
                case "Override":
                    File.WriteAllText(sPath, sContent);
                    break;
            }
        }

        /// <summary>
        /// 파일을 제거합니다.
        /// </summary>
        /// <param name="sPath">경로(Path)</param>
        static void DeleteFile(string sPath)
        {
            File.Delete(sPath);
        }

        #endregion

        #region 폴더(디렉토리 : Directory)
        /// <summary>
        /// 폴더(디렉토리)를 생성합니다.
        /// </summary>
        /// <param name="sPath">경로(Path)</param>
        static void CreateFolder(string sPath)
        {
            Directory.CreateDirectory(sPath);
        }

        /// <summary>
        /// 폴더(디렉토리)가 존재하지 않으면 생성합니다.
        /// </summary>
        /// <param name="sPath">경로(Path)</param>
        static void CheckFolder(string sPath)
        {
            if (!Directory.Exists(sPath))
            {
                Directory.CreateDirectory(sPath);
            }
        }

        /// <summary>
        /// 폴더(디렉토리)를 제거합니다.
        /// </summary>
        /// <param name="sPath"></param>
        static void DeleteFolder(string sPath)
        {
            Directory.Delete(sPath);
        }

        /// <summary>
        /// 대상 경로의 하위 폴더(디렉토리)들을 가져옵니다.
        /// </summary>
        /// <param name="sPath">경로(Path)</param>
        /// <param name="saFolders">디렉토리 배열을 저장할 변수</param>
        static void GetFolders(string sPath, out string[] saFolders)
        {
            saFolders = Directory.GetDirectories(sPath);
        }

        /// <summary>
        /// 대상 폴더(디렉토리)에 포함된 파일들을 가져옵니다.
        /// </summary>
        /// <param name="sPath">경로(Path)</param>
        /// <param name="saFiles">파일 배열을 저장할 변수</param>
        static void GetFolderFiles(string sPath, out string[] saFiles)
        {
            saFiles = Directory.GetFiles(sPath);
        }
        #endregion
    }
}