using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public static class ListExportingtk
    {
        public static List<Exportingtk> ExportingtkList { get; set; }
        static ListExportingtk()
        {
            ExportingtkList = new List<Exportingtk>();
        }
    }
}
