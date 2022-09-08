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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class MechanicBuildingExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16210
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 gadget_idRawNum; // 0x14
	protected SimpleSafeUInt32 specialEffectLevel1RawNum; // 0x18
	protected SimpleSafeUInt32 specialEffectLevel2RawNum; // 0x1C
	protected SimpleSafeUInt32 specialEffectID1RawNum; // 0x20
	protected SimpleSafeUInt32 specialEffectID2RawNum; // 0x24
	protected uint _specialEffectDesc1TextMapHash; // 0x28
	protected uint _specialEffectDesc2TextMapHash; // 0x2C
	protected SimpleSafeUInt32 maxLevelRawNum; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected SGVConfig[] _openConds; // 0x38
	protected SimpleSafeUInt32 buildLimitRawNum; // 0x40
	protected bool _isEnableRotate; // 0x44
	protected SimpleSafeUInt32[] _defaultDungeonList; // 0x48
	protected SimpleSafeUInt32 elementTypeRawNum; // 0x50

	// Properties
	public uint id { /* [XID] */ /* 0x00000001899ADDC0-0x00000001899ADDE0 */ get => default; /* [XID] */ /* 0x00000001899B5560-0x00000001899B5580 */ protected set {} } // 0x0000000182803160-0x0000000182803230 0x0000000182801AF0-0x0000000182801BD0
	public uint gadget_id { /* [XID] */ /* 0x00000001899BCD50-0x00000001899BCD70 */ get => default; /* [XID] */ /* 0x00000001899C4720-0x00000001899C4740 */ protected set {} } // 0x00000001828016E0-0x00000001828017B0 0x0000000182801600-0x00000001828016E0
	public uint specialEffectLevel1 { /* [XID] */ /* 0x00000001899CBF60-0x00000001899CBF80 */ get => default; /* [XID] */ /* 0x00000001899D3490-0x00000001899D34B0 */ protected set {} } // 0x0000000182802D00-0x0000000182802DD0 0x0000000182801890-0x0000000182801970
	public uint specialEffectLevel2 { /* [XID] */ /* 0x00000001899DAA20-0x00000001899DAA40 */ get => default; /* [XID] */ /* 0x00000001899E2360-0x00000001899E2380 */ protected set {} } // 0x0000000182802EA0-0x0000000182802F70 0x0000000182802AC0-0x0000000182802BA0
	public uint specialEffectID1 { /* [XID] */ /* 0x00000001899E9860-0x00000001899E9880 */ get => default; /* [XID] */ /* 0x00000001899F1010-0x00000001899F1030 */ protected set {} } // 0x0000000182801320-0x00000001828013F0 0x00000001828017B0-0x0000000182801890
	public uint specialEffectID2 { /* [XID] */ /* 0x00000001899F8810-0x00000001899F8830 */ get => default; /* [XID] */ /* 0x00000001899FFE40-0x00000001899FFE60 */ protected set {} } // 0x0000000182802DD0-0x0000000182802EA0 0x00000001827FFC30-0x00000001827FFD10
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint specialEffectDesc1TextMapHash { /* [XID] */ /* 0x0000000189A07710-0x0000000189A07730 */ get => default; /* [XID] */ /* 0x0000000189A0EB50-0x0000000189A0EB70 */ protected set {} } // 0x00000001827FF5D0-0x00000001827FF670 0x00000001828027C0-0x0000000182802870
	public string specialEffectDesc1 { /* [XID] */ /* 0x0000000189A16340-0x0000000189A16360 */ get => default; } // 0x0000000182801970-0x0000000182801AF0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint specialEffectDesc2TextMapHash { /* [XID] */ /* 0x0000000189A1D8A0-0x0000000189A1D8C0 */ get => default; /* [XID] */ /* 0x0000000189A24CB0-0x0000000189A24CD0 */ protected set {} } // 0x0000000182802870-0x0000000182802910 0x0000000182802BA0-0x0000000182802C50
	public string specialEffectDesc2 { /* [XID] */ /* 0x0000000189A2C2F0-0x0000000189A2C310 */ get => default; } // 0x00000001827FF890-0x00000001827FFA10 
	public uint maxLevel { /* [XID] */ /* 0x0000000189A339A0-0x0000000189A339C0 */ get => default; /* [XID] */ /* 0x0000000189A3B140-0x0000000189A3B160 */ protected set {} } // 0x00000001827FFB60-0x00000001827FFC30 0x0000000182803230-0x0000000182803310
	public SGVConfig[] openConds { /* [XID] */ /* 0x0000000189A42AD0-0x0000000189A42AF0 */ get => default; /* [XID] */ /* 0x0000000189A4A000-0x0000000189A4A020 */ protected set {} } // 0x0000000182801560-0x0000000182801600 0x00000001827FFA10-0x00000001827FFAC0
	public uint buildLimit { /* [XID] */ /* 0x0000000189A51970-0x0000000189A51990 */ get => default; /* [XID] */ /* 0x0000000189A591E0-0x0000000189A59200 */ protected set {} } // 0x00000001828029F0-0x0000000182802AC0 0x00000001828026E0-0x00000001828027C0
	public bool isEnableRotate { /* [XID] */ /* 0x0000000189A60AC0-0x0000000189A60AE0 */ get => default; /* [XID] */ /* 0x0000000189A688B0-0x0000000189A688D0 */ protected set {} } // 0x00000001828014C0-0x0000000182801560 0x0000000182802C50-0x0000000182802D00
	public SimpleSafeUInt32[] defaultDungeonList { /* [XID] */ /* 0x0000000189A6FC60-0x0000000189A6FC80 */ get => default; /* [XID] */ /* 0x0000000189A773F0-0x0000000189A77410 */ protected set {} } // 0x00000001827FFAC0-0x00000001827FFB60 0x0000000182802F70-0x0000000182803020
	public uint elementType { /* [XID] */ /* 0x0000000189A7ECA0-0x0000000189A7ECC0 */ get => default; /* [XID] */ /* 0x0000000189A864D0-0x0000000189A864F0 */ protected set {} } // 0x00000001828013F0-0x00000001828014C0 0x0000000182802910-0x00000001828029F0

	// Constructors
	public MechanicBuildingExcelConfig() {} // 0x00000001828033B0-0x0000000182803410

	// Methods
	// [IDTag] // 0x0000000189A8DF50-0x0000000189A8DF90
	// [XID] // 0x0000000189A8DF50-0x0000000189A8DF90
	public virtual bool ParseFromLine(string line) => default; // 0x00000001828007A0-0x0000000182801320
	// [IDTag] // 0x0000000189A987C0-0x0000000189A98800
	// [XID] // 0x0000000189A987C0-0x0000000189A98800
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001827FFD10-0x00000001828007A0
	// [XID] // 0x0000000189AA29E0-0x0000000189AA2A00
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3469 */, bool useObjectPool = false /* Metadata: 0x00AF346D */) => default; // 0x0000000182801BD0-0x00000001828026E0
	[BlackList] // 0x0000000189AAA0A0-0x0000000189AAA0E0
	// [XID] // 0x0000000189AAA0A0-0x0000000189AAA0E0
	public virtual void AutoAllocTypeFields() {} // 0x00000001827FF670-0x00000001827FF710
	[BlackList] // 0x0000000189AB4BD0-0x0000000189AB4C10
	// [XID] // 0x0000000189AB4BD0-0x0000000189AB4C10
	public virtual void AutoRecycleTypeFields() {} // 0x00000001827FF710-0x00000001827FF890
	[BlackList] // 0x0000000189ABF550-0x0000000189ABF590
	// [XID] // 0x0000000189ABF550-0x0000000189ABF590
	public virtual void ReturnToObjectPool() {} // 0x0000000182803310-0x00000001828033B0
	[BlackList] // 0x0000000189AC9F20-0x0000000189AC9F60
	// [XID] // 0x0000000189AC9F20-0x0000000189AC9F60
	public virtual void OnPoolAllocated() {} // 0x00000001828030C0-0x0000000182803160
	[BlackList] // 0x0000000189AD4C40-0x0000000189AD4C80
	// [XID] // 0x0000000189AD4C40-0x0000000189AD4C80
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182803020-0x00000001828030C0
}

