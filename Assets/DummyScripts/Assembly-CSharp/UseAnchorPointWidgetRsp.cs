/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UseAnchorPointWidgetRsp : MessageBase, IMessage<UseAnchorPointWidgetRsp> // TypeDefIndex: 25808
{
	// Fields
	private static readonly MessageParser<UseAnchorPointWidgetRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B099D7
	private int retcode_; // 0x18
	public const int NewAnchorPointIdFieldNumber = 2; // Metadata: 0x00B099DB
	private uint newAnchorPointId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UseAnchorPointWidgetRsp> Parser { get => default; } // 0x0000000183775B20-0x0000000183775BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001837758B0-0x0000000183775940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183775500-0x0000000183775580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183774E50-0x0000000183774EB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183775F50-0x0000000183776040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183775CE0-0x0000000183775D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183775940-0x0000000183775A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183775F00-0x0000000183775F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001837756C0-0x00000001837757B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183775460-0x0000000183775500 0x00000001837750A0-0x0000000183775140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NewAnchorPointId { get => default; set {} } // 0x0000000183775620-0x00000001837756C0 0x0000000183775E60-0x0000000183775F00

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25809
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25810
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4253
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseAnchorPointWidgetRsp() {} // 0x0000000183776300-0x0000000183776360
	static UseAnchorPointWidgetRsp() {} // 0x0000000183776240-0x0000000183776300

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseAnchorPointWidgetRsp Clone() => default; // 0x0000000183775A30-0x0000000183775B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UseAnchorPointWidgetRsp ShallowCopy() => default; // 0x0000000183775580-0x0000000183775620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183774FE0-0x0000000183775030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183775C40-0x0000000183775C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183775C90-0x0000000183775CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183775030-0x00000001837750A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183775140-0x0000000183775210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UseAnchorPointWidgetRsp other) => default; // 0x0000000183775210-0x0000000183775330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001837757B0-0x00000001837758B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183776040-0x0000000183776240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183775D40-0x0000000183775E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183775330-0x0000000183775460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UseAnchorPointWidgetRsp other) {} // 0x0000000183774EB0-0x0000000183774FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183774D50-0x0000000183774E50
}

