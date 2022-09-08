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
public class ConfigIK : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18121
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBoolForPlatforms _remoteMoveIK; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBoolForPlatforms _remoteClimbIK; // 0x18

	// Properties
	public ConfigBoolForPlatforms remoteMoveIK { /* [XID] */ /* 0x0000000189843DC0-0x0000000189843DE0 */ get => default; /* [XID] */ /* 0x000000018984B2F0-0x000000018984B310 */ private set {} } // 0x0000000183AD6DB0-0x0000000183AD6E50 0x0000000183AD70D0-0x0000000183AD7180
	public ConfigBoolForPlatforms remoteClimbIK { /* [XID] */ /* 0x000000018970B2D0-0x000000018970B2F0 */ get => default; /* [XID] */ /* 0x0000000189859E50-0x0000000189859E70 */ private set {} } // 0x0000000183AD65A0-0x0000000183AD6640 0x0000000183AD61D0-0x0000000183AD6280

	// Constructors
	public ConfigIK() {} // 0x0000000183AD7460-0x0000000183AD74C0

	// Methods
	// [XID] // 0x0000000189860F50-0x0000000189860F70
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183AD7180-0x0000000183AD7280
	// [XID] // 0x0000000189868750-0x0000000189868770
	public void InitEmpty() {} // 0x0000000183AD69C0-0x0000000183AD6AB0
	[BlackList] // 0x000000018986FBC0-0x000000018986FC00
	// [XID] // 0x000000018986FBC0-0x000000018986FC00
	public bool FromJson(JSONNode node) => default; // 0x0000000183AD6640-0x0000000183AD69C0
	// [XID] // 0x000000018987A790-0x000000018987A7B0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183AD59C0-0x0000000183AD5CC0
	// [XID] // 0x0000000189881920-0x0000000189881940
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8BD1 */, bool useObjectPool = false /* Metadata: 0x00AF8BD5 */) => default; // 0x0000000183AD6AB0-0x0000000183AD6DB0
	// [XID] // 0x0000000189888F20-0x0000000189888F40
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8BD6 */, bool useObjectPool = false /* Metadata: 0x00AF8BDA */) => default; // 0x0000000183AD6280-0x0000000183AD65A0
	[BlackList] // 0x0000000189890240-0x0000000189890280
	// [XID] // 0x0000000189890240-0x0000000189890280
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183AD5CC0-0x0000000183AD5F90
	// [XID] // 0x000000018989AA90-0x000000018989AAB0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183AD6E50-0x0000000183AD70D0
	[BlackList] // 0x00000001898A1D20-0x00000001898A1D60
	// [XID] // 0x00000001898A1D20-0x00000001898A1D60
	public virtual void AutoAllocTypeFields() {} // 0x0000000183AD5F90-0x0000000183AD6030
	[BlackList] // 0x00000001898AC3C0-0x00000001898AC400
	// [XID] // 0x00000001898AC3C0-0x00000001898AC400
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183AD6030-0x0000000183AD61D0
	[BlackList] // 0x00000001898B6C50-0x00000001898B6C90
	// [XID] // 0x00000001898B6C50-0x00000001898B6C90
	public virtual void ReturnToObjectPool() {} // 0x0000000183AD73C0-0x0000000183AD7460
	[BlackList] // 0x00000001898C1480-0x00000001898C14C0
	// [XID] // 0x00000001898C1480-0x00000001898C14C0
	public virtual void OnPoolAllocated() {} // 0x0000000183AD7320-0x0000000183AD73C0
	[BlackList] // 0x00000001898CBB50-0x00000001898CBB90
	// [XID] // 0x00000001898CBB50-0x00000001898CBB90
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183AD7280-0x0000000183AD7320
}

