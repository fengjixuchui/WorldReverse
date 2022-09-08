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
public class NpcFirstMetExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15913
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32[] _subQuestIdList; // 0x18
	protected SimpleSafeUInt32 avatarIDRawNum; // 0x20
	protected uint _avatarDescriptionTextMapHash; // 0x24

	// Properties
	public uint id { /* [XID] */ /* 0x000000018987DB80-0x000000018987DBA0 */ get => default; /* [XID] */ /* 0x0000000189884A70-0x0000000189884A90 */ protected set {} } // 0x000000018241AF90-0x000000018241B060 0x000000018241A6A0-0x000000018241A780
	public SimpleSafeUInt32[] subQuestIdList { /* [XID] */ /* 0x000000018988C120-0x000000018988C140 */ get => default; /* [XID] */ /* 0x0000000189893690-0x00000001898936B0 */ protected set {} } // 0x000000018241ADB0-0x000000018241AE50 0x0000000182419730-0x00000001824197E0
	public uint avatarID { /* [XID] */ /* 0x000000018989AD90-0x000000018989ADB0 */ get => default; /* [XID] */ /* 0x00000001898A21A0-0x00000001898A21C0 */ protected set {} } // 0x0000000182419970-0x0000000182419A40 0x000000018241A520-0x000000018241A600
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint avatarDescriptionTextMapHash { /* [XID] */ /* 0x00000001898A98F0-0x00000001898A9910 */ get => default; /* [XID] */ /* 0x00000001898B1200-0x00000001898B1220 */ protected set {} } // 0x000000018241A600-0x000000018241A6A0 0x0000000182419A40-0x0000000182419AF0
	public string avatarDescription { /* [XID] */ /* 0x00000001898B8AA0-0x00000001898B8AC0 */ get => default; } // 0x000000018241A780-0x000000018241A900 

	// Constructors
	public NpcFirstMetExcelConfig() {} // 0x000000018241B100-0x000000018241B160

	// Methods
	// [IDTag] // 0x00000001898C00A0-0x00000001898C00E0
	// [XID] // 0x00000001898C00A0-0x00000001898C00E0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000182419AF0-0x000000018241A020
	// [IDTag] // 0x00000001898CA980-0x00000001898CA9C0
	// [XID] // 0x00000001898CA980-0x00000001898CA9C0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018241A020-0x000000018241A520
	// [XID] // 0x00000001898D51F0-0x00000001898D5210
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2B01 */, bool useObjectPool = false /* Metadata: 0x00AF2B05 */) => default; // 0x000000018241A900-0x000000018241ADB0
	[BlackList] // 0x00000001898DCA70-0x00000001898DCAB0
	// [XID] // 0x00000001898DCA70-0x00000001898DCAB0
	public virtual void AutoAllocTypeFields() {} // 0x00000001824197E0-0x0000000182419880
	[BlackList] // 0x00000001898E79B0-0x00000001898E79F0
	// [XID] // 0x00000001898E79B0-0x00000001898E79F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182419880-0x0000000182419970
	[BlackList] // 0x00000001898F2090-0x00000001898F20D0
	// [XID] // 0x00000001898F2090-0x00000001898F20D0
	public virtual void ReturnToObjectPool() {} // 0x000000018241B060-0x000000018241B100
	[BlackList] // 0x00000001898FC730-0x00000001898FC770
	// [XID] // 0x00000001898FC730-0x00000001898FC770
	public virtual void OnPoolAllocated() {} // 0x000000018241AEF0-0x000000018241AF90
	[BlackList] // 0x00000001899070D0-0x0000000189907110
	// [XID] // 0x00000001899070D0-0x0000000189907110
	public virtual void OnBeforePoolRecycled() {} // 0x000000018241AE50-0x000000018241AEF0
}

