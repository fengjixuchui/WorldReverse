/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityMetaAddOrGetAbilityAndTrigger : MessageBase, IMessage<AbilityMetaAddOrGetAbilityAndTrigger> // TypeDefIndex: 21757
{
	// Fields
	private static readonly MessageParser<AbilityMetaAddOrGetAbilityAndTrigger> _parser; // 0x00
	public const int AbilityNameFieldNumber = 1; // Metadata: 0x00AFFF0B
	private AbilityString abilityName_; // 0x18
	public const int AbilityOverrideFieldNumber = 2; // Metadata: 0x00AFFF0F
	private AbilityString abilityOverride_; // 0x20
	public const int TriggerArgumentFieldNumber = 3; // Metadata: 0x00AFFF13
	private float triggerArgument_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityMetaAddOrGetAbilityAndTrigger> Parser { get => default; } // 0x00000001859466D0-0x0000000185946760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001859463C0-0x0000000185946450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185945F70-0x0000000185945FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001859453A0-0x0000000185945400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185946BC0-0x0000000185946CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185946910-0x0000000185946970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185946450-0x0000000185946540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185946B70-0x0000000185946BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185946090-0x0000000185946180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityString AbilityName { get => default; set {} } // 0x0000000185946540-0x00000001859465E0 0x0000000185946AD0-0x0000000185946B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityString AbilityOverride { get => default; set {} } // 0x0000000185945ED0-0x0000000185945F70 0x00000001859456B0-0x0000000185945750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float TriggerArgument { get => default; set {} } // 0x0000000185945400-0x00000001859454A0 0x00000001859459D0-0x0000000185945A70

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMetaAddOrGetAbilityAndTrigger() {} // 0x0000000185946FD0-0x0000000185947030
	static AbilityMetaAddOrGetAbilityAndTrigger() {} // 0x0000000185946F10-0x0000000185946FD0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMetaAddOrGetAbilityAndTrigger Clone() => default; // 0x00000001859465E0-0x00000001859466D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMetaAddOrGetAbilityAndTrigger ShallowCopy() => default; // 0x0000000185945FF0-0x0000000185946090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185945750-0x00000001859457E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001859467F0-0x0000000185946880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185946880-0x0000000185946910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001859457E0-0x00000001859459D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185945A70-0x0000000185945B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityMetaAddOrGetAbilityAndTrigger other) => default; // 0x0000000185945B40-0x0000000185945CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185946180-0x00000001859463C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185946CB0-0x0000000185946F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185946970-0x0000000185946AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185945CB0-0x0000000185945ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityMetaAddOrGetAbilityAndTrigger other) {} // 0x00000001859454A0-0x00000001859456B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185945210-0x00000001859453A0
}

