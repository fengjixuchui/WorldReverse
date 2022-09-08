/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x0000000189B2BE30-0x0000000189B2BE60
	internal static class CollectionUtils // TypeDefIndex: 5338
	{
		// Methods
		public static bool IsNullOrEmpty<T>(ICollection<T> collection) => default;
		public static bool IsDictionaryType(System.Type type) => default; // 0x0000000185E49600-0x0000000185E49750
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType) => default; // 0x0000000185E49AE0-0x0000000185E49C40
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(System.Type collectionType, System.Type collectionItemType, System.Type constructorArgumentType) => default; // 0x0000000185E49860-0x0000000185E49AE0
		private static IList<int> GetDimensions(IList values, int dimensionsCount) => default; // 0x0000000185E492A0-0x0000000185E49600
		private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices) {} // 0x0000000185E49020-0x0000000185E492A0
		private static object JaggedArrayGetValue(IList values, int[] indices) => default; // 0x0000000185E49750-0x0000000185E49860
		public static Array ToMultidimensionalArray(IList values, System.Type type, int rank) => default; // 0x0000000185E49C40-0x0000000185E49DD0
	
		// Extension methods
		public static void AddRange<T>(this IList<T> initial, IEnumerable<T> collection) {}
		public static void AddRange<T>(this IList<T> initial, IEnumerable collection) {}
		public static int IndexOf<T>(this IEnumerable<T> collection, Func<T, bool> predicate) => default;
		public static bool Contains<T>(this List<T> list, T value, IEqualityComparer comparer) => default;
		public static int IndexOfReference<T>(this List<T> list, T item) => default;
	}
}
