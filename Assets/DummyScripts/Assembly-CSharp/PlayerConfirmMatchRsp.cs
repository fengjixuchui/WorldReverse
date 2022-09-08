/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerConfirmMatchRsp : MessageBase, IMessage<PlayerConfirmMatchRsp> // TypeDefIndex: 23851
{
	// Fields
	private static readonly MessageParser<PlayerConfirmMatchRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B04FAF
	private int retcode_; // 0x18
	public const int MatchTypeFieldNumber = 2; // Metadata: 0x00B04FB3
	private MatchType matchType_; // 0x1C
	public const int IsAgreedFieldNumber = 3; // Metadata: 0x00B04FB7
	private bool isAgreed_; // 0x20
	public const int MatchIdFieldNumber = 4; // Metadata: 0x00B04FBB
	private uint matchId_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerConfirmMatchRsp> Parser { get => default; } // 0x0000000182E04C80-0x0000000182E04D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182E04970-0x0000000182E04A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182E045C0-0x0000000182E04640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182E03C20-0x0000000182E03C80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182E051D0-0x0000000182E052C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182E04F80-0x0000000182E04FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182E04A00-0x0000000182E04AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182E05180-0x0000000182E051D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182E046E0-0x0000000182E047D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182E04520-0x0000000182E045C0 0x0000000182E04020-0x0000000182E040C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MatchType MatchType { get => default; set {} } // 0x0000000182E04BE0-0x0000000182E04C80 0x0000000182E04E90-0x0000000182E04F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAgreed { get => default; set {} } // 0x0000000182E03D20-0x0000000182E03DC0 0x0000000182E04D10-0x0000000182E04DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MatchId { get => default; set {} } // 0x0000000182E040C0-0x0000000182E04160 0x0000000182E03C80-0x0000000182E03D20

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23852
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23853
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4159
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerConfirmMatchRsp() {} // 0x0000000182E056A0-0x0000000182E05710
	static PlayerConfirmMatchRsp() {} // 0x0000000182E055E0-0x0000000182E056A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerConfirmMatchRsp Clone() => default; // 0x0000000182E04AF0-0x0000000182E04BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerConfirmMatchRsp ShallowCopy() => default; // 0x0000000182E04640-0x0000000182E046E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182E03F40-0x0000000182E03F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E04E40-0x0000000182E04E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E04F30-0x0000000182E04F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182E03F90-0x0000000182E04020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182E04160-0x0000000182E04230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerConfirmMatchRsp other) => default; // 0x0000000182E04230-0x0000000182E04390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182E047D0-0x0000000182E04970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182E052C0-0x0000000182E055E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182E04FE0-0x0000000182E05180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182E04390-0x0000000182E04520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerConfirmMatchRsp other) {} // 0x0000000182E03DC0-0x0000000182E03F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182E03B00-0x0000000182E03C20
}

