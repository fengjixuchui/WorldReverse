/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MassivePropSyncInfo : MessageBase, IMessage<MassivePropSyncInfo> // TypeDefIndex: 26000
{
	// Fields
	private static readonly MessageParser<MassivePropSyncInfo> _parser; // 0x00
	public const int IdFieldNumber = 1; // Metadata: 0x00B0A9F7
	private long id_; // 0x18
	public const int PropMapFieldNumber = 2; // Metadata: 0x00B0A9FB
	private static readonly MapField<int, MassivePropParam> _map_propMap_codec; // 0x08
	private readonly MapField<int, MassivePropParam> propMap_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MassivePropSyncInfo> Parser { get => default; } // 0x0000000183C5F410-0x0000000183C5F4A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183C5F1A0-0x0000000183C5F230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183C5EE50-0x0000000183C5EED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183C5E7C0-0x0000000183C5E820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183C5F860-0x0000000183C5F950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183C5F670-0x0000000183C5F6D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183C5F230-0x0000000183C5F320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183C5F810-0x0000000183C5F860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183C5EF70-0x0000000183C5F060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public long Id { get => default; set {} } // 0x0000000183C5EDB0-0x0000000183C5EE50 0x0000000183C5F4A0-0x0000000183C5F540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<int, MassivePropParam> PropMap { get => default; } // 0x0000000183C5F950-0x0000000183C5F9B0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassivePropSyncInfo() {} // 0x0000000183C5FD00-0x0000000183C5FD90
	static MassivePropSyncInfo() {} // 0x0000000183C5FBA0-0x0000000183C5FD00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassivePropSyncInfo Clone() => default; // 0x0000000183C5F320-0x0000000183C5F410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassivePropSyncInfo ShallowCopy() => default; // 0x0000000183C5EED0-0x0000000183C5EF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183C5E950-0x0000000183C5E9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C5F5D0-0x0000000183C5F620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C5F620-0x0000000183C5F670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183C5E9A0-0x0000000183C5EA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183C5EA60-0x0000000183C5EB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MassivePropSyncInfo other) => default; // 0x0000000183C5EB30-0x0000000183C5EC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183C5F060-0x0000000183C5F1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183C5F9B0-0x0000000183C5FBA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183C5F6D0-0x0000000183C5F810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183C5EC70-0x0000000183C5EDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MassivePropSyncInfo other) {} // 0x0000000183C5E820-0x0000000183C5E950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183C5E660-0x0000000183C5E7C0
}

