/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TeamEntityInfo : MessageBase, IMessage<TeamEntityInfo> // TypeDefIndex: 23119
{
	// Fields
	private static readonly MessageParser<TeamEntityInfo> _parser; // 0x00
	public const int TeamEntityIdFieldNumber = 1; // Metadata: 0x00B033BB
	private uint teamEntityId_; // 0x18
	public const int AuthorityPeerIdFieldNumber = 2; // Metadata: 0x00B033BF
	private uint authorityPeerId_; // 0x1C
	public const int TeamAbilityInfoFieldNumber = 3; // Metadata: 0x00B033C3
	private AbilitySyncStateInfo teamAbilityInfo_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TeamEntityInfo> Parser { get => default; } // 0x00000001838836F0-0x0000000183883780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183883340-0x00000001838833D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183882F80-0x0000000183883000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183882710-0x0000000183882770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183883C60-0x0000000183883D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001838839B0-0x0000000183883A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001838833D0-0x00000001838834C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183883C10-0x0000000183883C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001838830A0-0x0000000183883190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TeamEntityId { get => default; set {} } // 0x0000000183883D50-0x0000000183883DF0 0x0000000183882770-0x0000000183882810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AuthorityPeerId { get => default; set {} } // 0x0000000183883780-0x0000000183883820 0x00000001838835B0-0x0000000183883650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilitySyncStateInfo TeamAbilityInfo { get => default; set {} } // 0x0000000183883B70-0x0000000183883C10 0x0000000183883650-0x00000001838836F0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TeamEntityInfo() {} // 0x0000000183884120-0x0000000183884180
	static TeamEntityInfo() {} // 0x0000000183884060-0x0000000183884120

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TeamEntityInfo Clone() => default; // 0x00000001838834C0-0x00000001838835B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TeamEntityInfo ShallowCopy() => default; // 0x0000000183883000-0x00000001838830A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001838829C0-0x0000000183882A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001838838B0-0x0000000183883930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183883930-0x00000001838839B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183882A40-0x0000000183882B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183882B80-0x0000000183882C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TeamEntityInfo other) => default; // 0x0000000183882C50-0x0000000183882DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183883190-0x0000000183883340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183883DF0-0x0000000183884060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183883A10-0x0000000183883B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183882DA0-0x0000000183882F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TeamEntityInfo other) {} // 0x0000000183882810-0x00000001838829C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001838825B0-0x0000000183882710
}

