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
	public enum _HTML_PAINTER
	{
		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINTER_OPAQUE = 1,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINTER_TRANSPARENT = 2,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINTER_ALPHA = 4,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINTER_COMPLEX = 8,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINTER_OVERLAY = 16,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>32</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINTER_HITTEST = 32,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>256</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINTER_SURFACE = 256,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>512</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINTER_3DSURFACE = 512,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>1024</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINTER_NOBAND = 1024,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>4096</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINTER_NODC = 4096,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>8192</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINTER_NOPHYSICALCLIP = 8192,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>16384</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINTER_NOSAVEDC = 16384,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>32768</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINTER_SUPPORTS_XFORM = 32768,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>65536</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINTER_EXPAND = 65536,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>131072</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTMLPAINTER_NOSCROLLBITS = 131072,

		 /// <summary>
		 /// SupportByVersion MSHTML 4
		 /// </summary>
		 /// <remarks>2147483647</remarks>
		 [SupportByVersion("MSHTML", 4)]
		 HTML_PAINTER_Max = 2147483647
	}
}