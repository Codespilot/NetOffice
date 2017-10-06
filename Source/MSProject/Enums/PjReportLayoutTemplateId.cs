﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.MSProjectApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSProject 11
	 /// </summary>
	[SupportByVersion("MSProject", 11)]
	[EntityType(EntityType.IsEnum)]
	public enum PjReportLayoutTemplateId
	{
		 /// <summary>
		 /// SupportByVersion MSProject 11
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersion("MSProject", 11)]
		 pjReportLayoutTitleOnly = 0,

		 /// <summary>
		 /// SupportByVersion MSProject 11
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("MSProject", 11)]
		 pjReportLayoutTitleAndChart = 1,

		 /// <summary>
		 /// SupportByVersion MSProject 11
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("MSProject", 11)]
		 pjReportLayoutTitleAndTable = 2,

		 /// <summary>
		 /// SupportByVersion MSProject 11
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersion("MSProject", 11)]
		 pjReportLayoutComparison = 3
	}
}