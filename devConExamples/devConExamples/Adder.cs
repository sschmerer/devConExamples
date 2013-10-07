
namespace devConExamples
{
   public class Adder : IOperation
   {
      private int _operand;

      public Adder( int newNumber )
      {
         _operand = newNumber;
      }

      public int Evaluate( int incomingOperand )
      {
         return incomingOperand + _operand;
      }
   }
}