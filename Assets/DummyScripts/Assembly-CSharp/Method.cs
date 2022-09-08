/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Method : MessageBase, IMessage<Method> // TypeDefIndex: 26437
{
	// Fields
	private static readonly MessageParser<Method> _parser; // 0x00
	public const int NameFieldNumber = 1; // Metadata: 0x00B0C198
	private string name_; // 0x18
	public const int RequestTypeUrlFieldNumber = 2; // Metadata: 0x00B0C19C
	private string requestTypeUrl_; // 0x20
	public const int RequestStreamingFieldNumber = 3; // Metadata: 0x00B0C1A0
	private bool requestStreaming_; // 0x28
	public const int ResponseTypeUrlFieldNumber = 4; // Metadata: 0x00B0C1A4
	private string responseTypeUrl_; // 0x30
	public const int ResponseStreamingFieldNumber = 5; // Metadata: 0x00B0C1A8
	private bool responseStreaming_; // 0x38
	public const int OptionsFieldNumber = 6; // Metadata: 0x00B0C1AC
	private static readonly FieldCodec<Option> _repeated_options_codec; // 0x08
	private readonly RepeatedMessageField<Option> options_; // 0x40
	public const int SyntaxFieldNumber = 7; // Metadata: 0x00B0C1B0
	private Syntax syntax_; // 0x48

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Method> Parser { /* [XID] */ /* 0x0000000189B92FA0-0x0000000189B92FC0 */ get => default; } // 0x00000001843FB530-0x00000001843FB600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189B9A5A0-0x0000000189B9A5C0 */ get => default; } // 0x00000001843FAEF0-0x00000001843FAFE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189BA1D10-0x0000000189BA1D30 */ get => default; } // 0x00000001843FA880-0x00000001843FA950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189BA90D0-0x0000000189BA90F0 */ get => default; } // 0x00000001843F9750-0x00000001843F97F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x0000000189BB0840-0x0000000189BB0860 */ get => default; } // 0x00000001843FBFE0-0x00000001843FC0E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x0000000189BB7BC0-0x0000000189BB7BE0 */ get => default; } // 0x00000001843FB910-0x00000001843FB9B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x0000000189BBF1E0-0x0000000189BBF200 */ get => default; } // 0x00000001843FB220-0x00000001843FB320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x0000000189BC6EB0-0x0000000189BC6ED0 */ get => default; } // 0x00000001843FBF40-0x00000001843FBFE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x0000000189BCEB20-0x0000000189BCEB40 */ get => default; } // 0x00000001843FAA30-0x00000001843FAB30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Name { /* [XID] */ /* 0x000000018961A380-0x000000018961A3A0 */ get => default; /* [XID] */ /* 0x0000000189621950-0x0000000189621970 */ set {} } // 0x00000001843FA7A0-0x00000001843FA880 0x00000001843F9F40-0x00000001843FA030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string RequestTypeUrl { /* [XID] */ /* 0x0000000189629220-0x0000000189629240 */ get => default; /* [XID] */ /* 0x0000000189630B80-0x0000000189630BA0 */ set {} } // 0x00000001843FB450-0x00000001843FB530 0x00000001843FBD60-0x00000001843FBE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool RequestStreaming { /* [XID] */ /* 0x0000000189638660-0x0000000189638680 */ get => default; /* [XID] */ /* 0x000000018963FA20-0x000000018963FA40 */ set {} } // 0x00000001843FA6C0-0x00000001843FA7A0 0x00000001843FB140-0x00000001843FB220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ResponseTypeUrl { /* [XID] */ /* 0x0000000189647240-0x0000000189647260 */ get => default; /* [XID] */ /* 0x000000018964E910-0x000000018964E930 */ set {} } // 0x00000001843F9E60-0x00000001843F9F40 0x00000001843FBE50-0x00000001843FBF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool ResponseStreaming { /* [XID] */ /* 0x0000000189656180-0x00000001896561A0 */ get => default; /* [XID] */ /* 0x000000018965D8C0-0x000000018965D8E0 */ set {} } // 0x00000001843FB830-0x00000001843FB910 0x00000001843F9860-0x00000001843F9940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Option> Options { /* [XID] */ /* 0x0000000189664FE0-0x0000000189665000 */ get => default; } // 0x00000001843FB9B0-0x00000001843FBA50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Syntax Syntax { /* [XID] */ /* 0x000000018966C5E0-0x000000018966C600 */ get => default; /* [XID] */ /* 0x00000001896744E0-0x0000000189674500 */ set {} } // 0x00000001843FAE10-0x00000001843FAEF0 0x00000001843FAFE0-0x00000001843FB0C0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Method() {} // 0x00000001843FC680-0x00000001843FC740
	static Method() {} // 0x00000001843FC570-0x00000001843FC680

	// Methods
	[DebuggerNonUserCode] // 0x0000000189BD5E40-0x0000000189BD5E80
	// [XID] // 0x0000000189BD5E40-0x0000000189BD5E80
	public Method Clone() => default; // 0x00000001843FB320-0x00000001843FB450
	[DebuggerNonUserCode] // 0x00000001895E5C30-0x00000001895E5C70
	// [XID] // 0x00000001895E5C30-0x00000001895E5C70
	public Method ShallowCopy() => default; // 0x00000001843FA950-0x00000001843FAA30
	[DebuggerNonUserCode] // 0x00000001895F04C0-0x00000001895F0500
	// [XID] // 0x00000001895F04C0-0x00000001895F0500
	protected override void InternalSetInPool(bool value) {} // 0x00000001843F9C00-0x00000001843F9CB0
	[DebuggerNonUserCode] // 0x00000001895FAB10-0x00000001895FAB50
	// [XID] // 0x00000001895FAB10-0x00000001895FAB50
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843FB690-0x00000001843FB760
	[DebuggerNonUserCode] // 0x0000000189605180-0x00000001896051C0
	// [XID] // 0x0000000189605180-0x00000001896051C0
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843FB760-0x00000001843FB830
	[DebuggerNonUserCode] // 0x000000018960FDA0-0x000000018960FDE0
	// [XID] // 0x000000018960FDA0-0x000000018960FDE0
	public override void Reset() {} // 0x00000001843F9CB0-0x00000001843F9DF0
	[DebuggerNonUserCode] // 0x000000018967BCE0-0x000000018967BD30
	// [IDTag] // 0x000000018967BCE0-0x000000018967BD30
	// [XID] // 0x000000018967BCE0-0x000000018967BD30
	public override bool Equals(object other) => default; // 0x00000001843FA030-0x00000001843FA140
	[DebuggerNonUserCode] // 0x0000000189689730-0x0000000189689780
	// [IDTag] // 0x0000000189689730-0x0000000189689780
	// [XID] // 0x0000000189689730-0x0000000189689780
	public bool Equals(Method other) => default; // 0x00000001843FA140-0x00000001843FA3F0
	[DebuggerNonUserCode] // 0x0000000189697490-0x00000001896974D0
	// [XID] // 0x0000000189697490-0x00000001896974D0
	public override int GetHashCode() => default; // 0x00000001843FAB30-0x00000001843FAE10
	[DebuggerNonUserCode] // 0x00000001896A1690-0x00000001896A16D0
	// [XID] // 0x00000001896A1690-0x00000001896A16D0
	public override string ToString() => default; // 0x00000001843FC0E0-0x00000001843FC570
	[DebuggerNonUserCode] // 0x00000001896AB9B0-0x00000001896AB9F0
	// [XID] // 0x00000001896AB9B0-0x00000001896AB9F0
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001843FBA50-0x00000001843FBD60
	[DebuggerNonUserCode] // 0x00000001896B6080-0x00000001896B60C0
	// [XID] // 0x00000001896B6080-0x00000001896B60C0
	public override int CalculateSize() => default; // 0x00000001843FA3F0-0x00000001843FA6C0
	[DebuggerNonUserCode] // 0x00000001896BFF90-0x00000001896BFFD0
	// [XID] // 0x00000001896BFF90-0x00000001896BFFD0
	public void CopyFrom(Method other) {} // 0x00000001843F9940-0x00000001843F9C00
	[DebuggerNonUserCode] // 0x00000001896CA4E0-0x00000001896CA520
	// [XID] // 0x00000001896CA4E0-0x00000001896CA520
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001843F9520-0x00000001843F9750
}

