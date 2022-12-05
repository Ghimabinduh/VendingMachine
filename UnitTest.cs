
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine.ViewModel;

namespace VendingMachineUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        VendingMachineViewModel viewmodel = new VendingMachineViewModel();
        [TestMethod]
        public async void ValidateDataTestMethod()
        {
         await   viewmodel.ValidateData(Coins.Dimes.ToString(), 0, Products.candy.ToString());
            Assert.IsNotNull(viewmodel.Confirmationtext);
                
        }
        [TestMethod]
        public  void SetProcessVisibilityTestMethod()
        {
             viewmodel.SetProcessVisibility(Coins.Dimes.ToString(),0,Products.chips.ToString());
            Assert.AreEqual(viewmodel.ProcessVisibility,Windows.UI.Xaml.Visibility.Visible);

        }
    }
}
