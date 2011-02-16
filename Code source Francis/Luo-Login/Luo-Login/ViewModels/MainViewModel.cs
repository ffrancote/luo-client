using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Luo_Login.Properties;
using Luo_Login.Commands;
using System.Globalization;

namespace Luo_Login.ViewModels
{
  public class MainViewModel : PropertiesResource
  {
    private DelegateCommand exitCommand;
    private List<String> _cultureName;
    private string _selectedCultureName;

    #region Constructor

    public MainViewModel()
    {
      _cultureName = new List<string>();
      _cultureName.Add("English");
      _cultureName.Add("Français");
      _selectedCultureName = "English";
    }

    #endregion

    public string SelectedCultureName
    {
      get { return _selectedCultureName; }
      set 
      { 
        _selectedCultureName = value;
        if (_selectedCultureName == "Français")
        {
          LoadCulture("fr");
        }else
        {
          LoadCulture("en");
        }
       
        OnPropertyChanged("SelectedCultureName");
        ReloadResource();
      }
    }

    public List<String> CultureName
    {
      get { return _cultureName; }
    }

    public CultureInfo Culture
    {
      get;
      set;
    }

    public ICommand ExitCommand
    {
      get
      {
        if (exitCommand == null)
        {
          exitCommand = new DelegateCommand(Exit);
        }
        return exitCommand;
      }
    }

    private void Exit()
    {
      Application.Current.Shutdown();
    }

    public bool LoadCulture(string cultureID)
    {
      string culture = cultureID;
      Culture = new System.Globalization.CultureInfo(culture);
      System.Threading.Thread.CurrentThread.CurrentUICulture = Culture;
      Resources.Culture = Culture;
      return true;
    }
   
  }
}
