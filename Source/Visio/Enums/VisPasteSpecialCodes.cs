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
	public enum VisPasteSpecialCodes
	{
		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPasteText = 1,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPasteBitmap = 2,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPasteMetafile = 3,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPasteOEMText = 7,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPasteDIB = 8,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>14</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPasteEMF = 14,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>65536</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPasteOLEObject = 65536,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>65537</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPasteRichText = 65537,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>65538</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPasteHyperlink = 65538,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>65539</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPasteURL = 65539,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>65540</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPasteVisioShapes = 65540,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>65541</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPasteVisioMasters = 65541,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>65542</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPasteVisioText = 65542,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>65543</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPasteVisioIcon = 65543,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>65544</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPasteInk = 65544,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>65545</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPasteVisioShapesXML = 65545,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>65546</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visPasteVisioMastersXML = 65546,

		 /// <summary>
		 /// SupportByVersion Visio 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>65548</remarks>
		 [SupportByVersion("Visio", 12,14,15,16)]
		 visPasteVisioShapesWithoutDataLinks = 65548
	}
}