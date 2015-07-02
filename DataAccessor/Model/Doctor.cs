using BLToolkit.DataAccess;
using BLToolkit.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    [TableName("Doctor")]
    public class Doctor
    {
        [MapField("ID"), PrimaryKey, NonUpdatable]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
