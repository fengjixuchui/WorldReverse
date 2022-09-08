/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeSceneArrangementInfo : MessageBase, IMessage<HomeSceneArrangementInfo> // TypeDefIndex: 23343
{
	// Fields
	private static readonly MessageParser<HomeSceneArrangementInfo> _parser; // 0x00
	public const int SceneIdFieldNumber = 1; // Metadata: 0x00B03D07
	private uint sceneId_; // 0x18
	public const int BlockArrangementInfoListFieldNumber = 2; // Metadata: 0x00B03D0B
	private static readonly FieldCodec<HomeBlockArrangementInfo> _repeated_blockArrangementInfoList_codec; // 0x08
	private readonly RepeatedMessageField<HomeBlockArrangementInfo> blockArrangementInfoList_; // 0x20
	public const int IsSetBornPosFieldNumber = 3; // Metadata: 0x00B03D0F
	private bool isSetBornPos_; // 0x28
	public const int BornPosFieldNumber = 4; // Metadata: 0x00B03D13
	private Vector bornPos_; // 0x30
	public const int BornRotFieldNumber = 5; // Metadata: 0x00B03D17
	private Vector bornRot_; // 0x38
	public const int DoorListFieldNumber = 7; // Metadata: 0x00B03D1B
	private static readonly FieldCodec<HomeFurnitureData> _repeated_doorList_codec; // 0x10
	private readonly RepeatedMessageField<HomeFurnitureData> doorList_; // 0x40
	public const int StairListFieldNumber = 8; // Metadata: 0x00B03D1F
	private static readonly FieldCodec<HomeFurnitureData> _repeated_stairList_codec; // 0x18
	private readonly RepeatedMessageField<HomeFurnitureData> stairList_; // 0x48
	public const int MainHouseFieldNumber = 9; // Metadata: 0x00B03D23
	private HomeFurnitureData mainHouse_; // 0x50
	public const int ComfortValueFieldNumber = 10; // Metadata: 0x00B03D27
	private uint comfortValue_; // 0x58
	public const int DjinnPosFieldNumber = 11; // Metadata: 0x00B03D2B
	private Vector djinnPos_; // 0x60
	public const int TmpVersionFieldNumber = 12; // Metadata: 0x00B03D2F
	private uint tmpVersion_; // 0x68

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeSceneArrangementInfo> Parser { get => default; } // 0x00000001853B6680-0x00000001853B6710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001853B62D0-0x00000001853B6360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001853B5BC0-0x00000001853B5C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001853B4360-0x00000001853B43C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001853B7160-0x00000001853B7250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001853B6CA0-0x00000001853B6D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001853B6400-0x00000001853B64F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001853B7110-0x00000001853B7160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001853B5CE0-0x00000001853B5DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x00000001853B4F80-0x00000001853B5020 0x00000001853B5A80-0x00000001853B5B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<HomeBlockArrangementInfo> BlockArrangementInfoList { get => default; } // 0x00000001853B69F0-0x00000001853B6A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSetBornPos { get => default; set {} } // 0x00000001853B4860-0x00000001853B4900 0x00000001853B6B60-0x00000001853B6C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector BornPos { get => default; set {} } // 0x00000001853B6840-0x00000001853B68E0 0x00000001853B6C00-0x00000001853B6CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector BornRot { get => default; set {} } // 0x00000001853B5B20-0x00000001853B5BC0 0x00000001853B53A0-0x00000001853B5440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<HomeFurnitureData> DoorList { get => default; } // 0x00000001853B5980-0x00000001853B59E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<HomeFurnitureData> StairList { get => default; } // 0x00000001853B4900-0x00000001853B4960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeFurnitureData MainHouse { get => default; set {} } // 0x00000001853B7070-0x00000001853B7110 0x00000001853B4EE0-0x00000001853B4F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ComfortValue { get => default; set {} } // 0x00000001853B6230-0x00000001853B62D0 0x00000001853B65E0-0x00000001853B6680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector DjinnPos { get => default; set {} } // 0x00000001853B43C0-0x00000001853B4460 0x00000001853B6360-0x00000001853B6400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TmpVersion { get => default; set {} } // 0x00000001853B6710-0x00000001853B67B0 0x00000001853B59E0-0x00000001853B5A80

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeSceneArrangementInfo() {} // 0x00000001853B7A10-0x00000001853B7AE0
	static HomeSceneArrangementInfo() {} // 0x00000001853B7880-0x00000001853B7A10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeSceneArrangementInfo Clone() => default; // 0x00000001853B64F0-0x00000001853B65E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeSceneArrangementInfo ShallowCopy() => default; // 0x00000001853B5C40-0x00000001853B5CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001853B4960-0x00000001853B4A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001853B68E0-0x00000001853B69F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001853B6A50-0x00000001853B6B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001853B4A20-0x00000001853B4EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001853B52D0-0x00000001853B53A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeSceneArrangementInfo other) => default; // 0x00000001853B5020-0x00000001853B52D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001853B5DD0-0x00000001853B6230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001853B7250-0x00000001853B7880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001853B6D00-0x00000001853B7070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001853B5440-0x00000001853B5980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeSceneArrangementInfo other) {} // 0x00000001853B4460-0x00000001853B4860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001853B3F90-0x00000001853B4360
}

