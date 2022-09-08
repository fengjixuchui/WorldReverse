/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerPropChangeReasonNotify : MessageBase, IMessage<PlayerPropChangeReasonNotify> // TypeDefIndex: 24552
{
	// Fields
	private static readonly MessageParser<PlayerPropChangeReasonNotify> _parser; // 0x00
	public const int PropTypeFieldNumber = 1; // Metadata: 0x00B06B17
	private uint propType_; // 0x18
	public const int OldValueFieldNumber = 2; // Metadata: 0x00B06B1B
	private float oldValue_; // 0x1C
	public const int CurValueFieldNumber = 3; // Metadata: 0x00B06B1F
	private float curValue_; // 0x20
	public const int ReasonFieldNumber = 4; // Metadata: 0x00B06B23
	private PropChangeReason reason_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerPropChangeReasonNotify> Parser { get => default; } // 0x0000000183B46B50-0x0000000183B46BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183B46660-0x0000000183B466F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183B46290-0x0000000183B46310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183B45990-0x0000000183B459F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183B46F70-0x0000000183B47060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183B46D10-0x0000000183B46D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183B46790-0x0000000183B46880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183B46F20-0x0000000183B46F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183B463B0-0x0000000183B464A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PropType { get => default; set {} } // 0x0000000183B46A10-0x0000000183B46AB0 0x0000000183B45DB0-0x0000000183B45E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float OldValue { get => default; set {} } // 0x0000000183B466F0-0x0000000183B46790 0x0000000183B461F0-0x0000000183B46290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float CurValue { get => default; set {} } // 0x0000000183B46970-0x0000000183B46A10 0x0000000183B45D10-0x0000000183B45DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PropChangeReason Reason { get => default; set {} } // 0x0000000183B46AB0-0x0000000183B46B50 0x0000000183B45BE0-0x0000000183B45C80

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24553
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24554
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1210
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerPropChangeReasonNotify() {} // 0x0000000183B47440-0x0000000183B474B0
	static PlayerPropChangeReasonNotify() {} // 0x0000000183B47380-0x0000000183B47440

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerPropChangeReasonNotify Clone() => default; // 0x0000000183B46880-0x0000000183B46970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerPropChangeReasonNotify ShallowCopy() => default; // 0x0000000183B46310-0x0000000183B463B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183B45B90-0x0000000183B45BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B46C70-0x0000000183B46CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B46CC0-0x0000000183B46D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183B45C80-0x0000000183B45D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183B45FC0-0x0000000183B46090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerPropChangeReasonNotify other) => default; // 0x0000000183B45E50-0x0000000183B45FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183B464A0-0x0000000183B46660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183B47060-0x0000000183B47380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183B46D70-0x0000000183B46F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183B46090-0x0000000183B461F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerPropChangeReasonNotify other) {} // 0x0000000183B459F0-0x0000000183B45B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183B45850-0x0000000183B45990
}

