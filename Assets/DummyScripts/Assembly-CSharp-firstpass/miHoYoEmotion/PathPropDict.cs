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

namespace miHoYoEmotion
{
	[Serializable]
	[CreateAssetMenu] // 0x0000000189642380-0x00000001896423D0
	public class PathPropDict : ScriptableObject // TypeDefIndex: 8512
	{
		// Fields
		public static readonly int PATH_STEP; // 0x00
		public static readonly bool DYNAMIC_ADD; // 0x04
		public List<string> pathList; // 0x18
		public List<string> propList; // 0x20
		private static PathPropDict dict; // 0x08
		public static readonly string assetPath; // 0x10
	
		// Properties
		public static PathPropDict Dict { /* [XID] */ /* 0x000000018988E8E0-0x000000018988E900 */ get => default; /* [XID] */ /* 0x000000018965A0D0-0x000000018965A0F0 */ set {} } // 0x0000000187269180-0x00000001872692E0 0x00000001872692E0-0x00000001872693B0
	
		// Constructors
		public PathPropDict() {} // 0x00000001872690D0-0x0000000187269180
		static PathPropDict() {} // 0x0000000187269030-0x00000001872690D0
	
		// Methods
		// [XID] // 0x000000018964B140-0x000000018964B160
		public static bool IsDictInited() => default; // 0x0000000187268EA0-0x0000000187268FA0
		// [XID] // 0x0000000189661840-0x0000000189661860
		public static string GetPath(int index) => default; // 0x0000000187268870-0x0000000187268A30
		// [XID] // 0x00000001897DE130-0x00000001897DE150
		public static int GetPathIndex(string path) => default; // 0x0000000187268650-0x0000000187268870
		// [XID] // 0x0000000189670F10-0x0000000189670F30
		public static string GetProp(int index) => default; // 0x0000000187268C50-0x0000000187268E10
		// [XID] // 0x00000001896785D0-0x00000001896785F0
		public static int GetPropIndex(string prop) => default; // 0x0000000187268A30-0x0000000187268C50
		// [XID] // 0x000000018967FE50-0x000000018967FE70
		public static void Save() {} // 0x0000000187268FA0-0x0000000187269030
		// [XID] // 0x0000000189687520-0x0000000189687540
		public static void InitPathProp() {} // 0x0000000187268E10-0x0000000187268EA0
	}
}
