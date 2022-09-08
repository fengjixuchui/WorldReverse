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
public class ConfigActivityTalkScheme : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18814
{
	// Fields
	private uint _activityId; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigTalkScheme[] _talks; // 0x18

	// Properties
	public uint activityId { /* [XID] */ /* 0x0000000189AF8C40-0x0000000189AF8C60 */ get => default; /* [XID] */ /* 0x0000000189B00170-0x0000000189B00190 */ private set {} } // 0x00000001838E6430-0x00000001838E64D0 0x00000001838E5FB0-0x00000001838E6060
	public ConfigTalkScheme[] talks { /* [XID] */ /* 0x0000000189B07770-0x0000000189B07790 */ get => default; /* [XID] */ /* 0x0000000189B0EF70-0x0000000189B0EF90 */ private set {} } // 0x00000001838E5F10-0x00000001838E5FB0 0x00000001838E6740-0x00000001838E67F0

	// Constructors
	public ConfigActivityTalkScheme() {} // 0x00000001838E6AE0-0x00000001838E6B40

	// Methods
	// [XID] // 0x0000000189B16250-0x0000000189B16270
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001838E67F0-0x00000001838E6900
	// [XID] // 0x0000000189B1D9B0-0x0000000189B1D9D0
	public void InitEmpty() {} // 0x00000001838E6060-0x00000001838E6130
	[BlackList] // 0x0000000189B252A0-0x0000000189B252E0
	// [XID] // 0x0000000189B252A0-0x0000000189B252E0
	public bool FromJson(JSONNode node) => default; // 0x00000001838E5B90-0x00000001838E5F10
	// [XID] // 0x0000000189B2F430-0x0000000189B2F450
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001838E5220-0x00000001838E54D0
	// [XID] // 0x0000000189B36D30-0x0000000189B36D50
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD9D */, bool useObjectPool = false /* Metadata: 0x00AFADA1 */) => default; // 0x00000001838E6130-0x00000001838E6430
	// [XID] // 0x0000000189B3E560-0x0000000189B3E580
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFADA2 */, bool useObjectPool = false /* Metadata: 0x00AFADA6 */) => default; // 0x00000001838E58F0-0x00000001838E5B90
	[BlackList] // 0x0000000189B460C0-0x0000000189B46100
	// [XID] // 0x0000000189B460C0-0x0000000189B46100
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001838E54D0-0x00000001838E57A0
	// [XID] // 0x0000000189B50800-0x0000000189B50820
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001838E64D0-0x00000001838E6740
	[BlackList] // 0x0000000189B580E0-0x0000000189B58120
	// [XID] // 0x0000000189B580E0-0x0000000189B58120
	public virtual void AutoAllocTypeFields() {} // 0x00000001838E57A0-0x00000001838E5840
	[BlackList] // 0x0000000189B62390-0x0000000189B623D0
	// [XID] // 0x0000000189B62390-0x0000000189B623D0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001838E5840-0x00000001838E58F0
	[BlackList] // 0x0000000189B6CBA0-0x0000000189B6CBE0
	// [XID] // 0x0000000189B6CBA0-0x0000000189B6CBE0
	public virtual void ReturnToObjectPool() {} // 0x00000001838E6A40-0x00000001838E6AE0
	[BlackList] // 0x0000000189B77130-0x0000000189B77170
	// [XID] // 0x0000000189B77130-0x0000000189B77170
	public virtual void OnPoolAllocated() {} // 0x00000001838E69A0-0x00000001838E6A40
	[BlackList] // 0x0000000189B818D0-0x0000000189B81910
	// [XID] // 0x0000000189B818D0-0x0000000189B81910
	public virtual void OnBeforePoolRecycled() {} // 0x00000001838E6900-0x00000001838E69A0
}

