/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYoSDKJSON
{
	internal class JSONLazyCreator : JSONNode // TypeDefIndex: 8912
	{
		// Fields
		private JSONNode m_Node; // 0x10
		private string m_Key; // 0x18
	
		// Properties
		public override JSONNodeType Tag { /* [XID] */ /* 0x0000000189B08480-0x0000000189B084A0 */ get => default; } // 0x000000018725DB30-0x000000018725DBD0 
		public override JSONNode this[int aIndex] { /* [XID] */ /* 0x0000000189B16EE0-0x0000000189B16F20 */ /* [IDTag] */ /* 0x0000000189B16EE0-0x0000000189B16F20 */ get => default; /* [XID] */ /* 0x0000000189B21580-0x0000000189B215C0 */ /* [IDTag] */ /* 0x0000000189B21580-0x0000000189B215C0 */ set {} } // 0x000000018725D980-0x000000018725DA50 0x000000018725E270-0x000000018725E380
		public override JSONNode this[string aKey] { /* [XID] */ /* 0x0000000189B2BC00-0x0000000189B2BC40 */ /* [IDTag] */ /* 0x0000000189B2BC00-0x0000000189B2BC40 */ get => default; /* [XID] */ /* 0x0000000189B36200-0x0000000189B36240 */ /* [IDTag] */ /* 0x0000000189B36200-0x0000000189B36240 */ set {} } // 0x000000018725DA50-0x000000018725DB30 0x000000018725E380-0x000000018725E4A0
		public override int AsInt { /* [XID] */ /* 0x0000000189B73910-0x0000000189B73930 */ get => default; /* [XID] */ /* 0x00000001896FE2D0-0x00000001896FE2F0 */ set {} } // 0x000000018725D690-0x000000018725D770 0x000000018725E010-0x000000018725E100
		public override float AsFloat { /* [XID] */ /* 0x00000001898AD490-0x00000001898AD4B0 */ get => default; /* [XID] */ /* 0x0000000189B89F20-0x0000000189B89F40 */ set {} } // 0x000000018725D5B0-0x000000018725D690 0x000000018725DF20-0x000000018725E010
		public override double AsDouble { /* [XID] */ /* 0x0000000189B91590-0x0000000189B915B0 */ get => default; /* [XID] */ /* 0x00000001896E0790-0x00000001896E07B0 */ set {} } // 0x000000018725D4D0-0x000000018725D5B0 0x000000018725DE40-0x000000018725DF20
		public override long AsLong { /* [XID] */ /* 0x00000001896D8ED0-0x00000001896D8EF0 */ get => default; /* [XID] */ /* 0x00000001898DBA10-0x00000001898DBA30 */ set {} } // 0x000000018725D770-0x000000018725D8B0 0x000000018725E100-0x000000018725E270
		public override bool AsBool { /* [XID] */ /* 0x0000000189BAE6F0-0x0000000189BAE710 */ get => default; /* [XID] */ /* 0x00000001899B64F0-0x00000001899B6510 */ set {} } // 0x000000018725D3F0-0x000000018725D4D0 0x000000018725DD60-0x000000018725DE40
		public override JSONArray AsArray { /* [XID] */ /* 0x0000000189BBD580-0x0000000189BBD5A0 */ get => default; } // 0x000000018725D320-0x000000018725D3F0 
		public override JSONObject AsObject { /* [XID] */ /* 0x00000001898FA170-0x00000001898FA190 */ get => default; } // 0x000000018725D8B0-0x000000018725D980 
	
		// Constructors
		public JSONLazyCreator() {} // Dummy constructor
		public JSONLazyCreator(JSONNode aNode) {} // 0x000000018725D230-0x000000018725D320
		public JSONLazyCreator(JSONNode aNode, string aKey) {} // 0x000000018725D150-0x000000018725D230
	
		// Methods
		// [XID] // 0x0000000189B0FD80-0x0000000189B0FDA0
		public override Enumerator GetEnumerator() => default; // 0x000000018725C4B0-0x000000018725C620
		private T Set<T>(T aVal)
			where T : JSONNode => default;
		// [IDTag] // 0x0000000189B40CC0-0x0000000189B40D00
		// [XID] // 0x0000000189B40CC0-0x0000000189B40D00
		public override void Add(JSONNode aItem) {} // 0x000000018725C2E0-0x000000018725C3E0
		// [IDTag] // 0x0000000189B4B380-0x0000000189B4B3C0
		// [XID] // 0x0000000189B4B380-0x0000000189B4B3C0
		public override void Add(string aKey, JSONNode aItem) {} // 0x000000018725C1C0-0x000000018725C2E0
		// [XID] // 0x0000000189B55B40-0x0000000189B55B60
		public static bool operator ==(JSONLazyCreator a, object b) => default; // 0x000000018725DBD0-0x000000018725DCA0
		// [XID] // 0x0000000189624AF0-0x0000000189624B10
		public static bool operator !=(JSONLazyCreator a, object b) => default; // 0x000000018725DCA0-0x000000018725DD60
		// [XID] // 0x00000001898C52E0-0x00000001898C5300
		public override bool Equals(object obj) => default; // 0x000000018725C3E0-0x000000018725C4B0
		// [XID] // 0x0000000189B6C0F0-0x0000000189B6C110
		public override int GetHashCode() => default; // 0x000000018725C620-0x000000018725C6C0
		// [XID] // 0x0000000189963240-0x0000000189963260
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x000000018725D050-0x000000018725D150
	}
}
