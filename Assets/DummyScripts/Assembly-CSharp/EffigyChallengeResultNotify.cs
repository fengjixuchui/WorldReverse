/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EffigyChallengeResultNotify : MessageBase, IMessage<EffigyChallengeResultNotify> // TypeDefIndex: 22074
{
	// Fields
	private static readonly MessageParser<EffigyChallengeResultNotify> _parser; // 0x00
	public const int ChallengeIdFieldNumber = 1; // Metadata: 0x00B00BBF
	private uint challengeId_; // 0x18
	public const int IsSuccessFieldNumber = 2; // Metadata: 0x00B00BC3
	private bool isSuccess_; // 0x1C
	public const int ChallengeScoreFieldNumber = 3; // Metadata: 0x00B00BC7
	private uint challengeScore_; // 0x20
	public const int ChallengeMaxScoreFieldNumber = 4; // Metadata: 0x00B00BCB
	private uint challengeMaxScore_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EffigyChallengeResultNotify> Parser { get => default; } // 0x0000000183B0A420-0x0000000183B0A4B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183B0A070-0x0000000183B0A100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183B09C60-0x0000000183B09CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183B09540-0x0000000183B095A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183B0AAB0-0x0000000183B0ABA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183B0A7C0-0x0000000183B0A820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183B0A1A0-0x0000000183B0A290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183B0AA60-0x0000000183B0AAB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183B09D80-0x0000000183B09E70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeId { get => default; set {} } // 0x0000000183B09FD0-0x0000000183B0A070 0x0000000183B0A380-0x0000000183B0A420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSuccess { get => default; set {} } // 0x0000000183B0A720-0x0000000183B0A7C0 0x0000000183B095A0-0x0000000183B09640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeScore { get => default; set {} } // 0x0000000183B0A680-0x0000000183B0A720 0x0000000183B0A9C0-0x0000000183B0AA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeMaxScore { get => default; set {} } // 0x0000000183B0A100-0x0000000183B0A1A0 0x0000000183B0A540-0x0000000183B0A5E0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22075
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22076
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2104
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EffigyChallengeResultNotify() {} // 0x0000000183B0AF80-0x0000000183B0AFE0
	static EffigyChallengeResultNotify() {} // 0x0000000183B0AEC0-0x0000000183B0AF80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EffigyChallengeResultNotify Clone() => default; // 0x0000000183B0A290-0x0000000183B0A380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EffigyChallengeResultNotify ShallowCopy() => default; // 0x0000000183B09CE0-0x0000000183B09D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183B097C0-0x0000000183B09810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B0A5E0-0x0000000183B0A630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B0A630-0x0000000183B0A680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183B09810-0x0000000183B098A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183B098A0-0x0000000183B09970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EffigyChallengeResultNotify other) => default; // 0x0000000183B09970-0x0000000183B09AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183B09E70-0x0000000183B09FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183B0ABA0-0x0000000183B0AEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183B0A820-0x0000000183B0A9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183B09AD0-0x0000000183B09C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EffigyChallengeResultNotify other) {} // 0x0000000183B09640-0x0000000183B097C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183B09410-0x0000000183B09540
}

