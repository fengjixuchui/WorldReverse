/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerGeneralMatchConfirmNotify : MessageBase, IMessage<PlayerGeneralMatchConfirmNotify> // TypeDefIndex: 23867
{
	// Fields
	private static readonly MessageParser<PlayerGeneralMatchConfirmNotify> _parser; // 0x00
	public const int MatchIdFieldNumber = 1; // Metadata: 0x00B0504B
	private uint matchId_; // 0x18
	public const int UidFieldNumber = 2; // Metadata: 0x00B0504F
	private uint uid_; // 0x1C
	public const int IsAgreeFieldNumber = 3; // Metadata: 0x00B05053
	private bool isAgree_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerGeneralMatchConfirmNotify> Parser { get => default; } // 0x00000001834E2690-0x00000001834E2720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001834E22E0-0x00000001834E2370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001834E1FA0-0x00000001834E2020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001834E17D0-0x00000001834E1830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001834E2B00-0x00000001834E2BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001834E28F0-0x00000001834E2950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001834E2410-0x00000001834E2500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001834E2AB0-0x00000001834E2B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001834E20C0-0x00000001834E21B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MatchId { get => default; set {} } // 0x00000001834E1B00-0x00000001834E1BA0 0x00000001834E1830-0x00000001834E18D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x00000001834E1F00-0x00000001834E1FA0 0x00000001834E2370-0x00000001834E2410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAgree { get => default; set {} } // 0x00000001834E25F0-0x00000001834E2690 0x00000001834E2720-0x00000001834E27C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23868
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23869
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4164
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerGeneralMatchConfirmNotify() {} // 0x00000001834E2F40-0x00000001834E2FA0
	static PlayerGeneralMatchConfirmNotify() {} // 0x00000001834E2E80-0x00000001834E2F40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerGeneralMatchConfirmNotify Clone() => default; // 0x00000001834E2500-0x00000001834E25F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerGeneralMatchConfirmNotify ShallowCopy() => default; // 0x00000001834E2020-0x00000001834E20C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001834E1A30-0x00000001834E1A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001834E2850-0x00000001834E28A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001834E28A0-0x00000001834E28F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001834E1A80-0x00000001834E1B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001834E1BA0-0x00000001834E1C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerGeneralMatchConfirmNotify other) => default; // 0x00000001834E1C70-0x00000001834E1DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001834E21B0-0x00000001834E22E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001834E2BF0-0x00000001834E2E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001834E2950-0x00000001834E2AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001834E1DB0-0x00000001834E1F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerGeneralMatchConfirmNotify other) {} // 0x00000001834E18D0-0x00000001834E1A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001834E16C0-0x00000001834E17D0
}

