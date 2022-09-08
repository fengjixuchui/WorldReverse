/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace XLua
{
	public class ObjectCheckers // TypeDefIndex: 32411
	{
		// Fields
		private Dictionary<System.Type, ObjectCheck> checkersMap; // 0x10
		private ObjectTranslator translator; // 0x18
	
		// Constructors
		public ObjectCheckers() {} // Dummy constructor
		public ObjectCheckers(ObjectTranslator translator) {} // 0x0000000186131820-0x0000000186132460
	
		// Methods
		private static bool objectCheck(IntPtr L, int idx) => default; // 0x0000000186132E30-0x0000000186132E80
		private bool luaTableCheck(IntPtr L, int idx) => default; // 0x0000000186132CB0-0x0000000186132DB0
		private bool numberCheck(IntPtr L, int idx) => default; // 0x0000000186132DB0-0x0000000186132E30
		private bool decimalCheck(IntPtr L, int idx) => default; // 0x00000001861325D0-0x0000000186132690
		private bool strCheck(IntPtr L, int idx) => default; // 0x0000000186132E80-0x0000000186132F20
		private bool bytesCheck(IntPtr L, int idx) => default; // 0x00000001861324E0-0x00000001861325D0
		private bool boolCheck(IntPtr L, int idx) => default; // 0x0000000186132460-0x00000001861324E0
		private bool int64Check(IntPtr L, int idx) => default; // 0x0000000186132A90-0x0000000186132B30
		private bool uint64Check(IntPtr L, int idx) => default; // 0x0000000186132F20-0x0000000186132FC0
		private bool luaFunctionCheck(IntPtr L, int idx) => default; // 0x0000000186132BB0-0x0000000186132CB0
		private bool intptrCheck(IntPtr L, int idx) => default; // 0x0000000186132B30-0x0000000186132BB0
		private ObjectCheck genChecker(System.Type type) => default; // 0x0000000186132690-0x0000000186132960
		public ObjectCheck genNullableChecker(ObjectCheck oc) => default; // 0x0000000186132960-0x0000000186132A90
		public ObjectCheck GetChecker(System.Type type) => default; // 0x00000001861316E0-0x0000000186131820
	}
}
