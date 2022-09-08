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
public class ConfigCustomAttackShape : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17946
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCustomAttackSphere _sphere; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCustomAttackBox _box; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCustomAttackCircle _circle; // 0x20

	// Properties
	public ConfigCustomAttackSphere sphere { /* [XID] */ /* 0x000000018983C730-0x000000018983C750 */ get => default; /* [XID] */ /* 0x0000000189843EA0-0x0000000189843EC0 */ private set {} } // 0x0000000182811C70-0x0000000182811D10 0x0000000182812AB0-0x0000000182812B60
	public ConfigCustomAttackBox box { /* [XID] */ /* 0x0000000189B3F340-0x0000000189B3F360 */ get => default; /* [XID] */ /* 0x0000000189852520-0x0000000189852540 */ private set {} } // 0x00000001828122A0-0x0000000182812340 0x0000000182813650-0x0000000182813700
	public ConfigCustomAttackCircle circle { /* [XID] */ /* 0x0000000189BB8B40-0x0000000189BB8B60 */ get => default; /* [XID] */ /* 0x0000000189860FD0-0x0000000189860FF0 */ private set {} } // 0x0000000182812B60-0x0000000182812C00 0x0000000182813000-0x00000001828130B0

	// Constructors
	public ConfigCustomAttackShape() {} // 0x00000001828137A0-0x0000000182813800

	// Methods
	// [XID] // 0x00000001898687F0-0x0000000189868810
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001828133E0-0x0000000182813510
	// [XID] // 0x000000018986FC40-0x000000018986FC60
	public void InitEmpty() {} // 0x0000000182812C00-0x0000000182812D00
	[BlackList] // 0x0000000189877350-0x0000000189877390
	// [XID] // 0x0000000189877350-0x0000000189877390
	public bool FromJson(JSONNode node) => default; // 0x0000000182812730-0x0000000182812AB0
	// [XID] // 0x0000000189881960-0x0000000189881980
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182811880-0x0000000182811C70
	// [XID] // 0x0000000189888FE0-0x0000000189889000
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8459 */, bool useObjectPool = false /* Metadata: 0x00AF845D */) => default; // 0x0000000182812D00-0x0000000182813000
	// [XID] // 0x0000000189890300-0x0000000189890320
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF845E */, bool useObjectPool = false /* Metadata: 0x00AF8462 */) => default; // 0x0000000182812340-0x0000000182812730
	[BlackList] // 0x0000000189897820-0x0000000189897860
	// [XID] // 0x0000000189897820-0x0000000189897860
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182811D10-0x0000000182811FE0
	// [XID] // 0x00000001898A1DA0-0x00000001898A1DC0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001828130B0-0x00000001828133E0
	[BlackList] // 0x00000001898A9610-0x00000001898A9650
	// [XID] // 0x00000001898A9610-0x00000001898A9650
	public virtual void AutoAllocTypeFields() {} // 0x0000000182811FE0-0x0000000182812080
	[BlackList] // 0x00000001898B3A20-0x00000001898B3A60
	// [XID] // 0x00000001898B3A20-0x00000001898B3A60
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182812080-0x00000001828122A0
	[BlackList] // 0x00000001898BE3E0-0x00000001898BE420
	// [XID] // 0x00000001898BE3E0-0x00000001898BE420
	public virtual void ReturnToObjectPool() {} // 0x0000000182813700-0x00000001828137A0
	[BlackList] // 0x00000001898C8E80-0x00000001898C8EC0
	// [XID] // 0x00000001898C8E80-0x00000001898C8EC0
	public virtual void OnPoolAllocated() {} // 0x00000001828135B0-0x0000000182813650
	[BlackList] // 0x00000001898D33F0-0x00000001898D3430
	// [XID] // 0x00000001898D33F0-0x00000001898D3430
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182813510-0x00000001828135B0
}

