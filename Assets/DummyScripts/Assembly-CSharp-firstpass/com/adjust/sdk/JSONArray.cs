/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace com.adjust.sdk
{
	public class JSONArray : JSONNode, IEnumerable // TypeDefIndex: 6710
	{
		// Fields
		private List<JSONNode> m_List; // 0x10
	
		// Properties
		public override JSONNode this[int aIndex] { /* [IDTag] */ /* 0x00000001897A0DB0-0x00000001897A0DF0 */ /* [XID] */ /* 0x00000001897A0DB0-0x00000001897A0DF0 */ get => default; /* [XID] */ /* 0x00000001897AB180-0x00000001897AB1C0 */ /* [IDTag] */ /* 0x00000001897AB180-0x00000001897AB1C0 */ set {} } // 0x000000018669D140-0x000000018669D250 0x000000018669D320-0x000000018669D440
		public override JSONNode this[string aKey] { /* [IDTag] */ /* 0x00000001897B6670-0x00000001897B66B0 */ /* [XID] */ /* 0x00000001897B6670-0x00000001897B66B0 */ get => default; /* [XID] */ /* 0x00000001897C11E0-0x00000001897C1220 */ /* [IDTag] */ /* 0x00000001897C11E0-0x00000001897C1220 */ set {} } // 0x000000018669D250-0x000000018669D320 0x000000018669D440-0x000000018669D520
		public override int Count { /* [XID] */ /* 0x00000001897CB6E0-0x00000001897CB700 */ get => default; } // 0x000000018669D080-0x000000018669D140 
		public override IEnumerable<JSONNode> Childs { /* [XID] */ /* 0x0000000189A30FA0-0x0000000189A30FC0 */ get => default; } // 0x000000018669CF70-0x000000018669D080 
	
		// Constructors
		public JSONArray() {} // 0x000000018669CEA0-0x000000018669CF70
	
		// Methods
		// [XID] // 0x0000000189A1AED0-0x0000000189A1AEF0
		public override void Add(string aKey, JSONNode aItem) {} // 0x000000018669BDC0-0x000000018669BEA0
		// [IDTag] // 0x00000001897DABF0-0x00000001897DAC30
		// [XID] // 0x00000001897DABF0-0x00000001897DAC30
		public override JSONNode Remove(int aIndex) => default; // 0x000000018669BFB0-0x000000018669C0D0
		// [IDTag] // 0x00000001897E5010-0x00000001897E5050
		// [XID] // 0x00000001897E5010-0x00000001897E5050
		public override JSONNode Remove(JSONNode aNode) => default; // 0x000000018669C0D0-0x000000018669C1A0
		[DebuggerHidden] // 0x00000001897F72C0-0x00000001897F72F0
		// [XID] // 0x00000001897F72C0-0x00000001897F72F0
		public IEnumerator GetEnumerator() => default; // 0x000000018669BEA0-0x000000018669BFB0
		// [IDTag] // 0x0000000189801C40-0x0000000189801C80
		// [XID] // 0x0000000189801C40-0x0000000189801C80
		public override string ToString() => default; // 0x000000018669C330-0x000000018669C5C0
		// [IDTag] // 0x000000018980BF00-0x000000018980BF40
		// [XID] // 0x000000018980BF00-0x000000018980BF40
		public override string ToString(string aPrefix) => default; // 0x000000018669C5C0-0x000000018669C8B0
		// [XID] // 0x0000000189A56660-0x0000000189A56680
		public override void Serialize(BinaryWriter aWriter) {} // 0x000000018669C1A0-0x000000018669C330
	}
}
