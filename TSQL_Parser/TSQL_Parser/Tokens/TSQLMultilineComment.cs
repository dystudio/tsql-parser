﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSQL.Tokens
{
	public class TSQLMultilineComment : TSQLComment
	{
		public TSQLMultilineComment(
			int beginPostion,
			int endPosition,
			string text) :
			base(
				beginPostion,
				endPosition,
				text)
		{
			Comment = Text.Substring(2, Text.Length - 4);
		}
	}
}
