﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.VisioApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Visio 14, 15, 16
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/ff766515(v=office.14).aspx </remarks>
	[SupportByVersion("Visio", 14,15,16)]
	[EntityType(EntityType.IsEnum)]
	public enum VisValidationFlags
	{
		 /// <summary>
		 /// SupportByVersion Visio 14, 15, 16
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersion("Visio", 14,15,16)]
		 visValidationDefault = 0,

		 /// <summary>
		 /// SupportByVersion Visio 14, 15, 16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("Visio", 14,15,16)]
		 visValidationNoOpenWindow = 1
	}
}