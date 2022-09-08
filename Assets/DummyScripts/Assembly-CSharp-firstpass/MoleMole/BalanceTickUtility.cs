/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public static class BalanceTickUtility // TypeDefIndex: 10467
	{
		// Fields
		public const int NOTICK_INTERVAL = 0; // Metadata: 0x00AE761F
		public const int EVERYFRAMETICK_INTERVAL = 1; // Metadata: 0x00AE7623
		public const int MINBALANCETICK_INTERVAL = 2; // Metadata: 0x00AE7627
		public const int MAXBALANCETICK_INTERVAL = 8; // Metadata: 0x00AE762B
	
		// Properties
		public static int frameCount { /* [XID] */ /* 0x00000001899DC780-0x00000001899DC7C0 */ get; /* [XID] */ /* 0x00000001899E7250-0x00000001899E7290 */ private set; } // 0x00000001868F2440-0x00000001868F24A0 0x00000001868F25E0-0x00000001868F2640
		public static float time { /* [XID] */ /* 0x00000001899F1650-0x00000001899F1690 */ get; /* [XID] */ /* 0x00000001899FC1A0-0x00000001899FC1E0 */ private set; } // 0x00000001868F24A0-0x00000001868F2510 0x00000001868F2640-0x00000001868F26B0
		public static float deltaTime { /* [XID] */ /* 0x0000000189A06820-0x0000000189A06860 */ get; /* [XID] */ /* 0x0000000189A10AA0-0x0000000189A10AE0 */ private set; } // 0x00000001868F2370-0x00000001868F23E0 0x00000001868F2510-0x00000001868F2580
		public static EngineTickStage engineTickStage { /* [XID] */ /* 0x0000000189A1AF10-0x0000000189A1AF50 */ get; /* [XID] */ /* 0x0000000189A253F0-0x0000000189A25430 */ private set; } // 0x00000001868F23E0-0x00000001868F2440 0x00000001868F2580-0x00000001868F25E0
	
		// Nested types
		public enum EngineTickStage // TypeDefIndex: 10468
		{
			ETS_Undefined = 0,
			ETS_LateUpdate = 1
		}
	
		public enum TestPlanesResults // TypeDefIndex: 10469
		{
			Inside = 0,
			Intersect = 1,
			Outside = 2
		}
	
		// Methods
		// [XID] // 0x00000001899C6720-0x00000001899C6740
		public static bool IsNoTick(int inInterval) => default; // 0x00000001868F1BB0-0x00000001868F1C50
		// [XID] // 0x0000000189AD6B90-0x0000000189AD6BB0
		public static bool IsEveryFrameTick(int inInterval) => default; // 0x00000001868F1B10-0x00000001868F1BB0
		// [XID] // 0x0000000189B21370-0x0000000189B21390
		public static bool IsBalancedTick(int inInterval) => default; // 0x00000001868F1A60-0x00000001868F1B10
		// [XID] // 0x0000000189A2FA10-0x0000000189A2FA30
		public static void SetEngineTickStageLateUpdate(bool isLateUpdate) {} // 0x00000001868F1E60-0x00000001868F1FA0
		// [XID] // 0x0000000189B89D10-0x0000000189B89D30
		public static bool GetEngineTickStageLateUpdate() => default; // 0x00000001868F1980-0x00000001868F1A60
		// [XID] // 0x0000000189A3EAD0-0x0000000189A3EAF0
		public static void OnFrameTick() {} // 0x00000001868F1C50-0x00000001868F1E60
		// [IDTag] // 0x0000000189A461A0-0x0000000189A461E0
		// [XID] // 0x0000000189A461A0-0x0000000189A461E0
		public static TestPlanesResults TestPlanesAABBInternalFast(Plane[] planes, ref Bounds bounds) => default; // 0x00000001868F1FA0-0x00000001868F20D0
		// [IDTag] // 0x0000000189A509E0-0x0000000189A50A20
		// [XID] // 0x0000000189A509E0-0x0000000189A50A20
		public static TestPlanesResults TestPlanesAABBInternalFast(Plane[] planes, ref Vector3 boundsMin, ref Vector3 boundsMax, bool testIntersection = false /* Metadata: 0x00AE761E */) => default; // 0x00000001868F20D0-0x00000001868F2370
	}
}
