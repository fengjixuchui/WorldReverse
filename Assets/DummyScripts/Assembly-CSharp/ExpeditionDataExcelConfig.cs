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
public class ExpeditionDataExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15597
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 IDRawNum; // 0x10
	protected uint _nameTextMapHash; // 0x14
	protected SimpleSafeUInt32 city_idRawNum; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected ExpeditionOpenCondition[] _open_condition_vec; // 0x20
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected ExpeditionReward[] _time_reward_vec; // 0x28
	protected uint _descriptionTextMapHash; // 0x30
	protected string _picture; // 0x38
	protected SimpleSafeFloat posXRawNum; // 0x40
	protected SimpleSafeFloat posYRawNum; // 0x44

	// Properties
	public uint ID { /* [XID] */ /* 0x0000000189AE9D70-0x0000000189AE9D90 */ get => default; /* [XID] */ /* 0x0000000189AF1B70-0x0000000189AF1B90 */ protected set {} } // 0x0000000182FC7660-0x0000000182FC7730 0x0000000182FC5EE0-0x0000000182FC5FC0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189AF9310-0x0000000189AF9330 */ get => default; /* [XID] */ /* 0x0000000189B007D0-0x0000000189B007F0 */ protected set {} } // 0x0000000182FC61B0-0x0000000182FC6250 0x0000000182FC8310-0x0000000182FC83C0
	public string name { /* [XID] */ /* 0x0000000189B07E70-0x0000000189B07E90 */ get => default; } // 0x0000000182FC8730-0x0000000182FC88B0 
	public uint city_id { /* [XID] */ /* 0x0000000189B0F630-0x0000000189B0F650 */ get => default; /* [XID] */ /* 0x0000000189B16970-0x0000000189B16990 */ protected set {} } // 0x0000000182FC7730-0x0000000182FC7800 0x0000000182FC72B0-0x0000000182FC7390
	public ExpeditionOpenCondition[] open_condition_vec { /* [XID] */ /* 0x0000000189B1E010-0x0000000189B1E030 */ get => default; /* [XID] */ /* 0x0000000189B258E0-0x0000000189B25900 */ protected set {} } // 0x0000000182FC6250-0x0000000182FC62F0 0x0000000182FC78E0-0x0000000182FC7990
	public ExpeditionReward[] time_reward_vec { /* [XID] */ /* 0x0000000189B2CD70-0x0000000189B2CD90 */ get => default; /* [XID] */ /* 0x0000000189B341E0-0x0000000189B34200 */ protected set {} } // 0x0000000182FC5E40-0x0000000182FC5EE0 0x0000000182FC8180-0x0000000182FC8230
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descriptionTextMapHash { /* [XID] */ /* 0x0000000189B3BBF0-0x0000000189B3BC10 */ get => default; /* [XID] */ /* 0x0000000189B435B0-0x0000000189B435D0 */ protected set {} } // 0x0000000182FC7390-0x0000000182FC7430 0x0000000182FC8540-0x0000000182FC85F0
	public string description { /* [XID] */ /* 0x0000000189B4ADB0-0x0000000189B4ADD0 */ get => default; } // 0x0000000182FC7430-0x0000000182FC75B0 
	public string picture { /* [XID] */ /* 0x0000000189B523C0-0x0000000189B523E0 */ get => default; /* [XID] */ /* 0x0000000189B59D80-0x0000000189B59DA0 */ protected set {} } // 0x0000000182FC84A0-0x0000000182FC8540 0x0000000182FC75B0-0x0000000182FC7660
	public float posX { /* [XID] */ /* 0x0000000189B614B0-0x0000000189B614D0 */ get => default; /* [XID] */ /* 0x0000000189B68F80-0x0000000189B68FA0 */ protected set {} } // 0x0000000182FC8230-0x0000000182FC8310 0x0000000182FC62F0-0x0000000182FC63D0
	public float posY { /* [XID] */ /* 0x0000000189B70360-0x0000000189B70380 */ get => default; /* [XID] */ /* 0x0000000189B77850-0x0000000189B77870 */ protected set {} } // 0x0000000182FC7800-0x0000000182FC78E0 0x0000000182FC83C0-0x0000000182FC84A0

	// Constructors
	public ExpeditionDataExcelConfig() {} // 0x0000000182FC8950-0x0000000182FC89B0

	// Methods
	// [IDTag] // 0x0000000189B7EE60-0x0000000189B7EEA0
	// [XID] // 0x0000000189B7EE60-0x0000000189B7EEA0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182FC63D0-0x0000000182FC6BA0
	// [IDTag] // 0x0000000189B897B0-0x0000000189B897F0
	// [XID] // 0x0000000189B897B0-0x0000000189B897F0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182FC6BA0-0x0000000182FC72B0
	// [XID] // 0x0000000189B93B70-0x0000000189B93B90
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF201F */, bool useObjectPool = false /* Metadata: 0x00AF2023 */) => default; // 0x0000000182FC7990-0x0000000182FC8180
	[BlackList] // 0x0000000189B9B040-0x0000000189B9B080
	// [XID] // 0x0000000189B9B040-0x0000000189B9B080
	public virtual void AutoAllocTypeFields() {} // 0x0000000182FC5FC0-0x0000000182FC6060
	[BlackList] // 0x0000000189BA5610-0x0000000189BA5650
	// [XID] // 0x0000000189BA5610-0x0000000189BA5650
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182FC6060-0x0000000182FC61B0
	[BlackList] // 0x0000000189BAF880-0x0000000189BAF8C0
	// [XID] // 0x0000000189BAF880-0x0000000189BAF8C0
	public virtual void ReturnToObjectPool() {} // 0x0000000182FC88B0-0x0000000182FC8950
	[BlackList] // 0x0000000189BB9DE0-0x0000000189BB9E20
	// [XID] // 0x0000000189BB9DE0-0x0000000189BB9E20
	public virtual void OnPoolAllocated() {} // 0x0000000182FC8690-0x0000000182FC8730
	[BlackList] // 0x0000000189BC4AA0-0x0000000189BC4AE0
	// [XID] // 0x0000000189BC4AA0-0x0000000189BC4AE0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182FC85F0-0x0000000182FC8690
}

