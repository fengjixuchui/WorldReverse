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

namespace ProGrids
{
	public static class pg_Util // TypeDefIndex: 9705
	{
		// Fields
		private const float EPSILON = 0.0001f; // Metadata: 0x00AE5F58
		private static Dictionary<Transform, SnapEnabledOverride> m_SnapOverrideCache; // 0x00
		private static Dictionary<System.Type, bool> m_NoSnapAttributeTypeCache; // 0x08
		private static Dictionary<System.Type, MethodInfo> m_ConditionalSnapAttributeCache; // 0x10
	
		// Nested types
		private abstract class SnapEnabledOverride // TypeDefIndex: 9706
		{
			// Constructors
			protected SnapEnabledOverride() {} // 0x0000000186022100-0x0000000186022160
	
			// Methods
			public abstract bool IsEnabled();
		}
	
		private class SnapIsEnabledOverride : SnapEnabledOverride // TypeDefIndex: 9707
		{
			// Fields
			private bool m_SnapIsEnabled; // 0x10
	
			// Constructors
			public SnapIsEnabledOverride() {} // Dummy constructor
			public SnapIsEnabledOverride(bool snapIsEnabled) {} // 0x0000000186022200-0x00000001860222B0
	
			// Methods
			// [XID] // 0x00000001896ED600-0x00000001896ED620
			public override bool IsEnabled() => default; // 0x0000000186022160-0x0000000186022200
		}
	
		private class ConditionalSnapOverride : SnapEnabledOverride // TypeDefIndex: 9708
		{
			// Fields
			public Func<bool> m_IsEnabledDelegate; // 0x10
	
			// Constructors
			public ConditionalSnapOverride() {} // Dummy constructor
			public ConditionalSnapOverride(Func<bool> d) {} // 0x000000018600AE30-0x000000018600AEE0
	
			// Methods
			// [XID] // 0x00000001896F4E80-0x00000001896F4EA0
			public override bool IsEnabled() => default; // 0x000000018600AD70-0x000000018600AE30
		}
	
		// Constructors
		static pg_Util() {} // 0x000000018602C830-0x000000018602C920
	
		// Methods
		// [XID] // 0x0000000189B45970-0x0000000189B45990
		public static Color ColorWithString(string value) => default; // 0x0000000186029F60-0x000000018602A290
		// [XID] // 0x0000000189636620-0x0000000189636640
		private static Vector3 VectorToMask(Vector3 vec) => default; // 0x000000018602C600-0x000000018602C830
		// [XID] // 0x000000018963DC50-0x000000018963DC70
		private static Axis MaskToAxis(Vector3 vec) => default; // 0x000000018602A710-0x000000018602A8A0
		// [XID] // 0x00000001896452D0-0x00000001896452F0
		private static Axis BestAxis(Vector3 vec) => default; // 0x00000001860295B0-0x00000001860296E0
		// [XID] // 0x0000000189628E20-0x0000000189628E40
		public static Axis CalcDragAxis(Vector3 movement, Camera cam) => default; // 0x00000001860296E0-0x0000000186029D50
		// [XID] // 0x0000000189654110-0x0000000189654130
		public static float ValueFromMask(Vector3 val, Vector3 mask) => default; // 0x000000018602C480-0x000000018602C600
		// [IDTag] // 0x000000018965BB90-0x000000018965BBD0
		// [XID] // 0x000000018965BB90-0x000000018965BBD0
		public static Vector3 SnapValue(Vector3 val, float snapValue) => default; // 0x000000018602BD80-0x000000018602BF40
		// [XID] // 0x0000000189638200-0x0000000189638220
		private static System.Type GetType(string type, string assembly = null) => default; // 0x000000018602A290-0x000000018602A5C0
		// [XID] // 0x0000000189760A10-0x0000000189760A30
		public static void SetUnityGridEnabled(bool isEnabled) {} // 0x000000018602A8A0-0x000000018602AA10
		// [XID] // 0x0000000189675650-0x0000000189675670
		public static bool GetUnityGridEnabled() => default; // 0x000000018602A5C0-0x000000018602A710
		// [IDTag] // 0x000000018967CD90-0x000000018967CDD0
		// [XID] // 0x000000018967CD90-0x000000018967CDD0
		public static Vector3 SnapValue(Vector3 val, Vector3 mask, float snapValue) => default; // 0x000000018602BF40-0x000000018602C250
		// [IDTag] // 0x0000000189687400-0x0000000189687440
		// [XID] // 0x0000000189687400-0x0000000189687440
		public static Vector3 SnapToCeil(Vector3 val, Vector3 mask, float snapValue) => default; // 0x000000018602B4B0-0x000000018602B7C0
		// [IDTag] // 0x00000001896925C0-0x0000000189692600
		// [XID] // 0x00000001896925C0-0x0000000189692600
		public static Vector3 SnapToFloor(Vector3 val, float snapValue) => default; // 0x000000018602BBC0-0x000000018602BD80
		// [IDTag] // 0x000000018969C890-0x000000018969C8D0
		// [XID] // 0x000000018969C890-0x000000018969C8D0
		public static Vector3 SnapToFloor(Vector3 val, Vector3 mask, float snapValue) => default; // 0x000000018602B8B0-0x000000018602BBC0
		// [XID] // 0x00000001896A6A60-0x00000001896A6A80
		public static float Snap(float val, float round) => default; // 0x000000018602C250-0x000000018602C340
		// [IDTag] // 0x00000001896AE150-0x00000001896AE190
		// [XID] // 0x00000001896AE150-0x00000001896AE190
		public static float SnapToFloor(float val, float snapValue) => default; // 0x000000018602B7C0-0x000000018602B8B0
		// [IDTag] // 0x00000001896B86B0-0x00000001896B86F0
		// [XID] // 0x00000001896B86B0-0x00000001896B86F0
		public static float SnapToCeil(float val, float snapValue) => default; // 0x000000018602B3C0-0x000000018602B4B0
		// [XID] // 0x00000001896C27B0-0x00000001896C27D0
		public static Vector3 CeilFloor(Vector3 v) => default; // 0x0000000186029D50-0x0000000186029E80
		// [XID] // 0x00000001896C9D50-0x00000001896C9D70
		public static void ClearSnapEnabledCache() {} // 0x0000000186029E80-0x0000000186029F60
		// [XID] // 0x00000001896D14E0-0x00000001896D1500
		public static bool SnapIsEnabled(Transform t) => default; // 0x000000018602AA10-0x000000018602B3C0
	}
}
