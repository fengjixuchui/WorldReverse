/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BuyGoodsRsp : MessageBase, IMessage<BuyGoodsRsp> // TypeDefIndex: 25428
{
	// Fields
	private static readonly MessageParser<BuyGoodsRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B08BD7
	private int retcode_; // 0x18
	public const int ShopTypeFieldNumber = 2; // Metadata: 0x00B08BDB
	private uint shopType_; // 0x1C
	public const int GoodsFieldNumber = 3; // Metadata: 0x00B08BDF
	private ShopGoods goods_; // 0x20
	public const int BuyCountFieldNumber = 4; // Metadata: 0x00B08BE3
	private uint buyCount_; // 0x28
	public const int GoodsListFieldNumber = 5; // Metadata: 0x00B08BE7
	private static readonly FieldCodec<ShopGoods> _repeated_goodsList_codec; // 0x08
	private readonly RepeatedMessageField<ShopGoods> goodsList_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BuyGoodsRsp> Parser { get => default; } // 0x0000000185121B80-0x0000000185121C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185121870-0x0000000185121900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185121350-0x00000001851213D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185120720-0x0000000185120780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001851221C0-0x00000001851222B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185121F20-0x0000000185121F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185121900-0x00000001851219F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185122170-0x00000001851221C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185121510-0x0000000185121600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001851212B0-0x0000000185121350 0x0000000185120C80-0x0000000185120D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ShopType { get => default; set {} } // 0x0000000185121470-0x0000000185121510 0x0000000185121AE0-0x0000000185121B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShopGoods Goods { get => default; set {} } // 0x0000000185121E80-0x0000000185121F20 0x0000000185120F90-0x0000000185121030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BuyCount { get => default; set {} } // 0x0000000185120780-0x0000000185120820 0x0000000185121DE0-0x0000000185121E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ShopGoods> GoodsList { get => default; } // 0x0000000185121810-0x0000000185121870 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25429
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25430
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 704
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BuyGoodsRsp() {} // 0x0000000185122730-0x00000001851227C0
	static BuyGoodsRsp() {} // 0x0000000185122620-0x0000000185122730

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BuyGoodsRsp Clone() => default; // 0x00000001851219F0-0x0000000185121AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BuyGoodsRsp ShallowCopy() => default; // 0x00000001851213D0-0x0000000185121470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185120A40-0x0000000185120AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185121CA0-0x0000000185121D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185121D40-0x0000000185121DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185120AC0-0x0000000185120C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185120EC0-0x0000000185120F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BuyGoodsRsp other) => default; // 0x0000000185120D20-0x0000000185120EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185121600-0x0000000185121810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001851222B0-0x0000000185122620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185121F80-0x0000000185122170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185121030-0x00000001851212B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BuyGoodsRsp other) {} // 0x0000000185120820-0x0000000185120A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185120530-0x0000000185120720
}

