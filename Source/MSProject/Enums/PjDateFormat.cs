﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.MSProjectApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSProject 11, 12, 14
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff867191(v=office.14).aspx </remarks>
	[SupportByVersion("MSProject", 11,12,14)]
	[EntityType(EntityType.IsEnum)]
	public enum PjDateFormat
	{
		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>255</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjDateDefault = 255,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjDate_mm_dd_yy_hh_mmAM = 0,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjDate_mm_dd_yy = 1,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjDate_mmmm_dd_yyyy_hh_mmAM = 2,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjDate_mmmm_dd_yyyy = 3,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjDate_mmm_dd_hh_mmAM = 4,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjDate_mmm_dd_yyy = 5,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjDate_mmmm_dd = 6,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjDate_mmm_dd = 7,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjDate_ddd_mm_dd_yy_hh_mmAM = 8,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>9</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjDate_ddd_mm_dd_yy = 9,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>10</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjDate_ddd_mmm_dd_yyy = 10,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>11</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjDate_ddd_hh_mmAM = 11,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>12</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjDate_mm_dd = 12,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>13</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjDate_dd = 13,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>14</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjDate_hh_mmAM = 14,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>15</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjDate_ddd_mmm_dd = 15,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjDate_ddd_mm_dd = 16,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>17</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjDate_ddd_dd = 17,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>18</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjDate_Www_dd = 18,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>19</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjDate_Www_dd_yy_hh_mmAM = 19,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>20</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjDate_mm_dd_yyyy = 20
	}
}