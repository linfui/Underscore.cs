﻿using System;
using System.Threading.Tasks;

namespace Underscore.Action
{
	public class DelayComponent : IDelayComponent
	{
        private readonly Function.IDelayComponent _fnDelay;
        private readonly IConvertComponent _actionConvert;

        public DelayComponent(Function.IDelayComponent fnDelay, IConvertComponent actionConvert)
        {
            _fnDelay = fnDelay;
            _actionConvert = actionConvert;
        }

		public Func<Task> Delay(System.Action action, int milliseconds)
		{
			return _fnDelay.Delay(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T, Task> Delay<T>(Action<T> action, int milliseconds)
		{
			return _fnDelay.Delay(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, Task> Delay<T1, T2>(Action<T1, T2> action, int milliseconds)
		{
			return _fnDelay.Delay(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, Task> Delay<T1, T2, T3>(Action<T1, T2, T3> action, int milliseconds)
		{
			return _fnDelay.Delay(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, Task> Delay<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, int milliseconds)
		{
			return _fnDelay.Delay(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, Task> Delay<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, int milliseconds)
		{
			return _fnDelay.Delay(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, Task> Delay<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, int milliseconds)
		{
			return _fnDelay.Delay(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, Task> Delay<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, int milliseconds)
		{
			return _fnDelay.Delay(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, int milliseconds)
		{
			return _fnDelay.Delay(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, int milliseconds)
		{
			return _fnDelay.Delay(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, int milliseconds)
		{
			return _fnDelay.Delay(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, int milliseconds)
		{
			return _fnDelay.Delay(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, int milliseconds)
		{
			return _fnDelay.Delay(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, int milliseconds)
		{
			return _fnDelay.Delay(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, int milliseconds)
		{
			return _fnDelay.Delay(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, int milliseconds)
		{
			return _fnDelay.Delay(_actionConvert.ToFunction(action), milliseconds);
		}

		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, int milliseconds)
		{
			return _fnDelay.Delay(_actionConvert.ToFunction(action), milliseconds);
		}
	}
}
