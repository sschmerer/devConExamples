using System.Collections.Generic;

namespace devConExamples
{
   public class Calculator
   {
      private List<IOperation> _actions;
      private Stack<IOperation> _undoneActions; 

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

      public void DivideThis( int newNumber )
      {
         var divider = new Divider( newNumber );

         _actions.Add( divider );
      }

      public void Undo()
      {
         var operationToRemove = _actions[_actions.Count - 1];
         _actions.RemoveAt( _actions.Count - 1 );

         _undoneActions.Push( operationToRemove );
      }

      public void Redo()
      {
         var operation = _undoneActions.Pop();

         _actions.Add( operation );
      }
   }
}
