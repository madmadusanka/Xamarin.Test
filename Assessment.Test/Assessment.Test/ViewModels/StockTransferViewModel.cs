using Assessment.Test.Models;
using Assessment.Test.Utils;
using Assessment.Test.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Assessment.Test.ViewModels
{
    public class StockTransferViewModel : BaseViewModel
    {
        public List<StockTransferModel> listitems {get; set;}

        public StockTransferViewModel()
        {
            listitems = new List<StockTransferModel>();
            listitems.Add(new StockTransferModel { product = "A" });
            listitems.Add(new StockTransferModel { product = "B" });
            listitems.Add(new StockTransferModel { product = "C" });
            listitems.Add(new StockTransferModel { product = "D" });
            listitems.Add(new StockTransferModel { product = "E" });
            listitems.Add(new StockTransferModel { product = "F" });
            listitems.Add(new StockTransferModel { product = "APPLES" });

            
        }

        private ICommand _displaylable = null;
        //public ICommand DisplyLable => _displaylable = _displaylable ?? new Command(async () => await DisplyInfor());
        public ICommand DisplyLable => _displaylable = _displaylable ?? new Command<StockTransferModel>((parameter) => DisplyInfor(parameter));
        private async Task DisplyInfor(StockTransferModel produ)
        {
            string pro = produ.product;
            await App.Current.MainPage.DisplayAlert("Product",pro, AppConstants.Ok);
        }
    }
}
