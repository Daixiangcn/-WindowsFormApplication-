//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Exam001
{
    using System;
    using System.Collections.Generic;
    
    public partial class goods
    {
        public string 货物代码 { get; set; }
        public string 货物名称 { get; set; }
        public string 入库单号 { get; set; }
        public Nullable<System.DateTime> 入库日期 { get; set; }
        public string 单位 { get; set; }
        public string 库存量 { get; set; }
        public Nullable<decimal> 售价 { get; set; }
        public Nullable<int> 类型 { get; set; }
        public Nullable<int> 供应商 { get; set; }
    
        public virtual types types { get; set; }
        public virtual supplier supplier { get; set; }
    }
}