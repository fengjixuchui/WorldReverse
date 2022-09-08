/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LevelupCityRsp : MessageBase, IMessage<LevelupCityRsp> // TypeDefIndex: 25061
{
	// Fields
	private static readonly MessageParser<LevelupCityRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B07E43
	private int retcode_; // 0x18
	public const int SceneIdFieldNumber = 2; // Metadata: 0x00B07E47
	private uint sceneId_; // 0x1C
	public const int AreaIdFieldNumber = 3; // Metadata: 0x00B07E4B
	private uint areaId_; // 0x20
	public const int CityInfoFieldNumber = 4; // Metadata: 0x00B07E4F
	private CityInfo cityInfo_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<LevelupCityRsp> Parser { get => default; } // 0x00000001845AC910-0x00000001845AC9A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001845AC560-0x00000001845AC5F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001845AC170-0x00000001845AC1F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001845AB540-0x00000001845AB5A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001845ACD80-0x00000001845ACE70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001845ACB30-0x00000001845ACB90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001845AC690-0x00000001845AC780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001845ACD30-0x00000001845ACD80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001845AC290-0x00000001845AC380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001845AC030-0x00000001845AC0D0 0x00000001845ABB20-0x00000001845ABBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x00000001845ABA80-0x00000001845ABB20 0x00000001845AC0D0-0x00000001845AC170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AreaId { get => default; set {} } // 0x00000001845AB9E0-0x00000001845ABA80 0x00000001845AC5F0-0x00000001845AC690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityInfo CityInfo { get => default; set {} } // 0x00000001845AC870-0x00000001845AC910 0x00000001845AB5A0-0x00000001845AB640

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25062
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25063
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 256
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LevelupCityRsp() {} // 0x00000001845AD230-0x00000001845AD290
	static LevelupCityRsp() {} // 0x00000001845AD170-0x00000001845AD230

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LevelupCityRsp Clone() => default; // 0x00000001845AC780-0x00000001845AC870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public LevelupCityRsp ShallowCopy() => default; // 0x00000001845AC1F0-0x00000001845AC290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001845AB810-0x00000001845AB890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001845ACA30-0x00000001845ACAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001845ACAB0-0x00000001845ACB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001845AB890-0x00000001845AB9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001845ABD30-0x00000001845ABE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(LevelupCityRsp other) => default; // 0x00000001845ABBC0-0x00000001845ABD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001845AC380-0x00000001845AC560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001845ACE70-0x00000001845AD170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001845ACB90-0x00000001845ACD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001845ABE00-0x00000001845AC030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(LevelupCityRsp other) {} // 0x00000001845AB640-0x00000001845AB810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001845AB3C0-0x00000001845AB540
}

