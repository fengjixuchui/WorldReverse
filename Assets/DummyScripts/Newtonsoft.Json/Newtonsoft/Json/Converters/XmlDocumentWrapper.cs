/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Xml;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Converters
{
	internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument // TypeDefIndex: 5488
	{
		// Fields
		private readonly XmlDocument _document; // 0x28
	
		// Properties
		public IXmlElement DocumentElement { get => default; } // 0x0000000185CDF780-0x0000000185CDF840 
	
		// Constructors
		public XmlDocumentWrapper() {} // Dummy constructor
		public XmlDocumentWrapper(XmlDocument document) {} // 0x0000000185CDF6C0-0x0000000185CDF780
	
		// Methods
		public IXmlNode CreateComment(string data) => default; // 0x0000000185CDEF10-0x0000000185CDF000
		public IXmlNode CreateTextNode(string text) => default; // 0x0000000185CDF350-0x0000000185CDF440
		public IXmlNode CreateCDataSection(string data) => default; // 0x0000000185CDEE20-0x0000000185CDEF10
		public IXmlNode CreateWhitespace(string text) => default; // 0x0000000185CDF440-0x0000000185CDF530
		public IXmlNode CreateSignificantWhitespace(string text) => default; // 0x0000000185CDF260-0x0000000185CDF350
		public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) => default; // 0x0000000185CDF530-0x0000000185CDF5F0
		public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) => default; // 0x0000000185CDF5F0-0x0000000185CDF6C0
		public IXmlNode CreateProcessingInstruction(string target, string data) => default; // 0x0000000185CDF170-0x0000000185CDF260
		public IXmlElement CreateElement(string elementName) => default; // 0x0000000185CDF0C0-0x0000000185CDF170
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri) => default; // 0x0000000185CDF000-0x0000000185CDF0C0
		public IXmlNode CreateAttribute(string name, string value) => default; // 0x0000000185CDEC20-0x0000000185CDED20
		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) => default; // 0x0000000185CDED20-0x0000000185CDEE20
	}
}
