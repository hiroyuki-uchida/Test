using UnityEngine;

namespace Foo
{
    public class Bar
    {
        private int mCounter;

        public void Baz()
        {
            Debug.Log("test");
            mCounter++;
        }

        public void GetCounter()
        {
            return mCounter;
        }
    }
}
