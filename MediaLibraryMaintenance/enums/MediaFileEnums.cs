using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibraryMaintenance.enums
{
        /// <summary>
        /// Enum of media type classifications
        /// </summary>
        public enum MediaClassifications
        {
            /// <summary>
            /// Media file representing an episode of a Television Show
            /// </summary>
            Television_Episode = 1,

            /// <summary>
            /// Media file representing a single movie
            /// </summary>
            Movie = 2,

            /// <summary>
            /// Media file representing a single song
            /// </summary>
            Music = 3,

            /// <summary>
            /// Media file representing a single photo
            /// </summary>
            Picture = 4,

            /// <summary>
            /// Media file that still needs to be classified from the sort folder
            /// </summary>
            Unclassified_File = 5
        }

        /// <summary>
        /// Enum of media file types
        /// </summary>
        public enum MediaFileType
        {
            public KeyValuePair<string, string> _fileTypes = new KeyValuePair<string, string>();

        }        
}
