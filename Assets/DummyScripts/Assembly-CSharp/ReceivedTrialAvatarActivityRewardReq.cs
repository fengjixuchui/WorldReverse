/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReceivedTrialAvatarActivityRewardReq : MessageBase, IMessage<ReceivedTrialAvatarActivityRewardReq> // TypeDefIndex: 21974
{
	// Fields
	private static readonly MessageParser<ReceivedTrialAvatarActivityRewardReq> _parser; // 0x00
	public const int TrialAvatarIndexIdFieldNumber = 1; // Metadata: 0x00B007B7
	private uint trialAvatarIndexId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ReceivedTrialAvatarActivityRewardReq> Parser { get => default; } // 0x000000018136A0D0-0x000000018136A160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181369DC0-0x0000000181369E50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181369AD0-0x0000000181369B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001813695E0-0x0000000181369640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018136A4C0-0x000000018136A5B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018136A330-0x000000018136A390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181369EF0-0x0000000181369FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018136A470-0x000000018136A4C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181369BF0-0x0000000181369CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TrialAvatarIndexId { get => default; set {} } // 0x0000000181369E50-0x0000000181369EF0 0x000000018136A290-0x000000018136A330

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21975
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21976
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2043
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReceivedTrialAvatarActivityRewardReq() {} // 0x000000018136A7E0-0x000000018136A840
	static ReceivedTrialAvatarActivityRewardReq() {} // 0x000000018136A720-0x000000018136A7E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReceivedTrialAvatarActivityRewardReq Clone() => default; // 0x0000000181369FE0-0x000000018136A0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReceivedTrialAvatarActivityRewardReq ShallowCopy() => default; // 0x0000000181369B50-0x0000000181369BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181369750-0x00000001813697A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018136A1F0-0x000000018136A240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018136A240-0x000000018136A290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001813697A0-0x0000000181369810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181369810-0x00000001813698E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ReceivedTrialAvatarActivityRewardReq other) => default; // 0x00000001813698E0-0x00000001813699E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181369CE0-0x0000000181369DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018136A5B0-0x000000018136A720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018136A390-0x000000018136A470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001813699E0-0x0000000181369AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ReceivedTrialAvatarActivityRewardReq other) {} // 0x0000000181369640-0x0000000181369750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181369500-0x00000001813695E0
}

