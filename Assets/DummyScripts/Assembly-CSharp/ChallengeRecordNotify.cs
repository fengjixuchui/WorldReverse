/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChallengeRecordNotify : MessageBase, IMessage<ChallengeRecordNotify> // TypeDefIndex: 22878
{
	// Fields
	private static readonly MessageParser<ChallengeRecordNotify> _parser; // 0x00
	public const int GroupIdFieldNumber = 1; // Metadata: 0x00B0297B
	private uint groupId_; // 0x18
	public const int ChallengeRecordListFieldNumber = 2; // Metadata: 0x00B0297F
	private static readonly FieldCodec<ChallengeRecord> _repeated_challengeRecordList_codec; // 0x08
	private readonly RepeatedMessageField<ChallengeRecord> challengeRecordList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChallengeRecordNotify> Parser { get => default; } // 0x00000001835D1960-0x00000001835D19F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001835D1650-0x00000001835D16E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001835D1340-0x00000001835D13C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001835D0C10-0x00000001835D0C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001835D1D90-0x00000001835D1E80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001835D1BA0-0x00000001835D1C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001835D16E0-0x00000001835D17D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001835D1D40-0x00000001835D1D90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001835D1460-0x00000001835D1550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GroupId { get => default; set {} } // 0x00000001835D17D0-0x00000001835D1870 0x00000001835D12A0-0x00000001835D1340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ChallengeRecord> ChallengeRecordList { get => default; } // 0x00000001835D1240-0x00000001835D12A0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22879
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22880
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 924
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChallengeRecordNotify() {} // 0x00000001835D2170-0x00000001835D2200
	static ChallengeRecordNotify() {} // 0x00000001835D2060-0x00000001835D2170

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChallengeRecordNotify Clone() => default; // 0x00000001835D1870-0x00000001835D1960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChallengeRecordNotify ShallowCopy() => default; // 0x00000001835D13C0-0x00000001835D1460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001835D0DD0-0x00000001835D0E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835D1A80-0x00000001835D1B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835D1B10-0x00000001835D1BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001835D0E20-0x00000001835D0F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001835D1030-0x00000001835D1100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChallengeRecordNotify other) => default; // 0x00000001835D0F00-0x00000001835D1030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001835D1550-0x00000001835D1650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001835D1E80-0x00000001835D2060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001835D1C00-0x00000001835D1D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001835D1100-0x00000001835D1240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChallengeRecordNotify other) {} // 0x00000001835D0C70-0x00000001835D0DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001835D0AB0-0x00000001835D0C10
}

