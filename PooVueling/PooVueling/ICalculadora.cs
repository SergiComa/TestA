using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
    public interface ICalculadora
    {
        ///<sumary>
        ///Sumas the specified num1
        ///</sumary>
        ///<param name="num1">The num1</param>
        ///<param name="num2">The num2</param>
        ///<returns></returns>
        int Suma(int num1, int num2);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        int Resta(int num1, int num2);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        int Multiplicacion(int num1, int num2);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        int Division(int num1, int num2);

    }
}
