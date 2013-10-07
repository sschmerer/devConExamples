using System.Collections.Generic;

namespace devConExamples
{
   public class Calculator
   {
      private List<IOperation> _actions;

      public int RunEvaulations()
      {
         int result = 0;
         foreach ( var action in _actions )
         {
            result = action.Evaluate( result );
         }

         return result;
      }

      public void AddThis( int newNumber )
      {
         var adder = new Adder( newNumber );

         _actions.Add( adder );
      }

      public void SubtractThis( int newNumber )
      {
         var subtractor = new Subtractor( newNumber );

         _actions.Add( subtractor );
      }

      public void MultipyThis( int newNumber )
      {
         var multiplier = new Multiplier( newNumber );

         _actions.Add( multiplier );
      }
   }
}
