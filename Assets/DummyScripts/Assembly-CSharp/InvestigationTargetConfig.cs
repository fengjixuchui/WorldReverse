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
public class InvestigationTargetConfig : WatcherConfig, IAutoAllocRecycle // TypeDefIndex: 15769
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 questIdRawNum; // 0x28
	protected SimpleSafeUInt32 investigationIdRawNum; // 0x2C
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x30
	protected string _icon; // 0x38
	protected string _image; // 0x40
	protected uint _infoDesTextMapHash; // 0x48
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected QuestGuide _guide; // 0x50

	// Properties
	public uint questId { /* [XID] */ /* 0x0000000189635EF0-0x0000000189635F10 */ get => default; /* [XID] */ /* 0x000000018963D650-0x000000018963D670 */ protected set {} } // 0x0000000184850250-0x0000000184850320 0x00000001848506A0-0x0000000184850780
	public uint investigationId { /* [XID] */ /* 0x0000000189644BD0-0x0000000189644BF0 */ get => default; /* [XID] */ /* 0x000000018964C5B0-0x000000018964C5D0 */ protected set {} } // 0x0000000184850780-0x0000000184850850 0x0000000184851500-0x00000001848515E0
	public uint rewardId { /* [XID] */ /* 0x0000000189653B40-0x0000000189653B60 */ get => default; /* [XID] */ /* 0x000000018965B3D0-0x000000018965B3F0 */ protected set {} } // 0x0000000184851270-0x0000000184851340 0x000000018484F180-0x000000018484F260
	public string icon { /* [XID] */ /* 0x0000000189662860-0x0000000189662880 */ get => default; /* [XID] */ /* 0x000000018966A400-0x000000018966A420 */ protected set {} } // 0x000000018484F300-0x000000018484F3A0 0x0000000184851450-0x0000000184851500
	public string image { /* [XID] */ /* 0x0000000189672040-0x0000000189672060 */ get => default; /* [XID] */ /* 0x0000000189679910-0x0000000189679930 */ protected set {} } // 0x000000018484F260-0x000000018484F300 0x00000001848505F0-0x00000001848506A0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint infoDesTextMapHash { /* [XID] */ /* 0x0000000189681000-0x0000000189681020 */ get => default; /* [XID] */ /* 0x0000000189688AA0-0x0000000189688AC0 */ protected set {} } // 0x0000000184850550-0x00000001848505F0 0x00000001848504A0-0x0000000184850550
	public string infoDes { /* [XID] */ /* 0x0000000189690460-0x0000000189690480 */ get => default; } // 0x0000000184850320-0x00000001848504A0 
	public QuestGuide guide { /* [XID] */ /* 0x0000000189697D20-0x0000000189697D40 */ get => default; /* [XID] */ /* 0x000000018969EFF0-0x000000018969F010 */ protected set {} } // 0x00000001848515E0-0x0000000184851680 0x0000000184851340-0x00000001848513F0

	// Constructors
	public InvestigationTargetConfig() {} // 0x0000000184851720-0x0000000184851780

	// Methods
	// [IDTag] // 0x00000001896A6490-0x00000001896A64D0
	// [XID] // 0x00000001896A6490-0x00000001896A64D0
	public virtual bool ParseFromLine(string line) => default; // 0x000000018484F650-0x000000018484FC90
	// [IDTag] // 0x00000001896B0650-0x00000001896B0690
	// [XID] // 0x00000001896B0650-0x00000001896B0690
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018484FC90-0x0000000184850250
	// [XID] // 0x00000001896BAE90-0x00000001896BAEB0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2583 */, bool useObjectPool = false /* Metadata: 0x00AF2587 */) => default; // 0x0000000184850940-0x0000000184851270
	[BlackList] // 0x00000001896C2000-0x00000001896C2040
	// [XID] // 0x00000001896C2000-0x00000001896C2040
	public override void AutoAllocTypeFields() {} // 0x000000018484F3A0-0x000000018484F440
	[BlackList] // 0x00000001896CC790-0x00000001896CC7D0
	// [XID] // 0x00000001896CC790-0x00000001896CC7D0
	public override void AutoRecycleTypeFields() {} // 0x000000018484F440-0x000000018484F550
	[BlackList] // 0x00000001896D6CC0-0x00000001896D6D00
	// [XID] // 0x00000001896D6CC0-0x00000001896D6D00
	public override void ReturnToObjectPool() {} // 0x0000000184851680-0x0000000184851720
}

