/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtAnimatorStateChangedInfo : MessageBase, IMessage<EvtAnimatorStateChangedInfo> // TypeDefIndex: 23026
{
	// Fields
	private static readonly MessageParser<EvtAnimatorStateChangedInfo> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B02F9F
	private uint entityId_; // 0x18
	public const int ToStateHashFieldNumber = 2; // Metadata: 0x00B02FA3
	private uint toStateHash_; // 0x1C
	public const int NormalizedTimeCompactFieldNumber = 3; // Metadata: 0x00B02FA7
	private uint normalizedTimeCompact_; // 0x20
	public const int FaceAngleCompactFieldNumber = 4; // Metadata: 0x00B02FAB
	private int faceAngleCompact_; // 0x24
	public const int PosFieldNumber = 5; // Metadata: 0x00B02FAF
	private Vector pos_; // 0x28
	public const int FadeDurationFieldNumber = 6; // Metadata: 0x00B02FB3
	private float fadeDuration_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtAnimatorStateChangedInfo> Parser { get => default; } // 0x000000018264F7E0-0x000000018264F870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018264F430-0x000000018264F4C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018264EF20-0x000000018264EFA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018264E500-0x000000018264E560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182650090-0x0000000182650180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018264FD20-0x000000018264FD80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018264F560-0x000000018264F650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182650040-0x0000000182650090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018264F040-0x000000018264F130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x000000018264FC80-0x000000018264FD20 0x0000000182650180-0x0000000182650220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ToStateHash { get => default; set {} } // 0x000000018264F870-0x000000018264F910 0x000000018264E2A0-0x000000018264E340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NormalizedTimeCompact { get => default; set {} } // 0x000000018264FA20-0x000000018264FAC0 0x000000018264F740-0x000000018264F7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int FaceAngleCompact { get => default; set {} } // 0x000000018264F390-0x000000018264F430 0x000000018264FBE0-0x000000018264FC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x000000018264FB40-0x000000018264FBE0 0x000000018264FFA0-0x0000000182650040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float FadeDuration { get => default; set {} } // 0x000000018264E790-0x000000018264E830 0x000000018264F4C0-0x000000018264F560

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtAnimatorStateChangedInfo() {} // 0x0000000182650700-0x0000000182650760
	static EvtAnimatorStateChangedInfo() {} // 0x0000000182650640-0x0000000182650700

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtAnimatorStateChangedInfo Clone() => default; // 0x000000018264F650-0x000000018264F740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtAnimatorStateChangedInfo ShallowCopy() => default; // 0x000000018264EFA0-0x000000018264F040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018264E830-0x000000018264E8B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018264F9A0-0x000000018264FA20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018264FAC0-0x000000018264FB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018264E8B0-0x000000018264EA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018264EBD0-0x000000018264ECA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtAnimatorStateChangedInfo other) => default; // 0x000000018264EA10-0x000000018264EBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018264F130-0x000000018264F390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182650220-0x0000000182650640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018264FD80-0x000000018264FFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018264ECA0-0x000000018264EF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtAnimatorStateChangedInfo other) {} // 0x000000018264E560-0x000000018264E790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018264E340-0x000000018264E500
}

