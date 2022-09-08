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
public class MusicEnemyCombatPhaseState : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17595
{
	// Fields
	private ConfigAICombatPhase _combatPhase; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _stateValue; // 0x18

	// Properties
	public ConfigAICombatPhase combatPhase { /* [XID] */ /* 0x0000000189AF1750-0x0000000189AF1770 */ get => default; /* [XID] */ /* 0x0000000189AF8E30-0x0000000189AF8E50 */ private set {} } // 0x0000000183C35110-0x0000000183C351B0 0x0000000183C35BD0-0x0000000183C35C80
	public ConfigWwiseString stateValue { /* [XID] */ /* 0x0000000189813620-0x0000000189813640 */ get => default; /* [XID] */ /* 0x0000000189B078F0-0x0000000189B07910 */ private set {} } // 0x0000000183C35F90-0x0000000183C36030 0x0000000183C35EE0-0x0000000183C35F90

	// Constructors
	public MusicEnemyCombatPhaseState() {} // 0x0000000183C36330-0x0000000183C36390

	// Methods
	// [XID] // 0x0000000189B0F1B0-0x0000000189B0F1D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183C36030-0x0000000183C36150
	// [XID] // 0x0000000189B164D0-0x0000000189B164F0
	public void InitEmpty() {} // 0x0000000183C35800-0x0000000183C358D0
	[BlackList] // 0x0000000189B1DC30-0x0000000189B1DC70
	// [XID] // 0x0000000189B1DC30-0x0000000189B1DC70
	public bool FromJson(JSONNode node) => default; // 0x0000000183C35480-0x0000000183C35800
	// [XID] // 0x0000000189B28310-0x0000000189B28330
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183C34990-0x0000000183C34C70
	// [XID] // 0x0000000189B2F670-0x0000000189B2F690
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7429 */, bool useObjectPool = false /* Metadata: 0x00AF742D */) => default; // 0x0000000183C358D0-0x0000000183C35BD0
	// [XID] // 0x0000000189B36F10-0x0000000189B36F30
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF742E */, bool useObjectPool = false /* Metadata: 0x00AF7432 */) => default; // 0x0000000183C351B0-0x0000000183C35480
	[BlackList] // 0x0000000189B3E7C0-0x0000000189B3E800
	// [XID] // 0x0000000189B3E7C0-0x0000000189B3E800
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183C34C70-0x0000000183C34F40
	// [XID] // 0x0000000189B49400-0x0000000189B49420
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183C35C80-0x0000000183C35EE0
	[BlackList] // 0x0000000189B50A40-0x0000000189B50A80
	// [XID] // 0x0000000189B50A40-0x0000000189B50A80
	public virtual void AutoAllocTypeFields() {} // 0x0000000183C34F40-0x0000000183C34FE0
	[BlackList] // 0x0000000189B5B110-0x0000000189B5B150
	// [XID] // 0x0000000189B5B110-0x0000000189B5B150
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183C34FE0-0x0000000183C35110
	[BlackList] // 0x0000000189B65900-0x0000000189B65940
	// [XID] // 0x0000000189B65900-0x0000000189B65940
	public virtual void ReturnToObjectPool() {} // 0x0000000183C36290-0x0000000183C36330
	[BlackList] // 0x0000000189B6FEE0-0x0000000189B6FF20
	// [XID] // 0x0000000189B6FEE0-0x0000000189B6FF20
	public virtual void OnPoolAllocated() {} // 0x0000000183C361F0-0x0000000183C36290
	[BlackList] // 0x0000000189B7A470-0x0000000189B7A4B0
	// [XID] // 0x0000000189B7A470-0x0000000189B7A4B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183C36150-0x0000000183C361F0
}

