﻿using System;
using Descriptio.Core.Extensions;

namespace Descriptio.Core.AST
{
    [System.Diagnostics.DebuggerDisplay("``{" + nameof(Text) + "}``")]
    public class CodeTextInline : TextInline, IEquatable<CodeTextInline>
    {
        public CodeTextInline(string text) : base(text)
        {
        }

        public override TextInline SetText(string text)
            => new CodeTextInline(text.ThrowIfNullOrEmpty(nameof(text)));

        public bool Equals(CodeTextInline other) => Text == other?.Text;

        public override bool Equals(object obj) => obj is CodeTextInline other && Equals(other);

        public override int GetHashCode() => Text.GetHashCode();

        public override void Accept(IAbstractSyntaxTreeInlineVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
