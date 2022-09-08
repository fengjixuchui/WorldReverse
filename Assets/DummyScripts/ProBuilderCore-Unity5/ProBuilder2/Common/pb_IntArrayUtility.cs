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
	public static class pb_IntArrayUtility // TypeDefIndex: 3402
	{
		// Methods
		public static HashSet<int> GetCommonIndices(Dictionary<int, int> lookup, IList<int> indices) => default; // 0x0000000186BA0DC0-0x0000000186BA1010
		public static pb_IntArray[] ExtractSharedIndices(Vector3[] v) => default; // 0x0000000186BA0840-0x0000000186BA0D30
		public static int MergeSharedIndices(ref pb_IntArray[] sharedIndices, int[] indices) => default; // 0x0000000186BA1620-0x0000000186BA1A40
		public static void MergeSharedIndices(ref pb_IntArray[] sharedIndices, int a, int b) {} // 0x0000000186BA14C0-0x0000000186BA1620
		public static int AddValueAtIndex(ref pb_IntArray[] sharedIndices, int sharedIndex, int value) => default; // 0x0000000186BA0420-0x0000000186BA05C0
		public static int AddRangeAtIndex(ref pb_IntArray[] sharedIndices, int sharedIndex, int[] indices) => default; // 0x0000000186BA02C0-0x0000000186BA0420
		public static void RemoveValues(ref pb_IntArray[] sharedIndices, int[] remove) {} // 0x0000000186BA1EA0-0x0000000186BA2070
		public static void RemoveValuesAndShift(ref pb_IntArray[] sharedIndices, IEnumerable<int> remove) {} // 0x0000000186BA1A40-0x0000000186BA1EA0
	
		// Extension methods
		public static int[][] ToArray(this pb_IntArray[] val) => default; // 0x0000000186BA2070-0x0000000186BA21B0
		public static Dictionary<int, int> ToDictionary(this pb_IntArray[] array) => default; // 0x0000000186BA21B0-0x0000000186BA2360
		public static pb_IntArray[] ToSharedIndices(this IEnumerable<KeyValuePair<int, int>> lookup) => default; // 0x0000000186BA28E0-0x0000000186BA2D00
		public static pb_IntArray[] ToPbIntArray(this int[][] val) => default; // 0x0000000186BA27A0-0x0000000186BA28E0
		public static pb_IntArray[] ToPbIntArray(this List<List<int>> val) => default; // 0x0000000186BA2650-0x0000000186BA27A0
		public static List<List<int>> ToList(this pb_IntArray[] val) => default; // 0x0000000186BA24E0-0x0000000186BA2650
		public static string ToFormattedString(this pb_IntArray[] arr) => default; // 0x0000000186BA2360-0x0000000186BA24E0
		public static int IndexOf(this int[] array, int val, pb_IntArray[] sharedIndices) => default; // 0x0000000186BA1360-0x0000000186BA14C0
		public static int IndexOf(this IList<int> indices, int triangle, ref Dictionary<int, int> lookup) => default; // 0x0000000186BA1140-0x0000000186BA1260
		public static int IndexOf(this pb_IntArray[] intArray, int index) => default; // 0x0000000186BA1260-0x0000000186BA1360
		public static IList<int> AllIndicesWithValues(this pb_IntArray[] pbIntArr, IList<int> indices) => default; // 0x0000000186BA05C0-0x0000000186BA0700
		public static IList<int> AllIndicesWithValues(this pb_IntArray[] pbIntArr, Dictionary<int, int> lookup, IList<int> indices) => default; // 0x0000000186BA0700-0x0000000186BA0840
		public static IList<int> UniqueIndicesWithValues(this pb_IntArray[] pbIntArr, IList<int> indices) => default; // 0x0000000186BA2D70-0x0000000186BA31A0
		public static HashSet<int> GetCommonIndices(this pb_IntArray[] pbIntArr, IList<int> indices) => default; // 0x0000000186BA0D30-0x0000000186BA0DC0
		public static IEnumerable<int> GetIndicesWithCommon(this pb_IntArray[] pbIntArr, IEnumerable<int> common) => default; // 0x0000000186BA1010-0x0000000186BA1140
	}
}
