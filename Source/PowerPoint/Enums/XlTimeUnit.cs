﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.PowerPointApi.Enums
{
	 /// <summary>
	 /// SupportByVersion PowerPoint 14, 15, 16
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745377.aspx </remarks>
	[SupportByVersion("PowerPoint", 14,15,16)]
	[EntityType(EntityType.IsEnum)]
	public enum XlTimeUnit
	{
		 /// <summary>
		 /// SupportByVersion PowerPoint 14, 15, 16
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersion("PowerPoint", 14,15,16)]
		 xlDays = 0,

		 /// <summary>
		 /// SupportByVersion PowerPoint 14, 15, 16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("PowerPoint", 14,15,16)]
		 xlMonths = 1,

		 /// <summary>
		 /// SupportByVersion PowerPoint 14, 15, 16
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("PowerPoint", 14,15,16)]
		 xlYears = 2
	}
}