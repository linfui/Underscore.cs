using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.List;
using Underscore.Utility;

namespace Underscore.Test.List
{

    [TestClass]
    public class PartitionTest
    {
        private PartitionComponent _testing = new PartitionComponent(new MathComponent());
        private int[] _target = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        

        [TestMethod]
        public void ListSplit(  )
        {
            var result = _testing.Split( _target );

            Assert.AreEqual( 5, result.Item1.Count );
            Assert.AreEqual( 5, result.Item2.Count );
            int ct = 0;

            for ( int i=0 ; i < 5 ; i++ ) 
            {
                Assert.AreEqual( ct, result.Item1[ i ] );
                ct++;
            }

            for ( int i=0 ; i < 5 ; i++ ) 
            {
                Assert.AreEqual( ct, result.Item2[ i ] );
                ct++;
            }

            result = _testing.Split( new[ ] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } );

            Assert.AreEqual( 6, result.Item1.Count );
            Assert.AreEqual( 5, result.Item2.Count );

            ct = 0;

            for ( int i=0 ; i < 6 ; i++ )
            {
                Assert.AreEqual( ct, result.Item1[ i ] );
                ct++;
            }

            for ( int i=0 ; i < 5 ; i++ )
            {
                Assert.AreEqual( ct, result.Item2[ i ] );
                ct++;
            }

        }

        [TestMethod]
        public void List_Chunk_IntArg()
        {

            var result = _testing.Chunk(_target, 2);

            //testing even distribution
            Assert.AreEqual(5, result.Count());

            foreach (var coll in result)
                Assert.AreEqual(2, coll.Count());

            var chunk = result.First();

            Assert.AreEqual(0, chunk.First());
            Assert.AreEqual(1, chunk.Skip(1).First());

            chunk = result.Skip(1).First();

            Assert.AreEqual(2, chunk.First());
            Assert.AreEqual(3, chunk.Skip(1).First());

            chunk = result.Skip(2).First();

            Assert.AreEqual(4, chunk.First());
            Assert.AreEqual(5, chunk.Skip(1).First());

            chunk = result.Skip(3).First();

            Assert.AreEqual(6, chunk.First());
            Assert.AreEqual(7, chunk.Skip(1).First());

            chunk = result.Skip(4).First();

            Assert.AreEqual(8, chunk.First());
            Assert.AreEqual(9, chunk.Skip(1).First());

            result = _testing.Chunk(_target, 3);

            Assert.AreEqual(4, result.Count());

            chunk = result.First();

            Assert.AreEqual(3, chunk.Count());

            Assert.AreEqual(0, chunk.First());
            Assert.AreEqual(1, chunk.Skip(1).First());
            Assert.AreEqual(2, chunk.Skip(2).First());

            chunk = result.Skip(1).First();

            Assert.AreEqual(3, chunk.Count());

            Assert.AreEqual(3, chunk.First());
            Assert.AreEqual(4, chunk.Skip(1).First());
            Assert.AreEqual(5, chunk.Skip(2).First());

            chunk = result.Skip(2).First();

            Assert.AreEqual(3, chunk.Count());

            Assert.AreEqual(6, chunk.First());
            Assert.AreEqual(7, chunk.Skip(1).First());
            Assert.AreEqual(8, chunk.Skip(2).First());

            chunk = result.Skip(3).First();
            Assert.AreEqual(1, chunk.Count());
            Assert.AreEqual(9, chunk.First());

            result = _testing.Chunk(_target, 11);
            Assert.AreEqual(1, result.Count());

            chunk = result.First();
            Assert.AreEqual(10, chunk.Count());

            for (var i = 0; i < _target.Count(); i++)
            {
                Assert.AreEqual(_target.ElementAt(i), chunk.ElementAt(i));
            }
        }

        [TestMethod]
        public void List_Chunk_FuncArg( )
        {
                var target = new[ ] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                var testing = new PartitionComponent( new MathComponent( ) );
                var result = testing.Chunk( target, a=> a> 0 && a % 3 == 0 );
                
                foreach ( var chunk in  result ) 
                {
                    for ( int i=0 ; i < chunk.Count( ) ; i++ ) 
                    {
                        Assert.AreEqual( i, chunk.ElementAt( i ) % 3 );
                    }
                }
                
        }

        [TestMethod]
        public void List_Partition_IntArg()
        {

            for (int i = 0; i < _target.Count(); i++)
            {
                var result = _testing.Partition(_target, i);
                int j = 0;
                for (; j < i; j++)
                {
                    Assert.AreEqual(j, result.Item1.ElementAt(j));
                }

                for (; j < _target.Length; j++)
                {
                    Assert.AreEqual(j, result.Item2.ElementAt(j - i));
                }
            }
        }

        [TestMethod]
        public void List_Partition_FuncArg( )
        {
            var result = _testing.Partition( _target, a => a > 0 && a % 3 == 0 );

            Assert.AreEqual( 3, result.Item1.Count( ) );
                
            for ( int i=0 ; i < 3 ; i++ )
                Assert.AreEqual( i, result.Item1.ElementAt( i ) );

            for ( int i=0 ; i < result.Item2.Count( ) ; i++ )
                Assert.AreEqual( i + 3, result.Item2.ElementAt( i ) );

        }

	    [TestMethod]
	    public void List_PartitionMatches()
	    {
			var target = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			var testing = new PartitionComponent(new MathComponent());
			var result = testing.PartitionMatches(target, n => n % 2 == 0);

			var leftExpected = new[] { 0, 2, 4, 6, 8 };
			var rightExpected = new[] { 1, 3, 5, 7, 9 };

			var leftResult = result.Item1.ToList();
			var rightResult = result.Item2.ToList();

			for (var i = 0; i < leftExpected.Length; i++)
			{
				Assert.AreEqual(leftExpected[i], leftResult[i]);
			}

			for (var i = 0; i < rightExpected.Length; i++)
			{
				Assert.AreEqual(rightExpected[i], rightResult[i]);
			}
	    }


        [TestMethod]
        public void ListSlice( ) 
        {
            var partitioner = new PartitionComponent( new MathComponent( ) );

            var ls = new[ ] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // slice length < list length 
            // positive 
            // forward 
            var slice = partitioner.Slice( ls, 0, 3 );

            // result should be 0 , 1 , 2 , 3
            Assert.AreEqual( 4, slice.Count );

            Assert.AreEqual( 0 , slice[ 0 ] );
            Assert.AreEqual( 1 , slice[ 1 ] );
            Assert.AreEqual( 2 , slice[ 2 ] );
            Assert.AreEqual( 3 , slice[ 3 ] );

            // slice length < list length
            // positive 
            // backwards
            slice = partitioner.Slice(ls , 3 , 0 );

            // result should be 3 , 2 , 1 , 0
            Assert.AreEqual( 4 , slice.Count );

            Assert.AreEqual( 3 , slice[0] );
            Assert.AreEqual( 2 , slice[1] );
            Assert.AreEqual( 1 , slice[2] );
            Assert.AreEqual( 0 , slice[3] );

            // slice length > list length
            // positive
            // forward
            slice = partitioner.Slice(ls, 3 , 15 );

            // result should be 3, 4, 5, 6, 7, 8, 9, 10, 0, 1, 2, 3, 4

            Assert.AreEqual(3 , slice[0]);
            Assert.AreEqual(4 , slice[1]);
            Assert.AreEqual(5 , slice[2]);
            Assert.AreEqual(6 , slice[3]);
            Assert.AreEqual(7 , slice[4]);
            Assert.AreEqual(8 , slice[5]);
            Assert.AreEqual(9 , slice[6]);
            Assert.AreEqual(10 , slice[7]);
            Assert.AreEqual(0 , slice[8]);
            Assert.AreEqual(1 , slice[9]);
            Assert.AreEqual(2 , slice[10]);
            Assert.AreEqual(3 , slice[11]);
            Assert.AreEqual(4 , slice[12]);

            // slice length > list length
            // positive
            // backwards
            slice = partitioner.Slice( ls, 15, 3 );

            Assert.AreEqual(4 , slice[0]);
            Assert.AreEqual(3 , slice[1]);
            Assert.AreEqual(2 , slice[2]);
            Assert.AreEqual(1 , slice[3]);
            Assert.AreEqual(0 , slice[4]);
            Assert.AreEqual(10 , slice[5]);
            Assert.AreEqual(9 , slice[6]);
            Assert.AreEqual(8 , slice[7]);
            Assert.AreEqual(7 , slice[8]);
            Assert.AreEqual(6 , slice[9]);
            Assert.AreEqual(5 , slice[10]);
            Assert.AreEqual(4 , slice[11]);
            Assert.AreEqual(3 , slice[12]);


            // slice length > list length
            // negative 
            // forward
            // should be
            // 10,0,1,2,3,4,5,6,7,8,9,10,0,1,2
            slice = partitioner.Slice( ls,- 12, 2 );

            Assert.AreEqual(slice.Count, 15);

            Assert.AreEqual( 10 , slice[0]);
            Assert.AreEqual( 0 , slice[1]);
            Assert.AreEqual( 1 , slice[2]);
            Assert.AreEqual( 2 , slice[3]);
            Assert.AreEqual( 3 , slice[4]);
            Assert.AreEqual( 4 , slice[5]);
            Assert.AreEqual( 5 , slice[6]);
            Assert.AreEqual( 6 , slice[7]);
            Assert.AreEqual( 7 , slice[8]);
            Assert.AreEqual( 8 , slice[9]);
            Assert.AreEqual( 9 , slice[10]);
            Assert.AreEqual( 10 , slice[11]);
            Assert.AreEqual( 0 , slice[12]);
            Assert.AreEqual( 1 , slice[13]);
            Assert.AreEqual( 2 , slice[14]);

            
            // slice length > list length
            // negative backwards
            // should be
            // 2 ,1,0,10,9,8,7,6,5,4,3,2,1,0,10
            slice = partitioner.Slice( ls,- 12, 2 );

            Assert.AreEqual(slice.Count, 15);

            Assert.AreEqual( 10 , slice[0]);
            Assert.AreEqual( 0 , slice[1]);
            Assert.AreEqual( 1 , slice[2]);
            Assert.AreEqual( 2 , slice[3]);
            Assert.AreEqual( 3 , slice[4]);
            Assert.AreEqual( 4 , slice[5]);
            Assert.AreEqual( 5 , slice[6]);
            Assert.AreEqual( 6 , slice[7]);
            Assert.AreEqual( 7 , slice[8]);
            Assert.AreEqual( 8 , slice[9]);
            Assert.AreEqual( 9 , slice[10]);
            Assert.AreEqual( 10 , slice[11]);
            Assert.AreEqual( 0 , slice[12]);
            Assert.AreEqual( 1 , slice[13]);
            Assert.AreEqual( 2 , slice[14]);


            slice = partitioner.Slice( ls, 0, 1000 );

            Assert.AreEqual( slice.Count, 1001 );

            slice = partitioner.Slice( ls, 0, 10000 );
            Assert.AreEqual( slice.Count, 10001 );

            slice = partitioner.Slice( ls, 0, 100000 );
            Assert.AreEqual( slice.Count, 100001 );

            slice = partitioner.Slice( ls, 0, -1000000 );
            Assert.AreEqual( slice.Count, 1000001 );


        }


        [TestMethod]
        public void ListCombinations_Unit()
        {
            var testing = new PartitionComponent(new MathComponent());
            ListCombinationsImpl(testing.Combinations);
        }
        
        [TestMethod]
        public void ListCombinations_Integration()
        {
            var testing = new Func<IList<int>,IEnumerable<IEnumerable<int>>>( _.List.Combinations) ;
            ListCombinationsImpl(testing);
        }

        private static void ListCombinationsImpl(Func<IList<int>, IEnumerable<IEnumerable<int>>> testing)
        {
            int[] stuff = {1, 2, 3, 4};

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
