﻿using System.IO;
using System.Text;
using Descriptio.Core.AST;

namespace Descriptio.Transform.Html
{
    public class HtmlFormatter : IFormatter 
    {
        public void Transform(IAbstractSyntaxTreeBlock abstractSyntaxTreeBlock, Stream stream)
        {
            using (var streamWriter = new StreamWriter(stream, Encoding.UTF8, 1024, true))
            {
                var visitor = new HtmlAbstractSyntaxTreeVisitor(streamWriter);
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
