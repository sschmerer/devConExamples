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

      private int _firstNumber;

      void onClickNumber( object sender, RoutedEventArgs e )
      {
         _firstNumber = int.Parse( ( (Button) sender ).Content.ToString() );
      }
   }
}
