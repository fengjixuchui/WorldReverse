/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HuntingOngoingNotify : MessageBase, IMessage<HuntingOngoingNotify> // TypeDefIndex: 23562
{
	// Fields
	private static readonly MessageParser<HuntingOngoingNotify> _parser; // 0x00
	public const int HuntingPairFieldNumber = 1; // Metadata: 0x00B0449F
	private HuntingPair huntingPair_; // 0x18
	public const int NextPositionFieldNumber = 2; // Metadata: 0x00B044A3
	private Vector nextPosition_; // 0x20
	public const int FailTimeFieldNumber = 3; // Metadata: 0x00B044A7
	private uint failTime_; // 0x28
	public const int IsStartedFieldNumber = 4; // Metadata: 0x00B044AB
	private bool isStarted_; // 0x2C
	public const int FinishClueCountFieldNumber = 5; // Metadata: 0x00B044AF
	private uint finishClueCount_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HuntingOngoingNotify> Parser { get => default; } // 0x0000000183E3DD90-0x0000000183E3DE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183E3D8A0-0x0000000183E3D930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183E3D400-0x0000000183E3D480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183E3C7C0-0x0000000183E3C820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183E3E2F0-0x0000000183E3E3E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183E3E070-0x0000000183E3E0D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183E3DB10-0x0000000183E3DC00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183E3E2A0-0x0000000183E3E2F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183E3D520-0x0000000183E3D610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingPair HuntingPair { get => default; set {} } // 0x0000000183E3CA70-0x0000000183E3CB10 0x0000000183E3C560-0x0000000183E3C600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector NextPosition { get => default; set {} } // 0x0000000183E3D9D0-0x0000000183E3DA70 0x0000000183E3E3E0-0x0000000183E3E480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FailTime { get => default; set {} } // 0x0000000183E3DA70-0x0000000183E3DB10 0x0000000183E3D930-0x0000000183E3D9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsStarted { get => default; set {} } // 0x0000000183E3D360-0x0000000183E3D400 0x0000000183E3CBA0-0x0000000183E3CC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FinishClueCount { get => default; set {} } // 0x0000000183E3DCF0-0x0000000183E3DD90 0x0000000183E3DF40-0x0000000183E3DFE0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23563
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23564
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4312
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingOngoingNotify() {} // 0x0000000183E3E8B0-0x0000000183E3E910
	static HuntingOngoingNotify() {} // 0x0000000183E3E7F0-0x0000000183E3E8B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingOngoingNotify Clone() => default; // 0x0000000183E3DC00-0x0000000183E3DCF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingOngoingNotify ShallowCopy() => default; // 0x0000000183E3D480-0x0000000183E3D520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183E3CB10-0x0000000183E3CBA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E3DEB0-0x0000000183E3DF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E3DFE0-0x0000000183E3E070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183E3CC40-0x0000000183E3CE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183E3CFF0-0x0000000183E3D0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HuntingOngoingNotify other) => default; // 0x0000000183E3CE50-0x0000000183E3CFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183E3D610-0x0000000183E3D8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183E3E480-0x0000000183E3E7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183E3E0D0-0x0000000183E3E2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183E3D0C0-0x0000000183E3D360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HuntingOngoingNotify other) {} // 0x0000000183E3C820-0x0000000183E3CA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183E3C600-0x0000000183E3C7C0
}

