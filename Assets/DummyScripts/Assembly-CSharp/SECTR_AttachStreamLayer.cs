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
public class SECTR_AttachStreamLayer : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18967
{
	// Fields
	private string _attachName; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private SECTR_CombineStreamPathInfo _festivalLayerPathInfo; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private SECTR_CombineStreamPathInfo _routineLayerPathInfo; // 0x20

	// Properties
	public string attachName { /* [XID] */ /* 0x0000000189B29820-0x0000000189B29840 */ get => default; /* [XID] */ /* 0x0000000189B30DB0-0x0000000189B30DD0 */ private set {} } // 0x0000000183783DE0-0x0000000183783E80 0x0000000183783550-0x0000000183783600
	public SECTR_CombineStreamPathInfo festivalLayerPathInfo { /* [XID] */ /* 0x0000000189B38470-0x0000000189B38490 */ get => default; /* [XID] */ /* 0x0000000189B3FE80-0x0000000189B3FEA0 */ private set {} } // 0x0000000183784310-0x00000001837843B0 0x0000000183784940-0x00000001837849F0
	public SECTR_CombineStreamPathInfo routineLayerPathInfo { /* [XID] */ /* 0x0000000189B476E0-0x0000000189B47700 */ get => default; /* [XID] */ /* 0x0000000189B4EE70-0x0000000189B4EE90 */ private set {} } // 0x0000000183783F70-0x0000000183784010 0x00000001837839B0-0x0000000183783A60

	// Constructors
	public SECTR_AttachStreamLayer() {} // 0x0000000183784A90-0x0000000183784AF0

	// Methods
	// [XID] // 0x0000000189B56850-0x0000000189B56870
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001837846B0-0x0000000183784800
	// [XID] // 0x0000000189B5E040-0x0000000189B5E060
	public void InitEmpty() {} // 0x0000000183783E80-0x0000000183783F70
	[BlackList] // 0x0000000189B65560-0x0000000189B655A0
	// [XID] // 0x0000000189B65560-0x0000000189B655A0
	public bool FromJson(JSONNode node) => default; // 0x0000000183783A60-0x0000000183783DE0
	// [XID] // 0x0000000189B6FC00-0x0000000189B6FC20
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183782C50-0x0000000183783030
	// [XID] // 0x0000000189B770F0-0x0000000189B77110
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB5CB */, bool useObjectPool = false /* Metadata: 0x00AFB5CF */) => default; // 0x0000000183784010-0x0000000183784310
	// [XID] // 0x0000000189B7E7C0-0x0000000189B7E7E0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB5D0 */, bool useObjectPool = false /* Metadata: 0x00AFB5D4 */) => default; // 0x0000000183783600-0x00000001837839B0
	[BlackList] // 0x0000000189B863E0-0x0000000189B86420
	// [XID] // 0x0000000189B863E0-0x0000000189B86420
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183783030-0x0000000183783300
	// [XID] // 0x0000000189B90610-0x0000000189B90630
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001837843B0-0x00000001837846B0
	[BlackList] // 0x0000000189B97A00-0x0000000189B97A40
	// [XID] // 0x0000000189B97A00-0x0000000189B97A40
	public virtual void AutoAllocTypeFields() {} // 0x0000000183783300-0x00000001837833A0
	[BlackList] // 0x0000000189BA2110-0x0000000189BA2150
	// [XID] // 0x0000000189BA2110-0x0000000189BA2150
	public virtual void AutoRecycleTypeFields() {} // 0x00000001837833A0-0x0000000183783550
	[BlackList] // 0x0000000189BAC210-0x0000000189BAC250
	// [XID] // 0x0000000189BAC210-0x0000000189BAC250
	public virtual void ReturnToObjectPool() {} // 0x00000001837849F0-0x0000000183784A90
	[BlackList] // 0x0000000189BB6910-0x0000000189BB6950
	// [XID] // 0x0000000189BB6910-0x0000000189BB6950
	public virtual void OnPoolAllocated() {} // 0x00000001837848A0-0x0000000183784940
	[BlackList] // 0x0000000189BC16A0-0x0000000189BC16E0
	// [XID] // 0x0000000189BC16A0-0x0000000189BC16E0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183784800-0x00000001837848A0
}

