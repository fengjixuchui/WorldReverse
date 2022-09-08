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
public class LandSoundExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15643
{
	// Fields
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected string _name; // 0x18
	protected string _audioName; // 0x20

	// Properties
	public uint id { /* [XID] */ /* 0x000000018978C870-0x000000018978C890 */ get => default; /* [XID] */ /* 0x0000000189793D00-0x0000000189793D20 */ protected set {} } // 0x00000001813F0420-0x00000001813F04F0 0x00000001813EFD50-0x00000001813EFE30
	public string name { /* [XID] */ /* 0x000000018979C070-0x000000018979C090 */ get => default; /* [XID] */ /* 0x00000001897A3580-0x00000001897A35A0 */ protected set {} } // 0x00000001813F04F0-0x00000001813F0590 0x00000001813EFCA0-0x00000001813EFD50
	public string audioName { /* [XID] */ /* 0x0000000189A95BB0-0x0000000189A95BD0 */ get => default; /* [XID] */ /* 0x00000001897B2690-0x00000001897B26B0 */ protected set {} } // 0x00000001813F0240-0x00000001813F02E0 0x00000001813EF540-0x00000001813EF5F0

	// Constructors
	public LandSoundExcelConfig() {} // 0x00000001813F0630-0x00000001813F0690

	// Methods
	// [IDTag] // 0x00000001897B9F10-0x00000001897B9F50
	// [XID] // 0x00000001897B9F10-0x00000001897B9F50
	public virtual bool ParseFromLine(string line) => default; // 0x00000001813EF770-0x00000001813EFA20
	// [IDTag] // 0x00000001897C4EE0-0x00000001897C4F20
	// [XID] // 0x00000001897C4EE0-0x00000001897C4F20
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001813EFA20-0x00000001813EFCA0
	// [XID] // 0x00000001897CF7D0-0x00000001897CF7F0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF217F */, bool useObjectPool = false /* Metadata: 0x00AF2183 */) => default; // 0x00000001813EFE30-0x00000001813F0240
	[BlackList] // 0x00000001897D7080-0x00000001897D70C0
	// [XID] // 0x00000001897D7080-0x00000001897D70C0
	public virtual void AutoAllocTypeFields() {} // 0x00000001813EF5F0-0x00000001813EF690
	[BlackList] // 0x00000001897E18A0-0x00000001897E18E0
	// [XID] // 0x00000001897E18A0-0x00000001897E18E0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001813EF690-0x00000001813EF770
	[BlackList] // 0x00000001897EC3C0-0x00000001897EC400
	// [XID] // 0x00000001897EC3C0-0x00000001897EC400
	public virtual void ReturnToObjectPool() {} // 0x00000001813F0590-0x00000001813F0630
	[BlackList] // 0x00000001897F6960-0x00000001897F69A0
	// [XID] // 0x00000001897F6960-0x00000001897F69A0
	public virtual void OnPoolAllocated() {} // 0x00000001813F0380-0x00000001813F0420
	[BlackList] // 0x0000000189801380-0x00000001898013C0
	// [XID] // 0x0000000189801380-0x00000001898013C0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001813F02E0-0x00000001813F0380
}

