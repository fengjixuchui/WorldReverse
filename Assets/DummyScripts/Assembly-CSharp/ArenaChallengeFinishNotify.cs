/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ArenaChallengeFinishNotify : MessageBase, IMessage<ArenaChallengeFinishNotify> // TypeDefIndex: 22249
{
	// Fields
	private static readonly MessageParser<ArenaChallengeFinishNotify> _parser; // 0x00
	public const int ArenaChallengeIdFieldNumber = 1; // Metadata: 0x00B01257
	private uint arenaChallengeId_; // 0x18
	public const int ArenaChallengeLevelFieldNumber = 2; // Metadata: 0x00B0125B
	private uint arenaChallengeLevel_; // 0x1C
	public const int IsSuccessFieldNumber = 3; // Metadata: 0x00B0125F
	private bool isSuccess_; // 0x20
	public const int ChildChallengeListFieldNumber = 4; // Metadata: 0x00B01263
	private static readonly FieldCodec<ArenaChallengeChildChallengeInfo> _repeated_childChallengeList_codec; // 0x08
	private readonly RepeatedMessageField<ArenaChallengeChildChallengeInfo> childChallengeList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ArenaChallengeFinishNotify> Parser { get => default; } // 0x0000000184616E40-0x0000000184616ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184616BD0-0x0000000184616C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184616720-0x00000001846167A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184615EA0-0x0000000184615F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184617420-0x0000000184617510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184617120-0x0000000184617180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184616C60-0x0000000184616D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001846173D0-0x0000000184617420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001846168E0-0x00000001846169D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ArenaChallengeId { get => default; set {} } // 0x00000001846162A0-0x0000000184616340 0x0000000184616B30-0x0000000184616BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ArenaChallengeLevel { get => default; set {} } // 0x0000000184616840-0x00000001846168E0 0x0000000184617330-0x00000001846173D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSuccess { get => default; set {} } // 0x0000000184617080-0x0000000184617120 0x0000000184615F00-0x0000000184615FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ArenaChallengeChildChallengeInfo> ChildChallengeList { get => default; } // 0x0000000184615E40-0x0000000184615EA0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22250
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22251
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2197
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ArenaChallengeFinishNotify() {} // 0x0000000184617920-0x00000001846179B0
	static ArenaChallengeFinishNotify() {} // 0x0000000184617810-0x0000000184617920

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ArenaChallengeFinishNotify Clone() => default; // 0x0000000184616D50-0x0000000184616E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ArenaChallengeFinishNotify ShallowCopy() => default; // 0x00000001846167A0-0x0000000184616840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184616150-0x00000001846161A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184616F60-0x0000000184616FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184616FF0-0x0000000184617080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001846161A0-0x00000001846162A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001846164B0-0x0000000184616580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ArenaChallengeFinishNotify other) => default; // 0x0000000184616340-0x00000001846164B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001846169D0-0x0000000184616B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184617510-0x0000000184617810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184617180-0x0000000184617330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184616580-0x0000000184616720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ArenaChallengeFinishNotify other) {} // 0x0000000184615FA0-0x0000000184616150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184615CA0-0x0000000184615E40
}

