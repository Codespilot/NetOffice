﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.MSProjectApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSProject 11, 14
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff862595(v=office.14).aspx </remarks>
	[SupportByVersion("MSProject", 11,14)]
	[EntityType(EntityType.IsEnum)]
	public enum PjAssignmentReplanAction
	{
		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersion("MSProject", 11,14)]
		 pjConstrainToMaxUnitsByIncreasingDuration = 0,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("MSProject", 11,14)]
		 pjConstrainToMaxUnitsByDecreasingWork = 1
	}
}