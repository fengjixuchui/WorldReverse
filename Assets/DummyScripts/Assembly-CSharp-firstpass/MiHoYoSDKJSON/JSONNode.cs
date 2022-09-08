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
	public abstract class JSONNode // TypeDefIndex: 8895
	{
		// Fields
		public static bool forceASCII; // 0x00
		public static bool longAsString; // 0x01
		public static bool allowLineComments; // 0x02
		[ThreadStatic] // 0x0000000189823E60-0x0000000189823E70
		private static StringBuilder m_EscapeBuilder; // 0xFFFFFFFF
	
		// Properties
		public abstract JSONNodeType Tag { get; }
		public virtual JSONNode this[int aIndex] { /* [IDTag] */ /* 0x0000000189A8E810-0x0000000189A8E850 */ /* [XID] */ /* 0x0000000189A8E810-0x0000000189A8E850 */ get => default; /* [XID] */ /* 0x0000000189A992D0-0x0000000189A99310 */ /* [IDTag] */ /* 0x0000000189A992D0-0x0000000189A99310 */ set {} } // 0x0000000187260EC0-0x0000000187260F70 0x0000000187262910-0x00000001872629D0
		public virtual JSONNode this[string aKey] { /* [XID] */ /* 0x0000000189AA3360-0x0000000189AA33A0 */ /* [IDTag] */ /* 0x0000000189AA3360-0x0000000189AA33A0 */ get => default; /* [IDTag] */ /* 0x0000000189AADAD0-0x0000000189AADB10 */ /* [XID] */ /* 0x0000000189AADAD0-0x0000000189AADB10 */ set {} } // 0x0000000187260F70-0x0000000187261020 0x00000001872629D0-0x0000000187262A90
		public virtual string Value { /* [XID] */ /* 0x0000000189AB82C0-0x0000000189AB82E0 */ get; /* [XID] */ /* 0x0000000189ABFD50-0x0000000189ABFD70 */ set; } // 0x00000001872612A0-0x0000000187261350 0x0000000187262A90-0x0000000187262B40
		public virtual int Count { /* [XID] */ /* 0x0000000189B39BD0-0x0000000189B39BF0 */ get; } // 0x0000000187260740-0x00000001872607E0 
		public virtual bool IsNumber { /* [XID] */ /* 0x0000000189ACEEF0-0x0000000189ACEF10 */ get; } // 0x0000000187260CE0-0x0000000187260D80 
		public virtual bool IsString { /* [XID] */ /* 0x0000000189AD6D30-0x0000000189AD6D50 */ get; } // 0x0000000187260E20-0x0000000187260EC0 
		public virtual bool IsBoolean { /* [XID] */ /* 0x000000018962CB90-0x000000018962CBB0 */ get; } // 0x0000000187260BA0-0x0000000187260C40 
		public virtual bool IsNull { /* [XID] */ /* 0x0000000189B41F10-0x0000000189B41F30 */ get; } // 0x0000000187260C40-0x0000000187260CE0 
		public virtual bool IsArray { /* [XID] */ /* 0x00000001897E0D70-0x00000001897E0D90 */ get; } // 0x0000000187260B00-0x0000000187260BA0 
		public virtual bool IsObject { /* [XID] */ /* 0x00000001898DC890-0x00000001898DC8B0 */ get; } // 0x0000000187260D80-0x0000000187260E20 
		public virtual bool Inline { /* [XID] */ /* 0x0000000189AFC4D0-0x0000000189AFC4F0 */ get; /* [XID] */ /* 0x0000000189B03D90-0x0000000189B03DB0 */ set; } // 0x0000000187260A60-0x0000000187260B00 0x0000000187262860-0x0000000187262910
		public virtual IEnumerable<JSONNode> Children { /* [XID] */ /* 0x00000001898C5CF0-0x00000001898C5D10 */ get; } // 0x0000000187260630-0x0000000187260740 
		public IEnumerable<JSONNode> DeepChildren { /* [XID] */ /* 0x00000001898E4300-0x00000001898E4320 */ get; } // 0x00000001872607E0-0x0000000187260900 
		public IEnumerable<KeyValuePair<string, JSONNode>> Linq { /* [XID] */ /* 0x0000000189A0BC70-0x0000000189A0BC90 */ get; } // 0x00000001872611D0-0x00000001872612A0 
		public KeyEnumerator Keys { /* [XID] */ /* 0x0000000189AF5BB0-0x0000000189AF5BD0 */ get; } // 0x0000000187261020-0x00000001872611D0 
		public ValueEnumerator Values { /* [XID] */ /* 0x0000000189B80B40-0x0000000189B80B60 */ get; } // 0x0000000187261350-0x0000000187261500 
		public virtual double AsDouble { /* [XID] */ /* 0x0000000189B88700-0x0000000189B88720 */ get; /* [XID] */ /* 0x0000000189B8F9C0-0x0000000189B8F9E0 */ set; } // 0x00000001872601D0-0x00000001872602F0 0x0000000187262520-0x0000000187262610
		public virtual int AsInt { /* [XID] */ /* 0x0000000189B96F50-0x0000000189B96F70 */ get; /* [XID] */ /* 0x0000000189B9E3B0-0x0000000189B9E3D0 */ set; } // 0x00000001872603B0-0x0000000187260460 0x00000001872626D0-0x0000000187262790
		public virtual float AsFloat { /* [XID] */ /* 0x0000000189BA5E00-0x0000000189BA5E20 */ get; /* [XID] */ /* 0x0000000189B6EB00-0x0000000189B6EB20 */ set; } // 0x00000001872602F0-0x00000001872603B0 0x0000000187262610-0x00000001872626D0
		public virtual bool AsBool { /* [XID] */ /* 0x0000000189BB49A0-0x0000000189BB49C0 */ get; /* [XID] */ /* 0x0000000189BBBEB0-0x0000000189BBBED0 */ set; } // 0x0000000187260080-0x00000001872601D0 0x0000000187262440-0x0000000187262520
		public virtual long AsLong { /* [XID] */ /* 0x0000000189B14000-0x0000000189B14020 */ get; /* [XID] */ /* 0x0000000189B8C320-0x0000000189B8C340 */ set; } // 0x0000000187260460-0x0000000187260540 0x0000000187262790-0x0000000187262860
		public virtual JSONArray AsArray { /* [XID] */ /* 0x0000000189927A30-0x0000000189927A50 */ get; } // 0x000000018725FF90-0x0000000187260080 
		public virtual JSONObject AsObject { /* [XID] */ /* 0x000000018992F1E0-0x000000018992F200 */ get; } // 0x0000000187260540-0x0000000187260630 
		internal static StringBuilder EscapeBuilder { /* [XID] */ /* 0x000000018968D700-0x000000018968D720 */ get; } // 0x0000000187260900-0x0000000187260A60 
	
		// Nested types
		public struct Enumerator // TypeDefIndex: 8896
		{
			// Fields
			private Type type; // 0x00
			private Dictionary<string, JSONNode> m_Object; // 0x08
			private List<JSONNode> m_Array; // 0x28
	
			// Properties
			public bool IsValid { /* [XID] */ /* 0x00000001896AB2D0-0x00000001896AB2F0 */ get => default; } // 0x0000000187252A00-0x0000000187252A30 
			public KeyValuePair<string, JSONNode> Current { /* [XID] */ /* 0x0000000189B5E1E0-0x0000000189B5E200 */ get => default; } // 0x0000000187252930-0x0000000187252A00 
	
			// Nested types
			private enum Type // TypeDefIndex: 8897
			{
				None = 0,
				Array = 1,
				Object = 2
			}
	
			// Constructors
			public Enumerator(List<JSONNode> aArrayEnum) : this() {
				type = default;
				m_Object = default;
				m_Array = default;
			} // 0x0000000187252640-0x00000001872526F0
			public Enumerator(Dictionary<string, JSONNode> aDictEnum) : this() {
				type = default;
				m_Object = default;
				m_Array = default;
			} // 0x00000001872526F0-0x0000000187252930
	
			// Methods
			// [XID] // 0x000000018982C470-0x000000018982C490
			public bool MoveNext() => default; // 0x0000000187252630-0x0000000187252640
		}
	
		public struct ValueEnumerator // TypeDefIndex: 8898
		{
			// Fields
			private Enumerator m_Enumerator; // 0x00
	
			// Properties
			public JSONNode Current { /* [XID] */ /* 0x00000001896C10A0-0x00000001896C10C0 */ get => default; } // 0x0000000187270450-0x0000000187270480 
	
			// Constructors
			public ValueEnumerator(List<JSONNode> aArrayEnum) : this() {
				m_Enumerator = default;
			} // 0x00000001872702B0-0x00000001872702E0
			public ValueEnumerator(Dictionary<string, JSONNode> aDictEnum) : this() {
				m_Enumerator = default;
			} // 0x0000000187270120-0x00000001872702B0
			public ValueEnumerator(Enumerator aEnumerator) : this() {
				m_Enumerator = default;
			} // 0x00000001872702E0-0x0000000187270450
	
			// Methods
			// [XID] // 0x00000001896C86F0-0x00000001896C8710
			public bool MoveNext() => default; // 0x000000018726FFB0-0x0000000187270120
			// [XID] // 0x0000000189A01250-0x0000000189A01270
			public ValueEnumerator GetEnumerator() => default; // 0x000000018726FEC0-0x000000018726FFB0
		}
	
		public struct KeyEnumerator // TypeDefIndex: 8899
		{
			// Fields
			private Enumerator m_Enumerator; // 0x00
	
			// Properties
			public string Current { /* [XID] */ /* 0x00000001896D74C0-0x00000001896D74E0 */ get => default; } // 0x0000000187267D90-0x0000000187267DC0 
	
			// Constructors
			public KeyEnumerator(List<JSONNode> aArrayEnum) : this() {
				m_Enumerator = default;
			} // 0x0000000187267C90-0x0000000187267D90
			public KeyEnumerator(Dictionary<string, JSONNode> aDictEnum) : this() {
				m_Enumerator = default;
			} // 0x0000000187267B00-0x0000000187267C90
			public KeyEnumerator(Enumerator aEnumerator) : this() {
				m_Enumerator = default;
			} // 0x0000000187267900-0x0000000187267B00
	
			// Methods
			// [XID] // 0x0000000189769E10-0x0000000189769E30
			public bool MoveNext() => default; // 0x00000001872678F0-0x0000000187267900
			// [XID] // 0x00000001896E6020-0x00000001896E6040
			public KeyEnumerator GetEnumerator() => default; // 0x0000000187267800-0x00000001872678F0
		}
	
		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerable<KeyValuePair<string, JSONNode>> // TypeDefIndex: 8900
		{
			// Fields
			private JSONNode m_Node; // 0x10
			private Enumerator m_Enumerator; // 0x18
	
			// Properties
			object IEnumerator.Current { /* [XID] */ /* 0x0000000189A1ED90-0x0000000189A1EDB0 */ get => default; } // 0x0000000187268240-0x0000000187268310 
			public KeyValuePair<string, JSONNode> Current { /* [XID] */ /* 0x00000001896ED6B0-0x00000001896ED6D0 */ get => default; } // 0x0000000187268410-0x00000001872684F0 
	
			// Constructors
			public LinqEnumerator() {} // Dummy constructor
			internal LinqEnumerator(JSONNode aNode) {} // 0x0000000187268310-0x0000000187268410
	
			// Methods
			// [XID] // 0x0000000189A2D6D0-0x0000000189A2D6F0
			public bool MoveNext() => default; // 0x0000000187267F90-0x0000000187268040
			// [XID] // 0x0000000189A3C7A0-0x0000000189A3C7C0
			public void Dispose() {} // 0x0000000187267DC0-0x0000000187267EC0
			// [XID] // 0x0000000189A4B740-0x0000000189A4B760
			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator() => default; // 0x0000000187267EC0-0x0000000187267F90
			// [XID] // 0x0000000189712BD0-0x0000000189712BF0
			public void Reset() {} // 0x0000000187268040-0x0000000187268170
			// [XID] // 0x000000018971A5B0-0x000000018971A5D0
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000187268170-0x0000000187268240
		}
	
		// Constructors
		protected JSONNode() {} // 0x000000018725FF30-0x000000018725FF90
		static JSONNode() {} // 0x000000018725FEB0-0x000000018725FF30
	
		// Methods
		// [IDTag] // 0x0000000189B0B4A0-0x0000000189B0B4E0
		// [XID] // 0x0000000189B0B4A0-0x0000000189B0B4E0
		public virtual void Add(string aKey, JSONNode aItem) {} // 0x000000018725E570-0x000000018725E630
		// [IDTag] // 0x0000000189B15750-0x0000000189B15790
		// [XID] // 0x0000000189B15750-0x0000000189B15790
		public virtual void Add(JSONNode aItem) {} // 0x000000018725E4A0-0x000000018725E570
		// [IDTag] // 0x0000000189B20070-0x0000000189B200B0
		// [XID] // 0x0000000189B20070-0x0000000189B200B0
		public virtual JSONNode Remove(string aKey) => default; // 0x000000018725F9C0-0x000000018725FA70
		// [IDTag] // 0x0000000189B2A660-0x0000000189B2A6A0
		// [XID] // 0x0000000189B2A660-0x0000000189B2A6A0
		public virtual JSONNode Remove(int aIndex) => default; // 0x000000018725FA70-0x000000018725FB20
		// [IDTag] // 0x0000000189B348B0-0x0000000189B348F0
		// [XID] // 0x0000000189B348B0-0x0000000189B348F0
		public virtual JSONNode Remove(JSONNode aNode) => default; // 0x000000018725F910-0x000000018725F9C0
		// [XID] // 0x00000001896B9810-0x00000001896B9830
		public virtual bool HasKey(string aKey) => default; // 0x000000018725EB80-0x000000018725EC30
		// [XID] // 0x00000001897F2790-0x00000001897F27B0
		public virtual JSONNode GetValueOrDefault(string aKey, JSONNode aDefault) => default; // 0x000000018725EAC0-0x000000018725EB80
		// [IDTag] // 0x0000000189B5D5A0-0x0000000189B5D5E0
		// [XID] // 0x0000000189B5D5A0-0x0000000189B5D5E0
		public override string ToString() => default; // 0x000000018725FB20-0x000000018725FC30
		// [IDTag] // 0x0000000189B67D90-0x0000000189B67DD0
		// [XID] // 0x0000000189B67D90-0x0000000189B67DD0
		public virtual string ToString(int aIndent) => default; // 0x000000018725FC30-0x000000018725FD50
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);
		public abstract Enumerator GetEnumerator();
		// [IDTag] // 0x00000001895E6B10-0x00000001895E6B50
		// [XID] // 0x00000001895E6B10-0x00000001895E6B50
		public static implicit operator JSONNode(string s) => default; // 0x0000000187261880-0x0000000187261950
		// [IDTag] // 0x00000001895F1400-0x00000001895F1440
		// [XID] // 0x00000001895F1400-0x00000001895F1440
		public static implicit operator string(JSONNode d) => default; // 0x0000000187261A50-0x0000000187261B40
		// [IDTag] // 0x00000001895FBD10-0x00000001895FBD50
		// [XID] // 0x00000001895FBD10-0x00000001895FBD50
		public static implicit operator JSONNode(double n) => default; // 0x0000000187261CF0-0x0000000187261DC0
		// [IDTag] // 0x0000000189606510-0x0000000189606550
		// [XID] // 0x0000000189606510-0x0000000189606550
		public static implicit operator double(JSONNode d) => default; // 0x0000000187261780-0x0000000187261880
		// [IDTag] // 0x0000000189610DE0-0x0000000189610E20
		// [XID] // 0x0000000189610DE0-0x0000000189610E20
		public static implicit operator JSONNode(float n) => default; // 0x0000000187262050-0x0000000187262120
		// [IDTag] // 0x000000018961B390-0x000000018961B3D0
		// [XID] // 0x000000018961B390-0x000000018961B3D0
		public static implicit operator float(JSONNode d) => default; // 0x0000000187262260-0x0000000187262360
		// [IDTag] // 0x00000001896259A0-0x00000001896259E0
		// [XID] // 0x00000001896259A0-0x00000001896259E0
		public static implicit operator JSONNode(int n) => default; // 0x0000000187261EB0-0x0000000187261F80
		// [IDTag] // 0x0000000189630310-0x0000000189630350
		// [XID] // 0x0000000189630310-0x0000000189630350
		public static implicit operator int(JSONNode d) => default; // 0x0000000187261DC0-0x0000000187261EB0
		// [IDTag] // 0x000000018963ACB0-0x000000018963ACF0
		// [XID] // 0x000000018963ACB0-0x000000018963ACF0
		public static implicit operator JSONNode(long n) => default; // 0x0000000187262120-0x0000000187262260
		// [IDTag] // 0x0000000189645370-0x00000001896453B0
		// [XID] // 0x0000000189645370-0x00000001896453B0
		public static implicit operator long(JSONNode d) => default; // 0x0000000187261B40-0x0000000187261C30
		// [IDTag] // 0x000000018964F930-0x000000018964F970
		// [XID] // 0x000000018964F930-0x000000018964F970
		public static implicit operator JSONNode(bool b) => default; // 0x0000000187261F80-0x0000000187262050
		// [IDTag] // 0x000000018965A070-0x000000018965A0B0
		// [XID] // 0x000000018965A070-0x000000018965A0B0
		public static implicit operator bool(JSONNode d) => default; // 0x0000000187261950-0x0000000187261A50
		// [IDTag] // 0x0000000189664930-0x0000000189664970
		// [XID] // 0x0000000189664930-0x0000000189664970
		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue) => default; // 0x0000000187261C30-0x0000000187261CF0
		// [XID] // 0x000000018966F2C0-0x000000018966F2E0
		public static bool operator ==(JSONNode a, object b) => default; // 0x0000000187261500-0x0000000187261780
		// [XID] // 0x0000000189676DD0-0x0000000189676DF0
		public static bool operator !=(JSONNode a, object b) => default; // 0x0000000187262360-0x0000000187262440
		// [XID] // 0x00000001895EB130-0x00000001895EB150
		public override bool Equals(object obj) => default; // 0x000000018725E630-0x000000018725E6F0
		// [XID] // 0x00000001895FA040-0x00000001895FA060
		public override int GetHashCode() => default; // 0x000000018725EA10-0x000000018725EAC0
		// [XID] // 0x0000000189B24300-0x0000000189B24320
		internal static string Escape(string aText) => default; // 0x000000018725E6F0-0x000000018725EA10
		// [XID] // 0x000000018969C960-0x000000018969C980
		private static JSONNode ParseElement(string token, bool quoted) => default; // 0x000000018725EC30-0x000000018725EF10
		// [XID] // 0x00000001896A3E20-0x00000001896A3E40
		public static JSONNode Parse(string aJSON) => default; // 0x000000018725EF10-0x000000018725F910
	}
}
