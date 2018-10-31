using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using LongPathTools;

namespace LongPathProof
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fileExists = LongPathHelpers.FileExists(@"\\?\UNC\fs-lrar-01\Programmers\Systems Assurance\VestcomProofingService\Proofs\ALBERTSONS CO. INC. SEATTLE\OriginalPDFs\abcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyz\ALBERTSONSCO-INC-SEATTLE-1026=040024=SEATTLE_27_MTN_20181029_20181025-AlbertsonsCoInc-SEATTLESTACKZSNAPISM12UP-760802-AUB11A-10260411244031[01586].pdf");
            Console.WriteLine($"File Exists: {fileExists}");

            bool directoryExists = LongPathHelpers.DirectoryExists(@"\\?\UNC\fs-lrar-01\Programmers\");
            Console.WriteLine($"Directory Exists: {directoryExists}");

            bool fileCopy = LongPathHelpers.FileCopy(@"\\?\UNC\fs-lrar-01\Programmers\Systems Assurance\VestcomProofingService\Proofs\ALBERTSONS CO. INC. SEATTLE\OriginalPDFs\abcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyz\ALBERTSONSCO-INC-SEATTLE-1026=040024=SEATTLE_27_MTN_20181029_20181025-AlbertsonsCoInc-SEATTLESTACKZSNAPISM12UP-760802-AUB11A-10260411244031[01586].pdf", @"\\?\C:\test\test.PDF", false);
            Console.WriteLine($"File Copy: {fileCopy}");

            bool fileMove = LongPathHelpers.FileMove(@"\\?\UNC\fs-lrar-01\Programmers\Systems Assurance\VestcomProofingService\Proofs\ALBERTSONS CO. INC. SEATTLE\OriginalPDFs\abcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyz\ALBERTSONSCO-INC-SEATTLE-1026=040024=SEATTLE_27_MTN_20181029_20181025-AlbertsonsCoInc-SEATTLESTACKZSNAPISM12UP-760802-AUB11A-10260411244031[01586].pdf", @"\\?\C:\test\test.PDF");
            Console.WriteLine($"File Move: {fileMove}");

            bool fileDelete = LongPathHelpers.FileDelete(@"\\?\UNC\fs-lrar-01\Programmers\Systems Assurance\VestcomProofingService\Proofs\ALBERTSONS CO. INC. SEATTLE\OriginalPDFs\abcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyzabcdefghjklmnoprstuvwxyz\ALBERTSONSCO-INC-SEATTLE-1026=040024=SEATTLE_27_MTN_20181029_20181025-AlbertsonsCoInc-SEATTLESTACKZSNAPISM12UP-760802-AUB11A-10260411244031[01586].pdf");
            Console.WriteLine($"File Delete: {fileDelete}");

        }
    }
}
