/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public static class ThreadObjectCache<T> // TypeDefIndex: 10640
		where T : class, new()
	{
		// Fields
		[ThreadStatic] // 0x0000000189823E60-0x0000000189823E70
		private static T _value;
		[ThreadStatic] // 0x0000000189823E60-0x0000000189823E70
		private static bool _used;
	
		// Methods
		public static T Get() => default;
		public static void Release(T value) {}
	}
}
