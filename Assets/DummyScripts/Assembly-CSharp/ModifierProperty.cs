/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ModifierProperty : MessageBase, IMessage<ModifierProperty> // TypeDefIndex: 21754
{
	// Fields
	private static readonly MessageParser<ModifierProperty> _parser; // 0x00
	public const int KeyFieldNumber = 1; // Metadata: 0x00AFFED3
	private AbilityString key_; // 0x18
	public const int ValueFieldNumber = 2; // Metadata: 0x00AFFED7
	private float value_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ModifierProperty> Parser { get => default; } // 0x0000000182C7E860-0x0000000182C7E8F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182C7E550-0x0000000182C7E5E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182C7E1B0-0x0000000182C7E230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182C7D9E0-0x0000000182C7DA40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182C7ECF0-0x0000000182C7EDE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182C7EB20-0x0000000182C7EB80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182C7E680-0x0000000182C7E770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182C7ECA0-0x0000000182C7ECF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182C7E2D0-0x0000000182C7E3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityString Key { get => default; set {} } // 0x0000000182C7EDE0-0x0000000182C7EE80 0x0000000182C7DA40-0x0000000182C7DAE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float Value { get => default; set {} } // 0x0000000182C7E5E0-0x0000000182C7E680 0x0000000182C7EA00-0x0000000182C7EAA0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ModifierProperty() {} // 0x0000000182C7F130-0x0000000182C7F190
	static ModifierProperty() {} // 0x0000000182C7F070-0x0000000182C7F130

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ModifierProperty Clone() => default; // 0x0000000182C7E770-0x0000000182C7E860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ModifierProperty ShallowCopy() => default; // 0x0000000182C7E230-0x0000000182C7E2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182C7DC80-0x0000000182C7DD00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C7E980-0x0000000182C7EA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C7EAA0-0x0000000182C7EB20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182C7DD00-0x0000000182C7DE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182C7DE30-0x0000000182C7DF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ModifierProperty other) => default; // 0x0000000182C7DF00-0x0000000182C7E040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182C7E3C0-0x0000000182C7E550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182C7EE80-0x0000000182C7F070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182C7EB80-0x0000000182C7ECA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182C7E040-0x0000000182C7E1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ModifierProperty other) {} // 0x0000000182C7DAE0-0x0000000182C7DC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182C7D8B0-0x0000000182C7D9E0
}

