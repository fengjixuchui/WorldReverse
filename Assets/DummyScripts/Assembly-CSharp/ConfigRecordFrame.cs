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
public class ConfigRecordFrame : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18885
{
	// Fields
	private SimpleSafeFloat deltaTimeRawNum; // 0x10
	private SimpleSafeUInt32 frameCountRawNum; // 0x14
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigRecordActorBase[] _actors; // 0x18

	// Properties
	public float deltaTime { /* [XID] */ /* 0x00000001899B0C10-0x00000001899B0C30 */ get => default; /* [XID] */ /* 0x00000001899B7E90-0x00000001899B7EB0 */ private set {} } // 0x0000000183274FD0-0x00000001832750B0 0x0000000183274EF0-0x0000000183274FD0
	public uint frameCount { /* [XID] */ /* 0x00000001899BFAB0-0x00000001899BFAD0 */ get => default; /* [XID] */ /* 0x00000001899C7270-0x00000001899C7290 */ private set {} } // 0x00000001832749E0-0x0000000183274AB0 0x0000000183274AB0-0x0000000183274B90
	public ConfigRecordActorBase[] actors { /* [XID] */ /* 0x00000001899CE7E0-0x00000001899CE800 */ get => default; /* [XID] */ /* 0x00000001899D5ED0-0x00000001899D5EF0 */ private set {} } // 0x00000001832746E0-0x0000000183274780 0x0000000183274780-0x0000000183274830

	// Constructors
	public ConfigRecordFrame() {} // 0x0000000183275E80-0x0000000183275EE0

	// Methods
	// [XID] // 0x00000001899DD360-0x00000001899DD380
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183275B80-0x0000000183275CA0
	// [XID] // 0x00000001899E5000-0x00000001899E5020
	public void InitEmpty() {} // 0x0000000183275430-0x0000000183275560
	[BlackList] // 0x00000001899EC3B0-0x00000001899EC3F0
	// [XID] // 0x00000001899EC3B0-0x00000001899EC3F0
	public bool FromJson(JSONNode node) => default; // 0x00000001832750B0-0x0000000183275430
	// [XID] // 0x00000001899F6CF0-0x00000001899F6D10
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183273FE0-0x0000000183274410
	// [XID] // 0x00000001899FE370-0x00000001899FE390
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB271 */, bool useObjectPool = false /* Metadata: 0x00AFB275 */) => default; // 0x0000000183275560-0x0000000183275860
	// [XID] // 0x0000000189A05C70-0x0000000189A05C90
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB276 */, bool useObjectPool = false /* Metadata: 0x00AFB27A */) => default; // 0x0000000183274B90-0x0000000183274EF0
	[BlackList] // 0x0000000189A0CF80-0x0000000189A0CFC0
	// [XID] // 0x0000000189A0CF80-0x0000000189A0CFC0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183274410-0x00000001832746E0
	// [XID] // 0x0000000189A172D0-0x0000000189A172F0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183275860-0x0000000183275B80
	[BlackList] // 0x0000000189A1EA10-0x0000000189A1EA50
	// [XID] // 0x0000000189A1EA10-0x0000000189A1EA50
	public virtual void AutoAllocTypeFields() {} // 0x0000000183274830-0x00000001832748D0
	[BlackList] // 0x0000000189A28EA0-0x0000000189A28EE0
	// [XID] // 0x0000000189A28EA0-0x0000000189A28EE0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001832748D0-0x00000001832749E0
	[BlackList] // 0x0000000189A33380-0x0000000189A333C0
	// [XID] // 0x0000000189A33380-0x0000000189A333C0
	public virtual void ReturnToObjectPool() {} // 0x0000000183275DE0-0x0000000183275E80
	[BlackList] // 0x0000000189A3DD90-0x0000000189A3DDD0
	// [XID] // 0x0000000189A3DD90-0x0000000189A3DDD0
	public virtual void OnPoolAllocated() {} // 0x0000000183275D40-0x0000000183275DE0
	[BlackList] // 0x0000000189A484F0-0x0000000189A48530
	// [XID] // 0x0000000189A484F0-0x0000000189A48530
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183275CA0-0x0000000183275D40
}

