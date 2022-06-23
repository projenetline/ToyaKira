using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Domain.Concrete.Models.Rent
{
    public partial class WinFormLayout : BaseEntity
    {
        public int? UserId { get; set; }
        public string Name { get; set; }
        public string FormBounds { get; set; }
        public Nullable<int> WindowState { get; set; }
        public byte[] MainLayoutControlLayout { get; set; }
        public byte[] MainColumnViewLayout01 { get; set; }
        public byte[] MainColumnViewLayout02 { get; set; }
        public byte[] MainColumnViewLayout03 { get; set; }
        public byte[] MainColumnViewLayout04 { get; set; }
        public byte[] MainColumnViewLayout05 { get; set; }
        public byte[] MainColumnViewLayout06 { get; set; }
        public byte[] MainColumnViewLayout07 { get; set; }
        public byte[] MainColumnViewLayout08 { get; set; }
        public byte[] MainColumnViewLayout09 { get; set; }
        public byte[] MainColumnViewLayout10 { get; set; }
        public byte[] AlternateColumnViewLayout { get; set; }
        public byte[] MainDockingLayout { get; set; }
        public byte[] QuickAccessToolbar { get; set; }
        public Nullable<bool> MainView { get; set; }
        public byte[] MainPivotGrid { get; set; }
    }
}
