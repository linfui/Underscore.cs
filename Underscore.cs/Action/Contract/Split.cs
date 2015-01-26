﻿using System;

namespace Underscore.Action
{
    public interface ISplitComponent 
    {
        /// <summary>
        /// Halves the passed action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T15"></typeparam>
        /// <param name="action">action to split</param>
        /// <returns>
        /// a function taking first half of arguments 
        /// that returns an action that takes the other half, 
        /// invocation of returned method would be the same as invoking
        /// the passed action with all parameters from the first function call
        /// and the following action call
        /// </returns>
        Func<T0, T1, T2, T3, T4, T5, T6, T7, Action<T8, T9, T10, T11, T12, T13, T14, T15>> Split<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>( Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action );


       /// <summary>
       /// Halves the passed action as function that returns action that can invoke the passed action
       /// </summary>
       /// <typeparam name="T0"></typeparam>
       /// <typeparam name="T1"></typeparam>
       /// <typeparam name="T2"></typeparam>
       /// <typeparam name="T3"></typeparam>
       /// <typeparam name="T4"></typeparam>
       /// <typeparam name="T5"></typeparam>
       /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>        
        /// <param name="action">action to split</param>
        /// <returns>
        /// a function taking first half of arguments 
        /// that returns an action that takes the other half, 
        /// invocation of returned method would be the same as invoking
        /// the passed action with all parameters from the first function call
        /// and the following action call
        /// </returns>
        Func<T0, T1, T2, T3, Action<T4, T5, T6, T7>> Split<T0, T1, T2, T3, T4, T5, T6, T7>( Action<T0, T1, T2, T3, T4, T5, T6, T7> action );


        /// <summary>
        /// Halves the passed action as function that returns action that can invoke the passed action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>        
        /// <param name="action">action to split</param>
        /// <returns>
        /// a function taking first half of arguments 
        /// that returns an action that takes the other half, 
        /// invocation of returned method would be the same as invoking
        /// the passed action with all parameters from the first function call
        /// and the following action call
        /// </returns>
        Func<T0, T1, Action<T2, T3>> Split<T0, T1, T2, T3>( Action<T0, T1, T2, T3> action );

        /// <summary>
        /// Halves the passed action as function that returns action that can invoke the passed action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <param name="action"></param>
        /// <returns>
        /// a function taking first half of arguments 
        /// that returns an action that takes the other half, 
        /// invocation of returned method would be the same as invoking
        /// the passed action with all parameters from the first function call
        /// and the following action call
        /// </returns>
        Func<T0, Action<T1>> Split<T0, T1>( Action<T0, T1> action );

        /// <summary>
        /// Splits an action into a chain of functions 
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T15"></typeparam>
        /// <param name="action">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14,Action<T15>>>>>>>>>>>>>>>>
            Splay<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,T15>( Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,T15> action );


        /// <summary>
        /// Splits an action into a chain of functions 
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <param name="action">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Action<T14>>>>>>>>>>>>>>>
            Splay<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14 >( Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14 > action );


        /// <summary>
        /// Splits an action into a chain of functions 
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <param name="action">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Action<T13>>>>>>>>>>>>>>
            Splay<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13 >( Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13 > action );


        /// <summary>
        /// Splits an action into a chain of functions 
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <param name="action">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Action<T12>>>>>>>>>>>>>
            Splay<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12 >( Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12 > action );


        /// <summary>
        /// Splits an action into a chain of functions 
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <param name="action">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Action<T11>>>>>>>>>>>>
            Splay<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11 >( Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11 > action );


        /// <summary>
        /// Splits an action into a chain of functions 
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <param name="action">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Action<T10>>>>>>>>>>>
            Splay<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10 >( Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10 > action );


        /// <summary>
        /// Splits an action into a chain of functions 
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <param name="action">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Action<T9>>>>>>>>>>
            Splay<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9 >( Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9 > action );


        /// <summary>
        /// Splits an action into a chain of functions 
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <param name="action">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Action<T8>>>>>>>>>
            Splay<T0, T1, T2, T3, T4, T5, T6, T7, T8 >( Action<T0, T1, T2, T3, T4, T5, T6, T7, T8 > action );

        /// <summary>
        /// Splits an action into a chain of functions 
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="action">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>>>
            Splay<T0, T1, T2, T3, T4, T5, T6, T7>( Action<T0, T1, T2, T3, T4, T5, T6, T7 > action );

        /// <summary>
        /// Splits an action into a chain of functions 
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <param name="action">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>>>
            Splay<T0, T1, T2, T3, T4, T5, T6>( Action<T0, T1, T2, T3, T4, T5, T6> action );


        /// <summary>
        /// Splits an action into a chain of functions 
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <param name="action">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Action<T5 >>>>>>
            Splay<T0, T1, T2, T3, T4, T5 >( Action<T0, T1, T2, T3, T4, T5 > action );

        /// <summary>
        /// Splits an action into a chain of functions 
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <param name="action">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Action<T4 >>>>>
            Splay<T0, T1, T2, T3, T4 >( Action<T0, T1, T2, T3, T4 > action );


        /// <summary>
        /// Splits an action into a chain of functions 
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <param name="action">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Action<T3 >>>>
            Splay<T0, T1, T2, T3 >( Action<T0, T1, T2, T3 > action );



        /// <summary>
        /// Splits an action into a chain of functions 
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="action">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Action<T2 >>>
            Splay<T0, T1, T2 >( Action<T0, T1, T2 > action );



        /// <summary>
        /// Splits an action into a chain of functions 
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <param name="action">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Action<T1 >>
            Splay<T0, T1 >( Action<T0, T1 > action );
        
    }

}
