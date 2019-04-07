using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibraryMaintenance.ExceptionClasses
{
    public class InvalidSortDestination : Exception
    {
        public InvalidSortDestination() : base("File could not be moved because the destination path does not exist.")
        {
          
        }
    }
}
