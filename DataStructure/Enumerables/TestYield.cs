using System.Collections;

namespace DataStructure.Enumerables
{
    public class TestYield : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // keyword Yield
        // [1] He did Enumerator    [2] I will use it insteas of Enumerator
    }
}
