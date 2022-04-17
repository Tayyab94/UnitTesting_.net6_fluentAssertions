using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_ConsoleApp.Tests
{
    public static class WorldDumbestFunctionTests
    {

        public static void WorldDumbestFunction_ReturnPickchuIfZeor_ReturnStrign()
        {
            try
            {
                //Arrange
                int num = 0;

                WorldDumbestFunction fun = new WorldDumbestFunction();
                // Act

                var result = fun.ReturnPickchuIfZore(num);
                if(result == "PICKACHU")
                {
                    Console.WriteLine("Success: This test is working fine");
                }
                else
                {
                    Console.WriteLine("Failed: Something is wrong, Please degus your code to fine the Error");
                }

            }
            catch (Exception e)
            {
              Console.WriteLine(e.Message);
            }
        }
    }
}
