﻿using EasySqlParser.Internals.Dialect.Transformer;
using EasySqlParser.Internals.Node;

namespace EasySqlParser.Internals.Dialect
{
    // Porting from DOMA
    //   package    org.seasar.doma.jdbc.dialect
    //   class      MssqlDialect
    // https://github.com/domaframework/doma
    internal class MssqlDialect : Mssql2008Dialect
    {
        private readonly bool _pagingForceOffsetFetch;
        //internal override string ParameterPrefix { get; } = "@";
        //internal override bool EnableNamedParameter { get; } = true;

        //private static readonly char[] DefaultWildcards = { '%', '_', '[' };

        internal MssqlDialect() :
            base(DefaultWildcards)
        {
            _pagingForceOffsetFetch = false;
        }

        internal MssqlDialect(char[] wildcards) :
            base(wildcards)
        {
            _pagingForceOffsetFetch = false;
        }

        protected MssqlDialect(char escapeChar, char[] wildcards) :
            base(escapeChar, wildcards)
        {
            _pagingForceOffsetFetch = false;
        }

        internal MssqlDialect(bool pagingForceOffsetFetch) :
            base(DefaultWildcards)
        {
            _pagingForceOffsetFetch = pagingForceOffsetFetch;
        }

        internal override ISqlNode ToPagingSqlNode(ISqlNode node, long offset, long limit, string rowNumberColumn)
        {
            var transformer = new MssqlPagingTransformer(offset, limit, _pagingForceOffsetFetch, rowNumberColumn);
            return transformer.Transform(node);
        }
    }
}
