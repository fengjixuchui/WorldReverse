/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BigTalentPointConvertReq : MessageBase, IMessage<BigTalentPointConvertReq> // TypeDefIndex: 25489
{
	// Fields
	private static readonly MessageParser<BigTalentPointConvertReq> _parser; // 0x00
	public const int AvatarGuidFieldNumber = 1; // Metadata: 0x00B08E0B
	private ulong avatarGuid_; // 0x18
	public const int ItemGuidListFieldNumber = 2; // Metadata: 0x00B08E0F
	private static readonly FieldCodec<ulong> _repeated_itemGuidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<ulong> itemGuidList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BigTalentPointConvertReq> Parser { get => default; } // 0x00000001811D2050-0x00000001811D20E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001811D1D40-0x00000001811D1DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001811D1A30-0x00000001811D1AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001811D1350-0x00000001811D13B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001811D2400-0x00000001811D24F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001811D2210-0x00000001811D2270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001811D1E70-0x00000001811D1F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001811D23B0-0x00000001811D2400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001811D1B50-0x00000001811D1C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x00000001811D1DD0-0x00000001811D1E70 0x00000001811D14E0-0x00000001811D1580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<ulong> ItemGuidList { get => default; } // 0x00000001811D1690-0x00000001811D16F0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25490
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25491
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1005
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BigTalentPointConvertReq() {} // 0x00000001811D27C0-0x00000001811D2850
	static BigTalentPointConvertReq() {} // 0x00000001811D26E0-0x00000001811D27C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BigTalentPointConvertReq Clone() => default; // 0x00000001811D1F60-0x00000001811D2050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BigTalentPointConvertReq ShallowCopy() => default; // 0x00000001811D1AB0-0x00000001811D1B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001811D1580-0x00000001811D15D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001811D2170-0x00000001811D21C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001811D21C0-0x00000001811D2210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001811D15D0-0x00000001811D1690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001811D1820-0x00000001811D18F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BigTalentPointConvertReq other) => default; // 0x00000001811D16F0-0x00000001811D1820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001811D1C40-0x00000001811D1D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001811D24F0-0x00000001811D26E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001811D2270-0x00000001811D23B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001811D18F0-0x00000001811D1A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BigTalentPointConvertReq other) {} // 0x00000001811D13B0-0x00000001811D14E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001811D11E0-0x00000001811D1350
}

