﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.PublisherApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Publisher 14, 15, 16
	 /// </summary>
	[SupportByVersion("Publisher", 14,15,16)]
	[EntityType(EntityType.IsEnum)]
	public enum PbLineSpacingRule
	{
		 /// <summary>
		 /// SupportByVersion Publisher 14, 15, 16
		 /// </summary>
		 /// <remarks>-9999999</remarks>
		 [SupportByVersion("Publisher", 14,15,16)]
		 pbLineSpacingMixed = -9999999,

		 /// <summary>
		 /// SupportByVersion Publisher 14, 15, 16
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersion("Publisher", 14,15,16)]
		 pbLineSpacingSingle = 0,

		 /// <summary>
		 /// SupportByVersion Publisher 14, 15, 16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("Publisher", 14,15,16)]
		 pbLineSpacing1pt5 = 1,

		 /// <summary>
		 /// SupportByVersion Publisher 14, 15, 16
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("Publisher", 14,15,16)]
		 pbLineSpacingDouble = 2,

		 /// <summary>
		 /// SupportByVersion Publisher 14, 15, 16
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersion("Publisher", 14,15,16)]
		 pbLineSpacingExactly = 4,

		 /// <summary>
		 /// SupportByVersion Publisher 14, 15, 16
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersion("Publisher", 14,15,16)]
		 pbLineSpacingMultiple = 5
	}
}