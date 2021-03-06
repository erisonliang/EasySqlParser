﻿using System;

namespace EasySqlParser.Internals.Node
{
    // Porting from DOMA
    //   package    org.seasar.doma.internal.jdbc.sql.node
    //   class      FromClauseNode
    // https://github.com/domaframework/doma
    internal class FromClauseNode : AbstractClauseNode
    {
        internal FromClauseNode(string word) : base(word)
        {
        }

        internal FromClauseNode(WordNode wordNode) : base(wordNode)
        {
        }

        public override TResult Accept<TParameter, TResult>(
            ISqlNodeVisitor<TParameter, TResult> visitor,
            TParameter parameter)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException(nameof(visitor));
            }

            return visitor.VisitFromClauseNode(this, parameter);
        }
    }
}
