namespace devConExamples
{
   public class Divider : IOperation
   {
      private int _operand;

      public Divider( int operand )
      {
         _operand = operand;
      }

      public int Evaluate( int incomingOperand )
      {
         return incomingOperand / _operand;
      }
   }
}