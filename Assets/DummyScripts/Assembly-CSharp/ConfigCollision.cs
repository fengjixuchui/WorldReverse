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
public class ConfigCollision : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18089
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCCD _ccd; // 0x10
	private TriggerType _triggerType; // 0x18
	private SimpleSafeFloat triggerCDRawNum; // 0x1C
	private TargetType _targetType; // 0x20
	private bool _ignoreScene; // 0x24
	private bool _ignoreWater; // 0x25
	private bool _bornWithTriggerEnabled; // 0x26
	private SimpleSafeFloat delayEnableCollisionRawNum; // 0x28

	// Properties
	public ConfigCCD ccd { /* [XID] */ /* 0x00000001896DF920-0x00000001896DF940 */ get => default; /* [XID] */ /* 0x00000001896E6CC0-0x00000001896E6CE0 */ private set {} } // 0x0000000183258A40-0x0000000183258AE0 0x00000001832597D0-0x0000000183259880
	public TriggerType triggerType { /* [XID] */ /* 0x00000001896EE1D0-0x00000001896EE1F0 */ get => default; /* [XID] */ /* 0x00000001896F5AE0-0x00000001896F5B00 */ private set {} } // 0x0000000183259300-0x00000001832593A0 0x0000000183258AE0-0x0000000183258B90
	public float triggerCD { /* [XID] */ /* 0x00000001896FD2D0-0x00000001896FD2F0 */ get => default; /* [XID] */ /* 0x00000001897047F0-0x0000000189704810 */ private set {} } // 0x0000000183259880-0x0000000183259960 0x0000000183259220-0x0000000183259300
	public TargetType targetType { /* [XID] */ /* 0x0000000189A462E0-0x0000000189A46300 */ get => default; /* [XID] */ /* 0x00000001897138E0-0x0000000189713900 */ private set {} } // 0x0000000183259A00-0x0000000183259AA0 0x0000000183257B90-0x0000000183257C40
	public bool ignoreScene { /* [XID] */ /* 0x000000018971B160-0x000000018971B180 */ get => default; /* [XID] */ /* 0x00000001897224C0-0x00000001897224E0 */ private set {} } // 0x0000000183259960-0x0000000183259A00 0x0000000183259BB0-0x0000000183259C60
	public bool ignoreWater { /* [XID] */ /* 0x0000000189729BA0-0x0000000189729BC0 */ get => default; /* [XID] */ /* 0x0000000189731260-0x0000000189731280 */ private set {} } // 0x0000000183259180-0x0000000183259220 0x0000000183259720-0x00000001832597D0
	public bool bornWithTriggerEnabled { /* [XID] */ /* 0x0000000189738A90-0x0000000189738AB0 */ get => default; /* [XID] */ /* 0x0000000189740880-0x00000001897408A0 */ private set {} } // 0x000000018325A040-0x000000018325A0E0 0x0000000183257AE0-0x0000000183257B90
	public float delayEnableCollision { /* [XID] */ /* 0x0000000189747C10-0x0000000189747C30 */ get => default; /* [XID] */ /* 0x000000018974F450-0x000000018974F470 */ private set {} } // 0x0000000183258960-0x0000000183258A40 0x0000000183259F60-0x000000018325A040

	// Constructors
	public ConfigCollision() {} // 0x000000018325AA10-0x000000018325AA80

	// Methods
	// [XID] // 0x0000000189756A60-0x0000000189756A80
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018325A670-0x000000018325A830
	// [XID] // 0x000000018975DED0-0x000000018975DEF0
	public void InitEmpty() {} // 0x0000000183259AA0-0x0000000183259BB0
	[BlackList] // 0x0000000189765630-0x0000000189765670
	// [XID] // 0x0000000189765630-0x0000000189765670
	public bool FromJson(JSONNode node) => default; // 0x00000001832593A0-0x0000000183259720
	// [XID] // 0x000000018976FDB0-0x000000018976FDD0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183257C40-0x0000000183258460
	// [XID] // 0x0000000189777550-0x0000000189777570
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A93 */, bool useObjectPool = false /* Metadata: 0x00AF8A97 */) => default; // 0x0000000183259C60-0x0000000183259F60
	// [XID] // 0x000000018977EC80-0x000000018977ECA0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8A98 */, bool useObjectPool = false /* Metadata: 0x00AF8A9C */) => default; // 0x0000000183258B90-0x0000000183259180
	[BlackList] // 0x00000001897865A0-0x00000001897865E0
	// [XID] // 0x00000001897865A0-0x00000001897865E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183258460-0x0000000183258730
	// [XID] // 0x0000000189790AD0-0x0000000189790AF0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018325A0E0-0x000000018325A670
	[BlackList] // 0x0000000189798440-0x0000000189798480
	// [XID] // 0x0000000189798440-0x0000000189798480
	public virtual void AutoAllocTypeFields() {} // 0x0000000183258730-0x00000001832587D0
	[BlackList] // 0x00000001897A3080-0x00000001897A30C0
	// [XID] // 0x00000001897A3080-0x00000001897A30C0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001832587D0-0x0000000183258960
	[BlackList] // 0x00000001897AD730-0x00000001897AD770
	// [XID] // 0x00000001897AD730-0x00000001897AD770
	public virtual void ReturnToObjectPool() {} // 0x000000018325A970-0x000000018325AA10
	[BlackList] // 0x00000001897B8600-0x00000001897B8640
	// [XID] // 0x00000001897B8600-0x00000001897B8640
	public virtual void OnPoolAllocated() {} // 0x000000018325A8D0-0x000000018325A970
	[BlackList] // 0x00000001897C3410-0x00000001897C3450
	// [XID] // 0x00000001897C3410-0x00000001897C3450
	public virtual void OnBeforePoolRecycled() {} // 0x000000018325A830-0x000000018325A8D0
}

