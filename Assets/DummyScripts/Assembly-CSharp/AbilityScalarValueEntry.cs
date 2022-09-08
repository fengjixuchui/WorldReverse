/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityScalarValueEntry : MessageBase, IMessage<AbilityScalarValueEntry> // TypeDefIndex: 25993
{
	// Fields
	private static readonly MessageParser<AbilityScalarValueEntry> _parser; // 0x00
	public const int KeyFieldNumber = 1; // Metadata: 0x00B0A95B
	private AbilityString key_; // 0x18
	public const int ValueTypeFieldNumber = 2; // Metadata: 0x00B0A95F
	private AbilityScalarType valueType_; // 0x20
	public const int FloatValueFieldNumber = 3; // Metadata: 0x00B0A963
	public const int StringValueFieldNumber = 4; // Metadata: 0x00B0A967
	public const int IntValueFieldNumber = 5; // Metadata: 0x00B0A96B
	public const int UintValueFieldNumber = 6; // Metadata: 0x00B0A96F
	private object value_; // 0x28
	private ValueOneofCase valueCase_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityScalarValueEntry> Parser { get => default; } // 0x0000000180FCE4D0-0x0000000180FCE560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000180FCE0A0-0x0000000180FCE130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000180FCDA80-0x0000000180FCDB00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000180FCCCD0-0x0000000180FCCD30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000180FCEAE0-0x0000000180FCEBD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000180FCE790-0x0000000180FCE7F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000180FCE240-0x0000000180FCE330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000180FCEA90-0x0000000180FCEAE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000180FCDBA0-0x0000000180FCDC90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityString Key { get => default; set {} } // 0x0000000180FCECA0-0x0000000180FCED40 0x0000000180FCCD90-0x0000000180FCCE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityScalarType ValueType { get => default; set {} } // 0x0000000180FCE7F0-0x0000000180FCE890 0x0000000180FCE6F0-0x0000000180FCE790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float FloatValue { get => default; set {} } // 0x0000000180FCD080-0x0000000180FCD160 0x0000000180FCD1E0-0x0000000180FCD2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string StringValue { get => default; set {} } // 0x0000000180FCDFD0-0x0000000180FCE0A0 0x0000000180FCDF10-0x0000000180FCDFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int IntValue { get => default; set {} } // 0x0000000180FCD470-0x0000000180FCD540 0x0000000180FCE420-0x0000000180FCE4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint UintValue { get => default; set {} } // 0x0000000180FCEBD0-0x0000000180FCECA0 0x0000000180FCE130-0x0000000180FCE1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ValueOneofCase ValueCase { get => default; } // 0x0000000180FCCD30-0x0000000180FCCD90 

	// Nested types
	public enum ValueOneofCase // TypeDefIndex: 25994
	{
		None = 0,
		FloatValue = 3,
		StringValue = 4,
		IntValue = 5,
		UintValue = 6
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityScalarValueEntry() {} // 0x0000000180FCF270-0x0000000180FCF2E0
	static AbilityScalarValueEntry() {} // 0x0000000180FCF1B0-0x0000000180FCF270

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityScalarValueEntry Clone() => default; // 0x0000000180FCE330-0x0000000180FCE420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityScalarValueEntry ShallowCopy() => default; // 0x0000000180FCDB00-0x0000000180FCDBA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000180FCD160-0x0000000180FCD1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180FCE5F0-0x0000000180FCE670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180FCE670-0x0000000180FCE6F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000180FCD2A0-0x0000000180FCD3E0
	public void resetValue() {} // 0x0000000180FCD3E0-0x0000000180FCD470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearValue() {} // 0x0000000180FCE1E0-0x0000000180FCE240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000180FCD750-0x0000000180FCD820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityScalarValueEntry other) => default; // 0x0000000180FCD540-0x0000000180FCD750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000180FCDC90-0x0000000180FCDF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000180FCED40-0x0000000180FCF1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000180FCE890-0x0000000180FCEA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000180FCD820-0x0000000180FCDA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityScalarValueEntry other) {} // 0x0000000180FCCE30-0x0000000180FCD080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000180FCCB30-0x0000000180FCCCD0
}

