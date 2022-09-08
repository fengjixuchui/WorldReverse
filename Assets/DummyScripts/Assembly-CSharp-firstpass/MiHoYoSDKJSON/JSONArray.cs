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
	public class JSONArray : JSONNode // TypeDefIndex: 8903
	{
		// Fields
		private List<JSONNode> m_List; // 0x10
		private bool inline; // 0x18
	
		// Properties
		public override bool Inline { /* [XID] */ /* 0x0000000189A78C00-0x0000000189A78C20 */ get => default; /* [XID] */ /* 0x0000000189A87DA0-0x0000000189A87DC0 */ set {} } // 0x000000018725AD60-0x000000018725AE00 0x000000018725B120-0x000000018725B1D0
		public override JSONNodeType Tag { /* [XID] */ /* 0x00000001897E9810-0x00000001897E9830 */ get => default; } // 0x000000018725B080-0x000000018725B120 
		public override bool IsArray { /* [XID] */ /* 0x00000001897F1460-0x00000001897F1480 */ get => default; } // 0x000000018725AE00-0x000000018725AEA0 
		public override JSONNode this[int aIndex] { /* [XID] */ /* 0x0000000189800260-0x00000001898002A0 */ /* [IDTag] */ /* 0x0000000189800260-0x00000001898002A0 */ get => default; /* [IDTag] */ /* 0x000000018980A890-0x000000018980A8D0 */ /* [XID] */ /* 0x000000018980A890-0x000000018980A8D0 */ set {} } // 0x000000018725AF70-0x000000018725B080 0x000000018725B1D0-0x000000018725B350
		public override JSONNode this[string aKey] { /* [IDTag] */ /* 0x0000000189814CF0-0x0000000189814D30 */ /* [XID] */ /* 0x0000000189814CF0-0x0000000189814D30 */ get => default; /* [IDTag] */ /* 0x0000000189737B40-0x0000000189737B80 */ /* [XID] */ /* 0x0000000189737B40-0x0000000189737B80 */ set {} } // 0x000000018725AEA0-0x000000018725AF70 0x000000018725B350-0x000000018725B490
		public override int Count { /* [XID] */ /* 0x0000000189829DB0-0x0000000189829DD0 */ get => default; } // 0x000000018725ACA0-0x000000018725AD60 
		public override IEnumerable<JSONNode> Children { /* [XID] */ /* 0x000000018976CE00-0x000000018976CE20 */ get => default; } // 0x000000018725AB80-0x000000018725ACA0 
	
		// Constructors
		public JSONArray() {} // 0x000000018725AA90-0x000000018725AB80
	
		// Methods
		// [XID] // 0x00000001897F8BB0-0x00000001897F8BD0
		public override Enumerator GetEnumerator() => default; // 0x0000000187259EC0-0x000000018725A0B0
		// [XID] // 0x0000000189831310-0x0000000189831330
		public override void Add(string aKey, JSONNode aItem) {} // 0x0000000187259D80-0x0000000187259EC0
		// [IDTag] // 0x0000000189838B80-0x0000000189838BC0
		// [XID] // 0x0000000189838B80-0x0000000189838BC0
		public override JSONNode Remove(int aIndex) => default; // 0x000000018725A180-0x000000018725A2A0
		// [IDTag] // 0x0000000189843320-0x0000000189843360
		// [XID] // 0x0000000189843320-0x0000000189843360
		public override JSONNode Remove(JSONNode aNode) => default; // 0x000000018725A0B0-0x000000018725A180
		// [XID] // 0x0000000189BCC2E0-0x0000000189BCC300
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) {} // 0x000000018725A880-0x000000018725AA90
	}
}
