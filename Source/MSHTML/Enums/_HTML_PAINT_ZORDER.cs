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
	public enum _HTML_PAINT_ZORDER
	{
		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINT_ZORDER_NONE = 0,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINT_ZORDER_REPLACE_ALL = 1,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINT_ZORDER_REPLACE_CONTENT = 2,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINT_ZORDER_REPLACE_BACKGROUND = 3,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINT_ZORDER_BELOW_CONTENT = 4,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINT_ZORDER_BELOW_FLOW = 5,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINT_ZORDER_ABOVE_FLOW = 6,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINT_ZORDER_ABOVE_CONTENT = 7,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINT_ZORDER_WINDOW_TOP = 8,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>2147483647</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTML_PAINT_ZORDER_Max = 2147483647
	}
}