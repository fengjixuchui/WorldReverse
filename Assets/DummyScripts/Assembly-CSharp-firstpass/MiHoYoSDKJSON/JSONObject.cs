/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYoSDKJSON
{
	public class JSONObject : JSONNode // TypeDefIndex: 8905
	{
		// Fields
		private Dictionary<string, JSONNode> m_Dict; // 0x10
		private bool inline; // 0x18
	
		// Properties
		public override bool Inline { /* [XID] */ /* 0x00000001898BACD0-0x00000001898BACF0 */ get => default; /* [XID] */ /* 0x00000001898C1FC0-0x00000001898C1FE0 */ set {} } // 0x00000001872662F0-0x0000000187266390 0x0000000187266710-0x00000001872667C0
		public override JSONNodeType Tag { /* [XID] */ /* 0x00000001897A4D70-0x00000001897A4D90 */ get => default; } // 0x0000000187266670-0x0000000187266710 
		public override bool IsObject { /* [XID] */ /* 0x00000001898D1080-0x00000001898D10A0 */ get => default; } // 0x0000000187266390-0x0000000187266430 
		public override JSONNode this[string aKey] { /* [XID] */ /* 0x00000001898E05A0-0x00000001898E05E0 */ /* [IDTag] */ /* 0x00000001898E05A0-0x00000001898E05E0 */ get => default; /* [XID] */ /* 0x00000001898EAFE0-0x00000001898EB020 */ /* [IDTag] */ /* 0x00000001898EAFE0-0x00000001898EB020 */ set {} } // 0x0000000187266550-0x0000000187266670 0x0000000187266970-0x0000000187266AF0
		public override JSONNode this[int aIndex] { /* [IDTag] */ /* 0x00000001898F57D0-0x00000001898F5810 */ /* [XID] */ /* 0x00000001898F57D0-0x00000001898F5810 */ get => default; /* [IDTag] */ /* 0x0000000189900230-0x0000000189900270 */ /* [XID] */ /* 0x0000000189900230-0x0000000189900270 */ set {} } // 0x0000000187266430-0x0000000187266550 0x00000001872667C0-0x0000000187266970
		public override int Count { /* [XID] */ /* 0x000000018990A700-0x000000018990A720 */ get => default; } // 0x0000000187266230-0x00000001872662F0 
		public override IEnumerable<JSONNode> Children { /* [XID] */ /* 0x0000000189947E50-0x0000000189947E70 */ get => default; } // 0x0000000187266110-0x0000000187266230 
	
		// Constructors
		public JSONObject() {} // 0x0000000187266020-0x0000000187266110
	
		// Methods
		// [XID] // 0x00000001898D87D0-0x00000001898D87F0
		public override Enumerator GetEnumerator() => default; // 0x0000000187264D00-0x0000000187264EE0
		// [XID] // 0x00000001899120B0-0x00000001899120D0
		public override void Add(string aKey, JSONNode aItem) {} // 0x0000000187264B00-0x0000000187264D00
		// [IDTag] // 0x0000000189919BA0-0x0000000189919BE0
		// [XID] // 0x0000000189919BA0-0x0000000189919BE0
		public override JSONNode Remove(string aKey) => default; // 0x00000001872650B0-0x00000001872651D0
		// [IDTag] // 0x0000000189924640-0x0000000189924680
		// [XID] // 0x0000000189924640-0x0000000189924680
		public override JSONNode Remove(int aIndex) => default; // 0x00000001872653B0-0x0000000187265510
		// [IDTag] // 0x000000018992EA30-0x000000018992EA70
		// [XID] // 0x000000018992EA30-0x000000018992EA70
		public override JSONNode Remove(JSONNode aNode) => default; // 0x00000001872651D0-0x00000001872653B0
		// [XID] // 0x0000000189938E40-0x0000000189938E60
		public override bool HasKey(string aKey) => default; // 0x0000000187264FE0-0x00000001872650B0
		// [XID] // 0x00000001899406D0-0x00000001899406F0
		public override JSONNode GetValueOrDefault(string aKey, JSONNode aDefault) => default; // 0x0000000187264EE0-0x0000000187264FE0
		// [XID] // 0x000000018994F420-0x000000018994F440
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x0000000187265C80-0x0000000187266020
	}
}
