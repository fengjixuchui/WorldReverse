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
public class EquipAffixExcelConfig : BaseTalentConfig, IAutoAllocRecycle // TypeDefIndex: 14847
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 affixIdRawNum; // 0x28
	protected SimpleSafeUInt32 idRawNum; // 0x2C
	protected SimpleSafeUInt32 levelRawNum; // 0x30
	protected uint _nameTextMapHash; // 0x34
	protected uint _descTextMapHash; // 0x38

	// Properties
	public override uint talentSkillID { /* [XID] */ /* 0x0000000189771DB0-0x0000000189771DD0 */ get => default; } // 0x0000000184D068C0-0x0000000184D06970 
	public uint affixId { /* [XID] */ /* 0x0000000189779560-0x0000000189779580 */ get => default; /* [XID] */ /* 0x0000000189780E40-0x0000000189780E60 */ protected set {} } // 0x0000000184D07760-0x0000000184D07830 0x0000000184D067E0-0x0000000184D068C0
	public uint id { /* [XID] */ /* 0x0000000189788380-0x00000001897883A0 */ get => default; /* [XID] */ /* 0x000000018978F940-0x000000018978F960 */ protected set {} } // 0x0000000184D07830-0x0000000184D07900 0x0000000184D06B80-0x0000000184D06C60
	public uint level { /* [XID] */ /* 0x0000000189797130-0x0000000189797150 */ get => default; /* [XID] */ /* 0x000000018979F190-0x000000018979F1B0 */ protected set {} } // 0x0000000184D074E0-0x0000000184D075B0 0x0000000184D07400-0x0000000184D074E0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x00000001897A6820-0x00000001897A6840 */ get => default; /* [XID] */ /* 0x00000001897ADE70-0x00000001897ADE90 */ protected set {} } // 0x0000000184D057B0-0x0000000184D05850 0x0000000184D07650-0x0000000184D07700
	public string name { /* [XID] */ /* 0x00000001897B5F50-0x00000001897B5F70 */ get => default; } // 0x0000000184D07900-0x0000000184D07A80 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x00000001897BDD60-0x00000001897BDD80 */ get => default; /* [XID] */ /* 0x00000001897C5120-0x00000001897C5140 */ protected set {} } // 0x0000000184D075B0-0x0000000184D07650 0x0000000184D05850-0x0000000184D05900
	public string desc { /* [XID] */ /* 0x00000001897CC970-0x00000001897CC990 */ get => default; } // 0x0000000184D06970-0x0000000184D06AF0 

	// Constructors
	public EquipAffixExcelConfig() {} // 0x0000000184D07B20-0x0000000184D07B80

	// Methods
	// [IDTag] // 0x00000001897D4140-0x00000001897D4180
	// [XID] // 0x00000001897D4140-0x00000001897D4180
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184D05960-0x0000000184D060D0
	// [IDTag] // 0x00000001897DE7D0-0x00000001897DE810
	// [XID] // 0x00000001897DE7D0-0x00000001897DE810
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184D060D0-0x0000000184D06770
	// [XID] // 0x00000001897E9290-0x00000001897E92B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF7B1 */, bool useObjectPool = false /* Metadata: 0x00AEF7B5 */) => default; // 0x0000000184D06CC0-0x0000000184D07400
	[BlackList] // 0x00000001897F0E00-0x00000001897F0E40
	// [XID] // 0x00000001897F0E00-0x00000001897F0E40
	public override void AutoAllocTypeFields() {} // 0x0000000184D05570-0x0000000184D05610
	[BlackList] // 0x00000001897FB8B0-0x00000001897FB8F0
	// [XID] // 0x00000001897FB8B0-0x00000001897FB8F0
	public override void AutoRecycleTypeFields() {} // 0x0000000184D05610-0x0000000184D05710
	[BlackList] // 0x0000000189805930-0x0000000189805970
	// [XID] // 0x0000000189805930-0x0000000189805970
	public override void ReturnToObjectPool() {} // 0x0000000184D07A80-0x0000000184D07B20
}

