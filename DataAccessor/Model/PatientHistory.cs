using BLToolkit.DataAccess;
using BLToolkit.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    [TableName("PatientHistory")]
    public class PatientHistory
    {
        [MapField("ID"), PrimaryKey, NonUpdatable]
        public int ID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime CheckDate { get; set; }
        public string Description { get; set; }
        public string Medicine { get; set; }
        public DateTime AppointmentDate { get; set; }

        [NonUpdatable]
        public string PatientName { get; set; }
        [NonUpdatable]
        public string DoctorName { get; set; }
    }
}
