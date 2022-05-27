using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace epicRD.Attached_Properties
{
    internal class SideNavigationMenu : UserControl
    {


        public object MenuButtonsContainer
        {
            get => GetValue(MenuButtonsContainerProperty);
            set => SetValue(MenuButtonsContainerProperty, value);
        }

        // Using a DependencyProperty as the backing store for MenuButtonContainer.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MenuButtonsContainerProperty =
            DependencyProperty.Register("MenuButtonsContainer", typeof(object), typeof(SideNavigationMenu));



        public object FooterMenuButtonsContainer
        {
            get => GetValue(FooterMenuButtonsContainerProperty);
            set => SetValue(FooterMenuButtonsContainerProperty, value);
        }

        // Using a DependencyProperty as the backing store for FooterMenuButtonContainer.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FooterMenuButtonsContainerProperty =
            DependencyProperty.Register("FooterMenuButtonsContainer", typeof(object), typeof(SideNavigationMenu));



    }
}
