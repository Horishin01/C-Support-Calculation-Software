using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE15_01
{
    internal class PartShift
    {
        private ObservableCollection<TaxPrice> __taxPrices = new ObservableCollection<TaxPrice>();

        public ObservableCollection<TaxPrice> TaxPrices
        {
            // get;
            get { return __taxPrices; }
        }

        public PartShift()
        {
        }
        public void Add(TaxPrice taxPrice)
        {
            __taxPrices.Add(taxPrice);
        }

        public void Remove(TaxPrice taxPrice)
        {
            __taxPrices.Remove(taxPrice);
        }

        public void Clear()
        {
            __taxPrices.Clear();
            //test
        }
    }
}
    