/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReunionBriefInfoRsp : MessageBase, IMessage<ReunionBriefInfoRsp> // TypeDefIndex: 24810
{
	// Fields
	private static readonly MessageParser<ReunionBriefInfoRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B074C7
	private int retcode_; // 0x18
	public const int IsActivateFieldNumber = 2; // Metadata: 0x00B074CB
	private bool isActivate_; // 0x1C
	public const int ReunionBriefInfoFieldNumber = 3; // Metadata: 0x00B074CF
	private ReunionBriefInfo reunionBriefInfo_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ReunionBriefInfoRsp> Parser { get => default; } // 0x0000000181BEFE40-0x0000000181BEFED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181BEFB30-0x0000000181BEFBC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181BEF770-0x0000000181BEF7F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181BEEDF0-0x0000000181BEEE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181BF03B0-0x0000000181BF04A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181BF0060-0x0000000181BF00C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181BEFC60-0x0000000181BEFD50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181BF0360-0x0000000181BF03B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181BEF890-0x0000000181BEF980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181BEF6D0-0x0000000181BEF770 0x0000000181BEF260-0x0000000181BEF300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsActivate { get => default; set {} } // 0x0000000181BF00C0-0x0000000181BF0160 0x0000000181BEF1C0-0x0000000181BEF260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionBriefInfo ReunionBriefInfo { get => default; set {} } // 0x0000000181BF0160-0x0000000181BF0200 0x0000000181BEFBC0-0x0000000181BEFC60

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24811
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24812
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5052
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionBriefInfoRsp() {} // 0x0000000181BF07D0-0x0000000181BF0830
	static ReunionBriefInfoRsp() {} // 0x0000000181BF0710-0x0000000181BF07D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionBriefInfoRsp Clone() => default; // 0x0000000181BEFD50-0x0000000181BEFE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionBriefInfoRsp ShallowCopy() => default; // 0x0000000181BEF7F0-0x0000000181BEF890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181BEF000-0x0000000181BEF080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181BEFF60-0x0000000181BEFFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181BEFFE0-0x0000000181BF0060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181BEF080-0x0000000181BEF1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181BEF450-0x0000000181BEF520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ReunionBriefInfoRsp other) => default; // 0x0000000181BEF300-0x0000000181BEF450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181BEF980-0x0000000181BEFB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181BF04A0-0x0000000181BF0710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181BF0200-0x0000000181BF0360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181BEF520-0x0000000181BEF6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ReunionBriefInfoRsp other) {} // 0x0000000181BEEE50-0x0000000181BEF000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181BEEC90-0x0000000181BEEDF0
}

