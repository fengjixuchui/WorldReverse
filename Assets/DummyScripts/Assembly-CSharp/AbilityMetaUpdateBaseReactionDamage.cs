/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityMetaUpdateBaseReactionDamage : MessageBase, IMessage<AbilityMetaUpdateBaseReactionDamage> // TypeDefIndex: 21764
{
	// Fields
	private static readonly MessageParser<AbilityMetaUpdateBaseReactionDamage> _parser; // 0x00
	public const int SourceCasterIdFieldNumber = 1; // Metadata: 0x00AFFF3F
	private uint sourceCasterId_; // 0x18
	public const int ReactionTypeFieldNumber = 2; // Metadata: 0x00AFFF43
	private uint reactionType_; // 0x1C
	public const int GlobalValueKeyFieldNumber = 3; // Metadata: 0x00AFFF47
	private AbilityString globalValueKey_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityMetaUpdateBaseReactionDamage> Parser { get => default; } // 0x0000000181D3FE70-0x0000000181D3FF00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181D3FC00-0x0000000181D3FC90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181D3F840-0x0000000181D3F8C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181D3EDF0-0x0000000181D3EE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181D40340-0x0000000181D40430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181D40130-0x0000000181D40190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181D3FC90-0x0000000181D3FD80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181D402F0-0x0000000181D40340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181D3F960-0x0000000181D3FA50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SourceCasterId { get => default; set {} } // 0x0000000181D40090-0x0000000181D40130 0x0000000181D3F260-0x0000000181D3F300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ReactionType { get => default; set {} } // 0x0000000181D3EE50-0x0000000181D3EEF0 0x0000000181D3F520-0x0000000181D3F5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityString GlobalValueKey { get => default; set {} } // 0x0000000181D3ED50-0x0000000181D3EDF0 0x0000000181D3F7A0-0x0000000181D3F840

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMetaUpdateBaseReactionDamage() {} // 0x0000000181D40760-0x0000000181D407C0
	static AbilityMetaUpdateBaseReactionDamage() {} // 0x0000000181D406A0-0x0000000181D40760

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMetaUpdateBaseReactionDamage Clone() => default; // 0x0000000181D3FD80-0x0000000181D3FE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMetaUpdateBaseReactionDamage ShallowCopy() => default; // 0x0000000181D3F8C0-0x0000000181D3F960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181D3F0A0-0x0000000181D3F120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D3FF90-0x0000000181D40010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D40010-0x0000000181D40090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181D3F120-0x0000000181D3F260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181D3F300-0x0000000181D3F3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityMetaUpdateBaseReactionDamage other) => default; // 0x0000000181D3F3D0-0x0000000181D3F520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181D3FA50-0x0000000181D3FC00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181D40430-0x0000000181D406A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181D40190-0x0000000181D402F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181D3F5C0-0x0000000181D3F7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityMetaUpdateBaseReactionDamage other) {} // 0x0000000181D3EEF0-0x0000000181D3F0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181D3EBF0-0x0000000181D3ED50
}

