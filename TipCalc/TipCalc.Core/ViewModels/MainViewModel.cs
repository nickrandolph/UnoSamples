using TipCalc.Core.Services;
using System.ComponentModel;
using System;
using System.Runtime.CompilerServices;

namespace TipCalc.Core.ViewModels
{
    public class MainViewModel:INotifyPropertyChanged
    {
        private readonly ICalculationService _calculationService;
        public MainViewModel(ICalculationService calculationService)
        {
            _calculationService = calculationService;
            Generosity = 20;
            SubTotal = 100;
        }

        private double _generosity;
        public double Generosity
        {
            get { return _generosity; }
            set { SetProperty(ref _generosity, value); Recalc(); }
        }

        private double _subTotal;
        public double SubTotal
        {
            get { return _subTotal; }
            set { SetProperty(ref _subTotal, value); Recalc(); }
        }

        private double _tip;
        public double Tip
        {
            get { return _tip; }
            set { SetProperty(ref _tip, value); }
        }

        private double _total;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Total
        {
            get { return _total; }
            set { SetProperty(ref _total, value); }
        }

        private void SetProperty<T>(ref T total, T value, [CallerMemberName] string caller=null)
        {
            if (total?.Equals(value) ?? false) return;
            total = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }

        private void Recalc()
        {
            Tip = _calculationService.Tip(SubTotal, Generosity);
            Total = SubTotal + Tip;
        }
    }
}
