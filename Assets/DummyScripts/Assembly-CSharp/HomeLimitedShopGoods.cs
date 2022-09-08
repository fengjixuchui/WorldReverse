/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeLimitedShopGoods : MessageBase, IMessage<HomeLimitedShopGoods> // TypeDefIndex: 23494
{
	// Fields
	private static readonly MessageParser<HomeLimitedShopGoods> _parser; // 0x00
	public const int GoodsIdFieldNumber = 1; // Metadata: 0x00B0424B
	private uint goodsId_; // 0x18
	public const int GoodsItemFieldNumber = 2; // Metadata: 0x00B0424F
	private ItemParam goodsItem_; // 0x20
	public const int CostItemListFieldNumber = 3; // Metadata: 0x00B04253
	private static readonly FieldCodec<ItemParam> _repeated_costItemList_codec; // 0x08
	private readonly RepeatedMessageField<ItemParam> costItemList_; // 0x28
	public const int BoughtNumFieldNumber = 4; // Metadata: 0x00B04257
	private uint boughtNum_; // 0x30
	public const int BuyLimitFieldNumber = 5; // Metadata: 0x00B0425B
	private uint buyLimit_; // 0x34

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeLimitedShopGoods> Parser { get => default; } // 0x00000001827F9330-0x00000001827F93C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001827F8F80-0x00000001827F9010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001827F8AC0-0x00000001827F8B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001827F7ED0-0x00000001827F7F30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001827F98E0-0x00000001827F99D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001827F9590-0x00000001827F95F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001827F90B0-0x00000001827F91A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001827F9890-0x00000001827F98E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001827F8C80-0x00000001827F8D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GoodsId { get => default; set {} } // 0x00000001827F8BE0-0x00000001827F8C80 0x00000001827F7F30-0x00000001827F7FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ItemParam GoodsItem { get => default; set {} } // 0x00000001827F8290-0x00000001827F8330 0x00000001827F95F0-0x00000001827F9690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> CostItemList { get => default; } // 0x00000001827F8A60-0x00000001827F8AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BoughtNum { get => default; set {} } // 0x00000001827F99D0-0x00000001827F9A70 0x00000001827F7FD0-0x00000001827F8070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BuyLimit { get => default; set {} } // 0x00000001827F9010-0x00000001827F90B0 0x00000001827F9290-0x00000001827F9330

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeLimitedShopGoods() {} // 0x00000001827F9EF0-0x00000001827F9F80
	static HomeLimitedShopGoods() {} // 0x00000001827F9DE0-0x00000001827F9EF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeLimitedShopGoods Clone() => default; // 0x00000001827F91A0-0x00000001827F9290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeLimitedShopGoods ShallowCopy() => default; // 0x00000001827F8B40-0x00000001827F8BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001827F8330-0x00000001827F83B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001827F9450-0x00000001827F94F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001827F94F0-0x00000001827F9590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001827F83B0-0x00000001827F8570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001827F8570-0x00000001827F8640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeLimitedShopGoods other) => default; // 0x00000001827F8640-0x00000001827F87E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001827F8D70-0x00000001827F8F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001827F9A70-0x00000001827F9DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001827F9690-0x00000001827F9890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001827F87E0-0x00000001827F8A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeLimitedShopGoods other) {} // 0x00000001827F8070-0x00000001827F8290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001827F7CE0-0x00000001827F7ED0
}

