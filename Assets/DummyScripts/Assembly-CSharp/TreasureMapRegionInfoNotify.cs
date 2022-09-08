/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TreasureMapRegionInfoNotify : MessageBase, IMessage<TreasureMapRegionInfoNotify> // TypeDefIndex: 22098
{
	// Fields
	private static readonly MessageParser<TreasureMapRegionInfoNotify> _parser; // 0x00
	public const int RegionInfoFieldNumber = 1; // Metadata: 0x00B00CC3
	private TreasureMapRegionInfo regionInfo_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TreasureMapRegionInfoNotify> Parser { get => default; } // 0x0000000183978D30-0x0000000183978DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183978980-0x0000000183978A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183978620-0x00000001839786A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183977F90-0x0000000183977FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001839790E0-0x00000001839791D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183978F50-0x0000000183978FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183978A10-0x0000000183978B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183979090-0x00000001839790E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183978740-0x0000000183978830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapRegionInfo RegionInfo { get => default; set {} } // 0x0000000183978C90-0x0000000183978D30 0x0000000183978B00-0x0000000183978BA0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22099
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22100
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2121
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapRegionInfoNotify() {} // 0x00000001839793E0-0x0000000183979440
	static TreasureMapRegionInfoNotify() {} // 0x0000000183979320-0x00000001839793E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapRegionInfoNotify Clone() => default; // 0x0000000183978BA0-0x0000000183978C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapRegionInfoNotify ShallowCopy() => default; // 0x00000001839786A0-0x0000000183978740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183978150-0x00000001839781D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183978E50-0x0000000183978ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183978ED0-0x0000000183978F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001839781D0-0x00000001839782F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001839782F0-0x00000001839783C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TreasureMapRegionInfoNotify other) => default; // 0x00000001839783C0-0x00000001839784D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183978830-0x0000000183978980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001839791D0-0x0000000183979320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183978FB0-0x0000000183979090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001839784D0-0x0000000183978620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TreasureMapRegionInfoNotify other) {} // 0x0000000183977FF0-0x0000000183978150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183977E80-0x0000000183977F90
}

