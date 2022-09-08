/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EffigyChallengeDungeonResultInfo : MessageBase, IMessage<EffigyChallengeDungeonResultInfo> // TypeDefIndex: 22073
{
	// Fields
	private static readonly MessageParser<EffigyChallengeDungeonResultInfo> _parser; // 0x00
	public const int ChallengeIdFieldNumber = 1; // Metadata: 0x00B00BAB
	private uint challengeId_; // 0x18
	public const int IsSuccessFieldNumber = 2; // Metadata: 0x00B00BAF
	private bool isSuccess_; // 0x1C
	public const int ChallengeScoreFieldNumber = 3; // Metadata: 0x00B00BB3
	private uint challengeScore_; // 0x20
	public const int ChallengeMaxScoreFieldNumber = 4; // Metadata: 0x00B00BB7
	private uint challengeMaxScore_; // 0x24
	public const int IsInTimeLimitFieldNumber = 5; // Metadata: 0x00B00BBB
	private bool isInTimeLimit_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EffigyChallengeDungeonResultInfo> Parser { get => default; } // 0x0000000183FC7F60-0x0000000183FC7FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183FC7B10-0x0000000183FC7BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183FC76D0-0x0000000183FC7750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183FC6F50-0x0000000183FC6FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183FC86D0-0x0000000183FC87C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183FC8300-0x0000000183FC8360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183FC7C40-0x0000000183FC7D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183FC85E0-0x0000000183FC8630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183FC77F0-0x0000000183FC78E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeId { get => default; set {} } // 0x0000000183FC7A70-0x0000000183FC7B10 0x0000000183FC7E20-0x0000000183FC7EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSuccess { get => default; set {} } // 0x0000000183FC8260-0x0000000183FC8300 0x0000000183FC6FB0-0x0000000183FC7050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeScore { get => default; set {} } // 0x0000000183FC81C0-0x0000000183FC8260 0x0000000183FC8540-0x0000000183FC85E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeMaxScore { get => default; set {} } // 0x0000000183FC7BA0-0x0000000183FC7C40 0x0000000183FC8080-0x0000000183FC8120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsInTimeLimit { get => default; set {} } // 0x0000000183FC8630-0x0000000183FC86D0 0x0000000183FC7EC0-0x0000000183FC7F60

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EffigyChallengeDungeonResultInfo() {} // 0x0000000183FC8C20-0x0000000183FC8C80
	static EffigyChallengeDungeonResultInfo() {} // 0x0000000183FC8B60-0x0000000183FC8C20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EffigyChallengeDungeonResultInfo Clone() => default; // 0x0000000183FC7D30-0x0000000183FC7E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EffigyChallengeDungeonResultInfo ShallowCopy() => default; // 0x0000000183FC7750-0x0000000183FC77F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183FC7200-0x0000000183FC7250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FC8120-0x0000000183FC8170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FC8170-0x0000000183FC81C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183FC7250-0x0000000183FC72F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183FC7460-0x0000000183FC7530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EffigyChallengeDungeonResultInfo other) => default; // 0x0000000183FC72F0-0x0000000183FC7460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183FC78E0-0x0000000183FC7A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183FC87C0-0x0000000183FC8B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183FC8360-0x0000000183FC8540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183FC7530-0x0000000183FC76D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EffigyChallengeDungeonResultInfo other) {} // 0x0000000183FC7050-0x0000000183FC7200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183FC6E00-0x0000000183FC6F50
}

