﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.WordApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff191861.aspx </remarks>
	[SupportByVersion("Word", 9,10,11,12,14,15,16)]
	[EntityType(EntityType.IsEnum)]
	public enum WdAutoVersions
	{
		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersion("Word", 9,10,11,12,14,15,16)]
		 wdAutoVersionOff = 0,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("Word", 9,10,11,12,14,15,16)]
		 wdAutoVersionOnClose = 1
	}
}