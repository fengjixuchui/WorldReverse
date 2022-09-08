/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityString : MessageBase, IMessage<AbilityString> // TypeDefIndex: 25990
{
	// Fields
	private static readonly MessageParser<AbilityString> _parser; // 0x00
	public const int StrFieldNumber = 1; // Metadata: 0x00B0A943
	public const int HashFieldNumber = 2; // Metadata: 0x00B0A947
	private object type_; // 0x18
	private TypeOneofCase typeCase_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityString> Parser { get => default; } // 0x0000000181C60830-0x0000000181C608C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181C60490-0x0000000181C60520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181C600B0-0x0000000181C60130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181C5F9E0-0x0000000181C5FA40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181C60BB0-0x0000000181C60CA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181C609F0-0x0000000181C60A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181C60580-0x0000000181C60670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181C60B60-0x0000000181C60BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181C601D0-0x0000000181C602C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Str { get => default; set {} } // 0x0000000181C60CA0-0x0000000181C60D70 0x0000000181C603D0-0x0000000181C60490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Hash { get => default; set {} } // 0x0000000181C60760-0x0000000181C60830 0x0000000181C5F930-0x0000000181C5F9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TypeOneofCase TypeCase { get => default; } // 0x0000000181C60520-0x0000000181C60580 

	// Nested types
	public enum TypeOneofCase // TypeDefIndex: 25991
	{
		None = 0,
		Str = 1,
		Hash = 2
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityString() {} // 0x0000000181C61040-0x0000000181C610B0
	static AbilityString() {} // 0x0000000181C60F80-0x0000000181C61040

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityString Clone() => default; // 0x0000000181C60670-0x0000000181C60760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityString ShallowCopy() => default; // 0x0000000181C60130-0x0000000181C601D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181C5FCA0-0x0000000181C5FCF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181C60950-0x0000000181C609A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181C609A0-0x0000000181C609F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181C5FCF0-0x0000000181C5FD50
	public void resetType() {} // 0x0000000181C5FA40-0x0000000181C5FAC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearType() {} // 0x0000000181C5FC40-0x0000000181C5FCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181C5FD50-0x0000000181C5FE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityString other) => default; // 0x0000000181C5FE20-0x0000000181C5FF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181C602C0-0x0000000181C603D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181C60D70-0x0000000181C60F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181C60A50-0x0000000181C60B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181C5FF90-0x0000000181C600B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityString other) {} // 0x0000000181C5FAC0-0x0000000181C5FC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181C5F830-0x0000000181C5F930
}

