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
public class ItemConfig : IComparable<ItemConfig>, IAutoAllocRecycle // TypeDefIndex: 14843
{
	// Fields
	public const uint COIN_ITEM_ID = 202; // Metadata: 0x00AEF756
	public const uint CRYSTAL_ITEM_ID = 201; // Metadata: 0x00AEF75A
	public const uint MCOIN_ITEM_ID = 203; // Metadata: 0x00AEF75E
	public const uint RESIN_ITEM_ID = 106; // Metadata: 0x00AEF762
	public const uint LEGENDARY_KEY_ITEM_ID = 107; // Metadata: 0x00AEF766
	public const uint ACTIVITY_ASTER_CREDIT_ITEM_ID = 109; // Metadata: 0x00AEF76A
	public const uint ACTIVITY_ASTER_TOKEN_ITEM_ID = 110; // Metadata: 0x00AEF76E
	public const uint ACTIVITY_DRAGONSPINE_SHIMMERING_ESSENCE_ITEM_ID = 111; // Metadata: 0x00AEF772
	public const uint ACTIVITY_DRAGONSPINE_WARM_ESSENCE_ITEM_ID = 112; // Metadata: 0x00AEF776
	public const uint ACTIVITY_DRAGONSPINE_WONDROUS_ESSENCE_ITEM_ID = 113; // Metadata: 0x00AEF77A
	public const uint ACTIVITY_TREASUREHUNT_COIN_ITEM_ID = 114; // Metadata: 0x00AEF77E
	public const uint ACTIVITY_SEALAMP_TAILSMAN = 115; // Metadata: 0x00AEF782
	public const uint ACTIVITY_SEALAMP_POPULARITY = 116; // Metadata: 0x00AEF786
	public const uint ACTIVITY_MECHANICUS_COIN_ITEM_ID = 117; // Metadata: 0x00AEF78A
	public const uint ACTIVITY_FLEURFAIR_MINIGAME_COIN_ITEM_ID = 118; // Metadata: 0x00AEF78E
	public const uint ACTIVITY_FLEURFAIR_DUNGEON_COIN_ITEM_ID = 119; // Metadata: 0x00AEF792
	public const uint ACTIVITY_WATER_SPRITE_COIN_ITEM_ID = 120; // Metadata: 0x00AEF796
	public const uint HOME_WORLD_EXP_ITEM_ID = 121; // Metadata: 0x00AEF79A
	public const uint ACTIVITY_CHANNELLER_SLAB_COIN_ITEM_ID = 122; // Metadata: 0x00AEF79E
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _nameTextMapHash; // 0x14
	protected uint _descTextMapHash; // 0x18
	protected string _icon; // 0x20
	protected ItemType _itemType; // 0x28
	protected SimpleSafeUInt32 weightRawNum; // 0x2C
	protected SimpleSafeUInt32 rankRawNum; // 0x30
	protected SimpleSafeUInt32 gadgetIdRawNum; // 0x34
	protected bool _dropable; // 0x38
	protected SimpleSafeUInt32 useLevelRawNum; // 0x3C
	protected SimpleSafeUInt32 globalItemLimitRawNum; // 0x40

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189983950-0x0000000189983970 */ get => default; /* [XID] */ /* 0x000000018998B1A0-0x000000018998B1C0 */ protected set {} } // 0x0000000183842E60-0x0000000183842F30 0x0000000183841A00-0x0000000183841AE0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x0000000189992D30-0x0000000189992D50 */ get => default; /* [XID] */ /* 0x000000018999A950-0x000000018999A970 */ protected set {} } // 0x0000000183840970-0x0000000183840A10 0x00000001838427E0-0x0000000183842890
	public string name { /* [XID] */ /* 0x00000001899A1FF0-0x00000001899A2010 */ get => default; } // 0x00000001838430D0-0x0000000183843250 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x00000001899A9880-0x00000001899A98A0 */ get => default; /* [XID] */ /* 0x00000001899B12D0-0x00000001899B12F0 */ protected set {} } // 0x0000000183842740-0x00000001838427E0 0x0000000183840A10-0x0000000183840AC0
	public string desc { /* [XID] */ /* 0x00000001899B85D0-0x00000001899B85F0 */ get => default; } // 0x00000001838416E0-0x0000000183841860 
	public string icon { /* [XID] */ /* 0x00000001899C00B0-0x00000001899C00D0 */ get => default; /* [XID] */ /* 0x00000001899C7850-0x00000001899C7870 */ protected set {} } // 0x0000000183840650-0x00000001838406F0 0x0000000183842890-0x0000000183842940
	public ItemType itemType { /* [XID] */ /* 0x00000001899CF040-0x00000001899CF060 */ get => default; /* [XID] */ /* 0x00000001899D65D0-0x00000001899D65F0 */ protected set {} } // 0x00000001838408D0-0x0000000183840970 0x0000000183842B20-0x0000000183842BD0
	public uint weight { /* [XID] */ /* 0x00000001899DDB00-0x00000001899DDB20 */ get => default; /* [XID] */ /* 0x00000001899E58A0-0x00000001899E58C0 */ protected set {} } // 0x0000000183842F30-0x0000000183843000 0x0000000183841480-0x0000000183841560
	public uint rank { /* [XID] */ /* 0x00000001899EC9B0-0x00000001899EC9D0 */ get => default; /* [XID] */ /* 0x00000001899F47B0-0x00000001899F47D0 */ protected set {} } // 0x0000000183842940-0x0000000183842A10 0x00000001838424E0-0x00000001838425C0
	public uint gadgetId { /* [XID] */ /* 0x00000001899FBDB0-0x00000001899FBDD0 */ get => default; /* [XID] */ /* 0x0000000189A03150-0x0000000189A03170 */ protected set {} } // 0x0000000183841860-0x0000000183841930 0x0000000183841560-0x0000000183841640
	public bool dropable { /* [XID] */ /* 0x0000000189A0A6E0-0x0000000189A0A700 */ get => default; /* [XID] */ /* 0x0000000189A11F40-0x0000000189A11F60 */ protected set {} } // 0x0000000183841640-0x00000001838416E0 0x00000001838425C0-0x0000000183842670
	public uint useLevel { /* [XID] */ /* 0x0000000189A19370-0x0000000189A19390 */ get => default; /* [XID] */ /* 0x0000000189A20A30-0x0000000189A20A50 */ protected set {} } // 0x0000000183841930-0x0000000183841A00 0x0000000183840570-0x0000000183840650
	public uint globalItemLimit { /* [XID] */ /* 0x0000000189A27DC0-0x0000000189A27DE0 */ get => default; /* [XID] */ /* 0x0000000189A2F5B0-0x0000000189A2F5D0 */ protected set {} } // 0x0000000183843000-0x00000001838430D0 0x0000000183842400-0x00000001838424E0

	// Constructors
	public ItemConfig() {} // 0x00000001838432F0-0x0000000183843350

	// Methods
	// [XID] // 0x000000018995E010-0x000000018995E030
	public static ItemConfig GetItemConfig(uint itemID) => default; // 0x00000001838412C0-0x0000000183841480
	// [XID] // 0x00000001899657D0-0x00000001899657F0
	public static uint GetItemQualityType(uint itemID) => default; // 0x0000000183842BD0-0x0000000183842D20
	// [XID] // 0x000000018996CF70-0x000000018996CF90
	public static string GetQualityColor(QualityType quality) => default; // 0x0000000183842A10-0x0000000183842B20
	// [XID] // 0x00000001899747F0-0x0000000189974810
	public int CompareTo(ItemConfig other) => default; // 0x0000000183840AC0-0x0000000183840C30
	// [XID] // 0x000000018997BDC0-0x000000018997BDE0
	private int GetItemSortPriority() => default; // 0x0000000183842670-0x0000000183842740
	// [XID] // 0x0000000189A36FF0-0x0000000189A37010
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183840C30-0x00000001838412C0
	// [XID] // 0x0000000189A3E5F0-0x0000000189A3E610
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF751 */, bool useObjectPool = false /* Metadata: 0x00AEF755 */) => default; // 0x0000000183841AE0-0x0000000183842400
	[BlackList] // 0x0000000189A45C60-0x0000000189A45CA0
	// [XID] // 0x0000000189A45C60-0x0000000189A45CA0
	public virtual void AutoAllocTypeFields() {} // 0x00000001838406F0-0x0000000183840790
	[BlackList] // 0x0000000189A504A0-0x0000000189A504E0
	// [XID] // 0x0000000189A504A0-0x0000000189A504E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183840790-0x00000001838408D0
	[BlackList] // 0x0000000189A5AA90-0x0000000189A5AAD0
	// [XID] // 0x0000000189A5AA90-0x0000000189A5AAD0
	public virtual void ReturnToObjectPool() {} // 0x0000000183843250-0x00000001838432F0
	[BlackList] // 0x0000000189A656C0-0x0000000189A65700
	// [XID] // 0x0000000189A656C0-0x0000000189A65700
	public virtual void OnPoolAllocated() {} // 0x0000000183842DC0-0x0000000183842E60
	[BlackList] // 0x0000000189A6FE20-0x0000000189A6FE60
	// [XID] // 0x0000000189A6FE20-0x0000000189A6FE60
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183842D20-0x0000000183842DC0
}

