/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityMetaSpecialFloatArgument : MessageBase, IMessage<AbilityMetaSpecialFloatArgument> // TypeDefIndex: 21756
{
	// Fields
	private static readonly MessageParser<AbilityMetaSpecialFloatArgument> _parser; // 0x00
	public const int ArgumentValueFieldNumber = 1; // Metadata: 0x00AFFF03
	private float argumentValue_; // 0x18
	public const int IsOnFieldNumber = 2; // Metadata: 0x00AFFF07
	private bool isOn_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityMetaSpecialFloatArgument> Parser { get => default; } // 0x0000000181255B20-0x0000000181255BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181255810-0x00000001812558A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181255440-0x00000001812554C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181254E70-0x0000000181254ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181255F60-0x0000000181256050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181255D80-0x0000000181255DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001812558A0-0x0000000181255990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181255F10-0x0000000181255F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181255600-0x00000001812556F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float ArgumentValue { get => default; set {} } // 0x0000000181255BB0-0x0000000181255C50 0x00000001812550E0-0x0000000181255180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsOn { get => default; set {} } // 0x0000000181255A80-0x0000000181255B20 0x00000001812554C0-0x0000000181255560

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMetaSpecialFloatArgument() {} // 0x0000000181256310-0x0000000181256370
	static AbilityMetaSpecialFloatArgument() {} // 0x0000000181256250-0x0000000181256310

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMetaSpecialFloatArgument Clone() => default; // 0x0000000181255990-0x0000000181255A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMetaSpecialFloatArgument ShallowCopy() => default; // 0x0000000181255560-0x0000000181255600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181255010-0x0000000181255060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181255CE0-0x0000000181255D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181255D30-0x0000000181255D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181255060-0x00000001812550E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181255180-0x0000000181255250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityMetaSpecialFloatArgument other) => default; // 0x0000000181255250-0x0000000181255370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001812556F0-0x0000000181255810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181256050-0x0000000181256250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181255DE0-0x0000000181255F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181255370-0x0000000181255440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityMetaSpecialFloatArgument other) {} // 0x0000000181254ED0-0x0000000181255010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181254D70-0x0000000181254E70
}

