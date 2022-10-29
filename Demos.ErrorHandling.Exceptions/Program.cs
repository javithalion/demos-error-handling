using Demos.ErrorHandling.Exceptions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MethodA();
            MethodB();
            MethodC();
            MethodD();
            MethodE();
        }      

        /// <summary>
        /// Throwing exceptions
        /// </summary>        
        private static void MethodA()
        {
            throw new Exception("Hey! This is an exception!");
        }

        /// <summary>
        /// Catching exceptions I
        /// </summary>
        private static void MethodB()
        {
            try
            {
                // 1)
            }
            catch
            {
                // 2)
            }
            finally
            {
                // 3)
            }
        }

        /// <summary>
        /// Catching exceptions II
        /// </summary>        
        private static void MethodC()
        {
            // 1)
            try
            {
                // code that throws an exception
            }
            catch
            {
                throw new Exception();
            }

            // 2)
            try
            {
                // code that throws an exception
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // 3)
            try
            {
                // code that throws an exception
            }
            catch
            {
                throw;
            }

            // 4)
            try
            {
                // code that throws an exception
            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);
            }
        }

        /// <summary>
        /// Catching exceptions III
        /// </summary>        
        private static void MethodD()
        {
            try
            {
                var result = 10 / int.Parse("0"); // 10/0
            }
            catch (DivideByZeroException exc)
            {
                Console.WriteLine("A");
            }
            catch (Exception exc)
            {
                Console.WriteLine("B");
            }
            finally
            {
                Console.WriteLine("C");
            }

            // --------------------------------------------------------

            try
            {
                var result = 10 / int.Parse("0"); // 10/0
            }
            catch (Exception exc)
            {
                Console.WriteLine("A");
            }
            catch (DivideByZeroException exc)
            {
                Console.WriteLine("B");
            }
            finally
            {
                Console.WriteLine("C");
            }
        }

        /// <summary>
        /// Custom exceptions
        /// </summary>       
        private static void MethodE()
        {
            throw new MyException("This is a custom exception");
        }
    }
}