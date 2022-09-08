/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WorldPlayerRTTNotify : MessageBase, IMessage<WorldPlayerRTTNotify> // TypeDefIndex: 24012
{
	// Fields
	private static readonly MessageParser<WorldPlayerRTTNotify> _parser; // 0x00
	public const int PlayerRttListFieldNumber = 1; // Metadata: 0x00B05597
	private static readonly FieldCodec<PlayerRTTInfo> _repeated_playerRttList_codec; // 0x08
	private readonly RepeatedMessageField<PlayerRTTInfo> playerRttList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WorldPlayerRTTNotify> Parser { get => default; } // 0x000000018476A550-0x000000018476A5E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018476A2E0-0x000000018476A370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018476A010-0x000000018476A090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184769A90-0x0000000184769AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018476A9A0-0x000000018476AA90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018476A7F0-0x000000018476A850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018476A370-0x000000018476A460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018476A950-0x000000018476A9A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018476A130-0x000000018476A220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<PlayerRTTInfo> PlayerRttList { get => default; } // 0x000000018476A700-0x000000018476A760 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24013
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24014
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 21
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldPlayerRTTNotify() {} // 0x000000018476ACF0-0x000000018476AD80
	static WorldPlayerRTTNotify() {} // 0x000000018476ABE0-0x000000018476ACF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldPlayerRTTNotify Clone() => default; // 0x000000018476A460-0x000000018476A550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldPlayerRTTNotify ShallowCopy() => default; // 0x000000018476A090-0x000000018476A130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184769C20-0x0000000184769C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018476A670-0x000000018476A700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018476A760-0x000000018476A7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184769C70-0x0000000184769D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184769E50-0x0000000184769F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WorldPlayerRTTNotify other) => default; // 0x0000000184769D40-0x0000000184769E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018476A220-0x000000018476A2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018476AA90-0x000000018476ABE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018476A850-0x000000018476A950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184769F20-0x000000018476A010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WorldPlayerRTTNotify other) {} // 0x0000000184769AF0-0x0000000184769C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184769960-0x0000000184769A90
}

