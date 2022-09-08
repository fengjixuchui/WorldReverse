/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigAnimatorMove : ConfigMove, IAutoAllocRecycle // TypeDefIndex: 18586
{
	// Fields
	private bool _initWithGroundHitCheck; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigMoveSmoothedSpeed _smoothedSpeed; // 0x20
	private bool _moveOnGround; // 0x28
	private bool _moveOnWater; // 0x29
	private SimpleSafeFloat moveOnWaterDepthRawNum; // 0x2C
	private FacingMoveType _facingMove; // 0x30
	private MonsterSizeType _monsterSizeType; // 0x34
	private PositionModifyState _positionModifyState; // 0x38
	private Dictionary<SimpleSafeUInt32, PositionModifyState> _positionModifyStateMap; // 0x40

	// Properties
	public bool initWithGroundHitCheck { /* [XID] */ /* 0x0000000189962310-0x0000000189962330 */ get => default; /* [XID] */ /* 0x0000000189969780-0x00000001899697A0 */ private set {} } // 0x0000000182E74040-0x0000000182E740E0 0x0000000182E74180-0x0000000182E74230
	public ConfigMoveSmoothedSpeed smoothedSpeed { /* [XID] */ /* 0x00000001899714C0-0x00000001899714E0 */ get => default; /* [XID] */ /* 0x0000000189978E70-0x0000000189978E90 */ private set {} } // 0x0000000182E72C10-0x0000000182E72CB0 0x0000000182E72E00-0x0000000182E72EB0
	public bool moveOnGround { /* [XID] */ /* 0x0000000189722F00-0x0000000189722F20 */ get => default; /* [XID] */ /* 0x0000000189987710-0x0000000189987730 */ private set {} } // 0x0000000182E74B00-0x0000000182E74BA0 0x0000000182E71C90-0x0000000182E71D40
	public bool moveOnWater { /* [XID] */ /* 0x000000018998F360-0x000000018998F380 */ get => default; /* [XID] */ /* 0x0000000189996D00-0x0000000189996D20 */ private set {} } // 0x0000000182E740E0-0x0000000182E74180 0x0000000182E74A50-0x0000000182E74B00
	public float moveOnWaterDepth { /* [XID] */ /* 0x000000018999E910-0x000000018999E930 */ get => default; /* [XID] */ /* 0x00000001899A62F0-0x00000001899A6310 */ private set {} } // 0x0000000182E736F0-0x0000000182E737D0 0x0000000182E75190-0x0000000182E75270
	public FacingMoveType facingMove { /* [XID] */ /* 0x00000001899AD920-0x00000001899AD940 */ get => default; /* [XID] */ /* 0x00000001899B51C0-0x00000001899B51E0 */ private set {} } // 0x0000000182E74E50-0x0000000182E74EF0 0x0000000182E72EB0-0x0000000182E72F60
	public MonsterSizeType monsterSizeType { /* [XID] */ /* 0x00000001899BC850-0x00000001899BC870 */ get => default; /* [XID] */ /* 0x00000001899C42A0-0x00000001899C42C0 */ private set {} } // 0x0000000182E75050-0x0000000182E750F0 0x0000000182E73D00-0x0000000182E73DB0
	public PositionModifyState positionModifyState { /* [XID] */ /* 0x00000001899CBA00-0x00000001899CBA20 */ get => default; /* [XID] */ /* 0x00000001899D2EF0-0x00000001899D2F10 */ private set {} } // 0x0000000182E750F0-0x0000000182E75190 0x0000000182E73850-0x0000000182E73900
	public Dictionary<SimpleSafeUInt32, PositionModifyState> positionModifyStateMap { /* [XID] */ /* 0x00000001899DA4E0-0x00000001899DA500 */ get => default; /* [XID] */ /* 0x00000001899E1F00-0x00000001899E1F20 */ private set {} } // 0x0000000182E743D0-0x0000000182E74470 0x0000000182E749A0-0x0000000182E74A50

	// Constructors
	public ConfigAnimatorMove() {} // 0x0000000182E75B70-0x0000000182E75C20

	// Methods
	// [XID] // 0x00000001899E93C0-0x00000001899E93E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182E758F0-0x0000000182E75AD0
	// [XID] // 0x00000001899F0AF0-0x00000001899F0B10
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182E74F50-0x0000000182E75050
	// [XID] // 0x00000001899F83F0-0x00000001899F8410
	public override ConfigMove Clone(bool useObjectPool = false /* Metadata: 0x00AFA4EF */) => default; // 0x0000000182E748C0-0x0000000182E749A0
	// [XID] // 0x00000001899FF9E0-0x00000001899FFA00
	public override int GetHashNum() => default; // 0x0000000182E72D30-0x0000000182E72E00
	// [XID] // 0x0000000189A07210-0x0000000189A07230
	public override void InitEmpty() {} // 0x0000000182E74230-0x0000000182E74350
	[BlackList] // 0x0000000189A0E790-0x0000000189A0E7D0
	// [XID] // 0x0000000189A0E790-0x0000000189A0E7D0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182E73980-0x0000000182E73D00
	// [XID] // 0x0000000189A18C90-0x0000000189A18CB0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182E71DC0-0x0000000182E72690
	[BlackList] // 0x0000000189A20350-0x0000000189A20390
	// [XID] // 0x0000000189A20350-0x0000000189A20390
	public static new ConfigAnimatorMove ParseFromJson(JSONNode node) => default; // 0x0000000182E74C00-0x0000000182E74E50
	// [XID] // 0x0000000189A2A820-0x0000000189A2A840
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA4F0 */, bool useObjectPool = false /* Metadata: 0x00AFA4F4 */) => default; // 0x0000000182E745C0-0x0000000182E748C0
	// [XID] // 0x0000000189A31D40-0x0000000189A31D60
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA4F5 */, bool useObjectPool = false /* Metadata: 0x00AFA4F9 */) => default; // 0x0000000182E73040-0x0000000182E736F0
	// [XID] // 0x0000000189A39770-0x0000000189A39790
	public static new ConfigAnimatorMove ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA4FA */, bool useObjectPool = false /* Metadata: 0x00AFA4FE */) => default; // 0x0000000182E73DB0-0x0000000182E73FD0
	[BlackList] // 0x0000000189A40FD0-0x0000000189A41010
	// [XID] // 0x0000000189A40FD0-0x0000000189A41010
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182E72690-0x0000000182E72960
	// [XID] // 0x0000000189A4B520-0x0000000189A4B540
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182E75270-0x0000000182E758F0
	[BlackList] // 0x0000000189A52BC0-0x0000000189A52C00
	// [XID] // 0x0000000189A52BC0-0x0000000189A52C00
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182E744D0-0x0000000182E745C0
	[BlackList] // 0x0000000189A5D6A0-0x0000000189A5D6E0
	// [XID] // 0x0000000189A5D6A0-0x0000000189A5D6E0
	public override void AutoAllocTypeFields() {} // 0x0000000182E72960-0x0000000182E72A00
	[BlackList] // 0x0000000189A682D0-0x0000000189A68310
	// [XID] // 0x0000000189A682D0-0x0000000189A68310
	public override void AutoRecycleTypeFields() {} // 0x0000000182E72A00-0x0000000182E72B70
	[BlackList] // 0x0000000189A72830-0x0000000189A72870
	// [XID] // 0x0000000189A72830-0x0000000189A72870
	public override void ReturnToObjectPool() {} // 0x0000000182E75AD0-0x0000000182E75B70
}

