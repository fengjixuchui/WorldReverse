/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GadgetCrucibleInfo : MessageBase, IMessage<GadgetCrucibleInfo> // TypeDefIndex: 26033
{
	// Fields
	private static readonly MessageParser<GadgetCrucibleInfo> _parser; // 0x00
	public const int MpPlayIdFieldNumber = 1; // Metadata: 0x00B0AC93
	private uint mpPlayId_; // 0x18
	public const int PrepareEndTimeFieldNumber = 2; // Metadata: 0x00B0AC97
	private uint prepareEndTime_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GadgetCrucibleInfo> Parser { get => default; } // 0x0000000183FC29C0-0x0000000183FC2A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183FC2750-0x0000000183FC27E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183FC2300-0x0000000183FC2380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183FC1C50-0x0000000183FC1CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183FC2D50-0x0000000183FC2E40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183FC2B80-0x0000000183FC2BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183FC27E0-0x0000000183FC28D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183FC2D00-0x0000000183FC2D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183FC2420-0x0000000183FC2510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MpPlayId { get => default; set {} } // 0x0000000183FC2610-0x0000000183FC26B0 0x0000000183FC1EA0-0x0000000183FC1F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PrepareEndTime { get => default; set {} } // 0x0000000183FC1F40-0x0000000183FC1FE0 0x0000000183FC26B0-0x0000000183FC2750

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetCrucibleInfo() {} // 0x0000000183FC3100-0x0000000183FC3160
	static GadgetCrucibleInfo() {} // 0x0000000183FC3040-0x0000000183FC3100

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetCrucibleInfo Clone() => default; // 0x0000000183FC28D0-0x0000000183FC29C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetCrucibleInfo ShallowCopy() => default; // 0x0000000183FC2380-0x0000000183FC2420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183FC1DE0-0x0000000183FC1E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FC2AE0-0x0000000183FC2B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FC2B30-0x0000000183FC2B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183FC1E30-0x0000000183FC1EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183FC2100-0x0000000183FC21D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GadgetCrucibleInfo other) => default; // 0x0000000183FC1FE0-0x0000000183FC2100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183FC2510-0x0000000183FC2610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183FC2E40-0x0000000183FC3040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183FC2BE0-0x0000000183FC2D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183FC21D0-0x0000000183FC2300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GadgetCrucibleInfo other) {} // 0x0000000183FC1CB0-0x0000000183FC1DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183FC1B50-0x0000000183FC1C50
}

