using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4
{
    public class NamedAndOptionalParameters
    {
        #region Invalid Order
        //INVALID: This is not VALID, all optional parameters should be followed by mandatory parameters

        /*public void InvalidMethodDeclaration(int a = 20, string name){}*/

        #endregion

        #region Not Allowed Values
        //INVALID: Default parameter value for 'message' must be a compile-time constant

        
        //public static string OptionalParametersMethod2(string name = "World", string message = string.Empty)
        //{
        //    return message + name;
        //}
        #endregion 

        public static string OptionalParametersMethod(string name="World", string message = "Hello, ")
        {
            return message + name;
        }

        #region Overload Resolution

        /*
         * The old resolution type based rules are still applied.
         * 
         * In case of potential conflit with same types and optional parametes, the parameter count match wins
         * 
         * Do(10) will call the first one
         * Do(x: 10) will call the first one
         * 
         * Do(int x=10){}
         * 
         * Do(int x=10, int y=20){}
         * 
         * Typed methods gets precedence over the generic methods in case of resolution.
         * 
         * Compiler will also consider the name of the paramter and based on that it can do the resolution 
         * even though shorter list of params is preffered.
         * 
         * 
         * 
         * */

        #endregion
    }
}
