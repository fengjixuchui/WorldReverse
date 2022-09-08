/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace behaviac
{
	public class ComparerRegister // TypeDefIndex: 27395
	{
		// Fields
		private static Dictionary<System.Type, ICompareValue> ms_valueComparers; // 0x00
	
		// Constructors
		public ComparerRegister() {} // 0x0000000186D728C0-0x0000000186D72920
		static ComparerRegister() {} // 0x0000000186D72860-0x0000000186D728C0
	
		// Methods
		private static void Register() {} // 0x0000000186D71F00-0x0000000186D72860
		public static void Init() {} // 0x0000000186D71E10-0x0000000186D71F00
		public static void Cleanup() {} // 0x0000000186D71C30-0x0000000186D71D10
		public static void RegisterType<T, TCOMPARER>()
			where TCOMPARER : ICompareValue, new() {}
		public static ICompareValue<T> Get<T>() => default;
		public static ICompareValue Get(System.Type type) => default; // 0x0000000186D71D10-0x0000000186D71E10
	}
}
