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
public class MechanicusMapExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16216
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 mechanicusMapIDRawNum; // 0x10
	protected uint _mapNameTextMapHash; // 0x14
	protected uint _descTextMapHash; // 0x18
	protected uint _unlockTipsTextMapHash; // 0x1C
	protected string _mapIconPath; // 0x20
	protected SimpleSafeUInt32 buildGearLimitRawNum; // 0x28
	protected SimpleSafeUInt32 dungeonIDRawNum; // 0x2C

	// Properties
	public uint mechanicusMapID { /* [XID] */ /* 0x000000018983B260-0x000000018983B280 */ get => default; /* [XID] */ /* 0x0000000189842AC0-0x0000000189842AE0 */ protected set {} } // 0x000000018223CF30-0x000000018223D000 0x000000018223CE50-0x000000018223CF30
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint mapNameTextMapHash { /* [XID] */ /* 0x0000000189849E30-0x0000000189849E50 */ get => default; /* [XID] */ /* 0x00000001898514B0-0x00000001898514D0 */ protected set {} } // 0x000000018223B140-0x000000018223B1E0 0x000000018223CB50-0x000000018223CC00
	public string mapName { /* [XID] */ /* 0x0000000189858A20-0x0000000189858A40 */ get => default; } // 0x000000018223B500-0x000000018223B680 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x000000018985FB70-0x000000018985FB90 */ get => default; /* [XID] */ /* 0x00000001898672D0-0x00000001898672F0 */ protected set {} } // 0x000000018223CDB0-0x000000018223CE50 0x000000018223B680-0x000000018223B730
	public string desc { /* [XID] */ /* 0x000000018986EA30-0x000000018986EA50 */ get => default; } // 0x000000018223C1B0-0x000000018223C330 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint unlockTipsTextMapHash { /* [XID] */ /* 0x0000000189875F40-0x0000000189875F60 */ get => default; /* [XID] */ /* 0x000000018987DB00-0x000000018987DB20 */ protected set {} } // 0x000000018223C060-0x000000018223C100 0x000000018223C410-0x000000018223C4C0
	public string unlockTips { /* [XID] */ /* 0x00000001898849B0-0x00000001898849D0 */ get => default; } // 0x000000018223B380-0x000000018223B500 
	public string mapIconPath { /* [XID] */ /* 0x000000018988C020-0x000000018988C040 */ get => default; /* [XID] */ /* 0x0000000189893630-0x0000000189893650 */ protected set {} } // 0x000000018223D000-0x000000018223D0A0 0x000000018223C100-0x000000018223C1B0
	public uint buildGearLimit { /* [XID] */ /* 0x000000018989AD30-0x000000018989AD50 */ get => default; /* [XID] */ /* 0x00000001898A20C0-0x00000001898A20E0 */ protected set {} } // 0x000000018223D1E0-0x000000018223D2B0 0x000000018223CC00-0x000000018223CCE0
	public uint dungeonID { /* [XID] */ /* 0x00000001898A9890-0x00000001898A98B0 */ get => default; /* [XID] */ /* 0x00000001898B11A0-0x00000001898B11C0 */ protected set {} } // 0x000000018223CCE0-0x000000018223CDB0 0x000000018223C330-0x000000018223C410

	// Constructors
	public MechanicusMapExcelConfig() {} // 0x000000018223D350-0x000000018223D3B0

	// Methods
	// [IDTag] // 0x00000001898B89E0-0x00000001898B8A20
	// [XID] // 0x00000001898B89E0-0x00000001898B8A20
	public virtual bool ParseFromLine(string line) => default; // 0x000000018223BBC0-0x000000018223C060
	// [IDTag] // 0x00000001898C2F60-0x00000001898C2FA0
	// [XID] // 0x00000001898C2F60-0x00000001898C2FA0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018223B730-0x000000018223BBC0
	// [XID] // 0x00000001898CD680-0x00000001898CD6A0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3496 */, bool useObjectPool = false /* Metadata: 0x00AF349A */) => default; // 0x000000018223C4C0-0x000000018223CB50
	[BlackList] // 0x00000001898D50B0-0x00000001898D50F0
	// [XID] // 0x00000001898D50B0-0x00000001898D50F0
	public virtual void AutoAllocTypeFields() {} // 0x000000018223B1E0-0x000000018223B280
	[BlackList] // 0x00000001898DFDE0-0x00000001898DFE20
	// [XID] // 0x00000001898DFDE0-0x00000001898DFE20
	public virtual void AutoRecycleTypeFields() {} // 0x000000018223B280-0x000000018223B380
	[BlackList] // 0x00000001898EA890-0x00000001898EA8D0
	// [XID] // 0x00000001898EA890-0x00000001898EA8D0
	public virtual void ReturnToObjectPool() {} // 0x000000018223D2B0-0x000000018223D350
	[BlackList] // 0x00000001898F4F60-0x00000001898F4FA0
	// [XID] // 0x00000001898F4F60-0x00000001898F4FA0
	public virtual void OnPoolAllocated() {} // 0x000000018223D140-0x000000018223D1E0
	[BlackList] // 0x00000001898FF7F0-0x00000001898FF830
	// [XID] // 0x00000001898FF7F0-0x00000001898FF830
	public virtual void OnBeforePoolRecycled() {} // 0x000000018223D0A0-0x000000018223D140
}

