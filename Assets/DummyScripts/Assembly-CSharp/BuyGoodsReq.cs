/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BuyGoodsReq : MessageBase, IMessage<BuyGoodsReq> // TypeDefIndex: 25425
{
	// Fields
	private static readonly MessageParser<BuyGoodsReq> _parser; // 0x00
	public const int ShopTypeFieldNumber = 1; // Metadata: 0x00B08BB7
	private uint shopType_; // 0x18
	public const int GoodsFieldNumber = 2; // Metadata: 0x00B08BBB
	private ShopGoods goods_; // 0x20
	public const int BuyCountFieldNumber = 3; // Metadata: 0x00B08BBF
	private uint buyCount_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BuyGoodsReq> Parser { get => default; } // 0x00000001839E9150-0x00000001839E91E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001839E8E40-0x00000001839E8ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001839E89E0-0x00000001839E8A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001839E80D0-0x00000001839E8130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001839E96C0-0x00000001839E97B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001839E94B0-0x00000001839E9510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001839E8ED0-0x00000001839E8FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001839E9670-0x00000001839E96C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001839E8BA0-0x00000001839E8C90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ShopType { get => default; set {} } // 0x00000001839E8B00-0x00000001839E8BA0 0x00000001839E90B0-0x00000001839E9150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShopGoods Goods { get => default; set {} } // 0x00000001839E9410-0x00000001839E94B0 0x00000001839E8760-0x00000001839E8800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BuyCount { get => default; set {} } // 0x00000001839E8130-0x00000001839E81D0 0x00000001839E9370-0x00000001839E9410

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25426
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25427
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 703
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BuyGoodsReq() {} // 0x00000001839E9AE0-0x00000001839E9B40
	static BuyGoodsReq() {} // 0x00000001839E9A20-0x00000001839E9AE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BuyGoodsReq Clone() => default; // 0x00000001839E8FC0-0x00000001839E90B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BuyGoodsReq ShallowCopy() => default; // 0x00000001839E8A60-0x00000001839E8B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001839E8380-0x00000001839E8400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001839E9270-0x00000001839E92F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001839E92F0-0x00000001839E9370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001839E8400-0x00000001839E8540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001839E8690-0x00000001839E8760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BuyGoodsReq other) => default; // 0x00000001839E8540-0x00000001839E8690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001839E8C90-0x00000001839E8E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001839E97B0-0x00000001839E9A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001839E9510-0x00000001839E9670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001839E8800-0x00000001839E89E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BuyGoodsReq other) {} // 0x00000001839E81D0-0x00000001839E8380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001839E7F70-0x00000001839E80D0
}

