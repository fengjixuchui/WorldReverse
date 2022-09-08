/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityActionSetCrashDamage : MessageBase, IMessage<AbilityActionSetCrashDamage> // TypeDefIndex: 21766
{
	// Fields
	private static readonly MessageParser<AbilityActionSetCrashDamage> _parser; // 0x00
	public const int DamageFieldNumber = 1; // Metadata: 0x00AFFF4F
	private float damage_; // 0x18
	public const int HitPosFieldNumber = 2; // Metadata: 0x00AFFF53
	private Vector hitPos_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityActionSetCrashDamage> Parser { get => default; } // 0x00000001824578D0-0x0000000182457960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001824575C0-0x0000000182457650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182457220-0x00000001824572A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182456A70-0x0000000182456AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182457D60-0x0000000182457E50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182457B90-0x0000000182457BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001824576F0-0x00000001824577E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182457D10-0x0000000182457D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182457340-0x0000000182457430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float Damage { get => default; set {} } // 0x0000000182457AF0-0x0000000182457B90 0x0000000182456AD0-0x0000000182456B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector HitPos { get => default; set {} } // 0x0000000182457650-0x00000001824576F0 0x00000001824569D0-0x0000000182456A70

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityActionSetCrashDamage() {} // 0x0000000182458100-0x0000000182458160
	static AbilityActionSetCrashDamage() {} // 0x0000000182458040-0x0000000182458100

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityActionSetCrashDamage Clone() => default; // 0x00000001824577E0-0x00000001824578D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityActionSetCrashDamage ShallowCopy() => default; // 0x00000001824572A0-0x0000000182457340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182456D00-0x0000000182456D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001824579F0-0x0000000182457A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182457A70-0x0000000182457AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182456D80-0x0000000182456EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182456EB0-0x0000000182456F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityActionSetCrashDamage other) => default; // 0x0000000182456F80-0x00000001824570B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182457430-0x00000001824575C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182457E50-0x0000000182458040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182457BF0-0x0000000182457D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001824570B0-0x0000000182457220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityActionSetCrashDamage other) {} // 0x0000000182456B70-0x0000000182456D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182456890-0x00000001824569D0
}

