/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeSceneSnapshot : MessageBase, IMessage<HomeSceneSnapshot> // TypeDefIndex: 23407
{
	// Fields
	private static readonly MessageParser<HomeSceneSnapshot> _parser; // 0x00
	public const int SceneIdFieldNumber = 1; // Metadata: 0x00B03F4B
	private uint sceneId_; // 0x18
	public const int DeployNpcListFieldNumber = 4; // Metadata: 0x00B03F4F
	private static readonly FieldCodec<HomeNpcData> _repeated_deployNpcList_codec; // 0x08
	private readonly RepeatedMessageField<HomeNpcData> deployNpcList_; // 0x20
	public const int FurnitureSuiteListFieldNumber = 5; // Metadata: 0x00B03F53
	private static readonly FieldCodec<HomeFurnitureSuiteData> _repeated_furnitureSuiteList_codec; // 0x10
	private readonly RepeatedMessageField<HomeFurnitureSuiteData> furnitureSuiteList_; // 0x28
	public const int MainHouseFieldNumber = 9; // Metadata: 0x00B03F57
	private HomeFurnitureData mainHouse_; // 0x30
	public const int DjinnPosFieldNumber = 11; // Metadata: 0x00B03F5B
	private Vector djinnPos_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeSceneSnapshot> Parser { get => default; } // 0x0000000182BA8CE0-0x0000000182BA8D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182BA8970-0x0000000182BA8A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182BA8490-0x0000000182BA8510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182BA7690-0x0000000182BA76F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182BA92E0-0x0000000182BA93D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182BA8FA0-0x0000000182BA9000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182BA8AA0-0x0000000182BA8B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182BA9290-0x0000000182BA92E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182BA85B0-0x0000000182BA86A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x0000000182BA7DE0-0x0000000182BA7E80 0x0000000182BA83F0-0x0000000182BA8490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<HomeNpcData> DeployNpcList { get => default; } // 0x0000000182BA8C80-0x0000000182BA8CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<HomeFurnitureSuiteData> FurnitureSuiteList { get => default; } // 0x0000000182BA8910-0x0000000182BA8970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeFurnitureData MainHouse { get => default; set {} } // 0x0000000182BA91F0-0x0000000182BA9290 0x0000000182BA7D40-0x0000000182BA7DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector DjinnPos { get => default; set {} } // 0x0000000182BA76F0-0x0000000182BA7790 0x0000000182BA8A00-0x0000000182BA8AA0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeSceneSnapshot() {} // 0x0000000182BA9870-0x0000000182BA9920
	static HomeSceneSnapshot() {} // 0x0000000182BA9710-0x0000000182BA9870

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeSceneSnapshot Clone() => default; // 0x0000000182BA8B90-0x0000000182BA8C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeSceneSnapshot ShallowCopy() => default; // 0x0000000182BA8510-0x0000000182BA85B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182BA7A00-0x0000000182BA7A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182BA8E00-0x0000000182BA8ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182BA8ED0-0x0000000182BA8FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182BA7A90-0x0000000182BA7D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182BA8040-0x0000000182BA8110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeSceneSnapshot other) => default; // 0x0000000182BA7E80-0x0000000182BA8040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182BA86A0-0x0000000182BA8910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182BA93D0-0x0000000182BA9710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182BA9000-0x0000000182BA91F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182BA8110-0x0000000182BA83F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeSceneSnapshot other) {} // 0x0000000182BA7790-0x0000000182BA7A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182BA7420-0x0000000182BA7690
}

