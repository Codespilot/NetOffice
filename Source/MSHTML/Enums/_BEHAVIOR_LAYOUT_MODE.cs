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
	public enum _BEHAVIOR_LAYOUT_MODE
	{
		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 BEHAVIORLAYOUTMODE_NATURAL = 1,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 BEHAVIORLAYOUTMODE_MINWIDTH = 2,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 BEHAVIORLAYOUTMODE_MAXWIDTH = 4,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>16384</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 BEHAVIORLAYOUTMODE_MEDIA_RESOLUTION = 16384,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>32768</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 BEHAVIORLAYOUTMODE_FINAL_PERCENT = 32768,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>2147483647</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 BEHAVIOR_LAYOUT_MODE_Max = 2147483647
	}
}