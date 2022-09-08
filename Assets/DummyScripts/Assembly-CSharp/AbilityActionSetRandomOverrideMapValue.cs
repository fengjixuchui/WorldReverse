/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityActionSetRandomOverrideMapValue : MessageBase, IMessage<AbilityActionSetRandomOverrideMapValue> // TypeDefIndex: 21771
{
	// Fields
	private static readonly MessageParser<AbilityActionSetRandomOverrideMapValue> _parser; // 0x00
	public const int RandomValueFieldNumber = 1; // Metadata: 0x00AFFF7F
	private float randomValue_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityActionSetRandomOverrideMapValue> Parser { get => default; } // 0x000000018454C260-0x000000018454C2F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018454BF50-0x000000018454BFE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018454BC50-0x000000018454BCD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018454B6E0-0x000000018454B740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018454C5C0-0x000000018454C6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018454C420-0x000000018454C480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018454C080-0x000000018454C170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018454C570-0x000000018454C5C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018454BD70-0x000000018454BE60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float RandomValue { get => default; set {} } // 0x000000018454BFE0-0x000000018454C080 0x000000018454B740-0x000000018454B7E0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityActionSetRandomOverrideMapValue() {} // 0x000000018454C8F0-0x000000018454C950
	static AbilityActionSetRandomOverrideMapValue() {} // 0x000000018454C830-0x000000018454C8F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityActionSetRandomOverrideMapValue Clone() => default; // 0x000000018454C170-0x000000018454C260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityActionSetRandomOverrideMapValue ShallowCopy() => default; // 0x000000018454BCD0-0x000000018454BD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018454B8F0-0x000000018454B940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018454C380-0x000000018454C3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018454C3D0-0x000000018454C420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018454B940-0x000000018454B9B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018454BAC0-0x000000018454BB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityActionSetRandomOverrideMapValue other) => default; // 0x000000018454B9B0-0x000000018454BAC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018454BE60-0x000000018454BF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018454C6B0-0x000000018454C830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018454C480-0x000000018454C570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018454BB90-0x000000018454BC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityActionSetRandomOverrideMapValue other) {} // 0x000000018454B7E0-0x000000018454B8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018454B600-0x000000018454B6E0
}

