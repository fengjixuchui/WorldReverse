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
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigSeal : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17987
{
	// Fields
	private SealProgressType _progressType; // 0x10
	private string _boardEffect; // 0x18
	private SimpleSafeFloat boardEffectStartPositionRawNum; // 0x20
	private SimpleSafeFloat boardEffectEndPositionRawNum; // 0x24
	private string _startTips; // 0x28
	private string _title; // 0x30

	// Properties
	public SealProgressType progressType { /* [XID] */ /* 0x0000000189B5E280-0x0000000189B5E2A0 */ get => default; /* [XID] */ /* 0x0000000189B657C0-0x0000000189B657E0 */ private set {} } // 0x00000001817B8510-0x00000001817B85B0 0x00000001817B78C0-0x00000001817B7970
	public string boardEffect { /* [XID] */ /* 0x0000000189B6CDA0-0x0000000189B6CDC0 */ get => default; /* [XID] */ /* 0x0000000189B74550-0x0000000189B74570 */ private set {} } // 0x00000001817B83C0-0x00000001817B8460 0x00000001817B87C0-0x00000001817B8870
	public float boardEffectStartPosition { /* [XID] */ /* 0x0000000189B7BB70-0x0000000189B7BB90 */ get => default; /* [XID] */ /* 0x0000000189B83440-0x0000000189B83460 */ private set {} } // 0x00000001817B85B0-0x00000001817B8690 0x00000001817B6CC0-0x00000001817B6DA0
	public float boardEffectEndPosition { /* [XID] */ /* 0x0000000189B8A910-0x0000000189B8A930 */ get => default; /* [XID] */ /* 0x0000000189B91E80-0x0000000189B91EA0 */ private set {} } // 0x00000001817B82E0-0x00000001817B83C0 0x00000001817B7970-0x00000001817B7A50
	public string startTips { /* [XID] */ /* 0x0000000189B99320-0x0000000189B99340 */ get => default; /* [XID] */ /* 0x0000000189BA0830-0x0000000189BA0850 */ private set {} } // 0x00000001817B8C10-0x00000001817B8CB0 0x00000001817B9110-0x00000001817B91C0
	public string title { /* [XID] */ /* 0x0000000189BA7F70-0x0000000189BA7F90 */ get => default; /* [XID] */ /* 0x0000000189BAF3E0-0x0000000189BAF400 */ private set {} } // 0x00000001817B8B70-0x00000001817B8C10 0x00000001817B8460-0x00000001817B8510

	// Constructors
	public ConfigSeal() {} // 0x00000001817B9510-0x00000001817B9570

	// Methods
	// [XID] // 0x0000000189BB6A70-0x0000000189BB6A90
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001817B91C0-0x00000001817B9330
	// [XID] // 0x0000000189BBE0D0-0x0000000189BBE0F0
	public void InitEmpty() {} // 0x00000001817B8690-0x00000001817B87C0
	[BlackList] // 0x0000000189BC5DA0-0x0000000189BC5DE0
	// [XID] // 0x0000000189BC5DA0-0x0000000189BC5DE0
	public bool FromJson(JSONNode node) => default; // 0x00000001817B7F60-0x00000001817B82E0
	// [XID] // 0x0000000189BD0650-0x0000000189BD0670
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001817B6DA0-0x00000001817B7460
	// [XID] // 0x0000000189BD7C50-0x0000000189BD7C70
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF85B9 */, bool useObjectPool = false /* Metadata: 0x00AF85BD */) => default; // 0x00000001817B8870-0x00000001817B8B70
	// [XID] // 0x0000000189BDF860-0x0000000189BDF880
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF85BE */, bool useObjectPool = false /* Metadata: 0x00AF85C2 */) => default; // 0x00000001817B7A50-0x00000001817B7F60
	[BlackList] // 0x00000001895EC390-0x00000001895EC3D0
	// [XID] // 0x00000001895EC390-0x00000001895EC3D0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001817B7460-0x00000001817B7730
	// [XID] // 0x00000001895F6C40-0x00000001895F6C60
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001817B8CB0-0x00000001817B9110
	[BlackList] // 0x00000001895FDFE0-0x00000001895FE020
	// [XID] // 0x00000001895FDFE0-0x00000001895FE020
	public virtual void AutoAllocTypeFields() {} // 0x00000001817B7730-0x00000001817B77D0
	[BlackList] // 0x0000000189608AF0-0x0000000189608B30
	// [XID] // 0x0000000189608AF0-0x0000000189608B30
	public virtual void AutoRecycleTypeFields() {} // 0x00000001817B77D0-0x00000001817B78C0
	[BlackList] // 0x0000000189613040-0x0000000189613080
	// [XID] // 0x0000000189613040-0x0000000189613080
	public virtual void ReturnToObjectPool() {} // 0x00000001817B9470-0x00000001817B9510
	[BlackList] // 0x000000018961D890-0x000000018961D8D0
	// [XID] // 0x000000018961D890-0x000000018961D8D0
	public virtual void OnPoolAllocated() {} // 0x00000001817B93D0-0x00000001817B9470
	[BlackList] // 0x0000000189627DD0-0x0000000189627E10
	// [XID] // 0x0000000189627DD0-0x0000000189627E10
	public virtual void OnBeforePoolRecycled() {} // 0x00000001817B9330-0x00000001817B93D0
}

