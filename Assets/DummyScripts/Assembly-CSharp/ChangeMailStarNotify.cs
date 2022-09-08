/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChangeMailStarNotify : MessageBase, IMessage<ChangeMailStarNotify> // TypeDefIndex: 23822
{
	// Fields
	private static readonly MessageParser<ChangeMailStarNotify> _parser; // 0x00
	public const int MailIdListFieldNumber = 1; // Metadata: 0x00B04E67
	private static readonly FieldCodec<uint> _repeated_mailIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> mailIdList_; // 0x18
	public const int IsStarFieldNumber = 2; // Metadata: 0x00B04E6B
	private bool isStar_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChangeMailStarNotify> Parser { get => default; } // 0x000000018366A240-0x000000018366A2D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183669F30-0x0000000183669FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183669C30-0x0000000183669CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183669690-0x00000001836696F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018366A690-0x000000018366A780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018366A4A0-0x000000018366A500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183669FC0-0x000000018366A0B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018366A640-0x000000018366A690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183669D50-0x0000000183669E40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> MailIdList { get => default; } // 0x0000000183669630-0x0000000183669690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsStar { get => default; set {} } // 0x000000018366A3B0-0x000000018366A450 0x000000018366A1A0-0x000000018366A240

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23823
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23824
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1413
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChangeMailStarNotify() {} // 0x000000018366AA40-0x000000018366AAD0
	static ChangeMailStarNotify() {} // 0x000000018366A960-0x000000018366AA40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChangeMailStarNotify Clone() => default; // 0x000000018366A0B0-0x000000018366A1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChangeMailStarNotify ShallowCopy() => default; // 0x0000000183669CB0-0x0000000183669D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183669820-0x0000000183669870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018366A360-0x000000018366A3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018366A450-0x000000018366A4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183669870-0x0000000183669940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183669A60-0x0000000183669B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChangeMailStarNotify other) => default; // 0x0000000183669940-0x0000000183669A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183669E40-0x0000000183669F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018366A780-0x000000018366A960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018366A500-0x000000018366A640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183669B30-0x0000000183669C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChangeMailStarNotify other) {} // 0x00000001836696F0-0x0000000183669820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001836694C0-0x0000000183669630
}

