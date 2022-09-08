/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class LevelWindZoneManager // TypeDefIndex: 31530
{
	// Fields
	public const int MAX_SPHERICAL_WINDZONE = 4; // Metadata: 0x00B12896
	private static float WIND_ZONE_FADEIN_SPEED; // 0x00
	private static float WIND_ZONE_FADEOUT_SPEED; // 0x04
	private static Vector4 _WindForce; // 0x08
	private static int _lastFrameID; // 0x18
	private static float _lastTimeScale; // 0x1C
	private static float _timeScalePhaseFix; // 0x20
	private static float _lastWindForce; // 0x24
	private static float _windForcePhaseFix; // 0x28
	private const string propTimeScale = "_MiHoYoTimeScale"; // Metadata: 0x00B1289A
	private const string propWind = "_MiHoYoWind"; // Metadata: 0x00B128AE
	private static int timeScaleID; // 0x2C
	private static int windID; // 0x30
	private static InterpolateWindZone[] _zoneTable; // 0x38
	private static int _zoneTableCount; // 0x40

	// Nested types
	public struct InterpolateWindZone // TypeDefIndex: 31531
	{
		// Fields
		public EnviroWindZone zone; // 0x00
		public Vector3 initialPos; // 0x08
		public float originalStrength; // 0x14
		public float originalSign; // 0x18
		public bool fadeIn; // 0x1C
		public float lastFreq; // 0x20
		public float phaseFix; // 0x24
	}

	// Constructors
	static LevelWindZoneManager() {} // 0x0000000181896B30-0x0000000181896E20

	// Methods
	// [XID] // 0x000000018994DF00-0x000000018994DF20
	private static bool _TryGetValue(int key, out InterpolateWindZone iwz) {
		iwz = default;
		return default;
	} // 0x0000000181896720-0x0000000181896920
	// [XID] // 0x0000000189955560-0x0000000189955580
	private static bool _Add(int key, EnviroWindZone windzone) => default; // 0x0000000181896290-0x0000000181896540
	// [XID] // 0x000000018995D020-0x000000018995D040
	public static void Reset() {} // 0x0000000181896540-0x0000000181896720
	// [XID] // 0x00000001899646E0-0x0000000189964700
	public static void UpdateWindVector() {} // 0x0000000181895320-0x0000000181896290
	// [XID] // 0x000000018996BDF0-0x000000018996BE10
	public static Vector4 GetWindZoneVector() => default; // 0x0000000181896A40-0x0000000181896B30
	// [XID] // 0x00000001899738E0-0x0000000189973900
	public static InterpolateWindZone[] GetSphericalWindZones(out float count) {
		count = default;
		return default;
	} // 0x0000000181896920-0x0000000181896A40
}

