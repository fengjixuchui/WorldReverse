/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EnterTrialAvatarActivityDungeonRsp : MessageBase, IMessage<EnterTrialAvatarActivityDungeonRsp> // TypeDefIndex: 21971
{
	// Fields
	private static readonly MessageParser<EnterTrialAvatarActivityDungeonRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0079B
	private int retcode_; // 0x18
	public const int ActivityIdFieldNumber = 2; // Metadata: 0x00B0079F
	private uint activityId_; // 0x1C
	public const int TrialAvatarIndexIdFieldNumber = 3; // Metadata: 0x00B007A3
	private uint trialAvatarIndexId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EnterTrialAvatarActivityDungeonRsp> Parser { get => default; } // 0x0000000185421630-0x00000001854216C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185421320-0x00000001854213B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185420FE0-0x0000000185421060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001854207E0-0x0000000185420840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185421B40-0x0000000185421C30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185421930-0x0000000185421990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185421450-0x0000000185421540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185421AF0-0x0000000185421B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185421100-0x00000001854211F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000185420F40-0x0000000185420FE0 0x0000000185420B10-0x0000000185420BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActivityId { get => default; set {} } // 0x00000001854217F0-0x0000000185421890 0x0000000185420840-0x00000001854208E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TrialAvatarIndexId { get => default; set {} } // 0x00000001854213B0-0x0000000185421450 0x0000000185421890-0x0000000185421930

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21972
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21973
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2042
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterTrialAvatarActivityDungeonRsp() {} // 0x0000000185421F80-0x0000000185421FE0
	static EnterTrialAvatarActivityDungeonRsp() {} // 0x0000000185421EC0-0x0000000185421F80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterTrialAvatarActivityDungeonRsp Clone() => default; // 0x0000000185421540-0x0000000185421630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterTrialAvatarActivityDungeonRsp ShallowCopy() => default; // 0x0000000185421060-0x0000000185421100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185420A40-0x0000000185420A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185421750-0x00000001854217A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001854217A0-0x00000001854217F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185420A90-0x0000000185420B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185420BB0-0x0000000185420C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EnterTrialAvatarActivityDungeonRsp other) => default; // 0x0000000185420C80-0x0000000185420DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001854211F0-0x0000000185421320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185421C30-0x0000000185421EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185421990-0x0000000185421AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185420DC0-0x0000000185420F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EnterTrialAvatarActivityDungeonRsp other) {} // 0x00000001854208E0-0x0000000185420A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001854206D0-0x00000001854207E0
}

