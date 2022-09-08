/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeBlockArrangementInfo : MessageBase, IMessage<HomeBlockArrangementInfo> // TypeDefIndex: 23342
{
	// Fields
	private static readonly MessageParser<HomeBlockArrangementInfo> _parser; // 0x00
	public const int BlockIdFieldNumber = 1; // Metadata: 0x00B03CE3
	private uint blockId_; // 0x18
	public const int PersistentFurnitureListFieldNumber = 2; // Metadata: 0x00B03CE7
	private static readonly FieldCodec<HomeFurnitureData> _repeated_persistentFurnitureList_codec; // 0x08
	private readonly RepeatedMessageField<HomeFurnitureData> persistentFurnitureList_; // 0x20
	public const int DeployFurniureListFieldNumber = 3; // Metadata: 0x00B03CEB
	private static readonly FieldCodec<HomeFurnitureData> _repeated_deployFurniureList_codec; // 0x10
	private readonly RepeatedMessageField<HomeFurnitureData> deployFurniureList_; // 0x28
	public const int DeployNpcListFieldNumber = 4; // Metadata: 0x00B03CEF
	private static readonly FieldCodec<HomeNpcData> _repeated_deployNpcList_codec; // 0x18
	private readonly RepeatedMessageField<HomeNpcData> deployNpcList_; // 0x30
	public const int FurnitureSuiteListFieldNumber = 5; // Metadata: 0x00B03CF3
	private static readonly FieldCodec<HomeFurnitureSuiteData> _repeated_furnitureSuiteList_codec; // 0x20
	private readonly RepeatedMessageField<HomeFurnitureSuiteData> furnitureSuiteList_; // 0x38
	public const int DeployAnimalListFieldNumber = 6; // Metadata: 0x00B03CF7
	private static readonly FieldCodec<HomeAnimalData> _repeated_deployAnimalList_codec; // 0x28
	private readonly RepeatedMessageField<HomeAnimalData> deployAnimalList_; // 0x40
	public const int IsUnlockedFieldNumber = 7; // Metadata: 0x00B03CFB
	private bool isUnlocked_; // 0x48
	public const int ComfortValueFieldNumber = 8; // Metadata: 0x00B03CFF
	private uint comfortValue_; // 0x4C
	public const int WeekendDjinnInfoListFieldNumber = 9; // Metadata: 0x00B03D03
	private static readonly FieldCodec<WeekendDjinnInfo> _repeated_weekendDjinnInfoList_codec; // 0x30
	private readonly RepeatedMessageField<WeekendDjinnInfo> weekendDjinnInfoList_; // 0x50

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeBlockArrangementInfo> Parser { get => default; } // 0x0000000183BD1ED0-0x0000000183BD1F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183BD1AA0-0x0000000183BD1B30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183BD1470-0x0000000183BD14F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183BD07E0-0x0000000183BD0840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183BD2710-0x0000000183BD2800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183BD22D0-0x0000000183BD2330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183BD1B90-0x0000000183BD1C80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183BD26C0-0x0000000183BD2710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183BD1630-0x0000000183BD1720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BlockId { get => default; set {} } // 0x0000000183BD2230-0x0000000183BD22D0 0x0000000183BD2330-0x0000000183BD23D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<HomeFurnitureData> PersistentFurnitureList { get => default; } // 0x0000000183BD1C80-0x0000000183BD1CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<HomeFurnitureData> DeployFurniureList { get => default; } // 0x0000000183BD1B30-0x0000000183BD1B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<HomeNpcData> DeployNpcList { get => default; } // 0x0000000183BD1DD0-0x0000000183BD1E30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<HomeFurnitureSuiteData> FurnitureSuiteList { get => default; } // 0x0000000183BD1A40-0x0000000183BD1AA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<HomeAnimalData> DeployAnimalList { get => default; } // 0x0000000183BD1940-0x0000000183BD19A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsUnlocked { get => default; set {} } // 0x0000000183BD0DE0-0x0000000183BD0E80 0x0000000183BD1590-0x0000000183BD1630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ComfortValue { get => default; set {} } // 0x0000000183BD19A0-0x0000000183BD1A40 0x0000000183BD1E30-0x0000000183BD1ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<WeekendDjinnInfo> WeekendDjinnInfoList { get => default; } // 0x0000000183BD0B00-0x0000000183BD0B60 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeBlockArrangementInfo() {} // 0x0000000183BD2FC0-0x0000000183BD3100
	static HomeBlockArrangementInfo() {} // 0x0000000183BD2D40-0x0000000183BD2FC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeBlockArrangementInfo Clone() => default; // 0x0000000183BD1CE0-0x0000000183BD1DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeBlockArrangementInfo ShallowCopy() => default; // 0x0000000183BD14F0-0x0000000183BD1590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183BD0AB0-0x0000000183BD0B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183BD1FF0-0x0000000183BD2110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183BD2110-0x0000000183BD2230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183BD0B60-0x0000000183BD0DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183BD10E0-0x0000000183BD11B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeBlockArrangementInfo other) => default; // 0x0000000183BD0E80-0x0000000183BD10E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183BD1720-0x0000000183BD1940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183BD2800-0x0000000183BD2D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183BD23D0-0x0000000183BD26C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183BD11B0-0x0000000183BD1470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeBlockArrangementInfo other) {} // 0x0000000183BD0840-0x0000000183BD0AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183BD0440-0x0000000183BD07E0
}

