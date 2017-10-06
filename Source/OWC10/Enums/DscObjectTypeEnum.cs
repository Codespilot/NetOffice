﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.OWC10Api.Enums
{
	 /// <summary>
	 /// SupportByVersion OWC10 1
	 /// </summary>
	[SupportByVersion("OWC10", 1)]
	[EntityType(EntityType.IsEnum)]
	public enum DscObjectTypeEnum
	{
		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>-1</remarks>
		 [SupportByVersion("OWC10", 1)]
		 dscobjUnknown = -1,

		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("OWC10", 1)]
		 dscobjSchemaRowsource = 1,

		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("OWC10", 1)]
		 dscobjSchemaField = 2,

		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersion("OWC10", 1)]
		 dscobjSchemaRelationship = 4,

		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersion("OWC10", 1)]
		 dscobjRecordsetDef = 8,

		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByVersion("OWC10", 1)]
		 dscobjPageRowsource = 16,

		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>32</remarks>
		 [SupportByVersion("OWC10", 1)]
		 dscobjPageField = 32,

		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>64</remarks>
		 [SupportByVersion("OWC10", 1)]
		 dscobjSublistRelationship = 64,

		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>128</remarks>
		 [SupportByVersion("OWC10", 1)]
		 dscobjLookupRelationship = 128,

		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>256</remarks>
		 [SupportByVersion("OWC10", 1)]
		 dscobjGroupingDef = 256,

		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>512</remarks>
		 [SupportByVersion("OWC10", 1)]
		 dscobjDatamodel = 512,

		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>1024</remarks>
		 [SupportByVersion("OWC10", 1)]
		 dscobjPageRelatedField = 1024,

		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>2048</remarks>
		 [SupportByVersion("OWC10", 1)]
		 dscobjParameterValue = 2048,

		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>4096</remarks>
		 [SupportByVersion("OWC10", 1)]
		 dscobjSchemaRelatedField = 4096,

		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>8192</remarks>
		 [SupportByVersion("OWC10", 1)]
		 dscobjSchemaParameter = 8192,

		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>16384</remarks>
		 [SupportByVersion("OWC10", 1)]
		 dscobjSchemaProperty = 16384,

		 /// <summary>
		 /// SupportByVersion OWC10 1
		 /// </summary>
		 /// <remarks>32768</remarks>
		 [SupportByVersion("OWC10", 1)]
		 dscobjSchemaDiagram = 32768
	}
}