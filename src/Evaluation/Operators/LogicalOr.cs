﻿using System;
using System.Diagnostics;
using xnaMugen.Collections;

namespace xnaMugen.Evaluation.Operators
{
	class LogicalOr : IFunction
	{
		public EvaluationResult Evaluate(EvaluationState state, ReadOnlyList<IEvaluate> args, ReadOnlyList<Object> data)
		{
			return BaseOperations.LogicalOr(args[0].Evaluate(state), args[1].Evaluate(state));
		}
	}
}