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
public class ConfigWidgetGadget : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19190
{
	// Fields
	private SimpleSafeUInt32 maxCountInSceneRawNum; // 0x10
	private SimpleSafeUInt32 maxCountByPlayerRawNum; // 0x14
	private bool _isCombatDestroy; // 0x18
	private SimpleSafeFloat combatDestroyDistanceRawNum; // 0x1C
	private bool _isDistanceDestroy; // 0x20
	private SimpleSafeFloat distanceDestroyDistanceRawNum; // 0x24
	private bool _isHasCollision; // 0x28
	private bool _collisionIncludeNpc; // 0x29
	private bool _collisionIncludeWater; // 0x2A
	private SimpleSafeFloat radiusRawNum; // 0x2C
	private SimpleSafeFloat distanceToAvatarRawNum; // 0x30
	private SimpleSafeFloat createHeightRawNum; // 0x34
	private MoleMole.Config.Vector _createRot; // 0x38

	// Properties
	public uint maxCountInScene { /* [XID] */ /* 0x0000000189B9EDD0-0x0000000189B9EDF0 */ get => default; /* [XID] */ /* 0x0000000189BA66E0-0x0000000189BA6700 */ private set {} } // 0x0000000181C5DBB0-0x0000000181C5DC80 0x0000000181C5B020-0x0000000181C5B100
	public uint maxCountByPlayer { /* [XID] */ /* 0x0000000189BAD980-0x0000000189BAD9A0 */ get => default; /* [XID] */ /* 0x0000000189BB5190-0x0000000189BB51B0 */ private set {} } // 0x0000000181C5BF00-0x0000000181C5BFD0 0x0000000181C5BC90-0x0000000181C5BD70
	public bool isCombatDestroy { /* [XID] */ /* 0x0000000189BBC850-0x0000000189BBC870 */ get => default; /* [XID] */ /* 0x0000000189BC4500-0x0000000189BC4520 */ private set {} } // 0x0000000181C5D6A0-0x0000000181C5D740 0x0000000181C5BE50-0x0000000181C5BF00
	public float combatDestroyDistance { /* [XID] */ /* 0x0000000189BCBEC0-0x0000000189BCBEE0 */ get => default; /* [XID] */ /* 0x0000000189BD33F0-0x0000000189BD3410 */ private set {} } // 0x0000000181C5BAD0-0x0000000181C5BBB0 0x0000000181C5DC80-0x0000000181C5DD60
	public bool isDistanceDestroy { /* [XID] */ /* 0x0000000189BDAD00-0x0000000189BDAD20 */ get => default; /* [XID] */ /* 0x00000001895E7650-0x00000001895E7670 */ private set {} } // 0x0000000181C5C4D0-0x0000000181C5C570 0x0000000181C5AF70-0x0000000181C5B020
	public float distanceDestroyDistance { /* [XID] */ /* 0x00000001895EEF60-0x00000001895EEF80 */ get => default; /* [XID] */ /* 0x00000001895F6960-0x00000001895F6980 */ private set {} } // 0x0000000181C5BD70-0x0000000181C5BE50 0x0000000181C5C350-0x0000000181C5C430
	public bool isHasCollision { /* [XID] */ /* 0x00000001895FDD20-0x00000001895FDD40 */ get => default; /* [XID] */ /* 0x0000000189605510-0x0000000189605530 */ private set {} } // 0x0000000181C5C430-0x0000000181C5C4D0 0x0000000181C5CB40-0x0000000181C5CBF0
	public bool collisionIncludeNpc { /* [XID] */ /* 0x000000018960CEC0-0x000000018960CEE0 */ get => default; /* [XID] */ /* 0x0000000189614520-0x0000000189614540 */ private set {} } // 0x0000000181C5B100-0x0000000181C5B1A0 0x0000000181C5C9F0-0x0000000181C5CAA0
	public bool collisionIncludeWater { /* [XID] */ /* 0x000000018961BE90-0x000000018961BEB0 */ get => default; /* [XID] */ /* 0x0000000189623460-0x0000000189623480 */ private set {} } // 0x0000000181C5CAA0-0x0000000181C5CB40 0x0000000181C5DF20-0x0000000181C5DFD0
	public float radius { /* [XID] */ /* 0x000000018962ACA0-0x000000018962ACC0 */ get => default; /* [XID] */ /* 0x0000000189632420-0x0000000189632440 */ private set {} } // 0x0000000181C5CCD0-0x0000000181C5CDB0 0x0000000181C5DE40-0x0000000181C5DF20
	public float distanceToAvatar { /* [XID] */ /* 0x0000000189639E90-0x0000000189639EB0 */ get => default; /* [XID] */ /* 0x0000000189641380-0x00000001896413A0 */ private set {} } // 0x0000000181C5DAD0-0x0000000181C5DBB0 0x0000000181C5DD60-0x0000000181C5DE40
	public float createHeight { /* [XID] */ /* 0x0000000189648DA0-0x0000000189648DC0 */ get => default; /* [XID] */ /* 0x0000000189650390-0x00000001896503B0 */ private set {} } // 0x0000000181C5AE90-0x0000000181C5AF70 0x0000000181C5BBB0-0x0000000181C5BC90
	public MoleMole.Config.Vector createRot { /* [XID] */ /* 0x0000000189657C70-0x0000000189657C90 */ get => default; /* [XID] */ /* 0x000000018965F3A0-0x000000018965F3C0 */ private set {} } // 0x0000000181C5CBF0-0x0000000181C5CCD0 0x0000000181C5A8D0-0x0000000181C5A9A0

	// Constructors
	public ConfigWidgetGadget() {} // 0x0000000181C5E070-0x0000000181C5E0D0

	// Methods
	// [XID] // 0x0000000189666BF0-0x0000000189666C10
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181C5D740-0x0000000181C5D990
	// [XID] // 0x000000018966E2C0-0x000000018966E2E0
	public void InitEmpty() {} // 0x0000000181C5C570-0x0000000181C5C6F0
	[BlackList] // 0x0000000189676040-0x0000000189676080
	// [XID] // 0x0000000189676040-0x0000000189676080
	public bool FromJson(JSONNode node) => default; // 0x0000000181C5BFD0-0x0000000181C5C350
	// [XID] // 0x00000001896809E0-0x0000000189680A00
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181C59BD0-0x0000000181C5A8D0
	// [XID] // 0x00000001896884C0-0x00000001896884E0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC4C9 */, bool useObjectPool = false /* Metadata: 0x00AFC4CD */) => default; // 0x0000000181C5C6F0-0x0000000181C5C9F0
	// [XID] // 0x000000018968FD20-0x000000018968FD40
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC4CE */, bool useObjectPool = false /* Metadata: 0x00AFC4D2 */) => default; // 0x0000000181C5B1A0-0x0000000181C5BAD0
	[BlackList] // 0x00000001896976E0-0x0000000189697720
	// [XID] // 0x00000001896976E0-0x0000000189697720
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181C5A9A0-0x0000000181C5AC70
	// [XID] // 0x00000001896A1B80-0x00000001896A1BA0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181C5CDB0-0x0000000181C5D6A0
	[BlackList] // 0x00000001896A8F60-0x00000001896A8FA0
	// [XID] // 0x00000001896A8F60-0x00000001896A8FA0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181C5AC70-0x0000000181C5AD10
	[BlackList] // 0x00000001896B3050-0x00000001896B3090
	// [XID] // 0x00000001896B3050-0x00000001896B3090
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181C5AD10-0x0000000181C5AE90
	[BlackList] // 0x00000001896BD540-0x00000001896BD580
	// [XID] // 0x00000001896BD540-0x00000001896BD580
	public virtual void ReturnToObjectPool() {} // 0x0000000181C5DFD0-0x0000000181C5E070
	[BlackList] // 0x00000001896C7AF0-0x00000001896C7B30
	// [XID] // 0x00000001896C7AF0-0x00000001896C7B30
	public virtual void OnPoolAllocated() {} // 0x0000000181C5DA30-0x0000000181C5DAD0
	[BlackList] // 0x00000001896D1F20-0x00000001896D1F60
	// [XID] // 0x00000001896D1F20-0x00000001896D1F60
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181C5D990-0x0000000181C5DA30
}

