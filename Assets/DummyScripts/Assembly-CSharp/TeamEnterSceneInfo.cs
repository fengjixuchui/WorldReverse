/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TeamEnterSceneInfo : MessageBase, IMessage<TeamEnterSceneInfo> // TypeDefIndex: 25101
{
	// Fields
	private static readonly MessageParser<TeamEnterSceneInfo> _parser; // 0x00
	public const int TeamEntityIdFieldNumber = 1; // Metadata: 0x00B07FDF
	private uint teamEntityId_; // 0x18
	public const int TeamAbilityInfoFieldNumber = 2; // Metadata: 0x00B07FE3
	private AbilitySyncStateInfo teamAbilityInfo_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TeamEnterSceneInfo> Parser { get => default; } // 0x0000000184BCBB60-0x0000000184BCBBF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184BCB850-0x0000000184BCB8E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184BCB4C0-0x0000000184BCB540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184BCACF0-0x0000000184BCAD50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184BCBFF0-0x0000000184BCC0E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184BCBD80-0x0000000184BCBDE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184BCB8E0-0x0000000184BCB9D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184BCBFA0-0x0000000184BCBFF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184BCB5E0-0x0000000184BCB6D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TeamEntityId { get => default; set {} } // 0x0000000184BCC0E0-0x0000000184BCC180 0x0000000184BCAD50-0x0000000184BCADF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilitySyncStateInfo TeamAbilityInfo { get => default; set {} } // 0x0000000184BCBF00-0x0000000184BCBFA0 0x0000000184BCBAC0-0x0000000184BCBB60

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TeamEnterSceneInfo() {} // 0x0000000184BCC420-0x0000000184BCC480
	static TeamEnterSceneInfo() {} // 0x0000000184BCC360-0x0000000184BCC420

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TeamEnterSceneInfo Clone() => default; // 0x0000000184BCB9D0-0x0000000184BCBAC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TeamEnterSceneInfo ShallowCopy() => default; // 0x0000000184BCB540-0x0000000184BCB5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184BCAF70-0x0000000184BCAFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184BCBC80-0x0000000184BCBD00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184BCBD00-0x0000000184BCBD80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184BCAFF0-0x0000000184BCB120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184BCB120-0x0000000184BCB1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TeamEnterSceneInfo other) => default; // 0x0000000184BCB1F0-0x0000000184BCB320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184BCB6D0-0x0000000184BCB850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184BCC180-0x0000000184BCC360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184BCBDE0-0x0000000184BCBF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184BCB320-0x0000000184BCB4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TeamEnterSceneInfo other) {} // 0x0000000184BCADF0-0x0000000184BCAF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184BCABB0-0x0000000184BCACF0
}

