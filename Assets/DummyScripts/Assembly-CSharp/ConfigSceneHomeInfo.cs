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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigSceneHomeInfo : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18946
{
	// Fields
	private SimpleSafeUInt32 sceneIdRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigHomeBlock[] _blockArrangementInfoList; // 0x18
	private bool _isSetBornPos; // 0x20
	private MoleMole.Config.Vector _bornPos; // 0x24
	private MoleMole.Config.Vector _bornRot; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigHomeFurniture[] _doorList; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigHomeFurniture[] _stairList; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigHomeFurniture _mainHouse; // 0x50
	private MoleMole.Config.Vector _djinnPos; // 0x58
	private SimpleSafeUInt32 tmpVersionRawNum; // 0x64

	// Properties
	public uint sceneId { /* [XID] */ /* 0x00000001896EC940-0x00000001896EC960 */ get => default; /* [XID] */ /* 0x00000001896F4160-0x00000001896F4180 */ private set {} } // 0x000000018398E4F0-0x000000018398E5C0 0x000000018398E9A0-0x000000018398EA80
	public ConfigHomeBlock[] blockArrangementInfoList { /* [XID] */ /* 0x00000001896FB970-0x00000001896FB990 */ get => default; /* [XID] */ /* 0x0000000189702F90-0x0000000189702FB0 */ private set {} } // 0x000000018398D3C0-0x000000018398D460 0x000000018398CDA0-0x000000018398CE50
	public bool isSetBornPos { /* [XID] */ /* 0x000000018970A660-0x000000018970A680 */ get => default; /* [XID] */ /* 0x00000001897120F0-0x0000000189712110 */ private set {} } // 0x000000018398EC00-0x000000018398ECA0 0x000000018398D0C0-0x000000018398D170
	public MoleMole.Config.Vector bornPos { /* [XID] */ /* 0x00000001897197B0-0x00000001897197D0 */ get => default; /* [XID] */ /* 0x0000000189720CF0-0x0000000189720D10 */ private set {} } // 0x000000018398BF50-0x000000018398C030 0x000000018398ECA0-0x000000018398ED70
	public MoleMole.Config.Vector bornRot { /* [XID] */ /* 0x0000000189728370-0x0000000189728390 */ get => default; /* [XID] */ /* 0x000000018972FAF0-0x000000018972FB10 */ private set {} } // 0x000000018398E8C0-0x000000018398E9A0 0x000000018398D170-0x000000018398D240
	public ConfigHomeFurniture[] doorList { /* [XID] */ /* 0x00000001897374E0-0x0000000189737500 */ get => default; /* [XID] */ /* 0x000000018973EF80-0x000000018973EFA0 */ private set {} } // 0x000000018398D240-0x000000018398D2E0 0x000000018398E440-0x000000018398E4F0
	public ConfigHomeFurniture[] stairList { /* [XID] */ /* 0x00000001897461C0-0x00000001897461E0 */ get => default; /* [XID] */ /* 0x000000018974DD70-0x000000018974DD90 */ private set {} } // 0x000000018398CA30-0x000000018398CAD0 0x000000018398DD20-0x000000018398DDD0
	public ConfigHomeFurniture mainHouse { /* [XID] */ /* 0x0000000189755410-0x0000000189755430 */ get => default; /* [XID] */ /* 0x000000018975C5B0-0x000000018975C5D0 */ private set {} } // 0x000000018398E220-0x000000018398E2C0 0x000000018398EB50-0x000000018398EC00
	public MoleMole.Config.Vector djinnPos { /* [XID] */ /* 0x0000000189763EA0-0x0000000189763EC0 */ get => default; /* [XID] */ /* 0x000000018976B700-0x000000018976B720 */ private set {} } // 0x000000018398DC40-0x000000018398DD20 0x000000018398EA80-0x000000018398EB50
	public uint tmpVersion { /* [XID] */ /* 0x0000000189772CA0-0x0000000189772CC0 */ get => default; /* [XID] */ /* 0x000000018977A320-0x000000018977A340 */ private set {} } // 0x000000018398E150-0x000000018398E220 0x000000018398D2E0-0x000000018398D3C0

	// Constructors
	public ConfigSceneHomeInfo() {} // 0x000000018398FA00-0x000000018398FA60

	// Methods
	// [XID] // 0x0000000189781F60-0x0000000189781F80
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018398F5E0-0x000000018398F820
	// [XID] // 0x0000000189789340-0x0000000189789360
	public void InitEmpty() {} // 0x000000018398E2C0-0x000000018398E440
	[BlackList] // 0x0000000189790990-0x00000001897909D0
	// [XID] // 0x0000000189790990-0x00000001897909D0
	public bool FromJson(JSONNode node) => default; // 0x000000018398DDD0-0x000000018398E150
	// [XID] // 0x000000018979BAB0-0x000000018979BAD0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018398C030-0x000000018398CA30
	// [XID] // 0x00000001897A2F40-0x00000001897A2F60
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB495 */, bool useObjectPool = false /* Metadata: 0x00AFB499 */) => default; // 0x000000018398E5C0-0x000000018398E8C0
	// [XID] // 0x00000001897AA560-0x00000001897AA580
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB49A */, bool useObjectPool = false /* Metadata: 0x00AFB49E */) => default; // 0x000000018398D460-0x000000018398DC40
	[BlackList] // 0x00000001897B1FB0-0x00000001897B1FF0
	// [XID] // 0x00000001897B1FB0-0x00000001897B1FF0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018398CAD0-0x000000018398CDA0
	// [XID] // 0x00000001897BD440-0x00000001897BD460
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018398ED70-0x000000018398F5E0
	[BlackList] // 0x00000001897C47C0-0x00000001897C4800
	// [XID] // 0x00000001897C47C0-0x00000001897C4800
	public virtual void AutoAllocTypeFields() {} // 0x000000018398CE50-0x000000018398CEF0
	[BlackList] // 0x00000001897CF130-0x00000001897CF170
	// [XID] // 0x00000001897CF130-0x00000001897CF170
	public virtual void AutoRecycleTypeFields() {} // 0x000000018398CEF0-0x000000018398D0C0
	[BlackList] // 0x00000001897D9F70-0x00000001897D9FB0
	// [XID] // 0x00000001897D9F70-0x00000001897D9FB0
	public virtual void ReturnToObjectPool() {} // 0x000000018398F960-0x000000018398FA00
	[BlackList] // 0x00000001897E4310-0x00000001897E4350
	// [XID] // 0x00000001897E4310-0x00000001897E4350
	public virtual void OnPoolAllocated() {} // 0x000000018398F8C0-0x000000018398F960
	[BlackList] // 0x00000001897EED90-0x00000001897EEDD0
	// [XID] // 0x00000001897EED90-0x00000001897EEDD0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018398F820-0x000000018398F8C0
}

