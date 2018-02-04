select SUBSTRING(e.LoginId, CHARINDEX('\',e.LoginId) + 1,LEN(e.LoginId)) as Empleado, d.Name as Departamento from HumanResources.Employee e left join HumanResources.EmployeeDepartmentHistory dh
on e.BusinessEntityID = dh.BusinessEntityID inner join HumanResources.Department d
on dh.DepartmentID = d.DepartmentID;

select e.LoginId as Empleado, d.Name as Departamento from HumanResources.Employee e 
left join HumanResources.EmployeeDepartmentHistory dh
on e.BusinessEntityID = dh.BusinessEntityID inner join HumanResources.Department d
on dh.DepartmentID = d.DepartmentID;

select COUNT(*) as 'Cantidad de Empleados', d.Name as Departamento from HumanResources.Employee e 
left join HumanResources.EmployeeDepartmentHistory dh
on e.BusinessEntityID = dh.BusinessEntityID inner join HumanResources.Department d
on dh.DepartmentID = d.DepartmentID 
group by d.Name

                                      
 Select top 1 r.Total, r.Nombre from 
(
select SUM(e.Salary) as Total, d.Name as Nombre from HumanResources.Employee e inner join
 HumanResources.EmployeeDepartmentHistory dh
on e.BusinessEntityID = dh.BusinessEntityID inner join 
HumanResources.Department d on dh.DepartmentID = d.DepartmentID
group by d.Name
) r 
order by r.Total;

Select top 1 r.Total, r.Nombre from 
(
select SUM(e.Salary) as Total, d.Name as Nombre from HumanResources.Employee e inner join HumanResources.EmployeeDepartmentHistory dh
on e.BusinessEntityID = dh.BusinessEntityID inner join HumanResources.Department d on dh.DepartmentID = d.DepartmentID
group by d.Name
) r 
order by r.Total desc
