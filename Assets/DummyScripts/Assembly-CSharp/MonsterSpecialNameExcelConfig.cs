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
public class MonsterSpecialNameExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15852
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 specialNameIDRawNum; // 0x10
	protected SimpleSafeUInt32 specialNameLabIDRawNum; // 0x14
	protected uint _specialNameTextMapHash; // 0x18
	protected bool _isInRandomList; // 0x1C
	protected string _desc; // 0x20

	// Properties
	public uint specialNameID { /* [XID] */ /* 0x000000018988C160-0x000000018988C180 */ get => default; /* [XID] */ /* 0x00000001898936D0-0x00000001898936F0 */ protected set {} } // 0x000000018272C2E0-0x000000018272C3B0 0x000000018272C460-0x000000018272C540
	public uint specialNameLabID { /* [XID] */ /* 0x000000018989ADF0-0x000000018989AE10 */ get => default; /* [XID] */ /* 0x00000001898A21C0-0x00000001898A21E0 */ protected set {} } // 0x000000018272BCC0-0x000000018272BD90 0x000000018272BBE0-0x000000018272BCC0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint specialNameTextMapHash { /* [XID] */ /* 0x00000001898A9910-0x00000001898A9930 */ get => default; /* [XID] */ /* 0x00000001898B1220-0x00000001898B1240 */ protected set {} } // 0x000000018272B950-0x000000018272B9F0 0x000000018272C3B0-0x000000018272C460
	public string specialName { /* [XID] */ /* 0x00000001898B8AC0-0x00000001898B8AE0 */ get => default; } // 0x000000018272C730-0x000000018272C8B0 
	public bool isInRandomList { /* [XID] */ /* 0x00000001898C0120-0x00000001898C0140 */ get => default; /* [XID] */ /* 0x00000001898C79E0-0x00000001898C7A00 */ protected set {} } // 0x000000018272B9F0-0x000000018272BA90 0x000000018272BA90-0x000000018272BB40
	public string desc { /* [XID] */ /* 0x00000001898CF170-0x00000001898CF190 */ get => default; /* [XID] */ /* 0x00000001898D6A80-0x00000001898D6AA0 */ protected set {} } // 0x000000018272BB40-0x000000018272BBE0 0x000000018272C540-0x000000018272C5F0

	// Constructors
	public MonsterSpecialNameExcelConfig() {} // 0x000000018272C950-0x000000018272C9B0

	// Methods
	// [IDTag] // 0x00000001898DE6A0-0x00000001898DE6E0
	// [XID] // 0x00000001898DE6A0-0x00000001898DE6E0
	public virtual bool ParseFromLine(string line) => default; // 0x000000018272B590-0x000000018272B950
	// [IDTag] // 0x00000001898E9180-0x00000001898E91C0
	// [XID] // 0x00000001898E9180-0x00000001898E91C0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018272B200-0x000000018272B590
	// [XID] // 0x00000001898F3820-0x00000001898F3840
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2863 */, bool useObjectPool = false /* Metadata: 0x00AF2867 */) => default; // 0x000000018272BD90-0x000000018272C2E0
	[BlackList] // 0x00000001898FAEE0-0x00000001898FAF20
	// [XID] // 0x00000001898FAEE0-0x00000001898FAF20
	public virtual void AutoAllocTypeFields() {} // 0x000000018272B070-0x000000018272B110
	[BlackList] // 0x0000000189905900-0x0000000189905940
	// [XID] // 0x0000000189905900-0x0000000189905940
	public virtual void AutoRecycleTypeFields() {} // 0x000000018272B110-0x000000018272B200
	[BlackList] // 0x0000000189910050-0x0000000189910090
	// [XID] // 0x0000000189910050-0x0000000189910090
	public virtual void ReturnToObjectPool() {} // 0x000000018272C8B0-0x000000018272C950
	[BlackList] // 0x000000018991AC50-0x000000018991AC90
	// [XID] // 0x000000018991AC50-0x000000018991AC90
	public virtual void OnPoolAllocated() {} // 0x000000018272C690-0x000000018272C730
	[BlackList] // 0x0000000189925320-0x0000000189925360
	// [XID] // 0x0000000189925320-0x0000000189925360
	public virtual void OnBeforePoolRecycled() {} // 0x000000018272C5F0-0x000000018272C690
}

