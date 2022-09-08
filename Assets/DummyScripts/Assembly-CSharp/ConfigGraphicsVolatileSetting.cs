/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigGraphicsVolatileSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18169
{
	// Fields
	private SimpleSafeUInt32 frameRateGradeRawNum; // 0x10
	private SimpleSafeUInt32 renderResolutionGradeRawNum; // 0x14
	private SimpleSafeUInt32 shadowQualityGradeRawNum; // 0x18
	private SimpleSafeUInt32 postprocessEffectGradeRawNum; // 0x1C
	private SimpleSafeUInt32 particleEffectGradeRawNum; // 0x20
	private SimpleSafeUInt32 comprehensiveQualityGradeRawNum; // 0x24
	private SimpleSafeUInt32 vSyncRawNum; // 0x28
	private SimpleSafeUInt32 AntiAliasingRawNum; // 0x2C
	private SimpleSafeUInt32 VolumetricFogRawNum; // 0x30
	private SimpleSafeUInt32 ReflectionRawNum; // 0x34
	private SimpleSafeUInt32 MotionBlurRawNum; // 0x38
	private SimpleSafeUInt32 BloomRawNum; // 0x3C
	private SimpleSafeUInt32 CrowdDensityRawNum; // 0x40
	private SimpleSafeUInt32 ObsoleteOnlineEffectRawNum; // 0x44
	private SimpleSafeUInt32 ScreenSubsurfaceScatteringRawNum; // 0x48
	private SimpleSafeUInt32 OnlineEffectRawNum; // 0x4C

	// Properties
	public uint frameRateGrade { /* [XID] */ /* 0x0000000189A7E980-0x0000000189A7E9A0 */ get => default; /* [XID] */ /* 0x0000000189A861F0-0x0000000189A86210 */ private set {} } // 0x000000018374F7D0-0x000000018374F8A0 0x000000018374F8A0-0x000000018374F980
	public uint renderResolutionGrade { /* [XID] */ /* 0x0000000189A8DB10-0x0000000189A8DB30 */ get => default; /* [XID] */ /* 0x0000000189A950D0-0x0000000189A950F0 */ private set {} } // 0x000000018374F980-0x000000018374FA50 0x000000018374E9E0-0x000000018374EAC0
	public uint shadowQualityGrade { /* [XID] */ /* 0x0000000189BB49C0-0x0000000189BB49E0 */ get => default; /* [XID] */ /* 0x0000000189AA4120-0x0000000189AA4140 */ private set {} } // 0x000000018374D110-0x000000018374D1E0 0x000000018374E900-0x000000018374E9E0
	public uint postprocessEffectGrade { /* [XID] */ /* 0x0000000189BAD1E0-0x0000000189BAD200 */ get => default; /* [XID] */ /* 0x0000000189AB2FC0-0x0000000189AB2FE0 */ private set {} } // 0x000000018374D1E0-0x000000018374D2B0 0x000000018374E740-0x000000018374E820
	public uint particleEffectGrade { /* [XID] */ /* 0x0000000189661800-0x0000000189661820 */ get => default; /* [XID] */ /* 0x0000000189AC2460-0x0000000189AC2480 */ private set {} } // 0x000000018374E130-0x000000018374E200 0x000000018374E050-0x000000018374E130
	public uint comprehensiveQualityGrade { /* [XID] */ /* 0x0000000189670EB0-0x0000000189670ED0 */ get => default; /* [XID] */ /* 0x0000000189AD13D0-0x0000000189AD13F0 */ private set {} } // 0x000000018374F700-0x000000018374F7D0 0x000000018374FA50-0x000000018374FB30
	public uint vSync { /* [XID] */ /* 0x00000001896785B0-0x00000001896785D0 */ get => default; /* [XID] */ /* 0x0000000189AE0BA0-0x0000000189AE0BC0 */ private set {} } // 0x000000018374F1F0-0x000000018374F2C0 0x000000018374CDA0-0x000000018374CE80
	public uint AntiAliasing { /* [XID] */ /* 0x0000000189AE80B0-0x0000000189AE80D0 */ get => default; /* [XID] */ /* 0x0000000189AEFF90-0x0000000189AEFFB0 */ private set {} } // 0x000000018374EAC0-0x000000018374EB90 0x000000018374B7E0-0x000000018374B8C0
	public uint VolumetricFog { /* [XID] */ /* 0x0000000189AF7420-0x0000000189AF7440 */ get => default; /* [XID] */ /* 0x0000000189AFEAD0-0x0000000189AFEAF0 */ private set {} } // 0x000000018374F630-0x000000018374F700 0x000000018374E200-0x000000018374E2E0
	public uint Reflection { /* [XID] */ /* 0x0000000189B06240-0x0000000189B06260 */ get => default; /* [XID] */ /* 0x0000000189B0D9F0-0x0000000189B0DA10 */ private set {} } // 0x0000000183750980-0x0000000183750A50 0x000000018374F3A0-0x000000018374F480
	public uint MotionBlur { /* [XID] */ /* 0x0000000189B14E50-0x0000000189B14E70 */ get => default; /* [XID] */ /* 0x0000000189B1C7B0-0x0000000189B1C7D0 */ private set {} } // 0x000000018374D2B0-0x000000018374D380 0x000000018374F480-0x000000018374F560
	public uint Bloom { /* [XID] */ /* 0x0000000189B23D60-0x0000000189B23D80 */ get => default; /* [XID] */ /* 0x0000000189B2B060-0x0000000189B2B080 */ private set {} } // 0x000000018374EE20-0x000000018374EEF0 0x000000018374E660-0x000000018374E740
	public uint CrowdDensity { /* [XID] */ /* 0x0000000189B326C0-0x0000000189B326E0 */ get => default; /* [XID] */ /* 0x0000000189B39F90-0x0000000189B39FB0 */ private set {} } // 0x000000018374D380-0x000000018374D450 0x000000018374E820-0x000000018374E900
	public uint ObsoleteOnlineEffect { /* [XID] */ /* 0x0000000189B418F0-0x0000000189B41910 */ get => default; /* [XID] */ /* 0x0000000189B49320-0x0000000189B49340 */ private set {} } // 0x000000018374F560-0x000000018374F630 0x0000000183750E00-0x0000000183750EE0
	public uint ScreenSubsurfaceScattering { /* [XID] */ /* 0x00000001899AB8F0-0x00000001899AB910 */ get => default; /* [XID] */ /* 0x0000000189B58240-0x0000000189B58260 */ private set {} } // 0x000000018374FC00-0x000000018374FCD0 0x000000018374F2C0-0x000000018374F3A0
	public uint OnlineEffect { /* [XID] */ /* 0x00000001899A3CC0-0x00000001899A3CE0 */ get => default; /* [XID] */ /* 0x0000000189B67200-0x0000000189B67220 */ private set {} } // 0x000000018374FB30-0x000000018374FC00 0x000000018374EB90-0x000000018374EC70

	// Constructors
	public ConfigGraphicsVolatileSetting() {} // 0x0000000183750F80-0x0000000183750FE0

	// Methods
	// [XID] // 0x0000000189B6E4A0-0x0000000189B6E4C0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183750A50-0x0000000183750CC0
	// [XID] // 0x0000000189B75C70-0x0000000189B75C90
	public void InitEmpty() {} // 0x000000018374EC70-0x000000018374EE20
	[BlackList] // 0x0000000189B7D0E0-0x0000000189B7D120
	// [XID] // 0x0000000189B7D0E0-0x0000000189B7D120
	public bool FromJson(JSONNode node) => default; // 0x000000018374E2E0-0x000000018374E660
	// [XID] // 0x0000000189B87C00-0x0000000189B87C20
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018374B8C0-0x000000018374CAD0
	// [XID] // 0x0000000189B8EE10-0x0000000189B8EE30
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8DAD */, bool useObjectPool = false /* Metadata: 0x00AF8DB1 */) => default; // 0x000000018374EEF0-0x000000018374F1F0
	// [XID] // 0x0000000189B962C0-0x0000000189B962E0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8DB2 */, bool useObjectPool = false /* Metadata: 0x00AF8DB6 */) => default; // 0x000000018374D450-0x000000018374E050
	[BlackList] // 0x0000000189B9D7C0-0x0000000189B9D800
	// [XID] // 0x0000000189B9D7C0-0x0000000189B9D800
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018374CAD0-0x000000018374CDA0
	// [XID] // 0x0000000189BA7F10-0x0000000189BA7F30
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018374FCD0-0x0000000183750980
	[BlackList] // 0x0000000189BAF380-0x0000000189BAF3C0
	// [XID] // 0x0000000189BAF380-0x0000000189BAF3C0
	public virtual void AutoAllocTypeFields() {} // 0x000000018374CE80-0x000000018374CF20
	[BlackList] // 0x0000000189BB98A0-0x0000000189BB98E0
	// [XID] // 0x0000000189BB98A0-0x0000000189BB98E0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018374CF20-0x000000018374D110
	[BlackList] // 0x0000000189BC4640-0x0000000189BC4680
	// [XID] // 0x0000000189BC4640-0x0000000189BC4680
	public virtual void ReturnToObjectPool() {} // 0x0000000183750EE0-0x0000000183750F80
	[BlackList] // 0x0000000189BCF170-0x0000000189BCF1B0
	// [XID] // 0x0000000189BCF170-0x0000000189BCF1B0
	public virtual void OnPoolAllocated() {} // 0x0000000183750D60-0x0000000183750E00
	[BlackList] // 0x0000000189BD9600-0x0000000189BD9640
	// [XID] // 0x0000000189BD9600-0x0000000189BD9640
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183750CC0-0x0000000183750D60
}

