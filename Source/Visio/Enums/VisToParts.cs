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
	public enum VisToParts
	{
		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>-1</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visConnectToError = -1,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visToNone = 0,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visGuideX = 1,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visGuideY = 2,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visWholeShape = 3,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visGuideIntersect = 4,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visToAngle = 7,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>100</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visConnectionPoint = 100,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>-1</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visConnectError = -1,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visNone = 0
	}
}