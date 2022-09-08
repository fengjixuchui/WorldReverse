/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HideAndSeekPlayerBattleInfo : MessageBase, IMessage<HideAndSeekPlayerBattleInfo> // TypeDefIndex: 24176
{
	// Fields
	private static readonly MessageParser<HideAndSeekPlayerBattleInfo> _parser; // 0x00
	public const int AvatarIdFieldNumber = 1; // Metadata: 0x00B05C6F
	private uint avatarId_; // 0x18
	public const int SkillListFieldNumber = 2; // Metadata: 0x00B05C73
	private static readonly FieldCodec<uint> _repeated_skillList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> skillList_; // 0x20
	public const int IsReadyFieldNumber = 3; // Metadata: 0x00B05C77
	private bool isReady_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HideAndSeekPlayerBattleInfo> Parser { get => default; } // 0x0000000181B00650-0x0000000181B006E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181B003E0-0x0000000181B00470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181B00040-0x0000000181B000C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181AFF760-0x0000000181AFF7C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181B00A40-0x0000000181B00B30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181B00810-0x0000000181B00870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181B00470-0x0000000181B00560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181B009F0-0x0000000181B00A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181B001C0-0x0000000181B002B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarId { get => default; set {} } // 0x0000000181AFFF00-0x0000000181AFFFA0 0x0000000181AFFFA0-0x0000000181B00040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> SkillList { get => default; } // 0x0000000181B000C0-0x0000000181B00120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsReady { get => default; set {} } // 0x0000000181AFFAF0-0x0000000181AFFB90 0x0000000181AFF7C0-0x0000000181AFF860

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekPlayerBattleInfo() {} // 0x0000000181B00E80-0x0000000181B00F10
	static HideAndSeekPlayerBattleInfo() {} // 0x0000000181B00DA0-0x0000000181B00E80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekPlayerBattleInfo Clone() => default; // 0x0000000181B00560-0x0000000181B00650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekPlayerBattleInfo ShallowCopy() => default; // 0x0000000181B00120-0x0000000181B001C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181AFF9C0-0x0000000181AFFA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181B00770-0x0000000181B007C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181B007C0-0x0000000181B00810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181AFFA10-0x0000000181AFFAF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181AFFB90-0x0000000181AFFC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HideAndSeekPlayerBattleInfo other) => default; // 0x0000000181AFFC60-0x0000000181AFFDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181B002B0-0x0000000181B003E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181B00B30-0x0000000181B00DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181B00870-0x0000000181B009F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181AFFDA0-0x0000000181AFFF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HideAndSeekPlayerBattleInfo other) {} // 0x0000000181AFF860-0x0000000181AFF9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181AFF5E0-0x0000000181AFF760
}

