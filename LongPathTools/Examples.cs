using System;


namespace LongPathTools
{
    public static class Examples
    {
        static void Main(string[] args)
        {

        //
        // ──────────────────────────────────────────────────────── I ──────────
        //  :::::: E X A M P L E S : :  :   :    :     :        :          :
        // ──────────────────────────────────────────────────────────────────
        //


            //
            // ─── PATH EXAMPLES ──────────────────────────────────────────────────────────────
            //

            // Path example for a local file/directory
            // @"\\?\C:\Directory\DeeperDirectory\ExtremelyLongPath.PDF"
            // @"\\?\C:\Directory\DeeperDirectory\"

            // Path example for a file/directory on a shared network directory
            // "\\?\UNC\share\Directory\DeeperDirectory\ExtremelyLongPath.pdf"
            // "\\?\UNC\share\Directory\DeeperDirectory\"



            //
            // ─── USAGE EXAMPLES ─────────────────────────────────────────────────────────────
            //
        
            //File.Exists()
            bool fileExists = LongPathHelpers.FileExists(@"\\?\C:\Directory\DeeperDirectory\ExtremelyLongPath\FileToCheckExistenceOf.pdf");
            Console.WriteLine($"File Exists: {fileExists}");

            //Directory.Exists()
            bool directoryExists = LongPathHelpers.DirectoryExists(@"\\?\UNC\share\Directory\DeeperDirectory\ExtremelyLongPath\");
            Console.WriteLine($"Directory Exists: {directoryExists}");

            //File.Copy()
            bool fileCopy = LongPathHelpers.FileCopy(@"\\?\UNC\share\OldDirectory\DeeperOldDirectory\ExtremelyLongPath\FileToCopy.pdf", @"\\?\C:\OldDirectory\DeeperNewDirectory\ExtremelyLongPath\CopiedFile.PDF", false);
            Console.WriteLine(fileCopy ? "File Copy: Success" : "File Copy: Fail");

            //File.Move()
            bool fileMove = LongPathHelpers.FileMove(@"\\?\C:\Directory\DeeperDirectory\ExtremelyLongPath\FileToMove.pdf", @"\\?\UNC\share\NewDirectory\DeeperNewDirectory\ExtremelyLongPath\MovedFile.pdf");
            Console.WriteLine(fileMove ? "File Move: Success" : "File Move: Fail");

            //File.Delete()
            bool fileDelete = LongPathHelpers.FileDelete(@"\\?\C:\Directory\DeeperDirectory\ExtremelyLongPath\FileToDelete.pdf");
            Console.WriteLine(fileDelete ? "File Delete: Success" : "File Delete: Fail");

        }
    }
}