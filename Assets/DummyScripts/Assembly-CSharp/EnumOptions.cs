/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class EnumOptions : MessageBase, IMessage<EnumOptions> // TypeDefIndex: 26380
{
	// Fields
	private static readonly MessageParser<EnumOptions> _parser; // 0x00
	internal CustomOptions CustomOptions; // 0x18
	public const int AllowAliasFieldNumber = 2; // Metadata: 0x00B0C091
	private bool allowAlias_; // 0x20
	public const int DeprecatedFieldNumber = 3; // Metadata: 0x00B0C095
	private bool deprecated_; // 0x21
	public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x00B0C099
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x08
	private readonly RepeatedMessageField<UninterpretedOption> uninterpretedOption_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EnumOptions> Parser { /* [XID] */ /* 0x000000018978D650-0x000000018978D670 */ get => default; } // 0x0000000181F339F0-0x0000000181F33AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189794A70-0x0000000189794A90 */ get => default; } // 0x0000000181F33570-0x0000000181F33660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x000000018979CF60-0x000000018979CF80 */ get => default; } // 0x0000000181F33150-0x0000000181F33220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x00000001897A4320-0x00000001897A4340 */ get => default; } // 0x0000000181F325F0-0x0000000181F32690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x00000001897AB860-0x00000001897AB880 */ get => default; } // 0x0000000181F340D0-0x0000000181F341D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x00000001897B37B0-0x00000001897B37D0 */ get => default; } // 0x0000000181F33DD0-0x0000000181F33E70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x00000001897BB5F0-0x00000001897BB610 */ get => default; } // 0x0000000181F336E0-0x0000000181F337E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x00000001897C2E00-0x00000001897C2E20 */ get => default; } // 0x0000000181F34030-0x0000000181F340D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x00000001897CA680-0x00000001897CA6A0 */ get => default; } // 0x0000000181F33300-0x0000000181F33400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool AllowAlias { /* [XID] */ /* 0x0000000189810EA0-0x0000000189810EC0 */ get => default; /* [XID] */ /* 0x00000001898189B0-0x00000001898189D0 */ set {} } // 0x0000000181F328D0-0x0000000181F329B0 0x0000000181F32B60-0x0000000181F32C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Deprecated { /* [XID] */ /* 0x0000000189820220-0x0000000189820240 */ get => default; /* [XID] */ /* 0x0000000189827810-0x0000000189827830 */ set {} } // 0x0000000181F33910-0x0000000181F339F0 0x0000000181F33AC0-0x0000000181F33BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<UninterpretedOption> UninterpretedOption { /* [XID] */ /* 0x000000018982EA40-0x000000018982EA60 */ get => default; } // 0x0000000181F32F50-0x0000000181F32FF0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnumOptions() {} // 0x0000000181F34590-0x0000000181F34660
	static EnumOptions() {} // 0x0000000181F34480-0x0000000181F34590

	// Methods
	[DebuggerNonUserCode] // 0x00000001897D1C30-0x00000001897D1C70
	// [XID] // 0x00000001897D1C30-0x00000001897D1C70
	public EnumOptions Clone() => default; // 0x0000000181F337E0-0x0000000181F33910
	[DebuggerNonUserCode] // 0x00000001897DC500-0x00000001897DC540
	// [XID] // 0x00000001897DC500-0x00000001897DC540
	public EnumOptions ShallowCopy() => default; // 0x0000000181F33220-0x0000000181F33300
	[DebuggerNonUserCode] // 0x00000001897E6D00-0x00000001897E6D40
	// [XID] // 0x00000001897E6D00-0x00000001897E6D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181F329B0-0x0000000181F32A60
	[DebuggerNonUserCode] // 0x00000001897F1B50-0x00000001897F1B90
	// [XID] // 0x00000001897F1B50-0x00000001897F1B90
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181F33C30-0x0000000181F33D00
	[DebuggerNonUserCode] // 0x00000001897FC4A0-0x00000001897FC4E0
	// [XID] // 0x00000001897FC4A0-0x00000001897FC4E0
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181F33D00-0x0000000181F33DD0
	[DebuggerNonUserCode] // 0x0000000189806750-0x0000000189806790
	// [XID] // 0x0000000189806750-0x0000000189806790
	public override void Reset() {} // 0x0000000181F32A60-0x0000000181F32B60
	[DebuggerNonUserCode] // 0x00000001898363C0-0x0000000189836410
	// [IDTag] // 0x00000001898363C0-0x0000000189836410
	// [XID] // 0x00000001898363C0-0x0000000189836410
	public override bool Equals(object other) => default; // 0x0000000181F32E40-0x0000000181F32F50
	[DebuggerNonUserCode] // 0x00000001898437C0-0x0000000189843810
	// [IDTag] // 0x00000001898437C0-0x0000000189843810
	// [XID] // 0x00000001898437C0-0x0000000189843810
	public bool Equals(EnumOptions other) => default; // 0x0000000181F32CB0-0x0000000181F32E40
	[DebuggerNonUserCode] // 0x0000000189850B30-0x0000000189850B70
	// [XID] // 0x0000000189850B30-0x0000000189850B70
	public override int GetHashCode() => default; // 0x0000000181F33400-0x0000000181F33570
	[DebuggerNonUserCode] // 0x000000018985B0A0-0x000000018985B0E0
	// [XID] // 0x000000018985B0A0-0x000000018985B0E0
	public override string ToString() => default; // 0x0000000181F341D0-0x0000000181F34480
	[DebuggerNonUserCode] // 0x00000001898652B0-0x00000001898652F0
	// [XID] // 0x00000001898652B0-0x00000001898652F0
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181F33E70-0x0000000181F34030
	[DebuggerNonUserCode] // 0x000000018986F750-0x000000018986F790
	// [XID] // 0x000000018986F750-0x000000018986F790
	public override int CalculateSize() => default; // 0x0000000181F32FF0-0x0000000181F33150
	[DebuggerNonUserCode] // 0x000000018987A250-0x000000018987A290
	// [XID] // 0x000000018987A250-0x000000018987A290
	public void CopyFrom(EnumOptions other) {} // 0x0000000181F32700-0x0000000181F328D0
	[DebuggerNonUserCode] // 0x00000001898840C0-0x0000000189884100
	// [XID] // 0x00000001898840C0-0x0000000189884100
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181F32420-0x0000000181F325F0
}

