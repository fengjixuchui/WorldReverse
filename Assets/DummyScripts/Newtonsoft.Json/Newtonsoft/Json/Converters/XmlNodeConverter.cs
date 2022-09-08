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
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Converters
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public class XmlNodeConverter : JsonConverter // TypeDefIndex: 5508
	{
		// Properties
		public string DeserializeRootElementName { get; } // 0x0000000185CE6350-0x0000000185CE63B0 
		public bool WriteArrayAttribute { get; } // 0x0000000185CE6410-0x0000000185CE6470 
		public bool OmitRootObject { get; } // 0x0000000185CE63B0-0x0000000185CE6410 
	
		// Constructors
		public XmlNodeConverter() {} // 0x0000000185CE62B0-0x0000000185CE6350
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {} // 0x0000000185CE60C0-0x0000000185CE62B0
		private IXmlNode WrapXml(object value) => default; // 0x0000000185CE5EE0-0x0000000185CE60C0
		private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager) {} // 0x0000000185CE2D20-0x0000000185CE3190
		private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager) => default; // 0x0000000185CE4660-0x0000000185CE48C0
		private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager) => default; // 0x0000000185CE24F0-0x0000000185CE2950
		private bool IsArray(IXmlNode node) => default; // 0x0000000185CE2950-0x0000000185CE2C00
		private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) {} // 0x0000000185CE48C0-0x0000000185CE4D50
		private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) {} // 0x0000000185CE4D50-0x0000000185CE5D10
		private static bool AllSameName(IXmlNode node) => default; // 0x0000000185CDFF30-0x0000000185CE0140
		public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer) => default; // 0x0000000185CE4110-0x0000000185CE4660
		private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode) {} // 0x0000000185CE2060-0x0000000185CE24F0
		private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager) {} // 0x0000000185CE3D30-0x0000000185CE4110
		private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, Dictionary<string, string> attributeNameValues) {} // 0x0000000185CE0DB0-0x0000000185CE1320
		private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string attributeName, XmlNamespaceManager manager, string attributePrefix) {} // 0x0000000185CDFBA0-0x0000000185CDFDB0
		private string ConvertTokenToXmlValue(JsonReader reader) => default; // 0x0000000185CE0260-0x0000000185CE09C0
		private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager) {} // 0x0000000185CE3190-0x0000000185CE3510
		private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document) {} // 0x0000000185CDFDB0-0x0000000185CDFF30
		private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager) => default; // 0x0000000185CE3510-0x0000000185CE3D30
		private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName) {} // 0x0000000185CE14C0-0x0000000185CE1910
		private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode) {} // 0x0000000185CE09C0-0x0000000185CE0DB0
		private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager) => default; // 0x0000000185CE1320-0x0000000185CE14C0
		private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode) {} // 0x0000000185CE1910-0x0000000185CE2060
		private bool IsNamespaceAttribute(string attributeName, out string prefix) {
			prefix = default;
			return default;
		} // 0x0000000185CE2C00-0x0000000185CE2D20
		private bool ValueAttributes(List<IXmlNode> c) => default; // 0x0000000185CE5D10-0x0000000185CE5EE0
		public override bool CanConvert(System.Type valueType) => default; // 0x0000000185CE0140-0x0000000185CE0260
	}
}
