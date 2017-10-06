﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.VisioApi
{
	#region Delegates

	#pragma warning disable
	public delegate void Style_StyleChangedEventHandler(NetOffice.VisioApi.IVStyle style);
	public delegate void Style_BeforeStyleDeleteEventHandler(NetOffice.VisioApi.IVStyle style);
	public delegate void Style_QueryCancelStyleDeleteEventHandler(NetOffice.VisioApi.IVStyle style);
	public delegate void Style_StyleDeleteCanceledEventHandler(NetOffice.VisioApi.IVStyle style);
	#pragma warning restore

	#endregion

	/// <summary>
	/// CoClass Style 
	/// SupportByVersion Visio, 11,12,14,15,16
	/// </summary>
	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/ff769398(v=office.14).aspx </remarks>
	[SupportByVersion("Visio", 11,12,14,15,16)]
	[EntityType(EntityType.IsCoClass)]
	[EventSink(typeof(Events.EStyle_SinkHelper))]
    [ComEventInterface(typeof(Events.EStyle))]
    public class Style : IVStyle, IEventBinding
	{
		#pragma warning disable

		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
        private static Type _type;
        private Events.EStyle_SinkHelper _eStyle_SinkHelper;
	
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
                    _type = typeof(Style);
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public Style(Core factory, ICOMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public Style(ICOMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Style(Core factory, ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{
			
		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Style(ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Style(ICOMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		/// <summary>
        /// Creates a new instance of Style 
        /// </summary>		
		public Style():base("Visio.Style")
		{
			
		}
		
		/// <summary>
        /// Creates a new instance of Style
        /// </summary>
        ///<param name="progId">registered ProgID</param>
		public Style(string progId):base(progId)
		{
			
		}

		#endregion

		#region Static CoClass Methods
		#endregion

		#region Events

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15,16
		/// </summary>
		private event Style_StyleChangedEventHandler _StyleChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15,16
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/ff768814(v=office.14).aspx </remarks>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		public event Style_StyleChangedEventHandler StyleChangedEvent
		{
			add
			{
				CreateEventBridge();
				_StyleChangedEvent += value;
			}
			remove
			{
				_StyleChangedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15,16
		/// </summary>
		private event Style_BeforeStyleDeleteEventHandler _BeforeStyleDeleteEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15,16
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/ff765885(v=office.14).aspx </remarks>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		public event Style_BeforeStyleDeleteEventHandler BeforeStyleDeleteEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeStyleDeleteEvent += value;
			}
			remove
			{
				_BeforeStyleDeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15,16
		/// </summary>
		private event Style_QueryCancelStyleDeleteEventHandler _QueryCancelStyleDeleteEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15,16
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/ff766049(v=office.14).aspx </remarks>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		public event Style_QueryCancelStyleDeleteEventHandler QueryCancelStyleDeleteEvent
		{
			add
			{
				CreateEventBridge();
				_QueryCancelStyleDeleteEvent += value;
			}
			remove
			{
				_QueryCancelStyleDeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 11,12,14,15,16
		/// </summary>
		private event Style_StyleDeleteCanceledEventHandler _StyleDeleteCanceledEvent;

		/// <summary>
		/// SupportByVersion Visio 11 12 14 15,16
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/ff765208(v=office.14).aspx </remarks>
		[SupportByVersion("Visio", 11,12,14,15,16)]
		public event Style_StyleDeleteCanceledEventHandler StyleDeleteCanceledEvent
		{
			add
			{
				CreateEventBridge();
				_StyleDeleteCanceledEvent += value;
			}
			remove
			{
				_StyleDeleteCanceledEvent -= value;
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, Events.EStyle_SinkHelper.Id);


			if(Events.EStyle_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_eStyle_SinkHelper = new Events.EStyle_SinkHelper(this, _connectPoint);
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
			if( null != _eStyle_SinkHelper)
			{
				_eStyle_SinkHelper.Dispose();
				_eStyle_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion

		#pragma warning restore
	}
}

