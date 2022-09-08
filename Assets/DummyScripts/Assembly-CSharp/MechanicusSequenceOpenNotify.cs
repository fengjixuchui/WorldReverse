/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MechanicusSequenceOpenNotify : MessageBase, IMessage<MechanicusSequenceOpenNotify> // TypeDefIndex: 23883
{
	// Fields
	private static readonly MessageParser<MechanicusSequenceOpenNotify> _parser; // 0x00
	public const int MechanicusIdFieldNumber = 1; // Metadata: 0x00B050DF
	private uint mechanicusId_; // 0x18
	public const int SequenceIdFieldNumber = 2; // Metadata: 0x00B050E3
	private uint sequenceId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MechanicusSequenceOpenNotify> Parser { get => default; } // 0x0000000183A84020-0x0000000183A840B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183A83D10-0x0000000183A83DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183A83A00-0x0000000183A83A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183A83350-0x0000000183A833B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183A84450-0x0000000183A84540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183A841E0-0x0000000183A84240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183A83E40-0x0000000183A83F30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183A84360-0x0000000183A843B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183A83B20-0x0000000183A83C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MechanicusId { get => default; set {} } // 0x0000000183A83DA0-0x0000000183A83E40 0x0000000183A835A0-0x0000000183A83640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SequenceId { get => default; set {} } // 0x0000000183A843B0-0x0000000183A84450 0x0000000183A83830-0x0000000183A838D0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23884
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23885
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3903
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusSequenceOpenNotify() {} // 0x0000000183A84800-0x0000000183A84860
	static MechanicusSequenceOpenNotify() {} // 0x0000000183A84740-0x0000000183A84800

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusSequenceOpenNotify Clone() => default; // 0x0000000183A83F30-0x0000000183A84020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusSequenceOpenNotify ShallowCopy() => default; // 0x0000000183A83A80-0x0000000183A83B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183A834E0-0x0000000183A83530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A84140-0x0000000183A84190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A84190-0x0000000183A841E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183A83530-0x0000000183A835A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183A83640-0x0000000183A83710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MechanicusSequenceOpenNotify other) => default; // 0x0000000183A83710-0x0000000183A83830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183A83C10-0x0000000183A83D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183A84540-0x0000000183A84740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183A84240-0x0000000183A84360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183A838D0-0x0000000183A83A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MechanicusSequenceOpenNotify other) {} // 0x0000000183A833B0-0x0000000183A834E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183A83250-0x0000000183A83350
}

