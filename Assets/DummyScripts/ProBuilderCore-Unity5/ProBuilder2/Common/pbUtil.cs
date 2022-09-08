/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	public static class pbUtil // TypeDefIndex: 3358
	{
		// Nested types
		private struct SearchRange // TypeDefIndex: 3359
		{
			// Fields
			public int begin; // 0x00
			public int end; // 0x04
	
			// Constructors
			public SearchRange(int begin, int end) {
				this.begin = default;
				this.end = default;
			} // 0x00000001894CA9B0-0x00000001894CAA20
	
			// Methods
			public bool Valid() => default; // 0x00000001894CA8E0-0x00000001894CA9B0
			public int Center() => default; // 0x00000001894CA4E0-0x00000001894CA870
			public override string ToString() => default; // 0x00000001894CA870-0x00000001894CA8E0
		}
	
		// Methods
		public static T[] GetComponents<T>(GameObject go)
			where T : Component => default;
		public static GameObject EmptyGameObjectWithTransform(Transform t) => default; // 0x00000001894CB2A0-0x00000001894CB420
		public static int[] AllIndexesOf<T>(T[] arr, T instance) => default;
		public static bool IsEqual<T>(T[] a, T[] b) => default;
		public static int NearestIndexPriorToValue<T>(IList<T> sorted_list, T value)
			where T : IComparable<T> => default;
		public static T[] Fill<T>(T val, int length) => default;
		public static List<T> Fill<T>(Func<int, T> ctor, int length) => default;
		public static T[] FilledArray<T>(T val, int length) => default;
		public static T[] Fill<T>(int count, Func<int, T> ctor) => default;
		public static string ControlKeyString(char character) => default; // 0x00000001894CB070-0x00000001894CB140
		[Obsolete] // 0x0000000189B63570-0x0000000189B635A0
		public static bool ColorWithString(string value, out Color col) {
			col = default;
			return default;
		} // 0x00000001894CAFE0-0x00000001894CB070
		public static bool TryParseColor(string value, ref Color col) => default; // 0x00000001894CB9B0-0x00000001894CBC70
		public static Vector3[] StringToVector3Array(string str) => default; // 0x00000001894CB420-0x00000001894CB860
	
		// Extension methods
		public static T[] GetComponents<T>(this IEnumerable<GameObject> gameObjects)
			where T : Component => default;
		public static T[] GetComponents<T>(this IEnumerable<Transform> transforms)
			where T : Component => default;
		public static Vector3[] ToWorldSpace(this Transform t, Vector3[] v) => default; // 0x00000001894CB860-0x00000001894CB9B0
		public static T[] ValuesWithIndices<T>(this T[] arr, int[] indices) => default;
		public static List<T> ValuesWithIndices<T>(this IList<T> arr, IList<int> indices) => default;
		public static T[] Add<T>(this T[] arr, T val) => default;
		public static T[] AddRange<T>(this T[] arr, T[] val) => default;
		public static T[] Remove<T>(this T[] arr, T val) => default;
		public static T[] Remove<T>(this T[] arr, IEnumerable<T> val) => default;
		public static T[] RemoveAt<T>(this T[] arr, int index) => default;
		public static T[] RemoveAt<T>(this IList<T> list, IEnumerable<int> indices) => default;
		public static T[] SortedRemoveAt<T>(this IList<T> list, IList<int> sorted_indices) => default;
		public static bool ContainsMatch<T>(this T[] a, T[] b) => default;
		public static bool ContainsMatch<T>(this T[] a, T[] b, out int index_a, out int index_b) {
			index_a = default;
			index_b = default;
			return default;
		}
		public static T[] Concat<T>(this T[] x, T[] y) => default;
		public static int IndexOf<T>(this List<List<T>> InList, T InValue) => default;
		public static void AddOrAppend<T, K>(this Dictionary<T, List<K>> dictionary, T key, K value) {}
		public static void AddOrAppendRange<T, K>(this Dictionary<T, List<K>> dictionary, T key, List<K> value) {}
		public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector) => default;
		[Obsolete] // 0x0000000189B49F60-0x0000000189B49F90
		public static string ToFormattedString<T>(this T[] t, string _delimiter) => default;
		[Obsolete] // 0x0000000189B49F60-0x0000000189B49F90
		public static string ToFormattedString<T>(this T[] t, string _delimiter, int entriesPerLine, int maxEntries) => default;
		[Obsolete] // 0x0000000189B49F60-0x0000000189B49F90
		public static string ToFormattedString<T>(this List<T> t, string _delimiter) => default;
		[Obsolete] // 0x0000000189B49F60-0x0000000189B49F90
		public static string ToFormattedString<T>(this HashSet<T> t, string _delimiter) => default;
		public static string ToString<TKey, TValue>(this Dictionary<TKey, TValue> dict) => default;
		public static string ToString<T>(this IEnumerable<T> arr, string separator = ", " /* Metadata: 0x00AC3318 */) => default;
		public static Vector2 DivideBy(this Vector2 v, Vector2 o) => default; // 0x00000001894CB140-0x00000001894CB1E0
		public static Vector3 DivideBy(this Vector3 v, Vector3 o) => default; // 0x00000001894CB1E0-0x00000001894CB2A0
	}
}
