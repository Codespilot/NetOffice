﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.WordApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Word 15,16
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/jj229206.aspx </remarks>
	[SupportByVersion("Word", 15, 16)]
	[EntityType(EntityType.IsEnum)]
	public enum WdColumnWidth
	{
		 /// <summary>
		 /// SupportByVersion Word 15,16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("Word", 15, 16)]
		 wdColumnWidthNarrow = 1,

		 /// <summary>
		 /// SupportByVersion Word 15,16
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("Word", 15, 16)]
		 wdColumnWidthDefault = 2,

		 /// <summary>
		 /// SupportByVersion Word 15,16
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersion("Word", 15, 16)]
		 wdColumnWidthWide = 3
	}
}