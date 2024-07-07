

namespace BOL;

public  class Department
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? DeptName { get; set; }
    public int Deptno { get; set; }
    /*
     * 
1.Create Blank solution.  1
2.Create new console Application.  1
3.Add Mysql.EntityFramework.dll using nuget package manager  1
4.Add Department.cs file matcthing with Department Table   1
5.Add new Class CollectionContext.cs file to project   1
6.Inherit class CollectionContext.cs from DbContext.   1
7.Add Data member <DbSet> Departments to CollectionContext 1
8.Override OnConfiguring method of Collection Context. 1
9.Define connection string inside OptionsBuilder using UseMySql() 1
10.Override OnModelCreating inside Collection Context Class. 1
11.Perform Model Mapping  with constraints using ModelBuilder  1
12.Add IDBManager interface with CRUD Operations signatures  
13.Add DBManager class implementing IDBManager interface.
14.Implement each crud operation method using instance of CollectionContext
15.Invoke LINQ query or Data Manipulation Code inside CRUD Operation method.
16.Always invoke SaveChanges method for  Update , Delete , Insert operation.
     * 
     * */
}
