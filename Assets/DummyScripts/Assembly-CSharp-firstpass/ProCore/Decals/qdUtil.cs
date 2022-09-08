/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace ProCore.Decals
{
	public static class qdUtil // TypeDefIndex: 9726
	{
		// Methods
		// [XID] // 0x0000000189A43760-0x0000000189A43780
		public static GameObject[] FindDecalsWithTexture(Texture2D img, Texture2D normalImg = null, DecalType type = DecalType.Sheet /* Metadata: 0x00AE6042 */) => default; // 0x000000018602CF60-0x000000018602D220
		// [XID] // 0x0000000189A96050-0x0000000189A96070
		public static void SortDecalsUsingView(ref List<Decal> decals, DecalView decalView) {} // 0x000000018602D220-0x000000018602D4A0
	
		// Extension methods
		// [XID] // 0x000000018987B190-0x000000018987B1D0
		public static bool Contains(this Dictionary<int, List<int>> dic, int key, int val) => default; // 0x000000018602CE40-0x000000018602CF60
		// [XID] // 0x0000000189885390-0x00000001898853D0
		public static void Add(this Dictionary<int, List<int>> dic, int key, int val) {} // 0x000000018602CC90-0x000000018602CE40
		// [XID] // 0x000000018988F700-0x000000018988F740
		public static string ToFormattedString(this Dictionary<int, List<int>> dic) => default; // 0x000000018602D4A0-0x000000018602D870
		public static string ToFormattedString<T>(this T[] t, string _delimiter) => default;
		public static string ToFormattedString<T>(this List<T> t, string _delimiter) => default;
	}
}
