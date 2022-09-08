/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace behaviac
{
	public class BsonDeserizer // TypeDefIndex: 27438
	{
		// Fields
		private byte[] m_pBuffer; // 0x10
		private BinaryReader m_BinaryReader; // 0x18
	
		// Nested types
		public enum BsonTypes // TypeDefIndex: 27439
		{
			BT_None = 0,
			BT_Double = 1,
			BT_String = 2,
			BT_Object = 3,
			BT_Array = 4,
			BT_Binary = 5,
			BT_Undefined = 6,
			BT_ObjectId = 7,
			BT_Boolean = 8,
			BT_DateTime = 9,
			BT_Null = 10,
			BT_Regex = 11,
			BT_Reference = 12,
			BT_Code = 13,
			BT_Symbol = 14,
			BT_ScopedCode = 15,
			BT_Int32 = 16,
			BT_Timestamp = 17,
			BT_Int64 = 18,
			BT_Float = 19,
			BT_Element = 20,
			BT_Set = 21,
			BT_BehaviorElement = 22,
			BT_PropertiesElement = 23,
			BT_ParsElement = 24,
			BT_ParElement = 25,
			BT_NodeElement = 26,
			BT_AttachmentsElement = 27,
			BT_AttachmentElement = 28,
			BT_AgentsElement = 29,
			BT_AgentElement = 30,
			BT_PropertyElement = 31,
			BT_MethodsElement = 32,
			BT_MethodElement = 33,
			BT_Custom = 34,
			BT_ParameterElement = 35
		}
	
		// Constructors
		public BsonDeserizer() {} // 0x00000001860B6FC0-0x00000001860B7030
	
		// Methods
		public bool Init(byte[] pBuffer) => default; // 0x00000001860B6AB0-0x00000001860B6B90
		private int GetCurrentIndex() => default; // 0x00000001860B6A10-0x00000001860B6AB0
		public bool OpenDocument() => default; // 0x00000001860B6B90-0x00000001860B6C40
		public void CloseDocument(bool bEatEod) {} // 0x00000001860B6940-0x00000001860B6A10
		public BsonTypes ReadType() => default; // 0x00000001860B6EC0-0x00000001860B6F40
		public int ReadInt32() => default; // 0x00000001860B6D50-0x00000001860B6DD0
		public ushort ReadUInt16() => default; // 0x00000001860B6F40-0x00000001860B6FC0
		public float ReadFloat() => default; // 0x00000001860B6CC0-0x00000001860B6D50
		public bool ReadBool() => default; // 0x00000001860B6C40-0x00000001860B6CC0
		public string ReadString() => default; // 0x00000001860B6DD0-0x00000001860B6EC0
		public bool eod() => default; // 0x00000001860B7030-0x00000001860B70D0
	}
}
