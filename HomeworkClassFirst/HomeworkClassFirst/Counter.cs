using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClassFirst
{
    class Counter
    {
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public int Min { get; set; }
        public int Max { get; set; }
        public int CurrentData { get; set; }

        public Counter()
        {

        }
        public Counter(int min, int max)
        {
            Min = min;
            Max = max;
            CurrentData = min;
            
        }

        public int GetCurrentData() => CurrentData;
        public void Increment()
        {
            if (CurrentData == Max) CurrentData = Min;
            else CurrentData++;
        }
    }
}
