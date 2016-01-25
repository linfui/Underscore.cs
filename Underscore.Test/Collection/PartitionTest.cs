using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Collection;
using Underscore.Utility;

namespace Underscore.Test.Collection
{
    [TestClass]
    public class Partition 
    {

        [TestMethod]
        public async Task CollectionChunk( )
        {
            await Util.Tasks.Start( ( ) =>
            {

                var target = new[ ] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                var testing = new PartitionComponent(new Underscore.List.PartitionComponent(new MathComponent()));
                var result = testing.Chunk( target, 2 );

                //testing even distribution
                Assert.AreEqual( 5, result.Count( ) );

                foreach ( var coll in result )
                    Assert.AreEqual( 2, coll.Count( ) );

                var chunk = result.First( );

                Assert.AreEqual( 0, chunk.First( ) );
                Assert.AreEqual( 1, chunk.Skip( 1 ).First( ) );

                chunk = result.Skip( 1 ).First( );

                Assert.AreEqual( 2, chunk.First( ) );
                Assert.AreEqual( 3, chunk.Skip( 1 ).First( ) );

                chunk = result.Skip( 2 ).First( );

                Assert.AreEqual( 4, chunk.First( ) );
                Assert.AreEqual( 5, chunk.Skip( 1 ).First( ) );

                chunk = result.Skip( 3 ).First( );

                Assert.AreEqual( 6, chunk.First( ) );
                Assert.AreEqual( 7, chunk.Skip( 1 ).First( ) );

                chunk = result.Skip( 4 ).First( );

                Assert.AreEqual( 8, chunk.First( ) );
                Assert.AreEqual( 9, chunk.Skip( 1 ).First( ) );

                result = testing.Chunk( target, 3 );

                Assert.AreEqual( 4, result.Count( ) );

                chunk = result.First( );

                Assert.AreEqual( 3, chunk.Count( ) );

                Assert.AreEqual( 0, chunk.First( ) );
                Assert.AreEqual( 1, chunk.Skip( 1 ).First( ) );
                Assert.AreEqual( 2, chunk.Skip( 2 ).First( ) );

                chunk = result.Skip( 1 ).First( );

                Assert.AreEqual( 3, chunk.Count( ) );

                Assert.AreEqual( 3, chunk.First( ) );
                Assert.AreEqual( 4, chunk.Skip( 1 ).First( ) );
                Assert.AreEqual( 5, chunk.Skip( 2 ).First( ) );

                chunk = result.Skip( 2 ).First( );

                Assert.AreEqual( 3, chunk.Count( ) );

                Assert.AreEqual( 6, chunk.First( ) );
                Assert.AreEqual( 7, chunk.Skip( 1 ).First( ) );
                Assert.AreEqual( 8, chunk.Skip( 2 ).First( ) );

                chunk = result.Skip( 3 ).First( );
                Assert.AreEqual( 1, chunk.Count( ) );
                Assert.AreEqual( 9, chunk.First( ) );

                result = testing.Chunk( target, 11 );
                Assert.AreEqual( 1, result.Count( ) );

                chunk = result.First( );
                Assert.AreEqual( 10, chunk.Count( ) );

                for ( var i = 0 ; i < target.Count( ) ; i++ )
                {
                    Assert.AreEqual( target.ElementAt( i ), chunk.ElementAt( i ) );
                }

            }, ( ) =>
            {
                var target = new[ ] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                var testing = new PartitionComponent(new Underscore.List.PartitionComponent(new MathComponent()));
                var result = testing.Chunk( target, a => a > 0 && a % 3 == 0 );

                foreach ( var chunk in result )
                {
                    for ( int i=0 ; i < chunk.Count( ) ; i++ )
                    {
                        Assert.AreEqual( i, chunk.ElementAt( i ) % 3 );
                    }
                }

            } );
        }

        [TestMethod]
        public async Task CollectionPartition( )
        {
            await Util.Tasks.Start( ( ) =>
            {

                var target = new[ ] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                var testing = new PartitionComponent(new Underscore.List.PartitionComponent(new MathComponent()));

                for ( int i=0 ; i < target.Count( ) ; i++ )
                {
                    var result = testing.Partition( target, i );
                    int j=0;
                    for ( ; j < i ; j++ )
                    {
                        Assert.AreEqual( j, result.Item1.ElementAt( j ) );
                    }

                    for ( ; j < target.Length ; j++ )
                    {
                        Assert.AreEqual( j, result.Item2.ElementAt( j - i ) );
                    }
                }

            }, ( ) =>
            {
                var target = new[ ] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                var testing = new global::Underscore.List.PartitionComponent( new MathComponent( ) );
                var result = testing.Partition( target, a => a > 0 && a % 3 == 0 );

                Assert.AreEqual( 3, result.Item1.Count( ) );

                for ( int i=0 ; i < 3 ; i++ )
                    Assert.AreEqual( i, result.Item1.ElementAt( i ) );

                for ( int i=0 ; i < result.Item2.Count( ) ; i++ )
                    Assert.AreEqual( i + 3, result.Item2.ElementAt( i ) );

            } );
        }

        [TestMethod]
        public void CollectionCombinations_Unit()
        {
            var testing = new PartitionComponent(new Underscore.List.PartitionComponent(new MathComponent()));
            CollectionCombinationsImpl(testing.Combinations);
        }

        [TestMethod]
        public void CollectionCombinations_Integration()
        {
            var testing = new Func<IEnumerable<int>, IEnumerable<IEnumerable<int>>>(_.Collection.Combinations);
            CollectionCombinationsImpl(testing);
        }

        private static void CollectionCombinationsImpl(Func<IEnumerable<int>, IEnumerable<IEnumerable<int>>> testing)
        {
            int[] stuff = { 1, 2, 3, 4 };

            int[][] expecting = new[]
            {
                new int[] {},
                new[] {1},
                new[] {1, 2},
                new[] {2},
                new[] {1, 2, 3},
                new[] {2, 3},
                new[] {1, 3},
                new[] {3},
                new[] {1, 2, 3, 4},
                new[] {1, 2, 4},
                new[] {1, 3, 4},
                new[] {2, 3, 4},
                new[] {3, 4},
                new[] {2, 4},
                new[] {1, 4},
                new[] {4}
            };

            var permutation = testing(stuff).Select(a => a.ToList()).ToList();

            Assert.IsTrue(
                expecting.Select(i => permutation.Any(a => a.Count == i.Length && a.All(i.Contains))).All(b => b));
        }


    }
}
