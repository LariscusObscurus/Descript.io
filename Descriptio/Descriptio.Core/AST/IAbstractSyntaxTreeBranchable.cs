﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Descriptio.Core.AST
{
    public interface IAbstractSyntaxTreeBranchable : IAbstractSyntaxTree, IEnumerable<IAbstractSyntaxTree>
    {

    }
}
