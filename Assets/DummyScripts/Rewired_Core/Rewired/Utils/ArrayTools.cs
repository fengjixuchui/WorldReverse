/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Interfaces;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Utils
{
	public static class ArrayTools // TypeDefIndex: 4373
	{
		// Methods
		public static T[] DeepClone<T>(T[] array)
			where T : class, IDeepCloneable => default;
		public static T[] ShallowCopy<T>(T[] array) => default;
		public static bool Contains<T>(T[] array, T item) => default;
		public static void Expand<T>(ref T[] array, int length) {}
		public static int IndexOf(int[] array, int value) => default; // 0x000000018554E9F0-0x000000018554EAC0
		public static int IndexOf(ushort[] array, ushort value) => default; // 0x000000018554E930-0x000000018554E9F0
		public static void Fill<T>(T[] array, T value) {}
		public static void Populate<T>(T[] array, int startIndex, int length, Func<T> instantiator) {}
		public static void Populate<T>(T[] array, int startIndex, int length)
			where T : class, new() {}
		public static void Populate<T>(T[] array)
			where T : class, new() {}
		public static void Populate<T>(T[] array, Func<T> instantiator) {}
		public static bool IsNullOrEmpty<T>(T[] array) => default;
	}
}
