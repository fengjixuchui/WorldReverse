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
public class ConfigHomeBlock : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18945
{
	// Fields
	private SimpleSafeUInt32 blockIdRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigHomeFurniture[] _persistentFurnitureList; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigHomeFurniture[] _deployFurniureList; // 0x20
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigHomeFurnitureSuite[] _furnitureSuiteList; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigHomeAnimal[] _deployAnimalList; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigWeekendDjinn[] _weekendDjinnInfoList; // 0x38

	// Properties
	public uint blockId { /* [XID] */ /* 0x00000001895F81D0-0x00000001895F81F0 */ get => default; /* [XID] */ /* 0x00000001895FF710-0x00000001895FF730 */ private set {} } // 0x0000000184D47040-0x0000000184D47110 0x0000000184D460C0-0x0000000184D461A0
	public ConfigHomeFurniture[] persistentFurnitureList { /* [XID] */ /* 0x0000000189606E60-0x0000000189606E80 */ get => default; /* [XID] */ /* 0x000000018960E7A0-0x000000018960E7C0 */ private set {} } // 0x0000000184D46470-0x0000000184D46510 0x0000000184D47300-0x0000000184D473B0
	public ConfigHomeFurniture[] deployFurniureList { /* [XID] */ /* 0x0000000189615E60-0x0000000189615E80 */ get => default; /* [XID] */ /* 0x000000018961D730-0x000000018961D750 */ private set {} } // 0x0000000184D47750-0x0000000184D477F0 0x0000000184D47940-0x0000000184D479F0
	public ConfigHomeFurnitureSuite[] furnitureSuiteList { /* [XID] */ /* 0x0000000189624B90-0x0000000189624BB0 */ get => default; /* [XID] */ /* 0x000000018962C350-0x000000018962C370 */ private set {} } // 0x0000000184D477F0-0x0000000184D47890 0x0000000184D479F0-0x0000000184D47AA0
	public ConfigHomeAnimal[] deployAnimalList { /* [XID] */ /* 0x0000000189633ED0-0x0000000189633EF0 */ get => default; /* [XID] */ /* 0x000000018963B660-0x000000018963B680 */ private set {} } // 0x0000000184D47110-0x0000000184D471B0 0x0000000184D466C0-0x0000000184D46770
	public ConfigWeekendDjinn[] weekendDjinnInfoList { /* [XID] */ /* 0x0000000189642EE0-0x0000000189642F00 */ get => default; /* [XID] */ /* 0x000000018964A580-0x000000018964A5A0 */ private set {} } // 0x0000000184D476B0-0x0000000184D47750 0x0000000184D47890-0x0000000184D47940

	// Constructors
	public ConfigHomeBlock() {} // 0x0000000184D48370-0x0000000184D483D0

	// Methods
	// [XID] // 0x0000000189651DA0-0x0000000189651DC0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184D48020-0x0000000184D48190
	// [XID] // 0x00000001896594F0-0x0000000189659510
	public void InitEmpty() {} // 0x0000000184D471B0-0x0000000184D47300
	[BlackList] // 0x0000000189660BD0-0x0000000189660C10
	// [XID] // 0x0000000189660BD0-0x0000000189660C10
	public bool FromJson(JSONNode node) => default; // 0x0000000184D46CC0-0x0000000184D47040
	// [XID] // 0x000000018966B400-0x000000018966B420
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184D45A60-0x0000000184D460C0
	// [XID] // 0x00000001896730E0-0x0000000189673100
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB48B */, bool useObjectPool = false /* Metadata: 0x00AFB48F */) => default; // 0x0000000184D473B0-0x0000000184D476B0
	// [XID] // 0x000000018967A700-0x000000018967A720
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB490 */, bool useObjectPool = false /* Metadata: 0x00AFB494 */) => default; // 0x0000000184D46770-0x0000000184D46CC0
	[BlackList] // 0x0000000189682050-0x0000000189682090
	// [XID] // 0x0000000189682050-0x0000000189682090
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184D461A0-0x0000000184D46470
	// [XID] // 0x000000018968CA80-0x000000018968CAA0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184D47AA0-0x0000000184D48020
	[BlackList] // 0x00000001896945E0-0x0000000189694620
	// [XID] // 0x00000001896945E0-0x0000000189694620
	public virtual void AutoAllocTypeFields() {} // 0x0000000184D46510-0x0000000184D465B0
	[BlackList] // 0x000000018969EC50-0x000000018969EC90
	// [XID] // 0x000000018969EC50-0x000000018969EC90
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184D465B0-0x0000000184D466C0
	[BlackList] // 0x00000001896A9000-0x00000001896A9040
	// [XID] // 0x00000001896A9000-0x00000001896A9040
	public virtual void ReturnToObjectPool() {} // 0x0000000184D482D0-0x0000000184D48370
	[BlackList] // 0x00000001896B3110-0x00000001896B3150
	// [XID] // 0x00000001896B3110-0x00000001896B3150
	public virtual void OnPoolAllocated() {} // 0x0000000184D48230-0x0000000184D482D0
	[BlackList] // 0x00000001896BD620-0x00000001896BD660
	// [XID] // 0x00000001896BD620-0x00000001896BD660
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184D48190-0x0000000184D48230
}

