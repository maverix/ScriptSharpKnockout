// CompareResult.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KnockoutApi
{
    [Imported]
    [IgnoreNamespace]
    public class CompareResult<T>
    {
        [IntrinsicProperty]
        public CompareStatus Status {
            get;
            set;
        }

        [IntrinsicProperty]
        public T Value {
            get;
            set;
        }
    }
}
