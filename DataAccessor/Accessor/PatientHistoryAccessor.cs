using BLToolkit.Data;
using BLToolkit.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class PatientHistoryAccessor
    {
        public List<PatientHistory> FindAll()
        {
            using (var db = new DbManager())
            {
                            return db
                              .SetCommand(@"select ph.*,p.Name PatientName,d.Name DoctorName
                                    from PatientHistory ph inner join Patient p
                                    on ph.PatientID = p.ID inner join Doctor d
                                    on ph.DoctorID = d.ID")
                              .ExecuteList<PatientHistory>();
            }
        }

        public PatientHistory FindById(int id)
        {
            using (var db = new DbManager())
            {
                return db
                     .SetCommand(@"select ph.*,p.Name PatientName,d.Name DoctorName
                                    from PatientHistory ph inner join Patient p
                                    on ph.PatientID = p.ID inner join Doctor d
                                    on ph.DoctorID = d.ID
                                    WHERE ph.ID = @id",
                                    db.Parameter("@id", id))
                     .ExecuteObject<PatientHistory>();
            }
        }

        public void Insert(PatientHistory model)
        {
            using (var db = new DbManager())
            {
                var query = new SqlQuery<PatientHistory>();
                query.Insert(model);
            }
        }

        public void Update(PatientHistory model)
        {
            using (var db = new DbManager())
            {
                var query = new SqlQuery<PatientHistory>();
                query.Update(model);
            }
        }

        public void InsertOrUpdate(PatientHistory model)
        {
            var modelInDb = this.FindById(model.ID);

            if (modelInDb == null)
                this.Insert(model);
            else
                this.Update(model);
        }

        public void Delete(int ID)
        {
            using (var db = new DbManager())
            {
                var query = new SqlQuery<PatientHistory>();
                query.DeleteByKey(ID);
            }
        }
    }
}
