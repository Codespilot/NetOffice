﻿using System.Reflection;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.OWC10Api
{
	/// <summary>
	/// DispatchInterface IXRangeEnum 
	/// SupportByVersion OWC10, 1
	/// </summary>
	[SupportByVersion("OWC10", 1)]
	[EntityType(EntityType.IsDispatchInterface)]
 	public class IXRangeEnum : COMObject
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
                    _type = typeof(IXRangeEnum);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <param name="factory">current used factory core</param>
		/// <param name="parentObject">object there has created the proxy</param>
		/// <param name="proxyShare">proxy share instead if com proxy</param>
		public IXRangeEnum(Core factory, ICOMObject parentObject, COMProxyShare proxyShare) : base(factory, parentObject, proxyShare)
		{
		}

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public IXRangeEnum(Core factory, ICOMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IXRangeEnum(ICOMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IXRangeEnum(Core factory, ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IXRangeEnum(ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IXRangeEnum(ICOMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IXRangeEnum() : base()
		{
		}
		
		/// <param name="progId">registered progID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IXRangeEnum(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		public UIntPtr RowCount
		{
			get
			{
				return Factory.ExecuteUIntPtrPropertyGet(this, "RowCount");
			}
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		public UIntPtr ColCount
		{
			get
			{
				return Factory.ExecuteUIntPtrPropertyGet(this, "ColCount");
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		/// <param name="cElt">Int32 cElt</param>
		/// <param name="rgvar">object rgvar</param>
		/// <param name="pcEltFetched">Int32 pcEltFetched</param>
		[SupportByVersion("OWC10", 1)]
		public void Next(Int32 cElt, out object rgvar, out Int32 pcEltFetched)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true);
			rgvar = null;
			pcEltFetched = 0;
			object[] paramsArray = Invoker.ValidateParamsArray(cElt, rgvar, pcEltFetched);
			Invoker.Method(this, "Next", paramsArray, modifiers);
			rgvar = (object)paramsArray[1];
			pcEltFetched = (Int32)paramsArray[2];
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		/// <param name="cElt">Int32 cElt</param>
		[SupportByVersion("OWC10", 1)]
		public void Skip(Int32 cElt)
		{
			 Factory.ExecuteMethod(this, "Skip", cElt);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		public void Reset()
		{
			 Factory.ExecuteMethod(this, "Reset");
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		/// <param name="ppEnum">NetOffice.OWC10Api.IXRangeEnum ppEnum</param>
		[SupportByVersion("OWC10", 1)]
		public void Clone(out NetOffice.OWC10Api.IXRangeEnum ppEnum)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			ppEnum = null;
			object[] paramsArray = Invoker.ValidateParamsArray(ppEnum);
			Invoker.Method(this, "Clone", paramsArray, modifiers);
            if (paramsArray[0] is MarshalByRefObject)
                ppEnum = new NetOffice.OWC10Api.IXRangeEnum(this, paramsArray[0]);
            else
                ppEnum = null;
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		/// <param name="nTraverseCode">UIntPtr nTraverseCode</param>
		[SupportByVersion("OWC10", 1)]
		public void SetTraversal(UIntPtr nTraverseCode)
		{
			 Factory.ExecuteMethod(this, "SetTraversal", nTraverseCode);
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		/// <param name="_out">object out</param>
		/// <param name="_in">object in</param>
		/// <param name="vt">Int16 vt</param>
		[SupportByVersion("OWC10", 1)]
		public void ChangeType(out object _out, object _in, Int16 vt)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,false,false);
			_out = null;
			object[] paramsArray = Invoker.ValidateParamsArray(_out, _in, vt);
			Invoker.Method(this, "ChangeType", paramsArray, modifiers);
			_out = (object)paramsArray[0];
		}

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		/// <param name="cElt">Int32 cElt</param>
		/// <param name="iStart">Int32 iStart</param>
		/// <param name="rvarDest">object rvarDest</param>
		/// <param name="pcFetched">Int32 pcFetched</param>
		/// <param name="vtCoerceTo">Int16 vtCoerceTo</param>
		/// <param name="vtbCoerceFrom">Int32 vtbCoerceFrom</param>
		/// <param name="fill">object fill</param>
		[SupportByVersion("OWC10", 1)]
		public void GetElements(Int32 cElt, Int32 iStart, object rvarDest, out Int32 pcFetched, Int16 vtCoerceTo, Int32 vtbCoerceFrom, object fill)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,false,true,false,false,false);
			pcFetched = 0;
			object[] paramsArray = Invoker.ValidateParamsArray(cElt, iStart, rvarDest, pcFetched, vtCoerceTo, vtbCoerceFrom, fill);
			Invoker.Method(this, "GetElements", paramsArray, modifiers);
			pcFetched = (Int32)paramsArray[3];
		}

		#endregion

		#pragma warning restore
	}
}
