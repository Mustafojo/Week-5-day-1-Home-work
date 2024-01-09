public class Company
{
    public string CompanyName { get; set; }
    public string Location { get; set; }
    public string CEO { get; set; }
    public int NumberOfEmployees { get; set; }
    public float Revenue { get; set; }
    public List<Employee> Employees { get; set; }
    public void HireEmployee(Employee employeeName)
    {
        Employees.Add(employeeName);
        Revenue ++;
    }
    public void FireEmployee(Employee employeeName)
    {
        Employees.Remove(employeeName);
        Revenue --;
    }
    public string GenerateAnnualReport()
    {
        return $"Company Name: {CompanyName}\nLocation:{Location}\nCEO : {CEO}\nNumber of Employees: {NumberOfEmployees}\nRevenue: {Revenue}";
    }


}