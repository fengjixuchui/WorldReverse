/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TrialAvatarInfo : MessageBase, IMessage<TrialAvatarInfo> // TypeDefIndex: 26064
{
	// Fields
	private static readonly MessageParser<TrialAvatarInfo> _parser; // 0x00
	public const int TrialAvatarIdFieldNumber = 1; // Metadata: 0x00B0AF27
	private uint trialAvatarId_; // 0x18
	public const int TrialEquipListFieldNumber = 2; // Metadata: 0x00B0AF2B
	private static readonly FieldCodec<Item> _repeated_trialEquipList_codec; // 0x08
	private readonly RepeatedMessageField<Item> trialEquipList_; // 0x20
	public const int GrantRecordFieldNumber = 3; // Metadata: 0x00B0AF2F
	private TrialAvatarGrantRecord grantRecord_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TrialAvatarInfo> Parser { get => default; } // 0x0000000182EDC530-0x0000000182EDC5C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182EDC180-0x0000000182EDC210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182EDBDC0-0x0000000182EDBE40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182EDB400-0x0000000182EDB460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182EDCA20-0x0000000182EDCB10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182EDC7F0-0x0000000182EDC850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182EDC350-0x0000000182EDC440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182EDC9D0-0x0000000182EDCA20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182EDBEE0-0x0000000182EDBFD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TrialAvatarId { get => default; set {} } // 0x0000000182EDC2B0-0x0000000182EDC350 0x0000000182EDB640-0x0000000182EDB6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Item> TrialEquipList { get => default; } // 0x0000000182EDC790-0x0000000182EDC7F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrialAvatarGrantRecord GrantRecord { get => default; set {} } // 0x0000000182EDC210-0x0000000182EDC2B0 0x0000000182EDB760-0x0000000182EDB800

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrialAvatarInfo() {} // 0x0000000182EDCE80-0x0000000182EDCF10
	static TrialAvatarInfo() {} // 0x0000000182EDCD70-0x0000000182EDCE80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrialAvatarInfo Clone() => default; // 0x0000000182EDC440-0x0000000182EDC530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrialAvatarInfo ShallowCopy() => default; // 0x0000000182EDBE40-0x0000000182EDBEE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182EDB6E0-0x0000000182EDB760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182EDC650-0x0000000182EDC6F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182EDC6F0-0x0000000182EDC790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182EDB800-0x0000000182EDB9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182EDB9A0-0x0000000182EDBA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TrialAvatarInfo other) => default; // 0x0000000182EDBA70-0x0000000182EDBBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182EDBFD0-0x0000000182EDC180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182EDCB10-0x0000000182EDCD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182EDC850-0x0000000182EDC9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182EDBBD0-0x0000000182EDBDC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TrialAvatarInfo other) {} // 0x0000000182EDB460-0x0000000182EDB640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182EDB240-0x0000000182EDB400
}

