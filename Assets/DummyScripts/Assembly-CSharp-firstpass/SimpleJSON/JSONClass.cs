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

namespace SimpleJSON
{
	public class JSONClass : JSONNode, IEnumerable // TypeDefIndex: 10047
	{
		// Fields
		private Dictionary<string, JSONNode> m_Dict; // 0x18
	
		// Properties
		public override JSONNode this[string aKey] { /* [IDTag] */ /* 0x000000018973ACD0-0x000000018973AD10 */ /* [XID] */ /* 0x000000018973ACD0-0x000000018973AD10 */ get => default; /* [IDTag] */ /* 0x00000001897456B0-0x00000001897456F0 */ /* [XID] */ /* 0x00000001897456B0-0x00000001897456F0 */ set {} } // 0x000000018673EB40-0x000000018673EC60 0x000000018673ED80-0x000000018673EEA0
		public override JSONNode this[int aIndex] { /* [IDTag] */ /* 0x000000018974FE30-0x000000018974FE70 */ /* [XID] */ /* 0x000000018974FE30-0x000000018974FE70 */ get => default; /* [XID] */ /* 0x000000018975A040-0x000000018975A080 */ /* [IDTag] */ /* 0x000000018975A040-0x000000018975A080 */ set {} } // 0x000000018673EA20-0x000000018673EB40 0x000000018673EEA0-0x000000018673EFF0
		public override int Count { /* [XID] */ /* 0x0000000189764960-0x0000000189764980 */ get => default; } // 0x000000018673E960-0x000000018673EA20 
		public override IEnumerable<string> Keys { /* [XID] */ /* 0x000000018979A4B0-0x000000018979A4D0 */ get => default; } // 0x000000018673EC60-0x000000018673ED80 
		public override IEnumerable<JSONNode> Childs { /* [XID] */ /* 0x0000000189B2EBF0-0x0000000189B2EC10 */ get => default; } // 0x000000018673E840-0x000000018673E960 
	
		// Constructors
		public JSONClass() {} // 0x000000018673E770-0x000000018673E840
	
		// Methods
		// [XID] // 0x000000018976C3E0-0x000000018976C400
		public override bool ContainsKey(string aKey) => default; // 0x000000018673CF60-0x000000018673D030
		// [XID] // 0x0000000189773880-0x00000001897738A0
		public override void Add(string aKey, JSONNode aItem) {} // 0x000000018673CD90-0x000000018673CF60
		// [IDTag] // 0x000000018977B070-0x000000018977B0B0
		// [XID] // 0x000000018977B070-0x000000018977B0B0
		public override JSONNode Remove(string aKey) => default; // 0x000000018673D480-0x000000018673D5A0
		// [IDTag] // 0x0000000189785940-0x0000000189785980
		// [XID] // 0x0000000189785940-0x0000000189785980
		public override JSONNode Remove(int aIndex) => default; // 0x000000018673D140-0x000000018673D2A0
		// [IDTag] // 0x000000018978FF20-0x000000018978FF60
		// [XID] // 0x000000018978FF20-0x000000018978FF60
		public override JSONNode Remove(JSONNode aNode) => default; // 0x000000018673D2A0-0x000000018673D480
		[DebuggerHidden] // 0x00000001897A9A80-0x00000001897A9AC0
		// [XID] // 0x00000001897A9A80-0x00000001897A9AC0
		public IEnumerator GetEnumerator() => default; // 0x000000018673D030-0x000000018673D140
		// [IDTag] // 0x00000001897B49A0-0x00000001897B49E0
		// [XID] // 0x00000001897B49A0-0x00000001897B49E0
		public override string ToString() => default; // 0x000000018673DC40-0x000000018673E010
		// [IDTag] // 0x00000001897BFA10-0x00000001897BFA50
		// [XID] // 0x00000001897BFA10-0x00000001897BFA50
		public override string ToString(string aPrefix) => default; // 0x000000018673D800-0x000000018673DC40
		// [XID] // 0x00000001897C9DA0-0x00000001897C9DC0
		public override void Serialize(BinaryWriter aWriter) {} // 0x000000018673D5A0-0x000000018673D800
	}
}
