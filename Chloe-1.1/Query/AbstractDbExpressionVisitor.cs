﻿using Chloe.DbExpressions;
using Chloe.Query.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chloe.Query
{
    public abstract class AbstractDbExpressionVisitor : DbExpressionVisitor<ISqlState>
    {
        public abstract Dictionary<string, object> ParameterStorage { get; }
    }

}