using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace LongPathTools
{
    public class LongPathHelpers
    {

    //
    // ──────────────────────────────────────────────────────────────────── I ──────────
    //  :::::: I M P L E M E N T A T I O N : :  :   :    :     :        :          :
    // ──────────────────────────────────────────────────────────────────────────────
    //

        #region ─── WRAPPER METHODS ────────────────────────────────────────────────────────────

        
        public static bool FileExists(string path)
        {
            uint attributes = GetFileAttributes(path.StartsWith(@"\\?\") ? path : @"\\?\" + path); //This will not convert network paths. Network paths must use \\?\UNC\RemoteMachine, rather than \\?\\\RemoteMachine
            if (attributes != 0xFFFFFFFF)
            {
                return !((FileAttributes)attributes).HasFlag(FileAttributes.Directory);
            }

            return false;
        }

        public static bool DirectoryExists(string path)
        {
            uint attributes = GetFileAttributes(path.StartsWith(@"\\?\") ? path : @"\\?\" + path);
            if (attributes != 0xFFFFFFFF)
            {
                return ((FileAttributes)attributes).HasFlag(FileAttributes.Directory);
            }

            return false;
        }

        public static bool FileCopy(string source, string destination, bool copyIfExists)
        {
            return CopyFile(source.StartsWith(@"\\?\") ? source : @"\\?\" + source, destination.StartsWith(@"\\?\") ? destination : @"\\?\" + destination, copyIfExists);
        }

        public static bool FileMove(string source, string destination)
        {
            return MoveFile(source.StartsWith(@"\\?\") ? source : @"\\?\" + source, destination.StartsWith(@"\\?\") ? destination : @"\\?\" + destination);
        }

        public static bool FileDelete(string path)
        {
            return DeleteFile(path.StartsWith(@"\\?\") ? path : @"\\?\" + path);
        }

        #endregion


        #region ─── PRIVATE METHODS ────────────────────────────────────────────────────────────


        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern uint GetFileAttributes(string lpFileName);


        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode, BestFitMapping = false)]
        [ResourceExposure(ResourceScope.Machine)]
        private static extern bool CopyFile(string lpExistingFileName, string lpNewFileName, bool bFailIfExists);


        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode, BestFitMapping = false)]
        [ResourceExposure(ResourceScope.Machine)]
        private static extern bool MoveFile(string lpExistingFileName, string lpNewFileName);


        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool DeleteFile(string lpFileName);

        #endregion

    }
}