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
public class ReunionWatcherExcelConfig : WatcherConfig, IAutoAllocRecycle // TypeDefIndex: 16060
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 watcherGroupIdRawNum; // 0x28
	protected uint _descTextMapHash; // 0x2C
	protected string _activateLevelRange; // 0x30
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x38
	protected SimpleSafeUInt32 scoreRawNum; // 0x3C

	// Properties
	public uint watcherGroupId { /* [XID] */ /* 0x000000018967C600-0x000000018967C620 */ get => default; /* [XID] */ /* 0x0000000189683D10-0x0000000189683D30 */ protected set {} } // 0x00000001844000B0-0x0000000184400180 0x00000001843FF2E0-0x00000001843FF3C0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x000000018968B970-0x000000018968B990 */ get => default; /* [XID] */ /* 0x0000000189693580-0x00000001896935A0 */ protected set {} } // 0x00000001843FFFB0-0x0000000184400050 0x00000001843FE6D0-0x00000001843FE780
	public string desc { /* [XID] */ /* 0x000000018969A870-0x000000018969A890 */ get => default; } // 0x00000001843FF3C0-0x00000001843FF540 
	public string activateLevelRange { /* [XID] */ /* 0x00000001896A2260-0x00000001896A2280 */ get => default; /* [XID] */ /* 0x00000001896A94A0-0x00000001896A94C0 */ protected set {} } // 0x00000001843FE580-0x00000001843FE620 0x00000001843FE620-0x00000001843FE6D0
	public uint rewardId { /* [XID] */ /* 0x00000001896B05D0-0x00000001896B05F0 */ get => default; /* [XID] */ /* 0x00000001896B8010-0x00000001896B8030 */ protected set {} } // 0x00000001843FFEE0-0x00000001843FFFB0 0x00000001843FE170-0x00000001843FE250
	public uint score { /* [XID] */ /* 0x00000001896BF090-0x00000001896BF0B0 */ get => default; /* [XID] */ /* 0x00000001896C69B0-0x00000001896C69D0 */ protected set {} } // 0x00000001843FF5D0-0x00000001843FF6A0 0x00000001843FE250-0x00000001843FE330

	// Constructors
	public ReunionWatcherExcelConfig() {} // 0x0000000184400220-0x0000000184400280

	// Methods
	// [IDTag] // 0x00000001896CE070-0x00000001896CE0B0
	// [XID] // 0x00000001896CE070-0x00000001896CE0B0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001843FED20-0x00000001843FF2E0
	// [IDTag] // 0x00000001896D8470-0x00000001896D84B0
	// [XID] // 0x00000001896D8470-0x00000001896D84B0
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001843FE7E0-0x00000001843FED20
	// [XID] // 0x00000001896E2BE0-0x00000001896E2C00
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2F34 */, bool useObjectPool = false /* Metadata: 0x00AF2F38 */) => default; // 0x00000001843FF700-0x00000001843FFEE0
	[BlackList] // 0x00000001896EA200-0x00000001896EA240
	// [XID] // 0x00000001896EA200-0x00000001896EA240
	public override void AutoAllocTypeFields() {} // 0x00000001843FE330-0x00000001843FE3D0
	[BlackList] // 0x00000001896F4720-0x00000001896F4760
	// [XID] // 0x00000001896F4720-0x00000001896F4760
	public override void AutoRecycleTypeFields() {} // 0x00000001843FE3D0-0x00000001843FE4E0
	[BlackList] // 0x00000001896FF010-0x00000001896FF050
	// [XID] // 0x00000001896FF010-0x00000001896FF050
	public override void ReturnToObjectPool() {} // 0x0000000184400180-0x0000000184400220
}

