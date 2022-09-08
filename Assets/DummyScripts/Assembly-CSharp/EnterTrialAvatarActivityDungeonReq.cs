/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EnterTrialAvatarActivityDungeonReq : MessageBase, IMessage<EnterTrialAvatarActivityDungeonReq> // TypeDefIndex: 21968
{
	// Fields
	private static readonly MessageParser<EnterTrialAvatarActivityDungeonReq> _parser; // 0x00
	public const int ActivityIdFieldNumber = 1; // Metadata: 0x00B0077B
	private uint activityId_; // 0x18
	public const int TrialAvatarIndexIdFieldNumber = 2; // Metadata: 0x00B0077F
	private uint trialAvatarIndexId_; // 0x1C
	public const int EnterPointIdFieldNumber = 3; // Metadata: 0x00B00783
	private uint enterPointId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EnterTrialAvatarActivityDungeonReq> Parser { get => default; } // 0x0000000183047460-0x00000001830474F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183047010-0x00000001830470A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183046CD0-0x0000000183046D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183046610-0x0000000183046670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183047970-0x0000000183047A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183047760-0x00000001830477C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183047140-0x0000000183047230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183047920-0x0000000183047970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183046DF0-0x0000000183046EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActivityId { get => default; set {} } // 0x0000000183047620-0x00000001830476C0 0x0000000183046670-0x0000000183046710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TrialAvatarIndexId { get => default; set {} } // 0x00000001830470A0-0x0000000183047140 0x00000001830476C0-0x0000000183047760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EnterPointId { get => default; set {} } // 0x00000001830473C0-0x0000000183047460 0x0000000183047320-0x00000001830473C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21969
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21970
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2041
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterTrialAvatarActivityDungeonReq() {} // 0x0000000183047DB0-0x0000000183047E10
	static EnterTrialAvatarActivityDungeonReq() {} // 0x0000000183047CF0-0x0000000183047DB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterTrialAvatarActivityDungeonReq Clone() => default; // 0x0000000183047230-0x0000000183047320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterTrialAvatarActivityDungeonReq ShallowCopy() => default; // 0x0000000183046D50-0x0000000183046DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183046870-0x00000001830468C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183047580-0x00000001830475D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001830475D0-0x0000000183047620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001830468C0-0x0000000183046940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183046940-0x0000000183046A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EnterTrialAvatarActivityDungeonReq other) => default; // 0x0000000183046A10-0x0000000183046B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183046EE0-0x0000000183047010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183047A60-0x0000000183047CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001830477C0-0x0000000183047920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183046B50-0x0000000183046CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EnterTrialAvatarActivityDungeonReq other) {} // 0x0000000183046710-0x0000000183046870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183046500-0x0000000183046610
}

