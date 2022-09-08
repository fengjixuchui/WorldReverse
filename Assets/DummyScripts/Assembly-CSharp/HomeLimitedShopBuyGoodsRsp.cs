/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeLimitedShopBuyGoodsRsp : MessageBase, IMessage<HomeLimitedShopBuyGoodsRsp> // TypeDefIndex: 23505
{
	// Fields
	private static readonly MessageParser<HomeLimitedShopBuyGoodsRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B042AB
	private int retcode_; // 0x18
	public const int GoodsFieldNumber = 2; // Metadata: 0x00B042AF
	private HomeLimitedShopGoods goods_; // 0x20
	public const int BuyCountFieldNumber = 3; // Metadata: 0x00B042B3
	private uint buyCount_; // 0x28
	public const int GoodsListFieldNumber = 4; // Metadata: 0x00B042B7
	private static readonly FieldCodec<HomeLimitedShopGoods> _repeated_goodsList_codec; // 0x08
	private readonly RepeatedMessageField<HomeLimitedShopGoods> goodsList_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeLimitedShopBuyGoodsRsp> Parser { get => default; } // 0x0000000185166070-0x0000000185166100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185165E00-0x0000000185165E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001851659C0-0x0000000185165A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185164E30-0x0000000185164E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185166670-0x0000000185166760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185166410-0x0000000185166470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185165E90-0x0000000185165F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185166620-0x0000000185166670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185165AE0-0x0000000185165BD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000185165920-0x00000001851659C0 0x0000000185165360-0x0000000185165400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeLimitedShopGoods Goods { get => default; set {} } // 0x0000000185166370-0x0000000185166410 0x0000000185165650-0x00000001851656F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BuyCount { get => default; set {} } // 0x0000000185164E90-0x0000000185164F30 0x00000001851662D0-0x0000000185166370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<HomeLimitedShopGoods> GoodsList { get => default; } // 0x0000000185165DA0-0x0000000185165E00 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23506
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23507
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4656
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeLimitedShopBuyGoodsRsp() {} // 0x0000000185166B50-0x0000000185166BE0
	static HomeLimitedShopBuyGoodsRsp() {} // 0x0000000185166A40-0x0000000185166B50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeLimitedShopBuyGoodsRsp Clone() => default; // 0x0000000185165F80-0x0000000185166070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeLimitedShopBuyGoodsRsp ShallowCopy() => default; // 0x0000000185165A40-0x0000000185165AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185165130-0x00000001851651B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185166190-0x0000000185166230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185166230-0x00000001851662D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001851651B0-0x0000000185165360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185165580-0x0000000185165650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeLimitedShopBuyGoodsRsp other) => default; // 0x0000000185165400-0x0000000185165580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185165BD0-0x0000000185165DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185166760-0x0000000185166A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185166470-0x0000000185166620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001851656F0-0x0000000185165920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeLimitedShopBuyGoodsRsp other) {} // 0x0000000185164F30-0x0000000185165130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185164C60-0x0000000185164E30
}

