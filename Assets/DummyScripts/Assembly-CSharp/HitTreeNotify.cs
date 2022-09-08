/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HitTreeNotify : MessageBase, IMessage<HitTreeNotify> // TypeDefIndex: 25355
{
	// Fields
	private static readonly MessageParser<HitTreeNotify> _parser; // 0x00
	public const int TreeTypeFieldNumber = 1; // Metadata: 0x00B0888B
	private uint treeType_; // 0x18
	public const int TreePosFieldNumber = 2; // Metadata: 0x00B0888F
	private Vector treePos_; // 0x20
	public const int DropPosFieldNumber = 3; // Metadata: 0x00B08893
	private Vector dropPos_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HitTreeNotify> Parser { get => default; } // 0x0000000182A57810-0x0000000182A578A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182A575A0-0x0000000182A57630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182A57170-0x0000000182A571F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182A564F0-0x0000000182A56550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182A57CF0-0x0000000182A57DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182A57AF0-0x0000000182A57B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182A57630-0x0000000182A57720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182A57CA0-0x0000000182A57CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182A57290-0x0000000182A57380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TreeType { get => default; set {} } // 0x0000000182A56550-0x0000000182A565F0 0x0000000182A57030-0x0000000182A570D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector TreePos { get => default; set {} } // 0x0000000182A579C0-0x0000000182A57A60 0x0000000182A567F0-0x0000000182A56890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector DropPos { get => default; set {} } // 0x0000000182A570D0-0x0000000182A57170 0x0000000182A56B10-0x0000000182A56BB0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25356
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25357
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 3066
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HitTreeNotify() {} // 0x0000000182A58100-0x0000000182A58160
	static HitTreeNotify() {} // 0x0000000182A58040-0x0000000182A58100

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HitTreeNotify Clone() => default; // 0x0000000182A57720-0x0000000182A57810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HitTreeNotify ShallowCopy() => default; // 0x0000000182A571F0-0x0000000182A57290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182A56890-0x0000000182A56920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A57930-0x0000000182A579C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A57A60-0x0000000182A57AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182A56920-0x0000000182A56B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182A56D10-0x0000000182A56DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HitTreeNotify other) => default; // 0x0000000182A56BB0-0x0000000182A56D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182A57380-0x0000000182A575A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182A57DE0-0x0000000182A58040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182A57B50-0x0000000182A57CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182A56DE0-0x0000000182A57030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HitTreeNotify other) {} // 0x0000000182A565F0-0x0000000182A567F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182A56360-0x0000000182A564F0
}

