/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HuntingRevealFinalNotify : MessageBase, IMessage<HuntingRevealFinalNotify> // TypeDefIndex: 23553
{
	// Fields
	private static readonly MessageParser<HuntingRevealFinalNotify> _parser; // 0x00
	public const int HuntingPairFieldNumber = 1; // Metadata: 0x00B0445B
	private HuntingPair huntingPair_; // 0x18
	public const int FinishedGroupIdFieldNumber = 2; // Metadata: 0x00B0445F
	private uint finishedGroupId_; // 0x20
	public const int FinalPositionFieldNumber = 3; // Metadata: 0x00B04463
	private Vector finalPosition_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HuntingRevealFinalNotify> Parser { get => default; } // 0x0000000183EAA140-0x0000000183EAA1D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183EA9E30-0x0000000183EA9EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183EA9950-0x0000000183EA99D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183EA8F50-0x0000000183EA8FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183EAA6C0-0x0000000183EAA7B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183EAA420-0x0000000183EAA480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183EA9F60-0x0000000183EAA050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183EAA670-0x0000000183EAA6C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183EA9A70-0x0000000183EA9B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingPair HuntingPair { get => default; set {} } // 0x0000000183EA91B0-0x0000000183EA9250 0x0000000183EA8D20-0x0000000183EA8DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FinishedGroupId { get => default; set {} } // 0x0000000183EAA5D0-0x0000000183EAA670 0x0000000183EA9D90-0x0000000183EA9E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector FinalPosition { get => default; set {} } // 0x0000000183EA9EC0-0x0000000183EA9F60 0x0000000183EAA380-0x0000000183EAA420

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23554
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23555
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4309
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingRevealFinalNotify() {} // 0x0000000183EAAAD0-0x0000000183EAAB30
	static HuntingRevealFinalNotify() {} // 0x0000000183EAAA10-0x0000000183EAAAD0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingRevealFinalNotify Clone() => default; // 0x0000000183EAA050-0x0000000183EAA140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingRevealFinalNotify ShallowCopy() => default; // 0x0000000183EA99D0-0x0000000183EA9A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183EA9250-0x0000000183EA92E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183EAA260-0x0000000183EAA2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183EAA2F0-0x0000000183EAA380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183EA92E0-0x0000000183EA94D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183EA9630-0x0000000183EA9700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HuntingRevealFinalNotify other) => default; // 0x0000000183EA94D0-0x0000000183EA9630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183EA9B60-0x0000000183EA9D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183EAA7B0-0x0000000183EAAA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183EAA480-0x0000000183EAA5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183EA9700-0x0000000183EA9950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HuntingRevealFinalNotify other) {} // 0x0000000183EA8FB0-0x0000000183EA91B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183EA8DC0-0x0000000183EA8F50
}

