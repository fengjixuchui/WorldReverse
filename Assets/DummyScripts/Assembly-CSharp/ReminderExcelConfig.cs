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
public class ReminderExcelConfig : IAutoAllocRecycle // TypeDefIndex: 14902
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _speakerTextMapHash; // 0x14
	protected uint _contentTextMapHash; // 0x18
	protected SimpleSafeFloat delayRawNum; // 0x1C
	protected SimpleSafeFloat showTimeRawNum; // 0x20
	protected SimpleSafeUInt32 nextReminderIdRawNum; // 0x24
	protected string _soundEffect; // 0x28
	protected ReminderStyleType _style; // 0x30
	protected bool _hasAudio; // 0x34

	// Properties
	public string mappedSpeaker { /* [XID] */ /* 0x0000000189A77570-0x0000000189A77590 */ get => default; } // 0x0000000181DA2DD0-0x0000000181DA2E80 
	public string mappedContent { /* [XID] */ /* 0x0000000189A7EE20-0x0000000189A7EE40 */ get => default; } // 0x0000000181DA3090-0x0000000181DA3140 
	public uint id { /* [XID] */ /* 0x0000000189A866D0-0x0000000189A866F0 */ get => default; /* [XID] */ /* 0x0000000189A8E2B0-0x0000000189A8E2D0 */ protected set {} } // 0x0000000181DA44C0-0x0000000181DA4590 0x0000000181DA3140-0x0000000181DA3220
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint speakerTextMapHash { /* [XID] */ /* 0x0000000189A957B0-0x0000000189A957D0 */ get => default; /* [XID] */ /* 0x0000000189A9D050-0x0000000189A9D070 */ protected set {} } // 0x0000000181DA2FF0-0x0000000181DA3090 0x0000000181DA3D90-0x0000000181DA3E40
	public string speaker { /* [XID] */ /* 0x0000000189AA4660-0x0000000189AA4680 */ get => default; } // 0x0000000181DA3F20-0x0000000181DA40A0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint contentTextMapHash { /* [XID] */ /* 0x0000000189AABD30-0x0000000189AABD50 */ get => default; /* [XID] */ /* 0x0000000189AB3680-0x0000000189AB36A0 */ protected set {} } // 0x0000000181DA3CF0-0x0000000181DA3D90 0x0000000181DA3220-0x0000000181DA32D0
	public string content { /* [XID] */ /* 0x0000000189ABB430-0x0000000189ABB450 */ get => default; } // 0x0000000181DA3B70-0x0000000181DA3CF0 
	public float delay { /* [XID] */ /* 0x0000000189AC2B40-0x0000000189AC2B60 */ get => default; /* [XID] */ /* 0x0000000189ACA1A0-0x0000000189ACA1C0 */ protected set {} } // 0x0000000181DA1D70-0x0000000181DA1E50 0x0000000181DA3E40-0x0000000181DA3F20
	public float showTime { /* [XID] */ /* 0x0000000189AD1A30-0x0000000189AD1A50 */ get => default; /* [XID] */ /* 0x0000000189AD9710-0x0000000189AD9730 */ protected set {} } // 0x0000000181DA2CF0-0x0000000181DA2DD0 0x0000000181DA42A0-0x0000000181DA4380
	public uint nextReminderId { /* [XID] */ /* 0x0000000189AE1180-0x0000000189AE11A0 */ get => default; /* [XID] */ /* 0x0000000189AE86B0-0x0000000189AE86D0 */ protected set {} } // 0x0000000181DA2E80-0x0000000181DA2F50 0x0000000181DA2030-0x0000000181DA2110
	public string soundEffect { /* [XID] */ /* 0x0000000189AF05D0-0x0000000189AF05F0 */ get => default; /* [XID] */ /* 0x0000000189AF7AA0-0x0000000189AF7AC0 */ protected set {} } // 0x0000000181DA2C50-0x0000000181DA2CF0 0x0000000181DA40A0-0x0000000181DA4150
	public ReminderStyleType style { /* [XID] */ /* 0x0000000189AFF030-0x0000000189AFF050 */ get => default; /* [XID] */ /* 0x0000000189B06880-0x0000000189B068A0 */ protected set {} } // 0x0000000181DA4150-0x0000000181DA41F0 0x0000000181DA41F0-0x0000000181DA42A0
	public bool hasAudio { /* [XID] */ /* 0x0000000189B0E010-0x0000000189B0E030 */ get => default; /* [XID] */ /* 0x0000000189B152D0-0x0000000189B152F0 */ protected set {} } // 0x0000000181DA2F50-0x0000000181DA2FF0 0x0000000181DA32D0-0x0000000181DA3380

	// Constructors
	public ReminderExcelConfig() {} // 0x0000000181DA4630-0x0000000181DA4690

	// Methods
	// [IDTag] // 0x0000000189B1CDB0-0x0000000189B1CDF0
	// [XID] // 0x0000000189B1CDB0-0x0000000189B1CDF0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181DA26B0-0x0000000181DA2C50
	// [IDTag] // 0x0000000189B27340-0x0000000189B27380
	// [XID] // 0x0000000189B27340-0x0000000189B27380
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181DA2110-0x0000000181DA26B0
	// [XID] // 0x0000000189B31790-0x0000000189B317B0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF96A */, bool useObjectPool = false /* Metadata: 0x00AEF96E */) => default; // 0x0000000181DA3380-0x0000000181DA3B70
	[BlackList] // 0x0000000189B38B30-0x0000000189B38B70
	// [XID] // 0x0000000189B38B30-0x0000000189B38B70
	public virtual void AutoAllocTypeFields() {} // 0x0000000181DA1E50-0x0000000181DA1EF0
	[BlackList] // 0x0000000189B43670-0x0000000189B436B0
	// [XID] // 0x0000000189B43670-0x0000000189B436B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181DA1EF0-0x0000000181DA2030
	[BlackList] // 0x0000000189B4DE20-0x0000000189B4DE60
	// [XID] // 0x0000000189B4DE20-0x0000000189B4DE60
	public virtual void ReturnToObjectPool() {} // 0x0000000181DA4590-0x0000000181DA4630
	[BlackList] // 0x0000000189B587F0-0x0000000189B58830
	// [XID] // 0x0000000189B587F0-0x0000000189B58830
	public virtual void OnPoolAllocated() {} // 0x0000000181DA4420-0x0000000181DA44C0
	[BlackList] // 0x0000000189B62BE0-0x0000000189B62C20
	// [XID] // 0x0000000189B62BE0-0x0000000189B62C20
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181DA4380-0x0000000181DA4420
}

