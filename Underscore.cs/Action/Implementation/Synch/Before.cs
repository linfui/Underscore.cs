﻿using System;

namespace Underscore.Action
{
	public class BeforeComponent : IBeforeComponent
	{
        private Function.IConvertComponent _fnConvert;
        private Action.IConvertComponent _actionConvert;
        private Function.IBeforeComponent _fnBefore;
        
        public BeforeComponent(Function.IConvertComponent fnConvert, Action.IConvertComponent actionConvert, Function.IBeforeComponent fnBefore)
        {
            _fnConvert = fnConvert;
            _actionConvert = actionConvert;
            _fnBefore = fnBefore;
        }

		public System.Action Before(System.Action action, int count)
		{
			return _fnConvert.ToAction(_fnBefore.Before(_actionConvert.ToFunction(action), count));
		}

		public Action<T> Before<T>(Action<T> action, int count)
		{
			return _fnConvert.ToAction(_fnBefore.Before(_actionConvert.ToFunction(action), count));
		}

		public Action<T1, T2> Before<T1, T2>(Action<T1, T2> action, int count)
		{
			return _fnConvert.ToAction(_fnBefore.Before(_actionConvert.ToFunction(action), count));
		}

		public Action<T1, T2, T3> Before<T1, T2, T3>(Action<T1, T2, T3> action, int count)
		{
			return _fnConvert.ToAction(_fnBefore.Before(_actionConvert.ToFunction(action), count));
		}

		public Action<T1, T2, T3, T4> Before<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, int count)
		{
			return _fnConvert.ToAction(_fnBefore.Before(_actionConvert.ToFunction(action), count));
		}

		public Action<T1, T2, T3, T4, T5> Before<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, int count)
		{
			return _fnConvert.ToAction(_fnBefore.Before(_actionConvert.ToFunction(action), count));
		}

		public Action<T1, T2, T3, T4, T5, T6> Before<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, int count)
		{
			return _fnConvert.ToAction(_fnBefore.Before(_actionConvert.ToFunction(action), count));
		}

		public Action<T1, T2, T3, T4, T5, T6, T7> Before<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, int count)
		{
			return _fnConvert.ToAction(_fnBefore.Before(_actionConvert.ToFunction(action), count));
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8> Before<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, int count)
		{
			return _fnConvert.ToAction(_fnBefore.Before(_actionConvert.ToFunction(action), count));
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, int count)
		{
			return _fnConvert.ToAction(_fnBefore.Before(_actionConvert.ToFunction(action), count));
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, int count)
		{
			return _fnConvert.ToAction(_fnBefore.Before(_actionConvert.ToFunction(action), count));
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, int count)
		{
			return _fnConvert.ToAction(_fnBefore.Before(_actionConvert.ToFunction(action), count));
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, int count)
		{
			return _fnConvert.ToAction(_fnBefore.Before(_actionConvert.ToFunction(action), count));
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, int count)
		{
			return _fnConvert.ToAction(_fnBefore.Before(_actionConvert.ToFunction(action), count));
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, int count)
		{
			return _fnConvert.ToAction(_fnBefore.Before(_actionConvert.ToFunction(action), count));
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, int count)
		{
			return _fnConvert.ToAction(_fnBefore.Before(_actionConvert.ToFunction(action), count));
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, int count)
		{
			return _fnConvert.ToAction(_fnBefore.Before(_actionConvert.ToFunction(action), count));
		}
	}
}
