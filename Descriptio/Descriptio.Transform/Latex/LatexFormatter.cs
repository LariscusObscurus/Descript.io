﻿using System.IO;
using System.Text;
using Descriptio.Core.AST;

namespace Descriptio.Transform.Latex
{
    public class LatexFormatter : IFormatter 
    {
        public void Transform(IAbstractSyntaxTreeBlock abstractSyntaxTreeBlock, Stream stream)
        {
            using (var streamWriter = new StreamWriter(stream, Encoding.UTF8, 1024, true))
            {
                var visitor = new LatexAbstractSyntaxTreeVisitor(streamWriter);
                var block = abstractSyntaxTreeBlock;
                while (block != null)
                {
                    block.Accept(visitor);
                    block = block.Next;
                }
                streamWriter.Flush();
            }
        }
    }
}
