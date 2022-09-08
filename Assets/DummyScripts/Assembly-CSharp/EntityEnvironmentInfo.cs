/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityEnvironmentInfo : MessageBase, IMessage<EntityEnvironmentInfo> // TypeDefIndex: 26051
{
	// Fields
	private static readonly MessageParser<EntityEnvironmentInfo> _parser; // 0x00
	public const int JsonClimateTypeFieldNumber = 1; // Metadata: 0x00B0AE3B
	private uint jsonClimateType_; // 0x18
	public const int ClimateAreaIdFieldNumber = 2; // Metadata: 0x00B0AE3F
	private uint climateAreaId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EntityEnvironmentInfo> Parser { get => default; } // 0x00000001832152A0-0x0000000183215330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183214F90-0x0000000183215020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183214C80-0x0000000183214D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001832145D0-0x0000000183214630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183215630-0x0000000183215720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183215460-0x00000001832154C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001832150C0-0x00000001832151B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001832155E0-0x0000000183215630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183214DA0-0x0000000183214E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint JsonClimateType { get => default; set {} } // 0x00000001832148C0-0x0000000183214960 0x0000000183215020-0x00000001832150C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ClimateAreaId { get => default; set {} } // 0x0000000183214630-0x00000001832146D0 0x0000000183215720-0x00000001832157C0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityEnvironmentInfo() {} // 0x0000000183215A80-0x0000000183215AE0
	static EntityEnvironmentInfo() {} // 0x00000001832159C0-0x0000000183215A80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityEnvironmentInfo Clone() => default; // 0x00000001832151B0-0x00000001832152A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityEnvironmentInfo ShallowCopy() => default; // 0x0000000183214D00-0x0000000183214DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183214800-0x0000000183214850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001832153C0-0x0000000183215410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183215410-0x0000000183215460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183214850-0x00000001832148C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183214960-0x0000000183214A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EntityEnvironmentInfo other) => default; // 0x0000000183214A30-0x0000000183214B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183214E90-0x0000000183214F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001832157C0-0x00000001832159C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001832154C0-0x00000001832155E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183214B50-0x0000000183214C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EntityEnvironmentInfo other) {} // 0x00000001832146D0-0x0000000183214800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001832144D0-0x00000001832145D0
}

