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
public class ConfigHitImpulse : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17675
{
	// Fields
	private HitLevel _hitLevel; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _hitImpulseX; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _hitImpulseY; // 0x20

	// Properties
	public HitLevel hitLevel { /* [XID] */ /* 0x00000001899FFB20-0x00000001899FFB40 */ get => default; /* [XID] */ /* 0x0000000189A07310-0x0000000189A07330 */ private set {} } // 0x0000000181E96030-0x0000000181E960D0 0x0000000181E95290-0x0000000181E95340
	public DynamicFloat hitImpulseX { /* [XID] */ /* 0x0000000189941B50-0x0000000189941B70 */ get => default; /* [XID] */ /* 0x0000000189A15FA0-0x0000000189A15FC0 */ private set {} } // 0x0000000181E95AF0-0x0000000181E95B90 0x0000000181E951E0-0x0000000181E95290
	public DynamicFloat hitImpulseY { /* [XID] */ /* 0x00000001899496D0-0x00000001899496F0 */ get => default; /* [XID] */ /* 0x0000000189A249F0-0x0000000189A24A10 */ private set {} } // 0x0000000181E95340-0x0000000181E953E0 0x0000000181E95F80-0x0000000181E96030

	// Constructors
	public ConfigHitImpulse() {} // 0x0000000181E96700-0x0000000181E96760

	// Methods
	// [XID] // 0x0000000189A2BFF0-0x0000000189A2C010
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181E963D0-0x0000000181E96520
	// [XID] // 0x0000000189A33740-0x0000000189A33760
	public void InitEmpty() {} // 0x0000000181E95B90-0x0000000181E95C80
	[BlackList] // 0x0000000189A3AE60-0x0000000189A3AEA0
	// [XID] // 0x0000000189A3AE60-0x0000000189A3AEA0
	public bool FromJson(JSONNode node) => default; // 0x0000000181E95770-0x0000000181E95AF0
	// [XID] // 0x0000000189A457E0-0x0000000189A45800
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181E94900-0x0000000181E94CD0
	// [XID] // 0x0000000189A4CDC0-0x0000000189A4CDE0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7743 */, bool useObjectPool = false /* Metadata: 0x00AF7747 */) => default; // 0x0000000181E95C80-0x0000000181E95F80
	// [XID] // 0x0000000189A54550-0x0000000189A54570
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7748 */, bool useObjectPool = false /* Metadata: 0x00AF774C */) => default; // 0x0000000181E953E0-0x0000000181E95770
	[BlackList] // 0x0000000189A5C060-0x0000000189A5C0A0
	// [XID] // 0x0000000189A5C060-0x0000000189A5C0A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181E94CD0-0x0000000181E94FA0
	// [XID] // 0x0000000189A66940-0x0000000189A66960
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181E960D0-0x0000000181E963D0
	[BlackList] // 0x0000000189A6E140-0x0000000189A6E180
	// [XID] // 0x0000000189A6E140-0x0000000189A6E180
	public virtual void AutoAllocTypeFields() {} // 0x0000000181E94FA0-0x0000000181E95040
	[BlackList] // 0x0000000189A78B40-0x0000000189A78B80
	// [XID] // 0x0000000189A78B40-0x0000000189A78B80
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181E95040-0x0000000181E951E0
	[BlackList] // 0x0000000189A83340-0x0000000189A83380
	// [XID] // 0x0000000189A83340-0x0000000189A83380
	public virtual void ReturnToObjectPool() {} // 0x0000000181E96660-0x0000000181E96700
	[BlackList] // 0x0000000189A8DC70-0x0000000189A8DCB0
	// [XID] // 0x0000000189A8DC70-0x0000000189A8DCB0
	public virtual void OnPoolAllocated() {} // 0x0000000181E965C0-0x0000000181E96660
	[BlackList] // 0x0000000189A984E0-0x0000000189A98520
	// [XID] // 0x0000000189A984E0-0x0000000189A98520
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181E96520-0x0000000181E965C0
}

