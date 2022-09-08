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
public class ExpeditionBonusExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15087
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 avatarLevelRawNum; // 0x14
	protected SimpleSafeFloat probabilityRawNum; // 0x18

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189620CC0-0x0000000189620CE0 */ get => default; /* [XID] */ /* 0x00000001896282F0-0x0000000189628310 */ protected set {} } // 0x000000018403D1F0-0x000000018403D2C0 0x000000018403CAE0-0x000000018403CBC0
	public uint avatarLevel { /* [XID] */ /* 0x000000018962FC00-0x000000018962FC20 */ get => default; /* [XID] */ /* 0x00000001896377C0-0x00000001896377E0 */ protected set {} } // 0x000000018403C3B0-0x000000018403C480 0x000000018403C120-0x000000018403C200
	public float probability { /* [XID] */ /* 0x000000018963EC60-0x000000018963EC80 */ get => default; /* [XID] */ /* 0x0000000189646460-0x0000000189646480 */ protected set {} } // 0x000000018403CFD0-0x000000018403D0B0 0x000000018403C480-0x000000018403C560

	// Constructors
	public ExpeditionBonusExcelConfig() {} // 0x000000018403D360-0x000000018403D3C0

	// Methods
	// [IDTag] // 0x000000018964DC20-0x000000018964DC60
	// [XID] // 0x000000018964DC20-0x000000018964DC60
	public virtual bool ParseFromLine(string line) => default; // 0x000000018403C800-0x000000018403CAE0
	// [IDTag] // 0x0000000189658430-0x0000000189658470
	// [XID] // 0x0000000189658430-0x0000000189658470
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018403C560-0x000000018403C800
	// [XID] // 0x0000000189662940-0x0000000189662960
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0076 */, bool useObjectPool = false /* Metadata: 0x00AF007A */) => default; // 0x000000018403CBC0-0x000000018403CFD0
	[BlackList] // 0x000000018966A4A0-0x000000018966A4E0
	// [XID] // 0x000000018966A4A0-0x000000018966A4E0
	public virtual void AutoAllocTypeFields() {} // 0x000000018403C200-0x000000018403C2A0
	[BlackList] // 0x0000000189675090-0x00000001896750D0
	// [XID] // 0x0000000189675090-0x00000001896750D0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018403C2A0-0x000000018403C3B0
	[BlackList] // 0x000000018967F760-0x000000018967F7A0
	// [XID] // 0x000000018967F760-0x000000018967F7A0
	public virtual void ReturnToObjectPool() {} // 0x000000018403D2C0-0x000000018403D360
	[BlackList] // 0x000000018968A170-0x000000018968A1B0
	// [XID] // 0x000000018968A170-0x000000018968A1B0
	public virtual void OnPoolAllocated() {} // 0x000000018403D150-0x000000018403D1F0
	[BlackList] // 0x0000000189694BA0-0x0000000189694BE0
	// [XID] // 0x0000000189694BA0-0x0000000189694BE0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018403D0B0-0x000000018403D150
}

