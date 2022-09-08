/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia.FullSerializer
{
	public sealed class fsData // TypeDefIndex: 9245
	{
		// Fields
		private object _value; // 0x10
		public static readonly fsData True; // 0x00
		public static readonly fsData False; // 0x08
		public static readonly fsData Null; // 0x10
	
		// Properties
		public fsDataType Type { /* [XID] */ /* 0x0000000189B260E0-0x0000000189B26100 */ get => default; } // 0x0000000186B4E250-0x0000000186B4E430 
		public bool IsNull { /* [XID] */ /* 0x00000001897C49A0-0x00000001897C49C0 */ get => default; } // 0x0000000186B4E020-0x0000000186B4E0D0 
		public bool IsDouble { /* [XID] */ /* 0x0000000189B5E180-0x0000000189B5E1A0 */ get => default; } // 0x0000000186B4DDB0-0x0000000186B4DE70 
		public bool IsInt64 { /* [XID] */ /* 0x0000000189B3C0F0-0x0000000189B3C110 */ get => default; } // 0x0000000186B4DE70-0x0000000186B4DF30 
		public bool IsUInt64 { /* [XID] */ /* 0x0000000189B43CF0-0x0000000189B43D10 */ get => default; } // 0x0000000186B4E190-0x0000000186B4E250 
		public bool IsBool { /* [XID] */ /* 0x0000000189A9F470-0x0000000189A9F490 */ get => default; } // 0x0000000186B4DC00-0x0000000186B4DCC0 
		public bool IsString { /* [XID] */ /* 0x0000000189B52B20-0x0000000189B52B40 */ get => default; } // 0x0000000186B4E0D0-0x0000000186B4E190 
		public bool IsDictionary { /* [XID] */ /* 0x0000000189B5A540-0x0000000189B5A560 */ get => default; } // 0x0000000186B4DCC0-0x0000000186B4DDB0 
		public bool IsList { /* [XID] */ /* 0x00000001896A49E0-0x00000001896A4A00 */ get => default; } // 0x0000000186B4DF30-0x0000000186B4E020 
		// [DebuggerBrowsable] // 0x00000001895F2B10-0x00000001895F2B30
		public double AsDouble { /* [XID] */ /* 0x00000001897AF030-0x00000001897AF050 */ get => default; } // 0x0000000186B4D880-0x0000000186B4D940 
		// [DebuggerBrowsable] // 0x00000001895F2B10-0x00000001895F2B30
		public long AsInt64 { /* [XID] */ /* 0x0000000189B70A60-0x0000000189B70A80 */ get => default; } // 0x0000000186B4D940-0x0000000186B4D9F0 
		// [DebuggerBrowsable] // 0x00000001895F2B10-0x00000001895F2B30
		public ulong AsUInt64 { /* [XID] */ /* 0x0000000189B49480-0x0000000189B494A0 */ get => default; } // 0x0000000186B4DB50-0x0000000186B4DC00 
		// [DebuggerBrowsable] // 0x00000001895F2B10-0x00000001895F2B30
		public bool AsBool { /* [XID] */ /* 0x00000001898AA740-0x00000001898AA760 */ get => default; } // 0x0000000186B4D720-0x0000000186B4D7D0 
		// [DebuggerBrowsable] // 0x00000001895F2B10-0x00000001895F2B30
		public string AsString { /* [XID] */ /* 0x0000000189923440-0x0000000189923460 */ get => default; } // 0x0000000186B4DAA0-0x0000000186B4DB50 
		// [DebuggerBrowsable] // 0x00000001895F2B10-0x00000001895F2B30
		public Dictionary<string, fsData> AsDictionary { /* [XID] */ /* 0x0000000189A9B440-0x0000000189A9B460 */ get => default; } // 0x0000000186B4D7D0-0x0000000186B4D880 
		// [DebuggerBrowsable] // 0x00000001895F2B10-0x00000001895F2B30
		public List<fsData> AsList { /* [XID] */ /* 0x0000000189B0D8F0-0x0000000189B0D910 */ get => default; } // 0x0000000186B4D9F0-0x0000000186B4DAA0 
	
		// Constructors
		public fsData() {} // 0x0000000186B4D320-0x0000000186B4D390
		public fsData(bool boolean) {} // 0x0000000186B4D590-0x0000000186B4D620
		public fsData(double f) {} // 0x0000000186B4D490-0x0000000186B4D520
		public fsData(long i) {} // 0x0000000186B4D620-0x0000000186B4D6B0
		public fsData(ulong i) {} // 0x0000000186B4D400-0x0000000186B4D490
		public fsData(string str) {} // 0x0000000186B4D520-0x0000000186B4D590
		public fsData(Dictionary<string, fsData> dict) {} // 0x0000000186B4D6B0-0x0000000186B4D720
		public fsData(List<fsData> list) {} // 0x0000000186B4D390-0x0000000186B4D400
		static fsData() {} // 0x0000000186B4D200-0x0000000186B4D320
	
		// Methods
		// [XID] // 0x0000000189AFB1A0-0x0000000189AFB1C0
		public static fsData CreateDictionary() => default; // 0x0000000186B4C540-0x0000000186B4C6A0
		// [IDTag] // 0x0000000189B02780-0x0000000189B027C0
		// [XID] // 0x0000000189B02780-0x0000000189B027C0
		public static fsData CreateList() => default; // 0x0000000186B4C6A0-0x0000000186B4C780
		// [IDTag] // 0x0000000189B0CBE0-0x0000000189B0CC20
		// [XID] // 0x0000000189B0CBE0-0x0000000189B0CC20
		public static fsData CreateList(int capacity) => default; // 0x0000000186B4C780-0x0000000186B4C860
		// [XID] // 0x00000001899259A0-0x00000001899259C0
		internal void BecomeDictionary() {} // 0x0000000186B4C360-0x0000000186B4C430
		// [XID] // 0x000000018967DA20-0x000000018967DA40
		internal fsData Clone() => default; // 0x0000000186B4C430-0x0000000186B4C540
		private T Cast<T>() => default;
		// [XID] // 0x0000000189A54330-0x0000000189A54350
		public override string ToString() => default; // 0x0000000186B4CFF0-0x0000000186B4D0A0
		// [IDTag] // 0x0000000189BA44D0-0x0000000189BA4510
		// [XID] // 0x0000000189BA44D0-0x0000000189BA4510
		public override bool Equals(object obj) => default; // 0x0000000186B4CE60-0x0000000186B4CF30
		// [IDTag] // 0x0000000189BAE650-0x0000000189BAE690
		// [XID] // 0x0000000189BAE650-0x0000000189BAE690
		public bool Equals(fsData other) => default; // 0x0000000186B4C860-0x0000000186B4CE60
		// [XID] // 0x0000000189850F30-0x0000000189850F50
		public static bool operator ==(fsData a, fsData b) => default; // 0x0000000186B4E430-0x0000000186B4E570
		// [XID] // 0x0000000189BC0540-0x0000000189BC0560
		public static bool operator !=(fsData a, fsData b) => default; // 0x0000000186B4E570-0x0000000186B4E650
		// [XID] // 0x0000000189BC7ED0-0x0000000189BC7EF0
		public override int GetHashCode() => default; // 0x0000000186B4CF30-0x0000000186B4CFF0
	}
}
