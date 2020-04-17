using System;
using System.Collections;
using System.Text;


namespace EmployeeApp
{
    class EmpArrayList
    {
        private int EmpID;
        private string Name;
        private int Age;
        ArrayList myOwnArryList = new ArrayList();




        public EmpArrayList( string nam, int empId, int ag)
        {
            EmpID = empId;
            Name = nam;
            Age = ag;
            
            myOwnArryList.Add(Name);
            myOwnArryList.Add(EmpID);
            myOwnArryList.Add(Age);
        }





        public void GetEmployee( int identity)
        {
            int validateId = identity;
           // myOwnArryList.Contains(validateId);
            Console.WriteLine(myOwnArryList.Contains(validateId));
            if (myOwnArryList.Contains(validateId))
            {
                Console.Write("Name:");
                for(int i = 0; i < myOwnArryList.Count; i++)
                {
                    Console.Write($"{myOwnArryList[i]} : ");
                }
            }
            else
            {
                Console.WriteLine($"Sorry We can't Validate you; Your ID is in Valid");
            }
           

            
                

        }
    }
}
