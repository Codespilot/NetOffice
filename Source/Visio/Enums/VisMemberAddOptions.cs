﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.VisioApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Visio 14, 15, 16
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/ff768755(v=office.14).aspx </remarks>
	[SupportByVersion("Visio", 14,15,16)]
	[EntityType(EntityType.IsEnum)]
	public enum VisMemberAddOptions
	{
		 /// <summary>
		 /// SupportByVersion Visio 14, 15, 16
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersion("Visio", 14,15,16)]
		 visMemberAddUseResizeSetting = 0,

		 /// <summary>
		 /// SupportByVersion Visio 14, 15, 16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("Visio", 14,15,16)]
		 visMemberAddExpandContainer = 1,

		 /// <summary>
		 /// SupportByVersion Visio 14, 15, 16
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("Visio", 14,15,16)]
		 visMemberAddDoNotExpand = 2
	}
}