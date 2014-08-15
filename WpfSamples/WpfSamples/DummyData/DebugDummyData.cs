using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSamples.DummyData
{
    using System.ComponentModel;

    /// <summary>
    /// The dummy datas.
    /// </summary>
    public class DebugDummyData
    {
        public enum DummyEnum
        {
            [Description("This is enum item 1")]
            EnumItems1 = 1,

            [Description("This is enum item 2")]
            EnumItems2 = 2,

            [Description("Hello World!!!")]
            EnumItems3 = 3,
        }
    }
}
