﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.WordApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff844990.aspx </remarks>
	[SupportByVersion("Word", 9,10,11,12,14,15,16)]
	[EntityType(EntityType.IsEnum)]
	public enum WdStoryType
	{
		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("Word", 9,10,11,12,14,15,16)]
		 wdMainTextStory = 1,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("Word", 9,10,11,12,14,15,16)]
		 wdFootnotesStory = 2,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersion("Word", 9,10,11,12,14,15,16)]
		 wdEndnotesStory = 3,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersion("Word", 9,10,11,12,14,15,16)]
		 wdCommentsStory = 4,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersion("Word", 9,10,11,12,14,15,16)]
		 wdTextFrameStory = 5,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersion("Word", 9,10,11,12,14,15,16)]
		 wdEvenPagesHeaderStory = 6,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersion("Word", 9,10,11,12,14,15,16)]
		 wdPrimaryHeaderStory = 7,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersion("Word", 9,10,11,12,14,15,16)]
		 wdEvenPagesFooterStory = 8,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>9</remarks>
		 [SupportByVersion("Word", 9,10,11,12,14,15,16)]
		 wdPrimaryFooterStory = 9,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>10</remarks>
		 [SupportByVersion("Word", 9,10,11,12,14,15,16)]
		 wdFirstPageHeaderStory = 10,

		 /// <summary>
		 /// SupportByVersion Word 9, 10, 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>11</remarks>
		 [SupportByVersion("Word", 9,10,11,12,14,15,16)]
		 wdFirstPageFooterStory = 11,

		 /// <summary>
		 /// SupportByVersion Word 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>12</remarks>
		 [SupportByVersion("Word", 11,12,14,15,16)]
		 wdFootnoteSeparatorStory = 12,

		 /// <summary>
		 /// SupportByVersion Word 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>13</remarks>
		 [SupportByVersion("Word", 11,12,14,15,16)]
		 wdFootnoteContinuationSeparatorStory = 13,

		 /// <summary>
		 /// SupportByVersion Word 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>14</remarks>
		 [SupportByVersion("Word", 11,12,14,15,16)]
		 wdFootnoteContinuationNoticeStory = 14,

		 /// <summary>
		 /// SupportByVersion Word 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>15</remarks>
		 [SupportByVersion("Word", 11,12,14,15,16)]
		 wdEndnoteSeparatorStory = 15,

		 /// <summary>
		 /// SupportByVersion Word 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByVersion("Word", 11,12,14,15,16)]
		 wdEndnoteContinuationSeparatorStory = 16,

		 /// <summary>
		 /// SupportByVersion Word 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>17</remarks>
		 [SupportByVersion("Word", 11,12,14,15,16)]
		 wdEndnoteContinuationNoticeStory = 17
	}
}