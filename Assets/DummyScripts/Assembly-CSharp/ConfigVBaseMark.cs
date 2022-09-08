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
public class ConfigVBaseMark : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18555
{
	// Fields
	private MarkViewType _type; // 0x10
	private string _resPath; // 0x18

	// Properties
	public MarkViewType type { /* [XID] */ /* 0x0000000189AFB0E0-0x0000000189AFB100 */ get => default; /* [XID] */ /* 0x0000000189AC82F0-0x0000000189AC8310 */ private set {} } // 0x0000000182ED0E50-0x0000000182ED0EF0 0x0000000182ED0870-0x0000000182ED0920
	public string resPath { /* [XID] */ /* 0x0000000189ACFA70-0x0000000189ACFA90 */ get => default; /* [XID] */ /* 0x0000000189AD7780-0x0000000189AD77A0 */ private set {} } // 0x0000000182ED0B60-0x0000000182ED0C00 0x0000000182ED0EF0-0x0000000182ED0FA0

	// Constructors
	public ConfigVBaseMark() {} // 0x0000000182ED1040-0x0000000182ED10A0

	// Methods
	// [XID] // 0x0000000189ADF210-0x0000000189ADF230
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182ED0C00-0x0000000182ED0D10
	// [XID] // 0x0000000189AE6AB0-0x0000000189AE6AD0
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182ED07A0-0x0000000182ED0870
	// [XID] // 0x0000000189AEE560-0x0000000189AEE580
	public virtual ConfigVBaseMark Clone(bool useObjectPool = false /* Metadata: 0x00AFA3C1 */) => default; // 0x0000000182ED04C0-0x0000000182ED05A0
	// [XID] // 0x0000000189AF5B10-0x0000000189AF5B30
	public virtual int GetHashNum() => default; // 0x0000000182ECF740-0x0000000182ECF810
	// [XID] // 0x0000000189AFD010-0x0000000189AFD030
	public virtual void InitEmpty() {} // 0x0000000182ED0000-0x0000000182ED00D0
	[BlackList] // 0x0000000189B047E0-0x0000000189B04820
	// [XID] // 0x0000000189B047E0-0x0000000189B04820
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000182ECFAB0-0x0000000182ECFE30
	// [XID] // 0x0000000189B0F010-0x0000000189B0F030
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182ECF070-0x0000000182ECF330
	[BlackList] // 0x0000000189B16310-0x0000000189B16350
	// [XID] // 0x0000000189B16310-0x0000000189B16350
	public static ConfigVBaseMark ParseFromJson(JSONNode node) => default; // 0x0000000182ED05A0-0x0000000182ED07A0
	// [XID] // 0x0000000189B20A30-0x0000000189B20A50
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA3C2 */, bool useObjectPool = false /* Metadata: 0x00AFA3C6 */) => default; // 0x0000000182ED01C0-0x0000000182ED04C0
	// [XID] // 0x0000000189B28110-0x0000000189B28130
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA3C7 */, bool useObjectPool = false /* Metadata: 0x00AFA3CB */) => default; // 0x0000000182ECF810-0x0000000182ECFAB0
	// [XID] // 0x0000000189B2F490-0x0000000189B2F4B0
	public static ConfigVBaseMark ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA3CC */, bool useObjectPool = false /* Metadata: 0x00AFA3D0 */) => default; // 0x0000000182ECFE30-0x0000000182ED0000
	[BlackList] // 0x0000000189B36D90-0x0000000189B36DD0
	// [XID] // 0x0000000189B36D90-0x0000000189B36DD0
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000182ECF330-0x0000000182ECF600
	// [XID] // 0x0000000189B41830-0x0000000189B41850
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182ED0920-0x0000000182ED0B60
	[BlackList] // 0x0000000189B49200-0x0000000189B49240
	// [XID] // 0x0000000189B49200-0x0000000189B49240
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182ED00D0-0x0000000182ED01C0
	[BlackList] // 0x0000000189B53720-0x0000000189B53760
	// [XID] // 0x0000000189B53720-0x0000000189B53760
	public virtual void AutoAllocTypeFields() {} // 0x0000000182ECF600-0x0000000182ECF6A0
	[BlackList] // 0x0000000189B5E120-0x0000000189B5E160
	// [XID] // 0x0000000189B5E120-0x0000000189B5E160
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182ECF6A0-0x0000000182ECF740
	[BlackList] // 0x0000000189B68800-0x0000000189B68840
	// [XID] // 0x0000000189B68800-0x0000000189B68840
	public virtual void ReturnToObjectPool() {} // 0x0000000182ED0FA0-0x0000000182ED1040
	[BlackList] // 0x0000000189B72D10-0x0000000189B72D50
	// [XID] // 0x0000000189B72D10-0x0000000189B72D50
	public virtual void OnPoolAllocated() {} // 0x0000000182ED0DB0-0x0000000182ED0E50
	[BlackList] // 0x0000000189B7D0A0-0x0000000189B7D0E0
	// [XID] // 0x0000000189B7D0A0-0x0000000189B7D0E0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182ED0D10-0x0000000182ED0DB0
}

