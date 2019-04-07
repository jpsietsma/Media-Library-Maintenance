using MediaLibraryMaintenance.enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibraryMaintenance.BaseClasses
{
    /// <summary>
    /// Base class for a video media file
    /// </summary>
    public class MediaFile
    {
        /// <summary>
        /// Full windows path to the media file
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Size on disk of media file
        /// </summary>
        public double FileSize { get; set; }

        /// <summary>
        /// Windows file name of media file
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Enum value representing media file type
        /// </summary>
        public MediaClassifications FileClassification { get; set; }

        public MediaFile()
        {

        }

        //Move file from source to destination
        /// <summary>
        /// Move file to destination path
        /// </summary>
        /// <param name="destination">File path where file will be moved</param>
        /// <returns></returns>
        public bool MoveFileTo(string destination)
        {
            bool finalStatus = false;

            try
            {
                File.Move(FilePath, destination);
                finalStatus = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return finalStatus;
        }

        /// <summary>
        /// Move media file to destination
        /// </summary>
        /// <param name="_file">MediaFile to move to destination</param>
        /// <param name="destination">Destination path MediaFile will be moved to</param>
        /// <returns> true if move successful</returns>
        public bool MoveFileTo(MediaFile _file, string destination)
        {
            bool finalStatus = false;

            try
            {
                File.Move(_file.FilePath, destination);
                finalStatus = true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            return finalStatus;
        }

        public bool Get

    }
}
