/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeLimitedShopBuyGoodsReq : MessageBase, IMessage<HomeLimitedShopBuyGoodsReq> // TypeDefIndex: 23502
{
	// Fields
	private static readonly MessageParser<HomeLimitedShopBuyGoodsReq> _parser; // 0x00
	public const int GoodsFieldNumber = 1; // Metadata: 0x00B0428F
	private HomeLimitedShopGoods goods_; // 0x18
	public const int BuyCountFieldNumber = 2; // Metadata: 0x00B04293
	private uint buyCount_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeLimitedShopBuyGoodsReq> Parser { get => default; } // 0x0000000182986270-0x0000000182986300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182986000-0x0000000182986090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182985C70-0x0000000182985CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001829853F0-0x0000000182985450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001829867A0-0x0000000182986890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001829865D0-0x0000000182986630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182986090-0x0000000182986180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182986750-0x00000001829867A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182985D90-0x0000000182985E80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeLimitedShopGoods Goods { get => default; set {} } // 0x0000000182986530-0x00000001829865D0 0x0000000182985A30-0x0000000182985AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BuyCount { get => default; set {} } // 0x0000000182985450-0x00000001829854F0 0x0000000182986490-0x0000000182986530

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23503
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23504
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4655
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeLimitedShopBuyGoodsReq() {} // 0x0000000182986B30-0x0000000182986B90
	static HomeLimitedShopBuyGoodsReq() {} // 0x0000000182986A70-0x0000000182986B30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeLimitedShopBuyGoodsReq Clone() => default; // 0x0000000182986180-0x0000000182986270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeLimitedShopBuyGoodsReq ShallowCopy() => default; // 0x0000000182985CF0-0x0000000182985D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182985680-0x0000000182985700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182986390-0x0000000182986410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182986410-0x0000000182986490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182985700-0x0000000182985830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182985960-0x0000000182985A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeLimitedShopBuyGoodsReq other) => default; // 0x0000000182985830-0x0000000182985960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182985E80-0x0000000182986000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182986890-0x0000000182986A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182986630-0x0000000182986750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182985AD0-0x0000000182985C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeLimitedShopBuyGoodsReq other) {} // 0x00000001829854F0-0x0000000182985680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001829852C0-0x00000001829853F0
}

