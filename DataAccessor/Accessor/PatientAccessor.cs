using BLToolkit.Data;
using BLToolkit.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class PatientAccessor
    {
        public List<Patient> FindAll()
        {
            using (var db = new DbManager())
            {
                var query = new SqlQuery<Patient>(db);

                return query.SelectAll();
            }
        }

        public Patient FindById(int id)
        {
            using (var db = new DbManager())
            {
                var query = new SqlQuery<Patient>();
                return query.SelectByKey(id);
            }
        }

        public void Insert(Patient model)
        {
            using (var db = new DbManager())
            {
                var query = new SqlQuery<Patient>();
                query.Insert(model);
            }
        }

        public void Update(Patient model)
        {
            using (var db = new DbManager())
            {
                var query = new SqlQuery<Patient>();
                query.Update(model);
            }
        }

        public void InsertOrUpdate(Patient model)
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
                var query = new SqlQuery<Patient>();
                query.DeleteByKey(ID);
            }
        }
    }
}
