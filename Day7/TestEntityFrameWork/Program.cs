using System;
using System.Collections.Generic;
using System.Transactions;
using BOL;
using DAL;

using DAL;
Console.WriteLine("Welcome to SOftware Engineering");

IDBManager dbm = new DBManager();

while (true)
{
    Console.WriteLine("Choose Option :");
    Console.WriteLine("1. Display  records");
    Console.WriteLine("2. Display Record By Id");
    Console.WriteLine("3. Insert  new record");
    Console.WriteLine("4. Update existing record");
    Console.WriteLine("5. Delete existing record");
    Console.WriteLine("6. Exit");

    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            List<Department> alldepartments = dbm.GetAll();
            foreach(var dept in alldepartments)
            {
                Console.WriteLine(" Id: {0}, Name: {1}, DeptName : {2},DeptNo:{3}",
                                   dept.Id, dept.Name, dept.DeptName, dept.Deptno);

            }
            break;
        case 2:
            Console.WriteLine("Enter Id:-");
            Department department = dbm.GetById(int.Parse(Console.ReadLine()));
            Console.WriteLine(" Id: {0}, Name: {1}, DeptName : {2},DeptNo:{3}",
                                   department.Id,department.Name,department.DeptName,department.Deptno);

            break;
        case 3:
            Console.WriteLine("Enter Details:-");
            var newDept = new Department();
            {
                newDept.Id = int.Parse(Console.ReadLine());
                newDept.Name = Console.ReadLine();
                newDept.DeptName = Console.ReadLine();
                newDept.Deptno = int.Parse(Console.ReadLine());

            }
            dbm.Insert(newDept);
            Console.WriteLine("inserted");

            break;
            case 4:
            Console.WriteLine("Enter the id :");
                var updateDepart = new Department();
            {
                updateDepart.Id = int.Parse(Console.ReadLine());
                updateDepart.Name = Console.ReadLine();
                updateDepart.DeptName= Console.ReadLine();
                updateDepart.Deptno= int.Parse(Console.ReadLine());
            }
            dbm.Update(updateDepart);

            break;
            case 5:
            Console.WriteLine("Enter Id to remove the details: -");
            dbm.Delete(int.Parse(Console.ReadLine()));
            break;
        default:
            return;
    }
}