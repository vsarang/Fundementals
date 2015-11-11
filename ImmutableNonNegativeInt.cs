using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundementals {
    class ImmutableNonNegativeInt : NonNegativeInt {
        public ImmutableNonNegativeInt(int i) : base(i) { }
        new public void Set(int i) { }
    }
}
