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
public class ConfigAIMixinSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17514
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAIMixinSetControllerCondition[] _setControllerParameterOnBeHitByEntityType; // 0x10

	// Properties
	public ConfigAIMixinSetControllerCondition[] setControllerParameterOnBeHitByEntityType { /* [XID] */ /* 0x00000001898847B0-0x00000001898847D0 */ get => default; /* [XID] */ /* 0x000000018988BE20-0x000000018988BE40 */ private set {} } // 0x0000000181746F00-0x0000000181746FA0 0x0000000181746C60-0x0000000181746D10

	// Constructors
	public ConfigAIMixinSetting() {} // 0x0000000181747260-0x00000001817472C0

	// Methods
	// [XID] // 0x0000000189BB5E90-0x0000000189BB5EB0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181746FA0-0x0000000181747080
	// [XID] // 0x000000018989ABD0-0x000000018989ABF0
	public void InitEmpty() {} // 0x0000000181746890-0x0000000181746960
	[BlackList] // 0x00000001898A1E20-0x00000001898A1E60
	// [XID] // 0x00000001898A1E20-0x00000001898A1E60
	public bool FromJson(JSONNode node) => default; // 0x0000000181746510-0x0000000181746890
	// [XID] // 0x00000001898AC5E0-0x00000001898AC600
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181745D10-0x0000000181745EF0
	// [XID] // 0x00000001898B3B60-0x00000001898B3B80
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7161 */, bool useObjectPool = false /* Metadata: 0x00AF7165 */) => default; // 0x0000000181746960-0x0000000181746C60
	// [XID] // 0x00000001898BB910-0x00000001898BB930
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7166 */, bool useObjectPool = false /* Metadata: 0x00AF716A */) => default; // 0x0000000181746300-0x0000000181746510
	[BlackList] // 0x00000001898C2BC0-0x00000001898C2C00
	// [XID] // 0x00000001898C2BC0-0x00000001898C2C00
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181745EF0-0x00000001817461C0
	// [XID] // 0x00000001898CD440-0x00000001898CD460
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181746D10-0x0000000181746F00
	[BlackList] // 0x00000001898D4DD0-0x00000001898D4E10
	// [XID] // 0x00000001898D4DD0-0x00000001898D4E10
	public virtual void AutoAllocTypeFields() {} // 0x00000001817461C0-0x0000000181746260
	[BlackList] // 0x00000001898DFAE0-0x00000001898DFB20
	// [XID] // 0x00000001898DFAE0-0x00000001898DFB20
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181746260-0x0000000181746300
	[BlackList] // 0x00000001898EA710-0x00000001898EA750
	// [XID] // 0x00000001898EA710-0x00000001898EA750
	public virtual void ReturnToObjectPool() {} // 0x00000001817471C0-0x0000000181747260
	[BlackList] // 0x00000001898F4D40-0x00000001898F4D80
	// [XID] // 0x00000001898F4D40-0x00000001898F4D80
	public virtual void OnPoolAllocated() {} // 0x0000000181747120-0x00000001817471C0
	[BlackList] // 0x00000001898FF510-0x00000001898FF550
	// [XID] // 0x00000001898FF510-0x00000001898FF550
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181747080-0x0000000181747120
}

