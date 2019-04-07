using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaLibraryMaintenance.enums;

namespace MediaLibraryMaintenance.BaseClasses
{
    /// <summary>
    /// Class that represents an unsorted media file
    /// </summary>
    public class SortMediaFile
    {
        /// <summary>
        /// Full windows file path to media file
        /// </summary>
        public string FullFilePath { get; set; }

        /// <summary>
        /// File name of the media file
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// DateTime when file download completed
        /// </summary>
        public DateTime FileCreated { get; set; }

        /// <summary>
        /// Size of the media file on disk
        /// </summary>
        public double FileSize { get; set; }

        /// <summary>
        /// File media type classification
        /// </summary>
        public MediaClassifications Classification { get; set; }

        /// <summary>
        /// Document type (extension) of media file
        /// </summary>
        public MediaFileType FileType { get; set; }

        /// <summary>
        /// Create a new SortMediaFile from a FileInfo object
        /// </summary>
        /// <param name="_file">FileInfo object to drop</param>
        public SortMediaFile(FileInfo _file)
        {
            FullFilePath = _file.FullName;
            FileName = _file.Name;
            FileSize = _file.Length;
            FileCreated = _file.CreationTime;
            Classification = MediaClassifications.Unclassified_File;
            FileType = MediaFileType.
        }

        public SortMediaFile()
        {

        }
    }
}
