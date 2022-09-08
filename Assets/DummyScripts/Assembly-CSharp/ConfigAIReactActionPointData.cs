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
public class ConfigAIReactActionPointData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17432
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAIPickActionPointCriteria[] _reactList; // 0x10

	// Properties
	public ConfigAIPickActionPointCriteria[] reactList { /* [XID] */ /* 0x0000000189B23F00-0x0000000189B23F20 */ get => default; /* [XID] */ /* 0x0000000189B2B270-0x0000000189B2B290 */ private set {} } // 0x0000000183B29D20-0x0000000183B29DC0 0x0000000183B29DC0-0x0000000183B29E70

	// Constructors
	public ConfigAIReactActionPointData() {} // 0x0000000183B2A320-0x0000000183B2A380

	// Methods
	// [XID] // 0x0000000189B32860-0x0000000189B32880
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183B2A060-0x0000000183B2A140
	// [XID] // 0x0000000189B3A170-0x0000000189B3A190
	public void InitEmpty() {} // 0x0000000183B29950-0x0000000183B29A20
	[BlackList] // 0x0000000189B41AB0-0x0000000189B41AF0
	// [XID] // 0x0000000189B41AB0-0x0000000189B41AF0
	public bool FromJson(JSONNode node) => default; // 0x0000000183B295D0-0x0000000183B29950
	// [XID] // 0x0000000189B4C340-0x0000000189B4C360
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183B28DD0-0x0000000183B28FB0
	// [XID] // 0x0000000189B53900-0x0000000189B53920
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E6D */, bool useObjectPool = false /* Metadata: 0x00AF6E71 */) => default; // 0x0000000183B29A20-0x0000000183B29D20
	// [XID] // 0x0000000189B5B1D0-0x0000000189B5B1F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6E72 */, bool useObjectPool = false /* Metadata: 0x00AF6E76 */) => default; // 0x0000000183B293C0-0x0000000183B295D0
	[BlackList] // 0x0000000189B62660-0x0000000189B626A0
	// [XID] // 0x0000000189B62660-0x0000000189B626A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183B28FB0-0x0000000183B29280
	// [XID] // 0x0000000189B6CF00-0x0000000189B6CF20
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183B29E70-0x0000000183B2A060
	[BlackList] // 0x0000000189B74690-0x0000000189B746D0
	// [XID] // 0x0000000189B74690-0x0000000189B746D0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183B29280-0x0000000183B29320
	[BlackList] // 0x0000000189B7EA00-0x0000000189B7EA40
	// [XID] // 0x0000000189B7EA00-0x0000000189B7EA40
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183B29320-0x0000000183B293C0
	[BlackList] // 0x0000000189B89390-0x0000000189B893D0
	// [XID] // 0x0000000189B89390-0x0000000189B893D0
	public virtual void ReturnToObjectPool() {} // 0x0000000183B2A280-0x0000000183B2A320
	[BlackList] // 0x0000000189B936B0-0x0000000189B936F0
	// [XID] // 0x0000000189B936B0-0x0000000189B936F0
	public virtual void OnPoolAllocated() {} // 0x0000000183B2A1E0-0x0000000183B2A280
	[BlackList] // 0x0000000189B9D940-0x0000000189B9D980
	// [XID] // 0x0000000189B9D940-0x0000000189B9D980
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183B2A140-0x0000000183B2A1E0
}

