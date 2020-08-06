﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Wox.Infrastructure.Storage
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1649:File name should match first type name", Justification = "Generic, file is named correctly")]
    public interface IRepository<T>
    {
        void Add(T insertedItem);

        void Remove(T removedItem);

        bool Contains(T item);

        void Set(IList<T> list);

        bool Any();
    }
}
