﻿using System;
using System.Linq;

namespace Underscore.Function
{
	public class OrComponent : IOrComponent
	{
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<bool> Or(params Func<bool>[] fns)
		{
			return () => fns.Aggregate(false, (prev, current) => prev || current());
		}

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, bool> Or<T1>(params Func<T1, bool>[] fns)
		{
			return (a) => fns.Aggregate(false, (prev, current) => prev || current(a));
		}

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, bool> Or<T1, T2>(params Func<T1, T2, bool>[] fns)
		{
			return (a, b) => fns.Aggregate(false, (prev, current) => prev || current(a, b));
		}

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, bool> Or<T1, T2, T3>(params Func<T1, T2, T3, bool>[] fns)
		{
			return (a, b, c) => fns.Aggregate(false, (prev, current) => prev || current(a, b, c));
		}

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, bool> Or<T1, T2, T3, T4>(params Func<T1, T2, T3, T4, bool>[] fns)
		{
			return (a, b, c, d) => fns.Aggregate(false, (prev, current) => prev || current(a, b, c, d));
		}

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, bool> Or<T1, T2, T3, T4, T5>(params Func<T1, T2, T3, T4, T5, bool>[] fns)
		{
			return (a, b, c, d, e) => fns.Aggregate(false, (prev, current) => prev || current(a, b, c, d, e));
		}

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, bool> Or<T1, T2, T3, T4, T5, T6>(params Func<T1, T2, T3, T4, T5, T6, bool>[] fns)
		{
			return (a, b, c, d, e, f) => fns.Aggregate(false, (prev, current) => prev || current(a, b, c, d, e, f));
		}

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, bool> Or<T1, T2, T3, T4, T5, T6, T7>(params Func<T1, T2, T3, T4, T5, T6, T7, bool>[] fns)
		{
			return (a, b, c, d, e, f, g) => fns.Aggregate(false, (prev, current) => prev || current(a, b, c, d, e, f, g));
		}

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>[] fns)
		{
			return (a, b, c, d, e, f, g, h) => fns.Aggregate(false, (prev, current) => prev || current(a, b, c, d, e, f, g, h));
		}

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool>[] fns)
		{
			return (a, b, c, d, e, f, g, h, i) => fns.Aggregate(false, (prev, current) => prev || current(a, b, c, d, e, f, g, h, i));
		}

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>[] fns)
		{
			return (a, b, c, d, e, f, g, h, i, j) => fns.Aggregate(false, (prev, current) => prev || current(a, b, c, d, e, f, g, h, i, j));
		}

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool>[] fns)
		{
			return (a, b, c, d, e, f, g, h, i, j, k) => fns.Aggregate(false, (prev, current) => prev || current(a, b, c, d, e, f, g, h, i, j, k));
		}

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>[] fns)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l) => fns.Aggregate(false, (prev, current) => prev || current(a, b, c, d, e, f, g, h, i, j, k, l));
		}

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool>[] fns)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l, m) => fns.Aggregate(false, (prev, current) => prev || current(a, b, c, d, e, f, g, h, i, j, k, l, m));
		}

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool>[] fns)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => fns.Aggregate(false, (prev, current) => prev || current(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
		}

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool>[] fns)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => fns.Aggregate(false, (prev, current) => prev || current(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
		}

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool>[] fns)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => fns.Aggregate(false, (prev, current) => prev || current(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p));
		}
	}
}
