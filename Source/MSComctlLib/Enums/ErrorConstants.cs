﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.MSComctlLibApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSComctlLib 6
	 /// </summary>
	[SupportByVersion("MSComctlLib", 6)]
	[EntityType(EntityType.IsEnum)]
	public enum ErrorConstants
	{
		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccInvalidProcedureCall = 5,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccOutOfMemory = 7,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>13</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccTypeMismatch = 13,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>91</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccObjectVariableNotSet = 91,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>380</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccInvalidPropertyValue = 380,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>382</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccSetNotSupportedAtRuntime = 382,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>383</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccSetNotSupported = 383,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>387</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccSetNotPermitted = 387,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>394</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccGetNotSupported = 394,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>481</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccInvalidPicture = 481,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>425</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccInvalidObjectUse = 425,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>461</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccWrongClipboardFormat = 461,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>672</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccDataObjectLocked = 672,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>673</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccExpectedAnArgument = 673,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>674</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccRecursiveOleDrag = 674,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>675</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccFormatNotByteArray = 675,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>676</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccDataNotSetForFormat = 676,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>35600</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccIndexOutOfBounds = 35600,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>35601</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccElemNotFound = 35601,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>35602</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccNonUniqueKey = 35602,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>35603</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccInvalidKey = 35603,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>35605</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccElemNotPartOfCollection = 35605,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>35606</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccCollectionChangedDuringEnum = 35606,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>35614</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccWouldIntroduceCycle = 35614,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>35607</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccMissingRequiredArg = 35607,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>35610</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccBadObjectReference = 35610,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>35700</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccCircularReference = 35700,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>35604</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccCol1MustBeLeftAligned = 35604,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>35611</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccReadOnlyIfHasImages = 35611,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>35613</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccImageListMustBeInitialized = 35613,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>35615</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccNotSameSize = 35615,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>35617</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccImageListLocked = 35617,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>35616</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccMaxPanelsExceeded = 35616,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>35619</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccMaxButtonsExceeded = 35619,

		 /// <summary>
		 /// SupportByVersion MSComctlLib 6
		 /// </summary>
		 /// <remarks>680</remarks>
		 [SupportByVersion("MSComctlLib", 6)]
		 ccInvalidSafeModeProcCall = 680
	}
}