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
public class ConfigPerformanceSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18174
{
	// Fields
	private SimpleSafeInt32 scenePropCacheCountRawNum; // 0x10
	private SimpleSafeFloat bundleUnloadLRURetireTimeRawNum; // 0x14
	private SimpleSafeInt32 bundleUnloadLRURetireSizeRawNum; // 0x18
	private SimpleSafeInt32 bundleUnloadLRUCapcityRawNum; // 0x1C
	private SimpleSafeInt32 GameObjectPoolCountRawNum; // 0x20
	private bool _useFinalIK; // 0x24
	private bool _enableAudioSurfaceMultiprobing; // 0x25
	private bool _enableAudioFocusAttenuation; // 0x26
	private bool _enableAudioOcclusionRacasts; // 0x27
	private bool _enableAudioListenerOutreachDetetion; // 0x28
	private SimpleSafeFloat cachedEntityTimeRawNum; // 0x2C
	private SimpleSafeFloat cachedEntityDistRawNum; // 0x30
	private bool _useHeadControl; // 0x34
	private bool _useAvatarGrassDisplacement; // 0x35
	private bool _useOtherEnttiyGrassDisplacement; // 0x36
	private bool _useWindZoneGrassDisplacement; // 0x37
	private bool _useRagdoll; // 0x38
	private bool _useFBIK; // 0x39
	private SimpleSafeInt32 windFlagMaxQualityLevelRawNum; // 0x3C
	private bool _useDynamicBone; // 0x40
	private SimpleSafeInt32 climbIKQualityLevelRawNum; // 0x44
	private bool _useClimbIK; // 0x48
	private bool _useMoveIK; // 0x49
	private bool _useEffectLOD; // 0x4A
	private SimpleSafeInt32 ragdollLimitCountRawNum; // 0x4C
	private SimpleSafeInt32 ragdollPoolSizeRawNum; // 0x50
	private SimpleSafeInt32 ragdollPoolSameIdSizeRawNum; // 0x54

	// Properties
	public int scenePropCacheCount { /* [XID] */ /* 0x00000001899E7F60-0x00000001899E7F80 */ get => default; /* [XID] */ /* 0x00000001899EF430-0x00000001899EF450 */ private set {} } // 0x00000001828A5C80-0x00000001828A5D50 0x00000001828A73D0-0x00000001828A74B0
	public float bundleUnloadLRURetireTime { /* [XID] */ /* 0x000000018992FFD0-0x000000018992FFF0 */ get => default; /* [XID] */ /* 0x00000001899FE510-0x00000001899FE530 */ private set {} } // 0x00000001828A4710-0x00000001828A47F0 0x00000001828A5DF0-0x00000001828A5ED0
	public int bundleUnloadLRURetireSize { /* [XID] */ /* 0x00000001898BEEA0-0x00000001898BEEC0 */ get => default; /* [XID] */ /* 0x0000000189A0D0E0-0x0000000189A0D100 */ private set {} } // 0x00000001828A63C0-0x00000001828A6490 0x00000001828A77A0-0x00000001828A7880
	public int bundleUnloadLRUCapcity { /* [XID] */ /* 0x0000000189A149C0-0x0000000189A149E0 */ get => default; /* [XID] */ /* 0x0000000189A1BC70-0x0000000189A1BC90 */ private set {} } // 0x00000001828A4590-0x00000001828A4660 0x00000001828A9060-0x00000001828A9140
	public int GameObjectPoolCount { /* [XID] */ /* 0x0000000189B88700-0x0000000189B88720 */ get => default; /* [XID] */ /* 0x0000000189A2A8A0-0x0000000189A2A8C0 */ private set {} } // 0x00000001828A47F0-0x00000001828A48C0 0x00000001828A9220-0x00000001828A9300
	public bool useFinalIK { /* [XID] */ /* 0x0000000189A31DA0-0x0000000189A31DC0 */ get => default; /* [XID] */ /* 0x0000000189A397F0-0x0000000189A39810 */ private set {} } // 0x00000001828A66A0-0x00000001828A6740 0x00000001828A41D0-0x00000001828A4280
	public bool enableAudioSurfaceMultiprobing { /* [XID] */ /* 0x0000000189B9CD20-0x0000000189B9CD40 */ get => default; /* [XID] */ /* 0x0000000189A48630-0x0000000189A48650 */ private set {} } // 0x00000001828A5D50-0x00000001828A5DF0 0x00000001828A5BD0-0x00000001828A5C80
	public bool enableAudioFocusAttenuation { /* [XID] */ /* 0x0000000189A4FEA0-0x0000000189A4FEC0 */ get => default; /* [XID] */ /* 0x0000000189A57430-0x0000000189A57450 */ private set {} } // 0x00000001828A3EB0-0x00000001828A3F50 0x00000001828A6DB0-0x00000001828A6E60
	public bool enableAudioOcclusionRacasts { /* [XID] */ /* 0x0000000189A5EF70-0x0000000189A5EF90 */ get => default; /* [XID] */ /* 0x0000000189A668C0-0x0000000189A668E0 */ private set {} } // 0x00000001828A3A70-0x00000001828A3B10 0x00000001828A65F0-0x00000001828A66A0
	public bool enableAudioListenerOutreachDetetion { /* [XID] */ /* 0x0000000189B7F5A0-0x0000000189B7F5C0 */ get => default; /* [XID] */ /* 0x0000000189A75590-0x0000000189A755B0 */ private set {} } // 0x00000001828A8970-0x00000001828A8A10 0x00000001828A4A50-0x00000001828A4B00
	public float cachedEntityTime { /* [XID] */ /* 0x0000000189937530-0x0000000189937550 */ get => default; /* [XID] */ /* 0x0000000189A84B00-0x0000000189A84B20 */ private set {} } // 0x00000001828A76C0-0x00000001828A77A0 0x00000001828A6CD0-0x00000001828A6DB0
	public float cachedEntityDist { /* [XID] */ /* 0x0000000189A8C310-0x0000000189A8C330 */ get => default; /* [XID] */ /* 0x0000000189A93790-0x0000000189A937B0 */ private set {} } // 0x00000001828A9140-0x00000001828A9220 0x00000001828A4970-0x00000001828A4A50
	public bool useHeadControl { /* [XID] */ /* 0x0000000189622A10-0x0000000189622A30 */ get => default; /* [XID] */ /* 0x0000000189AA26E0-0x0000000189AA2700 */ private set {} } // 0x00000001828A4440-0x00000001828A44E0 0x00000001828A7320-0x00000001828A73D0
	public bool useAvatarGrassDisplacement { /* [XID] */ /* 0x0000000189B96F50-0x0000000189B96F70 */ get => default; /* [XID] */ /* 0x0000000189AB1BA0-0x0000000189AB1BC0 */ private set {} } // 0x00000001828A74B0-0x00000001828A7550 0x00000001828A4660-0x00000001828A4710
	public bool useOtherEnttiyGrassDisplacement { /* [XID] */ /* 0x0000000189AB8ED0-0x0000000189AB8EF0 */ get => default; /* [XID] */ /* 0x0000000189AC0950-0x0000000189AC0970 */ private set {} } // 0x00000001828A71B0-0x00000001828A7250 0x00000001828A6540-0x00000001828A65F0
	public bool useWindZoneGrassDisplacement { /* [XID] */ /* 0x00000001896AE1F0-0x00000001896AE210 */ get => default; /* [XID] */ /* 0x0000000189ACFB50-0x0000000189ACFB70 */ private set {} } // 0x00000001828A8A10-0x00000001828A8AB0 0x00000001828A44E0-0x00000001828A4590
	public bool useRagdoll { /* [XID] */ /* 0x0000000189AD7820-0x0000000189AD7840 */ get => default; /* [XID] */ /* 0x0000000189ADF310-0x0000000189ADF330 */ private set {} } // 0x00000001828A7620-0x00000001828A76C0 0x00000001828A6490-0x00000001828A6540
	public bool useFBIK { /* [XID] */ /* 0x0000000189AE6B50-0x0000000189AE6B70 */ get => default; /* [XID] */ /* 0x0000000189AEE660-0x0000000189AEE680 */ private set {} } // 0x00000001828A2220-0x00000001828A22C0 0x00000001828A5B20-0x00000001828A5BD0
	public int windFlagMaxQualityLevel { /* [XID] */ /* 0x0000000189AF5BB0-0x0000000189AF5BD0 */ get => default; /* [XID] */ /* 0x0000000189AFD0D0-0x0000000189AFD0F0 */ private set {} } // 0x00000001828A4B00-0x00000001828A4BD0 0x00000001828A68F0-0x00000001828A69D0
	public bool useDynamicBone { /* [XID] */ /* 0x0000000189B95860-0x0000000189B95880 */ get => default; /* [XID] */ /* 0x0000000189B0C130-0x0000000189B0C150 */ private set {} } // 0x00000001828A7110-0x00000001828A71B0 0x00000001828A6FB0-0x00000001828A7060
	public int climbIKQualityLevel { /* [XID] */ /* 0x0000000189B136D0-0x0000000189B136F0 */ get => default; /* [XID] */ /* 0x0000000189B1ADA0-0x0000000189B1ADC0 */ private set {} } // 0x00000001828A7250-0x00000001828A7320 0x00000001828A4360-0x00000001828A4440
	public bool useClimbIK { /* [XID] */ /* 0x0000000189BA4550-0x0000000189BA4570 */ get => default; /* [XID] */ /* 0x0000000189B29920-0x0000000189B29940 */ private set {} } // 0x00000001828A5ED0-0x00000001828A5F70 0x00000001828A48C0-0x00000001828A4970
	public bool useMoveIK { /* [XID] */ /* 0x0000000189B30F10-0x0000000189B30F30 */ get => default; /* [XID] */ /* 0x0000000189B385B0-0x0000000189B385D0 */ private set {} } // 0x00000001828A22C0-0x00000001828A2360 0x00000001828A6F00-0x00000001828A6FB0
	public bool useEffectLOD { /* [XID] */ /* 0x0000000189B40020-0x0000000189B40040 */ get => default; /* [XID] */ /* 0x0000000189B47880-0x0000000189B478A0 */ private set {} } // 0x00000001828A6E60-0x00000001828A6F00 0x00000001828A7060-0x00000001828A7110
	public int ragdollLimitCount { /* [XID] */ /* 0x00000001896E6020-0x00000001896E6040 */ get => default; /* [XID] */ /* 0x0000000189B569B0-0x0000000189B569D0 */ private set {} } // 0x00000001828A3DE0-0x00000001828A3EB0 0x00000001828A8F80-0x00000001828A9060
	public int ragdollPoolSize { /* [XID] */ /* 0x0000000189B5E1E0-0x0000000189B5E200 */ get => default; /* [XID] */ /* 0x0000000189B65740-0x0000000189B65760 */ private set {} } // 0x00000001828A5F70-0x00000001828A6040 0x00000001828A4280-0x00000001828A4360
	public int ragdollPoolSameIdSize { /* [XID] */ /* 0x00000001896D74C0-0x00000001896D74E0 */ get => default; /* [XID] */ /* 0x0000000189B744B0-0x0000000189B744D0 */ private set {} } // 0x00000001828A7550-0x00000001828A7620 0x00000001828A5A40-0x00000001828A5B20

	// Constructors
	public ConfigPerformanceSetting() {} // 0x00000001828A93A0-0x00000001828A9540

	// Methods
	// [XID] // 0x0000000189B7BAF0-0x0000000189B7BB10
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001828A8AB0-0x00000001828A8E40
	// [XID] // 0x0000000189B83400-0x0000000189B83420
	public void InitEmpty() {} // 0x00000001828A6740-0x00000001828A68F0
	[BlackList] // 0x0000000189B8A850-0x0000000189B8A890
	// [XID] // 0x0000000189B8A850-0x0000000189B8A890
	public bool FromJson(JSONNode node) => default; // 0x00000001828A6040-0x00000001828A63C0
	// [XID] // 0x0000000189B94C10-0x0000000189B94C30
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001828A2360-0x00000001828A3A70
	// [XID] // 0x0000000189B9C360-0x0000000189B9C380
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8DDF */, bool useObjectPool = false /* Metadata: 0x00AF8DE3 */) => default; // 0x00000001828A69D0-0x00000001828A6CD0
	// [XID] // 0x00000001897FE850-0x00000001897FE870
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8DE4 */, bool useObjectPool = false /* Metadata: 0x00AF8DE8 */) => default; // 0x00000001828A4BD0-0x00000001828A5A40
	[BlackList] // 0x0000000189BAAE60-0x0000000189BAAEA0
	// [XID] // 0x0000000189BAAE60-0x0000000189BAAEA0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001828A3B10-0x00000001828A3DE0
	// [XID] // 0x0000000189BB5270-0x0000000189BB5290
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001828A7880-0x00000001828A8970
	[BlackList] // 0x0000000189BBC9D0-0x0000000189BBCA10
	// [XID] // 0x0000000189BBC9D0-0x0000000189BBCA10
	public virtual void AutoAllocTypeFields() {} // 0x00000001828A3F50-0x00000001828A3FF0
	[BlackList] // 0x0000000189BC7480-0x0000000189BC74C0
	// [XID] // 0x0000000189BC7480-0x0000000189BC74C0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001828A3FF0-0x00000001828A41D0
	[BlackList] // 0x0000000189BD1F60-0x0000000189BD1FA0
	// [XID] // 0x0000000189BD1F60-0x0000000189BD1FA0
	public virtual void ReturnToObjectPool() {} // 0x00000001828A9300-0x00000001828A93A0
	[BlackList] // 0x0000000189BDC780-0x0000000189BDC7C0
	// [XID] // 0x0000000189BDC780-0x0000000189BDC7C0
	public virtual void OnPoolAllocated() {} // 0x00000001828A8EE0-0x00000001828A8F80
	[BlackList] // 0x00000001895EC290-0x00000001895EC2D0
	// [XID] // 0x00000001895EC290-0x00000001895EC2D0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001828A8E40-0x00000001828A8EE0
}

