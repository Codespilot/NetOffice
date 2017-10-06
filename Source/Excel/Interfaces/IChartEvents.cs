﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.ExcelApi
{
	/// <summary>
	/// Interface IChartEvents 
	/// SupportByVersion Excel, 9,10,11,12,14,15,16
	/// </summary>
	[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
	[EntityType(EntityType.IsInterface)]
 	public class IChartEvents : COMObject
	{
		#pragma warning disable

		#region Type Information

        /// <summary>
        /// Instance Type
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type InstanceType
        {
            get
            {
                return LateBindingApiWrapperType;
            }
        }

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(IChartEvents);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <param name="factory">current used factory core</param>
		/// <param name="parentObject">object there has created the proxy</param>
		/// <param name="proxyShare">proxy share instead if com proxy</param>
		public IChartEvents(Core factory, ICOMObject parentObject, COMProxyShare proxyShare) : base(factory, parentObject, proxyShare)
		{
		}

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public IChartEvents(Core factory, ICOMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IChartEvents(ICOMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IChartEvents(Core factory, ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IChartEvents(ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IChartEvents(ICOMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IChartEvents() : base()
		{
		}
		
		/// <param name="progId">registered progID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IChartEvents(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public Int32 Activate()
		{
			return Factory.ExecuteInt32MethodGet(this, "Activate");
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public Int32 Deactivate()
		{
			return Factory.ExecuteInt32MethodGet(this, "Deactivate");
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public Int32 Resize()
		{
			return Factory.ExecuteInt32MethodGet(this, "Resize");
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="button">Int32 button</param>
		/// <param name="shift">Int32 shift</param>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public Int32 MouseDown(Int32 button, Int32 shift, Int32 x, Int32 y)
		{
			return Factory.ExecuteInt32MethodGet(this, "MouseDown", button, shift, x, y);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="button">Int32 button</param>
		/// <param name="shift">Int32 shift</param>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public Int32 MouseUp(Int32 button, Int32 shift, Int32 x, Int32 y)
		{
			return Factory.ExecuteInt32MethodGet(this, "MouseUp", button, shift, x, y);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="button">Int32 button</param>
		/// <param name="shift">Int32 shift</param>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public Int32 MouseMove(Int32 button, Int32 shift, Int32 x, Int32 y)
		{
			return Factory.ExecuteInt32MethodGet(this, "MouseMove", button, shift, x, y);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="cancel">bool cancel</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public Int32 BeforeRightClick(bool cancel)
		{
			return Factory.ExecuteInt32MethodGet(this, "BeforeRightClick", cancel);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public Int32 DragPlot()
		{
			return Factory.ExecuteInt32MethodGet(this, "DragPlot");
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public Int32 DragOver()
		{
			return Factory.ExecuteInt32MethodGet(this, "DragOver");
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="elementID">Int32 elementID</param>
		/// <param name="arg1">Int32 arg1</param>
		/// <param name="arg2">Int32 arg2</param>
		/// <param name="cancel">bool cancel</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public Int32 BeforeDoubleClick(Int32 elementID, Int32 arg1, Int32 arg2, bool cancel)
		{
			return Factory.ExecuteInt32MethodGet(this, "BeforeDoubleClick", elementID, arg1, arg2, cancel);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="elementID">Int32 elementID</param>
		/// <param name="arg1">Int32 arg1</param>
		/// <param name="arg2">Int32 arg2</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public Int32 Select(Int32 elementID, Int32 arg1, Int32 arg2)
		{
			return Factory.ExecuteInt32MethodGet(this, "Select", elementID, arg1, arg2);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="seriesIndex">Int32 seriesIndex</param>
		/// <param name="pointIndex">Int32 pointIndex</param>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public Int32 SeriesChange(Int32 seriesIndex, Int32 pointIndex)
		{
			return Factory.ExecuteInt32MethodGet(this, "SeriesChange", seriesIndex, pointIndex);
		}

		/// <summary>
		/// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Excel", 9,10,11,12,14,15,16)]
		public Int32 Calculate()
		{
			return Factory.ExecuteInt32MethodGet(this, "Calculate");
		}

		#endregion

		#pragma warning restore
	}
}
