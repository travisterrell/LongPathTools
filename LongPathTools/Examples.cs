using System;

namespace LongPathTools
{
    public static class Examples
    {
        static void Main(string[] args)
        {
            //File.Exists()
            bool fileExists = LongPathHelpers.FileExists(@"\\?\UNC\fs-lrar-01\Programmers\Systems Assurance\VestcomProofingService\Proofs\ALBERTSONS CO. INC. SEATTLE\OriginalPDFs\abcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyz\ALBERTSONSCO-INC-SEATTLE-1026=040024=SEATTLE_27_MTN_20181029_20181025-AlbertsonsCoInc-SEATTLESTACKZSNAPISM12UP-760802-AUB11A-10260411244031[01586].pdf");
            Console.WriteLine($"File Exists: {fileExists}");

            //Directory.Exists()
            bool directoryExists = LongPathHelpers.DirectoryExists(@"\\?\UNC\fs-lrar-01\Programmers\");
            Console.WriteLine($"Directory Exists: {directoryExists}");

            //File.Copy()
            bool fileCopy = LongPathHelpers.FileCopy(@"\\?\UNC\fs-lrar-01\Programmers\Systems Assurance\VestcomProofingService\Proofs\ALBERTSONS CO. INC. SEATTLE\OriginalPDFs\abcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyz\ALBERTSONSCO-INC-SEATTLE-1026=040024=SEATTLE_27_MTN_20181029_20181025-AlbertsonsCoInc-SEATTLESTACKZSNAPISM12UP-760802-AUB11A-10260411244031[01586].pdf", @"\\?\C:\test\test.PDF", false);
            Console.WriteLine(fileCopy ? "File Copy: Success" : "File Copy: Fail");

            //File.Move()
            bool fileMove = LongPathHelpers.FileMove(@"\\?\UNC\fs-lrar-01\Programmers\Systems Assurance\VestcomProofingService\Proofs\ALBERTSONS CO. INC. SEATTLE\OriginalPDFs\abcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyz\ALBERTSONSCO-INC-SEATTLE-1026=040024=SEATTLE_27_MTN_20181029_20181025-AlbertsonsCoInc-SEATTLESTACKZSNAPISM12UP-760802-AUB11A-10260411244031[01586].pdf", @"\\?\C:\test\test.PDF");
            Console.WriteLine(fileMove ? "File Move: Success" : "File Move: Fail");

            //File.Delete()
            bool fileDelete = LongPathHelpers.FileDelete(@"\\?\UNC\fs-lrar-01\Programmers\Systems Assurance\VestcomProofingService\Proofs\ALBERTSONS CO. INC. SEATTLE\OriginalPDFs\abcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyz\ALBERTSONSCO-INC-SEATTLE-1026=040024=SEATTLE_27_MTN_20181029_20181025-AlbertsonsCoInc-SEATTLESTACKZSNAPISM12UP-760802-AUB11A-10260411244031[01586].pdf");
            Console.WriteLine(fileDelete ? "File Delete: Success" : "File Delete: Fail");

        }
    }
}
