/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerEyePointStateNotify : MessageBase, IMessage<PlayerEyePointStateNotify> // TypeDefIndex: 25311
{
	// Fields
	private static readonly MessageParser<PlayerEyePointStateNotify> _parser; // 0x00
	public const int IsUseEyePointFieldNumber = 1; // Metadata: 0x00B086D7
	private bool isUseEyePoint_; // 0x18
	public const int EyePointPosFieldNumber = 2; // Metadata: 0x00B086DB
	private Vector eyePointPos_; // 0x20
	public const int RegionEntityIdFieldNumber = 3; // Metadata: 0x00B086DF
	private uint regionEntityId_; // 0x28
	public const int RegionGroupIdFieldNumber = 4; // Metadata: 0x00B086E3
	private uint regionGroupId_; // 0x2C
	public const int RegionConfigIdFieldNumber = 5; // Metadata: 0x00B086E7
	private uint regionConfigId_; // 0x30
	public const int RegionShapeFieldNumber = 6; // Metadata: 0x00B086EB
	private uint regionShape_; // 0x34
	public const int SphereRadiusFieldNumber = 100; // Metadata: 0x00B086EF
	public const int CubicSizeFieldNumber = 101; // Metadata: 0x00B086F3
	private object regionSize_; // 0x38
	private RegionSizeOneofCase regionSizeCase_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerEyePointStateNotify> Parser { get => default; } // 0x0000000181A6E130-0x0000000181A6E1C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181A6DB40-0x0000000181A6DBD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181A6D560-0x0000000181A6D5E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181A6C7B0-0x0000000181A6C810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181A6EAA0-0x0000000181A6EB90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181A6E660-0x0000000181A6E6C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181A6DE10-0x0000000181A6DF00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181A6E9B0-0x0000000181A6EA00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181A6D680-0x0000000181A6D770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsUseEyePoint { get => default; set {} } // 0x0000000181A6C810-0x0000000181A6C8B0 0x0000000181A6DA00-0x0000000181A6DAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector EyePointPos { get => default; set {} } // 0x0000000181A6CE60-0x0000000181A6CF00 0x0000000181A6C8B0-0x0000000181A6C950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RegionEntityId { get => default; set {} } // 0x0000000181A6DAA0-0x0000000181A6DB40 0x0000000181A6DD70-0x0000000181A6DE10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RegionGroupId { get => default; set {} } // 0x0000000181A6E090-0x0000000181A6E130 0x0000000181A6CF00-0x0000000181A6CFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RegionConfigId { get => default; set {} } // 0x0000000181A6C360-0x0000000181A6C400 0x0000000181A6EA00-0x0000000181A6EAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RegionShape { get => default; set {} } // 0x0000000181A6E560-0x0000000181A6E600 0x0000000181A6DF00-0x0000000181A6DFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float SphereRadius { get => default; set {} } // 0x0000000181A6DC90-0x0000000181A6DD70 0x0000000181A6DBD0-0x0000000181A6DC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector CubicSize { get => default; set {} } // 0x0000000181A6E1C0-0x0000000181A6E290 0x0000000181A6E3F0-0x0000000181A6E490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RegionSizeOneofCase RegionSizeCase { get => default; } // 0x0000000181A6E600-0x0000000181A6E660 

	// Nested types
	public enum RegionSizeOneofCase // TypeDefIndex: 25312
	{
		None = 0,
		SphereRadius = 100,
		CubicSize = 101
	}

	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25313
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25314
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3052
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerEyePointStateNotify() {} // 0x0000000181A6F230-0x0000000181A6F2A0
	static PlayerEyePointStateNotify() {} // 0x0000000181A6F170-0x0000000181A6F230

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerEyePointStateNotify Clone() => default; // 0x0000000181A6DFA0-0x0000000181A6E090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerEyePointStateNotify ShallowCopy() => default; // 0x0000000181A6D5E0-0x0000000181A6D680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181A6CC10-0x0000000181A6CCF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A6E320-0x0000000181A6E3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A6E490-0x0000000181A6E560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181A6CCF0-0x0000000181A6CE60
	public void resetRegionSize() {} // 0x0000000181A6C400-0x0000000181A6C530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearRegionSize() {} // 0x0000000181A6E6C0-0x0000000181A6E720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181A6D1C0-0x0000000181A6D290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerEyePointStateNotify other) => default; // 0x0000000181A6CFA0-0x0000000181A6D1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181A6D770-0x0000000181A6DA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181A6EB90-0x0000000181A6F170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181A6E720-0x0000000181A6E9B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181A6D290-0x0000000181A6D560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerEyePointStateNotify other) {} // 0x0000000181A6C950-0x0000000181A6CC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181A6C530-0x0000000181A6C7B0
}

