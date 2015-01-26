﻿using System;
using System.Linq;

// This code has been automatically generated
// if you want to make changes make them on 
// the corresponding the text template file
// Compose.tt
namespace Underscore.Action
{

	public class ComposeComponent : IComposeComponent
	{

		
        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
		public void Apply<T>( Action<T> action , T[] arguments  )
		{
			action( arguments[0] ) ;
		}
		
				
        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
		public void Apply<T>( Action<T, T> action , T[] arguments  )
		{
			action( arguments[0] , arguments[1] ) ;
		}
		
				
        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
		public void Apply<T>( Action<T, T, T> action , T[] arguments  )
		{
			action( arguments[0] , arguments[1] , arguments[2] ) ;
		}
		
				
        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
		public void Apply<T>( Action<T, T, T, T> action , T[] arguments  )
		{
			action( arguments[0] , arguments[1] , arguments[2] , arguments[3] ) ;
		}
		
				
        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
		public void Apply<T>( Action<T, T, T, T, T> action , T[] arguments  )
		{
			action( arguments[0] , arguments[1] , arguments[2] , arguments[3] , arguments[4] ) ;
		}
		
				
        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
		public void Apply<T>( Action<T, T, T, T, T, T> action , T[] arguments  )
		{
			action( arguments[0] , arguments[1] , arguments[2] , arguments[3] , arguments[4] , arguments[5] ) ;
		}
		
				
        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
		public void Apply<T>( Action<T, T, T, T, T, T, T> action , T[] arguments  )
		{
			action( arguments[0] , arguments[1] , arguments[2] , arguments[3] , arguments[4] , arguments[5] , arguments[6] ) ;
		}
		
				
        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
		public void Apply<T>( Action<T, T, T, T, T, T, T, T> action , T[] arguments  )
		{
			action( arguments[0] , arguments[1] , arguments[2] , arguments[3] , arguments[4] , arguments[5] , arguments[6] , arguments[7] ) ;
		}
		
				
        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
		public void Apply<T>( Action<T, T, T, T, T, T, T, T, T> action , T[] arguments  )
		{
			action( arguments[0] , arguments[1] , arguments[2] , arguments[3] , arguments[4] , arguments[5] , arguments[6] , arguments[7] , arguments[8] ) ;
		}
		
				
        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
		public void Apply<T>( Action<T, T, T, T, T, T, T, T, T, T> action , T[] arguments  )
		{
			action( arguments[0] , arguments[1] , arguments[2] , arguments[3] , arguments[4] , arguments[5] , arguments[6] , arguments[7] , arguments[8] , arguments[9] ) ;
		}
		
				
        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
		public void Apply<T>( Action<T, T, T, T, T, T, T, T, T, T, T> action , T[] arguments  )
		{
			action( arguments[0] , arguments[1] , arguments[2] , arguments[3] , arguments[4] , arguments[5] , arguments[6] , arguments[7] , arguments[8] , arguments[9] , arguments[10] ) ;
		}
		
				
        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
		public void Apply<T>( Action<T, T, T, T, T, T, T, T, T, T, T, T> action , T[] arguments  )
		{
			action( arguments[0] , arguments[1] , arguments[2] , arguments[3] , arguments[4] , arguments[5] , arguments[6] , arguments[7] , arguments[8] , arguments[9] , arguments[10] , arguments[11] ) ;
		}
		
				
        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
		public void Apply<T>( Action<T, T, T, T, T, T, T, T, T, T, T, T, T> action , T[] arguments  )
		{
			action( arguments[0] , arguments[1] , arguments[2] , arguments[3] , arguments[4] , arguments[5] , arguments[6] , arguments[7] , arguments[8] , arguments[9] , arguments[10] , arguments[11] , arguments[12] ) ;
		}
		
				
        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
		public void Apply<T>( Action<T, T, T, T, T, T, T, T, T, T, T, T, T, T> action , T[] arguments  )
		{
			action( arguments[0] , arguments[1] , arguments[2] , arguments[3] , arguments[4] , arguments[5] , arguments[6] , arguments[7] , arguments[8] , arguments[9] , arguments[10] , arguments[11] , arguments[12] , arguments[13] ) ;
		}
		
				
        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
		public void Apply<T>( Action<T, T, T, T, T, T, T, T, T, T, T, T, T, T, T> action , T[] arguments  )
		{
			action( arguments[0] , arguments[1] , arguments[2] , arguments[3] , arguments[4] , arguments[5] , arguments[6] , arguments[7] , arguments[8] , arguments[9] , arguments[10] , arguments[11] , arguments[12] , arguments[13] , arguments[14] ) ;
		}
		
				
        /// <summary>
        /// Calls a function using the passed array of arguments
        /// </summary>
		public void Apply<T>( Action<T, T, T, T, T, T, T, T, T, T, T, T, T, T, T, T> action , T[] arguments  )
		{
			action( arguments[0] , arguments[1] , arguments[2] , arguments[3] , arguments[4] , arguments[5] , arguments[6] , arguments[7] , arguments[8] , arguments[9] , arguments[10] , arguments[11] , arguments[12] , arguments[13] , arguments[14] , arguments[15] ) ;
		}
		
				
        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
		public void Call<T1>( Action<T1> action ,T1 a )
		{
			action ( a ) ;
		}
				
        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
		public void Call<T1, T2>( Action<T1, T2> action ,T1 a ,T2 b )
		{
			action ( a, b ) ;
		}
				
        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
		public void Call<T1, T2, T3>( Action<T1, T2, T3> action ,T1 a ,T2 b ,T3 c )
		{
			action ( a, b, c ) ;
		}
				
        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
		public void Call<T1, T2, T3, T4>( Action<T1, T2, T3, T4> action ,T1 a ,T2 b ,T3 c ,T4 d )
		{
			action ( a, b, c, d ) ;
		}
				
        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
		public void Call<T1, T2, T3, T4, T5>( Action<T1, T2, T3, T4, T5> action ,T1 a ,T2 b ,T3 c ,T4 d ,T5 e )
		{
			action ( a, b, c, d, e ) ;
		}
				
        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
		public void Call<T1, T2, T3, T4, T5, T6>( Action<T1, T2, T3, T4, T5, T6> action ,T1 a ,T2 b ,T3 c ,T4 d ,T5 e ,T6 f )
		{
			action ( a, b, c, d, e, f ) ;
		}
				
        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
		public void Call<T1, T2, T3, T4, T5, T6, T7>( Action<T1, T2, T3, T4, T5, T6, T7> action ,T1 a ,T2 b ,T3 c ,T4 d ,T5 e ,T6 f ,T7 g )
		{
			action ( a, b, c, d, e, f, g ) ;
		}
				
        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
		public void Call<T1, T2, T3, T4, T5, T6, T7, T8>( Action<T1, T2, T3, T4, T5, T6, T7, T8> action ,T1 a ,T2 b ,T3 c ,T4 d ,T5 e ,T6 f ,T7 g ,T8 h )
		{
			action ( a, b, c, d, e, f, g, h ) ;
		}
				
        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
		public void Call<T1, T2, T3, T4, T5, T6, T7, T8, T9>( Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action ,T1 a ,T2 b ,T3 c ,T4 d ,T5 e ,T6 f ,T7 g ,T8 h ,T9 i )
		{
			action ( a, b, c, d, e, f, g, h, i ) ;
		}
				
        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
		public void Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>( Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action ,T1 a ,T2 b ,T3 c ,T4 d ,T5 e ,T6 f ,T7 g ,T8 h ,T9 i ,T10 j )
		{
			action ( a, b, c, d, e, f, g, h, i, j ) ;
		}
				
        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
		public void Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>( Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action ,T1 a ,T2 b ,T3 c ,T4 d ,T5 e ,T6 f ,T7 g ,T8 h ,T9 i ,T10 j ,T11 k )
		{
			action ( a, b, c, d, e, f, g, h, i, j, k ) ;
		}
				
        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
		public void Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>( Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action ,T1 a ,T2 b ,T3 c ,T4 d ,T5 e ,T6 f ,T7 g ,T8 h ,T9 i ,T10 j ,T11 k ,T12 l )
		{
			action ( a, b, c, d, e, f, g, h, i, j, k, l ) ;
		}
				
        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
		public void Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>( Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action ,T1 a ,T2 b ,T3 c ,T4 d ,T5 e ,T6 f ,T7 g ,T8 h ,T9 i ,T10 j ,T11 k ,T12 l ,T13 m )
		{
			action ( a, b, c, d, e, f, g, h, i, j, k, l, m ) ;
		}
				
        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
		public void Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>( Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action ,T1 a ,T2 b ,T3 c ,T4 d ,T5 e ,T6 f ,T7 g ,T8 h ,T9 i ,T10 j ,T11 k ,T12 l ,T13 m ,T14 n )
		{
			action ( a, b, c, d, e, f, g, h, i, j, k, l, m, n ) ;
		}
				
        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
		public void Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>( Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action ,T1 a ,T2 b ,T3 c ,T4 d ,T5 e ,T6 f ,T7 g ,T8 h ,T9 i ,T10 j ,T11 k ,T12 l ,T13 m ,T14 n ,T15 o )
		{
			action ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o ) ;
		}
				
        /// <summary>
        /// Calls the function passed with the given arguments as the parameters 
        /// </summary>
		public void Call<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>( Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action ,T1 a ,T2 b ,T3 c ,T4 d ,T5 e ,T6 f ,T7 g ,T8 h ,T9 i ,T10 j ,T11 k ,T12 l ,T13 m ,T14 n ,T15 o ,T16 p )
		{
			action ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p ) ;
		}
				
        /// <summary>
        /// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
        /// </summary>
		public Action<TStart> Compose<TStart, TEnd>(Func<TStart,TEnd> start, Action<TEnd> end)
		{
			return seed =>end ( start ( seed )  ) ;
		}
				
        /// <summary>
        /// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
        /// </summary>
		public Action<TStart> Compose<TStart, TMid, TEnd>(Func<TStart,TMid> start, Func<TMid,TEnd> mid, Action<TEnd> end)
		{
			return seed =>end ( mid ( start ( seed )  )  ) ;
		}
				
        /// <summary>
        /// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
        /// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TEnd> b, Action<TEnd> end)
		{
			return seed =>end ( b ( a ( start ( seed )  )  )  ) ;
		}
				
        /// <summary>
        /// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
        /// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TEnd> c, Action<TEnd> end)
		{
			return seed =>end ( c ( b ( a ( start ( seed )  )  )  )  ) ;
		}
				
        /// <summary>
        /// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
        /// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TEnd> d, Action<TEnd> end)
		{
			return seed =>end ( d ( c ( b ( a ( start ( seed )  )  )  )  )  ) ;
		}
				
        /// <summary>
        /// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
        /// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TEnd> e, Action<TEnd> end)
		{
			return seed =>end ( e ( d ( c ( b ( a ( start ( seed )  )  )  )  )  )  ) ;
		}
				
        /// <summary>
        /// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
        /// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TEnd> f, Action<TEnd> end)
		{
			return seed =>end ( f ( e ( d ( c ( b ( a ( start ( seed )  )  )  )  )  )  )  ) ;
		}
				
        /// <summary>
        /// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
        /// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TEnd> g, Action<TEnd> end)
		{
			return seed =>end ( g ( f ( e ( d ( c ( b ( a ( start ( seed )  )  )  )  )  )  )  )  ) ;
		}
				
        /// <summary>
        /// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
        /// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TEnd> h, Action<TEnd> end)
		{
			return seed =>end ( h ( g ( f ( e ( d ( c ( b ( a ( start ( seed )  )  )  )  )  )  )  )  )  ) ;
		}
				
        /// <summary>
        /// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
        /// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TLink9> h, Func<TLink9,TEnd> i, Action<TEnd> end)
		{
			return seed =>end ( i ( h ( g ( f ( e ( d ( c ( b ( a ( start ( seed )  )  )  )  )  )  )  )  )  )  ) ;
		}
				
        /// <summary>
        /// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
        /// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TLink9> h, Func<TLink9,TLink10> i, Func<TLink10,TEnd> j, Action<TEnd> end)
		{
			return seed =>end ( j ( i ( h ( g ( f ( e ( d ( c ( b ( a ( start ( seed )  )  )  )  )  )  )  )  )  )  )  ) ;
		}
				
        /// <summary>
        /// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
        /// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TLink9> h, Func<TLink9,TLink10> i, Func<TLink10,TLink11> j, Func<TLink11,TEnd> k, Action<TEnd> end)
		{
			return seed =>end ( k ( j ( i ( h ( g ( f ( e ( d ( c ( b ( a ( start ( seed )  )  )  )  )  )  )  )  )  )  )  )  ) ;
		}
				
        /// <summary>
        /// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
        /// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TLink9> h, Func<TLink9,TLink10> i, Func<TLink10,TLink11> j, Func<TLink11,TLink12> k, Func<TLink12,TEnd> l, Action<TEnd> end)
		{
			return seed =>end ( l ( k ( j ( i ( h ( g ( f ( e ( d ( c ( b ( a ( start ( seed )  )  )  )  )  )  )  )  )  )  )  )  )  ) ;
		}
				
        /// <summary>
        /// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
        /// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TLink13, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TLink9> h, Func<TLink9,TLink10> i, Func<TLink10,TLink11> j, Func<TLink11,TLink12> k, Func<TLink12,TLink13> l, Func<TLink13,TEnd> m, Action<TEnd> end)
		{
			return seed =>end ( m ( l ( k ( j ( i ( h ( g ( f ( e ( d ( c ( b ( a ( start ( seed )  )  )  )  )  )  )  )  )  )  )  )  )  )  ) ;
		}
				
        /// <summary>
        /// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
        /// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TLink13, TLink14, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TLink9> h, Func<TLink9,TLink10> i, Func<TLink10,TLink11> j, Func<TLink11,TLink12> k, Func<TLink12,TLink13> l, Func<TLink13,TLink14> m, Func<TLink14,TEnd> n, Action<TEnd> end)
		{
			return seed =>end ( n ( m ( l ( k ( j ( i ( h ( g ( f ( e ( d ( c ( b ( a ( start ( seed )  )  )  )  )  )  )  )  )  )  )  )  )  )  )  ) ;
		}
				
        /// <summary>
        /// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
        /// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TLink13, TLink14, TLink15, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TLink9> h, Func<TLink9,TLink10> i, Func<TLink10,TLink11> j, Func<TLink11,TLink12> k, Func<TLink12,TLink13> l, Func<TLink13,TLink14> m, Func<TLink14,TLink15> n, Func<TLink15,TEnd> o, Action<TEnd> end)
		{
			return seed =>end ( o ( n ( m ( l ( k ( j ( i ( h ( g ( f ( e ( d ( c ( b ( a ( start ( seed )  )  )  )  )  )  )  )  )  )  )  )  )  )  )  )  ) ;
		}
		
	    /// <summary>
        /// Creates a composition of actions taking the same result and input parameter
        /// </summary>
        public Action<T> Compose<T>( params Action<T>[ ] actions )
        {
			if(actions == null ) return null;
			
            return t  => actions.Aggregate( t, ( curr, next ) => { next( curr ); return curr; } );
        }

	}

}