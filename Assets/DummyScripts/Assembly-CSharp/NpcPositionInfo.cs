/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class NpcPositionInfo : MessageBase, IMessage<NpcPositionInfo> // TypeDefIndex: 26075
{
	// Fields
	private static readonly MessageParser<NpcPositionInfo> _parser; // 0x00
	public const int NpcIdFieldNumber = 1; // Metadata: 0x00B0B057
	private uint npcId_; // 0x18
	public const int PosFieldNumber = 2; // Metadata: 0x00B0B05B
	private Vector pos_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<NpcPositionInfo> Parser { get => default; } // 0x000000018484E860-0x000000018484E8F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018484E550-0x000000018484E5E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018484E120-0x000000018484E1A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018484D9F0-0x000000018484DA50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018484ED90-0x000000018484EE80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018484EB20-0x000000018484EB80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018484E680-0x000000018484E770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018484ED40-0x000000018484ED90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018484E2E0-0x000000018484E3D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NpcId { get => default; set {} } // 0x000000018484E5E0-0x000000018484E680 0x000000018484E1A0-0x000000018484E240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x000000018484EA80-0x000000018484EB20 0x000000018484ECA0-0x000000018484ED40

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public NpcPositionInfo() {} // 0x000000018484F120-0x000000018484F180
	static NpcPositionInfo() {} // 0x000000018484F060-0x000000018484F120

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public NpcPositionInfo Clone() => default; // 0x000000018484E770-0x000000018484E860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public NpcPositionInfo ShallowCopy() => default; // 0x000000018484E240-0x000000018484E2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018484DBD0-0x000000018484DC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018484E980-0x000000018484EA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018484EA00-0x000000018484EA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018484DC50-0x000000018484DD80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018484DEB0-0x000000018484DF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(NpcPositionInfo other) => default; // 0x000000018484DD80-0x000000018484DEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018484E3D0-0x000000018484E550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018484EE80-0x000000018484F060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018484EB80-0x000000018484ECA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018484DF80-0x000000018484E120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(NpcPositionInfo other) {} // 0x000000018484DA50-0x000000018484DBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018484D8B0-0x000000018484D9F0
}

