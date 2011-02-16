using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Luo_Login.Properties;
using Luo_Login.ViewModels;

namespace Luo_Login.Models
{
  public class PropertiesResource : ViewModelBase
  {
    public string ResourceLabelUsername
    {
      get { return Resources.Label_Username; }
    }
    public string ResourceLabelPassword
    {
      get { return Resources.Label_Password; }
    }
    public string ResourceLabelLogin
    {
      get { return Resources.Label_Login; } 
    }
    public string ResourceLabelDownload
    {
      get { return Resources.Label_Download; }
    }
    public string ResourceBtnPlay
    {
      get { return Resources.Btn_Play; }
    }
    public bool ReloadResource()
    {
      OnPropertyChanged("ResourceLabelUsername");
      OnPropertyChanged("ResourceLabelPassword");
      OnPropertyChanged("ResourceLabelLogin");
      OnPropertyChanged("ResourceLabelDownload");
      OnPropertyChanged("ResourceBtnPlay");
      return true;

    }
  }
}
