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
public class ShopmallEntranceExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16132
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 IDRawNum; // 0x10
	protected uint _nameTextMapHash; // 0x14
	protected SimpleSafeUInt32[] _subTabList; // 0x18
	protected ShopType _shopType; // 0x20
	protected string _icon; // 0x28
	protected ShopmallEntranceType _showType; // 0x30
	protected SimpleSafeUInt32 orderRawNum; // 0x34

	// Properties
	public uint ID { /* [XID] */ /* 0x00000001897E7670-0x00000001897E7690 */ get => default; /* [XID] */ /* 0x00000001897EF210-0x00000001897EF230 */ protected set {} } // 0x00000001841FFEF0-0x00000001841FFFC0 0x00000001841FE9D0-0x00000001841FEAB0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x00000001897F6860-0x00000001897F6880 */ get => default; /* [XID] */ /* 0x00000001897FDF00-0x00000001897FDF20 */ protected set {} } // 0x00000001841FEE40-0x00000001841FEEE0 0x0000000184200740-0x00000001842007F0
	public string name { /* [XID] */ /* 0x0000000189805750-0x0000000189805770 */ get => default; } // 0x00000001842009E0-0x0000000184200B60 
	public SimpleSafeUInt32[] subTabList { /* [XID] */ /* 0x000000018980CD50-0x000000018980CD70 */ get => default; /* [XID] */ /* 0x00000001898145B0-0x00000001898145D0 */ protected set {} } // 0x00000001841FFE50-0x00000001841FFEF0 0x00000001841FE920-0x00000001841FE9D0
	public ShopType shopType { /* [XID] */ /* 0x000000018981C040-0x000000018981C060 */ get => default; /* [XID] */ /* 0x00000001898234D0-0x00000001898234F0 */ protected set {} } // 0x00000001841FFD10-0x00000001841FFDB0 0x00000001841FED90-0x00000001841FEE40
	public string icon { /* [XID] */ /* 0x000000018982AF10-0x000000018982AF30 */ get => default; /* [XID] */ /* 0x00000001898323F0-0x0000000189832410 */ protected set {} } // 0x00000001841FEAB0-0x00000001841FEB50 0x00000001842007F0-0x00000001842008A0
	public ShopmallEntranceType showType { /* [XID] */ /* 0x00000001898399E0-0x0000000189839A00 */ get => default; /* [XID] */ /* 0x0000000189840F20-0x0000000189840F40 */ protected set {} } // 0x00000001841FFDB0-0x00000001841FFE50 0x00000001841FECE0-0x00000001841FED90
	public uint order { /* [XID] */ /* 0x0000000189848380-0x00000001898483A0 */ get => default; /* [XID] */ /* 0x000000018984FB20-0x000000018984FB40 */ protected set {} } // 0x00000001841FEEE0-0x00000001841FEFB0 0x00000001841FFFC0-0x00000001842000A0

	// Constructors
	public ShopmallEntranceExcelConfig() {} // 0x0000000184200C00-0x0000000184200C60

	// Methods
	// [IDTag] // 0x0000000189856EC0-0x0000000189856F00
	// [XID] // 0x0000000189856EC0-0x0000000189856F00
	public virtual bool ParseFromLine(string line) => default; // 0x00000001841FF650-0x00000001841FFD10
	// [IDTag] // 0x0000000189861310-0x0000000189861350
	// [XID] // 0x0000000189861310-0x0000000189861350
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001841FEFB0-0x00000001841FF650
	// [XID] // 0x000000018986BB40-0x000000018986BB60
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF320E */, bool useObjectPool = false /* Metadata: 0x00AF3212 */) => default; // 0x00000001842000A0-0x0000000184200740
	[BlackList] // 0x0000000189872DD0-0x0000000189872E10
	// [XID] // 0x0000000189872DD0-0x0000000189872E10
	public virtual void AutoAllocTypeFields() {} // 0x00000001841FEB50-0x00000001841FEBF0
	[BlackList] // 0x000000018987DB40-0x000000018987DB80
	// [XID] // 0x000000018987DB40-0x000000018987DB80
	public virtual void AutoRecycleTypeFields() {} // 0x00000001841FEBF0-0x00000001841FECE0
	[BlackList] // 0x0000000189887BA0-0x0000000189887BE0
	// [XID] // 0x0000000189887BA0-0x0000000189887BE0
	public virtual void ReturnToObjectPool() {} // 0x0000000184200B60-0x0000000184200C00
	[BlackList] // 0x0000000189891DC0-0x0000000189891E00
	// [XID] // 0x0000000189891DC0-0x0000000189891E00
	public virtual void OnPoolAllocated() {} // 0x0000000184200940-0x00000001842009E0
	[BlackList] // 0x000000018989C4A0-0x000000018989C4E0
	// [XID] // 0x000000018989C4A0-0x000000018989C4E0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001842008A0-0x0000000184200940
}

