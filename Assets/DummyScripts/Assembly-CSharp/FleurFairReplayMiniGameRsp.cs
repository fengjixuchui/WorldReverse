/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FleurFairReplayMiniGameRsp : MessageBase, IMessage<FleurFairReplayMiniGameRsp> // TypeDefIndex: 22237
{
	// Fields
	private static readonly MessageParser<FleurFairReplayMiniGameRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B011D3
	private int retcode_; // 0x18
	public const int MinigameIdFieldNumber = 2; // Metadata: 0x00B011D7
	private uint minigameId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FleurFairReplayMiniGameRsp> Parser { get => default; } // 0x0000000181B98BA0-0x0000000181B98C30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181B987F0-0x0000000181B98880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181B984E0-0x0000000181B98560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181B97E30-0x0000000181B97E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181B98F30-0x0000000181B99020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181B98D60-0x0000000181B98DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181B98920-0x0000000181B98A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181B98EE0-0x0000000181B98F30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181B98600-0x0000000181B986F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181B98440-0x0000000181B984E0 0x0000000181B98080-0x0000000181B98120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MinigameId { get => default; set {} } // 0x0000000181B98880-0x0000000181B98920 0x0000000181B98B00-0x0000000181B98BA0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22238
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22239
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2188
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairReplayMiniGameRsp() {} // 0x0000000181B992E0-0x0000000181B99340
	static FleurFairReplayMiniGameRsp() {} // 0x0000000181B99220-0x0000000181B992E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairReplayMiniGameRsp Clone() => default; // 0x0000000181B98A10-0x0000000181B98B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairReplayMiniGameRsp ShallowCopy() => default; // 0x0000000181B98560-0x0000000181B98600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181B97FC0-0x0000000181B98010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181B98CC0-0x0000000181B98D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181B98D10-0x0000000181B98D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181B98010-0x0000000181B98080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181B98120-0x0000000181B981F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FleurFairReplayMiniGameRsp other) => default; // 0x0000000181B981F0-0x0000000181B98310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181B986F0-0x0000000181B987F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181B99020-0x0000000181B99220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181B98DC0-0x0000000181B98EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181B98310-0x0000000181B98440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FleurFairReplayMiniGameRsp other) {} // 0x0000000181B97E90-0x0000000181B97FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181B97D30-0x0000000181B97E30
}

