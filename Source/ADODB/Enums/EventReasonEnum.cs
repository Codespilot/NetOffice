﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.ADODBApi.Enums
{
	 /// <summary>
	 /// SupportByVersion ADODB 2.1, 2.5
	 /// </summary>
	[SupportByVersion("ADODB", 2.1,2.5)]
	[EntityType(EntityType.IsEnum)]
	public enum EventReasonEnum
	{
		 /// <summary>
		 /// SupportByVersion ADODB 2.1, 2.5
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("ADODB", 2.1,2.5)]
		 adRsnAddNew = 1,

		 /// <summary>
		 /// SupportByVersion ADODB 2.1, 2.5
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("ADODB", 2.1,2.5)]
		 adRsnDelete = 2,

		 /// <summary>
		 /// SupportByVersion ADODB 2.1, 2.5
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersion("ADODB", 2.1,2.5)]
		 adRsnUpdate = 3,

		 /// <summary>
		 /// SupportByVersion ADODB 2.1, 2.5
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersion("ADODB", 2.1,2.5)]
		 adRsnUndoUpdate = 4,

		 /// <summary>
		 /// SupportByVersion ADODB 2.1, 2.5
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersion("ADODB", 2.1,2.5)]
		 adRsnUndoAddNew = 5,

		 /// <summary>
		 /// SupportByVersion ADODB 2.1, 2.5
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersion("ADODB", 2.1,2.5)]
		 adRsnUndoDelete = 6,

		 /// <summary>
		 /// SupportByVersion ADODB 2.1, 2.5
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersion("ADODB", 2.1,2.5)]
		 adRsnRequery = 7,

		 /// <summary>
		 /// SupportByVersion ADODB 2.1, 2.5
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersion("ADODB", 2.1,2.5)]
		 adRsnResynch = 8,

		 /// <summary>
		 /// SupportByVersion ADODB 2.1, 2.5
		 /// </summary>
		 /// <remarks>9</remarks>
		 [SupportByVersion("ADODB", 2.1,2.5)]
		 adRsnClose = 9,

		 /// <summary>
		 /// SupportByVersion ADODB 2.1, 2.5
		 /// </summary>
		 /// <remarks>10</remarks>
		 [SupportByVersion("ADODB", 2.1,2.5)]
		 adRsnMove = 10,

		 /// <summary>
		 /// SupportByVersion ADODB 2.1, 2.5
		 /// </summary>
		 /// <remarks>11</remarks>
		 [SupportByVersion("ADODB", 2.1,2.5)]
		 adRsnFirstChange = 11,

		 /// <summary>
		 /// SupportByVersion ADODB 2.1, 2.5
		 /// </summary>
		 /// <remarks>12</remarks>
		 [SupportByVersion("ADODB", 2.1,2.5)]
		 adRsnMoveFirst = 12,

		 /// <summary>
		 /// SupportByVersion ADODB 2.1, 2.5
		 /// </summary>
		 /// <remarks>13</remarks>
		 [SupportByVersion("ADODB", 2.1,2.5)]
		 adRsnMoveNext = 13,

		 /// <summary>
		 /// SupportByVersion ADODB 2.1, 2.5
		 /// </summary>
		 /// <remarks>14</remarks>
		 [SupportByVersion("ADODB", 2.1,2.5)]
		 adRsnMovePrevious = 14,

		 /// <summary>
		 /// SupportByVersion ADODB 2.1, 2.5
		 /// </summary>
		 /// <remarks>15</remarks>
		 [SupportByVersion("ADODB", 2.1,2.5)]
		 adRsnMoveLast = 15
	}
}