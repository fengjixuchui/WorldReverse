/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Converters
{
	internal interface IXmlDocument : IXmlNode // TypeDefIndex: 5493
	{
		// Properties
		IXmlElement DocumentElement { get; }
	
		// Methods
		IXmlNode CreateComment(string text);
		IXmlNode CreateTextNode(string text);
		IXmlNode CreateCDataSection(string data);
		IXmlNode CreateWhitespace(string text);
		IXmlNode CreateSignificantWhitespace(string text);
		IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);
		IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);
		IXmlNode CreateProcessingInstruction(string target, string data);
		IXmlElement CreateElement(string elementName);
		IXmlElement CreateElement(string qualifiedName, string namespaceUri);
		IXmlNode CreateAttribute(string name, string value);
		IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);
	}
}
