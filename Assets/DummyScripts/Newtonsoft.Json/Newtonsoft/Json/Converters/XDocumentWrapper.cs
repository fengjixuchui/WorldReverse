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
	internal class XDocumentWrapper : XContainerWrapper, IXmlDocument // TypeDefIndex: 5500
	{
		// Properties
		private XDocument Document { get => default; } // 0x0000000185CDCFC0-0x0000000185CDD0B0 
		public override List<IXmlNode> ChildNodes { get => default; } // 0x0000000185CDCDB0-0x0000000185CDCEF0 
		public IXmlElement DocumentElement { get => default; } // 0x0000000185CDCEF0-0x0000000185CDCFC0 
	
		// Constructors
		public XDocumentWrapper() {} // Dummy constructor
		public XDocumentWrapper(XDocument document) {} // 0x0000000185CDCD30-0x0000000185CDCDB0
	
		// Methods
		public IXmlNode CreateComment(string text) => default; // 0x0000000185CDC590-0x0000000185CDC670
		public IXmlNode CreateTextNode(string text) => default; // 0x0000000185CDC9F0-0x0000000185CDCAD0
		public IXmlNode CreateCDataSection(string data) => default; // 0x0000000185CDC4B0-0x0000000185CDC590
		public IXmlNode CreateWhitespace(string text) => default; // 0x0000000185CDCAD0-0x0000000185CDCBB0
		public IXmlNode CreateSignificantWhitespace(string text) => default; // 0x0000000185CDC910-0x0000000185CDC9F0
		public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) => default; // 0x0000000185CDCBB0-0x0000000185CDCC70
		public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) => default; // 0x0000000185CDCC70-0x0000000185CDCD30
		public IXmlNode CreateProcessingInstruction(string target, string data) => default; // 0x0000000185CDC860-0x0000000185CDC910
		public IXmlElement CreateElement(string elementName) => default; // 0x0000000185CDC670-0x0000000185CDC760
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri) => default; // 0x0000000185CDC760-0x0000000185CDC860
		public IXmlNode CreateAttribute(string name, string value) => default; // 0x0000000185CDC320-0x0000000185CDC3E0
		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) => default; // 0x0000000185CDC3E0-0x0000000185CDC4B0
		public override IXmlNode AppendChild(IXmlNode newChild) => default; // 0x0000000185CDC1F0-0x0000000185CDC320
	}
}
