﻿// Copyright (c) Microsoft. All rights reserved.

using System;

namespace Microsoft.SemanticMemory.Core20;

public class SemanticMemoryWebException : SemanticMemoryException
{
    /// <inheritdoc />
    public SemanticMemoryWebException()
    {
    }

    /// <inheritdoc />
    public SemanticMemoryWebException(string? message) : base(message)
    {
    }

    /// <inheritdoc />
    public SemanticMemoryWebException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}