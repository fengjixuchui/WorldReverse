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
public class AsterAvatarUpExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15025
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 activityIdRawNum; // 0x14
	protected uint _nameTextMapHash; // 0x18
	protected SimpleSafeUInt32[] _avatarIdList; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189B43610-0x0000000189B43630 */ get => default; /* [XID] */ /* 0x0000000189B4AE50-0x0000000189B4AE70 */ protected set {} } // 0x0000000182CEB160-0x0000000182CEB230 0x0000000182CEA860-0x0000000182CEA940
	public uint activityId { /* [XID] */ /* 0x0000000189B52520-0x0000000189B52540 */ get => default; /* [XID] */ /* 0x0000000189B59E40-0x0000000189B59E60 */ protected set {} } // 0x0000000182CEAEA0-0x0000000182CEAF70 0x0000000182CEA780-0x0000000182CEA860
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189B614F0-0x0000000189B61510 */ get => default; /* [XID] */ /* 0x0000000189B68FE0-0x0000000189B69000 */ protected set {} } // 0x0000000182CE9C40-0x0000000182CE9CE0 0x0000000182CEADF0-0x0000000182CEAEA0
	public string name { /* [XID] */ /* 0x0000000189B70440-0x0000000189B70460 */ get => default; } // 0x0000000182CEB230-0x0000000182CEB3B0 
	public SimpleSafeUInt32[] avatarIdList { /* [XID] */ /* 0x0000000189B778D0-0x0000000189B778F0 */ get => default; /* [XID] */ /* 0x0000000189B7EF00-0x0000000189B7EF20 */ protected set {} } // 0x0000000182CEA6E0-0x0000000182CEA780 0x0000000182CEAF70-0x0000000182CEB020

	// Constructors
	public AsterAvatarUpExcelConfig() {} // 0x0000000182CEB450-0x0000000182CEB4B0

	// Methods
	// [IDTag] // 0x0000000189B86AA0-0x0000000189B86AE0
	// [XID] // 0x0000000189B86AA0-0x0000000189B86AE0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182CEA1C0-0x0000000182CEA6E0
	// [IDTag] // 0x0000000189B90EB0-0x0000000189B90EF0
	// [XID] // 0x0000000189B90EB0-0x0000000189B90EF0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182CE9CE0-0x0000000182CEA1C0
	// [XID] // 0x0000000189B9B1A0-0x0000000189B9B1C0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFECB */, bool useObjectPool = false /* Metadata: 0x00AEFECF */) => default; // 0x0000000182CEA940-0x0000000182CEADF0
	[BlackList] // 0x0000000189BA2950-0x0000000189BA2990
	// [XID] // 0x0000000189BA2950-0x0000000189BA2990
	public virtual void AutoAllocTypeFields() {} // 0x0000000182CE9AB0-0x0000000182CE9B50
	[BlackList] // 0x0000000189BAC9B0-0x0000000189BAC9F0
	// [XID] // 0x0000000189BAC9B0-0x0000000189BAC9F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182CE9B50-0x0000000182CE9C40
	[BlackList] // 0x0000000189BB6F70-0x0000000189BB6FB0
	// [XID] // 0x0000000189BB6F70-0x0000000189BB6FB0
	public virtual void ReturnToObjectPool() {} // 0x0000000182CEB3B0-0x0000000182CEB450
	[BlackList] // 0x0000000189BC1E70-0x0000000189BC1EB0
	// [XID] // 0x0000000189BC1E70-0x0000000189BC1EB0
	public virtual void OnPoolAllocated() {} // 0x0000000182CEB0C0-0x0000000182CEB160
	[BlackList] // 0x0000000189BCC660-0x0000000189BCC6A0
	// [XID] // 0x0000000189BCC660-0x0000000189BCC6A0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182CEB020-0x0000000182CEB0C0
}

