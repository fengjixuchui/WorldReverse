/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class DebugMonitorUtil // TypeDefIndex: 27713
{
	// Fields
	private const int TargetFrameRateBits = 1; // Metadata: 0x00B0CC3C
	private const int RenderResolutionBits = 3; // Metadata: 0x00B0CC40
	private const int ShadowQualityBits = 2; // Metadata: 0x00B0CC44
	private const int PostprocessEffectBits = 2; // Metadata: 0x00B0CC48
	private const int ParticleEffectBits = 2; // Metadata: 0x00B0CC4C
	private const int ComprehensiveQualityBits = 3; // Metadata: 0x00B0CC50
	private const int VSyncBits = 1; // Metadata: 0x00B0CC54
	private const int AntiAliasingBits = 2; // Metadata: 0x00B0CC58
	private const int VolumetricFogBits = 1; // Metadata: 0x00B0CC5C
	private const int ReflectionBits = 1; // Metadata: 0x00B0CC60
	private const int MotionBlurBits = 2; // Metadata: 0x00B0CC64
	private const int BloomBits = 2; // Metadata: 0x00B0CC68
	private const int CrowdDensityBits = 1; // Metadata: 0x00B0CC6C
	private const int OnlineEffectBits = 1; // Metadata: 0x00B0CC70
	private const int TargetFrameRateMask = 1; // Metadata: 0x00B0CC74
	private const int RenderResolutionMask = 7; // Metadata: 0x00B0CC78
	private const int ShadowQualityMask = 3; // Metadata: 0x00B0CC7C
	private const int PostprocessEffectMask = 3; // Metadata: 0x00B0CC80
	private const int ParticleEffectMask = 3; // Metadata: 0x00B0CC84
	private const int ComprehensiveQualityMask = 7; // Metadata: 0x00B0CC88
	private const int VSyncMask = 1; // Metadata: 0x00B0CC8C
	private const int AntiAliasingMask = 3; // Metadata: 0x00B0CC90
	private const int VolumetricFogMask = 1; // Metadata: 0x00B0CC94
	private const int ReflectionMask = 1; // Metadata: 0x00B0CC98
	private const int MotionBlurMask = 3; // Metadata: 0x00B0CC9C
	private const int BloomMask = 3; // Metadata: 0x00B0CCA0
	private const int CrowdDensityMask = 1; // Metadata: 0x00B0CCA4
	private const int OnlineEffectMask = 1; // Metadata: 0x00B0CCA8
	private const int VolatileMask = 7; // Metadata: 0x00B0CCAC
	private const int TargetFrameRateOffset = 0; // Metadata: 0x00B0CCB0
	private const int RenderResolutionOffset = 1; // Metadata: 0x00B0CCB4
	private const int ShadowQualityOffset = 4; // Metadata: 0x00B0CCB8
	private const int PostprocessEffectOffset = 6; // Metadata: 0x00B0CCBC
	private const int ParticleEffectOffset = 8; // Metadata: 0x00B0CCC0
	private const int ComprehensiveQualityOffset = 10; // Metadata: 0x00B0CCC4
	private const int VSyncOffset = 13; // Metadata: 0x00B0CCC8
	private const int AntiAliasingOffset = 14; // Metadata: 0x00B0CCCC
	private const int VolumetricFogOffset = 16; // Metadata: 0x00B0CCD0
	private const int ReflectionOffset = 17; // Metadata: 0x00B0CCD4
	private const int MotionBlurOffset = 18; // Metadata: 0x00B0CCD8
	private const int BloomOffset = 20; // Metadata: 0x00B0CCDC
	private const int CrowdDensityOffset = 22; // Metadata: 0x00B0CCE0
	private const int OnlineEffectOffset = 23; // Metadata: 0x00B0CCE4
	private const int VolatileOffset = 24; // Metadata: 0x00B0CCE8

	// Constructors
	public DebugMonitorUtil() {} // 0x00000001830E07F0-0x00000001830E0850

	// Methods
	// [XID] // 0x0000000189BB64E0-0x0000000189BB6500
	public static StringBuilder GetStringBuffer() => default; // 0x00000001830DFDC0-0x00000001830DFE70
	// [XID] // 0x0000000189BBDB60-0x0000000189BBDB80
	public static StringBuilder GetStringBufferTemp() => default; // 0x00000001830E0740-0x00000001830E07F0
	// [XID] // 0x0000000189BC5840-0x0000000189BC5860
	public static void GetPosition(StringBuilder buffer) {} // 0x00000001830DF500-0x00000001830DF670
	// [XID] // 0x0000000189BCD2E0-0x0000000189BCD300
	public static void GetUID(StringBuilder buffer) {} // 0x00000001830DF670-0x00000001830DF800
	// [XID] // 0x0000000189BD47A0-0x0000000189BD47C0
	public static void GetOS(StringBuilder buffer) {} // 0x00000001830E0400-0x00000001830E04E0
	// [XID] // 0x0000000189BDC310-0x0000000189BDC330
	public static void GetCamera(StringBuilder buffer) {} // 0x00000001830DFE70-0x00000001830DFFE0
	// [XID] // 0x00000001895E8B50-0x00000001895E8B70
	public static void GetSceneID(StringBuilder buffer) {} // 0x00000001830DFBE0-0x00000001830DFD10
	// [XID] // 0x00000001895F03E0-0x00000001895F0400
	public static void GetDungeonID(StringBuilder buffer) {} // 0x00000001830E0140-0x00000001830E0270
	// [XID] // 0x00000001895F7E30-0x00000001895F7E50
	public static void GetLogCount(StringBuilder buffer) {} // 0x00000001830E0270-0x00000001830E0400
	// [XID] // 0x00000001895FF250-0x00000001895FF270
	public static int BytesToMegaBytesInt(long _bytes) => default; // 0x00000001830DFB30-0x00000001830DFBE0
	// [XID] // 0x0000000189606AB0-0x0000000189606AD0
	public static int BytesToKiloBytesInt(long _bytes) => default; // 0x00000001830DFD10-0x00000001830DFDC0
	// [XID] // 0x000000018960E410-0x000000018960E430
	public static void AddTransform(Transform transform, StringBuilder buffer) {} // 0x00000001830DF230-0x00000001830DF3C0
	// [XID] // 0x0000000189615A20-0x0000000189615A40
	public static void AddPosition(Vector3 pos, StringBuilder buffer) {} // 0x00000001830DF3C0-0x00000001830DF500
	// [XID] // 0x000000018961D2A0-0x000000018961D2C0
	public static void AddRotation(Quaternion rot, StringBuilder buffer) {} // 0x00000001830E04E0-0x00000001830E0640
	// [XID] // 0x0000000189624730-0x0000000189624750
	public static int GenerateGraphicsSetting() => default; // 0x00000001830E0640-0x00000001830E0740
	// [IDTag] // 0x000000018962BE90-0x000000018962BED0
	// [XID] // 0x000000018962BE90-0x000000018962BED0
	private static int GetGraphicsSetting(GraphicsSettingEntryType type) => default; // 0x00000001830DF800-0x00000001830DF9A0
	// [IDTag] // 0x0000000189636C10-0x0000000189636C50
	// [XID] // 0x0000000189636C10-0x0000000189636C50
	public static int GetGraphicsSetting(int config, GraphicsSettingEntryType type) => default; // 0x00000001830DF9A0-0x00000001830DFB30
	// [XID] // 0x0000000189640F80-0x0000000189640FA0
	public static int GetVolatile(int config) => default; // 0x00000001830DF190-0x00000001830DF230
	// [XID] // 0x0000000189648890-0x00000001896488B0
	private static bool CheckGraphicsSetting(int config) => default; // 0x00000001830DFFE0-0x00000001830E0140
}

