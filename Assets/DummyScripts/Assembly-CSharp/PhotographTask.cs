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
public class PhotographTask : IAutoAllocRecycle // TypeDefIndex: 15950
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 task_idRawNum; // 0x10
	protected SimpleSafeUInt32 sceneIDRawNum; // 0x14
	protected SimpleSafeFloat centerXRawNum; // 0x18
	protected SimpleSafeFloat centerYRawNum; // 0x1C
	protected SimpleSafeFloat centerZRawNum; // 0x20
	protected SimpleSafeFloat radiusRawNum; // 0x24
	protected string[] _targetGadgetID; // 0x28
	protected SimpleSafeFloat startTimeRawNum; // 0x30
	protected SimpleSafeFloat endTimeRawNum; // 0x34
	protected SimpleSafeUInt32 questidRawNum; // 0x38
	protected uint _finishTipsTextMapHash; // 0x3C
	protected uint _startTipsTextMapHash; // 0x40

	// Properties
	public uint task_id { /* [XID] */ /* 0x0000000189B07D30-0x0000000189B07D50 */ get => default; /* [XID] */ /* 0x0000000189B0F590-0x0000000189B0F5B0 */ protected set {} } // 0x00000001835C2D20-0x00000001835C2DF0 0x00000001835C2B00-0x00000001835C2BE0
	public uint sceneID { /* [XID] */ /* 0x0000000189B16870-0x0000000189B16890 */ get => default; /* [XID] */ /* 0x0000000189B1DF90-0x0000000189B1DFB0 */ protected set {} } // 0x00000001835C2A30-0x00000001835C2B00 0x00000001835C1550-0x00000001835C1630
	public float centerX { /* [XID] */ /* 0x0000000189B25800-0x0000000189B25820 */ get => default; /* [XID] */ /* 0x0000000189B2CD10-0x0000000189B2CD30 */ protected set {} } // 0x00000001835C2950-0x00000001835C2A30 0x00000001835C31E0-0x00000001835C32C0
	public float centerY { /* [XID] */ /* 0x0000000189B34140-0x0000000189B34160 */ get => default; /* [XID] */ /* 0x0000000189B3BAD0-0x0000000189B3BAF0 */ protected set {} } // 0x00000001835C1240-0x00000001835C1320 0x00000001835C0F30-0x00000001835C1010
	public float centerZ { /* [XID] */ /* 0x0000000189B43510-0x0000000189B43530 */ get => default; /* [XID] */ /* 0x0000000189B4ACD0-0x0000000189B4ACF0 */ protected set {} } // 0x00000001835C3030-0x00000001835C3110 0x00000001835C0E50-0x00000001835C0F30
	public float radius { /* [XID] */ /* 0x0000000189B52320-0x0000000189B52340 */ get => default; /* [XID] */ /* 0x0000000189B59CA0-0x0000000189B59CC0 */ protected set {} } // 0x00000001835C3F10-0x00000001835C3FF0 0x00000001835C4130-0x00000001835C4210
	public string[] targetGadgetID { /* [XID] */ /* 0x0000000189B613B0-0x0000000189B613D0 */ get => default; /* [XID] */ /* 0x0000000189B68E40-0x0000000189B68E60 */ protected set {} } // 0x00000001835C2BE0-0x00000001835C2C80 0x00000001835C2F80-0x00000001835C3030
	public float startTime { /* [XID] */ /* 0x0000000189B70280-0x0000000189B702A0 */ get => default; /* [XID] */ /* 0x0000000189B777B0-0x0000000189B777D0 */ protected set {} } // 0x00000001835C1630-0x00000001835C1710 0x00000001835C2870-0x00000001835C2950
	public float endTime { /* [XID] */ /* 0x0000000189B7ED80-0x0000000189B7EDA0 */ get => default; /* [XID] */ /* 0x0000000189B868E0-0x0000000189B86900 */ protected set {} } // 0x00000001835C2DF0-0x00000001835C2ED0 0x00000001835C1710-0x00000001835C17F0
	public uint questid { /* [XID] */ /* 0x0000000189B8DA50-0x0000000189B8DA70 */ get => default; /* [XID] */ /* 0x0000000189B94FD0-0x0000000189B94FF0 */ protected set {} } // 0x00000001835C3110-0x00000001835C31E0 0x00000001835C3CB0-0x00000001835C3D90
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint finishTipsTextMapHash { /* [XID] */ /* 0x0000000189B9C6E0-0x0000000189B9C700 */ get => default; /* [XID] */ /* 0x0000000189BA3D50-0x0000000189BA3D70 */ protected set {} } // 0x00000001835C2C80-0x00000001835C2D20 0x00000001835C1320-0x00000001835C13D0
	public string finishTips { /* [XID] */ /* 0x0000000189BAB280-0x0000000189BAB2A0 */ get => default; } // 0x00000001835C13D0-0x00000001835C1550 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint startTipsTextMapHash { /* [XID] */ /* 0x0000000189BB28F0-0x0000000189BB2910 */ get => default; /* [XID] */ /* 0x0000000189BB9CA0-0x0000000189BB9CC0 */ protected set {} } // 0x00000001835C17F0-0x00000001835C1890 0x00000001835C2ED0-0x00000001835C2F80
	public string startTips { /* [XID] */ /* 0x0000000189BC1CD0-0x0000000189BC1CF0 */ get => default; } // 0x00000001835C3D90-0x00000001835C3F10 

	// Constructors
	public PhotographTask() {} // 0x00000001835C42B0-0x00000001835C4310

	// Methods
	// [IDTag] // 0x0000000189BC92A0-0x0000000189BC92E0
	// [XID] // 0x0000000189BC92A0-0x0000000189BC92E0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001835C2070-0x00000001835C2870
	// [IDTag] // 0x0000000189BD3AF0-0x0000000189BD3B30
	// [XID] // 0x0000000189BD3AF0-0x0000000189BD3B30
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001835C1890-0x00000001835C2070
	// [XID] // 0x0000000189BDE400-0x0000000189BDE420
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2C06 */, bool useObjectPool = false /* Metadata: 0x00AF2C0A */) => default; // 0x00000001835C32C0-0x00000001835C3CB0
	[BlackList] // 0x00000001895EAF50-0x00000001895EAF90
	// [XID] // 0x00000001895EAF50-0x00000001895EAF90
	public virtual void AutoAllocTypeFields() {} // 0x00000001835C1010-0x00000001835C10B0
	[BlackList] // 0x00000001895F5650-0x00000001895F5690
	// [XID] // 0x00000001895F5650-0x00000001895F5690
	public virtual void AutoRecycleTypeFields() {} // 0x00000001835C10B0-0x00000001835C1240
	[BlackList] // 0x00000001895FFBB0-0x00000001895FFBF0
	// [XID] // 0x00000001895FFBB0-0x00000001895FFBF0
	public virtual void ReturnToObjectPool() {} // 0x00000001835C4210-0x00000001835C42B0
	[BlackList] // 0x000000018960A690-0x000000018960A6D0
	// [XID] // 0x000000018960A690-0x000000018960A6D0
	public virtual void OnPoolAllocated() {} // 0x00000001835C4090-0x00000001835C4130
	[BlackList] // 0x0000000189614D60-0x0000000189614DA0
	// [XID] // 0x0000000189614D60-0x0000000189614DA0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001835C3FF0-0x00000001835C4090
}

