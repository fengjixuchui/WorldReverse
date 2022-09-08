/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class CampExcelConfig : IAutoAllocRecycle // TypeDefIndex: 14841
{
	// Fields
	public Dictionary<uint, CampExcelConfig> enemyCampMap; // 0x10
	public SimpleSafeUInt32[] allianceCampList; // 0x18
	public SimpleSafeUInt32[] selfCampList; // 0x20
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x28
	protected uint _commentTextMapHash; // 0x2C
	protected SimpleSafeUInt32 trophicLevelRawNum; // 0x30
	protected SimpleSafeUInt32[] _enemyCampList; // 0x38

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189838600-0x0000000189838620 */ get => default; /* [XID] */ /* 0x000000018983FC70-0x000000018983FC90 */ protected set {} } // 0x0000000182D4E2B0-0x0000000182D4E380 0x0000000182D4D9C0-0x0000000182D4DAA0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint commentTextMapHash { /* [XID] */ /* 0x00000001898472B0-0x00000001898472D0 */ get => default; /* [XID] */ /* 0x000000018984E940-0x000000018984E960 */ protected set {} } // 0x0000000182D4DF50-0x0000000182D4DFF0 0x0000000182D4E0C0-0x0000000182D4E170
	public string comment { /* [XID] */ /* 0x0000000189855A10-0x0000000189855A30 */ get => default; } // 0x0000000182D4D760-0x0000000182D4D8E0 
	public uint trophicLevel { /* [XID] */ /* 0x000000018985CDB0-0x000000018985CDD0 */ get => default; /* [XID] */ /* 0x00000001898647B0-0x00000001898647D0 */ protected set {} } // 0x0000000182D4DFF0-0x0000000182D4E0C0 0x0000000182D4D8E0-0x0000000182D4D9C0
	public SimpleSafeUInt32[] enemyCampList { /* [XID] */ /* 0x00000001897DEE10-0x00000001897DEE30 */ get => default; /* [XID] */ /* 0x0000000189873110-0x0000000189873130 */ protected set {} } // 0x0000000182D4CB20-0x0000000182D4CBC0 0x0000000182D4E380-0x0000000182D4E430

	// Constructors
	public CampExcelConfig() {} // 0x0000000182D4E4D0-0x0000000182D4E530

	// Methods
	// [IDTag] // 0x000000018987ADD0-0x000000018987AE10
	// [XID] // 0x000000018987ADD0-0x000000018987AE10
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182D4CD60-0x0000000182D4D280
	// [IDTag] // 0x0000000189884D30-0x0000000189884D70
	// [XID] // 0x0000000189884D30-0x0000000189884D70
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182D4D280-0x0000000182D4D760
	// [XID] // 0x000000018988F1A0-0x000000018988F1C0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF742 */, bool useObjectPool = false /* Metadata: 0x00AEF746 */) => default; // 0x0000000182D4DAA0-0x0000000182D4DF50
	[BlackList] // 0x0000000189896700-0x0000000189896740
	// [XID] // 0x0000000189896700-0x0000000189896740
	public virtual void AutoAllocTypeFields() {} // 0x0000000182D4CBC0-0x0000000182D4CC60
	[BlackList] // 0x00000001898A0AB0-0x00000001898A0AF0
	// [XID] // 0x00000001898A0AB0-0x00000001898A0AF0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182D4CC60-0x0000000182D4CD60
	[BlackList] // 0x00000001898AB0A0-0x00000001898AB0E0
	// [XID] // 0x00000001898AB0A0-0x00000001898AB0E0
	public virtual void ReturnToObjectPool() {} // 0x0000000182D4E430-0x0000000182D4E4D0
	[BlackList] // 0x00000001898B5AD0-0x00000001898B5B10
	// [XID] // 0x00000001898B5AD0-0x00000001898B5B10
	public virtual void OnPoolAllocated() {} // 0x0000000182D4E210-0x0000000182D4E2B0
	[BlackList] // 0x00000001898C0320-0x00000001898C0360
	// [XID] // 0x00000001898C0320-0x00000001898C0360
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182D4E170-0x0000000182D4E210
}

