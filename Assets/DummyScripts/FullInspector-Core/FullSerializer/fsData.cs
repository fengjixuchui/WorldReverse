/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullSerializer
{
	public sealed class fsData // TypeDefIndex: 4718
	{
		// Fields
		private object _value; // 0x10
		public static readonly fsData True; // 0x00
		public static readonly fsData False; // 0x08
		public static readonly fsData Null; // 0x10
	
		// Properties
		public fsDataType Type { get => default; } // 0x0000000185D0A9E0-0x0000000185D0AB70 
		public bool IsNull { get => default; } // 0x0000000185D0A900-0x0000000185D0A960 
		public bool IsDouble { get => default; } // 0x0000000185D0A760-0x0000000185D0A7E0 
		public bool IsInt64 { get => default; } // 0x0000000185D0A7E0-0x0000000185D0A860 
		public bool IsBool { get => default; } // 0x0000000185D0A640-0x0000000185D0A6C0 
		public bool IsString { get => default; } // 0x0000000185D0A960-0x0000000185D0A9E0 
		public bool IsDictionary { get => default; } // 0x0000000185D0A6C0-0x0000000185D0A760 
		public bool IsList { get => default; } // 0x0000000185D0A860-0x0000000185D0A900 
		// [DebuggerBrowsable] // 0x00000001895F2B10-0x00000001895F2B30
		public double AsDouble { get => default; } // 0x0000000185D0A470-0x0000000185D0A4F0 
		// [DebuggerBrowsable] // 0x00000001895F2B10-0x00000001895F2B30
		public long AsInt64 { get => default; } // 0x0000000185D0A4F0-0x0000000185D0A560 
		// [DebuggerBrowsable] // 0x00000001895F2B10-0x00000001895F2B30
		public bool AsBool { get => default; } // 0x0000000185D0A390-0x0000000185D0A400 
		// [DebuggerBrowsable] // 0x00000001895F2B10-0x00000001895F2B30
		public string AsString { get => default; } // 0x0000000185D0A5D0-0x0000000185D0A640 
		// [DebuggerBrowsable] // 0x00000001895F2B10-0x00000001895F2B30
		public Dictionary<string, fsData> AsDictionary { get => default; } // 0x0000000185D0A400-0x0000000185D0A470 
		// [DebuggerBrowsable] // 0x00000001895F2B10-0x00000001895F2B30
		public List<fsData> AsList { get => default; } // 0x0000000185D0A560-0x0000000185D0A5D0 
	
		// Constructors
		public fsData() {} // 0x0000000185D0A320-0x0000000185D0A390
		public fsData(bool boolean) {} // 0x0000000185D0A020-0x0000000185D0A0B0
		public fsData(double f) {} // 0x0000000185D0A140-0x0000000185D0A1D0
		public fsData(long i) {} // 0x0000000185D0A0B0-0x0000000185D0A140
		public fsData(string str) {} // 0x0000000185D0A1D0-0x0000000185D0A240
		public fsData(Dictionary<string, fsData> dict) {} // 0x0000000185D0A240-0x0000000185D0A2B0
		public fsData(List<fsData> list) {} // 0x0000000185D0A2B0-0x0000000185D0A320
		static fsData() {} // 0x0000000185D09F00-0x0000000185D0A020
	
		// Methods
		public static fsData CreateDictionary() => default; // 0x0000000185D094B0-0x0000000185D09610
		public static fsData CreateList() => default; // 0x0000000185D096F0-0x0000000185D097D0
		public static fsData CreateList(int capacity) => default; // 0x0000000185D09610-0x0000000185D096F0
		internal void BecomeDictionary() {} // 0x0000000185D09350-0x0000000185D093E0
		internal fsData Clone() => default; // 0x0000000185D093E0-0x0000000185D094B0
		private T Cast<T>() => default;
		public override string ToString() => default; // 0x0000000185D09E90-0x0000000185D09F00
		public override bool Equals(object obj) => default; // 0x0000000185D097D0-0x0000000185D09860
		public bool Equals(fsData other) => default; // 0x0000000185D09860-0x0000000185D09E10
		public static bool operator ==(fsData a, fsData b) => default; // 0x0000000185D0AB70-0x0000000185D0AC60
		public static bool operator !=(fsData a, fsData b) => default; // 0x0000000185D0AC60-0x0000000185D0AD00
		public override int GetHashCode() => default; // 0x0000000185D09E10-0x0000000185D09E90
	}
}
