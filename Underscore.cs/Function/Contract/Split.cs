﻿using System;

namespace Underscore.Function
{
    public interface ISplitComponent 
    {

        /// <summary>
        /// Halves the passed action as function that returns action that can invoke the passed action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function"></param>
        /// <returns>
        /// a function taking first half of arguments 
        /// that returns an action that takes the other half, 
        /// invocation of returned method would be the same as invoking
        /// the passed action with all parameters from the first function call
        /// and the following action call
        /// </returns>
        Func<T0, Func<T1, TResult>> Split<T0, T1, TResult>( Func<T0, T1, TResult> function );


        /// <summary>
        /// Halves the passed action as function that returns action that can invoke the passed action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>  
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to split</param>
        /// <returns>
        /// a function taking first half of arguments 
        /// that returns an action that takes the other half, 
        /// invocation of returned method would be the same as invoking
        /// the passed action with all parameters from the first function call
        /// and the following action call
        /// </returns>
        Func<T0, T1, Func<T2, T3, TResult>> Split<T0, T1, T2, T3, TResult>( Func<T0, T1, T2, T3, TResult> function );


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
        /// <param name="function">action to split</param>
        /// <returns>
        /// a function taking first half of arguments 
        /// that returns an action that takes the other half, 
        /// invocation of returned method would be the same as invoking
        /// the passed action with all parameters from the first function call
        /// and the following action call
        /// </returns>
        Func<T0, T1, T2, T3, Func<T4, T5, T6, T7, TResult>> Split<T0, T1, T2, T3, T4, T5, T6, T7, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, TResult> function );


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
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to split</param>
        /// <returns>
        /// a function taking first half of arguments 
        /// that returns an action that takes the other half, 
        /// invocation of returned method would be the same as invoking
        /// the passed action with all parameters from the first function call
        /// and the following action call
        /// </returns>
        Func<T0, T1, T2, T3, T4, T5, T6, T7, Func<T8, T9, T10, T11, T12, T13, T14, T15, TResult>> Split<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function );


        /// <summary>
        /// Splits an action into a chain of functions 
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, TResult>>
            Splay<T0, T1, TResult>( Func<T0, T1, TResult> function );



        /// <summary>
        /// Splits an action into a chain of functions 
        /// each accepting one parameter associated cardinally 
        /// to the passed actions parameters
        /// final call is an action
        /// </summary>
        /// <typeparam name="T0"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, TResult>>>
            Splay<T0, T1, T2, TResult>( Func<T0, T1, T2, TResult> function );


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
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, TResult>>>>
            Splay<T0, T1, T2, T3, TResult>( Func<T0, T1, T2, T3, TResult> function );



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
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>>>
            Splay<T0, T1, T2, T3, T4, TResult>( Func<T0, T1, T2, T3, T4, TResult> function );


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
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>>>
            Splay<T0, T1, T2, T3, T4, T5, TResult>( Func<T0, T1, T2, T3, T4, T5, TResult> function );


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
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>>>
            Splay<T0, T1, T2, T3, T4, T5, T6, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, TResult> function );


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
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>>>>
            Splay<T0, T1, T2, T3, T4, T5, T6, T7, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, TResult> function );


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
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>>>>
            Splay<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult> function );


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
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>>>>>>
            Splay<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function );


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
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>>>>>>
            Splay<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function );


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
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>>>>>>
            Splay<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function );


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
        /// <typeparam name="TResult"></typeparam>
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>>>>>>
    Splay<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function );


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
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>>>>>>
            Splay<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function );


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
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>>>>>>
            Splay<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function );



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
        /// <param name="function">action to splay</param>
        /// <returns>Function chain resolving back to passed action</returns>
        Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>>>>>>
            Splay<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function );


    }
}
