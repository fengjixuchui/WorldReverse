/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ShopGoods : MessageBase, IMessage<ShopGoods> // TypeDefIndex: 25417
{
	// Fields
	private static readonly MessageParser<ShopGoods> _parser; // 0x00
	public const int GoodsIdFieldNumber = 1; // Metadata: 0x00B08B2B
	private uint goodsId_; // 0x18
	public const int GoodsItemFieldNumber = 2; // Metadata: 0x00B08B2F
	private ItemParam goodsItem_; // 0x20
	public const int ScoinFieldNumber = 3; // Metadata: 0x00B08B33
	private uint scoin_; // 0x28
	public const int HcoinFieldNumber = 4; // Metadata: 0x00B08B37
	private uint hcoin_; // 0x2C
	public const int CostItemListFieldNumber = 5; // Metadata: 0x00B08B3B
	private static readonly FieldCodec<ItemParam> _repeated_costItemList_codec; // 0x08
	private readonly RepeatedMessageField<ItemParam> costItemList_; // 0x30
	public const int BoughtNumFieldNumber = 6; // Metadata: 0x00B08B3F
	private uint boughtNum_; // 0x38
	public const int BuyLimitFieldNumber = 7; // Metadata: 0x00B08B43
	private uint buyLimit_; // 0x3C
	public const int BeginTimeFieldNumber = 8; // Metadata: 0x00B08B47
	private uint beginTime_; // 0x40
	public const int EndTimeFieldNumber = 9; // Metadata: 0x00B08B4B
	private uint endTime_; // 0x44
	public const int NextRefreshTimeFieldNumber = 10; // Metadata: 0x00B08B4F
	private uint nextRefreshTime_; // 0x48
	public const int MinLevelFieldNumber = 11; // Metadata: 0x00B08B53
	private uint minLevel_; // 0x4C
	public const int MaxLevelFieldNumber = 12; // Metadata: 0x00B08B57
	private uint maxLevel_; // 0x50
	public const int PreGoodsIdListFieldNumber = 13; // Metadata: 0x00B08B5B
	private static readonly FieldCodec<uint> _repeated_preGoodsIdList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> preGoodsIdList_; // 0x58
	public const int McoinFieldNumber = 14; // Metadata: 0x00B08B5F
	private uint mcoin_; // 0x60
	public const int DisableTypeFieldNumber = 15; // Metadata: 0x00B08B63
	private uint disableType_; // 0x64
	public const int SecondarySheetIdFieldNumber = 16; // Metadata: 0x00B08B67
	private uint secondarySheetId_; // 0x68

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ShopGoods> Parser { get => default; } // 0x000000018282F630-0x000000018282F6C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018282EF60-0x000000018282EFF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018282E840-0x000000018282E8C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018282D2E0-0x000000018282D340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182830310-0x0000000182830400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018282F9D0-0x000000018282FA30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018282F1D0-0x000000018282F2C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001828302C0-0x0000000182830310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018282EAA0-0x000000018282EB90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GoodsId { get => default; set {} } // 0x000000018282EA00-0x000000018282EAA0 0x000000018282D340-0x000000018282D3E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ItemParam GoodsItem { get => default; set {} } // 0x000000018282D980-0x000000018282DA20 0x000000018282FA30-0x000000018282FAD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Scoin { get => default; set {} } // 0x00000001828300E0-0x0000000182830180 0x0000000182830220-0x00000001828302C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Hcoin { get => default; set {} } // 0x000000018282E740-0x000000018282E7E0 0x000000018282F590-0x000000018282F630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> CostItemList { get => default; } // 0x000000018282E7E0-0x000000018282E840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BoughtNum { get => default; set {} } // 0x0000000182830460-0x0000000182830500 0x000000018282D3E0-0x000000018282D480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BuyLimit { get => default; set {} } // 0x000000018282F090-0x000000018282F130 0x000000018282F450-0x000000018282F4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BeginTime { get => default; set {} } // 0x0000000182830180-0x0000000182830220 0x000000018282F890-0x000000018282F930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EndTime { get => default; set {} } // 0x000000018282F3B0-0x000000018282F450 0x000000018282F930-0x000000018282F9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NextRefreshTime { get => default; set {} } // 0x000000018282F4F0-0x000000018282F590 0x0000000182830500-0x00000001828305A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MinLevel { get => default; set {} } // 0x00000001828305A0-0x0000000182830640 0x000000018282FB70-0x000000018282FC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MaxLevel { get => default; set {} } // 0x000000018282D240-0x000000018282D2E0 0x000000018282D520-0x000000018282D5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> PreGoodsIdList { get => default; } // 0x0000000182830400-0x0000000182830460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Mcoin { get => default; set {} } // 0x000000018282FAD0-0x000000018282FB70 0x000000018282D480-0x000000018282D520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DisableType { get => default; set {} } // 0x000000018282DA20-0x000000018282DAC0 0x000000018282F130-0x000000018282F1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SecondarySheetId { get => default; set {} } // 0x000000018282EFF0-0x000000018282F090 0x000000018282E8C0-0x000000018282E960

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShopGoods() {} // 0x00000001828310B0-0x0000000182831160
	static ShopGoods() {} // 0x0000000182830F80-0x00000001828310B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShopGoods Clone() => default; // 0x000000018282F2C0-0x000000018282F3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShopGoods ShallowCopy() => default; // 0x000000018282E960-0x000000018282EA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018282DAC0-0x000000018282DB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018282F750-0x000000018282F7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018282F7F0-0x000000018282F890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018282DB40-0x000000018282DDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018282DDD0-0x000000018282DEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ShopGoods other) => default; // 0x000000018282DEA0-0x000000018282E190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018282EB90-0x000000018282EF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182830640-0x0000000182830F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018282FC10-0x00000001828300E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018282E190-0x000000018282E740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ShopGoods other) {} // 0x000000018282D5C0-0x000000018282D980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018282CEB0-0x000000018282D240
}

