﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSQL.Tokens
{
	public class TSQLIdentifier : TSQLToken
	{
		public TSQLIdentifier(
			int beginPostion,
			int endPosition,
			string text) :
			base(
				beginPostion,
				endPosition,
				text)
		{
			if (Text.StartsWith("["))
			{
				Name = Text
					.Substring(1, Text.Length - 2)
					.Replace("]]", "]");
			}
			// check for quoted identifiers here just in case
			else if (Text.StartsWith("\""))
			{
				Name = Text
					.Substring(1, Text.Length - 2)
					.Replace("\"\"", "\"");
			}
			else
			{
				Name = Text;
			}
		}

		/// <summary>
		///		Unescaped value for the name of the identifier.
		/// </summary>
		public string Name
		{
			get;
			private set;
		}
	}
}
