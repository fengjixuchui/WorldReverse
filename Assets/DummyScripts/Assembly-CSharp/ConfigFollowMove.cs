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
public class ConfigFollowMove : ConfigMove, IAutoAllocRecycle // TypeDefIndex: 18633
{
	// Fields
	private FollowTarget _target; // 0x18
	private SimpleSafeUInt32 groupTargetInstanceIdRawNum; // 0x1C
	private string _attachPoint; // 0x20
	private bool _followRotation; // 0x28
	private MoleMole.Config.Vector _offset; // 0x2C
	private MoleMole.Config.Vector _forward; // 0x38
	private bool _followOwnerInvisible; // 0x44
	private SimpleSafeFloat fixedYRawNum; // 0x48
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigIgnoreCollision _ignoreCollision; // 0x50
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMoveDisableCollision _moveDisableCollision; // 0x58

	// Properties
	public FollowTarget target { /* [XID] */ /* 0x00000001898DD110-0x00000001898DD130 */ get => default; /* [XID] */ /* 0x00000001898DAB60-0x00000001898DAB80 */ private set {} } // 0x00000001820E0FC0-0x00000001820E1060 0x00000001820E10C0-0x00000001820E1170
	public uint groupTargetInstanceId { /* [XID] */ /* 0x0000000189A23EB0-0x0000000189A23ED0 */ get => default; /* [XID] */ /* 0x00000001898EA490-0x00000001898EA4B0 */ private set {} } // 0x00000001820E2440-0x00000001820E2510 0x00000001820E0EE0-0x00000001820E0FC0
	public string attachPoint { /* [XID] */ /* 0x00000001899DF6C0-0x00000001899DF6E0 */ get => default; /* [XID] */ /* 0x00000001898F9430-0x00000001898F9450 */ private set {} } // 0x00000001820E1B10-0x00000001820E1BB0 0x00000001820E2390-0x00000001820E2440
	public bool followRotation { /* [XID] */ /* 0x0000000189A32830-0x0000000189A32850 */ get => default; /* [XID] */ /* 0x0000000189908550-0x0000000189908570 */ private set {} } // 0x00000001820E2580-0x00000001820E2620 0x00000001820E27A0-0x00000001820E2850
	public MoleMole.Config.Vector offset { /* [XID] */ /* 0x0000000189A3A230-0x0000000189A3A250 */ get => default; /* [XID] */ /* 0x00000001899176E0-0x0000000189917700 */ private set {} } // 0x00000001820E1D10-0x00000001820E1DF0 0x00000001820E30D0-0x00000001820E31A0
	public MoleMole.Config.Vector forward { /* [XID] */ /* 0x000000018991ED20-0x000000018991ED40 */ get => default; /* [XID] */ /* 0x0000000189926660-0x0000000189926680 */ private set {} } // 0x00000001820E1C30-0x00000001820E1D10 0x00000001820E31A0-0x00000001820E3270
	public bool followOwnerInvisible { /* [XID] */ /* 0x000000018974D1B0-0x000000018974D1D0 */ get => default; /* [XID] */ /* 0x0000000189935130-0x0000000189935150 */ private set {} } // 0x00000001820E3630-0x00000001820E36D0 0x00000001820E36D0-0x00000001820E3780
	public float fixedY { /* [XID] */ /* 0x0000000189B61880-0x0000000189B618A0 */ get => default; /* [XID] */ /* 0x0000000189944320-0x0000000189944340 */ private set {} } // 0x00000001820E26C0-0x00000001820E27A0 0x00000001820E2AC0-0x00000001820E2BA0
	public ConfigIgnoreCollision ignoreCollision { /* [XID] */ /* 0x000000018994B8E0-0x000000018994B900 */ get => default; /* [XID] */ /* 0x00000001899530F0-0x0000000189953110 */ private set {} } // 0x00000001820E2620-0x00000001820E26C0 0x00000001820E3F50-0x00000001820E4000
	public ConfigMoveDisableCollision moveDisableCollision { /* [XID] */ /* 0x0000000189B96E80-0x0000000189B96EA0 */ get => default; /* [XID] */ /* 0x00000001899622F0-0x0000000189962310 */ private set {} } // 0x00000001820E4250-0x00000001820E42F0 0x00000001820E1170-0x00000001820E1220

	// Constructors
	public ConfigFollowMove() {} // 0x00000001820E4390-0x00000001820E4430

	// Methods
	// [XID] // 0x0000000189969760-0x0000000189969780
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001820E4000-0x00000001820E4250
	// [XID] // 0x00000001899714A0-0x00000001899714C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001820E3520-0x00000001820E3630
	// [XID] // 0x0000000189978E50-0x0000000189978E70
	public override ConfigMove Clone(bool useObjectPool = false /* Metadata: 0x00AFA66F */) => default; // 0x00000001820E2F90-0x00000001820E3070
	// [XID] // 0x000000018997FF60-0x000000018997FF80
	public override int GetHashNum() => default; // 0x00000001820E0E10-0x00000001820E0EE0
	// [XID] // 0x00000001899876F0-0x0000000189987710
	public override void InitEmpty() {} // 0x00000001820E2850-0x00000001820E29E0
	[BlackList] // 0x000000018998F320-0x000000018998F360
	// [XID] // 0x000000018998F320-0x000000018998F360
	public override bool FromJson(JSONNode node) => default; // 0x00000001820E1DF0-0x00000001820E2170
	// [XID] // 0x000000018999A1B0-0x000000018999A1D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001820DFD20-0x00000001820E0740
	[BlackList] // 0x00000001899A1870-0x00000001899A18B0
	// [XID] // 0x00000001899A1870-0x00000001899A18B0
	public static new ConfigFollowMove ParseFromJson(JSONNode node) => default; // 0x00000001820E3270-0x00000001820E34C0
	// [XID] // 0x00000001899AC370-0x00000001899AC390
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA670 */, bool useObjectPool = false /* Metadata: 0x00AFA674 */) => default; // 0x00000001820E2C90-0x00000001820E2F90
	// [XID] // 0x00000001899B3B80-0x00000001899B3BA0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA675 */, bool useObjectPool = false /* Metadata: 0x00AFA679 */) => default; // 0x00000001820E12A0-0x00000001820E1A90
	// [XID] // 0x00000001899BAFB0-0x00000001899BAFD0
	public static new ConfigFollowMove ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA67A */, bool useObjectPool = false /* Metadata: 0x00AFA67E */) => default; // 0x00000001820E2170-0x00000001820E2390
	[BlackList] // 0x00000001899C2940-0x00000001899C2980
	// [XID] // 0x00000001899C2940-0x00000001899C2980
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001820E0740-0x00000001820E0A10
	// [XID] // 0x00000001899CD030-0x00000001899CD050
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001820E3780-0x00000001820E3F50
	[BlackList] // 0x00000001899D45F0-0x00000001899D4630
	// [XID] // 0x00000001899D45F0-0x00000001899D4630
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001820E2BA0-0x00000001820E2C90
	[BlackList] // 0x00000001899DEA30-0x00000001899DEA70
	// [XID] // 0x00000001899DEA30-0x00000001899DEA70
	public override void AutoAllocTypeFields() {} // 0x00000001820E0A10-0x00000001820E0AB0
	[BlackList] // 0x00000001899E9380-0x00000001899E93C0
	// [XID] // 0x00000001899E9380-0x00000001899E93C0
	public override void AutoRecycleTypeFields() {} // 0x00000001820E0AB0-0x00000001820E0CF0
	[BlackList] // 0x00000001899F3FD0-0x00000001899F4010
	// [XID] // 0x00000001899F3FD0-0x00000001899F4010
	public override void ReturnToObjectPool() {} // 0x00000001820E42F0-0x00000001820E4390
}

