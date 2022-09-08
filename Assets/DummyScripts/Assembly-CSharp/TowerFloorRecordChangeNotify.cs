/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TowerFloorRecordChangeNotify : MessageBase, IMessage<TowerFloorRecordChangeNotify> // TypeDefIndex: 25700
{
	// Fields
	private static readonly MessageParser<TowerFloorRecordChangeNotify> _parser; // 0x00
	public const int TowerFloorRecordListFieldNumber = 1; // Metadata: 0x00B0960B
	private static readonly FieldCodec<TowerFloorRecord> _repeated_towerFloorRecordList_codec; // 0x08
	private readonly RepeatedMessageField<TowerFloorRecord> towerFloorRecordList_; // 0x18
	public const int IsFinishedEntranceFloorFieldNumber = 2; // Metadata: 0x00B0960F
	private bool isFinishedEntranceFloor_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TowerFloorRecordChangeNotify> Parser { get => default; } // 0x0000000183180420-0x00000001831804B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001831801B0-0x0000000183180240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018317FEB0-0x000000018317FF30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018317F720-0x000000018317F780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183180850-0x0000000183180940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183180660-0x00000001831806C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183180240-0x0000000183180330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183180800-0x0000000183180850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018317FFD0-0x00000001831800C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<TowerFloorRecord> TowerFloorRecordList { get => default; } // 0x000000018317FE50-0x000000018317FEB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsFinishedEntranceFloor { get => default; set {} } // 0x000000018317F780-0x000000018317F820 0x000000018317F820-0x000000018317F8C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25701
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25702
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2402
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerFloorRecordChangeNotify() {} // 0x0000000183180C30-0x0000000183180CC0
	static TowerFloorRecordChangeNotify() {} // 0x0000000183180B20-0x0000000183180C30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerFloorRecordChangeNotify Clone() => default; // 0x0000000183180330-0x0000000183180420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerFloorRecordChangeNotify ShallowCopy() => default; // 0x000000018317FF30-0x000000018317FFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018317FA30-0x000000018317FA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183180540-0x00000001831805D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831805D0-0x0000000183180660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018317FA80-0x000000018317FB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018317FC80-0x000000018317FD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TowerFloorRecordChangeNotify other) => default; // 0x000000018317FB60-0x000000018317FC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001831800C0-0x00000001831801B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183180940-0x0000000183180B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001831806C0-0x0000000183180800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018317FD50-0x000000018317FE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TowerFloorRecordChangeNotify other) {} // 0x000000018317F8C0-0x000000018317FA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018317F5C0-0x000000018317F720
}

