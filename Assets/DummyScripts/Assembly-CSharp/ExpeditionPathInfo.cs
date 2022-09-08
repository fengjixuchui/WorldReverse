/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ExpeditionPathInfo : MessageBase, IMessage<ExpeditionPathInfo> // TypeDefIndex: 22164
{
	// Fields
	private static readonly MessageParser<ExpeditionPathInfo> _parser; // 0x00
	public const int PathIdFieldNumber = 1; // Metadata: 0x00B00EFF
	private uint pathId_; // 0x18
	public const int StateFieldNumber = 2; // Metadata: 0x00B00F03
	private ExpeditionState state_; // 0x1C
	public const int StartTimeFieldNumber = 3; // Metadata: 0x00B00F07
	private uint startTime_; // 0x20
	public const int AvatarIdListFieldNumber = 4; // Metadata: 0x00B00F0B
	private static readonly FieldCodec<uint> _repeated_avatarIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> avatarIdList_; // 0x28
	public const int AssistUidFieldNumber = 5; // Metadata: 0x00B00F0F
	private uint assistUid_; // 0x30
	public const int AssistAvatarIdFieldNumber = 6; // Metadata: 0x00B00F13
	private uint assistAvatarId_; // 0x34
	public const int MarkIdFieldNumber = 7; // Metadata: 0x00B00F17
	private uint markId_; // 0x38
	public const int BonusProbabilityFieldNumber = 8; // Metadata: 0x00B00F1B
	private float bonusProbability_; // 0x3C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ExpeditionPathInfo> Parser { get => default; } // 0x00000001818477F0-0x0000000181847880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001818473A0-0x0000000181847430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181846F30-0x0000000181846FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181846230-0x0000000181846290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181847FA0-0x0000000181848090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181847B90-0x0000000181847BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001818474D0-0x00000001818475C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181847F50-0x0000000181847FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181847050-0x0000000181847140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PathId { get => default; set {} } // 0x00000001818466C0-0x0000000181846760 0x0000000181846190-0x0000000181846230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionState State { get => default; set {} } // 0x0000000181846CF0-0x0000000181846D90 0x0000000181846D90-0x0000000181846E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StartTime { get => default; set {} } // 0x0000000181848090-0x0000000181848130 0x0000000181847430-0x00000001818474D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> AvatarIdList { get => default; } // 0x0000000181846ED0-0x0000000181846F30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AssistUid { get => default; set {} } // 0x0000000181847EB0-0x0000000181847F50 0x0000000181847750-0x00000001818477F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AssistAvatarId { get => default; set {} } // 0x00000001818479B0-0x0000000181847A50 0x0000000181846E30-0x0000000181846ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MarkId { get => default; set {} } // 0x00000001818476B0-0x0000000181847750 0x0000000181847880-0x0000000181847920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float BonusProbability { get => default; set {} } // 0x0000000181847AF0-0x0000000181847B90 0x00000001818464B0-0x0000000181846550

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionPathInfo() {} // 0x0000000181848740-0x00000001818487E0
	static ExpeditionPathInfo() {} // 0x0000000181848660-0x0000000181848740

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionPathInfo Clone() => default; // 0x00000001818475C0-0x00000001818476B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionPathInfo ShallowCopy() => default; // 0x0000000181846FB0-0x0000000181847050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181846550-0x00000001818465A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181847A50-0x0000000181847AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181847AA0-0x0000000181847AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001818465A0-0x00000001818466C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181846950-0x0000000181846A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ExpeditionPathInfo other) => default; // 0x0000000181846760-0x0000000181846950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181847140-0x00000001818473A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181848130-0x0000000181848660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181847BF0-0x0000000181847EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181846A20-0x0000000181846CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ExpeditionPathInfo other) {} // 0x0000000181846290-0x00000001818464B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181845F80-0x0000000181846190
}

