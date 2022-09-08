/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AISnapshotEntitySkillCycle : MessageBase, IMessage<AISnapshotEntitySkillCycle> // TypeDefIndex: 25690
{
	// Fields
	private static readonly MessageParser<AISnapshotEntitySkillCycle> _parser; // 0x00
	public const int SkillIdFieldNumber = 1; // Metadata: 0x00B09563
	private uint skillId_; // 0x18
	public const int SelectedFieldNumber = 2; // Metadata: 0x00B09567
	private bool selected_; // 0x1C
	public const int TrydoskillFieldNumber = 3; // Metadata: 0x00B0956B
	private bool trydoskill_; // 0x1D
	public const int SuccessFieldNumber = 4; // Metadata: 0x00B0956F
	private bool success_; // 0x1E
	public const int FailedFieldNumber = 5; // Metadata: 0x00B09573
	private bool failed_; // 0x1F

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AISnapshotEntitySkillCycle> Parser { get => default; } // 0x0000000183C33EE0-0x0000000183C33F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183C33BD0-0x0000000183C33C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183C336F0-0x0000000183C33770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183C32DF0-0x0000000183C32E50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183C343D0-0x0000000183C344C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183C34140-0x0000000183C341A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183C33D00-0x0000000183C33DF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183C34380-0x0000000183C343D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183C338B0-0x0000000183C339A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SkillId { get => default; set {} } // 0x0000000183C33810-0x0000000183C338B0 0x0000000183C33C60-0x0000000183C33D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Selected { get => default; set {} } // 0x0000000183C32E50-0x0000000183C32EF0 0x0000000183C33F70-0x0000000183C34010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Trydoskill { get => default; set {} } // 0x0000000183C332D0-0x0000000183C33370 0x0000000183C33B30-0x0000000183C33BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Success { get => default; set {} } // 0x0000000183C33190-0x0000000183C33230 0x0000000183C32B50-0x0000000183C32BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Failed { get => default; set {} } // 0x0000000183C32D50-0x0000000183C32DF0 0x0000000183C330A0-0x0000000183C33140

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AISnapshotEntitySkillCycle() {} // 0x0000000183C34930-0x0000000183C34990
	static AISnapshotEntitySkillCycle() {} // 0x0000000183C34870-0x0000000183C34930

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AISnapshotEntitySkillCycle Clone() => default; // 0x0000000183C33DF0-0x0000000183C33EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AISnapshotEntitySkillCycle ShallowCopy() => default; // 0x0000000183C33770-0x0000000183C33810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183C33140-0x0000000183C33190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C340A0-0x0000000183C340F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C340F0-0x0000000183C34140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183C33230-0x0000000183C332D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183C33370-0x0000000183C33440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AISnapshotEntitySkillCycle other) => default; // 0x0000000183C33440-0x0000000183C335C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183C339A0-0x0000000183C33B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183C344C0-0x0000000183C34870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183C341A0-0x0000000183C34380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183C335C0-0x0000000183C336F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AISnapshotEntitySkillCycle other) {} // 0x0000000183C32EF0-0x0000000183C330A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183C32BF0-0x0000000183C32D50
}

