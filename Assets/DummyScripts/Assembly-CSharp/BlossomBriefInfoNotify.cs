/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BlossomBriefInfoNotify : MessageBase, IMessage<BlossomBriefInfoNotify> // TypeDefIndex: 22599
{
	// Fields
	private static readonly MessageParser<BlossomBriefInfoNotify> _parser; // 0x00
	public const int BriefInfoListFieldNumber = 1; // Metadata: 0x00B01F63
	private static readonly FieldCodec<BlossomBriefInfo> _repeated_briefInfoList_codec; // 0x08
	private readonly RepeatedMessageField<BlossomBriefInfo> briefInfoList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BlossomBriefInfoNotify> Parser { get => default; } // 0x00000001849ED860-0x00000001849ED8F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001849ED5F0-0x00000001849ED680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001849ED320-0x00000001849ED3A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001849ECDA0-0x00000001849ECE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001849EDC50-0x00000001849EDD40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001849EDAA0-0x00000001849EDB00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001849ED680-0x00000001849ED770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001849EDC00-0x00000001849EDC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001849ED440-0x00000001849ED530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<BlossomBriefInfo> BriefInfoList { get => default; } // 0x00000001849ECD40-0x00000001849ECDA0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22600
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22601
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2703
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlossomBriefInfoNotify() {} // 0x00000001849EDFA0-0x00000001849EE030
	static BlossomBriefInfoNotify() {} // 0x00000001849EDE90-0x00000001849EDFA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlossomBriefInfoNotify Clone() => default; // 0x00000001849ED770-0x00000001849ED860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlossomBriefInfoNotify ShallowCopy() => default; // 0x00000001849ED3A0-0x00000001849ED440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001849ECF30-0x00000001849ECF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849ED980-0x00000001849EDA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849EDA10-0x00000001849EDAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001849ECF80-0x00000001849ED050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001849ED160-0x00000001849ED230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BlossomBriefInfoNotify other) => default; // 0x00000001849ED050-0x00000001849ED160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001849ED530-0x00000001849ED5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001849EDD40-0x00000001849EDE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001849EDB00-0x00000001849EDC00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001849ED230-0x00000001849ED320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BlossomBriefInfoNotify other) {} // 0x00000001849ECE00-0x00000001849ECF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001849ECC10-0x00000001849ECD40
}

