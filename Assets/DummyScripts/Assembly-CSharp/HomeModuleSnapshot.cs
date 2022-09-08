/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeModuleSnapshot : MessageBase, IMessage<HomeModuleSnapshot> // TypeDefIndex: 23408
{
	// Fields
	private static readonly MessageParser<HomeModuleSnapshot> _parser; // 0x00
	public const int ModuleIdFieldNumber = 1; // Metadata: 0x00B03F5F
	private uint moduleId_; // 0x18
	public const int CurRoomSceneIdFieldNumber = 2; // Metadata: 0x00B03F63
	private uint curRoomSceneId_; // 0x1C
	public const int SceneListFieldNumber = 3; // Metadata: 0x00B03F67
	private static readonly FieldCodec<HomeSceneSnapshot> _repeated_sceneList_codec; // 0x08
	private readonly RepeatedMessageField<HomeSceneSnapshot> sceneList_; // 0x20
	public const int WorldSceneBlockComfortValueListFieldNumber = 4; // Metadata: 0x00B03F6B
	private static readonly FieldCodec<uint> _repeated_worldSceneBlockComfortValueList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> worldSceneBlockComfortValueList_; // 0x28
	public const int RoomSceneComfortValueFieldNumber = 5; // Metadata: 0x00B03F6F
	private uint roomSceneComfortValue_; // 0x30
	public const int LimitedShopInfoFieldNumber = 6; // Metadata: 0x00B03F73
	private HomeLimitedShopInfo limitedShopInfo_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeModuleSnapshot> Parser { get => default; } // 0x00000001834371C0-0x0000000183437250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183436EB0-0x0000000183436F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183436A60-0x0000000183436AE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183435D00-0x0000000183435D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183437840-0x0000000183437930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001834374C0-0x0000000183437520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183436FE0-0x00000001834370D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001834377F0-0x0000000183437840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183436B80-0x0000000183436C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ModuleId { get => default; set {} } // 0x00000001834372E0-0x0000000183437380 0x0000000183437520-0x00000001834375C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurRoomSceneId { get => default; set {} } // 0x0000000183435990-0x0000000183435A30 0x0000000183436F40-0x0000000183436FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<HomeSceneSnapshot> SceneList { get => default; } // 0x0000000183435FB0-0x0000000183436010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> WorldSceneBlockComfortValueList { get => default; } // 0x0000000183435CA0-0x0000000183435D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RoomSceneComfortValue { get => default; set {} } // 0x00000001834362A0-0x0000000183436340 0x0000000183436340-0x00000001834363E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeLimitedShopInfo LimitedShopInfo { get => default; set {} } // 0x00000001834363E0-0x0000000183436480 0x00000001834369C0-0x0000000183436A60

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeModuleSnapshot() {} // 0x0000000183437E40-0x0000000183437EF0
	static HomeModuleSnapshot() {} // 0x0000000183437D10-0x0000000183437E40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeModuleSnapshot Clone() => default; // 0x00000001834370D0-0x00000001834371C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeModuleSnapshot ShallowCopy() => default; // 0x0000000183436AE0-0x0000000183436B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183436010-0x0000000183436090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183437380-0x0000000183437420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183437420-0x00000001834374C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183436090-0x00000001834362A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183436640-0x0000000183436710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeModuleSnapshot other) => default; // 0x0000000183436480-0x0000000183436640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183436C70-0x0000000183436EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183437930-0x0000000183437D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001834375C0-0x00000001834377F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183436710-0x00000001834369C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeModuleSnapshot other) {} // 0x0000000183435D60-0x0000000183435FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183435A30-0x0000000183435CA0
}

