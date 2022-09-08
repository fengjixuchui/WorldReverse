/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class MethodOptions : MessageBase, IMessage<MethodOptions> // TypeDefIndex: 26383
{
	// Fields
	private static readonly MessageParser<MethodOptions> _parser; // 0x00
	internal CustomOptions CustomOptions; // 0x18
	public const int DeprecatedFieldNumber = 33; // Metadata: 0x00B0C0AD
	private bool deprecated_; // 0x20
	public const int IdempotencyLevelFieldNumber = 34; // Metadata: 0x00B0C0B1
	private Types.IdempotencyLevel idempotencyLevel_; // 0x24
	public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x00B0C0B5
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x08
	private readonly RepeatedMessageField<UninterpretedOption> uninterpretedOption_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MethodOptions> Parser { /* [XID] */ /* 0x0000000189B9EB20-0x0000000189B9EB40 */ get => default; } // 0x00000001842D2F60-0x00000001842D3030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189BA6410-0x0000000189BA6430 */ get => default; } // 0x00000001842D2920-0x00000001842D2A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189BAD720-0x0000000189BAD740 */ get => default; } // 0x00000001842D24C0-0x00000001842D2590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189BB4E70-0x0000000189BB4E90 */ get => default; } // 0x00000001842D1AE0-0x00000001842D1B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x0000000189BBC420-0x0000000189BBC440 */ get => default; } // 0x00000001842D3640-0x00000001842D3740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x0000000189BC4160-0x0000000189BC4180 */ get => default; } // 0x00000001842D3340-0x00000001842D33E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x0000000189BCBB30-0x0000000189BCBB50 */ get => default; } // 0x00000001842D2A90-0x00000001842D2B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x0000000189BD3060-0x0000000189BD3080 */ get => default; } // 0x00000001842D35A0-0x00000001842D3640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x0000000189BDA880-0x0000000189BDA8A0 */ get => default; } // 0x00000001842D2670-0x00000001842D2770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Deprecated { /* [XID] */ /* 0x00000001896260C0-0x00000001896260E0 */ get => default; /* [XID] */ /* 0x000000018962DA60-0x000000018962DA80 */ set {} } // 0x00000001842D2CC0-0x00000001842D2DA0 0x00000001842D3030-0x00000001842D3110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.IdempotencyLevel IdempotencyLevel { /* [XID] */ /* 0x0000000189635640-0x0000000189635660 */ get => default; /* [XID] */ /* 0x000000018963CCA0-0x000000018963CCC0 */ set {} } // 0x00000001842D2E80-0x00000001842D2F60 0x00000001842D2DA0-0x00000001842D2E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<UninterpretedOption> UninterpretedOption { /* [XID] */ /* 0x0000000189644300-0x0000000189644320 */ get => default; } // 0x00000001842D2280-0x00000001842D2320 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 26384
	{
		// Nested types
		internal enum IdempotencyLevel // TypeDefIndex: 26385
		{
			IdempotencyUnknown = 0,
			NoSideEffects = 1,
			Idempotent = 2
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MethodOptions() {} // 0x00000001842D3B00-0x00000001842D3BD0
	static MethodOptions() {} // 0x00000001842D39F0-0x00000001842D3B00

	// Methods
	[DebuggerNonUserCode] // 0x00000001895E72F0-0x00000001895E7330
	// [XID] // 0x00000001895E72F0-0x00000001895E7330
	public MethodOptions Clone() => default; // 0x00000001842D2B90-0x00000001842D2CC0
	[DebuggerNonUserCode] // 0x00000001895F1B70-0x00000001895F1BB0
	// [XID] // 0x00000001895F1B70-0x00000001895F1BB0
	public MethodOptions ShallowCopy() => default; // 0x00000001842D2590-0x00000001842D2670
	[DebuggerNonUserCode] // 0x00000001895FC3A0-0x00000001895FC3E0
	// [XID] // 0x00000001895FC3A0-0x00000001895FC3E0
	protected override void InternalSetInPool(bool value) {} // 0x00000001842D1DC0-0x00000001842D1E70
	[DebuggerNonUserCode] // 0x0000000189606B50-0x0000000189606B90
	// [XID] // 0x0000000189606B50-0x0000000189606B90
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001842D31A0-0x00000001842D3270
	[DebuggerNonUserCode] // 0x0000000189611540-0x0000000189611580
	// [XID] // 0x0000000189611540-0x0000000189611580
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001842D3270-0x00000001842D3340
	[DebuggerNonUserCode] // 0x000000018961BB00-0x000000018961BB40
	// [XID] // 0x000000018961BB00-0x000000018961BB40
	public override void Reset() {} // 0x00000001842D1E70-0x00000001842D1F70
	[DebuggerNonUserCode] // 0x000000018964BAE0-0x000000018964BB30
	// [IDTag] // 0x000000018964BAE0-0x000000018964BB30
	// [XID] // 0x000000018964BAE0-0x000000018964BB30
	public override bool Equals(object other) => default; // 0x00000001842D1FE0-0x00000001842D20F0
	[DebuggerNonUserCode] // 0x0000000189659110-0x0000000189659160
	// [IDTag] // 0x0000000189659110-0x0000000189659160
	// [XID] // 0x0000000189659110-0x0000000189659160
	public bool Equals(MethodOptions other) => default; // 0x00000001842D20F0-0x00000001842D2280
	[DebuggerNonUserCode] // 0x0000000189666740-0x0000000189666780
	// [XID] // 0x0000000189666740-0x0000000189666780
	public override int GetHashCode() => default; // 0x00000001842D2770-0x00000001842D2920
	[DebuggerNonUserCode] // 0x00000001896716E0-0x0000000189671720
	// [XID] // 0x00000001896716E0-0x0000000189671720
	public override string ToString() => default; // 0x00000001842D3740-0x00000001842D39F0
	[DebuggerNonUserCode] // 0x000000018967BD70-0x000000018967BDB0
	// [XID] // 0x000000018967BD70-0x000000018967BDB0
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001842D33E0-0x00000001842D35A0
	[DebuggerNonUserCode] // 0x0000000189686320-0x0000000189686360
	// [XID] // 0x0000000189686320-0x0000000189686360
	public override int CalculateSize() => default; // 0x00000001842D2320-0x00000001842D24C0
	[DebuggerNonUserCode] // 0x0000000189691450-0x0000000189691490
	// [XID] // 0x0000000189691450-0x0000000189691490
	public void CopyFrom(MethodOptions other) {} // 0x00000001842D1BF0-0x00000001842D1DC0
	[DebuggerNonUserCode] // 0x000000018969B850-0x000000018969B890
	// [XID] // 0x000000018969B850-0x000000018969B890
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001842D1910-0x00000001842D1AE0
}

