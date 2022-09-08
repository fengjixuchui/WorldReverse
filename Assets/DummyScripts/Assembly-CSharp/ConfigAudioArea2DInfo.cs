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
public class ConfigAudioArea2DInfo : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17551
{
	// Fields
	private SimpleSafeFloat leaveReverbDelayRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private AudioStateOp[] _enterReverbStates; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private AudioStateOp[] _leaveReverbStates; // 0x20

	// Properties
	public float leaveReverbDelay { /* [XID] */ /* 0x0000000189974310-0x0000000189974330 */ get => default; /* [XID] */ /* 0x000000018997BA40-0x000000018997BA60 */ private set {} } // 0x0000000181AA2920-0x0000000181AA2A00 0x0000000181AA2790-0x0000000181AA2870
	public AudioStateOp[] enterReverbStates { /* [XID] */ /* 0x000000018968C0C0-0x000000018968C0E0 */ get => default; /* [XID] */ /* 0x000000018998AD60-0x000000018998AD80 */ private set {} } // 0x0000000181AA23F0-0x0000000181AA2490 0x0000000181AA2870-0x0000000181AA2920
	public AudioStateOp[] leaveReverbStates { /* [XID] */ /* 0x0000000189657340-0x0000000189657360 */ get => default; /* [XID] */ /* 0x000000018999A3D0-0x000000018999A3F0 */ private set {} } // 0x0000000181AA12B0-0x0000000181AA1350 0x0000000181AA1B70-0x0000000181AA1C20

	// Constructors
	public ConfigAudioArea2DInfo() {} // 0x0000000181AA3030-0x0000000181AA30D0

	// Methods
	// [XID] // 0x00000001899A1A70-0x00000001899A1A90
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181AA2D30-0x0000000181AA2E50
	// [XID] // 0x00000001899A92E0-0x00000001899A9300
	public void InitEmpty() {} // 0x0000000181AA22D0-0x0000000181AA23F0
	[BlackList] // 0x00000001899B0D90-0x00000001899B0DD0
	// [XID] // 0x00000001899B0D90-0x00000001899B0DD0
	public bool FromJson(JSONNode node) => default; // 0x0000000181AA1F50-0x0000000181AA22D0
	// [XID] // 0x00000001899BB1B0-0x00000001899BB1D0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181AA1350-0x0000000181AA1720
	// [XID] // 0x00000001899C2C60-0x00000001899C2C80
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF729D */, bool useObjectPool = false /* Metadata: 0x00AF72A1 */) => default; // 0x0000000181AA2490-0x0000000181AA2790
	// [XID] // 0x00000001899CA160-0x00000001899CA180
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF72A2 */, bool useObjectPool = false /* Metadata: 0x00AF72A6 */) => default; // 0x0000000181AA1C20-0x0000000181AA1F50
	[BlackList] // 0x00000001899D19A0-0x00000001899D19E0
	// [XID] // 0x00000001899D19A0-0x00000001899D19E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181AA1720-0x0000000181AA19F0
	// [XID] // 0x00000001899DBEB0-0x00000001899DBED0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181AA2A00-0x0000000181AA2D30
	[BlackList] // 0x00000001899E3890-0x00000001899E38D0
	// [XID] // 0x00000001899E3890-0x00000001899E38D0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181AA19F0-0x0000000181AA1A90
	[BlackList] // 0x00000001899EDE80-0x00000001899EDEC0
	// [XID] // 0x00000001899EDE80-0x00000001899EDEC0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181AA1A90-0x0000000181AA1B70
	[BlackList] // 0x00000001899F8570-0x00000001899F85B0
	// [XID] // 0x00000001899F8570-0x00000001899F85B0
	public virtual void ReturnToObjectPool() {} // 0x0000000181AA2F90-0x0000000181AA3030
	[BlackList] // 0x0000000189A02BF0-0x0000000189A02C30
	// [XID] // 0x0000000189A02BF0-0x0000000189A02C30
	public virtual void OnPoolAllocated() {} // 0x0000000181AA2EF0-0x0000000181AA2F90
	[BlackList] // 0x0000000189A0D260-0x0000000189A0D2A0
	// [XID] // 0x0000000189A0D260-0x0000000189A0D2A0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181AA2E50-0x0000000181AA2EF0
}

