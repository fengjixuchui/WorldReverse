/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeReunionSignInRewardReq : MessageBase, IMessage<TakeReunionSignInRewardReq> // TypeDefIndex: 24825
{
	// Fields
	private static readonly MessageParser<TakeReunionSignInRewardReq> _parser; // 0x00
	public const int ConfigIdFieldNumber = 1; // Metadata: 0x00B0753F
	private uint configId_; // 0x18
	public const int RewardDayFieldNumber = 2; // Metadata: 0x00B07543
	private uint rewardDay_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeReunionSignInRewardReq> Parser { get => default; } // 0x0000000181CE76A0-0x0000000181CE7730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181CE72F0-0x0000000181CE7380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181CE6FE0-0x0000000181CE7060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181CE6930-0x0000000181CE6990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181CE7A30-0x0000000181CE7B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181CE7860-0x0000000181CE78C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181CE74C0-0x0000000181CE75B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181CE79E0-0x0000000181CE7A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181CE7100-0x0000000181CE71F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ConfigId { get => default; set {} } // 0x0000000181CE7420-0x0000000181CE74C0 0x0000000181CE6990-0x0000000181CE6A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RewardDay { get => default; set {} } // 0x0000000181CE6C20-0x0000000181CE6CC0 0x0000000181CE7380-0x0000000181CE7420

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24826
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24827
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 5057
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeReunionSignInRewardReq() {} // 0x0000000181CE7DE0-0x0000000181CE7F00
	static TakeReunionSignInRewardReq() {} // 0x0000000181CE7D20-0x0000000181CE7DE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeReunionSignInRewardReq Clone() => default; // 0x0000000181CE75B0-0x0000000181CE76A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeReunionSignInRewardReq ShallowCopy() => default; // 0x0000000181CE7060-0x0000000181CE7100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181CE6B60-0x0000000181CE6BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181CE77C0-0x0000000181CE7810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181CE7810-0x0000000181CE7860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181CE6BB0-0x0000000181CE6C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181CE6DE0-0x0000000181CE6EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeReunionSignInRewardReq other) => default; // 0x0000000181CE6CC0-0x0000000181CE6DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181CE71F0-0x0000000181CE72F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181CE7B20-0x0000000181CE7D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181CE78C0-0x0000000181CE79E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181CE6EB0-0x0000000181CE6FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeReunionSignInRewardReq other) {} // 0x0000000181CE6A30-0x0000000181CE6B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181CE6830-0x0000000181CE6930
}

