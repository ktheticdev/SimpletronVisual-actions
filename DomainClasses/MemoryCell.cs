using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpletronVisual.DomainClasses
{
    public class MemoryCell
    {
        public static List<TenCells> memData;
        public int address { get; set; }
        private int _value;
        public int value { 
            get {
                var d1 = address / 10;
                var d2 = address % 10;
                return memData[d1][d2];
            }
            set {
                var d1 = address / 10;
                var d2 = address % 10;
                memData[d1][d2] = value;
            }
        }

        public MemoryCell(int address, int value)
        {
            this.address = address;
            this.value = value;
        }
    }
}
