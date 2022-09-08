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
public class TriggerExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16090
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 sceneIdRawNum; // 0x14
	protected SimpleSafeUInt32 groupIdRawNum; // 0x18
	protected string _triggerName; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189605D50-0x0000000189605D70 */ get => default; /* [XID] */ /* 0x000000018960D580-0x000000018960D5A0 */ protected set {} } // 0x0000000183CD1510-0x0000000183CD15E0 0x0000000183CD0AE0-0x0000000183CD0BC0
	public uint sceneId { /* [XID] */ /* 0x0000000189614CE0-0x0000000189614D00 */ get => default; /* [XID] */ /* 0x000000018961C580-0x000000018961C5A0 */ protected set {} } // 0x0000000183CD0BC0-0x0000000183CD0C90 0x0000000183CD1140-0x0000000183CD1220
	public uint groupId { /* [XID] */ /* 0x0000000189623A40-0x0000000189623A60 */ get => default; /* [XID] */ /* 0x000000018962B260-0x000000018962B280 */ protected set {} } // 0x0000000183CD1220-0x0000000183CD12F0 0x0000000183CD12F0-0x0000000183CD13D0
	public string triggerName { /* [XID] */ /* 0x0000000189632A40-0x0000000189632A60 */ get => default; /* [XID] */ /* 0x000000018963A510-0x000000018963A530 */ protected set {} } // 0x0000000183CD0190-0x0000000183CD0230 0x0000000183CD0A30-0x0000000183CD0AE0

	// Constructors
	public TriggerExcelConfig() {} // 0x0000000183CD1680-0x0000000183CD16E0

	// Methods
	// [IDTag] // 0x0000000189641B60-0x0000000189641BA0
	// [XID] // 0x0000000189641B60-0x0000000189641BA0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183CD06E0-0x0000000183CD0A30
	// [IDTag] // 0x000000018964C4B0-0x000000018964C4F0
	// [XID] // 0x000000018964C4B0-0x000000018964C4F0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183CD03D0-0x0000000183CD06E0
	// [XID] // 0x0000000189656A90-0x0000000189656AB0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2FFA */, bool useObjectPool = false /* Metadata: 0x00AF2FFE */) => default; // 0x0000000183CD0C90-0x0000000183CD1140
	[BlackList] // 0x000000018965E130-0x000000018965E170
	// [XID] // 0x000000018965E130-0x000000018965E170
	public virtual void AutoAllocTypeFields() {} // 0x0000000183CD0230-0x0000000183CD02D0
	[BlackList] // 0x0000000189668B80-0x0000000189668BC0
	// [XID] // 0x0000000189668B80-0x0000000189668BC0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183CD02D0-0x0000000183CD03D0
	[BlackList] // 0x0000000189673460-0x00000001896734A0
	// [XID] // 0x0000000189673460-0x00000001896734A0
	public virtual void ReturnToObjectPool() {} // 0x0000000183CD15E0-0x0000000183CD1680
	[BlackList] // 0x000000018967DD00-0x000000018967DD40
	// [XID] // 0x000000018967DD00-0x000000018967DD40
	public virtual void OnPoolAllocated() {} // 0x0000000183CD1470-0x0000000183CD1510
	[BlackList] // 0x0000000189688A40-0x0000000189688A80
	// [XID] // 0x0000000189688A40-0x0000000189688A80
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183CD13D0-0x0000000183CD1470
}

