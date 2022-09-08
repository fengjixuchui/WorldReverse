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
	public class ObjectCasters // TypeDefIndex: 32414
	{
		// Fields
		private Dictionary<System.Type, ObjectCast> castersMap; // 0x10
		private ObjectTranslator translator; // 0x18
	
		// Constructors
		public ObjectCasters() {} // Dummy constructor
		public ObjectCasters(ObjectTranslator translator) {} // 0x000000018612ED40-0x000000018612FD90
	
		// Methods
		private static object charCaster(IntPtr L, int idx, object target) => default; // 0x000000018612FE20-0x000000018612FEB0
		private static object sbyteCaster(IntPtr L, int idx, object target) => default; // 0x0000000186131080-0x0000000186131110
		private static object byteCaster(IntPtr L, int idx, object target) => default; // 0x000000018612FD90-0x000000018612FE20
		private static object shortCaster(IntPtr L, int idx, object target) => default; // 0x0000000186131110-0x00000001861311A0
		private static object ushortCaster(IntPtr L, int idx, object target) => default; // 0x00000001861312C0-0x0000000186131350
		private static object intCaster(IntPtr L, int idx, object target) => default; // 0x0000000186130F60-0x0000000186130FF0
		private static object uintCaster(IntPtr L, int idx, object target) => default; // 0x00000001861311A0-0x0000000186131230
		private static object longCaster(IntPtr L, int idx, object target) => default; // 0x0000000186130FF0-0x0000000186131080
		private static object ulongCaster(IntPtr L, int idx, object target) => default; // 0x0000000186131230-0x00000001861312C0
		private static object getDouble(IntPtr L, int idx, object target) => default; // 0x0000000186130880-0x0000000186130910
		private static object floatCaster(IntPtr L, int idx, object target) => default; // 0x000000018612FF80-0x0000000186130020
		private object decimalCaster(IntPtr L, int idx, object target) => default; // 0x000000018612FEB0-0x000000018612FF80
		private static object getBoolean(IntPtr L, int idx, object target) => default; // 0x0000000186130720-0x00000001861307B0
		private static object getString(IntPtr L, int idx, object target) => default; // 0x0000000186130EE0-0x0000000186130F60
		private object getBytes(IntPtr L, int idx, object target) => default; // 0x00000001861307B0-0x0000000186130880
		private object getIntptr(IntPtr L, int idx, object target) => default; // 0x0000000186130910-0x00000001861309A0
		private object getObject(IntPtr L, int idx, object target) => default; // 0x0000000186130C20-0x0000000186130EE0
		private object getLuaTable(IntPtr L, int idx, object target) => default; // 0x0000000186130AE0-0x0000000186130C20
		private object getLuaFunction(IntPtr L, int idx, object target) => default; // 0x00000001861309A0-0x0000000186130AE0
		public void AddCaster(System.Type type, ObjectCast oc) {} // 0x000000018612EB60-0x000000018612EC00
		private ObjectCast genCaster(System.Type type) => default; // 0x0000000186130020-0x00000001861305F0
		private ObjectCast genNullableCaster(ObjectCast oc) => default; // 0x00000001861305F0-0x0000000186130720
		public ObjectCast GetCaster(System.Type type) => default; // 0x000000018612EC00-0x000000018612ED40
	}
}
