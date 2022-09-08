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
	public class JSONArray : JSONNode, IEnumerable // TypeDefIndex: 10044
	{
		// Fields
		private List<JSONNode> m_List; // 0x18
	
		// Properties
		public override JSONNode this[int aIndex] { /* [IDTag] */ /* 0x000000018961CC00-0x000000018961CC40 */ /* [XID] */ /* 0x000000018961CC00-0x000000018961CC40 */ get => default; /* [XID] */ /* 0x0000000189626F90-0x0000000189626FD0 */ /* [IDTag] */ /* 0x0000000189626F90-0x0000000189626FD0 */ set {} } // 0x000000018673CA80-0x000000018673CB90 0x000000018673CB90-0x000000018673CCB0
		public override JSONNode this[string aKey] { /* [XID] */ /* 0x0000000189631960-0x00000001896319A0 */ /* [IDTag] */ /* 0x0000000189631960-0x00000001896319A0 */ get => default; /* [XID] */ /* 0x000000018963C2A0-0x000000018963C2E0 */ /* [IDTag] */ /* 0x000000018963C2A0-0x000000018963C2E0 */ set {} } // 0x000000018673C9B0-0x000000018673CA80 0x000000018673CCB0-0x000000018673CD90
		public override int Count { /* [XID] */ /* 0x00000001896469A0-0x00000001896469C0 */ get => default; } // 0x000000018673C8F0-0x000000018673C9B0 
		public override IEnumerable<JSONNode> Childs { /* [XID] */ /* 0x000000018983FE80-0x000000018983FEA0 */ get => default; } // 0x000000018673C7D0-0x000000018673C8F0 
	
		// Constructors
		public JSONArray() {} // 0x000000018673C700-0x000000018673C7D0
	
		// Methods
		// [XID] // 0x000000018964E240-0x000000018964E260
		public override void Add(string aKey, JSONNode aItem) {} // 0x000000018673B620-0x000000018673B700
		// [IDTag] // 0x0000000189655A60-0x0000000189655AA0
		// [XID] // 0x0000000189655A60-0x0000000189655AA0
		public override JSONNode Remove(int aIndex) => default; // 0x000000018673B8E0-0x000000018673BA00
		// [IDTag] // 0x000000018965FE80-0x000000018965FEC0
		// [XID] // 0x000000018965FE80-0x000000018965FEC0
		public override JSONNode Remove(JSONNode aNode) => default; // 0x000000018673B810-0x000000018673B8E0
		[DebuggerHidden] // 0x0000000189672630-0x0000000189672670
		// [XID] // 0x0000000189672630-0x0000000189672670
		public IEnumerator GetEnumerator() => default; // 0x000000018673B700-0x000000018673B810
		// [IDTag] // 0x000000018967CCC0-0x000000018967CD00
		// [XID] // 0x000000018967CCC0-0x000000018967CD00
		public override string ToString() => default; // 0x000000018673BE80-0x000000018673C110
		// [IDTag] // 0x00000001896873A0-0x00000001896873E0
		// [XID] // 0x00000001896873A0-0x00000001896873E0
		public override string ToString(string aPrefix) => default; // 0x000000018673BB90-0x000000018673BE80
		// [XID] // 0x0000000189AAF110-0x0000000189AAF130
		public override void Serialize(BinaryWriter aWriter) {} // 0x000000018673BA00-0x000000018673BB90
	}
}
