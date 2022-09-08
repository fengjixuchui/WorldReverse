/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Shop : MessageBase, IMessage<Shop> // TypeDefIndex: 25418
{
	// Fields
	private static readonly MessageParser<Shop> _parser; // 0x00
	public const int ShopTypeFieldNumber = 1; // Metadata: 0x00B08B6B
	private uint shopType_; // 0x18
	public const int GoodsListFieldNumber = 2; // Metadata: 0x00B08B6F
	private static readonly FieldCodec<ShopGoods> _repeated_goodsList_codec; // 0x08
	private readonly RepeatedMessageField<ShopGoods> goodsList_; // 0x20
	public const int McoinProductListFieldNumber = 3; // Metadata: 0x00B08B73
	private static readonly FieldCodec<ShopMcoinProduct> _repeated_mcoinProductList_codec; // 0x10
	private readonly RepeatedMessageField<ShopMcoinProduct> mcoinProductList_; // 0x28
	public const int CardProductListFieldNumber = 4; // Metadata: 0x00B08B77
	private static readonly FieldCodec<ShopCardProduct> _repeated_cardProductList_codec; // 0x18
	private readonly RepeatedMessageField<ShopCardProduct> cardProductList_; // 0x30
	public const int NextRefreshTimeFieldNumber = 6; // Metadata: 0x00B08B7B
	private uint nextRefreshTime_; // 0x38
	public const int CityIdFieldNumber = 7; // Metadata: 0x00B08B7F
	private uint cityId_; // 0x3C
	public const int CityReputationLevelFieldNumber = 8; // Metadata: 0x00B08B83
	private uint cityReputationLevel_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Shop> Parser { get => default; } // 0x00000001813F8B70-0x00000001813F8C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001813F8760-0x00000001813F87F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001813F8270-0x00000001813F82F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001813F77B0-0x00000001813F7810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001813F91D0-0x00000001813F92C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001813F8EB0-0x00000001813F8F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001813F87F0-0x00000001813F88E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001813F9180-0x00000001813F91D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001813F8430-0x00000001813F8520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ShopType { get => default; set {} } // 0x00000001813F8390-0x00000001813F8430 0x00000001813F8AD0-0x00000001813F8B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ShopGoods> GoodsList { get => default; } // 0x00000001813F8700-0x00000001813F8760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ShopMcoinProduct> McoinProductList { get => default; } // 0x00000001813F7F80-0x00000001813F7FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ShopCardProduct> CardProductList { get => default; } // 0x00000001813F8A70-0x00000001813F8AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NextRefreshTime { get => default; set {} } // 0x00000001813F89D0-0x00000001813F8A70 0x00000001813F92C0-0x00000001813F9360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CityId { get => default; set {} } // 0x00000001813F7A30-0x00000001813F7AD0 0x00000001813F8C90-0x00000001813F8D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CityReputationLevel { get => default; set {} } // 0x00000001813F7670-0x00000001813F7710 0x00000001813F7710-0x00000001813F77B0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Shop() {} // 0x00000001813F9980-0x00000001813F9A50
	static Shop() {} // 0x00000001813F97D0-0x00000001813F9980

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Shop Clone() => default; // 0x00000001813F88E0-0x00000001813F89D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Shop ShallowCopy() => default; // 0x00000001813F82F0-0x00000001813F8390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001813F7AD0-0x00000001813F7B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001813F8D30-0x00000001813F8DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001813F8DF0-0x00000001813F8EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001813F7B20-0x00000001813F7CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001813F7CC0-0x00000001813F7D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(Shop other) => default; // 0x00000001813F7D90-0x00000001813F7F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001813F8520-0x00000001813F8700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001813F9360-0x00000001813F97D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001813F8F10-0x00000001813F9180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001813F7FE0-0x00000001813F8270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(Shop other) {} // 0x00000001813F7810-0x00000001813F7A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001813F73F0-0x00000001813F7670
}

