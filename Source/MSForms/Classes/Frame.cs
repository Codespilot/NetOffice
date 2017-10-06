﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.MSFormsApi
{
	#region Delegates

	#pragma warning disable
	public delegate void Frame_AddControlEventHandler(NetOffice.MSFormsApi.Control control);
	public delegate void Frame_BeforeDragOverEventHandler(NetOffice.MSFormsApi.ReturnBoolean cancel, NetOffice.MSFormsApi.Control control, NetOffice.MSFormsApi.DataObject data, Single x, Single y, NetOffice.MSFormsApi.Enums.fmDragState state, NetOffice.MSFormsApi.ReturnEffect effect, Int16 shift);
	public delegate void Frame_BeforeDropOrPasteEventHandler(NetOffice.MSFormsApi.ReturnBoolean cancel, NetOffice.MSFormsApi.Control control, NetOffice.MSFormsApi.Enums.fmAction action, NetOffice.MSFormsApi.DataObject data, Single x, Single y, NetOffice.MSFormsApi.ReturnEffect effect, Int16 shift);
	public delegate void Frame_ClickEventHandler();
	public delegate void Frame_DblClickEventHandler(NetOffice.MSFormsApi.ReturnBoolean cancel);
	public delegate void Frame_ErrorEventHandler(Int16 number, NetOffice.MSFormsApi.ReturnString description, Int32 sCode, string source, string helpFile, Int32 helpContext, NetOffice.MSFormsApi.ReturnBoolean cancelDisplay);
	public delegate void Frame_KeyDownEventHandler(NetOffice.MSFormsApi.ReturnInteger keyCode, Int16 shift);
	public delegate void Frame_KeyPressEventHandler(NetOffice.MSFormsApi.ReturnInteger keyAscii);
	public delegate void Frame_KeyUpEventHandler(NetOffice.MSFormsApi.ReturnInteger keyCode, Int16 shift);
	public delegate void Frame_LayoutEventHandler();
	public delegate void Frame_MouseDownEventHandler(Int16 button, Int16 shift, Single x, Single y);
	public delegate void Frame_MouseMoveEventHandler(Int16 button, Int16 shift, Single x, Single y);
	public delegate void Frame_MouseUpEventHandler(Int16 button, Int16 shift, Single x, Single y);
	public delegate void Frame_RemoveControlEventHandler(NetOffice.MSFormsApi.Control control);
	public delegate void Frame_ScrollEventHandler(NetOffice.MSFormsApi.Enums.fmScrollAction actionX, NetOffice.MSFormsApi.Enums.fmScrollAction actionY, Single requestDx, Single requestDy, NetOffice.MSFormsApi.ReturnSingle actualDx, NetOffice.MSFormsApi.ReturnSingle actualDy);
	public delegate void Frame_ZoomEventHandler(ref Int16 percent);
	#pragma warning restore

	#endregion

	/// <summary>
	/// CoClass Frame 
	/// SupportByVersion MSForms, 2
	/// </summary>
	[SupportByVersion("MSForms", 2)]
	[EntityType(EntityType.IsCoClass)]
	[EventSink(typeof(Events.OptionFrameEvents_SinkHelper))]
    [ComEventInterface(typeof(Events.OptionFrameEvents))]
    public class Frame : IOptionFrame, IEventBinding
	{
		#pragma warning disable

		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
        private static Type _type;
        private Events.OptionFrameEvents_SinkHelper _optionFrameEvents_SinkHelper;
	
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
                    _type = typeof(Frame);
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public Frame(Core factory, ICOMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public Frame(ICOMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Frame(Core factory, ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{
			
		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Frame(ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Frame(ICOMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		/// <summary>
        /// Creates a new instance of Frame 
        /// </summary>		
		public Frame():base("MSForms.Frame")
		{
			
		}
		
		/// <summary>
        /// Creates a new instance of Frame
        /// </summary>
        ///<param name="progId">registered ProgID</param>
		public Frame(string progId):base(progId)
		{
			
		}

		#endregion

		#region Static CoClass Methods
		#endregion

		#region Events

		/// <summary>
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event Frame_AddControlEventHandler _AddControlEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event Frame_AddControlEventHandler AddControlEvent
		{
			add
			{
				CreateEventBridge();
				_AddControlEvent += value;
			}
			remove
			{
				_AddControlEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event Frame_BeforeDragOverEventHandler _BeforeDragOverEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event Frame_BeforeDragOverEventHandler BeforeDragOverEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeDragOverEvent += value;
			}
			remove
			{
				_BeforeDragOverEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event Frame_BeforeDropOrPasteEventHandler _BeforeDropOrPasteEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event Frame_BeforeDropOrPasteEventHandler BeforeDropOrPasteEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeDropOrPasteEvent += value;
			}
			remove
			{
				_BeforeDropOrPasteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event Frame_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event Frame_ClickEventHandler ClickEvent
		{
			add
			{
				CreateEventBridge();
				_ClickEvent += value;
			}
			remove
			{
				_ClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event Frame_DblClickEventHandler _DblClickEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event Frame_DblClickEventHandler DblClickEvent
		{
			add
			{
				CreateEventBridge();
				_DblClickEvent += value;
			}
			remove
			{
				_DblClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event Frame_ErrorEventHandler _ErrorEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event Frame_ErrorEventHandler ErrorEvent
		{
			add
			{
				CreateEventBridge();
				_ErrorEvent += value;
			}
			remove
			{
				_ErrorEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event Frame_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event Frame_KeyDownEventHandler KeyDownEvent
		{
			add
			{
				CreateEventBridge();
				_KeyDownEvent += value;
			}
			remove
			{
				_KeyDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event Frame_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event Frame_KeyPressEventHandler KeyPressEvent
		{
			add
			{
				CreateEventBridge();
				_KeyPressEvent += value;
			}
			remove
			{
				_KeyPressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event Frame_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event Frame_KeyUpEventHandler KeyUpEvent
		{
			add
			{
				CreateEventBridge();
				_KeyUpEvent += value;
			}
			remove
			{
				_KeyUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event Frame_LayoutEventHandler _LayoutEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event Frame_LayoutEventHandler LayoutEvent
		{
			add
			{
				CreateEventBridge();
				_LayoutEvent += value;
			}
			remove
			{
				_LayoutEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event Frame_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event Frame_MouseDownEventHandler MouseDownEvent
		{
			add
			{
				CreateEventBridge();
				_MouseDownEvent += value;
			}
			remove
			{
				_MouseDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event Frame_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event Frame_MouseMoveEventHandler MouseMoveEvent
		{
			add
			{
				CreateEventBridge();
				_MouseMoveEvent += value;
			}
			remove
			{
				_MouseMoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event Frame_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event Frame_MouseUpEventHandler MouseUpEvent
		{
			add
			{
				CreateEventBridge();
				_MouseUpEvent += value;
			}
			remove
			{
				_MouseUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event Frame_RemoveControlEventHandler _RemoveControlEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event Frame_RemoveControlEventHandler RemoveControlEvent
		{
			add
			{
				CreateEventBridge();
				_RemoveControlEvent += value;
			}
			remove
			{
				_RemoveControlEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event Frame_ScrollEventHandler _ScrollEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event Frame_ScrollEventHandler ScrollEvent
		{
			add
			{
				CreateEventBridge();
				_ScrollEvent += value;
			}
			remove
			{
				_ScrollEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion MSForms, 2
		/// </summary>
		private event Frame_ZoomEventHandler _ZoomEvent;

		/// <summary>
		/// SupportByVersion MSForms 2
		/// </summary>
		[SupportByVersion("MSForms", 2)]
		public event Frame_ZoomEventHandler ZoomEvent
		{
			add
			{
				CreateEventBridge();
				_ZoomEvent += value;
			}
			remove
			{
				_ZoomEvent -= value;
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, Events.OptionFrameEvents_SinkHelper.Id);


			if(Events.OptionFrameEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_optionFrameEvents_SinkHelper = new Events.OptionFrameEvents_SinkHelper(this, _connectPoint);
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
			if( null != _optionFrameEvents_SinkHelper)
			{
				_optionFrameEvents_SinkHelper.Dispose();
				_optionFrameEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion

		#pragma warning restore
	}
}

