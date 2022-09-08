/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FightPropPair : MessageBase, IMessage<FightPropPair> // TypeDefIndex: 26049
{
	// Fields
	private static readonly MessageParser<FightPropPair> _parser; // 0x00
	public const int PropTypeFieldNumber = 1; // Metadata: 0x00B0AE2B
	private uint propType_; // 0x18
	public const int PropValueFieldNumber = 2; // Metadata: 0x00B0AE2F
	private float propValue_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FightPropPair> Parser { get => default; } // 0x00000001835055C0-0x0000000183505650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001835052B0-0x0000000183505340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183504F80-0x0000000183505000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001835048D0-0x0000000183504930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183505A00-0x0000000183505AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183505820-0x0000000183505880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183505340-0x0000000183505430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001835059B0-0x0000000183505A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001835050A0-0x0000000183505190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PropType { get => default; set {} } // 0x0000000183505520-0x00000001835055C0 0x0000000183504BE0-0x0000000183504C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float PropValue { get => default; set {} } // 0x0000000183504930-0x00000001835049D0 0x00000001835056E0-0x0000000183505780

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FightPropPair() {} // 0x0000000183505DB0-0x0000000183505E10
	static FightPropPair() {} // 0x0000000183505CF0-0x0000000183505DB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FightPropPair Clone() => default; // 0x0000000183505430-0x0000000183505520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FightPropPair ShallowCopy() => default; // 0x0000000183505000-0x00000001835050A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183504B10-0x0000000183504B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183505780-0x00000001835057D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835057D0-0x0000000183505820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183504B60-0x0000000183504BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183504DB0-0x0000000183504E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FightPropPair other) => default; // 0x0000000183504C80-0x0000000183504DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183505190-0x00000001835052B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183505AF0-0x0000000183505CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183505880-0x00000001835059B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183504E80-0x0000000183504F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FightPropPair other) {} // 0x00000001835049D0-0x0000000183504B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001835047D0-0x00000001835048D0
}

