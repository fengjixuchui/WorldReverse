/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class MethodDescriptorProto : MessageBase, IMessage<MethodDescriptorProto> // TypeDefIndex: 26370
{
	// Fields
	private static readonly MessageParser<MethodDescriptorProto> _parser; // 0x00
	public const int NameFieldNumber = 1; // Metadata: 0x00B0BFD5
	private string name_; // 0x18
	public const int InputTypeFieldNumber = 2; // Metadata: 0x00B0BFD9
	private string inputType_; // 0x20
	public const int OutputTypeFieldNumber = 3; // Metadata: 0x00B0BFDD
	private string outputType_; // 0x28
	public const int OptionsFieldNumber = 4; // Metadata: 0x00B0BFE1
	private MethodOptions options_; // 0x30
	public const int ClientStreamingFieldNumber = 5; // Metadata: 0x00B0BFE5
	private bool clientStreaming_; // 0x38
	public const int ServerStreamingFieldNumber = 6; // Metadata: 0x00B0BFE9
	private bool serverStreaming_; // 0x39

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MethodDescriptorProto> Parser { /* [XID] */ /* 0x0000000189A0B350-0x0000000189A0B370 */ get => default; } // 0x000000018193FAA0-0x000000018193FB70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189A12C20-0x0000000189A12C40 */ get => default; } // 0x000000018193F370-0x000000018193F460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189A19F80-0x0000000189A19FA0 */ get => default; } // 0x000000018193EE40-0x000000018193EF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189A21500-0x0000000189A21520 */ get => default; } // 0x000000018193DC80-0x000000018193DD20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x0000000189A28A80-0x0000000189A28AA0 */ get => default; } // 0x0000000181940250-0x0000000181940350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x0000000189A301C0-0x0000000189A301E0 */ get => default; } // 0x000000018193FD80-0x000000018193FE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x0000000189A37BA0-0x0000000189A37BC0 */ get => default; } // 0x000000018193F780-0x000000018193F880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x0000000189A3F350-0x0000000189A3F370 */ get => default; } // 0x00000001819401B0-0x0000000181940250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x0000000189A468D0-0x0000000189A468F0 */ get => default; } // 0x000000018193EFF0-0x000000018193F0F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Name { /* [XID] */ /* 0x0000000189A8D5E0-0x0000000189A8D600 */ get => default; /* [XID] */ /* 0x0000000189A94B80-0x0000000189A94BA0 */ set {} } // 0x000000018193ED60-0x000000018193EE40 0x000000018193E570-0x000000018193E660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string InputType { /* [XID] */ /* 0x0000000189A9C3C0-0x0000000189A9C3E0 */ get => default; /* [XID] */ /* 0x0000000189AA3B90-0x0000000189AA3BB0 */ set {} } // 0x000000018193E130-0x000000018193E210 0x000000018193F9B0-0x000000018193FAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string OutputType { /* [XID] */ /* 0x0000000189AAB130-0x0000000189AAB150 */ get => default; /* [XID] */ /* 0x0000000189AB2AB0-0x0000000189AB2AD0 */ set {} } // 0x000000018193E050-0x000000018193E130 0x000000018193E210-0x000000018193E300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MethodOptions Options { /* [XID] */ /* 0x0000000189ABA690-0x0000000189ABA6B0 */ get => default; /* [XID] */ /* 0x0000000189AC1FA0-0x0000000189AC1FC0 */ set {} } // 0x000000018193FE20-0x000000018193FF00 0x0000000181940350-0x0000000181940430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool ClientStreaming { /* [XID] */ /* 0x0000000189AC9570-0x0000000189AC9590 */ get => default; /* [XID] */ /* 0x0000000189AD0F40-0x0000000189AD0F60 */ set {} } // 0x000000018193EC80-0x000000018193ED60 0x000000018193F5C0-0x000000018193F6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool ServerStreaming { /* [XID] */ /* 0x0000000189AD8D30-0x0000000189AD8D50 */ get => default; /* [XID] */ /* 0x0000000189AE0790-0x0000000189AE07B0 */ set {} } // 0x000000018193F6A0-0x000000018193F780 0x000000018193F4E0-0x000000018193F5C0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MethodDescriptorProto() {} // 0x0000000181940900-0x0000000181940990
	static MethodDescriptorProto() {} // 0x0000000181940840-0x0000000181940900

	// Methods
	[DebuggerNonUserCode] // 0x0000000189A4E0E0-0x0000000189A4E120
	// [XID] // 0x0000000189A4E0E0-0x0000000189A4E120
	public MethodDescriptorProto Clone() => default; // 0x000000018193F880-0x000000018193F9B0
	[DebuggerNonUserCode] // 0x0000000189A58700-0x0000000189A58740
	// [XID] // 0x0000000189A58700-0x0000000189A58740
	public MethodDescriptorProto ShallowCopy() => default; // 0x000000018193EF10-0x000000018193EFF0
	[DebuggerNonUserCode] // 0x0000000189A63180-0x0000000189A631C0
	// [XID] // 0x0000000189A63180-0x0000000189A631C0
	protected override void InternalSetInPool(bool value) {} // 0x000000018193E300-0x000000018193E3C0
	[DebuggerNonUserCode] // 0x0000000189A6D8F0-0x0000000189A6D930
	// [XID] // 0x0000000189A6D8F0-0x0000000189A6D930
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018193FC00-0x000000018193FCC0
	[DebuggerNonUserCode] // 0x0000000189A78490-0x0000000189A784D0
	// [XID] // 0x0000000189A78490-0x0000000189A784D0
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018193FCC0-0x000000018193FD80
	[DebuggerNonUserCode] // 0x0000000189A82C90-0x0000000189A82CD0
	// [XID] // 0x0000000189A82C90-0x0000000189A82CD0
	public override void Reset() {} // 0x000000018193E3C0-0x000000018193E500
	[DebuggerNonUserCode] // 0x0000000189AE7CF0-0x0000000189AE7D40
	// [IDTag] // 0x0000000189AE7CF0-0x0000000189AE7D40
	// [XID] // 0x0000000189AE7CF0-0x0000000189AE7D40
	public override bool Equals(object other) => default; // 0x000000018193E8F0-0x000000018193EA00
	[DebuggerNonUserCode] // 0x0000000189AF56F0-0x0000000189AF5740
	// [IDTag] // 0x0000000189AF56F0-0x0000000189AF5740
	// [XID] // 0x0000000189AF56F0-0x0000000189AF5740
	public bool Equals(MethodDescriptorProto other) => default; // 0x000000018193E660-0x000000018193E8F0
	[DebuggerNonUserCode] // 0x0000000189B02DF0-0x0000000189B02E30
	// [XID] // 0x0000000189B02DF0-0x0000000189B02E30
	public override int GetHashCode() => default; // 0x000000018193F0F0-0x000000018193F370
	[DebuggerNonUserCode] // 0x0000000189B0D4A0-0x0000000189B0D4E0
	// [XID] // 0x0000000189B0D4A0-0x0000000189B0D4E0
	public override string ToString() => default; // 0x0000000181940430-0x0000000181940840
	[DebuggerNonUserCode] // 0x0000000189B17720-0x0000000189B17760
	// [XID] // 0x0000000189B17720-0x0000000189B17760
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018193FF00-0x00000001819401B0
	[DebuggerNonUserCode] // 0x0000000189B21EC0-0x0000000189B21F00
	// [XID] // 0x0000000189B21EC0-0x0000000189B21F00
	public override int CalculateSize() => default; // 0x000000018193EA00-0x000000018193EC80
	[DebuggerNonUserCode] // 0x0000000189B2C3E0-0x0000000189B2C420
	// [XID] // 0x0000000189B2C3E0-0x0000000189B2C420
	public void CopyFrom(MethodDescriptorProto other) {} // 0x000000018193DD90-0x000000018193E050
	[DebuggerNonUserCode] // 0x0000000189B368B0-0x0000000189B368F0
	// [XID] // 0x0000000189B368B0-0x0000000189B368F0
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018193DA80-0x000000018193DC80
}

