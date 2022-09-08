/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MiniXml
{
	internal sealed class SecurityParser : MiniXmlParser, IXmlHandler // TypeDefIndex: 27376
	{
		// Fields
		private SecurityElement root; // 0x68
		private SecurityElement current; // 0x70
		private Stack stack; // 0x78
	
		// Constructors
		public SecurityParser() {} // 0x0000000184191CA0-0x0000000184191D30
	
		// Methods
		public void LoadXml(string xml) {} // 0x0000000184191720-0x00000001841917F0
		public SecurityElement ToXml() => default; // 0x0000000184191C40-0x0000000184191CA0
		public void OnStartParsing(MiniXmlParser parser) {} // 0x0000000184191A00-0x0000000184191A50
		public void OnProcess(string name, string text) {} // 0x00000001841919B0-0x0000000184191A00
		public void OnIgnorableSpaces(string s) {} // 0x0000000184191960-0x00000001841919B0
		public void OnStart(string name, IAttributeList attrs) {} // 0x0000000184191A50-0x0000000184191C40
		public void OnEnd(string name) {} // 0x00000001841918C0-0x0000000184191960
		public void OnChars(string ch) {} // 0x00000001841917F0-0x0000000184191870
		public void OnEndParsing(MiniXmlParser parser) {} // 0x0000000184191870-0x00000001841918C0
	}
}
