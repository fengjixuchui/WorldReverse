/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeLimitedShopInfoChangeNotify : MessageBase, IMessage<HomeLimitedShopInfoChangeNotify> // TypeDefIndex: 23508
{
	// Fields
	private static readonly MessageParser<HomeLimitedShopInfoChangeNotify> _parser; // 0x00
	public const int GoodsListFieldNumber = 1; // Metadata: 0x00B042CB
	private static readonly FieldCodec<HomeLimitedShopGoods> _repeated_goodsList_codec; // 0x08
	private readonly RepeatedMessageField<HomeLimitedShopGoods> goodsList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeLimitedShopInfoChangeNotify> Parser { get => default; } // 0x00000001820DF4D0-0x00000001820DF560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001820DF260-0x00000001820DF2F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001820DEF30-0x00000001820DEFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001820DE9B0-0x00000001820DEA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001820DF8C0-0x00000001820DF9B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001820DF710-0x00000001820DF770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001820DF2F0-0x00000001820DF3E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001820DF870-0x00000001820DF8C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001820DF050-0x00000001820DF140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<HomeLimitedShopGoods> GoodsList { get => default; } // 0x00000001820DF200-0x00000001820DF260 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23509
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23510
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4657
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeLimitedShopInfoChangeNotify() {} // 0x00000001820DFC10-0x00000001820DFCA0
	static HomeLimitedShopInfoChangeNotify() {} // 0x00000001820DFB00-0x00000001820DFC10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeLimitedShopInfoChangeNotify Clone() => default; // 0x00000001820DF3E0-0x00000001820DF4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeLimitedShopInfoChangeNotify ShallowCopy() => default; // 0x00000001820DEFB0-0x00000001820DF050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001820DEB40-0x00000001820DEB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820DF5F0-0x00000001820DF680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820DF680-0x00000001820DF710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001820DEB90-0x00000001820DEC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001820DEC60-0x00000001820DED30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeLimitedShopInfoChangeNotify other) => default; // 0x00000001820DED30-0x00000001820DEE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001820DF140-0x00000001820DF200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001820DF9B0-0x00000001820DFB00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001820DF770-0x00000001820DF870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001820DEE40-0x00000001820DEF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeLimitedShopInfoChangeNotify other) {} // 0x00000001820DEA10-0x00000001820DEB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001820DE880-0x00000001820DE9B0
}

