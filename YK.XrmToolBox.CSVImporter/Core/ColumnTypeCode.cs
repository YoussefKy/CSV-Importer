using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YK.XrmToolBox.CSVImporter.Core
{
    internal enum ColumnTypeCode
    {
        DynamicConditionExpression = 0,
        StaticConditionExpression,
        AttributeToUpdate,
        PrimaryKey,
        Key,
        PartialKey,
        Ignore
    }
}
