using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpletronVisual.DomainClasses
{
    public class TenCells
    {
        public static DataGridView dgv;
        private int ten { get; set; }
        public int x0 { get; set; }
        public int x1 { get; set; }
        public int x2 { get; set; }
        public int x3 { get; set; }
        public int x4 { get; set; }
        public int x5 { get; set; }
        public int x6 { get; set; }
        public int x7 { get; set; }
        public int x8 { get; set; }
        public int x9 { get; set; }
        public int this[int index]
        {
            get { 
                
                switch (index)
                {
                    case 0: return x0;
                    case 1: return x1;
                    case 2: return x2;
                    case 3: return x3;
                    case 4: return x4;
                    case 5: return x5;
                    case 6: return x6;
                    case 7: return x7;
                    case 8: return x8;
                    case 9: return x9;
                }
                return 0;
            }
            set {
                switch (index)
                {
                    case 0:
                        x0 = value;
                        break;
                    case 1:
                        x1 = value;
                        break;
                    case 2:
                        x2 = value;
                        break;
                    case 3:
                        x3 = value;
                        break;
                    case 4:
                        x4 = value;
                        break;
                    case 5:
                        x5 = value;
                        break;
                    case 6:
                        x6 = value;
                        break;
                    case 7:
                        x7 = value;
                        break;
                    case 8:
                        x8 = value;
                        break;
                    case 9:
                        x9 = value;
                        break;
                }
                if (dgv != null) { dgv.Invalidate(); }
            }
        }

        public TenCells(int ten)
        {
            this.ten = ten;
        }
    }
}
