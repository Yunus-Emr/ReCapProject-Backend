using Core.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {

            foreach (var logic in logics)
            {
                //if logic unsuccess then it will give us the error.
                if (!logic.Success)
                {
                    return logic;
                }

            }
            //if succes it can do operations.
            return null;
        }
    }
}
