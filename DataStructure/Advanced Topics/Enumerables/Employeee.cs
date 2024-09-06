using System.Collections;

namespace DataStructure.Advanced_Topics.Enumerables
{
    public class Employeee : IEnumerable<PayItems>
    {
        private readonly List<PayItems> _PayItems = new List<PayItems>();
        public string Name { get; set; }

        #region Wrapper Method 
        // should used it when i have (collection , list) property must be private 
        public void AddPayItems(string name, int value)
        {
            _PayItems.Add(new PayItems { Name = name, Value = value });
        }
        #endregion

        #region Indexer To Use For Loop
        public PayItems this[int index] // indexer Property
        {
            get => _PayItems[index];
            //get
            //{
            //    return _PayItems[index];
            //}
        }
        #endregion

        public IEnumerator<PayItems> GetEnumerator() // Impilict Implementions
        {
            foreach (var item in _PayItems)
                yield return item;
        }
        IEnumerator IEnumerable.GetEnumerator() // Expilict Implementions
        {
            return GetEnumerator();
        }

        #region My Custom Enumertaor
        //private class PayItemEnumerator : IEnumerator<PayItems>
        //{
        //    private readonly List<PayItems> _payItems;
        //    private int _CurrentIndex = -1;
        //    public PayItemEnumerator(List<PayItems> payItems)
        //    {
        //        _payItems = payItems;
        //    }
        //    public PayItems Current => _payItems[_CurrentIndex];         // Impilict Implementions
        //    object IEnumerator.Current => Current;                       // Expilict Implementions
        //    public void Dispose()
        //    {
        //    }
        //    public bool MoveNext()
        //    {
        //        return ++_CurrentIndex < _payItems.Count;
        //        //_CurrentIndex++;
        //        //if (_CurrentIndex < _payItems.Count)
        //        //    return true;
        //        //return false;
        //    }
        //    public void Reset()
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
        #endregion
    }
}
