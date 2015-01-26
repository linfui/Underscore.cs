using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Collection;

namespace Underscore.Test.Collection
{
    [TestClass]
    public class Creation 
    {
        [TestMethod]
        public void CollectionSnapshot( )
        {
            var target = new[ ] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var testing = new CreationComponent( );
            var result = testing.Snapshot( target );
            var resultResult = result();

            for ( int i=0 ; i < target.Length ; i++ ) 
            {
                Assert.AreEqual( target[ i ], resultResult.ElementAt( i ) );
            }


            for ( int i=0 ; i < target.Length ; i++ )
                target[ i ] *= 2;

            resultResult = result( );

            for ( int i=0 ; i < target.Length ; i++ ) 
            {
                Assert.AreNotEqual( target[ i ], resultResult.ElementAt( i ) );
            }
        }
    }
}
