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

internal sealed class FieldOptions : MessageBase, IMessage<FieldOptions> // TypeDefIndex: 26375
{
	// Fields
	private static readonly MessageParser<FieldOptions> _parser; // 0x00
	internal CustomOptions CustomOptions; // 0x18
	public const int CtypeFieldNumber = 1; // Metadata: 0x00B0C059
	private Types.CType ctype_; // 0x20
	public const int PackedFieldNumber = 2; // Metadata: 0x00B0C05D
	private bool packed_; // 0x24
	public const int JstypeFieldNumber = 6; // Metadata: 0x00B0C061
	private Types.JSType jstype_; // 0x28
	public const int LazyFieldNumber = 5; // Metadata: 0x00B0C065
	private bool lazy_; // 0x2C
	public const int DeprecatedFieldNumber = 3; // Metadata: 0x00B0C069
	private bool deprecated_; // 0x2D
	public const int WeakFieldNumber = 10; // Metadata: 0x00B0C06D
	private bool weak_; // 0x2E
	public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x00B0C071
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x08
	private readonly RepeatedMessageField<UninterpretedOption> uninterpretedOption_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FieldOptions> Parser { /* [XID] */ /* 0x0000000189A4C820-0x0000000189A4C840 */ get => default; } // 0x0000000182180D00-0x0000000182180DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189A54080-0x0000000189A540A0 */ get => default; } // 0x00000001821805E0-0x00000001821806D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189A5BAB0-0x0000000189A5BAD0 */ get => default; } // 0x000000018217FEC0-0x000000018217FF90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189A63160-0x0000000189A63180 */ get => default; } // 0x000000018217EFE0-0x000000018217F080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x0000000189A6AD00-0x0000000189A6AD20 */ get => default; } // 0x00000001821814E0-0x00000001821815E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x0000000189A72360-0x0000000189A72380 */ get => default; } // 0x00000001821810E0-0x0000000182181180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x0000000189A7A020-0x0000000189A7A040 */ get => default; } // 0x0000000182180750-0x0000000182180850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x0000000189A814C0-0x0000000189A814E0 */ get => default; } // 0x0000000182181440-0x00000001821814E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x0000000189A88EE0-0x0000000189A88F00 */ get => default; } // 0x0000000182180150-0x0000000182180250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.CType Ctype { /* [XID] */ /* 0x0000000189ACF510-0x0000000189ACF530 */ get => default; /* [XID] */ /* 0x0000000189AD7290-0x0000000189AD72B0 */ set {} } // 0x000000018217F0F0-0x000000018217F1D0 0x0000000182180070-0x0000000182180150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Packed { /* [XID] */ /* 0x0000000189ADED30-0x0000000189ADED50 */ get => default; /* [XID] */ /* 0x0000000189AE6680-0x0000000189AE66A0 */ set {} } // 0x0000000182180500-0x00000001821805E0 0x0000000182180C20-0x0000000182180D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.JSType Jstype { /* [XID] */ /* 0x0000000189AEE010-0x0000000189AEE030 */ get => default; /* [XID] */ /* 0x0000000189AF56D0-0x0000000189AF56F0 */ set {} } // 0x0000000182180A60-0x0000000182180B40 0x0000000182180850-0x0000000182180930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Lazy { /* [XID] */ /* 0x0000000189AFCBD0-0x0000000189AFCBF0 */ get => default; /* [XID] */ /* 0x0000000189B04310-0x0000000189B04330 */ set {} } // 0x00000001821815E0-0x00000001821816C0 0x000000018217F430-0x000000018217F510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Deprecated { /* [XID] */ /* 0x0000000189B0BBF0-0x0000000189B0BC10 */ get => default; /* [XID] */ /* 0x0000000189B13130-0x0000000189B13150 */ set {} } // 0x0000000182180B40-0x0000000182180C20 0x0000000182180DD0-0x0000000182180EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Weak { /* [XID] */ /* 0x0000000189B1A8F0-0x0000000189B1A910 */ get => default; /* [XID] */ /* 0x0000000189B21EA0-0x0000000189B21EC0 */ set {} } // 0x000000018217F660-0x000000018217F740 0x000000018217ECC0-0x000000018217EDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<UninterpretedOption> UninterpretedOption { /* [XID] */ /* 0x0000000189B294C0-0x0000000189B294E0 */ get => default; } // 0x000000018217FC00-0x000000018217FCA0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 26376
	{
		// Nested types
		internal enum CType // TypeDefIndex: 26377
		{
			String = 0,
			Cord = 1,
			StringPiece = 2
		}

		internal enum JSType // TypeDefIndex: 26378
		{
			JsNormal = 0,
			JsString = 1,
			JsNumber = 2
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FieldOptions() {} // 0x0000000182181CB0-0x0000000182181D90
	static FieldOptions() {} // 0x0000000182181BA0-0x0000000182181CB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189A906B0-0x0000000189A906F0
	// [XID] // 0x0000000189A906B0-0x0000000189A906F0
	public FieldOptions Clone() => default; // 0x0000000182180930-0x0000000182180A60
	[DebuggerNonUserCode] // 0x0000000189A9AEB0-0x0000000189A9AEF0
	// [XID] // 0x0000000189A9AEB0-0x0000000189A9AEF0
	public FieldOptions ShallowCopy() => default; // 0x000000018217FF90-0x0000000182180070
	[DebuggerNonUserCode] // 0x0000000189AA5350-0x0000000189AA5390
	// [XID] // 0x0000000189AA5350-0x0000000189AA5390
	protected override void InternalSetInPool(bool value) {} // 0x000000018217F5B0-0x000000018217F660
	[DebuggerNonUserCode] // 0x0000000189AAFB10-0x0000000189AAFB50
	// [XID] // 0x0000000189AAFB10-0x0000000189AAFB50
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182180F40-0x0000000182181010
	[DebuggerNonUserCode] // 0x0000000189ABA650-0x0000000189ABA690
	// [XID] // 0x0000000189ABA650-0x0000000189ABA690
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182181010-0x00000001821810E0
	[DebuggerNonUserCode] // 0x0000000189AC4FA0-0x0000000189AC4FE0
	// [XID] // 0x0000000189AC4FA0-0x0000000189AC4FE0
	public override void Reset() {} // 0x000000018217F740-0x000000018217F870
	[DebuggerNonUserCode] // 0x0000000189B30980-0x0000000189B309D0
	// [IDTag] // 0x0000000189B30980-0x0000000189B309D0
	// [XID] // 0x0000000189B30980-0x0000000189B309D0
	public override bool Equals(object other) => default; // 0x000000018217F8E0-0x000000018217F9F0
	[DebuggerNonUserCode] // 0x0000000189B3E0D0-0x0000000189B3E120
	// [IDTag] // 0x0000000189B3E0D0-0x0000000189B3E120
	// [XID] // 0x0000000189B3E0D0-0x0000000189B3E120
	public bool Equals(FieldOptions other) => default; // 0x000000018217F9F0-0x000000018217FC00
	[DebuggerNonUserCode] // 0x0000000189B4BC10-0x0000000189B4BC50
	// [XID] // 0x0000000189B4BC10-0x0000000189B4BC50
	public override int GetHashCode() => default; // 0x0000000182180250-0x0000000182180500
	[DebuggerNonUserCode] // 0x0000000189B564A0-0x0000000189B564E0
	// [XID] // 0x0000000189B564A0-0x0000000189B564E0
	public override string ToString() => default; // 0x00000001821816C0-0x0000000182181BA0
	[DebuggerNonUserCode] // 0x0000000189B60D20-0x0000000189B60D60
	// [XID] // 0x0000000189B60D20-0x0000000189B60D60
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182181180-0x0000000182181440
	[DebuggerNonUserCode] // 0x0000000189B6B320-0x0000000189B6B360
	// [XID] // 0x0000000189B6B320-0x0000000189B6B360
	public override int CalculateSize() => default; // 0x000000018217FCA0-0x000000018217FEC0
	[DebuggerNonUserCode] // 0x0000000189B75710-0x0000000189B75750
	// [XID] // 0x0000000189B75710-0x0000000189B75750
	public void CopyFrom(FieldOptions other) {} // 0x000000018217F1D0-0x000000018217F430
	[DebuggerNonUserCode] // 0x0000000189B7FD50-0x0000000189B7FD90
	// [XID] // 0x0000000189B7FD50-0x0000000189B7FD90
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018217EDA0-0x000000018217EFE0
	// [XID] // 0x0000000189B8A4A0-0x0000000189B8A4C0
	private void OnConstruction() {} // 0x000000018217F510-0x000000018217F5B0
}

