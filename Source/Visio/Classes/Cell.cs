﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.VisioApi
{
	#region Delegates

	#pragma warning disable
	public delegate void Cell_CellChangedEventHandler(NetOffice.VisioApi.IVCell cell);
	public delegate void Cell_FormulaChangedEventHandler(NetOffice.VisioApi.IVCell cell);
	#pragma warning restore

	#endregion

	/// <summary>
	/// CoClass Cell 
	/// SupportByVersion Visio, 11,12,14,15,16
	/// </summary>
	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/ff769228(v=office.14).aspx </remarks>
	[SupportByVersion("Visio", 11,12,14,15,16)]
	[EntityType(EntityType.IsCoClass)]
	[EventSink(typeof(Events.ECell_SinkHelper))]
    [ComEventInterface(typeof(Events.ECell))]
    public class Cell : IVCell, IEventBinding
	{
		#pragma warning disable

		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
        private static Type _type;
        private Events.ECell_SinkHelper _eCell_SinkHelper;
	
		#endregion

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

        /// <summary>
        /// Type Cache
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Cell);
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public Cell(Core factory, ICOMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public Cell(ICOMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Cell(Core factory, ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{
			
		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Cell(ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Cell(ICOMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		/// <summary>
        /// Creates a new instance of Cell 
        /// </summary>		
		public Cell():base("Visio.Cell")
		{
			
		}
		
		/// <summary>
        /// Creates a new instance of Cell
        /// </summary>
        ///<param name="progId">registered ProgID</param>
		public Cell(string progId):base(progId)
		{
			
		}

		#endregion

		#region Static CoClass Methods
		#endregion

		#region Events

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15,16
		/// </summary>
		private event Cell_CellChangedEventHandler _CellChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15,16
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/ff768996(v=office.14).aspx </remarks>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		public event Cell_CellChangedEventHandler CellChangedEvent
		{
			add
			{
				CreateEventBridge();
				_CellChangedEvent += value;
			}
			remove
			{
				_CellChangedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15,16
		/// </summary>
		private event Cell_FormulaChangedEventHandler _FormulaChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15,16
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/ff767123(v=office.14).aspx </remarks>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		public event Cell_FormulaChangedEventHandler FormulaChangedEvent
		{
			add
			{
				CreateEventBridge();
				_FormulaChangedEvent += value;
			}
			remove
			{
				_FormulaChangedEvent -= value;
			}
		}

		#endregion
       
	    #region IEventBinding
        
		/// <summary>
        /// Creates active sink helper
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public void CreateEventBridge()
        {
			if(false == Factory.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, Events.ECell_SinkHelper.Id);


			if (Events.ECell_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_eCell_SinkHelper = new Events.ECell_SinkHelper(this, _connectPoint);
				return;
			} 
        }

        /// <summary>
        /// The instance use currently an event listener 
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        /// <summary>
        /// Instance has one or more event recipients
        /// </summary>
        /// <returns>true if one or more event is active, otherwise false</returns>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients()       
        {
            return NetOffice.Events.CoClassEventReflector.HasEventRecipients(this, LateBindingApiWrapperType);            
        }

        /// <summary>
        /// Instance has one or more event recipients
        /// </summary>
        /// <param name="eventName">name of the event</param>
        /// <returns></returns>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients(string eventName)
        {
            return NetOffice.Events.CoClassEventReflector.HasEventRecipients(this, LateBindingApiWrapperType, eventName);
        }

        /// <summary>
        /// Target methods from its actual event recipients
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
            return NetOffice.Events.CoClassEventReflector.GetEventRecipients(this, LateBindingApiWrapperType, eventName);
        }
       
        /// <summary>
        /// Returns the current count of event recipients
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int GetCountOfEventRecipients(string eventName)
        {
            return NetOffice.Events.CoClassEventReflector.GetCountOfEventRecipients(this, LateBindingApiWrapperType, eventName);       
         }
        
        /// <summary>
        /// Raise an instance event
        /// </summary>
        /// <param name="eventName">name of the event without 'Event' at the end</param>
        /// <param name="paramsArray">custom arguments for the event</param>
        /// <returns>count of called event recipients</returns>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int RaiseCustomEvent(string eventName, ref object[] paramsArray)
		{
            return NetOffice.Events.CoClassEventReflector.RaiseCustomEvent(this, LateBindingApiWrapperType, eventName, ref paramsArray);
		}
        /// <summary>
        /// Stop listening events for the instance
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeEventBridge()
        {
			if( null != _eCell_SinkHelper)
			{
				_eCell_SinkHelper.Dispose();
				_eCell_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion

		#pragma warning restore
	}
}