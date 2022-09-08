/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeCoopRewardReq : MessageBase, IMessage<TakeCoopRewardReq> // TypeDefIndex: 22738
{
	// Fields
	private static readonly MessageParser<TakeCoopRewardReq> _parser; // 0x00
	public const int RewardConfigIdFieldNumber = 1; // Metadata: 0x00B0242B
	private uint rewardConfigId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeCoopRewardReq> Parser { get => default; } // 0x00000001834F1730-0x00000001834F17C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001834F14C0-0x00000001834F1550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001834F11D0-0x00000001834F1250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001834F0CE0-0x00000001834F0D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001834F1BC0-0x00000001834F1CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001834F1A30-0x00000001834F1A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001834F1550-0x00000001834F1640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001834F1B70-0x00000001834F1BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001834F12F0-0x00000001834F13E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RewardConfigId { get => default; set {} } // 0x00000001834F1990-0x00000001834F1A30 0x00000001834F18F0-0x00000001834F1990

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22739
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22740
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1968
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeCoopRewardReq() {} // 0x00000001834F1EE0-0x00000001834F1F40
	static TakeCoopRewardReq() {} // 0x00000001834F1E20-0x00000001834F1EE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeCoopRewardReq Clone() => default; // 0x00000001834F1640-0x00000001834F1730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeCoopRewardReq ShallowCopy() => default; // 0x00000001834F1250-0x00000001834F12F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001834F0E50-0x00000001834F0EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001834F1850-0x00000001834F18A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001834F18A0-0x00000001834F18F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001834F0EA0-0x00000001834F0F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001834F1010-0x00000001834F10E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeCoopRewardReq other) => default; // 0x00000001834F0F10-0x00000001834F1010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001834F13E0-0x00000001834F14C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001834F1CB0-0x00000001834F1E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001834F1A90-0x00000001834F1B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001834F10E0-0x00000001834F11D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeCoopRewardReq other) {} // 0x00000001834F0D40-0x00000001834F0E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001834F0C00-0x00000001834F0CE0
}

