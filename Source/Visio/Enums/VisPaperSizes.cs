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
	public enum VisPaperSizes
	{
		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPaperSizeUnknown = 0,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPaperSizeLetter = 1,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPaperSizeLegal = 5,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPaperSizeA3 = 8,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>9</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPaperSizeA4 = 9,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>11</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPaperSizeA5 = 11,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>12</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPaperSizeB4 = 12,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>13</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPaperSizeB5 = 13,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>14</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPaperSizeFolio = 14,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>18</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPaperSizeNote = 18,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>24</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPaperSizeC = 24,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>25</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPaperSizeD = 25,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>26</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPaperSizeE = 26
	}
}