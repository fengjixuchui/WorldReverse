/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ScenePlayOwnerStartInviteRsp : MessageBase, IMessage<ScenePlayOwnerStartInviteRsp> // TypeDefIndex: 25378
{
	// Fields
	private static readonly MessageParser<ScenePlayOwnerStartInviteRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0899B
	private int retcode_; // 0x18
	public const int PlayIdFieldNumber = 2; // Metadata: 0x00B0899F
	private uint playId_; // 0x1C
	public const int IsSkipMatchFieldNumber = 3; // Metadata: 0x00B089A3
	private bool isSkipMatch_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ScenePlayOwnerStartInviteRsp> Parser { get => default; } // 0x0000000183057920-0x00000001830579B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183057610-0x00000001830576A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183057230-0x00000001830572B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183056A60-0x0000000183056AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183057D90-0x0000000183057E80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183057AE0-0x0000000183057B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183057740-0x0000000183057830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183057D40-0x0000000183057D90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183057350-0x0000000183057440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001830570F0-0x0000000183057190 0x0000000183056CF0-0x0000000183056D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayId { get => default; set {} } // 0x0000000183057190-0x0000000183057230 0x0000000183057570-0x0000000183057610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSkipMatch { get => default; set {} } // 0x0000000183057CA0-0x0000000183057D40 0x00000001830576A0-0x0000000183057740

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25379
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25380
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4355
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayOwnerStartInviteRsp() {} // 0x00000001830581D0-0x0000000183058230
	static ScenePlayOwnerStartInviteRsp() {} // 0x0000000183058110-0x00000001830581D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayOwnerStartInviteRsp Clone() => default; // 0x0000000183057830-0x0000000183057920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayOwnerStartInviteRsp ShallowCopy() => default; // 0x00000001830572B0-0x0000000183057350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183056C20-0x0000000183056C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183057A40-0x0000000183057A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183057A90-0x0000000183057AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183056C70-0x0000000183056CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183056D90-0x0000000183056E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ScenePlayOwnerStartInviteRsp other) => default; // 0x0000000183056E60-0x0000000183056FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183057440-0x0000000183057570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183057E80-0x0000000183058110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183057B40-0x0000000183057CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183056FA0-0x00000001830570F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ScenePlayOwnerStartInviteRsp other) {} // 0x0000000183056AC0-0x0000000183056C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183056950-0x0000000183056A60
}

