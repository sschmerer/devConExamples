namespace devConExamples
{
   public class Multiplier : IOperation
   {
      private int _operand;

      public Multiplier( int operand )
      {
         _operand = operand;
      }

      public int Evaluate( int incomingOperand )
      {
         return incomingOperand * _operand;
      }
   }
}