﻿using NUnit.Framework;
using System;
using Underscore.Function;

namespace Underscore.Test.Function
{
	[TestFixture]
	public class CacheTest
	{
		private ApplyComponent apply;

		[SetUp]
		public void Initialize()
		{
            apply = new ApplyComponent();
		}

		[Test]
		public void Function_Cache_Memo_1Argument()
		{
			var expected = "a";
			var callcount = 0;

			Func<string, string> testFn = a =>
			{
				callcount++;
				return Util.Join(a);
			};

			var memoized = _.Function.Memoize(testFn);

			var result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			expected = "A";

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);

			result = apply.Apply(memoized, Util.UppercaseCharArray);
			
			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);
		}

		[Test]
		public void Function_Cache_Memo_2Arguments()
		{
			var expected = "ab";
			var callcount = 0;

			Func<string, string, string> testFn = (a, b) =>
			{
				callcount++;
				return Util.Join(a, b);
			};

			var memoized = _.Function.Memoize(testFn);

			var result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			expected = "AB";

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);
		}

		[Test]
		public void Function_Cache_Memo_3Arguments()
		{
			var expected = "abc";
			var callcount = 0;

			Func<string, string, string, string> testFn = (a, b, c) =>
			{
				callcount++;
				return Util.Join(a, b, c);
			};

			var memoized = _.Function.Memoize(testFn);

			var result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			expected = "ABC";

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);
		}

		[Test]
		public void Function_Cache_Memo_4Arguments()
		{
			var expected = "abcd";
			var callcount = 0;

			Func<string, string, string, string, string> testFn = (a, b, c, d) =>
			{
				callcount++;
				return Util.Join(a, b, c, d);
			};

			var memoized = _.Function.Memoize(testFn);

			var result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			expected = "ABCD";

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);
		}

		[Test]
		public void Function_Cache_Memo_5Arguments()
		{
			var expected = "abcde";
			var callcount = 0;

			Func<string, string, string, string, string, string> testFn = (a, b, c, d, e) =>
			{
				callcount++;
				return Util.Join(a, b, c, d, e);
			};

			var memoized = _.Function.Memoize(testFn);

			var result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			expected = "ABCDE";

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);
		}

		[Test]
		public void Function_Cache_Memo_6Arguments()
		{
			var expected = "abcdef";
			var callcount = 0;

			Func<string, string, string, string, string, string, string> testFn = (a, b, c, d, e, f) =>
			{
				callcount++;
				return Util.Join(a, b, c, d, e, f);
			};

			var memoized = _.Function.Memoize(testFn);

			var result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			expected = "ABCDEF";

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);
		}

		[Test]
		public void Function_Cache_Memo_7Arguments()
		{
			var expected = "abcdefg";
			var callcount = 0;

			Func<string, string, string, string, string, string, string, string> testFn = (a, b, c, d, e, f, g) =>
			{
				callcount++;
				return Util.Join(a, b, c, d, e, f, g);
			};

			var memoized = _.Function.Memoize(testFn);

			var result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			expected = "ABCDEFG";

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);
		}

		[Test]
		public void Function_Cache_Memo_8Arguments()
		{
			var expected = "abcdefgh";
			var callcount = 0;

			Func<string, string, string, string, string, string, string, string, string> testFn = (a, b, c, d, e, f, g, h) =>
			{
				callcount++;
				return Util.Join(a, b, c, d, e, f, g, h);
			};

			var memoized = _.Function.Memoize(testFn);

			var result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			expected = "ABCDEFGH";

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);
		}

		[Test]
		public void Function_Cache_Memo_9Arguments()
		{
			var expected = "abcdefghi";
			var callcount = 0;

			Func<string, string, string, string, string, string, string, string, string, string> testFn = (a, b, c, d, e, f, g, h, i) =>
			{
				callcount++;
				return Util.Join(a, b, c, d, e, f, g, h, i);
			};

			var memoized = _.Function.Memoize(testFn);

			var result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			expected = "ABCDEFGHI";

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);
		}

		[Test]
		public void Function_Cache_Memo_10Arguments()
		{
			var expected = "abcdefghij";
			var callcount = 0;

			Func<string, string, string, string, string, string, string, string, string, string, string> testFn = (a, b, c, d, e, f, g, h, i, j) =>
			{
				callcount++;
				return Util.Join(a, b, c, d, e, f, g, h, i, j);
			};

			var memoized = _.Function.Memoize(testFn);

			var result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			expected = "ABCDEFGHIJ";

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);
		}

		[Test]
		public void Function_Cache_Memo_11Arguments()
		{
			var expected = "abcdefghijk";
			var callcount = 0;

			Func<string, string, string, string, string, string, string, string, string, string, string, string> testFn = (a, b, c, d, e, f, g, h, i, j, k) =>
			{
				callcount++;
				return Util.Join(a, b, c, d, e, f, g, h, i, j, k);
			};

			var memoized = _.Function.Memoize(testFn);

			var result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			expected = "ABCDEFGHIJK";

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);
		}

		[Test]
		public void Function_Cache_Memo_12Arguments()
		{
			var expected = "abcdefghijkl";
			var callcount = 0;

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string> testFn = (a, b, c, d, e, f, g, h, i, j, k, l) =>
			{
				callcount++;
				return Util.Join(a, b, c, d, e, f, g, h, i, j, k, l);
			};

			var memoized = _.Function.Memoize(testFn);

			var result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			expected = "ABCDEFGHIJKL";

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);
		}

		[Test]
		public void Function_Cache_Memo_13Arguments()
		{
			var expected = "abcdefghijklm";
			var callcount = 0;

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string> testFn = (a, b, c, d, e, f, g, h, i, j, k, l, m) =>
			{
				callcount++;
				return Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m);
			};

			var memoized = _.Function.Memoize(testFn);

			var result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			expected = "ABCDEFGHIJKLM";

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);
		}

		[Test]
		public void Function_Cache_Memo_14Arguments()
		{
			var expected = "abcdefghijklmn";
			var callcount = 0;

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> testFn = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
			{
				callcount++;
				return Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
			};

			var memoized = _.Function.Memoize(testFn);

			var result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			expected = "ABCDEFGHIJKLMN";

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);
		}

		[Test]
		public void Function_Cache_Memo_15Arguments()
		{
			var expected = "abcdefghijklmno";
			var callcount = 0;

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> testFn = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
			{
				callcount++;
				return Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
			};

			var memoized = _.Function.Memoize(testFn);

			var result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			expected = "ABCDEFGHIJKLMNO";

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);
		}

		[Test]
		public void Function_Cache_Memo_16Arguments()
		{
			var expected = "abcdefghijklmnop";
			var callcount = 0;

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> testFn = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =>
			{
				callcount++;
				return Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
			};

			var memoized = _.Function.Memoize(testFn);

			var result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			result = apply.Apply(memoized, Util.LowercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(1, callcount);

			expected = "ABCDEFGHIJKLMNOP";

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);

			result = apply.Apply(memoized, Util.UppercaseCharArray);

			Assert.AreEqual(expected, result);
			Assert.AreEqual(2, callcount);
		}
	}
}
