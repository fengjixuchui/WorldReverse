/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetMailItemRsp : MessageBase, IMessage<GetMailItemRsp> // TypeDefIndex: 23798
{
	// Fields
	private static readonly MessageParser<GetMailItemRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B04D8B
	private int retcode_; // 0x18
	public const int MailIdListFieldNumber = 2; // Metadata: 0x00B04D8F
	private static readonly FieldCodec<uint> _repeated_mailIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> mailIdList_; // 0x20
	public const int ItemListFieldNumber = 3; // Metadata: 0x00B04D93
	private static readonly FieldCodec<EquipParam> _repeated_itemList_codec; // 0x10
	private readonly RepeatedMessageField<EquipParam> itemList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetMailItemRsp> Parser { get => default; } // 0x0000000181D78590-0x0000000181D78620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181D782C0-0x0000000181D78350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181D77F90-0x0000000181D78010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181D77740-0x0000000181D777A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181D789F0-0x0000000181D78AE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181D787D0-0x0000000181D78830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181D783B0-0x0000000181D784A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181D789A0-0x0000000181D789F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181D780B0-0x0000000181D781A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181D77EF0-0x0000000181D77F90 0x0000000181D77AB0-0x0000000181D77B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> MailIdList { get => default; } // 0x0000000181D776E0-0x0000000181D77740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<EquipParam> ItemList { get => default; } // 0x0000000181D78350-0x0000000181D783B0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23799
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23800
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1405
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetMailItemRsp() {} // 0x0000000181D78E70-0x0000000181D78F20
	static GetMailItemRsp() {} // 0x0000000181D78D40-0x0000000181D78E70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetMailItemRsp Clone() => default; // 0x0000000181D784A0-0x0000000181D78590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetMailItemRsp ShallowCopy() => default; // 0x0000000181D78010-0x0000000181D780B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181D77920-0x0000000181D77970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D786B0-0x0000000181D78740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D78740-0x0000000181D787D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181D77970-0x0000000181D77AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181D77CA0-0x0000000181D77D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetMailItemRsp other) => default; // 0x0000000181D77B50-0x0000000181D77CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181D781A0-0x0000000181D782C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181D78AE0-0x0000000181D78D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181D78830-0x0000000181D789A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181D77D70-0x0000000181D77EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetMailItemRsp other) {} // 0x0000000181D777A0-0x0000000181D77920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181D77500-0x0000000181D776E0
}

