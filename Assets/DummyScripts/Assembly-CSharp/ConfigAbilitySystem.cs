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
public class ConfigAbilitySystem : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16312
{
	// Fields
	private bool _shouldPreActive; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityTask[] _tasks; // 0x18

	// Properties
	public bool shouldPreActive { /* [XID] */ /* 0x000000018995C2A0-0x000000018995C2C0 */ get => default; /* [XID] */ /* 0x0000000189963CC0-0x0000000189963CE0 */ private set {} } // 0x000000018309F020-0x000000018309F0C0 0x000000018309F0C0-0x000000018309F170
	public ConfigAbilityTask[] tasks { /* [XID] */ /* 0x000000018996B2B0-0x000000018996B2D0 */ get => default; /* [XID] */ /* 0x0000000189972D50-0x0000000189972D70 */ private set {} } // 0x000000018309EC80-0x000000018309ED20 0x000000018309EB00-0x000000018309EBB0

	// Constructors
	public ConfigAbilitySystem() {} // 0x000000018309F6D0-0x000000018309F740

	// Methods
	// [XID] // 0x000000018997A5F0-0x000000018997A610
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018309F3E0-0x000000018309F4F0
	// [XID] // 0x0000000189981F60-0x0000000189981F80
	public void InitEmpty() {} // 0x000000018309EBB0-0x000000018309EC80
	[BlackList] // 0x0000000189989800-0x0000000189989840
	// [XID] // 0x0000000189989800-0x0000000189989840
	public bool FromJson(JSONNode node) => default; // 0x000000018309E780-0x000000018309EB00
	// [XID] // 0x0000000189994330-0x0000000189994350
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018309DE10-0x000000018309E0C0
	// [XID] // 0x000000018999BB40-0x000000018999BB60
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3752 */, bool useObjectPool = false /* Metadata: 0x00AF3756 */) => default; // 0x000000018309ED20-0x000000018309F020
	// [XID] // 0x00000001899A3310-0x00000001899A3330
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3757 */, bool useObjectPool = false /* Metadata: 0x00AF375B */) => default; // 0x000000018309E4E0-0x000000018309E780
	[BlackList] // 0x00000001899AAE60-0x00000001899AAEA0
	// [XID] // 0x00000001899AAE60-0x00000001899AAEA0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018309E0C0-0x000000018309E390
	// [XID] // 0x00000001899B5520-0x00000001899B5540
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018309F170-0x000000018309F3E0
	[BlackList] // 0x00000001899BCCF0-0x00000001899BCD30
	// [XID] // 0x00000001899BCCF0-0x00000001899BCD30
	public virtual void AutoAllocTypeFields() {} // 0x000000018309E390-0x000000018309E430
	[BlackList] // 0x00000001899C7570-0x00000001899C75B0
	// [XID] // 0x00000001899C7570-0x00000001899C75B0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018309E430-0x000000018309E4E0
	[BlackList] // 0x00000001899D1B80-0x00000001899D1BC0
	// [XID] // 0x00000001899D1B80-0x00000001899D1BC0
	public virtual void ReturnToObjectPool() {} // 0x000000018309F630-0x000000018309F6D0
	[BlackList] // 0x00000001899DC110-0x00000001899DC150
	// [XID] // 0x00000001899DC110-0x00000001899DC150
	public virtual void OnPoolAllocated() {} // 0x000000018309F590-0x000000018309F630
	[BlackList] // 0x00000001899E6AB0-0x00000001899E6AF0
	// [XID] // 0x00000001899E6AB0-0x00000001899E6AF0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018309F4F0-0x000000018309F590
}

