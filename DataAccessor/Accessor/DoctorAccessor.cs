using BLToolkit.Data;
using BLToolkit.DataAccess;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class DoctorAccessor
    {
        public List<Doctor> FindAll()
        {
                using (var db = new DbManager())
                {
                    var query = new SqlQuery<Doctor>(db);

                    return query.SelectAll();
                }          
        }

        public Doctor FindById(int id)
        {
                using (var db = new DbManager())
                {
                    var query = new SqlQuery<Doctor>();
                    return query.SelectByKey(id);
                }           
        }

        public void Insert(Doctor model)
        {
            using (var db = new DbManager())
            {
                var query = new SqlQuery<Doctor>();
                query.Insert(model);
            }
        }

        public void Update(Doctor model)
        {
            using (var db = new DbManager())
            {
                var query = new SqlQuery<Doctor>();
                query.Update(model);
            }
        }

        public void InsertOrUpdate(Doctor model)
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
                var query = new SqlQuery<Doctor>();
                query.DeleteByKey(ID);
            }
        }
    }
}
