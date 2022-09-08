/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SetCurExpeditionChallengeIdRsp : MessageBase, IMessage<SetCurExpeditionChallengeIdRsp> // TypeDefIndex: 22195
{
	// Fields
	private static readonly MessageParser<SetCurExpeditionChallengeIdRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B01043
	private int retcode_; // 0x18
	public const int IdFieldNumber = 2; // Metadata: 0x00B01047
	private uint id_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SetCurExpeditionChallengeIdRsp> Parser { get => default; } // 0x00000001813114B0-0x0000000181311540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181311240-0x00000001813112D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181310F30-0x0000000181310FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001813107E0-0x0000000181310840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001813118E0-0x00000001813119D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181311710-0x0000000181311770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001813112D0-0x00000001813113C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181311890-0x00000001813118E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181311050-0x0000000181311140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181310DF0-0x0000000181310E90 0x0000000181310A30-0x0000000181310AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Id { get => default; set {} } // 0x0000000181310E90-0x0000000181310F30 0x0000000181311540-0x00000001813115E0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22196
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22197
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2170
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetCurExpeditionChallengeIdRsp() {} // 0x0000000181311C90-0x0000000181311CF0
	static SetCurExpeditionChallengeIdRsp() {} // 0x0000000181311BD0-0x0000000181311C90

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetCurExpeditionChallengeIdRsp Clone() => default; // 0x00000001813113C0-0x00000001813114B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetCurExpeditionChallengeIdRsp ShallowCopy() => default; // 0x0000000181310FB0-0x0000000181311050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181310970-0x00000001813109C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181311670-0x00000001813116C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001813116C0-0x0000000181311710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001813109C0-0x0000000181310A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181310BF0-0x0000000181310CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SetCurExpeditionChallengeIdRsp other) => default; // 0x0000000181310AD0-0x0000000181310BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181311140-0x0000000181311240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001813119D0-0x0000000181311BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181311770-0x0000000181311890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181310CC0-0x0000000181310DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SetCurExpeditionChallengeIdRsp other) {} // 0x0000000181310840-0x0000000181310970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001813106E0-0x00000001813107E0
}

