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

      void onClickNumber( object sender, RoutedEventArgs e )
      {
         int digit = int.Parse( ( (Button) sender ).Content.ToString() );
         _firstNumber = (_firstNumber*10) + digit;
      }
   }
}
