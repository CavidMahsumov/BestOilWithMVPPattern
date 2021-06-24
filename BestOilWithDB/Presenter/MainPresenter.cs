using BestOilWithDB.Data;
using BestOilWithDB.Model;
using BestOilWithDB.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOilWithDB.Presenter
{
    public class MainPresenter
    {
        private readonly PetrolContext _db;
        private IMainView _view;
        public MainPresenter(IMainView view)
        {
            _view = view;


            _db = new PetrolContext();
            //_db.Petrols.Add(new Petrol { Name = "AI95", Price = 1.4 });
            //_db.Petrols.Add(new Petrol { Name = "AI92", Price = 1 });
            //_db.Petrols.Add(new Petrol { Name = "DIZEL", Price = 0.8 });
            _view.ComboboxIndexChange += ComboboxIndexCanged;
            _view.CheckedChangedLiter += LiterChechkedChanged;
            _view.CheckedChangedAzn += AznChechkedChanged;
            _view.CalculateButtonClicked += CalculateButtonClicked;
            _view.LoadButtonClicked += LoadButtonClicked;
            _db.SaveChanges();
             
            var list = _db.Petrols.ToList();
            
            _view.Petrols = list;
        }
        public string NameOfOil { get; set; }
        public void ComboboxIndexCanged(object sender, EventArgs e)
        {
            var item = (sender as ComboBox).SelectedItem;
            var petrol = item as Petrol;
            NameOfOil=petrol.Name;
            _view.PriceText = petrol.Price.ToString();
        }

        public void LiterChechkedChanged(object sender, EventArgs e)
        {
            var item = sender as RadioButton;
            if (item.Checked)
            {
                _view.LitrEnabled = true;
            }
            else
            {
                _view.LitrEnabled = false;
            }
        }

        public void AznChechkedChanged(object sender, EventArgs e)
        {
            var item = sender as RadioButton;
            if (item.Checked)
            {
                _view.PriceEnabled = true;
            }
            else
            {
                _view.PriceEnabled = false;
            }
        }

        public void CalculateButtonClicked(object sender,EventArgs e) {
            if (_view.LitrEnabled==true)
            {
                var money = double.Parse(_view.LitrText) * double.Parse(_view.PriceText);
                _view.TotalText = money.ToString();
            }
            else
            {
                var money = double.Parse(_view.MoneyText) / double.Parse(_view.PriceText);
                _view.LitrText = String.Empty;
                var moneyFull = (int)money;
                _view.LitrText =moneyFull.ToString();
                _view.TotalText = _view.MoneyText;
            }

            Payment payment = new Payment
            {
                Liter = int.Parse(_view.LitrText),
                Oil = NameOfOil,
                TotalPayment=double.Parse(_view.TotalText)
            };
            _db.Payments.Add(payment);
            _db.SaveChanges();
        }

        public void LoadButtonClicked(object sender,EventArgs e) {
            var list = _db.Payments;
            _view.Payments = list.ToList();
        }
    }
}
