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
using System.Xml.Linq;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Converters
{
	internal class XElementWrapper : XContainerWrapper, IXmlElement // TypeDefIndex: 5507
	{
		// Fields
		private List<IXmlNode> _attributes; // 0x20
	
		// Properties
		private XElement Element { get => default; } // 0x0000000185CDD960-0x0000000185CDDA50 
		public override List<IXmlNode> Attributes { get => default; } // 0x0000000185CDD3B0-0x0000000185CDD960 
		public override string Value { get => default; } // 0x0000000185CDDC10-0x0000000185CDDC90 
		public override string LocalName { get => default; } // 0x0000000185CDDAD0-0x0000000185CDDB70 
		public override string NamespaceUri { get => default; } // 0x0000000185CDDB70-0x0000000185CDDC10 
		public bool IsEmpty { get => default; } // 0x0000000185CDDA50-0x0000000185CDDAD0 
	
		// Constructors
		public XElementWrapper() {} // Dummy constructor
		public XElementWrapper(XElement element) {} // 0x0000000185CDD330-0x0000000185CDD3B0
	
		// Methods
		public void SetAttributeNode(IXmlNode attribute) {} // 0x0000000185CDD1F0-0x0000000185CDD330
		public override IXmlNode AppendChild(IXmlNode newChild) => default; // 0x0000000185CDD0B0-0x0000000185CDD130
		public string GetPrefixOfNamespace(string namespaceUri) => default; // 0x0000000185CDD130-0x0000000185CDD1F0
	}
}
