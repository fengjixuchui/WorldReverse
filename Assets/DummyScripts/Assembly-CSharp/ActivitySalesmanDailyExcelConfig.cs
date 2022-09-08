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
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ActivitySalesmanDailyExcelConfig : IAutoAllocRecycle // TypeDefIndex: 14829
{
	// Fields
	private Vector3? _tracePositionCustom; // 0x10
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 dailyConfigIdRawNum; // 0x20
	protected IdCountConfig[] _costItemList; // 0x28
	protected uint _clusPosTextMapHash; // 0x30
	protected uint _npcTalkTextMapHash; // 0x34
	protected uint _IntroTextMapHash; // 0x38
	protected string _tracePosition; // 0x40

	// Properties
	public uint dailyConfigId { /* [XID] */ /* 0x0000000189B0C7B0-0x0000000189B0C7D0 */ get => default; /* [XID] */ /* 0x0000000189B13C30-0x0000000189B13C50 */ protected set {} } // 0x0000000184ED3D90-0x0000000184ED3E60 0x0000000184ED1E30-0x0000000184ED1F10
	public IdCountConfig[] costItemList { /* [XID] */ /* 0x0000000189B1B460-0x0000000189B1B480 */ get => default; /* [XID] */ /* 0x0000000189B22A50-0x0000000189B22A70 */ protected set {} } // 0x0000000184ED1CF0-0x0000000184ED1D90 0x0000000184ED2C90-0x0000000184ED2D40
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint clusPosTextMapHash { /* [XID] */ /* 0x0000000189B2A0C0-0x0000000189B2A0E0 */ get => default; /* [XID] */ /* 0x0000000189B317D0-0x0000000189B317F0 */ protected set {} } // 0x0000000184ED3760-0x0000000184ED3800 0x0000000184ED3340-0x0000000184ED33F0
	public string clusPos { /* [XID] */ /* 0x0000000189B38B90-0x0000000189B38BB0 */ get => default; } // 0x0000000184ED29C0-0x0000000184ED2B40 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint npcTalkTextMapHash { /* [XID] */ /* 0x0000000189B40580-0x0000000189B405A0 */ get => default; /* [XID] */ /* 0x0000000189B47F20-0x0000000189B47F40 */ protected set {} } // 0x0000000184ED1D90-0x0000000184ED1E30 0x0000000184ED2910-0x0000000184ED29C0
	public string npcTalk { /* [XID] */ /* 0x0000000189B4F6B0-0x0000000189B4F6D0 */ get => default; } // 0x0000000184ED3AD0-0x0000000184ED3C50 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint IntroTextMapHash { /* [XID] */ /* 0x0000000189B56F50-0x0000000189B56F70 */ get => default; /* [XID] */ /* 0x0000000189B5E8C0-0x0000000189B5E8E0 */ protected set {} } // 0x0000000184ED3800-0x0000000184ED38A0 0x0000000184ED38A0-0x0000000184ED3950
	public string Intro { /* [XID] */ /* 0x0000000189B65EC0-0x0000000189B65EE0 */ get => default; } // 0x0000000184ED3950-0x0000000184ED3AD0 
	public string tracePosition { /* [XID] */ /* 0x0000000189B6D4C0-0x0000000189B6D4E0 */ get => default; /* [XID] */ /* 0x0000000189B74AF0-0x0000000189B74B10 */ protected set {} } // 0x0000000184ED2BF0-0x0000000184ED2C90 0x0000000184ED2B40-0x0000000184ED2BF0

	// Constructors
	public ActivitySalesmanDailyExcelConfig() {} // 0x0000000184ED3F00-0x0000000184ED3F80

	// Methods
	// [XID] // 0x0000000189B050E0-0x0000000189B05100
	public Vector3 GetTracePosition() => default; // 0x0000000184ED33F0-0x0000000184ED3760
	// [IDTag] // 0x0000000189B7C130-0x0000000189B7C170
	// [XID] // 0x0000000189B7C130-0x0000000189B7C170
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184ED23C0-0x0000000184ED2910
	// [IDTag] // 0x0000000189B86BA0-0x0000000189B86BE0
	// [XID] // 0x0000000189B86BA0-0x0000000189B86BE0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184ED1F10-0x0000000184ED23C0
	// [XID] // 0x0000000189B90F90-0x0000000189B90FB0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF6D4 */, bool useObjectPool = false /* Metadata: 0x00AEF6D8 */) => default; // 0x0000000184ED2D40-0x0000000184ED3340
	[BlackList] // 0x0000000189B981C0-0x0000000189B98200
	// [XID] // 0x0000000189B981C0-0x0000000189B98200
	public virtual void AutoAllocTypeFields() {} // 0x0000000184ED1B60-0x0000000184ED1C00
	[BlackList] // 0x0000000189BA29D0-0x0000000189BA2A10
	// [XID] // 0x0000000189BA29D0-0x0000000189BA2A10
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184ED1C00-0x0000000184ED1CF0
	[BlackList] // 0x0000000189BACAF0-0x0000000189BACB30
	// [XID] // 0x0000000189BACAF0-0x0000000189BACB30
	public virtual void ReturnToObjectPool() {} // 0x0000000184ED3E60-0x0000000184ED3F00
	[BlackList] // 0x0000000189BB7070-0x0000000189BB70B0
	// [XID] // 0x0000000189BB7070-0x0000000189BB70B0
	public virtual void OnPoolAllocated() {} // 0x0000000184ED3CF0-0x0000000184ED3D90
	[BlackList] // 0x0000000189BC1F50-0x0000000189BC1F90
	// [XID] // 0x0000000189BC1F50-0x0000000189BC1F90
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184ED3C50-0x0000000184ED3CF0
}

