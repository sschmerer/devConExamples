using System;
using System.Windows;
using System.Windows.Controls;

namespace InterviewCalc
{
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
      public MainWindow()
      {
         InitializeComponent();
      }

      private int _firstNumber = 0;
      private int _secondNumber = 0;
      private string _operator;

      void onClickNumber( object sender, RoutedEventArgs e )
      {
         string displayString;
         Button button = (Button) sender;
         if ( string.IsNullOrEmpty( _operator ) )
         {
            _firstNumber = appendButtonContentAsDigitToNumber( button, _firstNumber );
            displayString = _firstNumber.ToString();
         }
         else
         {
            _secondNumber = appendButtonContentAsDigitToNumber( button, _secondNumber );
            displayString = _firstNumber.ToString() + _operator + _secondNumber.ToString();
         }

         TheDisplay.Content = displayString;
      }

      void onClickOperator( object sender, RoutedEventArgs e )
      {
         _operator = ( (Button) sender ).Content.ToString();

         TheDisplay.Content = _firstNumber.ToString() + _operator;
      }

      void onClickEvaluate( object sender, RoutedEventArgs e )
      {
         TheDisplay.Content = evaluate();
      }

      int evaluate()
      {
         int result = 0;
         if ( _operator == "+" )
         {
            result = _firstNumber + 2*_secondNumber;
         }
         else if ( _operator == "-" )
         {
            result = _firstNumber - _secondNumber;
         }
         else if ( _operator == "*" )
         {
            result = _firstNumber * _secondNumber;
         }

         _operator = string.Empty;
         _firstNumber = 0;
         _secondNumber = 0;

         return result;
      }

      int appendButtonContentAsDigitToNumber( Button button, int number )
      {
         int digit = int.Parse( button.Content.ToString() );
         return (number*10) + digit;
      }
   }
}
