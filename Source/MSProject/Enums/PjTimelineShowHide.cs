﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.MSProjectApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSProject 11, 14
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff867008(v=office.14).aspx </remarks>
	[SupportByVersion("MSProject", 11,14)]
	[EntityType(EntityType.IsEnum)]
	public enum PjTimelineShowHide
	{
		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersion("MSProject", 11,14)]
		 pjTimelineShowHideTaskOverlaps = 0,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("MSProject", 11,14)]
		 pjTimelineShowHidePanZoom = 1,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("MSProject", 11,14)]
		 pjTimelineShowHideTimescale = 2,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersion("MSProject", 11,14)]
		 pjTimelineShowHideToday = 3,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersion("MSProject", 11,14)]
		 pjTimelineShowHideTaskDates = 4
	}
}