/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class ServiceOptions : MessageBase, IMessage<ServiceOptions> // TypeDefIndex: 26382
{
	// Fields
	private static readonly MessageParser<ServiceOptions> _parser; // 0x00
	internal CustomOptions CustomOptions; // 0x18
	public const int DeprecatedFieldNumber = 33; // Metadata: 0x00B0C0A5
	private bool deprecated_; // 0x20
	public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x00B0C0A9
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x08
	private readonly RepeatedMessageField<UninterpretedOption> uninterpretedOption_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ServiceOptions> Parser { /* [XID] */ /* 0x0000000189A4B0B0-0x0000000189A4B0D0 */ get => default; } // 0x0000000184B06F20-0x0000000184B06FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189A52770-0x0000000189A52790 */ get => default; } // 0x0000000184B06AA0-0x0000000184B06B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189A5A0A0-0x0000000189A5A0C0 */ get => default; } // 0x0000000184B066B0-0x0000000184B06780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189A618D0-0x0000000189A618F0 */ get => default; } // 0x0000000184B05D70-0x0000000184B05E10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x0000000189A69850-0x0000000189A69870 */ get => default; } // 0x0000000184B075C0-0x0000000184B076C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x0000000189A70B50-0x0000000189A70B70 */ get => default; } // 0x0000000184B07300-0x0000000184B073A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x0000000189A78470-0x0000000189A78490 */ get => default; } // 0x0000000184B06C10-0x0000000184B06D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x0000000189A7FA40-0x0000000189A7FA60 */ get => default; } // 0x0000000184B07520-0x0000000184B075C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x0000000189A876E0-0x0000000189A87700 */ get => default; } // 0x0000000184B06860-0x0000000184B06960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Deprecated { /* [XID] */ /* 0x0000000189ACE000-0x0000000189ACE020 */ get => default; /* [XID] */ /* 0x0000000189AD5CA0-0x0000000189AD5CC0 */ set {} } // 0x0000000184B06E40-0x0000000184B06F20 0x0000000184B06FF0-0x0000000184B070D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<UninterpretedOption> UninterpretedOption { /* [XID] */ /* 0x0000000189ADD700-0x0000000189ADD720 */ get => default; } // 0x0000000184B064C0-0x0000000184B06560 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ServiceOptions() {} // 0x0000000184B07A00-0x0000000184B07AD0
	static ServiceOptions() {} // 0x0000000184B078F0-0x0000000184B07A00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189A8EE60-0x0000000189A8EEA0
	// [XID] // 0x0000000189A8EE60-0x0000000189A8EEA0
	public ServiceOptions Clone() => default; // 0x0000000184B06D10-0x0000000184B06E40
	[DebuggerNonUserCode] // 0x0000000189A998C0-0x0000000189A99900
	// [XID] // 0x0000000189A998C0-0x0000000189A99900
	public ServiceOptions ShallowCopy() => default; // 0x0000000184B06780-0x0000000184B06860
	[DebuggerNonUserCode] // 0x0000000189AA3B50-0x0000000189AA3B90
	// [XID] // 0x0000000189AA3B50-0x0000000189AA3B90
	protected override void InternalSetInPool(bool value) {} // 0x0000000184B06030-0x0000000184B060E0
	[DebuggerNonUserCode] // 0x0000000189AAE280-0x0000000189AAE2C0
	// [XID] // 0x0000000189AAE280-0x0000000189AAE2C0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B07160-0x0000000184B07230
	[DebuggerNonUserCode] // 0x0000000189AB88C0-0x0000000189AB8900
	// [XID] // 0x0000000189AB88C0-0x0000000189AB8900
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B07230-0x0000000184B07300
	[DebuggerNonUserCode] // 0x0000000189AC39A0-0x0000000189AC39E0
	// [XID] // 0x0000000189AC39A0-0x0000000189AC39E0
	public override void Reset() {} // 0x0000000184B060E0-0x0000000184B061D0
	[DebuggerNonUserCode] // 0x0000000189AE4E30-0x0000000189AE4E80
	// [IDTag] // 0x0000000189AE4E30-0x0000000189AE4E80
	// [XID] // 0x0000000189AE4E30-0x0000000189AE4E80
	public override bool Equals(object other) => default; // 0x0000000184B063B0-0x0000000184B064C0
	[DebuggerNonUserCode] // 0x0000000189AF2760-0x0000000189AF27B0
	// [IDTag] // 0x0000000189AF2760-0x0000000189AF27B0
	// [XID] // 0x0000000189AF2760-0x0000000189AF27B0
	public bool Equals(ServiceOptions other) => default; // 0x0000000184B06240-0x0000000184B063B0
	[DebuggerNonUserCode] // 0x0000000189AFFDA0-0x0000000189AFFDE0
	// [XID] // 0x0000000189AFFDA0-0x0000000189AFFDE0
	public override int GetHashCode() => default; // 0x0000000184B06960-0x0000000184B06AA0
	[DebuggerNonUserCode] // 0x0000000189B0A4E0-0x0000000189B0A520
	// [XID] // 0x0000000189B0A4E0-0x0000000189B0A520
	public override string ToString() => default; // 0x0000000184B076C0-0x0000000184B078F0
	[DebuggerNonUserCode] // 0x0000000189B14900-0x0000000189B14940
	// [XID] // 0x0000000189B14900-0x0000000189B14940
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184B073A0-0x0000000184B07520
	[DebuggerNonUserCode] // 0x0000000189B1EF90-0x0000000189B1EFD0
	// [XID] // 0x0000000189B1EF90-0x0000000189B1EFD0
	public override int CalculateSize() => default; // 0x0000000184B06560-0x0000000184B066B0
	[DebuggerNonUserCode] // 0x0000000189B29480-0x0000000189B294C0
	// [XID] // 0x0000000189B29480-0x0000000189B294C0
	public void CopyFrom(ServiceOptions other) {} // 0x0000000184B05E80-0x0000000184B06030
	[DebuggerNonUserCode] // 0x0000000189B33950-0x0000000189B33990
	// [XID] // 0x0000000189B33950-0x0000000189B33990
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184B05BB0-0x0000000184B05D70
}

