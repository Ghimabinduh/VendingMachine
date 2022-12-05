using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using VendingMachine.ViewModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace VendingMachine
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class VendingMachinePage : Page
    {
        VendingMachineViewModel vendingMachineViewModel = new VendingMachineViewModel();
        public VendingMachinePage()
        {
            this.InitializeComponent();

            this.DataContext = vendingMachineViewModel;
        }

        private async void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            await vendingMachineViewModel.ValidateData(vendingMachineViewModel.SelectedCoin, VendingMachineViewModel.Balanceamount, vendingMachineViewModel.SelectedProduct);
        }
    }
}