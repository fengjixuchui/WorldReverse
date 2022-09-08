/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MassiveWaterInfo : MessageBase, IMessage<MassiveWaterInfo> // TypeDefIndex: 26082
{
	// Fields
	private static readonly MessageParser<MassiveWaterInfo> _parser; // 0x00
	public const int IdFieldNumber = 1; // Metadata: 0x00B0B0EB
	private long id_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MassiveWaterInfo> Parser { get => default; } // 0x0000000183AAE8D0-0x0000000183AAE960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183AAE660-0x0000000183AAE6F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183AAE370-0x0000000183AAE3F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183AADDE0-0x0000000183AADE40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183AAECC0-0x0000000183AAEDB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183AAEB30-0x0000000183AAEB90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183AAE6F0-0x0000000183AAE7E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183AAEC70-0x0000000183AAECC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183AAE490-0x0000000183AAE580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public long Id { get => default; set {} } // 0x0000000183AAE2D0-0x0000000183AAE370 0x0000000183AAE960-0x0000000183AAEA00

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveWaterInfo() {} // 0x0000000183AAEFE0-0x0000000183AAF040
	static MassiveWaterInfo() {} // 0x0000000183AAEF20-0x0000000183AAEFE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveWaterInfo Clone() => default; // 0x0000000183AAE7E0-0x0000000183AAE8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveWaterInfo ShallowCopy() => default; // 0x0000000183AAE3F0-0x0000000183AAE490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183AADF50-0x0000000183AADFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183AAEA90-0x0000000183AAEAE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183AAEAE0-0x0000000183AAEB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183AADFA0-0x0000000183AAE010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183AAE010-0x0000000183AAE0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MassiveWaterInfo other) => default; // 0x0000000183AAE0E0-0x0000000183AAE1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183AAE580-0x0000000183AAE660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183AAEDB0-0x0000000183AAEF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183AAEB90-0x0000000183AAEC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183AAE1E0-0x0000000183AAE2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MassiveWaterInfo other) {} // 0x0000000183AADE40-0x0000000183AADF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183AADD00-0x0000000183AADDE0
}

