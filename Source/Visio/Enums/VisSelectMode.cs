﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.VisioApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Visio 11, 12, 14, 15, 16
	 /// </summary>
	[SupportByVersion("Visio", 11,12,14,15,16)]
	[EntityType(EntityType.IsEnum)]
	public enum VisSelectMode
	{
		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>256</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSelModeSkipSuper = 256,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>512</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSelModeOnlySuper = 512,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>1024</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSelModeSkipSub = 1024,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>2048</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSelModeOnlySub = 2048
	}
}