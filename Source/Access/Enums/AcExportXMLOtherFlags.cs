﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.AccessApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Access 11, 12, 14, 15, 16
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff836278.aspx </remarks>
	[SupportByVersion("Access", 11,12,14,15,16)]
	[EntityType(EntityType.IsEnum)]
	public enum AcExportXMLOtherFlags
	{
		 /// <summary>
		 /// SupportByVersion Access 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("Access", 11,12,14,15,16)]
		 acEmbedSchema = 1,

		 /// <summary>
		 /// SupportByVersion Access 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("Access", 11,12,14,15,16)]
		 acExcludePrimaryKeyAndIndexes = 2,

		 /// <summary>
		 /// SupportByVersion Access 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersion("Access", 11,12,14,15,16)]
		 acRunFromServer = 4,

		 /// <summary>
		 /// SupportByVersion Access 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersion("Access", 11,12,14,15,16)]
		 acLiveReportSource = 8,

		 /// <summary>
		 /// SupportByVersion Access 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByVersion("Access", 11,12,14,15,16)]
		 acPersistReportML = 16,

		 /// <summary>
		 /// SupportByVersion Access 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>32</remarks>
		 [SupportByVersion("Access", 12,14,15,16)]
		 acExportAllTableAndFieldProperties = 32
	}
}