/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SeaLampTakeContributionRewardReq : MessageBase, IMessage<SeaLampTakeContributionRewardReq> // TypeDefIndex: 21899
{
	// Fields
	private static readonly MessageParser<SeaLampTakeContributionRewardReq> _parser; // 0x00
	public const int ActivityIdFieldNumber = 2; // Metadata: 0x00B004D7
	private uint activityId_; // 0x18
	public const int ConfigIdFieldNumber = 1; // Metadata: 0x00B004DB
	private uint configId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SeaLampTakeContributionRewardReq> Parser { get => default; } // 0x0000000182C81C80-0x0000000182C81D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182C81970-0x0000000182C81A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182C81660-0x0000000182C816E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182C80FB0-0x0000000182C81010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182C820B0-0x0000000182C821A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182C81EE0-0x0000000182C81F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182C81AA0-0x0000000182C81B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182C82060-0x0000000182C820B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182C81780-0x0000000182C81870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActivityId { get => default; set {} } // 0x0000000182C81E40-0x0000000182C81EE0 0x0000000182C810B0-0x0000000182C81150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ConfigId { get => default; set {} } // 0x0000000182C81A00-0x0000000182C81AA0 0x0000000182C81010-0x0000000182C810B0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21900
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21901
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2016
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampTakeContributionRewardReq() {} // 0x0000000182C82460-0x0000000182C824C0
	static SeaLampTakeContributionRewardReq() {} // 0x0000000182C823A0-0x0000000182C82460

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampTakeContributionRewardReq Clone() => default; // 0x0000000182C81B90-0x0000000182C81C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampTakeContributionRewardReq ShallowCopy() => default; // 0x0000000182C816E0-0x0000000182C81780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182C81280-0x0000000182C812D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C81DA0-0x0000000182C81DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C81DF0-0x0000000182C81E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182C812D0-0x0000000182C81340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182C81340-0x0000000182C81410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SeaLampTakeContributionRewardReq other) => default; // 0x0000000182C81410-0x0000000182C81530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182C81870-0x0000000182C81970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182C821A0-0x0000000182C823A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182C81F40-0x0000000182C82060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182C81530-0x0000000182C81660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SeaLampTakeContributionRewardReq other) {} // 0x0000000182C81150-0x0000000182C81280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182C80EB0-0x0000000182C80FB0
}

