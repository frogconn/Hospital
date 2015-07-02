using BLToolkit.DataAccess;
using BLToolkit.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    [TableName("Patient")]
    public class Patient
    {
        [MapField("ID"), PrimaryKey, NonUpdatable]
        public int ID { get; set; }
        public string CitizenId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
    }
}
