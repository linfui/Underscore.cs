using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.List;

namespace Underscore.Test.List
{
    [TestClass]
    public class Manipulate 
    {
        [TestMethod]
        public void ListSwap()
        {
            var testing = new ManipulateComponent( );
            var arr = new[ ] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //reverse list in place
            for ( int i=0 ; i < 5 ; i++ ) 
            {
                testing.Swap( arr, i, 9 - i );
            }

            for ( int i=0 ; i <=9 ; i++ ) 
            {
                Assert.AreEqual( 9 - i, arr[ i ] );
            }
        }

        [TestMethod]
        public void ListShuffle()
        {
            List<int> arr = Enumerable.Range(0,100).ToList();
            var testing = new ManipulateComponent( );
            //test shuffle 5 times, see how random is

            int comparisionCount = 0;

            for ( int j=0 ; j < 5 ; j++ )
            {
                var container = new List<IList<int>>( );

                for ( int i=0 ; i < 5 ; i++ )
                    container.Add( testing.Shuffle( arr ) );

                comparisionCount = 0;
                // 
                // no more than 20 matching instances
                // this should suffice for randomness test
                for ( int i=0 ; i < arr.Count ; i++ )
                {
                    var st = new HashSet<int>( );
                    for ( int k=0 ; k < container.Count ; k++ )
                    {
                        if ( !st.Add( container[ k ][ i ] ) )
                            comparisionCount++;
                    }
                }
                if(comparisionCount < 25)
                    break;

            }

            Assert.IsTrue( comparisionCount < 25 );

            for ( int i=0 ; i < 5 ; i++ )
            {
                List<int> cmp = Enumerable.Range( 0, 100 ).ToList( );

                testing.Shuffle( arr, true );

                comparisionCount = 0;

                for ( int j=0 ; j < arr.Count ; j++ )
                    if ( arr[ j ] == cmp[ j ] )
                        comparisionCount++;

                if ( comparisionCount < 15 )
                    break;
            }

            Assert.IsTrue( comparisionCount < 15 );
        }

        [TestMethod]
        public void ListRotate()
        {
            var testing = new ManipulateComponent();
            var arr = new[ ] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int shiftl = -3;

            //left shift
            testing.Rotate( arr, shiftl );

            Assert.AreEqual( arr[ 0 ], 3 );
            Assert.AreEqual( arr[ 1 ], 4 );
            Assert.AreEqual( arr[ 2 ], 5 );
            Assert.AreEqual( arr[ 3 ], 6 );
            Assert.AreEqual( arr[ 4 ], 7 );
            Assert.AreEqual( arr[ 5 ], 8 );
            Assert.AreEqual( arr[ 6 ], 9 );
            Assert.AreEqual( arr[ 7 ], 0 );
            Assert.AreEqual( arr[ 8 ], 1 );
            Assert.AreEqual( arr[ 9 ], 2 );

            //right shift back to normal
            testing.Rotate( arr, -shiftl );


            Assert.AreEqual( arr[ 0 ], 0 );
            Assert.AreEqual( arr[ 1 ], 1 );
            Assert.AreEqual( arr[ 2 ], 2 );
            Assert.AreEqual( arr[ 3 ], 3 );
            Assert.AreEqual( arr[ 4 ], 4 );
            Assert.AreEqual( arr[ 5 ], 5 );
            Assert.AreEqual( arr[ 6 ], 6 );
            Assert.AreEqual( arr[ 7 ], 7 );
            Assert.AreEqual( arr[ 8 ], 8 );
            Assert.AreEqual( arr[ 9 ], 9 );

            var shiftr = 5;
            //right shift again
            testing.Rotate( arr, shiftr );

            Assert.AreEqual( arr[ 0 ], 5 );
            Assert.AreEqual( arr[ 1 ], 6 );
            Assert.AreEqual( arr[ 2 ], 7 );
            Assert.AreEqual( arr[ 3 ], 8 );
            Assert.AreEqual( arr[ 4 ], 9 );
            Assert.AreEqual( arr[ 5 ], 0 );
            Assert.AreEqual( arr[ 6 ], 1 );
            Assert.AreEqual( arr[ 7 ], 2 );
            Assert.AreEqual( arr[ 8 ], 3 );
            Assert.AreEqual( arr[ 9 ], 4 );


            shiftl = -12;
            //testing overflow shift
            //should be equiv to shift two left
            testing.Rotate( arr, shiftl );

            Assert.AreEqual( arr[ 0 ], 7 );
            Assert.AreEqual( arr[ 1 ], 8 );
            Assert.AreEqual( arr[ 2 ], 9 );
            Assert.AreEqual( arr[ 3 ], 0 );
            Assert.AreEqual( arr[ 4 ], 1 );
            Assert.AreEqual( arr[ 5 ], 2 );
            Assert.AreEqual( arr[ 6 ], 3 );
            Assert.AreEqual( arr[ 7 ], 4 );
            Assert.AreEqual( arr[ 8 ], 5 );
            Assert.AreEqual( arr[ 9 ], 6 );

            shiftr = 15;
            //should be equiv to shift two right
            testing.Rotate( arr, shiftr );


            Assert.AreEqual( arr[ 0 ], 2 );
            Assert.AreEqual( arr[ 1 ], 3 );
            Assert.AreEqual( arr[ 2 ], 4 );
            Assert.AreEqual( arr[ 3 ], 5 );
            Assert.AreEqual( arr[ 4 ], 6 );
            Assert.AreEqual( arr[ 5 ], 7 );
            Assert.AreEqual( arr[ 6 ], 8 );
            Assert.AreEqual( arr[ 7 ], 9 );
            Assert.AreEqual( arr[ 8 ], 0 );
            Assert.AreEqual( arr[ 9 ], 1 );




        }

        [TestMethod]
        public void ListSample()
        {
            var target = Enumerable.Range( 0, 100 ).ToList( );
            var testing = new ManipulateComponent( );

            IList<int> result = testing.Sample( target );

            foreach(var i in result)
                Assert.IsTrue(i>=0 && i<100);

            result = testing.Sample( target, 25 );

            Assert.AreEqual(25, result.Count);

            foreach ( var i in result )
                Assert.IsTrue( i >= 0 && i < 100 );

            result = testing.Sample( target, 25 ,true);

            var set = new HashSet<int>( );

            Assert.AreEqual(25, result.Count);

            foreach ( var i in result )
                Assert.IsTrue( set.Add( i ) );

            result = testing.Sample( target, 200, false );
            Assert.AreEqual( 200, result.Count );

            foreach ( var i in result )
                Assert.IsTrue( i >= 0 && i < 100 );

        }



        [TestMethod]
        public void ListExtend()
        {
            var target = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var testing = new ManipulateComponent();
            var result = testing.Extend(target, 20).ToList();

            Assert.AreEqual(20, result.Count);

            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(target[i % 10], result[i]);
            }

        }



        [TestMethod]
        public void ListInfinite()
        {
            var target = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var testing = new ManipulateComponent();
            var result = testing.Cycle(target);

            for (int i = 0; i < 1000; i++)
            {
                Assert.AreEqual(target[i % 10], result.ElementAt(i));
            }
        }
    }
}
