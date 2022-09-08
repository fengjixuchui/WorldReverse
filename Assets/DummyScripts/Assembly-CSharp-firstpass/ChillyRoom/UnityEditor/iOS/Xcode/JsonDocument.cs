/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace ChillyRoom.UnityEditor.iOS.Xcode
{
	internal class JsonDocument // TypeDefIndex: 10362
	{
		// Fields
		public JsonElementDict root; // 0x10
		public string indentString; // 0x18
	
		// Constructors
		public JsonDocument() {} // 0x00000001864DBAC0-0x00000001864DBB60
	
		// Methods
		// [XID] // 0x00000001896BF700-0x00000001896BF720
		private void AppendIndent(StringBuilder sb, int indent) {} // 0x00000001864DAA90-0x00000001864DAB80
		// [XID] // 0x0000000189B5D2F0-0x0000000189B5D310
		private void WriteString(StringBuilder sb, string str) {} // 0x00000001864DB720-0x00000001864DB820
		// [XID] // 0x00000001896CE740-0x00000001896CE760
		private void WriteBoolean(StringBuilder sb, bool value) {} // 0x00000001864DAF50-0x00000001864DB040
		// [XID] // 0x0000000189B737B0-0x0000000189B737D0
		private void WriteInteger(StringBuilder sb, int value) {} // 0x00000001864DB640-0x00000001864DB720
		// [XID] // 0x00000001898ADA10-0x00000001898ADA30
		private void WriteDictKeyValue(StringBuilder sb, string key, JsonElement value, int indent) {} // 0x00000001864DB040-0x00000001864DB330
		// [XID] // 0x00000001896E49F0-0x00000001896E4A10
		private void WriteDict(StringBuilder sb, JsonElementDict el, int indent) {} // 0x00000001864DB330-0x00000001864DB640
		// [XID] // 0x0000000189B7D160-0x0000000189B7D180
		private void WriteArray(StringBuilder sb, JsonElementArray el, int indent) {} // 0x00000001864DAB80-0x00000001864DAF50
		// [XID] // 0x00000001896F3590-0x00000001896F35B0
		public void WriteToFile(string path) {} // 0x00000001864DB820-0x00000001864DB8E0
		// [XID] // 0x000000018963AA50-0x000000018963AA70
		public void WriteToStream(TextWriter tw) {} // 0x00000001864DB8E0-0x00000001864DB9C0
		// [XID] // 0x0000000189B28BE0-0x0000000189B28C00
		public string WriteToString() => default; // 0x00000001864DB9C0-0x00000001864DBAC0
	}
}
