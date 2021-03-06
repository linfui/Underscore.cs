﻿using System;
using NUnit.Framework;
using Underscore.Action;

namespace Underscore.Test.Action
{
	[TestFixture]
	public class ComposeTest
	{
		private ComposeComponent component;
		private string str;

		[SetUp]
		public void Initialize()
		{
			component = new ComposeComponent();
			str = "";
		}

		public Action<string> TestComposeEnd(string s)
		{
			return (t) =>
			{
				Assert.AreEqual(s, t);
			};
		}

		public Func<string, string> TestComposeStart(string s)
		{
			return (t) => "Start" + s + t;
		}

		public Func<string, string> TestComposeLinks(string s)
		{
			return (t) => t + s;
		}

		[Test]
		public void Action_Compose_Compose_2Arguments()
		{
			var composeResult = _.Action.Compose(
					TestComposeStart("1"),
					TestComposeEnd("Start12")
			);

			composeResult("2");
		}

		[Test]
		public void Action_Compose_Compose_3Arguments()
		{
			var composeResult = _.Action.Compose(
					TestComposeStart("1"),
					TestComposeLinks("3"),
					TestComposeEnd("Start123")
			);

			composeResult("2");
		}

		[Test]
		public void Action_Compose_Compose_4Arguments()
		{
			var composeResult = _.Action.Compose(
					TestComposeStart("1"),
					TestComposeLinks("3"),
					TestComposeLinks("4"),
					TestComposeEnd("Start1234")
			);

			composeResult("2");
		}

		[Test]
		public void Action_Compose_Compose_5Arguments()
		{
			   var composeResult = _.Action.Compose(
					   TestComposeStart("1"),
					   TestComposeLinks("3"),
					   TestComposeLinks("4"),
					   TestComposeLinks("5"),
					   TestComposeEnd("Start12345")
			   );

			   composeResult("2");
		}

		[Test]
		public void Action_Compose_Compose_6Arguments()
		{            
			var composeResult = _.Action.Compose(
					TestComposeStart("1"),
					TestComposeLinks("3"),
					TestComposeLinks("4"),
					TestComposeLinks("5"),
					TestComposeLinks("6"),
					TestComposeEnd("Start123456")
			);

			composeResult("2");
		}

		[Test]
		public void Action_Compose_Compose_7Arguments()
		{
			

			var composeResult = _.Action.Compose(
					TestComposeStart("1"),
					TestComposeLinks("3"),
					TestComposeLinks("4"),
					TestComposeLinks("5"),
					TestComposeLinks("6"),
					TestComposeLinks("7"),
					TestComposeEnd("Start1234567")
			);

			composeResult("2");
		}

		[Test]
		public void Action_Compose_Compose_8Arguments()
		{
			var composeResult = _.Action.Compose(
					TestComposeStart("1"),
					TestComposeLinks("3"),
					TestComposeLinks("4"),
					TestComposeLinks("5"),
					TestComposeLinks("6"),
					TestComposeLinks("7"),
					TestComposeLinks("8"),
					TestComposeEnd("Start12345678")
			);

			composeResult("2");
		}

		[Test]
		public void Action_Compose_Compose_9Arguments()
		{
			var act = new Action<string>(a => str += a);

			var composeResult = _.Action.Compose(act, act, act, act, act);

			composeResult("1");
			Assert.AreEqual("11111", str);
		}
	}
}
