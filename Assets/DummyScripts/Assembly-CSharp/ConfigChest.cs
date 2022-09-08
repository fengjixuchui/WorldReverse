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
public class ConfigChest : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17982
{
	// Fields
	private bool _bornLockedByAbility; // 0x10
	private string _openEffect; // 0x18

	// Properties
	public bool bornLockedByAbility { /* [XID] */ /* 0x00000001898D65C0-0x00000001898D65E0 */ get => default; /* [XID] */ /* 0x00000001898DE260-0x00000001898DE280 */ private set {} } // 0x0000000181527F90-0x0000000181528030 0x00000001815282D0-0x0000000181528380
	public string openEffect { /* [XID] */ /* 0x00000001898E59E0-0x00000001898E5A00 */ get => default; /* [XID] */ /* 0x00000001898ED3E0-0x00000001898ED400 */ private set {} } // 0x0000000181527EF0-0x0000000181527F90 0x0000000181528F60-0x0000000181529010

	// Constructors
	public ConfigChest() {} // 0x00000001815290B0-0x0000000181529120

	// Methods
	// [XID] // 0x00000001898F4C20-0x00000001898F4C40
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181528D10-0x0000000181528E20
	// [XID] // 0x00000001898FC3F0-0x00000001898FC410
	public void InitEmpty() {} // 0x0000000181528700-0x00000001815287D0
	[BlackList] // 0x0000000189903EB0-0x0000000189903EF0
	// [XID] // 0x0000000189903EB0-0x0000000189903EF0
	public bool FromJson(JSONNode node) => default; // 0x0000000181528380-0x0000000181528700
	// [XID] // 0x000000018990E6B0-0x000000018990E6D0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181527830-0x0000000181527AE0
	// [XID] // 0x0000000189915D20-0x0000000189915D40
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8593 */, bool useObjectPool = false /* Metadata: 0x00AF8597 */) => default; // 0x00000001815287D0-0x0000000181528AD0
	// [XID] // 0x000000018991D790-0x000000018991D7B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8598 */, bool useObjectPool = false /* Metadata: 0x00AF859C */) => default; // 0x0000000181528030-0x00000001815282D0
	[BlackList] // 0x0000000189924FA0-0x0000000189924FE0
	// [XID] // 0x0000000189924FA0-0x0000000189924FE0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181527AE0-0x0000000181527DB0
	// [XID] // 0x000000018992F560-0x000000018992F580
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181528AD0-0x0000000181528D10
	[BlackList] // 0x00000001899369B0-0x00000001899369F0
	// [XID] // 0x00000001899369B0-0x00000001899369F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181527DB0-0x0000000181527E50
	[BlackList] // 0x00000001899410A0-0x00000001899410E0
	// [XID] // 0x00000001899410A0-0x00000001899410E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181527E50-0x0000000181527EF0
	[BlackList] // 0x000000018994BA20-0x000000018994BA60
	// [XID] // 0x000000018994BA20-0x000000018994BA60
	public virtual void ReturnToObjectPool() {} // 0x0000000181529010-0x00000001815290B0
	[BlackList] // 0x0000000189956000-0x0000000189956040
	// [XID] // 0x0000000189956000-0x0000000189956040
	public virtual void OnPoolAllocated() {} // 0x0000000181528EC0-0x0000000181528F60
	[BlackList] // 0x0000000189960920-0x0000000189960960
	// [XID] // 0x0000000189960920-0x0000000189960960
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181528E20-0x0000000181528EC0
}

