﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.MSProjectApi.Enums
{
	 /// <summary>
	 /// SupportByVersion MSProject 11, 12, 14
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff864310(v=office.14).aspx </remarks>
	[SupportByVersion("MSProject", 11,12,14)]
	[EntityType(EntityType.IsEnum)]
	public enum PjGroupOn
	{
		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnEachValue = 0,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnInterval = 1,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>10</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnDateEachValue = 10,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>11</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnDateMinute = 11,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>12</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnDateHour = 12,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>13</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnDateDay = 13,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>14</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnDateWeek = 14,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>15</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnDateThirdOfMonth = 15,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnDateMonth = 16,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>17</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnDateQtr = 17,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>18</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnDateYear = 18,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>20</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnDurationEachValue = 20,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>21</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnDurationMinutes = 21,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>22</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnDurationHours = 22,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>23</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnDurationDays = 23,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>24</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnDurationWeeks = 24,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>25</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnDurationMonths = 25,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>30</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnOutlineEachValue = 30,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>31</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnOutlineLevel = 31,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>40</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnPctEachValue = 40,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>41</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnPctInterval = 41,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>42</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnPct1_99 = 42,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>43</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnPct1_50 = 43,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>44</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnPct1_25 = 44,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>45</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnPct1_10 = 45,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>50</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnTextEachValue = 50,

		 /// <summary>
		 /// SupportByVersion MSProject 11, 12, 14
		 /// </summary>
		 /// <remarks>51</remarks>
		 [SupportByVersion("MSProject", 11,12,14)]
		 pjGroupOnTextPrefix = 51
	}
}