/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AnimatorParameterValueInfoPair : MessageBase, IMessage<AnimatorParameterValueInfoPair> // TypeDefIndex: 26050
{
	// Fields
	private static readonly MessageParser<AnimatorParameterValueInfoPair> _parser; // 0x00
	public const int NameIdFieldNumber = 1; // Metadata: 0x00B0AE33
	private int nameId_; // 0x18
	public const int AnimatorParaFieldNumber = 2; // Metadata: 0x00B0AE37
	private AnimatorParameterValueInfo animatorPara_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AnimatorParameterValueInfoPair> Parser { get => default; } // 0x00000001818F23A0-0x00000001818F2430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001818F2130-0x00000001818F21C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001818F1DA0-0x00000001818F1E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001818F1530-0x00000001818F1590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001818F28D0-0x00000001818F29C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001818F25C0-0x00000001818F2620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001818F21C0-0x00000001818F22B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001818F2880-0x00000001818F28D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001818F1EC0-0x00000001818F1FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int NameId { get => default; set {} } // 0x00000001818F1710-0x00000001818F17B0 0x00000001818F2620-0x00000001818F26C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnimatorParameterValueInfo AnimatorPara { get => default; set {} } // 0x00000001818F27E0-0x00000001818F2880 0x00000001818F1960-0x00000001818F1A00

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnimatorParameterValueInfoPair() {} // 0x00000001818F2C60-0x00000001818F2CC0
	static AnimatorParameterValueInfoPair() {} // 0x00000001818F2BA0-0x00000001818F2C60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnimatorParameterValueInfoPair Clone() => default; // 0x00000001818F22B0-0x00000001818F23A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AnimatorParameterValueInfoPair ShallowCopy() => default; // 0x00000001818F1E20-0x00000001818F1EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001818F17B0-0x00000001818F1830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818F24C0-0x00000001818F2540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818F2540-0x00000001818F25C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001818F1830-0x00000001818F1960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001818F1B30-0x00000001818F1C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AnimatorParameterValueInfoPair other) => default; // 0x00000001818F1A00-0x00000001818F1B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001818F1FB0-0x00000001818F2130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001818F29C0-0x00000001818F2BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001818F26C0-0x00000001818F27E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001818F1C00-0x00000001818F1DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AnimatorParameterValueInfoPair other) {} // 0x00000001818F1590-0x00000001818F1710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001818F13F0-0x00000001818F1530
}

