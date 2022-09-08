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
public class ConfigBulletPattern : ConfigGadgetPattern, IAutoAllocRecycle // TypeDefIndex: 18094
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigBaseGadgetTriggerAction[] _triggerActions; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigBaseGadgetTriggerAction[] _triggerLifeOverActions; // 0x20
	private bool _killByOther; // 0x28
	private SimpleSafeFloat dieDelayTimeRawNum; // 0x2C
	private bool _checkGrass; // 0x30
	private bool _checkWater; // 0x31
	private SimpleSafeFloat checkIntervalRawNum; // 0x34
	private bool _needCreateGW; // 0x38
	private bool _fireAISoundEvent; // 0x39
	private SimpleSafeFloat maxAutoKillDistRawNum; // 0x3C
	private SimpleSafeFloat enableCollisionDelayRawNum; // 0x40

	// Properties
	public ConfigBaseGadgetTriggerAction[] triggerActions { /* [XID] */ /* 0x000000018997A310-0x000000018997A330 */ get => default; /* [XID] */ /* 0x0000000189981AE0-0x0000000189981B00 */ private set {} } // 0x0000000182CD1020-0x0000000182CD10C0 0x0000000182CD0530-0x0000000182CD05E0
	public ConfigBaseGadgetTriggerAction[] triggerLifeOverActions { /* [XID] */ /* 0x0000000189989400-0x0000000189989420 */ get => default; /* [XID] */ /* 0x0000000189990C50-0x0000000189990C70 */ private set {} } // 0x0000000182CCE5B0-0x0000000182CCE650 0x0000000182CCFD20-0x0000000182CCFDD0
	public bool killByOther { /* [XID] */ /* 0x0000000189AD55B0-0x0000000189AD55D0 */ get => default; /* [XID] */ /* 0x000000018999FFF0-0x00000001899A0010 */ private set {} } // 0x0000000182CD1630-0x0000000182CD16D0 0x0000000182CD09B0-0x0000000182CD0A60
	public float dieDelayTime { /* [XID] */ /* 0x00000001899A7BC0-0x00000001899A7BE0 */ get => default; /* [XID] */ /* 0x00000001899AF390-0x00000001899AF3B0 */ private set {} } // 0x0000000182CCFC40-0x0000000182CCFD20 0x0000000182CD1470-0x0000000182CD1550
	public bool checkGrass { /* [XID] */ /* 0x0000000189679F00-0x0000000189679F20 */ get => default; /* [XID] */ /* 0x00000001899BE390-0x00000001899BE3B0 */ private set {} } // 0x0000000182CCDA20-0x0000000182CCDAC0 0x0000000182CCFDD0-0x0000000182CCFE80
	public bool checkWater { /* [XID] */ /* 0x00000001899C5B10-0x00000001899C5B30 */ get => default; /* [XID] */ /* 0x00000001899CD190-0x00000001899CD1B0 */ private set {} } // 0x0000000182CD0490-0x0000000182CD0530 0x0000000182CCF1D0-0x0000000182CCF280
	public float checkInterval { /* [XID] */ /* 0x00000001899585D0-0x00000001899585F0 */ get => default; /* [XID] */ /* 0x00000001899DBD90-0x00000001899DBDB0 */ private set {} } // 0x0000000182CD1550-0x0000000182CD1630 0x0000000182CCEE80-0x0000000182CCEF60
	public bool needCreateGW { /* [XID] */ /* 0x00000001899E37D0-0x00000001899E37F0 */ get => default; /* [XID] */ /* 0x00000001899EAB40-0x00000001899EAB60 */ private set {} } // 0x0000000182CD0820-0x0000000182CD08C0 0x0000000182CCF0A0-0x0000000182CCF150
	public bool fireAISoundEvent { /* [XID] */ /* 0x00000001899F2740-0x00000001899F2760 */ get => default; /* [XID] */ /* 0x00000001899F9C90-0x00000001899F9CB0 */ private set {} } // 0x0000000182CD0F20-0x0000000182CD0FC0 0x0000000182CCECF0-0x0000000182CCEDA0
	public float maxAutoKillDist { /* [XID] */ /* 0x0000000189A01070-0x0000000189A01090 */ get => default; /* [XID] */ /* 0x0000000189A08A50-0x0000000189A08A70 */ private set {} } // 0x0000000182CD0E40-0x0000000182CD0F20 0x0000000182CCEF60-0x0000000182CCF040
	public float enableCollisionDelay { /* [XID] */ /* 0x0000000189A0FFD0-0x0000000189A0FFF0 */ get => default; /* [XID] */ /* 0x0000000189A17430-0x0000000189A17450 */ private set {} } // 0x0000000182CCF280-0x0000000182CCF360 0x0000000182CCEDA0-0x0000000182CCEE80

	// Constructors
	public ConfigBulletPattern() {} // 0x0000000182CD2140-0x0000000182CD21F0

	// Methods
	// [XID] // 0x0000000189A1EBD0-0x0000000189A1EBF0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182CD1EA0-0x0000000182CD20A0
	// [XID] // 0x0000000189A26280-0x0000000189A262A0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182CD1370-0x0000000182CD1470
	// [XID] // 0x0000000189A2D570-0x0000000189A2D590
	public override ConfigGadgetPattern Clone(bool useObjectPool = false /* Metadata: 0x00AF8ABD */) => default; // 0x0000000182CD0D60-0x0000000182CD0E40
	// [XID] // 0x0000000189A34FF0-0x0000000189A35010
	public override int GetHashNum() => default; // 0x0000000182CCEC20-0x0000000182CCECF0
	// [XID] // 0x0000000189A3C450-0x0000000189A3C470
	public override void InitEmpty() {} // 0x0000000182CD05E0-0x0000000182CD0740
	[BlackList] // 0x0000000189A43FD0-0x0000000189A44010
	// [XID] // 0x0000000189A43FD0-0x0000000189A44010
	public override bool FromJson(JSONNode node) => default; // 0x0000000182CCFE80-0x0000000182CD0200
	// [XID] // 0x0000000189A4E750-0x0000000189A4E770
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182CCDAC0-0x0000000182CCE5B0
	[BlackList] // 0x0000000189A55E20-0x0000000189A55E60
	// [XID] // 0x0000000189A55E20-0x0000000189A55E60
	public static new ConfigBulletPattern ParseFromJson(JSONNode node) => default; // 0x0000000182CD10C0-0x0000000182CD1310
	// [XID] // 0x0000000189A606A0-0x0000000189A606C0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8ABE */, bool useObjectPool = false /* Metadata: 0x00AF8AC2 */) => default; // 0x0000000182CD0A60-0x0000000182CD0D60
	// [XID] // 0x0000000189A68350-0x0000000189A68370
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8AC3 */, bool useObjectPool = false /* Metadata: 0x00AF8AC7 */) => default; // 0x0000000182CCF360-0x0000000182CCFB40
	// [XID] // 0x0000000189A6F720-0x0000000189A6F740
	public static new ConfigBulletPattern ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8AC8 */, bool useObjectPool = false /* Metadata: 0x00AF8ACC */) => default; // 0x0000000182CD0200-0x0000000182CD0420
	[BlackList] // 0x0000000189A76EB0-0x0000000189A76EF0
	// [XID] // 0x0000000189A76EB0-0x0000000189A76EF0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182CCE650-0x0000000182CCE920
	// [XID] // 0x0000000189A81930-0x0000000189A81950
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182CD16D0-0x0000000182CD1EA0
	[BlackList] // 0x0000000189A89470-0x0000000189A894B0
	// [XID] // 0x0000000189A89470-0x0000000189A894B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182CD08C0-0x0000000182CD09B0
	[BlackList] // 0x0000000189A937D0-0x0000000189A93810
	// [XID] // 0x0000000189A937D0-0x0000000189A93810
	public override void AutoAllocTypeFields() {} // 0x0000000182CCE920-0x0000000182CCE9C0
	[BlackList] // 0x0000000189A9DE30-0x0000000189A9DE70
	// [XID] // 0x0000000189A9DE30-0x0000000189A9DE70
	public override void AutoRecycleTypeFields() {} // 0x0000000182CCE9C0-0x0000000182CCEB00
	[BlackList] // 0x0000000189AA8360-0x0000000189AA83A0
	// [XID] // 0x0000000189AA8360-0x0000000189AA83A0
	public override void ReturnToObjectPool() {} // 0x0000000182CD20A0-0x0000000182CD2140
}

