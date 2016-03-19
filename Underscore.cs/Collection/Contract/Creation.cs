﻿using System;
using System.Collections.Generic;

namespace Underscore.Collection
{
    public interface ICreationComponent 
    {

        /// <summary>
        /// creates a function that always returns a copy of the passed collection at the time it was called
        /// </summary>
        Func<IEnumerable<T>> Snapshot<T>( IEnumerable<T> collection );

        IEnumerable<T> Extend<T>(IEnumerable<T> collection, int length);


        IEnumerable<T> Cycle<T>(IEnumerable<T> collection);
    }
}
