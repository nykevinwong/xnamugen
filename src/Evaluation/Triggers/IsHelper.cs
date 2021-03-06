﻿using xnaMugen.Combat;

namespace xnaMugen.Evaluation.Triggers
{
	[CustomFunction("IsHelper")]
	internal static class IsHelper
	{
		public static bool Evaluate(Character character, ref bool error, int helperid)
		{
			if (character == null)
			{
				error = true;
				return false;
			}

			var helper = character as Combat.Helper;
			if (helper == null) return false;

			return helperid >= 0 ? helper.Data.HelperId == helperid : true;
		}

		public static Node Parse(ParseState parsestate)
		{
			var node = parsestate.BuildParenNumberNode(true);
			if (node != null)
			{
				return node;
			}

			parsestate.BaseNode.Children.Add(Node.NegativeOneNode);
			return parsestate.BaseNode;
		}
	}
}
