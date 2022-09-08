/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Xml;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Converters
{
	internal class XmlNodeWrapper : IXmlNode // TypeDefIndex: 5492
	{
		// Fields
		private readonly XmlNode _node; // 0x10
		private List<IXmlNode> _childNodes; // 0x18
		private List<IXmlNode> _attributes; // 0x20
	
		// Properties
		public object WrappedNode { get => default; } // 0x0000000185CE6FB0-0x0000000185CE7010 
		public XmlNodeType NodeType { get => default; } // 0x0000000185CE6D90-0x0000000185CE6E10 
		public virtual string LocalName { get => default; } // 0x0000000185CE6C90-0x0000000185CE6D10 
		public List<IXmlNode> ChildNodes { get => default; } // 0x0000000185CE69C0-0x0000000185CE6C90 
		public List<IXmlNode> Attributes { get => default; } // 0x0000000185CE6720-0x0000000185CE69C0 
		public IXmlNode ParentNode { get => default; } // 0x0000000185CE6E10-0x0000000185CE6F30 
		public string Value { get => default; set {} } // 0x0000000185CE6F30-0x0000000185CE6FB0 0x0000000185CE7010-0x0000000185CE8190
		public string NamespaceUri { get => default; } // 0x0000000185CE6D10-0x0000000185CE6D90 
	
		// Constructors
		public XmlNodeWrapper() {} // Dummy constructor
		public XmlNodeWrapper(XmlNode node) {} // 0x0000000185CE66B0-0x0000000185CE6720
	
		// Methods
		internal static IXmlNode WrapNode(XmlNode node) => default; // 0x0000000185CE6570-0x0000000185CE66B0
		public IXmlNode AppendChild(IXmlNode newChild) => default; // 0x0000000185CE6470-0x0000000185CE6570
	}
}
