using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class DBManager : IDBManager
    {
        public void Delete(int id)
        {
            using (var context = new CollectionContext())
            {
                context.Departments.Remove(context.Departments.Find(id));
                context.SaveChanges();
            }
        }

        public List<Department> GetAll()
        {
            //Deterministic Finalization
            using (var context = new CollectionContext())
            {
                var departments = from dept
                                  in  context.Departments 
                                  select dept;
                return departments.ToList<Department>();


            }
        }

        public Department GetById(int id)
        {

            using (var context = new CollectionContext())
            {
                var dept = context.Departments.Find(id);
                return dept;
            }
        }

        public void Insert(Department department)
        {
            using(var context = new CollectionContext())
            {
                context.Departments.Add(department);
                context.SaveChanges();
            }
        }

        public void Update(Department department)
        {
            using(var context = new CollectionContext())
            {
                var theDept = context.Departments.Find(department.Id);
                theDept.Name = department.Name;
                theDept.DeptName = department.DeptName;
                theDept.Deptno = department.Deptno;
                context.SaveChanges();
            }
        }
    }
}
