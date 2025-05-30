//
//Sử dụng Generic List để quản lý nhân sự với đầy đủ 
// Tính năng CRUD
// C-> Create--> Tạo mới dữ liệu
//R--> Read/Retrieve --> Xem, lọc, tìm kiếm, sắp xếp, thống kê....
//U--> Update -->Sửa dữ liệu
//D--> Delete --> xóa dữ liệu
//
// Câu 1 : tạo 5 nhân viên, 3 nhân viên chính thức, 2 thời vụ
//Lưu vào generic List:
using System.Text;
using OOP2;

List<Employee> employees = new List<Employee>();
FulltimeEmployee fe1 = new FulltimeEmployee()
{
    Id = 1,
    IdCard="123",
    Name="Name 1",
    Birthday =new DateTime(1992,01,12),
};
employees.Add(fe1);
FulltimeEmployee fe2 = new FulltimeEmployee()
{
    Id = 2,
    IdCard = "456",
    Name = "Name 2",
    Birthday = new DateTime(1993, 11, 2),
};
employees.Add(fe2);
FulltimeEmployee fe3 = new FulltimeEmployee()
{
    Id = 3,
    IdCard = "789",
    Name = "Name 3",
    Birthday = new DateTime(1979, 1, 12),
};
employees.Add(fe3);


ParttimeEmployee pe1 = new ParttimeEmployee()
{
    Id = 4,
    IdCard = "234",
    Name = "Name 4",
    Birthday = new DateTime(1999, 3, 22),
    WorkingHour=2,
};
employees.Add(pe1);

ParttimeEmployee pe2 = new ParttimeEmployee()
{
    Id = 5,
    IdCard = "5678",
    Name = "Name 5",
    Birthday = new DateTime(1989, 6, 23),
    WorkingHour=3,
};
employees.Add(pe2);

Console.OutputEncoding = Encoding.UTF8;

//Câu 2 R-->Xuất toàn bộ nhân sự:
Console.WriteLine("Câu 2: R--> Xuất toàn bộ nhân sự:");
//Cách 1 :
employees.ForEach(e => Console.WriteLine(e));
// Câu 3 : R --> Lọc ra các nhân sự chính thức
//Cách 1:

List<FulltimeEmployee> fe_list= employees.OfType<FulltimeEmployee>().ToList();
Console.WriteLine("Câu 3: R--> Lọc ra các nhân sự là chính thức:");
foreach(FulltimeEmployee fe in fe_list) Console.WriteLine(fe);

//Câu 4: Tổng lương nhân viên chính thức 
double fe_sum_salary = fe_list.Sum(e => e.calSalary());
Console.WriteLine("Câu 4: Tổng lương nhân viên chính thức:");
Console.WriteLine(fe_sum_salary);
//Câu 5: Tổng lương nhân viên thời vụ
double pe_sum_salary = employees.OfType<ParttimeEmployee>().Sum (e => e.calSalary());
Console.WriteLine("Câu 5: Tổng lương nhân viên thời vụ:");
Console.WriteLine(pe_sum_salary);
// Bổ sung thêm các tính năng xóa , sửa dữ liệu nhân viên
void DeleteEmployeeById(int id)
{
    Employee empToRemove = null;
    foreach (var e in employees)
    {
        if (e.Id == id)
        {
            empToRemove = e;
            break; 
        }
    }

    if (empToRemove != null)
    {
        employees.Remove(empToRemove);

        Console.WriteLine($"Đã xóa thông tin cho nhân viên Id = {id}");
    }
    else
    {
        Console.WriteLine($"Không tìm thấy nhân viên có Id = {id}");
    }
}
Console.WriteLine("Câu 6: Xóa dữ liệu nhân viên");
DeleteEmployeeById(2); 
Console.WriteLine("Sau khi Xóa dữ liệu nhân viên");
employees.ForEach(e => Console.WriteLine(e));
void UpdateEmployeeById(int id, string newIdCard, string newName, DateTime newBirthDay)
{
    Employee empToUpdate = null;
    foreach (var e in employees)
    {
        if (e.Id == id)
        {
            empToUpdate = e;
            break;
        }
    }
    if (empToUpdate != null)
    {
        empToUpdate.Name = newName;
        empToUpdate.IdCard = newIdCard;
        empToUpdate.Birthday = newBirthDay;

        Console.WriteLine($"Đã cập nhật thông tin cho nhân viên Id = {id}");
    }
    else
    {
        Console.WriteLine($"Không tìm thấy nhân viên có Id = {id}");
    }
}
Console.WriteLine("Câu 7: Update dữ liệu nhân viên");
UpdateEmployeeById(4,"999", "New " ,new DateTime(1989, 6, 23));
Console.WriteLine("Sau khi Update dữ liệu nhân viên");
employees.ForEach(e => Console.WriteLine(e));