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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ActivityUpAvatarExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15003
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 activityIdRawNum; // 0x14
	protected uint _nameTextMapHash; // 0x18
	protected SimpleSafeUInt32[] _avatarIdList; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x00000001899DC3F0-0x00000001899DC410 */ get => default; /* [XID] */ /* 0x00000001899E3B90-0x00000001899E3BB0 */ protected set {} } // 0x0000000182651E10-0x0000000182651EE0 0x0000000182651510-0x00000001826515F0
	public uint activityId { /* [XID] */ /* 0x00000001899EB020-0x00000001899EB040 */ get => default; /* [XID] */ /* 0x00000001899F2C20-0x00000001899F2C40 */ protected set {} } // 0x0000000182651B50-0x0000000182651C20 0x0000000182651430-0x0000000182651510
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x00000001899FA2D0-0x00000001899FA2F0 */ get => default; /* [XID] */ /* 0x0000000189A01610-0x0000000189A01630 */ protected set {} } // 0x00000001826508F0-0x0000000182650990 0x0000000182651AA0-0x0000000182651B50
	public string name { /* [XID] */ /* 0x0000000189A09050-0x0000000189A09070 */ get => default; } // 0x0000000182651EE0-0x0000000182652060 
	public SimpleSafeUInt32[] avatarIdList { /* [XID] */ /* 0x0000000189A10550-0x0000000189A10570 */ get => default; /* [XID] */ /* 0x0000000189A17B70-0x0000000189A17B90 */ protected set {} } // 0x0000000182651390-0x0000000182651430 0x0000000182651C20-0x0000000182651CD0

	// Constructors
	public ActivityUpAvatarExcelConfig() {} // 0x0000000182652100-0x0000000182652160

	// Methods
	// [IDTag] // 0x0000000189A1F190-0x0000000189A1F1D0
	// [XID] // 0x0000000189A1F190-0x0000000189A1F1D0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182650990-0x0000000182650EB0
	// [IDTag] // 0x0000000189A29660-0x0000000189A296A0
	// [XID] // 0x0000000189A29660-0x0000000189A296A0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182650EB0-0x0000000182651390
	// [XID] // 0x0000000189A33BE0-0x0000000189A33C00
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFE2A */, bool useObjectPool = false /* Metadata: 0x00AEFE2E */) => default; // 0x00000001826515F0-0x0000000182651AA0
	[BlackList] // 0x0000000189A3B300-0x0000000189A3B340
	// [XID] // 0x0000000189A3B300-0x0000000189A3B340
	public virtual void AutoAllocTypeFields() {} // 0x0000000182650760-0x0000000182650800
	[BlackList] // 0x0000000189A45BE0-0x0000000189A45C20
	// [XID] // 0x0000000189A45BE0-0x0000000189A45C20
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182650800-0x00000001826508F0
	[BlackList] // 0x0000000189A50380-0x0000000189A503C0
	// [XID] // 0x0000000189A50380-0x0000000189A503C0
	public virtual void ReturnToObjectPool() {} // 0x0000000182652060-0x0000000182652100
	[BlackList] // 0x0000000189A5A9B0-0x0000000189A5A9F0
	// [XID] // 0x0000000189A5A9B0-0x0000000189A5A9F0
	public virtual void OnPoolAllocated() {} // 0x0000000182651D70-0x0000000182651E10
	[BlackList] // 0x0000000189A65620-0x0000000189A65660
	// [XID] // 0x0000000189A65620-0x0000000189A65660
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182651CD0-0x0000000182651D70
}

