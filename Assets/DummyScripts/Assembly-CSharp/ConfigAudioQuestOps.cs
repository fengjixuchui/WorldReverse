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
public class ConfigAudioQuestOps : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17616
{
	// Fields
	private SimpleSafeUInt32 questIdRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigWwiseString[] _eventsOnStart; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private AudioStateOp[] _statesOnStart; // 0x20
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigWwiseString[] _eventsOnFinish; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private AudioStateOp[] _statesOnFinish; // 0x30

	// Properties
	public uint questId { /* [XID] */ /* 0x00000001898903A0-0x00000001898903C0 */ get => default; /* [XID] */ /* 0x00000001898978C0-0x00000001898978E0 */ private set {} } // 0x00000001839521B0-0x0000000183952280 0x0000000183952600-0x00000001839526E0
	public ConfigWwiseString[] eventsOnStart { /* [XID] */ /* 0x0000000189664A90-0x0000000189664AB0 */ get => default; /* [XID] */ /* 0x00000001898A6800-0x00000001898A6820 */ private set {} } // 0x0000000183952790-0x0000000183952830 0x00000001839535C0-0x0000000183953670
	public AudioStateOp[] statesOnStart { /* [XID] */ /* 0x0000000189655CC0-0x0000000189655CE0 */ get => default; /* [XID] */ /* 0x00000001898B54B0-0x00000001898B54D0 */ private set {} } // 0x0000000183951A10-0x0000000183951AB0 0x0000000183952DB0-0x0000000183952E60
	public ConfigWwiseString[] eventsOnFinish { /* [XID] */ /* 0x00000001898BCF40-0x00000001898BCF60 */ get => default; /* [XID] */ /* 0x00000001898C46A0-0x00000001898C46C0 */ private set {} } // 0x0000000183952C70-0x0000000183952D10 0x0000000183951C50-0x0000000183951D00
	public AudioStateOp[] statesOnFinish { /* [XID] */ /* 0x00000001898CBC90-0x00000001898CBCB0 */ get => default; /* [XID] */ /* 0x00000001898D3550-0x00000001898D3570 */ private set {} } // 0x0000000183952D10-0x0000000183952DB0 0x00000001839526E0-0x0000000183952790

	// Constructors
	public ConfigAudioQuestOps() {} // 0x0000000183953710-0x0000000183953770

	// Methods
	// [XID] // 0x00000001898DACA0-0x00000001898DACC0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183953320-0x0000000183953480
	// [XID] // 0x00000001898E2B00-0x00000001898E2B20
	public void InitEmpty() {} // 0x0000000183952830-0x0000000183952970
	[BlackList] // 0x00000001898EA6B0-0x00000001898EA6F0
	// [XID] // 0x00000001898EA6B0-0x00000001898EA6F0
	public bool FromJson(JSONNode node) => default; // 0x0000000183952280-0x0000000183952600
	// [XID] // 0x00000001898F4D20-0x00000001898F4D40
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001839511C0-0x0000000183951740
	// [XID] // 0x00000001898FC470-0x00000001898FC490
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF74D9 */, bool useObjectPool = false /* Metadata: 0x00AF74DD */) => default; // 0x0000000183952970-0x0000000183952C70
	// [XID] // 0x0000000189903EF0-0x0000000189903F10
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF74DE */, bool useObjectPool = false /* Metadata: 0x00AF74E2 */) => default; // 0x0000000183951D00-0x00000001839521B0
	[BlackList] // 0x000000018990B430-0x000000018990B470
	// [XID] // 0x000000018990B430-0x000000018990B470
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183951740-0x0000000183951A10
	// [XID] // 0x0000000189915D80-0x0000000189915DA0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183952E60-0x0000000183953320
	[BlackList] // 0x000000018991D830-0x000000018991D870
	// [XID] // 0x000000018991D830-0x000000018991D870
	public virtual void AutoAllocTypeFields() {} // 0x0000000183951AB0-0x0000000183951B50
	[BlackList] // 0x0000000189927F90-0x0000000189927FD0
	// [XID] // 0x0000000189927F90-0x0000000189927FD0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183951B50-0x0000000183951C50
	[BlackList] // 0x0000000189932560-0x00000001899325A0
	// [XID] // 0x0000000189932560-0x00000001899325A0
	public virtual void ReturnToObjectPool() {} // 0x0000000183953670-0x0000000183953710
	[BlackList] // 0x000000018993CE10-0x000000018993CE50
	// [XID] // 0x000000018993CE10-0x000000018993CE50
	public virtual void OnPoolAllocated() {} // 0x0000000183953520-0x00000001839535C0
	[BlackList] // 0x0000000189947340-0x0000000189947380
	// [XID] // 0x0000000189947340-0x0000000189947380
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183953480-0x0000000183953520
}

