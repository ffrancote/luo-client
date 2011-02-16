using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;
using Luo_Login.ViewModels;

namespace Luo_Login.Views
{
  /// <summary>
  /// Interaction logic for MainView.xaml
  /// </summary>
  public partial class MainView : Window
  {
    private MainViewModel _mainViewModels;

    public MainView()
    {
      InitializeComponent();
      _mainViewModels = new MainViewModel();
      _mainViewModels.LoadCulture("en");
      this.DataContext = _mainViewModels;
      LoadAuthentification();
    }


    private bool LoadAuthentification()
    {
      Authentificateur pageAuthentificateur = new Authentificateur();
      pageAuthentificateur.HorizontalAlignment = HorizontalAlignment.Center;
      pageAuthentificateur.VerticalAlignment = VerticalAlignment.Center;
      pageAuthentificateur.DataContext = this.DataContext;
      FramePagePrincipale.Content = pageAuthentificateur;
      
      return true;
    }
  }
}
