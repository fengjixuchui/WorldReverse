/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReunionPrivilegeInfo : MessageBase, IMessage<ReunionPrivilegeInfo> // TypeDefIndex: 24805
{
	// Fields
	private static readonly MessageParser<ReunionPrivilegeInfo> _parser; // 0x00
	public const int PrivilegeIdFieldNumber = 1; // Metadata: 0x00B07487
	private uint privilegeId_; // 0x18
	public const int CurDayCountFieldNumber = 2; // Metadata: 0x00B0748B
	private uint curDayCount_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ReunionPrivilegeInfo> Parser { get => default; } // 0x000000018437EDA0-0x000000018437EE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018437EA90-0x000000018437EB20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018437E6E0-0x000000018437E760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018437E0D0-0x000000018437E130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018437F1D0-0x000000018437F2C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018437EF60-0x000000018437EFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018437EB20-0x000000018437EC10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018437F180-0x000000018437F1D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018437E8A0-0x000000018437E990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PrivilegeId { get => default; set {} } // 0x000000018437E130-0x000000018437E1D0 0x000000018437E760-0x000000018437E800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurDayCount { get => default; set {} } // 0x000000018437ED00-0x000000018437EDA0 0x000000018437EFC0-0x000000018437F060

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionPrivilegeInfo() {} // 0x000000018437F580-0x000000018437F5E0
	static ReunionPrivilegeInfo() {} // 0x000000018437F4C0-0x000000018437F580

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionPrivilegeInfo Clone() => default; // 0x000000018437EC10-0x000000018437ED00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionPrivilegeInfo ShallowCopy() => default; // 0x000000018437E800-0x000000018437E8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018437E300-0x000000018437E350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018437EEC0-0x000000018437EF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018437EF10-0x000000018437EF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018437E350-0x000000018437E3C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018437E3C0-0x000000018437E490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ReunionPrivilegeInfo other) => default; // 0x000000018437E490-0x000000018437E5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018437E990-0x000000018437EA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018437F2C0-0x000000018437F4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018437F060-0x000000018437F180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018437E5B0-0x000000018437E6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ReunionPrivilegeInfo other) {} // 0x000000018437E1D0-0x000000018437E300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018437DFD0-0x000000018437E0D0
}

