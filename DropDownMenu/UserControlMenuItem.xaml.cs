using BeautySolutions.View.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DropDownMenu
{
  /// <summary>
  /// Interaction logic for UserControlMenuItem.xaml
  /// </summary>
  public partial class UserControlMenuItem : UserControl
  {
    public UserControlMenuItem(ItemMenu itemMenu)
    {
      InitializeComponent();

      ExpanderMenu.Visibility = itemMenu.SubItems == null ? Visibility.Collapsed : Visibility.Visible;
      ListViewItemMenu.Visibility = itemMenu.SubItems == null ? Visibility.Visible : Visibility.Collapsed;

      this.DataContext = itemMenu;
    }
  }
}
