using System;


namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            EmpArrayList empArrayList1 = new EmpArrayList("abayomi",12673,24);
            EmpArrayList empArrayList2 = new EmpArrayList("ada", 23904, 14);
            EmpArrayList empArrayList3 = new EmpArrayList("kemi",56899, 34);
            EmpArrayList empArrayList4 = new EmpArrayList("Kunle",66471, 54);
            EmpArrayList empArrayList5 = new EmpArrayList("Seun", 125431, 74);
            empArrayList1.GetEmployee(234);
           


        }
    }
}
