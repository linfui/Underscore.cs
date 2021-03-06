﻿using System;

namespace Underscore.Action
{
	public class OnceComponent : IOnceComponent
	{
        Function.IConvertComponent _fnConvert;
        Action.IConvertComponent _actionConvert;
        Function.IOnceComponent _fnOnce;

        public OnceComponent(Function.IOnceComponent fnOnce, Function.IConvertComponent fnConvert, Action.IConvertComponent actionConvert)
        {
            _fnOnce = fnOnce;
            _fnConvert = fnConvert;
            _actionConvert = actionConvert;
        }

		public System.Action Once(System.Action action)
		{
			return _fnConvert.ToAction(_fnOnce.Once(_actionConvert.ToFunction(action)));
		}

		public Action<T> Once<T>(Action<T> action)
		{
			return _fnConvert.ToAction(_fnOnce.Once(_actionConvert.ToFunction(action)));
		}

		public Action<T1, T2> Once<T1, T2>(Action<T1, T2> action)
		{
			return _fnConvert.ToAction(_fnOnce.Once(_actionConvert.ToFunction(action)));
		}

		public Action<T1, T2, T3> Once<T1, T2, T3>(Action<T1, T2, T3> action)
		{
			return _fnConvert.ToAction(_fnOnce.Once(_actionConvert.ToFunction(action)));
		}

		public Action<T1, T2, T3, T4> Once<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action)
		{
			return _fnConvert.ToAction(_fnOnce.Once(_actionConvert.ToFunction(action)));
		}

		public Action<T1, T2, T3, T4, T5> Once<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action)
		{
			return _fnConvert.ToAction(_fnOnce.Once(_actionConvert.ToFunction(action)));
		}

		public Action<T1, T2, T3, T4, T5, T6> Once<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action)
		{
			return _fnConvert.ToAction(_fnOnce.Once(_actionConvert.ToFunction(action)));
		}

		public Action<T1, T2, T3, T4, T5, T6, T7> Once<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action)
		{
			return _fnConvert.ToAction(_fnOnce.Once(_actionConvert.ToFunction(action)));
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8> Once<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
		{
			return _fnConvert.ToAction(_fnOnce.Once(_actionConvert.ToFunction(action)));
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
		{
			return _fnConvert.ToAction(_fnOnce.Once(_actionConvert.ToFunction(action)));
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action)
		{
			return _fnConvert.ToAction(_fnOnce.Once(_actionConvert.ToFunction(action)));
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
		{
			return _fnConvert.ToAction(_fnOnce.Once(_actionConvert.ToFunction(action)));
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action)
		{
			return _fnConvert.ToAction(_fnOnce.Once(_actionConvert.ToFunction(action)));
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action)
		{
			return _fnConvert.ToAction(_fnOnce.Once(_actionConvert.ToFunction(action)));
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action)
		{
			return _fnConvert.ToAction(_fnOnce.Once(_actionConvert.ToFunction(action)));
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action)
		{
			return _fnConvert.ToAction(_fnOnce.Once(_actionConvert.ToFunction(action)));
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action)
		{
			return _fnConvert.ToAction(_fnOnce.Once(_actionConvert.ToFunction(action)));
		}
	}
}
