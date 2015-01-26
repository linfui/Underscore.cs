﻿using System;
using System.Threading.Tasks;

namespace Underscore.Function
{
    public interface ISynchComponent
    {
        /// <summary>
        /// Creates a new Debounced version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <param name="action">The action to debounce</param>
        /// <param name="milliseconds">The action to debounce</param>
        /// <returns></returns>
        Func<Task<TResult>> Debounce<TResult>( Func<TResult> function, int milliseconds );

        /// <summary>
        /// Creates a new Debounced version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to debounce</param>
        /// <param name="milliseconds">The action to debounce</param>
        /// <returns></returns>
        Func<T,Task<TResult>> Debounce<T,TResult>( Func<T, TResult> function, int milliseconds );

        /// <summary>
        /// Creates a new Debounced version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to debounce</param>
        /// <param name="milliseconds">The action to debounce</param>
        /// <returns></returns>
        Func<T1,T2,Task<TResult>> Debounce<T1,T2, TResult>( Func<T1,T2, TResult> function, int milliseconds );

        /// <summary>
        /// Creates a new Debounced version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to debounce</param>
        /// <param name="milliseconds">The action to debounce</param>
        /// <returns></returns>
        Func<T1,T2,T3, Task<TResult>> Debounce<T1,T2,T3, TResult>( Func<T1,T2,T3, TResult> function, int milliseconds );

        /// <summary>
        /// Creates a new Debounced version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to debounce</param>
        /// <param name="milliseconds">The action to debounce</param>
        /// <returns></returns>
        Func<T1,T2,T3,T4, Task<TResult>> Debounce<T1,T2,T3,T4, TResult>( Func<T1,T2,T3,T4, TResult> function, int milliseconds );

        /// <summary>
        /// Creates a new Debounced version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to debounce</param>
        /// <param name="milliseconds">The action to debounce</param>
        /// <returns></returns>
        Func<T1,T2,T3,T4,T5, Task<TResult>> Debounce<T1,T2,T3,T4,T5, TResult>( Func<T1,T2,T3,T4,T5, TResult> function, int milliseconds );

        /// <summary>
        /// Creates a new Debounced version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to debounce</param>
        /// <param name="milliseconds">The action to debounce</param>
        /// <returns></returns>
        Func<T1,T2,T3,T4,T5,T6,Task<TResult>> Debounce<T1,T2,T3,T4,T5,T6, TResult>( Func<T1,T2,T3,T4,T5,T6, TResult> function, int milliseconds );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<Task<TResult>> Throttle<TResult>( Func<TResult> function, int milliseconds );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<Task<TResult>> Throttle<TResult>( Func<TResult> function, int milliseconds, bool leading );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T,Task<TResult>> Throttle<T, TResult>( Func<T, TResult> function, int milliseconds, bool leading );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T, Task<TResult>> Throttle<T, TResult>(Func<T, TResult> function, int milliseconds);

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2,Task<TResult>> Throttle<T1, T2, TResult>( Func<T1, T2, TResult> function, int milliseconds );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2 , Task<TResult>> Throttle<T1, T2, TResult>( Func<T1, T2, TResult> function, int milliseconds, bool leading );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3,Task<TResult>> Throttle<T1, T2, T3, TResult>( Func<T1, T2, T3, TResult> function, int milliseconds );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3 , Task<TResult>> Throttle<T1, T2, T3, TResult>( Func<T1, T2, T3, TResult> function, int milliseconds, bool leading );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, Task<TResult>> Throttle<T1, T2, T3, T4, TResult>( Func<T1, T2, T3, T4, TResult> function, int milliseconds );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3, T4 , Task<TResult>> Throttle<T1, T2, T3, T4, TResult>( Func<T1, T2, T3, T4, TResult> function, int milliseconds, bool leading );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, Task<TResult>> Throttle<T1, T2, T3, T4, T5, TResult>( Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5,Task<TResult>> Throttle<T1, T2, T3, T4, T5, TResult>( Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds, bool leading );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, TResult>( Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6 , Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, TResult>( Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds, bool leading );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<Task<TResult>> Delay<TResult>( Func<TResult> function, int milliseconds);

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T, Task<TResult>> Delay<T, TResult>( Func<T, TResult> function, int milliseconds);

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, Task<TResult>> Delay<T1, T2, TResult>( Func<T1, T2, TResult> function, int milliseconds );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3, Task<TResult>> Delay<T1, T2, T3, TResult>( Func<T1, T2, T3, TResult> function, int milliseconds );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, Task<TResult>> Delay<T1, T2, T3, T4, TResult>( Func<T1, T2, T3, T4, TResult> function, int milliseconds );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5,Task<TResult>> Delay<T1, T2, T3, T4, T5, TResult>( Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6,Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, TResult>( Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<TResult>Once<TResult>( Func<TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T, TResult> Once<T, TResult>( Func<T, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1,T2, TResult> Once<T1,T2, TResult>( Func<T1,T2, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2,T3, TResult> Once<T1, T2,T3, TResult>( Func<T1, T2,T3, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3,T4, TResult> Once<T1, T2, T3,T4, TResult>( Func<T1, T2, T3,T4, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4,T5, TResult> Once<T1, T2, T3, T4,T5, TResult>( Func<T1, T2, T3, T4,T5, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5,T6, TResult> Once<T1, T2, T3, T4, T5,T6, TResult>( Func<T1, T2, T3, T4, T5,T6, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6,T7, TResult> Once<T1, T2, T3, T4, T5, T6,T7, TResult>( Func<T1, T2, T3, T4, T5, T6,T7, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7,T8, TResult> Once<T1, T2, T3, T4, T5, T6, T7,T8, TResult>( Func<T1, T2, T3, T4, T5, T6, T7,T8, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8,T9, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8,T9, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8,T9, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9,T10, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9,T10, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9,T10, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,T11, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,T11, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,T11, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,T12, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,T12, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,T12, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,T13, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,T13, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,T13, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,T14, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,T14, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,T14, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,T15, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16, TResult> function );


        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<Task<TResult>> After<TResult>( int count , Func<TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T, Task<TResult> > After<T, TResult>( int count , Func<T, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, Task<TResult> > After<T1, T2, TResult>( int count , Func<T1, T2, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, Task<TResult> > After<T1, T2, T3, TResult>( int count , Func<T1, T2, T3, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, Task<TResult> > After<T1, T2, T3, T4, TResult>( int count , Func<T1, T2, T3, T4, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, Task<TResult> > After<T1, T2, T3, T4, T5, TResult>( int count , Func<T1, T2, T3, T4, T5, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, Task<TResult> > After<T1, T2, T3, T4, T5, T6, TResult>( int count , Func<T1, T2, T3, T4, T5, T6, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult> > After<T1, T2, T3, T4, T5, T6, T7, TResult>( int count , Func<T1, T2, T3, T4, T5, T6, T7, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult> > After<T1, T2, T3, T4, T5, T6, T7, T8, TResult>( int count , Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult> > After<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>( int count , Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult> > After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>( int count , Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult> > After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>( int count , Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult> > After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>( int count , Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>( int count , Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute After
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult> > After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>( int count , Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult> > After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( int count , Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function );


        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<TResult> Before<TResult>( int count, Func<TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T, TResult> Before<T, TResult>( int count, Func<T, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, TResult> Before<T1, T2, TResult>( int count, Func<T1, T2, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, TResult> Before<T1, T2, T3, TResult>( int count, Func<T1, T2, T3, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, TResult> Before<T1, T2, T3, T4, TResult>( int count, Func<T1, T2, T3, T4, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, TResult> Before<T1, T2, T3, T4, T5, TResult>( int count, Func<T1, T2, T3, T4, T5, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, TResult> Before<T1, T2, T3, T4, T5, T6, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, TResult> Before<T1, T2, T3, T4, T5, T6, T7, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute Before
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function );
   

    }
}
