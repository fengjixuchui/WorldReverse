/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeOfferingLevelRewardReq : MessageBase, IMessage<TakeOfferingLevelRewardReq> // TypeDefIndex: 24232
{
	// Fields
	private static readonly MessageParser<TakeOfferingLevelRewardReq> _parser; // 0x00
	public const int OfferingIdFieldNumber = 1; // Metadata: 0x00B05E6B
	private uint offeringId_; // 0x18
	public const int LevelFieldNumber = 2; // Metadata: 0x00B05E6F
	private uint level_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeOfferingLevelRewardReq> Parser { get => default; } // 0x0000000182BD6BC0-0x0000000182BD6C50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182BD68B0-0x0000000182BD6940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182BD6500-0x0000000182BD6580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182BD5EF0-0x0000000182BD5F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182BD6F50-0x0000000182BD7040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182BD6D80-0x0000000182BD6DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182BD6940-0x0000000182BD6A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182BD6F00-0x0000000182BD6F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182BD66C0-0x0000000182BD67B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OfferingId { get => default; set {} } // 0x0000000182BD7040-0x0000000182BD70E0 0x0000000182BD6B20-0x0000000182BD6BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x0000000182BD6080-0x0000000182BD6120 0x0000000182BD6620-0x0000000182BD66C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24233
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24234
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2904
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeOfferingLevelRewardReq() {} // 0x0000000182BD73A0-0x0000000182BD7400
	static TakeOfferingLevelRewardReq() {} // 0x0000000182BD72E0-0x0000000182BD73A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeOfferingLevelRewardReq Clone() => default; // 0x0000000182BD6A30-0x0000000182BD6B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeOfferingLevelRewardReq ShallowCopy() => default; // 0x0000000182BD6580-0x0000000182BD6620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182BD6120-0x0000000182BD6170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182BD6CE0-0x0000000182BD6D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182BD6D30-0x0000000182BD6D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182BD6170-0x0000000182BD61E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182BD6300-0x0000000182BD63D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeOfferingLevelRewardReq other) => default; // 0x0000000182BD61E0-0x0000000182BD6300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182BD67B0-0x0000000182BD68B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182BD70E0-0x0000000182BD72E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182BD6DE0-0x0000000182BD6F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182BD63D0-0x0000000182BD6500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeOfferingLevelRewardReq other) {} // 0x0000000182BD5F50-0x0000000182BD6080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182BD5DF0-0x0000000182BD5EF0
}

