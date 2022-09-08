/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MistTrialGetChallengeMissionRsp : MessageBase, IMessage<MistTrialGetChallengeMissionRsp> // TypeDefIndex: 22344
{
	// Fields
	private static readonly MessageParser<MistTrialGetChallengeMissionRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B01607
	private int retcode_; // 0x18
	public const int TrialIdFieldNumber = 2; // Metadata: 0x00B0160B
	private uint trialId_; // 0x1C
	public const int MissionInfoListFieldNumber = 3; // Metadata: 0x00B0160F
	private static readonly FieldCodec<MistTrialMissionInfo> _repeated_missionInfoList_codec; // 0x08
	private readonly RepeatedMessageField<MistTrialMissionInfo> missionInfoList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MistTrialGetChallengeMissionRsp> Parser { get => default; } // 0x00000001839C0BF0-0x00000001839C0C80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001839C08E0-0x00000001839C0970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001839C05A0-0x00000001839C0620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001839BFC80-0x00000001839BFCE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001839C1050-0x00000001839C1140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001839C0E30-0x00000001839C0E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001839C0970-0x00000001839C0A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001839C1000-0x00000001839C1050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001839C06C0-0x00000001839C07B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001839C0460-0x00000001839C0500 0x00000001839BFFB0-0x00000001839C0050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TrialId { get => default; set {} } // 0x00000001839C0B50-0x00000001839C0BF0 0x00000001839C0500-0x00000001839C05A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<MistTrialMissionInfo> MissionInfoList { get => default; } // 0x00000001839C0400-0x00000001839C0460 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22345
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22346
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 8024
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MistTrialGetChallengeMissionRsp() {} // 0x00000001839C14C0-0x00000001839C1550
	static MistTrialGetChallengeMissionRsp() {} // 0x00000001839C13B0-0x00000001839C14C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MistTrialGetChallengeMissionRsp Clone() => default; // 0x00000001839C0A60-0x00000001839C0B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MistTrialGetChallengeMissionRsp ShallowCopy() => default; // 0x00000001839C0620-0x00000001839C06C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001839BFE70-0x00000001839BFEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001839C0D10-0x00000001839C0DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001839C0DA0-0x00000001839C0E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001839BFEC0-0x00000001839BFFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001839C0050-0x00000001839C0120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MistTrialGetChallengeMissionRsp other) => default; // 0x00000001839C0120-0x00000001839C0270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001839C07B0-0x00000001839C08E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001839C1140-0x00000001839C13B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001839C0E90-0x00000001839C1000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001839C0270-0x00000001839C0400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MistTrialGetChallengeMissionRsp other) {} // 0x00000001839BFCE0-0x00000001839BFE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001839BFB00-0x00000001839BFC80
}

