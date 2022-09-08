/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerApplyEnterMpAfterMatchAgreedNotify : MessageBase, IMessage<PlayerApplyEnterMpAfterMatchAgreedNotify> // TypeDefIndex: 23861
{
	// Fields
	private static readonly MessageParser<PlayerApplyEnterMpAfterMatchAgreedNotify> _parser; // 0x00
	public const int MatchTypeFieldNumber = 1; // Metadata: 0x00B05013
	private MatchType matchType_; // 0x18
	public const int SrcPlayerInfoFieldNumber = 2; // Metadata: 0x00B05017
	private OnlinePlayerInfo srcPlayerInfo_; // 0x20
	public const int MatchserverIdFieldNumber = 3; // Metadata: 0x00B0501B
	private uint matchserverId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerApplyEnterMpAfterMatchAgreedNotify> Parser { get => default; } // 0x000000018541D1F0-0x000000018541D280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018541CE40-0x000000018541CED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018541CA40-0x000000018541CAC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018541C1D0-0x000000018541C230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018541D760-0x000000018541D850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018541D550-0x000000018541D5B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018541CED0-0x000000018541CFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018541D710-0x000000018541D760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018541CB60-0x000000018541CC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MatchType MatchType { get => default; set {} } // 0x000000018541D150-0x000000018541D1F0 0x000000018541D390-0x000000018541D430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OnlinePlayerInfo SrcPlayerInfo { get => default; set {} } // 0x000000018541D850-0x000000018541D8F0 0x000000018541C230-0x000000018541C2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MatchserverId { get => default; set {} } // 0x000000018541D0B0-0x000000018541D150 0x000000018541D4B0-0x000000018541D550

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23862
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23863
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4162
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerApplyEnterMpAfterMatchAgreedNotify() {} // 0x000000018541DC20-0x000000018541DC90
	static PlayerApplyEnterMpAfterMatchAgreedNotify() {} // 0x000000018541DB60-0x000000018541DC20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerApplyEnterMpAfterMatchAgreedNotify Clone() => default; // 0x000000018541CFC0-0x000000018541D0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerApplyEnterMpAfterMatchAgreedNotify ShallowCopy() => default; // 0x000000018541CAC0-0x000000018541CB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018541C480-0x000000018541C500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018541D310-0x000000018541D390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018541D430-0x000000018541D4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018541C500-0x000000018541C640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018541C790-0x000000018541C860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerApplyEnterMpAfterMatchAgreedNotify other) => default; // 0x000000018541C640-0x000000018541C790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018541CC50-0x000000018541CE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018541D8F0-0x000000018541DB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018541D5B0-0x000000018541D710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018541C860-0x000000018541CA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerApplyEnterMpAfterMatchAgreedNotify other) {} // 0x000000018541C2D0-0x000000018541C480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018541C080-0x000000018541C1D0
}

