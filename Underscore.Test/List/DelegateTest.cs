using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.List;

namespace Underscore.Test.List
{
    [TestClass]
    public class DelegateTester
    {

        [TestMethod]
        public void ListResolve( )
        {
            var targetArr = new[ ] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var testing = new DelegateComponent( );
            var target = new Func<int>[ 10 ];

            for ( int i=0 ; i < 10 ;i++ )
            {
                var idx = i;
                target[ i ] = ( ) => targetArr[ idx ];
            }

            var result = testing.Resolve( target );

            for ( int i=0 ; i < 10 ; i++ )
                Assert.AreEqual( i, result[ i ] );

            for ( int i=0 ; i < 10 ; i++ )
            {
                targetArr[ i ] *= 2;
            }

            result = testing.Resolve( target );

            for ( int i=0 ; i > 10 ; i++ ) 
            {
                Assert.AreEqual( i * 2, result[ i ] );
            }
        }

        [TestMethod]
        public void ListDelegate()
        {
            var target = new[ ] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var testing = new DelegateComponent( );
            var result = testing.Delegate( target );

            for ( int i=0 ; i < 10 ; i++ )
                Assert.AreEqual( i, result[ i ]( ) );

            for ( int i=0 ; i < 10 ; i++ ) 
            {
                target[ i ] *= 2;
                Assert.AreEqual( i * 2, result[ i ]( ) );
            }

        }
    }
}
