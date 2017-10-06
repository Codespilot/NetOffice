﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.PowerPointApi.Enums
{
	 /// <summary>
	 /// SupportByVersion PowerPoint 9
	 /// </summary>
	[SupportByVersion("PowerPoint", 9)]
	[EntityType(EntityType.IsEnum)]
	public enum PpAlertType
	{
		 /// <summary>
		 /// SupportByVersion PowerPoint 9
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersion("PowerPoint", 9)]
		 ppAlertTypeOK = 0,

		 /// <summary>
		 /// SupportByVersion PowerPoint 9
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("PowerPoint", 9)]
		 ppAlertTypeOKCANCEL = 1,

		 /// <summary>
		 /// SupportByVersion PowerPoint 9
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("PowerPoint", 9)]
		 ppAlertTypeYESNO = 2,

		 /// <summary>
		 /// SupportByVersion PowerPoint 9
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersion("PowerPoint", 9)]
		 ppAlertTypeYESNOCANCEL = 3,

		 /// <summary>
		 /// SupportByVersion PowerPoint 9
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersion("PowerPoint", 9)]
		 ppAlertTypeBACKNEXTCLOSE = 4,

		 /// <summary>
		 /// SupportByVersion PowerPoint 9
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersion("PowerPoint", 9)]
		 ppAlertTypeRETRYCANCEL = 5,

		 /// <summary>
		 /// SupportByVersion PowerPoint 9
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersion("PowerPoint", 9)]
		 ppAlertTypeABORTRETRYIGNORE = 6
	}
}