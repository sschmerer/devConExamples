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

      int appendButtonContentAsDigitToNumber( Button button, int number )
      {
         int digit = int.Parse( button.Content.ToString() );
         return (number*10) + digit;
      }
   }
}
