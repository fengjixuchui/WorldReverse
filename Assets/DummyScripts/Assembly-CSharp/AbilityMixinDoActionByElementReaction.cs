/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityMixinDoActionByElementReaction : MessageBase, IMessage<AbilityMixinDoActionByElementReaction> // TypeDefIndex: 21789
{
	// Fields
	private static readonly MessageParser<AbilityMixinDoActionByElementReaction> _parser; // 0x00
	public const int TargetEntityIdFieldNumber = 1; // Metadata: 0x00B00007
	private uint targetEntityId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityMixinDoActionByElementReaction> Parser { get => default; } // 0x0000000182F51EF0-0x0000000182F51F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182F51C80-0x0000000182F51D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182F51990-0x0000000182F51A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182F514A0-0x0000000182F51500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182F52380-0x0000000182F52470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182F52150-0x0000000182F521B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182F51D10-0x0000000182F51E00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182F52290-0x0000000182F522E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182F51AB0-0x0000000182F51BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetEntityId { get => default; set {} } // 0x0000000182F522E0-0x0000000182F52380 0x0000000182F520B0-0x0000000182F52150

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinDoActionByElementReaction() {} // 0x0000000182F526A0-0x0000000182F52700
	static AbilityMixinDoActionByElementReaction() {} // 0x0000000182F525E0-0x0000000182F526A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinDoActionByElementReaction Clone() => default; // 0x0000000182F51E00-0x0000000182F51EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinDoActionByElementReaction ShallowCopy() => default; // 0x0000000182F51A10-0x0000000182F51AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182F51610-0x0000000182F51660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182F52010-0x0000000182F52060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182F52060-0x0000000182F520B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182F51660-0x0000000182F516D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182F517D0-0x0000000182F518A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityMixinDoActionByElementReaction other) => default; // 0x0000000182F516D0-0x0000000182F517D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182F51BA0-0x0000000182F51C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182F52470-0x0000000182F525E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182F521B0-0x0000000182F52290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182F518A0-0x0000000182F51990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityMixinDoActionByElementReaction other) {} // 0x0000000182F51500-0x0000000182F51610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182F513C0-0x0000000182F514A0
}

