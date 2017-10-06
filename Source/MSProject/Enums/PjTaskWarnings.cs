﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.MSProjectApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSProject 11, 14
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff860436(v=office.14).aspx </remarks>
	[SupportByVersion("MSProject", 11,14)]
	[EntityType(EntityType.IsEnum)]
	public enum PjTaskWarnings
	{
		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("MSProject", 11,14)]
		 pjTaskWarningShadowFinishesLaterDueToLink = 1,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("MSProject", 11,14)]
		 pjTaskWarningShadowFinishesEarlierDueToLink = 2,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersion("MSProject", 11,14)]
		 pjTaskWarningSubTaskStartingBeforeParentStart = 4,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersion("MSProject", 11,14)]
		 pjTaskWarningSubTaskStartingAfterParentStart = 8,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByVersion("MSProject", 11,14)]
		 pjTaskWarningSubTaskFinishingAfterParentFinish = 16,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>32</remarks>
		 [SupportByVersion("MSProject", 11,14)]
		 pjTaskWarningSummaryInconsistentStart = 32,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>64</remarks>
		 [SupportByVersion("MSProject", 11,14)]
		 pjTaskWarningResourceBeyondMaxUnit = 64,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>128</remarks>
		 [SupportByVersion("MSProject", 11,14)]
		 pjTaskWarningResourceOverallocated = 128,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>256</remarks>
		 [SupportByVersion("MSProject", 11,14)]
		 pjTaskWarningShadowIncorrectByConstraintOnly = 256,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>512</remarks>
		 [SupportByVersion("MSProject", 11,14)]
		 pjTaskWarningShadowIncorrectByLevelingDelayOnly = 512,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>1024</remarks>
		 [SupportByVersion("MSProject", 11,14)]
		 pjTaskWarningShadowDateDifferent = 1024,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>2048</remarks>
		 [SupportByVersion("MSProject", 11,14)]
		 pjTaskWarningSummaryInconsistentFinish = 2048,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>4096</remarks>
		 [SupportByVersion("MSProject", 11,14)]
		 pjTaskWarningTaskStartingInNonWorkingTime = 4096,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>8192</remarks>
		 [SupportByVersion("MSProject", 11,14)]
		 pjTaskWarningTaskFinishingInNonWorkingTime = 8192,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 14
		 /// </summary>
		 /// <remarks>16384</remarks>
		 [SupportByVersion("MSProject", 11,14)]
		 pjTaskWarningAssnOverallocatedInNonWorkingTime = 16384
	}
}