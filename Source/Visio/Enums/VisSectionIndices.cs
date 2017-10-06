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
	public enum VisSectionIndices
	{
		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>255</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionInval = 255,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionFirst = 0,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>252</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionLast = 252,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>255</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionNone = 255,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionObject = 1,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionMember = 2,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionCharacter = 3,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionParagraph = 4,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionTab = 5,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionScratch = 6,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionConnectionPts = 7,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionExport = 7,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionTextField = 8,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>9</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionControls = 9,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>10</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionFirstComponent = 10,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>239</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionLastComponent = 239,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>240</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionAction = 240,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>241</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionLayer = 241,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>242</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionUser = 242,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>243</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionProp = 243,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>244</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionHyperlink = 244,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>245</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionReviewer = 245,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>246</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionAnnotation = 246,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>247</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionSmartTag = 247,

		 /// <summary>
		 /// SupportByVersion Visio 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>247</remarks>
		 [SupportByVersion("Visio", 11,12,14,15,16)]
		 visSectionLastReal = 247,

		 /// <summary>
		 /// SupportByVersion Visio 15,16
		 /// </summary>
		 /// <remarks>248</remarks>
		 [SupportByVersion("Visio", 15, 16)]
		 visSectionLineGradientStops = 248,

		 /// <summary>
		 /// SupportByVersion Visio 15,16
		 /// </summary>
		 /// <remarks>249</remarks>
		 [SupportByVersion("Visio", 15, 16)]
		 visSectionFillGradientStops = 249
	}
}