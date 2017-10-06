﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.OfficeApi
{
	/// <summary>
	/// DispatchInterface DiagramNode 
	/// SupportByVersion Office, 10,11,12,14,15,16
	/// </summary>
	[SupportByVersion("Office", 10,11,12,14,15,16)]
	[EntityType(EntityType.IsDispatchInterface)]
    [Duplicate("NetOffice.ExcelApi.DiagramNode")]
    public class DiagramNode : _IMsoDispObj
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
                    _type = typeof(DiagramNode);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <param name="factory">current used factory core</param>
		/// <param name="parentObject">object there has created the proxy</param>
		/// <param name="proxyShare">proxy share instead if com proxy</param>
		public DiagramNode(Core factory, ICOMObject parentObject, COMProxyShare proxyShare) : base(factory, parentObject, proxyShare)
		{
		}

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public DiagramNode(Core factory, ICOMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode(ICOMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode(Core factory, ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode(ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode(ICOMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode() : base()
		{
		}
		
		/// <param name="progId">registered progID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Office", 10,11,12,14,15,16), ProxyResult]
		public object Parent
		{
			get
			{
				return Factory.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public NetOffice.OfficeApi.DiagramNodeChildren Children
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.DiagramNodeChildren>(this, "Children", NetOffice.OfficeApi.DiagramNodeChildren.LateBindingApiWrapperType);
			}
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public NetOffice.OfficeApi.Shape Shape
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.Shape>(this, "Shape", NetOffice.OfficeApi.Shape.LateBindingApiWrapperType);
			}
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public NetOffice.OfficeApi.DiagramNode Root
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.DiagramNode>(this, "Root", NetOffice.OfficeApi.DiagramNode.LateBindingApiWrapperType);
			}
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public NetOffice.OfficeApi.IMsoDiagram Diagram
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.IMsoDiagram>(this, "Diagram", NetOffice.OfficeApi.IMsoDiagram.LateBindingApiWrapperType);
			}
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public NetOffice.OfficeApi.Enums.MsoOrgChartLayoutType Layout
		{
			get
			{
				return Factory.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoOrgChartLayoutType>(this, "Layout");
			}
			set
			{
				Factory.ExecuteEnumPropertySet(this, "Layout", value);
			}
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public NetOffice.OfficeApi.Shape TextShape
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.Shape>(this, "TextShape", NetOffice.OfficeApi.Shape.LateBindingApiWrapperType);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="pos">optional NetOffice.OfficeApi.Enums.MsoRelativeNodePosition Pos = 2</param>
		/// <param name="nodeType">optional NetOffice.OfficeApi.Enums.MsoDiagramNodeType NodeType = 1</param>
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public NetOffice.OfficeApi.DiagramNode AddNode(object pos, object nodeType)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.DiagramNode>(this, "AddNode", NetOffice.OfficeApi.DiagramNode.LateBindingApiWrapperType, pos, nodeType);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// </summary>
		[CustomMethod]
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public NetOffice.OfficeApi.DiagramNode AddNode()
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.DiagramNode>(this, "AddNode", NetOffice.OfficeApi.DiagramNode.LateBindingApiWrapperType);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="pos">optional NetOffice.OfficeApi.Enums.MsoRelativeNodePosition Pos = 2</param>
		[CustomMethod]
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public NetOffice.OfficeApi.DiagramNode AddNode(object pos)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.DiagramNode>(this, "AddNode", NetOffice.OfficeApi.DiagramNode.LateBindingApiWrapperType, pos);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public void Delete()
		{
			 Factory.ExecuteMethod(this, "Delete");
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="targetNode">NetOffice.OfficeApi.DiagramNode targetNode</param>
		/// <param name="pos">NetOffice.OfficeApi.Enums.MsoRelativeNodePosition pos</param>
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public void MoveNode(NetOffice.OfficeApi.DiagramNode targetNode, NetOffice.OfficeApi.Enums.MsoRelativeNodePosition pos)
		{
			 Factory.ExecuteMethod(this, "MoveNode", targetNode, pos);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="targetNode">NetOffice.OfficeApi.DiagramNode targetNode</param>
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public void ReplaceNode(NetOffice.OfficeApi.DiagramNode targetNode)
		{
			 Factory.ExecuteMethod(this, "ReplaceNode", targetNode);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="targetNode">NetOffice.OfficeApi.DiagramNode targetNode</param>
		/// <param name="swapChildren">optional bool SwapChildren = true</param>
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public void SwapNode(NetOffice.OfficeApi.DiagramNode targetNode, object swapChildren)
		{
			 Factory.ExecuteMethod(this, "SwapNode", targetNode, swapChildren);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="targetNode">NetOffice.OfficeApi.DiagramNode targetNode</param>
		[CustomMethod]
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public void SwapNode(NetOffice.OfficeApi.DiagramNode targetNode)
		{
			 Factory.ExecuteMethod(this, "SwapNode", targetNode);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="copyChildren">bool copyChildren</param>
		/// <param name="targetNode">NetOffice.OfficeApi.DiagramNode targetNode</param>
		/// <param name="pos">optional NetOffice.OfficeApi.Enums.MsoRelativeNodePosition Pos = 2</param>
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public NetOffice.OfficeApi.DiagramNode CloneNode(bool copyChildren, NetOffice.OfficeApi.DiagramNode targetNode, object pos)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.DiagramNode>(this, "CloneNode", NetOffice.OfficeApi.DiagramNode.LateBindingApiWrapperType, copyChildren, targetNode, pos);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="copyChildren">bool copyChildren</param>
		/// <param name="targetNode">NetOffice.OfficeApi.DiagramNode targetNode</param>
		[CustomMethod]
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public NetOffice.OfficeApi.DiagramNode CloneNode(bool copyChildren, NetOffice.OfficeApi.DiagramNode targetNode)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.DiagramNode>(this, "CloneNode", NetOffice.OfficeApi.DiagramNode.LateBindingApiWrapperType, copyChildren, targetNode);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// </summary>
		/// <param name="receivingNode">NetOffice.OfficeApi.DiagramNode receivingNode</param>
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public void TransferChildren(NetOffice.OfficeApi.DiagramNode receivingNode)
		{
			 Factory.ExecuteMethod(this, "TransferChildren", receivingNode);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public NetOffice.OfficeApi.DiagramNode NextNode()
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.DiagramNode>(this, "NextNode", NetOffice.OfficeApi.DiagramNode.LateBindingApiWrapperType);
		}

		/// <summary>
		/// SupportByVersion Office 10, 11, 12, 14, 15, 16
		/// </summary>
		[SupportByVersion("Office", 10,11,12,14,15,16)]
		public NetOffice.OfficeApi.DiagramNode PrevNode()
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.DiagramNode>(this, "PrevNode", NetOffice.OfficeApi.DiagramNode.LateBindingApiWrapperType);
		}

		#endregion

		#pragma warning restore
	}
}
