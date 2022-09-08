/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GadgetTalkChangeNotify : MessageBase, IMessage<GadgetTalkChangeNotify> // TypeDefIndex: 23232
{
	// Fields
	private static readonly MessageParser<GadgetTalkChangeNotify> _parser; // 0x00
	public const int GadgetEntityIdFieldNumber = 1; // Metadata: 0x00B038BB
	private uint gadgetEntityId_; // 0x18
	public const int CurGadgetTalkStateFieldNumber = 2; // Metadata: 0x00B038BF
	private uint curGadgetTalkState_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GadgetTalkChangeNotify> Parser { get => default; } // 0x00000001841F6110-0x00000001841F61A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001841F5E00-0x00000001841F5E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001841F5AF0-0x00000001841F5B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001841F5440-0x00000001841F54A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001841F6540-0x00000001841F6630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001841F62D0-0x00000001841F6330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001841F5E90-0x00000001841F5F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001841F64F0-0x00000001841F6540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001841F5C10-0x00000001841F5D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetEntityId { get => default; set {} } // 0x00000001841F6330-0x00000001841F63D0 0x00000001841F54A0-0x00000001841F5540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurGadgetTalkState { get => default; set {} } // 0x00000001841F5A50-0x00000001841F5AF0 0x00000001841F6070-0x00000001841F6110

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23233
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23234
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 819
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetTalkChangeNotify() {} // 0x00000001841F68F0-0x00000001841F6950
	static GadgetTalkChangeNotify() {} // 0x00000001841F6830-0x00000001841F68F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetTalkChangeNotify Clone() => default; // 0x00000001841F5F80-0x00000001841F6070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetTalkChangeNotify ShallowCopy() => default; // 0x00000001841F5B70-0x00000001841F5C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001841F5670-0x00000001841F56C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001841F6230-0x00000001841F6280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001841F6280-0x00000001841F62D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001841F56C0-0x00000001841F5730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001841F5730-0x00000001841F5800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GadgetTalkChangeNotify other) => default; // 0x00000001841F5800-0x00000001841F5920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001841F5D00-0x00000001841F5E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001841F6630-0x00000001841F6830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001841F63D0-0x00000001841F64F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001841F5920-0x00000001841F5A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GadgetTalkChangeNotify other) {} // 0x00000001841F5540-0x00000001841F5670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001841F5340-0x00000001841F5440
}

