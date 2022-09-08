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
public class AudioDialogReaction : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17566
{
	// Fields
	private SimpleSafeUInt32 dialogIdRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private AudioStateOp[] _stateOpsOnStart; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private AudioStateOp[] _stateOpsOnFinish; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _eventOnStart; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _eventOnFinish; // 0x30

	// Properties
	public uint dialogId { /* [XID] */ /* 0x0000000189B06420-0x0000000189B06440 */ get => default; /* [XID] */ /* 0x0000000189B0DB10-0x0000000189B0DB30 */ private set {} } // 0x00000001857992A0-0x0000000185799370 0x0000000185799CD0-0x0000000185799DB0
	public AudioStateOp[] stateOpsOnStart { /* [XID] */ /* 0x0000000189AAF4F0-0x0000000189AAF510 */ get => default; /* [XID] */ /* 0x0000000189B1C950-0x0000000189B1C970 */ private set {} } // 0x0000000185797760-0x0000000185797800 0x0000000185798340-0x00000001857983F0
	public AudioStateOp[] stateOpsOnFinish { /* [XID] */ /* 0x0000000189AC6290-0x0000000189AC62B0 */ get => default; /* [XID] */ /* 0x0000000189B2B180-0x0000000189B2B1A0 */ private set {} } // 0x0000000185798E60-0x0000000185798F00 0x00000001857988F0-0x00000001857989A0
	public ConfigWwiseString eventOnStart { /* [XID] */ /* 0x0000000189B327E0-0x0000000189B32800 */ get => default; /* [XID] */ /* 0x0000000189B3A0B0-0x0000000189B3A0D0 */ private set {} } // 0x0000000185799200-0x00000001857992A0 0x0000000185799410-0x00000001857994C0
	public ConfigWwiseString eventOnFinish { /* [XID] */ /* 0x0000000189ABE780-0x0000000189ABE7A0 */ get => default; /* [XID] */ /* 0x0000000189B49420-0x0000000189B49440 */ private set {} } // 0x0000000185799370-0x0000000185799410 0x0000000185799960-0x0000000185799A10

	// Constructors
	public AudioDialogReaction() {} // 0x0000000185799E50-0x0000000185799EB0

	// Methods
	// [XID] // 0x0000000189B50A80-0x0000000189B50AA0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185799A10-0x0000000185799B90
	// [XID] // 0x0000000189B58320-0x0000000189B58340
	public void InitEmpty() {} // 0x0000000185798D20-0x0000000185798E60
	[BlackList] // 0x0000000189B5FC80-0x0000000189B5FCC0
	// [XID] // 0x0000000189B5FC80-0x0000000189B5FCC0
	public bool FromJson(JSONNode node) => default; // 0x00000001857989A0-0x0000000185798D20
	// [XID] // 0x0000000189B6A210-0x0000000189B6A230
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000185797800-0x0000000185797DE0
	// [XID] // 0x0000000189B718B0-0x0000000189B718D0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7325 */, bool useObjectPool = false /* Metadata: 0x00AF7329 */) => default; // 0x0000000185798F00-0x0000000185799200
	// [XID] // 0x0000000189B78D40-0x0000000189B78D60
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF732A */, bool useObjectPool = false /* Metadata: 0x00AF732E */) => default; // 0x00000001857983F0-0x00000001857988F0
	[BlackList] // 0x0000000189B80230-0x0000000189B80270
	// [XID] // 0x0000000189B80230-0x0000000189B80270
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000185797DE0-0x00000001857980B0
	// [XID] // 0x0000000189B8A9D0-0x0000000189B8A9F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001857994C0-0x0000000185799960
	[BlackList] // 0x0000000189B91F60-0x0000000189B91FA0
	// [XID] // 0x0000000189B91F60-0x0000000189B91FA0
	public virtual void AutoAllocTypeFields() {} // 0x00000001857980B0-0x0000000185798150
	[BlackList] // 0x0000000189B9C4C0-0x0000000189B9C500
	// [XID] // 0x0000000189B9C4C0-0x0000000189B9C500
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185798150-0x0000000185798340
	[BlackList] // 0x0000000189BA69C0-0x0000000189BA6A00
	// [XID] // 0x0000000189BA69C0-0x0000000189BA6A00
	public virtual void ReturnToObjectPool() {} // 0x0000000185799DB0-0x0000000185799E50
	[BlackList] // 0x0000000189BB1090-0x0000000189BB10D0
	// [XID] // 0x0000000189BB1090-0x0000000189BB10D0
	public virtual void OnPoolAllocated() {} // 0x0000000185799C30-0x0000000185799CD0
	[BlackList] // 0x0000000189BBB350-0x0000000189BBB390
	// [XID] // 0x0000000189BBB350-0x0000000189BBB390
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185799B90-0x0000000185799C30
}

