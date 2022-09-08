/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WorldOwnerBlossomBriefInfoNotify : MessageBase, IMessage<WorldOwnerBlossomBriefInfoNotify> // TypeDefIndex: 22602
{
	// Fields
	private static readonly MessageParser<WorldOwnerBlossomBriefInfoNotify> _parser; // 0x00
	public const int BriefInfoListFieldNumber = 1; // Metadata: 0x00B01F7B
	private static readonly FieldCodec<BlossomBriefInfo> _repeated_briefInfoList_codec; // 0x08
	private readonly RepeatedMessageField<BlossomBriefInfo> briefInfoList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WorldOwnerBlossomBriefInfoNotify> Parser { get => default; } // 0x0000000182903970-0x0000000182903A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182903700-0x0000000182903790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182903430-0x00000001829034B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182902EB0-0x0000000182902F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182903D60-0x0000000182903E50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182903BB0-0x0000000182903C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182903790-0x0000000182903880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182903D10-0x0000000182903D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182903550-0x0000000182903640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<BlossomBriefInfo> BriefInfoList { get => default; } // 0x0000000182902E50-0x0000000182902EB0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22603
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22604
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2704
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldOwnerBlossomBriefInfoNotify() {} // 0x00000001829040B0-0x0000000182904140
	static WorldOwnerBlossomBriefInfoNotify() {} // 0x0000000182903FA0-0x00000001829040B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldOwnerBlossomBriefInfoNotify Clone() => default; // 0x0000000182903880-0x0000000182903970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldOwnerBlossomBriefInfoNotify ShallowCopy() => default; // 0x00000001829034B0-0x0000000182903550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182903040-0x0000000182903090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182903A90-0x0000000182903B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182903B20-0x0000000182903BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182903090-0x0000000182903160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182903270-0x0000000182903340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WorldOwnerBlossomBriefInfoNotify other) => default; // 0x0000000182903160-0x0000000182903270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182903640-0x0000000182903700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182903E50-0x0000000182903FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182903C10-0x0000000182903D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182903340-0x0000000182903430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WorldOwnerBlossomBriefInfoNotify other) {} // 0x0000000182902F10-0x0000000182903040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182902D20-0x0000000182902E50
}

