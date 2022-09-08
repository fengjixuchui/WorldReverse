/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetShopRsp : MessageBase, IMessage<GetShopRsp> // TypeDefIndex: 25422
{
	// Fields
	private static readonly MessageParser<GetShopRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B08B9F
	private int retcode_; // 0x18
	public const int ShopFieldNumber = 2; // Metadata: 0x00B08BA3
	private Shop shop_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetShopRsp> Parser { get => default; } // 0x0000000182773000-0x0000000182773090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182772C50-0x0000000182772CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001827728C0-0x0000000182772940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182772050-0x00000001827720B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001827733F0-0x00000001827734E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182773220-0x0000000182773280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182772D80-0x0000000182772E70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001827733A0-0x00000001827733F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001827729E0-0x0000000182772AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182772820-0x00000001827728C0 0x00000001827723E0-0x0000000182772480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Shop Shop { get => default; set {} } // 0x0000000182772F60-0x0000000182773000 0x0000000182772CE0-0x0000000182772D80

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25423
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25424
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 702
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetShopRsp() {} // 0x0000000182773780-0x00000001827737E0
	static GetShopRsp() {} // 0x00000001827736C0-0x0000000182773780

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetShopRsp Clone() => default; // 0x0000000182772E70-0x0000000182772F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetShopRsp ShallowCopy() => default; // 0x0000000182772940-0x00000001827729E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182772230-0x00000001827722B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182773120-0x00000001827731A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001827731A0-0x0000000182773220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001827722B0-0x00000001827723E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182772480-0x0000000182772550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetShopRsp other) => default; // 0x0000000182772550-0x0000000182772680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182772AD0-0x0000000182772C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001827734E0-0x00000001827736C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182773280-0x00000001827733A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182772680-0x0000000182772820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetShopRsp other) {} // 0x00000001827720B0-0x0000000182772230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182771F10-0x0000000182772050
}

