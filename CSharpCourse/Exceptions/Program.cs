using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            /*
            try
            {
                Find();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {

            }*/

            //Method
            HandleException(()=> 
            {
                Find();
            });
            

            Console.ReadLine();

        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3]{"Engin","Derin","Salih"};
                students[3] = "Ahmet";
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        private static void Find()
        {
            List<string> students = new List<string> { "Engin", "Demir", "Salih" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record not found");
            }
            else
            {
                Console.WriteLine("Record found");
            }
        }
    }
}
