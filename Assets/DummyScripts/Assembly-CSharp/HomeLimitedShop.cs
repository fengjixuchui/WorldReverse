/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeLimitedShop : MessageBase, IMessage<HomeLimitedShop> // TypeDefIndex: 23495
{
	// Fields
	private static readonly MessageParser<HomeLimitedShop> _parser; // 0x00
	public const int GoodsListFieldNumber = 1; // Metadata: 0x00B0425F
	private static readonly FieldCodec<HomeLimitedShopGoods> _repeated_goodsList_codec; // 0x08
	private readonly RepeatedMessageField<HomeLimitedShopGoods> goodsList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeLimitedShop> Parser { get => default; } // 0x0000000182B76130-0x0000000182B761C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182B75EC0-0x0000000182B75F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182B75B90-0x0000000182B75C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182B75610-0x0000000182B75670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182B76520-0x0000000182B76610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182B76370-0x0000000182B763D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182B75F50-0x0000000182B76040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182B764D0-0x0000000182B76520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182B75CB0-0x0000000182B75DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<HomeLimitedShopGoods> GoodsList { get => default; } // 0x0000000182B75E60-0x0000000182B75EC0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeLimitedShop() {} // 0x0000000182B76870-0x0000000182B76940
	static HomeLimitedShop() {} // 0x0000000182B76760-0x0000000182B76870

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeLimitedShop Clone() => default; // 0x0000000182B76040-0x0000000182B76130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeLimitedShop ShallowCopy() => default; // 0x0000000182B75C10-0x0000000182B75CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182B757A0-0x0000000182B757F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182B76250-0x0000000182B762E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182B762E0-0x0000000182B76370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182B757F0-0x0000000182B758C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182B758C0-0x0000000182B75990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeLimitedShop other) => default; // 0x0000000182B75990-0x0000000182B75AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182B75DA0-0x0000000182B75E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182B76610-0x0000000182B76760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182B763D0-0x0000000182B764D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182B75AA0-0x0000000182B75B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeLimitedShop other) {} // 0x0000000182B75670-0x0000000182B757A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182B754E0-0x0000000182B75610
}

