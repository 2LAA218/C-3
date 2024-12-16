using System.Security.Cryptography.X509Certificates;

namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region string formating
            //equation : x+y=12
            //int x = 3, y = 4;
            ////1.string concat
            //string massage = "equation : " + x + "," + y;
            //Console.WriteLine(massage);
            ////immutable datataype-->can not change after creation
            ////string format
            //string mass = string.Format("equation : {0}+{1}={2}", x, y, x + y);
            //Console.WriteLine(mass);
            ////string interpolution
            //// $ :
            //string masse=$"equation : {x}+{y}={x+y}";
            //Console.WriteLine(masse);
            #endregion
            #region ControlStatements
            //1.condditional(if,switch)
            //2.loop(for,foreach,while,do-while)
            #endregion
            #region ControlStatement1
            Console.WriteLine("enter num of month");
            int MonthNum=int.Parse(Console.ReadLine());
            #endregion

        }
    }
}
