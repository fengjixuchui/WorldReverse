/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ShopMcoinProduct : MessageBase, IMessage<ShopMcoinProduct> // TypeDefIndex: 26094
{
	// Fields
	private static readonly MessageParser<ShopMcoinProduct> _parser; // 0x00
	public const int ProductIdFieldNumber = 1; // Metadata: 0x00B0B1B3
	private string productId_; // 0x18
	public const int PriceTierFieldNumber = 2; // Metadata: 0x00B0B1B7
	private string priceTier_; // 0x20
	public const int McoinBaseFieldNumber = 3; // Metadata: 0x00B0B1BB
	private uint mcoinBase_; // 0x28
	public const int McoinNonFirstFieldNumber = 4; // Metadata: 0x00B0B1BF
	private uint mcoinNonFirst_; // 0x2C
	public const int McoinFirstFieldNumber = 5; // Metadata: 0x00B0B1C3
	private uint mcoinFirst_; // 0x30
	public const int BoughtNumFieldNumber = 6; // Metadata: 0x00B0B1C7
	private uint boughtNum_; // 0x34
	public const int IsAuditFieldNumber = 7; // Metadata: 0x00B0B1CB
	private bool isAudit_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ShopMcoinProduct> Parser { get => default; } // 0x000000018521FF40-0x000000018521FFD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018521F900-0x000000018521F990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018521F410-0x000000018521F490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018521E720-0x000000018521E780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185220440-0x0000000185220530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185220100-0x0000000185220160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018521FAD0-0x000000018521FBC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001852203F0-0x0000000185220440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018521F530-0x000000018521F620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ProductId { get => default; set {} } // 0x000000018521FCB0-0x000000018521FD50 0x000000018521FD50-0x000000018521FE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string PriceTier { get => default; set {} } // 0x000000018521FEA0-0x000000018521FF40 0x000000018521EDE0-0x000000018521EE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint McoinBase { get => default; set {} } // 0x000000018521F860-0x000000018521F900 0x000000018521FA30-0x000000018521FAD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint McoinNonFirst { get => default; set {} } // 0x000000018521E8C0-0x000000018521E960 0x000000018521E820-0x000000018521E8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint McoinFirst { get => default; set {} } // 0x000000018521FE00-0x000000018521FEA0 0x000000018521EA00-0x000000018521EAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BoughtNum { get => default; set {} } // 0x0000000185220530-0x00000001852205D0 0x000000018521E780-0x000000018521E820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAudit { get => default; set {} } // 0x000000018521E960-0x000000018521EA00 0x000000018521F990-0x000000018521FA30

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShopMcoinProduct() {} // 0x0000000185220B20-0x00000001852219D0
	static ShopMcoinProduct() {} // 0x0000000185220A60-0x0000000185220B20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShopMcoinProduct Clone() => default; // 0x000000018521FBC0-0x000000018521FCB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShopMcoinProduct ShallowCopy() => default; // 0x000000018521F490-0x000000018521F530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018521ECD0-0x000000018521ED20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185220060-0x00000001852200B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001852200B0-0x0000000185220100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018521ED20-0x000000018521EDE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018521EE90-0x000000018521EF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ShopMcoinProduct other) => default; // 0x000000018521EF60-0x000000018521F170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018521F620-0x000000018521F860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001852205D0-0x0000000185220A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185220160-0x00000001852203F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018521F170-0x000000018521F410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ShopMcoinProduct other) {} // 0x000000018521EAA0-0x000000018521ECD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018521E590-0x000000018521E720
}

