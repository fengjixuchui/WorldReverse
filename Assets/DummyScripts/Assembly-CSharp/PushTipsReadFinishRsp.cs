/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PushTipsReadFinishRsp : MessageBase, IMessage<PushTipsReadFinishRsp> // TypeDefIndex: 25789
{
	// Fields
	private static readonly MessageParser<PushTipsReadFinishRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B09937
	private int retcode_; // 0x18
	public const int PushTipsIdFieldNumber = 2; // Metadata: 0x00B0993B
	private uint pushTipsId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PushTipsReadFinishRsp> Parser { get => default; } // 0x00000001831AFC80-0x00000001831AFD10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001831AFA10-0x00000001831AFAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001831AF700-0x00000001831AF780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001831AEFB0-0x00000001831AF010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001831B00B0-0x00000001831B01A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001831AFE40-0x00000001831AFEA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001831AFAA0-0x00000001831AFB90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001831B0060-0x00000001831B00B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001831AF820-0x00000001831AF910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001831AF660-0x00000001831AF700 0x00000001831AF2A0-0x00000001831AF340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PushTipsId { get => default; set {} } // 0x00000001831AF010-0x00000001831AF0B0 0x00000001831AFEA0-0x00000001831AFF40

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25790
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25791
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2224
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PushTipsReadFinishRsp() {} // 0x00000001831B0460-0x00000001831B04C0
	static PushTipsReadFinishRsp() {} // 0x00000001831B03A0-0x00000001831B0460

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PushTipsReadFinishRsp Clone() => default; // 0x00000001831AFB90-0x00000001831AFC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PushTipsReadFinishRsp ShallowCopy() => default; // 0x00000001831AF780-0x00000001831AF820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001831AF1E0-0x00000001831AF230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831AFDA0-0x00000001831AFDF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831AFDF0-0x00000001831AFE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001831AF230-0x00000001831AF2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001831AF460-0x00000001831AF530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PushTipsReadFinishRsp other) => default; // 0x00000001831AF340-0x00000001831AF460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001831AF910-0x00000001831AFA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001831B01A0-0x00000001831B03A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001831AFF40-0x00000001831B0060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001831AF530-0x00000001831AF660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PushTipsReadFinishRsp other) {} // 0x00000001831AF0B0-0x00000001831AF1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001831AEEB0-0x00000001831AEFB0
}

