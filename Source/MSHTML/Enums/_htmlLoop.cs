﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.MSHTMLApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSHTML 4
	 /// </summary>
	[SupportByVersion("MSHTML", 4)]
	[EntityType(EntityType.IsEnum)]
	public enum _htmlLoop
	{
		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>-1</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 htmlLoopLoopInfinite = -1,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>2147483647</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 htmlLoop_Max = 2147483647
	}
}