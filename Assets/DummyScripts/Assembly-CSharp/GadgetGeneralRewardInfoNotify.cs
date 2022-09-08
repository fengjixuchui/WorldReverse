/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GadgetGeneralRewardInfoNotify : MessageBase, IMessage<GadgetGeneralRewardInfoNotify> // TypeDefIndex: 23213
{
	// Fields
	private static readonly MessageParser<GadgetGeneralRewardInfoNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B03807
	private uint entityId_; // 0x18
	public const int GeneralRewardInfoFieldNumber = 2; // Metadata: 0x00B0380B
	private GadgetGeneralRewardInfo generalRewardInfo_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GadgetGeneralRewardInfoNotify> Parser { get => default; } // 0x00000001827A38E0-0x00000001827A3970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001827A3670-0x00000001827A3700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001827A32E0-0x00000001827A3360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001827A2B10-0x00000001827A2B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001827A3E10-0x00000001827A3F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001827A3C40-0x00000001827A3CA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001827A3700-0x00000001827A37F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001827A3DC0-0x00000001827A3E10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001827A3400-0x00000001827A34F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x00000001827A3BA0-0x00000001827A3C40 0x00000001827A3F00-0x00000001827A3FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetGeneralRewardInfo GeneralRewardInfo { get => default; set {} } // 0x00000001827A2B70-0x00000001827A2C10 0x00000001827A3A80-0x00000001827A3B20

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23214
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23215
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 813
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetGeneralRewardInfoNotify() {} // 0x00000001827A4240-0x00000001827A42A0
	static GadgetGeneralRewardInfoNotify() {} // 0x00000001827A4180-0x00000001827A4240

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetGeneralRewardInfoNotify Clone() => default; // 0x00000001827A37F0-0x00000001827A38E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetGeneralRewardInfoNotify ShallowCopy() => default; // 0x00000001827A3360-0x00000001827A3400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001827A2D90-0x00000001827A2E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001827A3A00-0x00000001827A3A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001827A3B20-0x00000001827A3BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001827A2E10-0x00000001827A2F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001827A2F40-0x00000001827A3010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GadgetGeneralRewardInfoNotify other) => default; // 0x00000001827A3010-0x00000001827A3140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001827A34F0-0x00000001827A3670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001827A3FA0-0x00000001827A4180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001827A3CA0-0x00000001827A3DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001827A3140-0x00000001827A32E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GadgetGeneralRewardInfoNotify other) {} // 0x00000001827A2C10-0x00000001827A2D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001827A29D0-0x00000001827A2B10
}

