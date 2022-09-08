/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtFaceToDirInfo : MessageBase, IMessage<EvtFaceToDirInfo> // TypeDefIndex: 23015
{
	// Fields
	private static readonly MessageParser<EvtFaceToDirInfo> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B02F3B
	private uint entityId_; // 0x18
	public const int FaceDirFieldNumber = 2; // Metadata: 0x00B02F3F
	private Vector faceDir_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtFaceToDirInfo> Parser { get => default; } // 0x0000000183EB2C30-0x0000000183EB2CC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183EB2880-0x0000000183EB2910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183EB24F0-0x0000000183EB2570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183EB1DC0-0x0000000183EB1E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183EB30C0-0x0000000183EB31B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183EB2EF0-0x0000000183EB2F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183EB29B0-0x0000000183EB2AA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183EB3070-0x0000000183EB30C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183EB2610-0x0000000183EB2700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000183EB2E50-0x0000000183EB2EF0 0x0000000183EB31B0-0x0000000183EB3250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector FaceDir { get => default; set {} } // 0x0000000183EB2B90-0x0000000183EB2C30 0x0000000183EB2910-0x0000000183EB29B0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtFaceToDirInfo() {} // 0x0000000183EB34F0-0x0000000183EB3550
	static EvtFaceToDirInfo() {} // 0x0000000183EB3430-0x0000000183EB34F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtFaceToDirInfo Clone() => default; // 0x0000000183EB2AA0-0x0000000183EB2B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtFaceToDirInfo ShallowCopy() => default; // 0x0000000183EB2570-0x0000000183EB2610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183EB1FA0-0x0000000183EB2020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183EB2D50-0x0000000183EB2DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183EB2DD0-0x0000000183EB2E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183EB2020-0x0000000183EB2150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183EB2150-0x0000000183EB2220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtFaceToDirInfo other) => default; // 0x0000000183EB2220-0x0000000183EB2350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183EB2700-0x0000000183EB2880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183EB3250-0x0000000183EB3430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183EB2F50-0x0000000183EB3070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183EB2350-0x0000000183EB24F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtFaceToDirInfo other) {} // 0x0000000183EB1E20-0x0000000183EB1FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183EB1C80-0x0000000183EB1DC0
}

