/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ProductPriceTier : MessageBase, IMessage<ProductPriceTier> // TypeDefIndex: 24705
{
	// Fields
	private static readonly MessageParser<ProductPriceTier> _parser; // 0x00
	public const int ProductIdFieldNumber = 1; // Metadata: 0x00B070A7
	private string productId_; // 0x18
	public const int PriceTierFieldNumber = 2; // Metadata: 0x00B070AB
	private string priceTier_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ProductPriceTier> Parser { get => default; } // 0x0000000184CBCD40-0x0000000184CBCDD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184CBC8E0-0x0000000184CBC970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184CBC580-0x0000000184CBC600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184CBBE80-0x0000000184CBBEE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184CBD100-0x0000000184CBD1F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184CBCF00-0x0000000184CBCF60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184CBC970-0x0000000184CBCA60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184CBD0B0-0x0000000184CBD100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184CBC6A0-0x0000000184CBC790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ProductId { get => default; set {} } // 0x0000000184CBCB50-0x0000000184CBCBF0 0x0000000184CBCBF0-0x0000000184CBCCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string PriceTier { get => default; set {} } // 0x0000000184CBCCA0-0x0000000184CBCD40 0x0000000184CBC110-0x0000000184CBC1C0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ProductPriceTier() {} // 0x0000000184CBD470-0x0000000184CBD4F0
	static ProductPriceTier() {} // 0x0000000184CBD3B0-0x0000000184CBD470

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ProductPriceTier Clone() => default; // 0x0000000184CBCA60-0x0000000184CBCB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ProductPriceTier ShallowCopy() => default; // 0x0000000184CBC600-0x0000000184CBC6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184CBC040-0x0000000184CBC090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184CBCE60-0x0000000184CBCEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184CBCEB0-0x0000000184CBCF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184CBC090-0x0000000184CBC110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184CBC350-0x0000000184CBC420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ProductPriceTier other) => default; // 0x0000000184CBC1C0-0x0000000184CBC350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184CBC790-0x0000000184CBC8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184CBD1F0-0x0000000184CBD3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184CBCF60-0x0000000184CBD0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184CBC420-0x0000000184CBC580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ProductPriceTier other) {} // 0x0000000184CBBEE0-0x0000000184CBC040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184CBBD80-0x0000000184CBBE80
}

