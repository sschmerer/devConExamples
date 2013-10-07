using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace devConExamples
{
   public interface IAction
   {
      int Evaluate( int incomingOperand );
   }
}
