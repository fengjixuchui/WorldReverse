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
public class InvestigationConfig : IAutoAllocRecycle // TypeDefIndex: 15767
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 cityIdRawNum; // 0x14
	protected SimpleSafeUInt32[] _nextInvestigationIdList; // 0x18
	protected OpenStateType _unlockOpenStateType; // 0x20
	protected SimpleSafeUInt32 rewardIdRawNum; // 0x24
	protected uint _titleTextMapHash; // 0x28
	protected InvestigationType _investigationType; // 0x2C

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189ADDEA0-0x0000000189ADDEC0 */ get => default; /* [XID] */ /* 0x0000000189AE59E0-0x0000000189AE5A00 */ protected set {} } // 0x000000018337BE40-0x000000018337BF10 0x000000018337B080-0x000000018337B160
	public uint cityId { /* [XID] */ /* 0x0000000189AECDE0-0x0000000189AECE00 */ get => default; /* [XID] */ /* 0x0000000189AF4730-0x0000000189AF4750 */ protected set {} } // 0x000000018337BC30-0x000000018337BD00 0x000000018337AFA0-0x000000018337B080
	public SimpleSafeUInt32[] nextInvestigationIdList { /* [XID] */ /* 0x0000000189AFBD40-0x0000000189AFBD60 */ get => default; /* [XID] */ /* 0x0000000189B035D0-0x0000000189B035F0 */ protected set {} } // 0x000000018337BB90-0x000000018337BC30 0x0000000183379C50-0x0000000183379D00
	public OpenStateType unlockOpenStateType { /* [XID] */ /* 0x0000000189B0AD60-0x0000000189B0AD80 */ get => default; /* [XID] */ /* 0x0000000189B125A0-0x0000000189B125C0 */ protected set {} } // 0x0000000183379DE0-0x0000000183379E80 0x000000018337B8C0-0x000000018337B970
	public uint rewardId { /* [XID] */ /* 0x0000000189B19850-0x0000000189B19870 */ get => default; /* [XID] */ /* 0x0000000189B20EB0-0x0000000189B20ED0 */ protected set {} } // 0x000000018337B7F0-0x000000018337B8C0 0x0000000183379D00-0x0000000183379DE0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x0000000189B28610-0x0000000189B28630 */ get => default; /* [XID] */ /* 0x0000000189B2F9D0-0x0000000189B2F9F0 */ protected set {} } // 0x000000018337A020-0x000000018337A0C0 0x000000018337A0C0-0x000000018337A170
	public string title { /* [XID] */ /* 0x0000000189B37370-0x0000000189B37390 */ get => default; } // 0x000000018337B970-0x000000018337BAF0 
	public InvestigationType investigationType { /* [XID] */ /* 0x0000000189B3EBC0-0x0000000189B3EBE0 */ get => default; /* [XID] */ /* 0x0000000189B46660-0x0000000189B46680 */ protected set {} } // 0x000000018337BAF0-0x000000018337BB90 0x000000018337AEF0-0x000000018337AFA0

	// Constructors
	public InvestigationConfig() {} // 0x000000018337BFB0-0x000000018337C010

	// Methods
	// [IDTag] // 0x0000000189B4DBE0-0x0000000189B4DC20
	// [XID] // 0x0000000189B4DBE0-0x0000000189B4DC20
	public virtual bool ParseFromLine(string line) => default; // 0x000000018337A170-0x000000018337A840
	// [IDTag] // 0x0000000189B58670-0x0000000189B586B0
	// [XID] // 0x0000000189B58670-0x0000000189B586B0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018337A840-0x000000018337AEF0
	// [XID] // 0x0000000189B62980-0x0000000189B629A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2574 */, bool useObjectPool = false /* Metadata: 0x00AF2578 */) => default; // 0x000000018337B160-0x000000018337B7F0
	[BlackList] // 0x0000000189B6A490-0x0000000189B6A4D0
	// [XID] // 0x0000000189B6A490-0x0000000189B6A4D0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183379E80-0x0000000183379F20
	[BlackList] // 0x0000000189B748B0-0x0000000189B748F0
	// [XID] // 0x0000000189B748B0-0x0000000189B748F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183379F20-0x000000018337A020
	[BlackList] // 0x0000000189B7EDA0-0x0000000189B7EDE0
	// [XID] // 0x0000000189B7EDA0-0x0000000189B7EDE0
	public virtual void ReturnToObjectPool() {} // 0x000000018337BF10-0x000000018337BFB0
	[BlackList] // 0x0000000189B89730-0x0000000189B89770
	// [XID] // 0x0000000189B89730-0x0000000189B89770
	public virtual void OnPoolAllocated() {} // 0x000000018337BDA0-0x000000018337BE40
	[BlackList] // 0x0000000189B93AF0-0x0000000189B93B30
	// [XID] // 0x0000000189B93AF0-0x0000000189B93B30
	public virtual void OnBeforePoolRecycled() {} // 0x000000018337BD00-0x000000018337BDA0
}

