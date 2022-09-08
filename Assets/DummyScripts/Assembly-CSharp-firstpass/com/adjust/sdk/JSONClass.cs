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
	public class JSONClass : JSONNode, IEnumerable // TypeDefIndex: 6713
	{
		// Fields
		private Dictionary<string, JSONNode> m_Dict; // 0x10
	
		// Properties
		public override JSONNode this[string aKey] { /* [XID] */ /* 0x00000001898BEF00-0x00000001898BEF40 */ /* [IDTag] */ /* 0x00000001898BEF00-0x00000001898BEF40 */ get => default; /* [IDTag] */ /* 0x00000001898C99F0-0x00000001898C9A30 */ /* [XID] */ /* 0x00000001898C99F0-0x00000001898C9A30 */ set {} } // 0x000000018669F0F0-0x000000018669F210 0x000000018669F210-0x000000018669F330
		public override JSONNode this[int aIndex] { /* [XID] */ /* 0x00000001898D4100-0x00000001898D4140 */ /* [IDTag] */ /* 0x00000001898D4100-0x00000001898D4140 */ get => default; /* [IDTag] */ /* 0x00000001898DF050-0x00000001898DF090 */ /* [XID] */ /* 0x00000001898DF050-0x00000001898DF090 */ set {} } // 0x000000018669EFD0-0x000000018669F0F0 0x000000018669F330-0x000000018669F480
		public override int Count { /* [XID] */ /* 0x00000001898E9BC0-0x00000001898E9BE0 */ get => default; } // 0x000000018669EF10-0x000000018669EFD0 
		public override IEnumerable<JSONNode> Childs { /* [XID] */ /* 0x0000000189B6AA50-0x0000000189B6AA70 */ get => default; } // 0x000000018669EE00-0x000000018669EF10 
	
		// Constructors
		public JSONClass() {} // 0x000000018669ED30-0x000000018669EE00
	
		// Methods
		// [XID] // 0x00000001898F1140-0x00000001898F1160
		public override void Add(string aKey, JSONNode aItem) {} // 0x000000018669D520-0x000000018669D6F0
		// [IDTag] // 0x00000001898F8A70-0x00000001898F8AB0
		// [XID] // 0x00000001898F8A70-0x00000001898F8AB0
		public override JSONNode Remove(string aKey) => default; // 0x000000018669DB40-0x000000018669DC60
		// [IDTag] // 0x0000000189903190-0x00000001899031D0
		// [XID] // 0x0000000189903190-0x00000001899031D0
		public override JSONNode Remove(int aIndex) => default; // 0x000000018669D800-0x000000018669D960
		// [IDTag] // 0x000000018990D9C0-0x000000018990DA00
		// [XID] // 0x000000018990D9C0-0x000000018990DA00
		public override JSONNode Remove(JSONNode aNode) => default; // 0x000000018669D960-0x000000018669DB40
		[DebuggerHidden] // 0x000000018991F8B0-0x000000018991F8E0
		// [XID] // 0x000000018991F8B0-0x000000018991F8E0
		public IEnumerator GetEnumerator() => default; // 0x000000018669D6F0-0x000000018669D800
		// [IDTag] // 0x000000018992A2E0-0x000000018992A320
		// [XID] // 0x000000018992A2E0-0x000000018992A320
		public override string ToString() => default; // 0x000000018669DEC0-0x000000018669E290
		// [IDTag] // 0x00000001899347B0-0x00000001899347F0
		// [XID] // 0x00000001899347B0-0x00000001899347F0
		public override string ToString(string aPrefix) => default; // 0x000000018669E290-0x000000018669E6C0
		// [XID] // 0x000000018993F0C0-0x000000018993F0E0
		public override void Serialize(BinaryWriter aWriter) {} // 0x000000018669DC60-0x000000018669DEC0
	}
}
