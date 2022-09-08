/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CommonPlayerTipsNotify : MessageBase, IMessage<CommonPlayerTipsNotify> // TypeDefIndex: 22374
{
	// Fields
	private static readonly MessageParser<CommonPlayerTipsNotify> _parser; // 0x00
	public const int TextMapIdListFieldNumber = 1; // Metadata: 0x00B0170F
	private static readonly FieldCodec<string> _repeated_textMapIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<string> textMapIdList_; // 0x18
	public const int NotifyTypeFieldNumber = 2; // Metadata: 0x00B01713
	private uint notifyType_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CommonPlayerTipsNotify> Parser { get => default; } // 0x00000001836E56C0-0x00000001836E5750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001836E53B0-0x00000001836E5440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001836E50A0-0x00000001836E5120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001836E49C0-0x00000001836E4A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001836E5A70-0x00000001836E5B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001836E5880-0x00000001836E58E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001836E5440-0x00000001836E5530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001836E5A20-0x00000001836E5A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001836E51C0-0x00000001836E52B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<string> TextMapIdList { get => default; } // 0x00000001836E4BA0-0x00000001836E4C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NotifyType { get => default; set {} } // 0x00000001836E5530-0x00000001836E55D0 0x00000001836E5000-0x00000001836E50A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22375
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22376
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 8081
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CommonPlayerTipsNotify() {} // 0x00000001836E5E20-0x00000001836E5EB0
	static CommonPlayerTipsNotify() {} // 0x00000001836E5D40-0x00000001836E5E20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CommonPlayerTipsNotify Clone() => default; // 0x00000001836E55D0-0x00000001836E56C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CommonPlayerTipsNotify ShallowCopy() => default; // 0x00000001836E5120-0x00000001836E51C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001836E4B50-0x00000001836E4BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836E57E0-0x00000001836E5830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836E5830-0x00000001836E5880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001836E4C00-0x00000001836E4CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001836E4DF0-0x00000001836E4EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CommonPlayerTipsNotify other) => default; // 0x00000001836E4CD0-0x00000001836E4DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001836E52B0-0x00000001836E53B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001836E5B60-0x00000001836E5D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001836E58E0-0x00000001836E5A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001836E4EC0-0x00000001836E5000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CommonPlayerTipsNotify other) {} // 0x00000001836E4A20-0x00000001836E4B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001836E4860-0x00000001836E49C0
}

