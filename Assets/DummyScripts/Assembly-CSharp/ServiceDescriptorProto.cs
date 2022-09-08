/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class ServiceDescriptorProto : MessageBase, IMessage<ServiceDescriptorProto> // TypeDefIndex: 26369
{
	// Fields
	private static readonly MessageParser<ServiceDescriptorProto> _parser; // 0x00
	public const int NameFieldNumber = 1; // Metadata: 0x00B0BFC9
	private string name_; // 0x18
	public const int MethodFieldNumber = 2; // Metadata: 0x00B0BFCD
	private static readonly FieldCodec<MethodDescriptorProto> _repeated_method_codec; // 0x08
	private readonly RepeatedMessageField<MethodDescriptorProto> method_; // 0x20
	public const int OptionsFieldNumber = 3; // Metadata: 0x00B0BFD1
	private ServiceOptions options_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ServiceDescriptorProto> Parser { /* [XID] */ /* 0x000000018989FDB0-0x000000018989FDD0 */ get => default; } // 0x0000000184C2BD30-0x0000000184C2BE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x00000001898A7760-0x00000001898A7780 */ get => default; } // 0x0000000184C2B990-0x0000000184C2BA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x00000001898AF160-0x00000001898AF180 */ get => default; } // 0x0000000184C2B550-0x0000000184C2B620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x00000001898B65E0-0x00000001898B6600 */ get => default; } // 0x0000000184C2A830-0x0000000184C2A8D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x00000001898BDE00-0x00000001898BDE20 */ get => default; } // 0x0000000184C2C440-0x0000000184C2C540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x00000001898C56C0-0x00000001898C56E0 */ get => default; } // 0x0000000184C2C050-0x0000000184C2C0F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x00000001898CCD40-0x00000001898CCD60 */ get => default; } // 0x0000000184C2BB00-0x0000000184C2BC00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x00000001898D46D0-0x00000001898D46F0 */ get => default; } // 0x0000000184C2C3A0-0x0000000184C2C440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x00000001898DBFF0-0x00000001898DC010 */ get => default; } // 0x0000000184C2B700-0x0000000184C2B800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Name { /* [XID] */ /* 0x0000000189923180-0x00000001899231A0 */ get => default; /* [XID] */ /* 0x000000018992A950-0x000000018992A970 */ set {} } // 0x0000000184C2B470-0x0000000184C2B550 0x0000000184C2AE90-0x0000000184C2AF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<MethodDescriptorProto> Method { /* [XID] */ /* 0x0000000189931FD0-0x0000000189931FF0 */ get => default; } // 0x0000000184C2A940-0x0000000184C2A9E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServiceOptions Options { /* [XID] */ /* 0x00000001899398E0-0x0000000189939900 */ get => default; /* [XID] */ /* 0x0000000189940B90-0x0000000189940BB0 */ set {} } // 0x0000000184C2C0F0-0x0000000184C2C1D0 0x0000000184C2C540-0x0000000184C2C620

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServiceDescriptorProto() {} // 0x0000000184C2C9A0-0x0000000184C2CA60
	static ServiceDescriptorProto() {} // 0x0000000184C2C890-0x0000000184C2C9A0

	// Methods
	[DebuggerNonUserCode] // 0x00000001898E3A40-0x00000001898E3A80
	// [XID] // 0x00000001898E3A40-0x00000001898E3A80
	public ServiceDescriptorProto Clone() => default; // 0x0000000184C2BC00-0x0000000184C2BD30
	[DebuggerNonUserCode] // 0x00000001898EE7B0-0x00000001898EE7F0
	// [XID] // 0x00000001898EE7B0-0x00000001898EE7F0
	public ServiceDescriptorProto ShallowCopy() => default; // 0x0000000184C2B620-0x0000000184C2B700
	[DebuggerNonUserCode] // 0x00000001898F9020-0x00000001898F9060
	// [XID] // 0x00000001898F9020-0x00000001898F9060
	protected override void InternalSetInPool(bool value) {} // 0x0000000184C2AC20-0x0000000184C2ACE0
	[DebuggerNonUserCode] // 0x0000000189903920-0x0000000189903960
	// [XID] // 0x0000000189903920-0x0000000189903960
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184C2BE90-0x0000000184C2BF70
	[DebuggerNonUserCode] // 0x000000018990E0C0-0x000000018990E100
	// [XID] // 0x000000018990E0C0-0x000000018990E100
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184C2BF70-0x0000000184C2C050
	[DebuggerNonUserCode] // 0x00000001899188A0-0x00000001899188E0
	// [XID] // 0x00000001899188A0-0x00000001899188E0
	public override void Reset() {} // 0x0000000184C2ACE0-0x0000000184C2AE20
	[DebuggerNonUserCode] // 0x00000001899484D0-0x0000000189948520
	// [IDTag] // 0x00000001899484D0-0x0000000189948520
	// [XID] // 0x00000001899484D0-0x0000000189948520
	public override bool Equals(object other) => default; // 0x0000000184C2B170-0x0000000184C2B280
	[DebuggerNonUserCode] // 0x0000000189955B60-0x0000000189955BB0
	// [IDTag] // 0x0000000189955B60-0x0000000189955BB0
	// [XID] // 0x0000000189955B60-0x0000000189955BB0
	public bool Equals(ServiceDescriptorProto other) => default; // 0x0000000184C2AF80-0x0000000184C2B170
	[DebuggerNonUserCode] // 0x0000000189963600-0x0000000189963640
	// [XID] // 0x0000000189963600-0x0000000189963640
	public override int GetHashCode() => default; // 0x0000000184C2B800-0x0000000184C2B990
	[DebuggerNonUserCode] // 0x000000018996D8C0-0x000000018996D900
	// [XID] // 0x000000018996D8C0-0x000000018996D900
	public override string ToString() => default; // 0x0000000184C2C620-0x0000000184C2C890
	[DebuggerNonUserCode] // 0x0000000189978920-0x0000000189978960
	// [XID] // 0x0000000189978920-0x0000000189978960
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184C2C1D0-0x0000000184C2C3A0
	[DebuggerNonUserCode] // 0x0000000189982F00-0x0000000189982F40
	// [XID] // 0x0000000189982F00-0x0000000189982F40
	public override int CalculateSize() => default; // 0x0000000184C2B280-0x0000000184C2B470
	[DebuggerNonUserCode] // 0x000000018998D6D0-0x000000018998D710
	// [XID] // 0x000000018998D6D0-0x000000018998D710
	public void CopyFrom(ServiceDescriptorProto other) {} // 0x0000000184C2A9E0-0x0000000184C2AC20
	[DebuggerNonUserCode] // 0x0000000189998210-0x0000000189998250
	// [XID] // 0x0000000189998210-0x0000000189998250
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184C2A640-0x0000000184C2A830
}

