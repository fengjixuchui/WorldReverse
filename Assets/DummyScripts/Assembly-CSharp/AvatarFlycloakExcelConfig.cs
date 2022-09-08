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
public class AvatarFlycloakExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15218
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 flycloakIdRawNum; // 0x10
	protected uint _nameTextMapHash; // 0x14
	protected uint _descTextMapHash; // 0x18
	protected string _prefab_path; // 0x20
	protected string _json_name; // 0x28
	protected string _icon; // 0x30
	protected SimpleSafeUInt32 material_idRawNum; // 0x38
	protected bool _hide; // 0x3C

	// Properties
	public uint flycloakId { /* [XID] */ /* 0x0000000189A4D380-0x0000000189A4D3A0 */ get => default; /* [XID] */ /* 0x0000000189A54B30-0x0000000189A54B50 */ protected set {} } // 0x0000000182E888E0-0x0000000182E889B0 0x0000000182E8A410-0x0000000182E8A4F0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189A5C640-0x0000000189A5C660 */ get => default; /* [XID] */ /* 0x0000000189A63E70-0x0000000189A63E90 */ protected set {} } // 0x0000000182E88840-0x0000000182E888E0 0x0000000182E89FF0-0x0000000182E8A0A0
	public string name { /* [XID] */ /* 0x0000000189A6B7B0-0x0000000189A6B7D0 */ get => default; } // 0x0000000182E8A4F0-0x0000000182E8A670 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189A72E80-0x0000000189A72EA0 */ get => default; /* [XID] */ /* 0x0000000189A7AA70-0x0000000189A7AA90 */ protected set {} } // 0x0000000182E89F50-0x0000000182E89FF0 0x0000000182E889B0-0x0000000182E88A60
	public string desc { /* [XID] */ /* 0x0000000189A81EF0-0x0000000189A81F10 */ get => default; } // 0x0000000182E89530-0x0000000182E896B0 
	public string prefab_path { /* [XID] */ /* 0x0000000189A899B0-0x0000000189A899D0 */ get => default; /* [XID] */ /* 0x0000000189A910D0-0x0000000189A910F0 */ protected set {} } // 0x0000000182E887A0-0x0000000182E88840 0x0000000182E896B0-0x0000000182E89760
	public string json_name { /* [XID] */ /* 0x0000000189A98A60-0x0000000189A98A80 */ get => default; /* [XID] */ /* 0x0000000189A9FD90-0x0000000189A9FDB0 */ protected set {} } // 0x0000000182E893E0-0x0000000182E89480 0x0000000182E89760-0x0000000182E89810
	public string icon { /* [XID] */ /* 0x0000000189AA7540-0x0000000189AA7560 */ get => default; /* [XID] */ /* 0x0000000189AAEBE0-0x0000000189AAEC00 */ protected set {} } // 0x0000000182E88490-0x0000000182E88530 0x0000000182E8A0A0-0x0000000182E8A150
	public uint material_id { /* [XID] */ /* 0x0000000189AB6580-0x0000000189AB65A0 */ get => default; /* [XID] */ /* 0x0000000189ABE090-0x0000000189ABE0B0 */ protected set {} } // 0x0000000182E88530-0x0000000182E88600 0x0000000182E8A150-0x0000000182E8A230
	public bool hide { /* [XID] */ /* 0x0000000189AC5BD0-0x0000000189AC5BF0 */ get => default; /* [XID] */ /* 0x0000000189ACD160-0x0000000189ACD180 */ protected set {} } // 0x0000000182E8A230-0x0000000182E8A2D0 0x0000000182E89480-0x0000000182E89530

	// Constructors
	public AvatarFlycloakExcelConfig() {} // 0x0000000182E8A710-0x0000000182E8A770

	// Methods
	// [IDTag] // 0x0000000189AD4EE0-0x0000000189AD4F20
	// [XID] // 0x0000000189AD4EE0-0x0000000189AD4F20
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182E88A60-0x0000000182E88F20
	// [IDTag] // 0x0000000189ADF970-0x0000000189ADF9B0
	// [XID] // 0x0000000189ADF970-0x0000000189ADF9B0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182E88F20-0x0000000182E893E0
	// [XID] // 0x0000000189AE9E50-0x0000000189AE9E70
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF041E */, bool useObjectPool = false /* Metadata: 0x00AF0422 */) => default; // 0x0000000182E89810-0x0000000182E89F50
	[BlackList] // 0x0000000189AF1BD0-0x0000000189AF1C10
	// [XID] // 0x0000000189AF1BD0-0x0000000189AF1C10
	public virtual void AutoAllocTypeFields() {} // 0x0000000182E88600-0x0000000182E886A0
	[BlackList] // 0x0000000189AFBE20-0x0000000189AFBE60
	// [XID] // 0x0000000189AFBE20-0x0000000189AFBE60
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182E886A0-0x0000000182E887A0
	[BlackList] // 0x0000000189B06800-0x0000000189B06840
	// [XID] // 0x0000000189B06800-0x0000000189B06840
	public virtual void ReturnToObjectPool() {} // 0x0000000182E8A670-0x0000000182E8A710
	[BlackList] // 0x0000000189B11110-0x0000000189B11150
	// [XID] // 0x0000000189B11110-0x0000000189B11150
	public virtual void OnPoolAllocated() {} // 0x0000000182E8A370-0x0000000182E8A410
	[BlackList] // 0x0000000189B1B320-0x0000000189B1B360
	// [XID] // 0x0000000189B1B320-0x0000000189B1B360
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182E8A2D0-0x0000000182E8A370
}

