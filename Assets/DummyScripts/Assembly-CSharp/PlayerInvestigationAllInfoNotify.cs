/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerInvestigationAllInfoNotify : MessageBase, IMessage<PlayerInvestigationAllInfoNotify> // TypeDefIndex: 23577
{
	// Fields
	private static readonly MessageParser<PlayerInvestigationAllInfoNotify> _parser; // 0x00
	public const int InvestigationListFieldNumber = 1; // Metadata: 0x00B04537
	private static readonly FieldCodec<Investigation> _repeated_investigationList_codec; // 0x08
	private readonly RepeatedMessageField<Investigation> investigationList_; // 0x18
	public const int InvestigationTargetListFieldNumber = 2; // Metadata: 0x00B0453B
	private static readonly FieldCodec<InvestigationTarget> _repeated_investigationTargetList_codec; // 0x10
	private readonly RepeatedMessageField<InvestigationTarget> investigationTargetList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerInvestigationAllInfoNotify> Parser { get => default; } // 0x000000018415F1C0-0x000000018415F250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018415EF50-0x000000018415EFE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018415EBF0-0x000000018415EC70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018415E5A0-0x000000018415E600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018415F660-0x000000018415F750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018415F480-0x000000018415F4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018415EFE0-0x000000018415F0D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018415F610-0x000000018415F660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018415ED10-0x000000018415EE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Investigation> InvestigationList { get => default; } // 0x000000018415EEF0-0x000000018415EF50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<InvestigationTarget> InvestigationTargetList { get => default; } // 0x000000018415F420-0x000000018415F480 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23578
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23579
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1901
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerInvestigationAllInfoNotify() {} // 0x000000018415FA70-0x000000018415FB20
	static PlayerInvestigationAllInfoNotify() {} // 0x000000018415F910-0x000000018415FA70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerInvestigationAllInfoNotify Clone() => default; // 0x000000018415F0D0-0x000000018415F1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerInvestigationAllInfoNotify ShallowCopy() => default; // 0x000000018415EC70-0x000000018415ED10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018415E760-0x000000018415E7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018415F2E0-0x000000018415F380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018415F380-0x000000018415F420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018415E7B0-0x000000018415E8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018415EA00-0x000000018415EAD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerInvestigationAllInfoNotify other) => default; // 0x000000018415E8D0-0x000000018415EA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018415EE00-0x000000018415EEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018415F750-0x000000018415F910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018415F4E0-0x000000018415F610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018415EAD0-0x000000018415EBF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerInvestigationAllInfoNotify other) {} // 0x000000018415E600-0x000000018415E760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018415E400-0x000000018415E5A0
}

