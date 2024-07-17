using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Monotonic_Increasing_Stack
    {
        public List<int> Monotonic(List<int> nums)
        {
            int n = nums.Count;
            Stack<int> st = new Stack<int>();
            List<int> res = new List<int>();
            for (int i = 0; i < n; i++)
            {
                while(st.Count != 0 && st.Peek() < nums[i])
                {
                    st.Pop();
                }
                    st.Push(nums[i]);
            }
            // Transfer the stack to the result list in reverse order
            while (st.Count > 0)
            {
                res.Insert(0 , st.Pop());              
            }

            return res;
        }
    }
}
