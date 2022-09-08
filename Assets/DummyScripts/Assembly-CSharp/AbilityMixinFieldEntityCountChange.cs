/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityMixinFieldEntityCountChange : MessageBase, IMessage<AbilityMixinFieldEntityCountChange> // TypeDefIndex: 21790
{
	// Fields
	private static readonly MessageParser<AbilityMixinFieldEntityCountChange> _parser; // 0x00
	public const int FieldEntityCountFieldNumber = 1; // Metadata: 0x00B0000B
	private uint fieldEntityCount_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityMixinFieldEntityCountChange> Parser { get => default; } // 0x000000018278F970-0x000000018278FA00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018278F700-0x000000018278F790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018278F410-0x000000018278F490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018278EE80-0x000000018278EEE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018278FD60-0x000000018278FE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018278FB30-0x000000018278FB90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018278F790-0x000000018278F880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018278FC70-0x000000018278FCC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018278F530-0x000000018278F620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FieldEntityCount { get => default; set {} } // 0x000000018278F370-0x000000018278F410 0x000000018278FCC0-0x000000018278FD60

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinFieldEntityCountChange() {} // 0x0000000182790080-0x00000001827900E0
	static AbilityMixinFieldEntityCountChange() {} // 0x000000018278FFC0-0x0000000182790080

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinFieldEntityCountChange Clone() => default; // 0x000000018278F880-0x000000018278F970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinFieldEntityCountChange ShallowCopy() => default; // 0x000000018278F490-0x000000018278F530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018278EFF0-0x000000018278F040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018278FA90-0x000000018278FAE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018278FAE0-0x000000018278FB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018278F040-0x000000018278F0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018278F0B0-0x000000018278F180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityMixinFieldEntityCountChange other) => default; // 0x000000018278F180-0x000000018278F280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018278F620-0x000000018278F700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018278FE50-0x000000018278FFC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018278FB90-0x000000018278FC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018278F280-0x000000018278F370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityMixinFieldEntityCountChange other) {} // 0x000000018278EEE0-0x000000018278EFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018278EDA0-0x000000018278EE80
}

