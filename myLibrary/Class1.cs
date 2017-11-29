using System;

namespace myLibrary
{
    public class Class1
    {
		static public void TestRun()
		{
			Console.WriteLine("Run {0}.{1}.", System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName
                , System.Reflection.MethodBase.GetCurrentMethod().Name);
        }
    }
}
