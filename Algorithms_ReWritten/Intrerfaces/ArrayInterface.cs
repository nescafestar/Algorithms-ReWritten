using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_ReWritten.Intrerfaces
{
    interface ArrayInterface
    {
        object getValue(int i);
        int searchValue(object v);
        object caclculateSum();
        void outputAllValues();
        object findMaxValue();
        void addValue(object val, int index);
        void deleteAValue(int index);
    }
}
