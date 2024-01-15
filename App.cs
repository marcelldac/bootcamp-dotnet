namespace App{
    public class HumanResources{
        string[] EmployeesList = new string[4];
        public HumanResources(){
            EmployeesList[0] = "Marcell";
            EmployeesList[1] = "Natália";
            EmployeesList[2] = "Django";
            EmployeesList[3] = "Patrício";
        }
        public void ShowNames(){
            foreach(string name in EmployeesList){
                Console.WriteLine(name);
            }
        }

        public void NewEmployee(string employeeName){
            EmployeesList.Append(employeeName);
        }

        public void FireEmployee(string employeeName){
            int indexToRemove = Array.IndexOf(EmployeesList, employeeName);
            if(indexToRemove == -1){
                throw new InvalidOperationException("Array Index Not Found.");
            }
        }
    }
}