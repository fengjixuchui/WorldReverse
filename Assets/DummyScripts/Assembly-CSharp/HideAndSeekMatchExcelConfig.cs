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
public class HideAndSeekMatchExcelConfig : MatchLimitExcelConfig, IAutoAllocRecycle // TypeDefIndex: 15126
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected uint _titleTextMapHash; // 0x20
	protected uint _unlockTipsTextMapHash; // 0x24
	protected uint _dscTextMapHash; // 0x28
	protected byte _mapIconPathHashPre; // 0x2C
	protected uint _mapIconPathHashSuffix; // 0x30
	protected byte _mapSmallIconPathHashPre; // 0x34
	protected uint _mapSmallIconPathHashSuffix; // 0x38
	protected SimpleSafeUInt32 groupIdRawNum; // 0x3C
	protected SimpleSafeUInt32[] _transportPointList; // 0x40
	protected SimpleSafeUInt32[] _durationList; // 0x48
	protected SimpleSafeUInt32 galleryIDRawNum; // 0x50

	// Properties
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x000000018987C160-0x000000018987C180 */ get => default; /* [XID] */ /* 0x00000001898832F0-0x0000000189883310 */ protected set {} } // 0x00000001834F5D70-0x00000001834F5E10 0x00000001834F5E70-0x00000001834F5F20
	public string title { /* [XID] */ /* 0x000000018988AA50-0x000000018988AA70 */ get => default; } // 0x00000001834F8A60-0x00000001834F8BE0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint unlockTipsTextMapHash { /* [XID] */ /* 0x0000000189891F60-0x0000000189891F80 */ get => default; /* [XID] */ /* 0x00000001898998F0-0x0000000189899910 */ protected set {} } // 0x00000001834F7AA0-0x00000001834F7B40 0x00000001834F7FD0-0x00000001834F8080
	public string unlockTips { /* [XID] */ /* 0x00000001898A09D0-0x00000001898A09F0 */ get => default; } // 0x00000001834F5BF0-0x00000001834F5D70 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint dscTextMapHash { /* [XID] */ /* 0x00000001898A8090-0x00000001898A80B0 */ get => default; /* [XID] */ /* 0x00000001898AFBF0-0x00000001898AFC10 */ protected set {} } // 0x00000001834F8BE0-0x00000001834F8C80 0x00000001834F8E40-0x00000001834F8EF0
	public string dsc { /* [XID] */ /* 0x00000001898B70F0-0x00000001898B7110 */ get => default; } // 0x00000001834F9150-0x00000001834F92D0 
	public byte mapIconPathHashPre { /* [XID] */ /* 0x00000001898BE860-0x00000001898BE880 */ get => default; /* [XID] */ /* 0x00000001898C6030-0x00000001898C6050 */ protected set {} } // 0x00000001834F5900-0x00000001834F59A0 0x00000001834F6090-0x00000001834F6140
	public uint mapIconPathHashSuffix { /* [XID] */ /* 0x00000001898CD780-0x00000001898CD7A0 */ get => default; /* [XID] */ /* 0x00000001898D5310-0x00000001898D5330 */ protected set {} } // 0x00000001834F7A00-0x00000001834F7AA0 0x00000001834F8D90-0x00000001834F8E40
	public ulong mapIconPathHash { /* [XID] */ /* 0x00000001898DCBF0-0x00000001898DCC10 */ get => default; } // 0x00000001834F5F20-0x00000001834F5FF0 
	public byte mapSmallIconPathHashPre { /* [XID] */ /* 0x00000001898E4620-0x00000001898E4640 */ get => default; /* [XID] */ /* 0x00000001898EC050-0x00000001898EC070 */ protected set {} } // 0x00000001834F6140-0x00000001834F61E0 0x00000001834F90A0-0x00000001834F9150
	public uint mapSmallIconPathHashSuffix { /* [XID] */ /* 0x00000001898F38C0-0x00000001898F38E0 */ get => default; /* [XID] */ /* 0x00000001898FAFE0-0x00000001898FB000 */ protected set {} } // 0x00000001834F7CC0-0x00000001834F7D60 0x00000001834F8C80-0x00000001834F8D30
	public ulong mapSmallIconPathHash { /* [XID] */ /* 0x0000000189902AC0-0x0000000189902AE0 */ get => default; } // 0x00000001834F5830-0x00000001834F5900 
	public uint groupId { /* [XID] */ /* 0x000000018990A0A0-0x000000018990A0C0 */ get => default; /* [XID] */ /* 0x00000001899119A0-0x00000001899119C0 */ protected set {} } // 0x00000001834F8EF0-0x00000001834F8FC0 0x00000001834F8FC0-0x00000001834F90A0
	public SimpleSafeUInt32[] transportPointList { /* [XID] */ /* 0x0000000189919580-0x00000001899195A0 */ get => default; /* [XID] */ /* 0x0000000189920AD0-0x0000000189920AF0 */ protected set {} } // 0x00000001834F5FF0-0x00000001834F6090 0x00000001834F61E0-0x00000001834F6290
	public SimpleSafeUInt32[] durationList { /* [XID] */ /* 0x00000001899284D0-0x00000001899284F0 */ get => default; /* [XID] */ /* 0x000000018992F9A0-0x000000018992F9C0 */ protected set {} } // 0x00000001834F7B40-0x00000001834F7BE0 0x00000001834F7F20-0x00000001834F7FD0
	public uint galleryID { /* [XID] */ /* 0x0000000189936F10-0x0000000189936F30 */ get => default; /* [XID] */ /* 0x000000018993EA90-0x000000018993EAB0 */ protected set {} } // 0x00000001834F7DF0-0x00000001834F7EC0 0x00000001834F7BE0-0x00000001834F7CC0

	// Constructors
	public HideAndSeekMatchExcelConfig() {} // 0x00000001834F9370-0x00000001834F93D0

	// Methods
	// [IDTag] // 0x0000000189946120-0x0000000189946160
	// [XID] // 0x0000000189946120-0x0000000189946160
	public virtual bool ParseFromLine(string line) => default; // 0x00000001834F6DE0-0x00000001834F7A00
	// [IDTag] // 0x00000001899508D0-0x0000000189950910
	// [XID] // 0x00000001899508D0-0x0000000189950910
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001834F6290-0x00000001834F6DE0
	// [XID] // 0x000000018995AD90-0x000000018995ADB0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0187 */, bool useObjectPool = false /* Metadata: 0x00AF018B */) => default; // 0x00000001834F8080-0x00000001834F8A60
	[BlackList] // 0x00000001899629D0-0x0000000189962A10
	// [XID] // 0x00000001899629D0-0x0000000189962A10
	public override void AutoAllocTypeFields() {} // 0x00000001834F59A0-0x00000001834F5A40
	[BlackList] // 0x000000018996CE50-0x000000018996CE90
	// [XID] // 0x000000018996CE50-0x000000018996CE90
	public override void AutoRecycleTypeFields() {} // 0x00000001834F5A40-0x00000001834F5B50
	[BlackList] // 0x0000000189977980-0x00000001899779C0
	// [XID] // 0x0000000189977980-0x00000001899779C0
	public override void ReturnToObjectPool() {} // 0x00000001834F92D0-0x00000001834F9370
}

