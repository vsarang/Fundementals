using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundementals {
    class NonNegativeInt {
        protected int non_negative_int;

        public NonNegativeInt(int i) {
            if (i >= 0) {
                non_negative_int = i;
            } else {
                throw new System.ArgumentException("Parameter cannot be negative", "i");
            }
        }

        public int Get() {
            return non_negative_int;
        }

        public void Set(int i) {
            if (i > 0) {
                non_negative_int = i;
            }
        }
    }
}
