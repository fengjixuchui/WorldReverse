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
public class ConfigClimateMisc : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17648
{
	// Fields
	private SimpleSafeFloat dampingTimeRawNum; // 0x10
	private SimpleSafeFloat fadeSpeedRawNum; // 0x14

	// Properties
	public float dampingTime { /* [XID] */ /* 0x00000001899EDE40-0x00000001899EDE60 */ get => default; /* [XID] */ /* 0x00000001899F5690-0x00000001899F56B0 */ private set {} } // 0x0000000180DE0600-0x0000000180DE06E0 0x0000000180DE06E0-0x0000000180DE07C0
	public float fadeSpeed { /* [XID] */ /* 0x00000001899FCDF0-0x00000001899FCE10 */ get => default; /* [XID] */ /* 0x0000000189A04270-0x0000000189A04290 */ private set {} } // 0x0000000180DE0140-0x0000000180DE0220 0x0000000180DE07C0-0x0000000180DE08A0

	// Constructors
	public ConfigClimateMisc() {} // 0x0000000180DE0DE0-0x0000000180DE0E40

	// Methods
	// [XID] // 0x0000000189A0B9D0-0x0000000189A0B9F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000180DE0AF0-0x0000000180DE0C00
	// [XID] // 0x0000000189A13260-0x0000000189A13280
	public void InitEmpty() {} // 0x0000000180DE0220-0x0000000180DE0300
	[BlackList] // 0x0000000189A1A490-0x0000000189A1A4D0
	// [XID] // 0x0000000189A1A490-0x0000000189A1A4D0
	public bool FromJson(JSONNode node) => default; // 0x0000000180DDFDC0-0x0000000180DE0140
	// [XID] // 0x0000000189A24A10-0x0000000189A24A30
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000180DDF350-0x0000000180DDF6A0
	// [XID] // 0x0000000189A2C010-0x0000000189A2C030
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7607 */, bool useObjectPool = false /* Metadata: 0x00AF760B */) => default; // 0x0000000180DE0300-0x0000000180DE0600
	// [XID] // 0x0000000189A33760-0x0000000189A33780
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF760C */, bool useObjectPool = false /* Metadata: 0x00AF7610 */) => default; // 0x0000000180DDFAF0-0x0000000180DDFDC0
	[BlackList] // 0x0000000189A3AEA0-0x0000000189A3AEE0
	// [XID] // 0x0000000189A3AEA0-0x0000000189A3AEE0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000180DDF6A0-0x0000000180DDF970
	// [XID] // 0x0000000189A45800-0x0000000189A45820
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000180DE08A0-0x0000000180DE0AF0
	[BlackList] // 0x0000000189A4CDE0-0x0000000189A4CE20
	// [XID] // 0x0000000189A4CDE0-0x0000000189A4CE20
	public virtual void AutoAllocTypeFields() {} // 0x0000000180DDF970-0x0000000180DDFA10
	[BlackList] // 0x0000000189A57530-0x0000000189A57570
	// [XID] // 0x0000000189A57530-0x0000000189A57570
	public virtual void AutoRecycleTypeFields() {} // 0x0000000180DDFA10-0x0000000180DDFAF0
	[BlackList] // 0x0000000189A61D50-0x0000000189A61D90
	// [XID] // 0x0000000189A61D50-0x0000000189A61D90
	public virtual void ReturnToObjectPool() {} // 0x0000000180DE0D40-0x0000000180DE0DE0
	[BlackList] // 0x0000000189A6C880-0x0000000189A6C8C0
	// [XID] // 0x0000000189A6C880-0x0000000189A6C8C0
	public virtual void OnPoolAllocated() {} // 0x0000000180DE0CA0-0x0000000180DE0D40
	[BlackList] // 0x0000000189A77030-0x0000000189A77070
	// [XID] // 0x0000000189A77030-0x0000000189A77070
	public virtual void OnBeforePoolRecycled() {} // 0x0000000180DE0C00-0x0000000180DE0CA0
}

