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
	internal interface IXmlNode // TypeDefIndex: 5497
	{
		// Properties
		XmlNodeType NodeType { get; }
		string LocalName { get; }
		List<IXmlNode> ChildNodes { get; }
		List<IXmlNode> Attributes { get; }
		IXmlNode ParentNode { get; }
		string Value { get; }
		string NamespaceUri { get; }
		object WrappedNode { get; }
	
		// Methods
		IXmlNode AppendChild(IXmlNode newChild);
	}
}
