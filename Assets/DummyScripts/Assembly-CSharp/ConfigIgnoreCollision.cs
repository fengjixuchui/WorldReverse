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
public class ConfigIgnoreCollision : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18630
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigEntityCollider[] _selfColliders; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigEntityCollider[] _targetColliders; // 0x18

	// Properties
	public ConfigEntityCollider[] selfColliders { /* [XID] */ /* 0x0000000189786540-0x0000000189786560 */ get => default; /* [XID] */ /* 0x000000018978DBB0-0x000000018978DBD0 */ private set {} } // 0x0000000182C904D0-0x0000000182C90570 0x0000000182C90910-0x0000000182C909C0
	public ConfigEntityCollider[] targetColliders { /* [XID] */ /* 0x0000000189801A50-0x0000000189801A70 */ get => default; /* [XID] */ /* 0x000000018979D530-0x000000018979D550 */ private set {} } // 0x0000000182C90870-0x0000000182C90910 0x0000000182C90EB0-0x0000000182C90F60

	// Constructors
	public ConfigIgnoreCollision() {} // 0x0000000182C91000-0x0000000182C91060

	// Methods
	// [XID] // 0x00000001897A4830-0x00000001897A4850
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182C90C60-0x0000000182C90D70
	// [XID] // 0x00000001897ABDE0-0x00000001897ABE00
	public void InitEmpty() {} // 0x0000000182C903E0-0x0000000182C904D0
	[BlackList] // 0x00000001897B3D30-0x00000001897B3D70
	// [XID] // 0x00000001897B3D30-0x00000001897B3D70
	public bool FromJson(JSONNode node) => default; // 0x0000000182C90060-0x0000000182C903E0
	// [XID] // 0x00000001897BEE30-0x00000001897BEE50
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182C8F6A0-0x0000000182C8F970
	// [XID] // 0x00000001897C6480-0x00000001897C64A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA65B */, bool useObjectPool = false /* Metadata: 0x00AFA65F */) => default; // 0x0000000182C90570-0x0000000182C90870
	// [XID] // 0x00000001897CDC40-0x00000001897CDC60
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA660 */, bool useObjectPool = false /* Metadata: 0x00AFA664 */) => default; // 0x0000000182C8FD90-0x0000000182C90060
	[BlackList] // 0x00000001897D50D0-0x00000001897D5110
	// [XID] // 0x00000001897D50D0-0x00000001897D5110
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182C8F970-0x0000000182C8FC40
	// [XID] // 0x00000001897DF910-0x00000001897DF930
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182C909C0-0x0000000182C90C60
	[BlackList] // 0x00000001897E7030-0x00000001897E7070
	// [XID] // 0x00000001897E7030-0x00000001897E7070
	public virtual void AutoAllocTypeFields() {} // 0x0000000182C8FC40-0x0000000182C8FCE0
	[BlackList] // 0x00000001897F1F10-0x00000001897F1F50
	// [XID] // 0x00000001897F1F10-0x00000001897F1F50
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182C8FCE0-0x0000000182C8FD90
	[BlackList] // 0x00000001897FC880-0x00000001897FC8C0
	// [XID] // 0x00000001897FC880-0x00000001897FC8C0
	public virtual void ReturnToObjectPool() {} // 0x0000000182C90F60-0x0000000182C91000
	[BlackList] // 0x0000000189806C90-0x0000000189806CD0
	// [XID] // 0x0000000189806C90-0x0000000189806CD0
	public virtual void OnPoolAllocated() {} // 0x0000000182C90E10-0x0000000182C90EB0
	[BlackList] // 0x0000000189811260-0x00000001898112A0
	// [XID] // 0x0000000189811260-0x00000001898112A0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182C90D70-0x0000000182C90E10
}

