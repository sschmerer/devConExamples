namespace devConExamples
{
   public class Subtractor : IOperation
   {
      private int _operand;

      public Subtractor( int operand )
      {
         _operand = operand;
      }

      public int Evaluate( int incomingOperand )
      {
         return incomingOperand - _operand;
      }
   }
}