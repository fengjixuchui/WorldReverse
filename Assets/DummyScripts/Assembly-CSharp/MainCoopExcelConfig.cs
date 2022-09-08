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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class MainCoopExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15456
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected string _mainCoopCfg; // 0x18
	protected SimpleSafeUInt32 mainQuestSeriesRawNum; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189B586F0-0x0000000189B58710 */ get => default; /* [XID] */ /* 0x0000000189B60080-0x0000000189B600A0 */ protected set {} } // 0x000000018196F7C0-0x000000018196F890 0x000000018196F010-0x000000018196F0F0
	public string mainCoopCfg { /* [XID] */ /* 0x0000000189B67740-0x0000000189B67760 */ get => default; /* [XID] */ /* 0x0000000189B6E9C0-0x0000000189B6E9E0 */ protected set {} } // 0x000000018196F5E0-0x000000018196F680 0x000000018196F890-0x000000018196F940
	public uint mainQuestSeries { /* [XID] */ /* 0x0000000189B76210-0x0000000189B76230 */ get => default; /* [XID] */ /* 0x0000000189B7D780-0x0000000189B7D7A0 */ protected set {} } // 0x000000018196F940-0x000000018196FA10 0x000000018196F500-0x000000018196F5E0

	// Constructors
	public MainCoopExcelConfig() {} // 0x000000018196FAB0-0x000000018196FB10

	// Methods
	// [IDTag] // 0x0000000189B85510-0x0000000189B85550
	// [XID] // 0x0000000189B85510-0x0000000189B85550
	public virtual bool ParseFromLine(string line) => default; // 0x000000018196ED30-0x000000018196F010
	// [IDTag] // 0x0000000189B8F390-0x0000000189B8F3D0
	// [XID] // 0x0000000189B8F390-0x0000000189B8F3D0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018196EA90-0x000000018196ED30
	// [XID] // 0x0000000189B997C0-0x0000000189B997E0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1B04 */, bool useObjectPool = false /* Metadata: 0x00AF1B08 */) => default; // 0x000000018196F0F0-0x000000018196F500
	[BlackList] // 0x0000000189BA0D90-0x0000000189BA0DD0
	// [XID] // 0x0000000189BA0D90-0x0000000189BA0DD0
	public virtual void AutoAllocTypeFields() {} // 0x000000018196E900-0x000000018196E9A0
	[BlackList] // 0x0000000189BAB3E0-0x0000000189BAB420
	// [XID] // 0x0000000189BAB3E0-0x0000000189BAB420
	public virtual void AutoRecycleTypeFields() {} // 0x000000018196E9A0-0x000000018196EA90
	[BlackList] // 0x0000000189BB57B0-0x0000000189BB57F0
	// [XID] // 0x0000000189BB57B0-0x0000000189BB57F0
	public virtual void ReturnToObjectPool() {} // 0x000000018196FA10-0x000000018196FAB0
	[BlackList] // 0x0000000189BBFEB0-0x0000000189BBFEF0
	// [XID] // 0x0000000189BBFEB0-0x0000000189BBFEF0
	public virtual void OnPoolAllocated() {} // 0x000000018196F720-0x000000018196F7C0
	[BlackList] // 0x0000000189BCAE50-0x0000000189BCAE90
	// [XID] // 0x0000000189BCAE50-0x0000000189BCAE90
	public virtual void OnBeforePoolRecycled() {} // 0x000000018196F680-0x000000018196F720
}

