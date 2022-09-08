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
public class MaterialCodexExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15315
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 IdRawNum; // 0x10
	protected MaterialCodexType _type; // 0x14
	protected SimpleSafeUInt32 materialIdRawNum; // 0x18
	protected SimpleSafeUInt32 SortOrderRawNum; // 0x1C
	protected uint _nameTextMapHash; // 0x20
	protected uint _descTextMapHash; // 0x24
	protected string _icon; // 0x28
	protected bool _isDisuse; // 0x30
	protected bool _showOnlyUnlocked; // 0x31

	// Properties
	public uint Id { /* [XID] */ /* 0x000000018995AD50-0x000000018995AD70 */ get => default; /* [XID] */ /* 0x0000000189962950-0x0000000189962970 */ protected set {} } // 0x00000001837F85E0-0x00000001837F86B0 0x00000001837F9230-0x00000001837F9310
	public MaterialCodexType type { /* [XID] */ /* 0x0000000189969D20-0x0000000189969D40 */ get => default; /* [XID] */ /* 0x0000000189971A60-0x0000000189971A80 */ protected set {} } // 0x00000001837F9700-0x00000001837F97A0 0x00000001837F93C0-0x00000001837F9470
	public uint materialId { /* [XID] */ /* 0x0000000189979390-0x00000001899793B0 */ get => default; /* [XID] */ /* 0x00000001899804C0-0x00000001899804E0 */ protected set {} } // 0x00000001837F8510-0x00000001837F85E0 0x00000001837F8430-0x00000001837F8510
	public uint SortOrder { /* [XID] */ /* 0x0000000189987DD0-0x0000000189987DF0 */ get => default; /* [XID] */ /* 0x000000018998F7E0-0x000000018998F800 */ protected set {} } // 0x00000001837F86B0-0x00000001837F8780 0x00000001837F8350-0x00000001837F8430
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189997240-0x0000000189997260 */ get => default; /* [XID] */ /* 0x000000018999EE50-0x000000018999EE70 */ protected set {} } // 0x00000001837F7570-0x00000001837F7610 0x00000001837F9180-0x00000001837F9230
	public string name { /* [XID] */ /* 0x00000001899A66F0-0x00000001899A6710 */ get => default; } // 0x00000001837F97A0-0x00000001837F9920 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x00000001899ADF00-0x00000001899ADF20 */ get => default; /* [XID] */ /* 0x00000001899B5720-0x00000001899B5740 */ protected set {} } // 0x00000001837F90E0-0x00000001837F9180 0x00000001837F7610-0x00000001837F76C0
	public string desc { /* [XID] */ /* 0x00000001899BCEB0-0x00000001899BCED0 */ get => default; } // 0x00000001837F8780-0x00000001837F8900 
	public string icon { /* [XID] */ /* 0x00000001899C4840-0x00000001899C4860 */ get => default; /* [XID] */ /* 0x00000001899CBFC0-0x00000001899CBFE0 */ protected set {} } // 0x00000001837F7330-0x00000001837F73D0 0x00000001837F9310-0x00000001837F93C0
	public bool isDisuse { /* [XID] */ /* 0x00000001899D3550-0x00000001899D3570 */ get => default; /* [XID] */ /* 0x00000001899DAB80-0x00000001899DABA0 */ protected set {} } // 0x00000001837F9470-0x00000001837F9510 0x00000001837F9510-0x00000001837F95C0
	public bool showOnlyUnlocked { /* [XID] */ /* 0x00000001899E2460-0x00000001899E2480 */ get => default; /* [XID] */ /* 0x00000001899E99A0-0x00000001899E99C0 */ protected set {} } // 0x00000001837F76C0-0x00000001837F7760 0x00000001837F7760-0x00000001837F7810

	// Constructors
	public MaterialCodexExcelConfig() {} // 0x00000001837F99C0-0x00000001837F9A20

	// Methods
	// [IDTag] // 0x00000001899F1170-0x00000001899F11B0
	// [XID] // 0x00000001899F1170-0x00000001899F11B0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001837F7DB0-0x00000001837F8350
	// [IDTag] // 0x00000001899FBC90-0x00000001899FBCD0
	// [XID] // 0x00000001899FBC90-0x00000001899FBCD0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001837F7810-0x00000001837F7DB0
	// [XID] // 0x0000000189A061D0-0x0000000189A061F0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF074F */, bool useObjectPool = false /* Metadata: 0x00AF0753 */) => default; // 0x00000001837F8900-0x00000001837F90E0
	[BlackList] // 0x0000000189A0D740-0x0000000189A0D780
	// [XID] // 0x0000000189A0D740-0x0000000189A0D780
	public virtual void AutoAllocTypeFields() {} // 0x00000001837F73D0-0x00000001837F7470
	[BlackList] // 0x0000000189A179F0-0x0000000189A17A30
	// [XID] // 0x0000000189A179F0-0x0000000189A17A30
	public virtual void AutoRecycleTypeFields() {} // 0x00000001837F7470-0x00000001837F7570
	[BlackList] // 0x0000000189A22110-0x0000000189A22150
	// [XID] // 0x0000000189A22110-0x0000000189A22150
	public virtual void ReturnToObjectPool() {} // 0x00000001837F9920-0x00000001837F99C0
	[BlackList] // 0x0000000189A2C3F0-0x0000000189A2C430
	// [XID] // 0x0000000189A2C3F0-0x0000000189A2C430
	public virtual void OnPoolAllocated() {} // 0x00000001837F9660-0x00000001837F9700
	[BlackList] // 0x0000000189A36ED0-0x0000000189A36F10
	// [XID] // 0x0000000189A36ED0-0x0000000189A36F10
	public virtual void OnBeforePoolRecycled() {} // 0x00000001837F95C0-0x00000001837F9660
}

