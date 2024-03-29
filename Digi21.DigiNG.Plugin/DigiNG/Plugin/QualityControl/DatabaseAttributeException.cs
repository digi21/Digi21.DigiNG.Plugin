﻿using System;

namespace Digi21.DigiNG.Plugin.QualityControl
{
    public class DatabaseAttributeException : Exception
    {
        public DatabaseAttributeException(string message, int codeIndex, string field) => throw null;
        public DatabaseAttributeException(string message, int codeIndex, string field, Exception innerException) => throw null;
        public DatabaseAttributeException(string message, int codeIndex, string field, Tuple<string, string>[] contextualMenuOptions) => throw null;
        public DatabaseAttributeException(string message, int codeIndex, string field, Exception innerException, Tuple<string, string>[] contextualMenuOptions) => throw null;
        public Tuple<string, string>[] ContextualMenuOptions { get => throw null; set => throw null; }
        public string Field { get => throw null; set => throw null; }
        public int CodeIndex { get => throw null; set => throw null; }
    }
}
