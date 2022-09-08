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
public class ConfigRecord : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18889
{
	// Fields
	private string _name; // 0x10
	private string _cameraAttachPoint; // 0x18
	private string[] _deactiveNodeList; // 0x20
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigRecordActorInfo[] _actorInfoList; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigRecordFrame[] _frameList; // 0x30
	private SimpleSafeUInt32 targetFrameRateRawNum; // 0x38

	// Properties
	public string name { /* [XID] */ /* 0x0000000189B325C0-0x0000000189B325E0 */ get => default; /* [XID] */ /* 0x0000000189B39E90-0x0000000189B39EB0 */ private set {} } // 0x0000000182AA5E20-0x0000000182AA5EC0 0x0000000182AA4EB0-0x0000000182AA4F60
	public string cameraAttachPoint { /* [XID] */ /* 0x0000000189B41790-0x0000000189B417B0 */ get => default; /* [XID] */ /* 0x0000000189B49160-0x0000000189B49180 */ private set {} } // 0x0000000182AA4E10-0x0000000182AA4EB0 0x0000000182AA4340-0x0000000182AA43F0
	public string[] deactiveNodeList { /* [XID] */ /* 0x0000000189B507C0-0x0000000189B507E0 */ get => default; /* [XID] */ /* 0x0000000189B580A0-0x0000000189B580C0 */ private set {} } // 0x0000000182AA4D70-0x0000000182AA4E10 0x0000000182AA4290-0x0000000182AA4340
	public ConfigRecordActorInfo[] actorInfoList { /* [XID] */ /* 0x0000000189B5FA00-0x0000000189B5FA20 */ get => default; /* [XID] */ /* 0x0000000189B67140-0x0000000189B67160 */ private set {} } // 0x0000000182AA4F60-0x0000000182AA5000 0x0000000182AA4940-0x0000000182AA49F0
	public ConfigRecordFrame[] frameList { /* [XID] */ /* 0x0000000189B6E3A0-0x0000000189B6E3C0 */ get => default; /* [XID] */ /* 0x0000000189B75B70-0x0000000189B75B90 */ private set {} } // 0x0000000182AA54F0-0x0000000182AA5590 0x0000000182AA5000-0x0000000182AA50B0
	public uint targetFrameRate { /* [XID] */ /* 0x0000000189B7D060-0x0000000189B7D080 */ get => default; /* [XID] */ /* 0x0000000189B84EB0-0x0000000189B84ED0 */ private set {} } // 0x0000000182AA5590-0x0000000182AA5660 0x0000000182AA41B0-0x0000000182AA4290

	// Constructors
	public ConfigRecord() {} // 0x0000000182AA5F60-0x0000000182AA5FC0

	// Methods
	// [XID] // 0x0000000189B8BC80-0x0000000189B8BCA0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182AA5B70-0x0000000182AA5CE0
	// [XID] // 0x0000000189B934B0-0x0000000189B934D0
	public void InitEmpty() {} // 0x0000000182AA50B0-0x0000000182AA51F0
	[BlackList] // 0x0000000189B9A9A0-0x0000000189B9A9E0
	// [XID] // 0x0000000189B9A9A0-0x0000000189B9A9E0
	public bool FromJson(JSONNode node) => default; // 0x0000000182AA49F0-0x0000000182AA4D70
	// [XID] // 0x0000000189BA5170-0x0000000189BA5190
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182AA36D0-0x0000000182AA3D40
	// [XID] // 0x0000000189BAC250-0x0000000189BAC270
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB28D */, bool useObjectPool = false /* Metadata: 0x00AFB291 */) => default; // 0x0000000182AA51F0-0x0000000182AA54F0
	// [XID] // 0x0000000189BB3AF0-0x0000000189BB3B10
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB292 */, bool useObjectPool = false /* Metadata: 0x00AFB296 */) => default; // 0x0000000182AA43F0-0x0000000182AA4940
	[BlackList] // 0x0000000189BBB090-0x0000000189BBB0D0
	// [XID] // 0x0000000189BBB090-0x0000000189BBB0D0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182AA3D40-0x0000000182AA4010
	// [XID] // 0x0000000189BC5C40-0x0000000189BC5C60
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182AA5660-0x0000000182AA5B70
	[BlackList] // 0x0000000189BCD6A0-0x0000000189BCD6E0
	// [XID] // 0x0000000189BCD6A0-0x0000000189BCD6E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182AA4010-0x0000000182AA40B0
	[BlackList] // 0x0000000189BD7A90-0x0000000189BD7AD0
	// [XID] // 0x0000000189BD7A90-0x0000000189BD7AD0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182AA40B0-0x0000000182AA41B0
	[BlackList] // 0x00000001895E76B0-0x00000001895E76F0
	// [XID] // 0x00000001895E76B0-0x00000001895E76F0
	public virtual void ReturnToObjectPool() {} // 0x0000000182AA5EC0-0x0000000182AA5F60
	[BlackList] // 0x00000001895F1F10-0x00000001895F1F50
	// [XID] // 0x00000001895F1F10-0x00000001895F1F50
	public virtual void OnPoolAllocated() {} // 0x0000000182AA5D80-0x0000000182AA5E20
	[BlackList] // 0x00000001895FC6F0-0x00000001895FC730
	// [XID] // 0x00000001895FC6F0-0x00000001895FC730
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182AA5CE0-0x0000000182AA5D80
}

