using BOL;

namespace DAL
{
    public  interface IDBManager
    {


        List<Department> GetAll();

        Department GetById(int id);

        void Insert(Department department);

        void Update(Department department);
        void Delete(int id);
    }
}
