/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AddQuestContentProgressRsp : MessageBase, IMessage<AddQuestContentProgressRsp> // TypeDefIndex: 24584
{
	// Fields
	private static readonly MessageParser<AddQuestContentProgressRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B06C3F
	private int retcode_; // 0x18
	public const int ContentTypeFieldNumber = 2; // Metadata: 0x00B06C43
	private uint contentType_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AddQuestContentProgressRsp> Parser { get => default; } // 0x0000000183FF7350-0x0000000183FF73E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183FF70E0-0x0000000183FF7170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183FF6DD0-0x0000000183FF6E50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183FF6680-0x0000000183FF66E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183FF7780-0x0000000183FF7870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183FF75B0-0x0000000183FF7610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183FF7170-0x0000000183FF7260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183FF7730-0x0000000183FF7780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183FF6EF0-0x0000000183FF6FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183FF6C90-0x0000000183FF6D30 0x0000000183FF68D0-0x0000000183FF6970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ContentType { get => default; set {} } // 0x0000000183FF7510-0x0000000183FF75B0 0x0000000183FF6D30-0x0000000183FF6DD0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24585
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24586
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 407
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddQuestContentProgressRsp() {} // 0x0000000183FF7B30-0x0000000183FF7B90
	static AddQuestContentProgressRsp() {} // 0x0000000183FF7A70-0x0000000183FF7B30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddQuestContentProgressRsp Clone() => default; // 0x0000000183FF7260-0x0000000183FF7350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddQuestContentProgressRsp ShallowCopy() => default; // 0x0000000183FF6E50-0x0000000183FF6EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183FF6810-0x0000000183FF6860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FF7470-0x0000000183FF74C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FF74C0-0x0000000183FF7510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183FF6860-0x0000000183FF68D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183FF6A90-0x0000000183FF6B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AddQuestContentProgressRsp other) => default; // 0x0000000183FF6970-0x0000000183FF6A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183FF6FE0-0x0000000183FF70E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183FF7870-0x0000000183FF7A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183FF7610-0x0000000183FF7730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183FF6B60-0x0000000183FF6C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AddQuestContentProgressRsp other) {} // 0x0000000183FF66E0-0x0000000183FF6810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183FF6580-0x0000000183FF6680
}

