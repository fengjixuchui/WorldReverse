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
public class StateExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16170
{
	// Fields
	protected string _stateName; // 0x10
	protected StateType _stateType; // 0x18
	protected SimpleSafeUInt32 rankRawNum; // 0x1C

	// Properties
	public string stateName { /* [XID] */ /* 0x00000001898E78B0-0x00000001898E78D0 */ get => default; /* [XID] */ /* 0x00000001898EEFC0-0x00000001898EEFE0 */ protected set {} } // 0x0000000181C61880-0x0000000181C61920 0x0000000181C61920-0x0000000181C619D0
	public StateType stateType { /* [XID] */ /* 0x00000001898F68A0-0x00000001898F68C0 */ get => default; /* [XID] */ /* 0x00000001898FE040-0x00000001898FE060 */ protected set {} } // 0x0000000181C61230-0x0000000181C612D0 0x0000000181C620D0-0x0000000181C62180
	public uint rank { /* [XID] */ /* 0x00000001898B93B0-0x00000001898B93D0 */ get => default; /* [XID] */ /* 0x000000018990D130-0x000000018990D150 */ protected set {} } // 0x0000000181C61EC0-0x0000000181C61F90 0x0000000181C61DE0-0x0000000181C61EC0

	// Constructors
	public StateExcelConfig() {} // 0x0000000181C62220-0x0000000181C62280

	// Methods
	// [IDTag] // 0x0000000189914880-0x00000001899148C0
	// [XID] // 0x0000000189914880-0x00000001899148C0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181C612D0-0x0000000181C615C0
	// [IDTag] // 0x000000018991F080-0x000000018991F0C0
	// [XID] // 0x000000018991F080-0x000000018991F0C0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181C615C0-0x0000000181C61880
	// [XID] // 0x0000000189929B80-0x0000000189929BA0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF332B */, bool useObjectPool = false /* Metadata: 0x00AF332F */) => default; // 0x0000000181C619D0-0x0000000181C61DE0
	[BlackList] // 0x00000001899310E0-0x0000000189931120
	// [XID] // 0x00000001899310E0-0x0000000189931120
	public virtual void AutoAllocTypeFields() {} // 0x0000000181C610B0-0x0000000181C61150
	[BlackList] // 0x000000018993BA90-0x000000018993BAD0
	// [XID] // 0x000000018993BA90-0x000000018993BAD0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181C61150-0x0000000181C61230
	[BlackList] // 0x0000000189945F00-0x0000000189945F40
	// [XID] // 0x0000000189945F00-0x0000000189945F40
	public virtual void ReturnToObjectPool() {} // 0x0000000181C62180-0x0000000181C62220
	[BlackList] // 0x00000001899506F0-0x0000000189950730
	// [XID] // 0x00000001899506F0-0x0000000189950730
	public virtual void OnPoolAllocated() {} // 0x0000000181C62030-0x0000000181C620D0
	[BlackList] // 0x000000018995AC50-0x000000018995AC90
	// [XID] // 0x000000018995AC50-0x000000018995AC90
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181C61F90-0x0000000181C62030
}

