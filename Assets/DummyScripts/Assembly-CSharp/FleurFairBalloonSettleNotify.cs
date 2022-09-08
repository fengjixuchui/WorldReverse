/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FleurFairBalloonSettleNotify : MessageBase, IMessage<FleurFairBalloonSettleNotify> // TypeDefIndex: 22216
{
	// Fields
	private static readonly MessageParser<FleurFairBalloonSettleNotify> _parser; // 0x00
	public const int SettleInfoMapFieldNumber = 1; // Metadata: 0x00B01117
	private static readonly MapField<uint, FleurFairBalloonSettleInfo> _map_settleInfoMap_codec; // 0x08
	private readonly MapField<uint, FleurFairBalloonSettleInfo> settleInfoMap_; // 0x18
	public const int MinigameIdFieldNumber = 2; // Metadata: 0x00B0111B
	private uint minigameId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FleurFairBalloonSettleNotify> Parser { get => default; } // 0x00000001820C52D0-0x00000001820C5360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001820C4EC0-0x00000001820C4F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001820C4B80-0x00000001820C4C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001820C4520-0x00000001820C4580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001820C5680-0x00000001820C5770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001820C5490-0x00000001820C54F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001820C4FF0-0x00000001820C50E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001820C5630-0x00000001820C5680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001820C4CA0-0x00000001820C4D90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, FleurFairBalloonSettleInfo> SettleInfoMap { get => default; } // 0x00000001820C51D0-0x00000001820C5230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MinigameId { get => default; set {} } // 0x00000001820C4F50-0x00000001820C4FF0 0x00000001820C5230-0x00000001820C52D0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22217
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22218
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2181
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairBalloonSettleNotify() {} // 0x00000001820C5AB0-0x00000001820C5B40
	static FleurFairBalloonSettleNotify() {} // 0x00000001820C5950-0x00000001820C5AB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairBalloonSettleNotify Clone() => default; // 0x00000001820C50E0-0x00000001820C51D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairBalloonSettleNotify ShallowCopy() => default; // 0x00000001820C4C00-0x00000001820C4CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001820C46B0-0x00000001820C4700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820C53F0-0x00000001820C5440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820C5440-0x00000001820C5490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001820C4700-0x00000001820C47D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001820C47D0-0x00000001820C48A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FleurFairBalloonSettleNotify other) => default; // 0x00000001820C48A0-0x00000001820C4A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001820C4D90-0x00000001820C4EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001820C5770-0x00000001820C5950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001820C54F0-0x00000001820C5630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001820C4A40-0x00000001820C4B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FleurFairBalloonSettleNotify other) {} // 0x00000001820C4580-0x00000001820C46B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001820C43C0-0x00000001820C4520
}

