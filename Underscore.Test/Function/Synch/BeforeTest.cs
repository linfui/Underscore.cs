﻿using System;
using NUnit.Framework;
using Underscore.Function;

namespace Underscore.Test.Function.Synch
{
	[TestFixture]
	public class BeforeTest
	{
		private ApplyComponent apply;

		private readonly string[] arguments = Util.LowercaseCharArray;

		[SetUp]
		public void Initialize()
		{
            apply = new ApplyComponent();
		}

		[Test]
		public void Function_Synch_Before_NoArguments()
		{
			var counter = 0;
			var befored = _.Function.Before(() => (counter++), 2);
			for (var i = 0; i < 2; i++)
				Assert.AreEqual(i, befored());

			for (var i = 0; i < 10; i++)
				Assert.AreEqual(1, befored());
		}

		[Test]
		public void Function_Synch_Before_1Argument()
		{
			var invoked = false;

			var counter = 0;

			var beforing = new Func<string, string>((a) =>
			{
				invoked = true;
				return string.Join("", a, counter++);
			});

			var befored = _.Function.Before(beforing, 2);

			for (var i = 0; i < 2; i++)
				Assert.AreEqual("a" + i, apply.Apply(befored, arguments));

			for (var i = 2; i < 4; i++)
				Assert.AreEqual("a1", apply.Apply(befored, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Before_2Arguments()
		{
			var invoked = false;

			var counter = 0;

			var beforing = new Func<string, string, string>((a, b) =>
			{
				invoked = true;
				return string.Join("", a, b, counter++);
			});

			var befored = _.Function.Before(beforing, 2);

			for (var i = 0; i < 2; i++)
				Assert.AreEqual("ab" + i, apply.Apply(befored, arguments));

			for (var i = 2; i < 4; i++)
				Assert.AreEqual("ab1", apply.Apply(befored, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Before_3Arguments()
		{
			var invoked = false;

			var counter = 0;

			var beforing = new Func<string, string, string, string>((a, b, c) =>
			{
				invoked = true;
				return string.Join("", a, b, c, counter++);
			});

			var befored = _.Function.Before(beforing, 2);

			for (var i = 0; i < 2; i++)
				Assert.AreEqual("abc" + i, apply.Apply(befored, arguments));

			for (var i = 2; i < 4; i++)
				Assert.AreEqual("abc1", apply.Apply(befored, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Before_4Arguments()
		{

			var invoked = false;

			var counter = 0;

			var beforing = new Func<string, string, string, string, string>((a, b, c, d) =>
			{
				invoked = true;
				return string.Join("", a, b, c, d, counter++);
			});

			var befored = _.Function.Before(beforing, 2);

			for (var i = 0; i < 2; i++)
				Assert.AreEqual("abcd" + i, apply.Apply(befored, arguments));

			for (var i = 2; i < 4; i++)
				Assert.AreEqual("abcd1", apply.Apply(befored, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Before_5Arguments()
		{

			var invoked = false;

			var counter = 0;

			var beforing = new Func<string, string, string, string, string, string>((a, b, c, d, e) =>
			{
				invoked = true;
				return string.Join("", a, b, c, d, e, counter++);
			});

			var befored = _.Function.Before(beforing, 2);

			for (var i = 0; i < 2; i++)
				Assert.AreEqual("abcde" + i, apply.Apply(befored, arguments));

			for (var i = 2; i < 4; i++)
				Assert.AreEqual("abcde1", apply.Apply(befored, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Before_6Arguments()
		{

			var invoked = false;

			var counter = 0;

			var beforing = new Func<string, string, string, string, string, string, string>((a, b, c, d, e, f) =>
			{
				invoked = true;
				return string.Join("", a, b, c, d, e, f, counter++);
			});

			var befored = _.Function.Before(beforing, 2);

			for (var i = 0; i < 2; i++)
				Assert.AreEqual("abcdef" + i, apply.Apply(befored, arguments));

			for (var i = 2; i < 4; i++)
				Assert.AreEqual("abcdef1", apply.Apply(befored, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Before_7Arguments()
		{

			var invoked = false;

			var counter = 0;

			var beforing = new Func<string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g) =>
			{
				invoked = true;
				return string.Join("", a, b, c, d, e, f, g, counter++);
			});

			var befored = _.Function.Before(beforing, 2);

			for (var i = 0; i < 2; i++)
				Assert.AreEqual("abcdefg" + i, apply.Apply(befored, arguments));

			for (var i = 2; i < 4; i++)
				Assert.AreEqual("abcdefg1", apply.Apply(befored, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Before_8Arguments()
		{
			var invoked = false;

			var counter = 0;

			var beforing = new Func<string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h) =>
			{
				invoked = true;
				return string.Join("", a, b, c, d, e, f, g, h, counter++);
			});

			var befored = _.Function.Before(beforing, 2);

			for (var i = 0; i < 2; i++)
				Assert.AreEqual("abcdefgh" + i, apply.Apply(befored, arguments));

			for (var i = 2; i < 4; i++)
				Assert.AreEqual("abcdefgh1", apply.Apply(befored, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Before_9Arguments()
		{

			var invoked = false;

			var counter = 0;

			var beforing = new Func<string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i) =>
			{
				invoked = true;
				return string.Join("", a, b, c, d, e, f, g, h, i, counter++);
			});

			var befored = _.Function.Before(beforing, 2);

			for (var i = 0; i < 2; i++)
				Assert.AreEqual("abcdefghi" + i, apply.Apply(befored, arguments));

			for (var i = 2; i < 4; i++)
				Assert.AreEqual("abcdefghi1", apply.Apply(befored, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Before_10Arguments()
		{
			var invoked = false;

			var counter = 0;

			var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j) =>
			{
				invoked = true;
				return string.Join("", a, b, c, d, e, f, g, h, i, j, counter++);
			});

			var befored = _.Function.Before(beforing, 2);

			for (var i = 0; i < 2; i++)
				Assert.AreEqual("abcdefghij" + i, apply.Apply(befored, arguments));

			for (var i = 2; i < 4; i++)
				Assert.AreEqual("abcdefghij1", apply.Apply(befored, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Before_11Arguments()
		{
			var invoked = false;

			var counter = 0;

			var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k) =>
			{
				invoked = true;
				return string.Join("", a, b, c, d, e, f, g, h, i, j, k, counter++);
			});

			var befored = _.Function.Before(beforing, 2);

			for (var i = 0; i < 2; i++)
				Assert.AreEqual("abcdefghijk" + i, apply.Apply(befored, arguments));

			for (var i = 2; i < 4; i++)
				Assert.AreEqual("abcdefghijk1", apply.Apply(befored, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Before_12Arguments()
		{
			var invoked = false;

			var counter = 0;

			var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l) =>
			{
				invoked = true;
				return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, counter++);
			});

			var befored = _.Function.Before(beforing, 2);

			for (var i = 0; i < 2; i++)
				Assert.AreEqual("abcdefghijkl" + i, apply.Apply(befored, arguments));

			for (var i = 2; i < 4; i++)
				Assert.AreEqual("abcdefghijkl1", apply.Apply(befored, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Before_13Arguments()
		{

			var invoked = false;

			var counter = 0;

			var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m) =>
			{
				invoked = true;
				return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, counter++);
			});

			var befored = _.Function.Before(beforing, 2);

			for (var i = 0; i < 2; i++)
				Assert.AreEqual("abcdefghijklm" + i, apply.Apply(befored, arguments));

			for (var i = 2; i < 4; i++)
				Assert.AreEqual("abcdefghijklm1", apply.Apply(befored, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Before_14Arguments()
		{

			var invoked = false;

			var counter = 0;

			var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
			{
				invoked = true;
				return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, counter++);
			});

			var befored = _.Function.Before(beforing, 2);

			for (var i = 0; i < 2; i++)
				Assert.AreEqual("abcdefghijklmn" + i, apply.Apply(befored, arguments));

			for (var i = 2; i < 4; i++)
				Assert.AreEqual("abcdefghijklmn1", apply.Apply(befored, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Before_15Arguments()
		{

			var invoked = false;

			var counter = 0;

			var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
			{
				invoked = true;
				return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, counter++);
			});

			var befored = _.Function.Before(beforing, 2);

			for (var i = 0; i < 2; i++)
				Assert.AreEqual("abcdefghijklmno" + i, apply.Apply(befored, arguments));

			for (var i = 2; i < 4; i++)
				Assert.AreEqual("abcdefghijklmno1", apply.Apply(befored, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Before_16Arguments()
		{
			var invoked = false;

			var counter = 0;

			var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =>
			{
				invoked = true;
				return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, counter++);
			});

			var befored = _.Function.Before(beforing, 2);

			for (var i = 0; i < 2; i++)
				Assert.AreEqual("abcdefghijklmnop" + i, apply.Apply(befored, arguments));

			for (var i = 2; i < 4; i++)
				Assert.AreEqual("abcdefghijklmnop1", apply.Apply(befored, arguments));

			Assert.IsTrue(invoked);
		}

	}
}
