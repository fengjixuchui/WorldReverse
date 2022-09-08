/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AsterMidCampInfoNotify : MessageBase, IMessage<AsterMidCampInfoNotify> // TypeDefIndex: 22042
{
	// Fields
	private static readonly MessageParser<AsterMidCampInfoNotify> _parser; // 0x00
	public const int CampListFieldNumber = 1; // Metadata: 0x00B00A4B
	private static readonly FieldCodec<AsterMidCampInfo> _repeated_campList_codec; // 0x08
	private readonly RepeatedMessageField<AsterMidCampInfo> campList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AsterMidCampInfoNotify> Parser { get => default; } // 0x000000018454ADD0-0x000000018454AE60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018454AB60-0x000000018454ABF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018454A890-0x000000018454A910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018454A310-0x000000018454A370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018454B220-0x000000018454B310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018454B070-0x000000018454B0D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018454ABF0-0x000000018454ACE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018454B1D0-0x000000018454B220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018454A9B0-0x000000018454AAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AsterMidCampInfo> CampList { get => default; } // 0x000000018454B010-0x000000018454B070 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22043
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22044
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2073
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterMidCampInfoNotify() {} // 0x000000018454B570-0x000000018454B600
	static AsterMidCampInfoNotify() {} // 0x000000018454B460-0x000000018454B570

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterMidCampInfoNotify Clone() => default; // 0x000000018454ACE0-0x000000018454ADD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterMidCampInfoNotify ShallowCopy() => default; // 0x000000018454A910-0x000000018454A9B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018454A4A0-0x000000018454A4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018454AEF0-0x000000018454AF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018454AF80-0x000000018454B010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018454A4F0-0x000000018454A5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018454A6D0-0x000000018454A7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AsterMidCampInfoNotify other) => default; // 0x000000018454A5C0-0x000000018454A6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018454AAA0-0x000000018454AB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018454B310-0x000000018454B460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018454B0D0-0x000000018454B1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018454A7A0-0x000000018454A890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AsterMidCampInfoNotify other) {} // 0x000000018454A370-0x000000018454A4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018454A1E0-0x000000018454A310
}

