/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarEnterElementViewNotify : MessageBase, IMessage<AvatarEnterElementViewNotify> // TypeDefIndex: 23079
{
	// Fields
	private static readonly MessageParser<AvatarEnterElementViewNotify> _parser; // 0x00
	public const int AvatarEntityIdFieldNumber = 1; // Metadata: 0x00B03247
	private uint avatarEntityId_; // 0x18
	public const int IsTriggerdFieldNumber = 2; // Metadata: 0x00B0324B
	private bool isTriggerd_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarEnterElementViewNotify> Parser { get => default; } // 0x00000001846B4020-0x00000001846B40B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001846B3D10-0x00000001846B3DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001846B3950-0x00000001846B39D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001846B32D0-0x00000001846B3330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001846B43B0-0x00000001846B44A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001846B41E0-0x00000001846B4240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001846B3E40-0x00000001846B3F30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001846B4360-0x00000001846B43B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001846B3B10-0x00000001846B3C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarEntityId { get => default; set {} } // 0x00000001846B38B0-0x00000001846B3950 0x00000001846B3DA0-0x00000001846B3E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsTriggerd { get => default; set {} } // 0x00000001846B3520-0x00000001846B35C0 0x00000001846B39D0-0x00000001846B3A70

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23080
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23081
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 332
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarEnterElementViewNotify() {} // 0x00000001846B4760-0x00000001846B47C0
	static AvatarEnterElementViewNotify() {} // 0x00000001846B46A0-0x00000001846B4760

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarEnterElementViewNotify Clone() => default; // 0x00000001846B3F30-0x00000001846B4020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarEnterElementViewNotify ShallowCopy() => default; // 0x00000001846B3A70-0x00000001846B3B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001846B3460-0x00000001846B34B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001846B4140-0x00000001846B4190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001846B4190-0x00000001846B41E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001846B34B0-0x00000001846B3520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001846B36E0-0x00000001846B37B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarEnterElementViewNotify other) => default; // 0x00000001846B35C0-0x00000001846B36E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001846B3C00-0x00000001846B3D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001846B44A0-0x00000001846B46A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001846B4240-0x00000001846B4360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001846B37B0-0x00000001846B38B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarEnterElementViewNotify other) {} // 0x00000001846B3330-0x00000001846B3460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001846B31D0-0x00000001846B32D0
}

