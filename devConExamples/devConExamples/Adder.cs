
namespace devConExamples
{
   public class Adder : IAction
   {
      public int Evaluate( int left, int right )
      {
         return left + right;
      }
   }
}