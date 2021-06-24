using BestOilWithDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOilWithDB.View
{
    public interface IMainView
    {
        EventHandler<EventArgs> ComboboxIndexChange { get; set; }
        EventHandler<EventArgs> CheckedChangedLiter { get; set; }
        EventHandler<EventArgs> CheckedChangedAzn { get; set; }
        EventHandler<EventArgs> CalculateButtonClicked { get; set; }
        EventHandler<EventArgs> LoadButtonClicked { get; set; }

        List<Petrol> Petrols { set; }
        List<Payment> Payments { set; }
        string PriceText { get; set; }
        bool IsLitr { get; set; }
        string LitrText { get; set; }
        string MoneyText { get; set; }
        string TotalText { get; set; }
        bool LitrEnabled { get; set; }
        bool PriceEnabled { get; set; }
    }
}
