/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChannellerSlabBuffInfo : MessageBase, IMessage<ChannellerSlabBuffInfo> // TypeDefIndex: 22267
{
	// Fields
	private static readonly MessageParser<ChannellerSlabBuffInfo> _parser; // 0x00
	public const int BuffIdListFieldNumber = 1; // Metadata: 0x00B0130F
	private static readonly FieldCodec<uint> _repeated_buffIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> buffIdList_; // 0x18
	public const int SingleBuffSchemeInfoFieldNumber = 2; // Metadata: 0x00B01313
	private ChannellerSlabBuffSchemeInfo singleBuffSchemeInfo_; // 0x20
	public const int MpBuffSchemeInfoFieldNumber = 3; // Metadata: 0x00B01317
	private ChannellerSlabBuffSchemeInfo mpBuffSchemeInfo_; // 0x28
	public const int AssistInfoListFieldNumber = 4; // Metadata: 0x00B0131B
	private static readonly FieldCodec<ChannellerSlabAssistInfo> _repeated_assistInfoList_codec; // 0x10
	private readonly RepeatedMessageField<ChannellerSlabAssistInfo> assistInfoList_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChannellerSlabBuffInfo> Parser { get => default; } // 0x00000001841A6320-0x00000001841A63B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001841A6050-0x00000001841A60E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001841A5C10-0x00000001841A5C90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001841A4E90-0x00000001841A4EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001841A6880-0x00000001841A6970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001841A6600-0x00000001841A6660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001841A60E0-0x00000001841A61D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001841A6830-0x00000001841A6880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001841A5D30-0x00000001841A5E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> BuffIdList { get => default; } // 0x00000001841A65A0-0x00000001841A6600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabBuffSchemeInfo SingleBuffSchemeInfo { get => default; set {} } // 0x00000001841A4EF0-0x00000001841A4F90 0x00000001841A5B70-0x00000001841A5C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabBuffSchemeInfo MpBuffSchemeInfo { get => default; set {} } // 0x00000001841A5AD0-0x00000001841A5B70 0x00000001841A5A30-0x00000001841A5AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ChannellerSlabAssistInfo> AssistInfoList { get => default; } // 0x00000001841A62C0-0x00000001841A6320 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabBuffInfo() {} // 0x00000001841A6D40-0x00000001841A6DF0
	static ChannellerSlabBuffInfo() {} // 0x00000001841A6C10-0x00000001841A6D40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabBuffInfo Clone() => default; // 0x00000001841A61D0-0x00000001841A62C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabBuffInfo ShallowCopy() => default; // 0x00000001841A5C90-0x00000001841A5D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001841A51D0-0x00000001841A5260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001841A6440-0x00000001841A64F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001841A64F0-0x00000001841A65A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001841A5260-0x00000001841A5510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001841A56B0-0x00000001841A5780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChannellerSlabBuffInfo other) => default; // 0x00000001841A5510-0x00000001841A56B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001841A5E20-0x00000001841A6050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001841A6970-0x00000001841A6C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001841A6660-0x00000001841A6830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001841A5780-0x00000001841A5A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChannellerSlabBuffInfo other) {} // 0x00000001841A4F90-0x00000001841A51D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001841A4C30-0x00000001841A4E90
}

