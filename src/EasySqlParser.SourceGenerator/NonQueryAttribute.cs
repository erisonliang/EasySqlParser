﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EasySqlParser.SourceGenerator
{
    // TODO: DOC
    /// <summary>
    /// Attribute for INSERT,UPDATE,DELETE sql
    /// </summary>
    public abstract class NonQueryAttribute : MethodAttributeBase
    {
        /// <summary>
        /// SQL文を自動生成するか
        /// </summary>
        public bool AutoGenerate { get; set; } = true;

        /// <summary>
        /// DbSetを利用してメタデータの取得を行うか
        /// </summary>
        public bool UseDbSet { get; set; } = true;


    }
}