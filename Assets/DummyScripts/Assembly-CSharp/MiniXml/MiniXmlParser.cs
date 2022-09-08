/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MiniXml
{
	internal class MiniXmlParser // TypeDefIndex: 27372
	{
		// Fields
		private IXmlHandler xmlHandler_; // 0x10
		private TextReader textReader_; // 0x18
		private Stack elementNames_; // 0x20
		private Stack xmlSpaces_; // 0x28
		private string xmlBlank_; // 0x30
		private StringBuilder stringBuffer_; // 0x38
		private char[] nameBufferArray_; // 0x40
		private bool isBlank_; // 0x48
		private AttributeListImpl _attributes; // 0x50
		private int line; // 0x58
		private int column; // 0x5C
		private bool resetCol_; // 0x60
	
		// Nested types
		public interface IXmlHandler // TypeDefIndex: 27373
		{
			// Methods
			void OnStartParsing(MiniXmlParser parser);
			void OnEndParsing(MiniXmlParser parser);
			void OnStart(string szName, IAttributeList attrsList);
			void OnEnd(string szName);
			void OnProcess(string szName, string content);
			void OnChars(string content);
			void OnIgnorableSpaces(string content);
		}
	
		public interface IAttributeList // TypeDefIndex: 27374
		{
			// Properties
			int AttrLength { get; }
			bool IsEmpty { get; }
			string[] Names { get; }
			string[] Values { get; }
	
			// Methods
			string GetAttrName(int i);
			string GetAttrValue(int i);
			string GetAttrValue(string name);
		}
	
		private class AttributeListImpl : IAttributeList // TypeDefIndex: 27375
		{
			// Fields
			private ArrayList attrNames; // 0x10
			private ArrayList attrValues; // 0x18
	
			// Properties
			public int AttrLength { get => default; } // 0x000000018416D3E0-0x000000018416D460 
			public bool IsEmpty { get => default; } // 0x000000018416D460-0x000000018416D4E0 
			public string[] Names { get => default; } // 0x000000018416D4E0-0x000000018416D5E0 
			public string[] Values { get => default; } // 0x000000018416D5E0-0x000000018416D6E0 
	
			// Constructors
			public AttributeListImpl() {} // 0x000000018416D330-0x000000018416D3E0
	
			// Methods
			public string GetAttrName(int i) => default; // 0x000000018416D050-0x000000018416D100
			public string GetAttrValue(int i) => default; // 0x000000018416D100-0x000000018416D1B0
			public string GetAttrValue(string name) => default; // 0x000000018416D1B0-0x000000018416D330
			internal void Clear() {} // 0x000000018416CFB0-0x000000018416D050
			internal void Add(string name, string value) {} // 0x000000018416CEF0-0x000000018416CFB0
		}
	
		// Constructors
		public MiniXmlParser() {} // 0x00000001841910B0-0x00000001841911C0
	
		// Methods
		private static bool IsUnicodeSep(char c, bool start) => default; // 0x000000018418F6F0-0x000000018418F7D0
		private Exception ErrorMsg_(string msg) => default; // 0x000000018418F100-0x000000018418F1A0
		private Exception UnexpectedEndException_() => default; // 0x0000000184190F70-0x00000001841910B0
		private bool IsNameChararcter_(char c, bool start) => default; // 0x000000018418F610-0x000000018418F6F0
		private bool IsBlank_(int c) => default; // 0x000000018418F590-0x000000018418F610
		public void SkipBlank() {} // 0x0000000184190DD0-0x0000000184190E40
		public void SkipBlanks_(bool expected) {} // 0x0000000184190E40-0x0000000184190F70
		private void HandleBlank_() {} // 0x000000018418F2D0-0x000000018418F470
		private int ReadNext_() => default; // 0x0000000184190910-0x00000001841909C0
		private int PeekNext_() => default; // 0x000000018418F9C0-0x000000018418FA40
		public void Expect(int c) {} // 0x000000018418F1A0-0x000000018418F2D0
		public string ReadName() => default; // 0x0000000184190710-0x0000000184190910
		public void Parse(TextReader input, IXmlHandler handler) {} // 0x000000018418F7D0-0x000000018418F9C0
		private string ReadUntil_(char until, bool handleReferences) => default; // 0x0000000184190C40-0x0000000184190DD0
		private void Cleanup() {} // 0x000000018418F010-0x000000018418F100
		public void ReadAll() {} // 0x000000018418FA40-0x0000000184190110
		private void ReadChars_() {} // 0x0000000184190520-0x0000000184190640
		private void ReadRef_() {} // 0x00000001841909C0-0x0000000184190C40
		private void HandleBufferContent_() {} // 0x000000018418F470-0x000000018418F590
		private int ReadCharRef_() => default; // 0x0000000184190420-0x0000000184190520
		private void ReadAttr_(AttributeListImpl a) {} // 0x0000000184190110-0x0000000184190290
		private void ReadComment_() {} // 0x0000000184190640-0x0000000184190710
		private void ReadCDATA_() {} // 0x0000000184190290-0x0000000184190420
	}
}
