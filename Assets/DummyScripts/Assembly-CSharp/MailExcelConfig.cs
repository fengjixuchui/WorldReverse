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
public class MailExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15795
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 expireDaysRawNum; // 0x14
	protected uint _titleTextMapHash; // 0x18
	protected uint _contentTextMapHash; // 0x1C
	protected uint _senderTextMapHash; // 0x20
	protected bool _isStar; // 0x24
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x28

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189A4BA00-0x0000000189A4BA20 */ get => default; /* [XID] */ /* 0x0000000189A530E0-0x0000000189A53100 */ protected set {} } // 0x00000001848DAA50-0x00000001848DAB20 0x00000001848D9A60-0x00000001848D9B40
	public uint expireDays { /* [XID] */ /* 0x0000000189A5A8D0-0x0000000189A5A8F0 */ get => default; /* [XID] */ /* 0x0000000189A62090-0x0000000189A620B0 */ protected set {} } // 0x00000001848DA790-0x00000001848DA860 0x00000001848DAB20-0x00000001848DAC00
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x0000000189A69F30-0x0000000189A69F50 */ get => default; /* [XID] */ /* 0x0000000189A711E0-0x0000000189A71200 */ protected set {} } // 0x00000001848D8E80-0x00000001848D8F20 0x00000001848D8F20-0x00000001848D8FD0
	public string title { /* [XID] */ /* 0x0000000189A78D80-0x0000000189A78DA0 */ get => default; } // 0x00000001848DA570-0x00000001848DA6F0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint contentTextMapHash { /* [XID] */ /* 0x0000000189A802C0-0x0000000189A802E0 */ get => default; /* [XID] */ /* 0x0000000189A88020-0x0000000189A88040 */ protected set {} } // 0x00000001848DA4D0-0x00000001848DA570 0x00000001848D9B40-0x00000001848D9BF0
	public string content { /* [XID] */ /* 0x0000000189A8F8B0-0x0000000189A8F8D0 */ get => default; } // 0x00000001848DA350-0x00000001848DA4D0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint senderTextMapHash { /* [XID] */ /* 0x0000000189A96F00-0x0000000189A96F20 */ get => default; /* [XID] */ /* 0x0000000189A9E290-0x0000000189A9E2B0 */ protected set {} } // 0x00000001848D99C0-0x00000001848D9A60 0x00000001848DA860-0x00000001848DA910
	public string sender { /* [XID] */ /* 0x0000000189AA5C40-0x0000000189AA5C60 */ get => default; } // 0x00000001848D8D00-0x00000001848D8E80 
	public bool isStar { /* [XID] */ /* 0x0000000189AAD2A0-0x0000000189AAD2C0 */ get => default; /* [XID] */ /* 0x0000000189AB4C90-0x0000000189AB4CB0 */ protected set {} } // 0x00000001848DA6F0-0x00000001848DA790 0x00000001848D8FD0-0x00000001848D9080
	public uint rewardId { /* [XID] */ /* 0x0000000189ABC960-0x0000000189ABC980 */ get => default; /* [XID] */ /* 0x0000000189AC4260-0x0000000189AC4280 */ protected set {} } // 0x00000001848DA280-0x00000001848DA350 0x00000001848D8A80-0x00000001848D8B60

	// Constructors
	public MailExcelConfig() {} // 0x00000001848DACA0-0x00000001848DAD00

	// Methods
	// [IDTag] // 0x0000000189ACB770-0x0000000189ACB7B0
	// [XID] // 0x0000000189ACB770-0x0000000189ACB7B0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001848D9510-0x00000001848D99C0
	// [IDTag] // 0x0000000189AD6620-0x0000000189AD6660
	// [XID] // 0x0000000189AD6620-0x0000000189AD6660
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001848D9080-0x00000001848D9510
	// [XID] // 0x0000000189AE1060-0x0000000189AE1080
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF263E */, bool useObjectPool = false /* Metadata: 0x00AF2642 */) => default; // 0x00000001848D9BF0-0x00000001848DA280
	[BlackList] // 0x0000000189AE8410-0x0000000189AE8450
	// [XID] // 0x0000000189AE8410-0x0000000189AE8450
	public virtual void AutoAllocTypeFields() {} // 0x00000001848D8B60-0x00000001848D8C00
	[BlackList] // 0x0000000189AF3210-0x0000000189AF3250
	// [XID] // 0x0000000189AF3210-0x0000000189AF3250
	public virtual void AutoRecycleTypeFields() {} // 0x00000001848D8C00-0x00000001848D8D00
	[BlackList] // 0x0000000189AFD6D0-0x0000000189AFD710
	// [XID] // 0x0000000189AFD6D0-0x0000000189AFD710
	public virtual void ReturnToObjectPool() {} // 0x00000001848DAC00-0x00000001848DACA0
	[BlackList] // 0x0000000189B07DB0-0x0000000189B07DF0
	// [XID] // 0x0000000189B07DB0-0x0000000189B07DF0
	public virtual void OnPoolAllocated() {} // 0x00000001848DA9B0-0x00000001848DAA50
	[BlackList] // 0x0000000189B12560-0x0000000189B125A0
	// [XID] // 0x0000000189B12560-0x0000000189B125A0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001848DA910-0x00000001848DA9B0
}

