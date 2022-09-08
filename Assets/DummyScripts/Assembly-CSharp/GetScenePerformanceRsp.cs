/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetScenePerformanceRsp : MessageBase, IMessage<GetScenePerformanceRsp> // TypeDefIndex: 25349
{
	// Fields
	private static readonly MessageParser<GetScenePerformanceRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0882F
	private int retcode_; // 0x18
	public const int PosFieldNumber = 2; // Metadata: 0x00B08833
	private Vector pos_; // 0x20
	public const int GroupNumFieldNumber = 3; // Metadata: 0x00B08837
	private uint groupNum_; // 0x28
	public const int EntityNumFieldNumber = 4; // Metadata: 0x00B0883B
	private uint entityNum_; // 0x2C
	public const int DynamicGroupNumFieldNumber = 5; // Metadata: 0x00B0883F
	private uint dynamicGroupNum_; // 0x30
	public const int MonsterNumFieldNumber = 6; // Metadata: 0x00B08843
	private uint monsterNum_; // 0x34
	public const int GadgetNumFieldNumber = 7; // Metadata: 0x00B08847
	private uint gadgetNum_; // 0x38
	public const int GatherNumFieldNumber = 8; // Metadata: 0x00B0884B
	private uint gatherNum_; // 0x3C
	public const int GatherNumInsightFieldNumber = 9; // Metadata: 0x00B0884F
	private uint gatherNumInsight_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetScenePerformanceRsp> Parser { get => default; } // 0x0000000182C0AB30-0x0000000182C0ABC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182C0A820-0x0000000182C0A8B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182C0A0E0-0x0000000182C0A160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182C09080-0x0000000182C090E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182C0B2B0-0x0000000182C0B3A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182C0AE90-0x0000000182C0AEF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182C0A950-0x0000000182C0AA40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182C0B260-0x0000000182C0B2B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182C0A340-0x0000000182C0A430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182C0A040-0x0000000182C0A0E0 0x0000000182C098A0-0x0000000182C09940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x0000000182C0AD50-0x0000000182C0ADF0 0x0000000182C0B1C0-0x0000000182C0B260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GroupNum { get => default; set {} } // 0x0000000182C0A8B0-0x0000000182C0A950 0x0000000182C09220-0x0000000182C092C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityNum { get => default; set {} } // 0x0000000182C0A780-0x0000000182C0A820 0x0000000182C0B3A0-0x0000000182C0B440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DynamicGroupNum { get => default; set {} } // 0x0000000182C0A160-0x0000000182C0A200 0x0000000182C0B440-0x0000000182C0B4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MonsterNum { get => default; set {} } // 0x0000000182C0A6E0-0x0000000182C0A780 0x0000000182C092C0-0x0000000182C09360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetNum { get => default; set {} } // 0x0000000182C0ADF0-0x0000000182C0AE90 0x0000000182C095F0-0x0000000182C09690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GatherNum { get => default; set {} } // 0x0000000182C09940-0x0000000182C099E0 0x0000000182C0A200-0x0000000182C0A2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GatherNumInsight { get => default; set {} } // 0x0000000182C09180-0x0000000182C09220 0x0000000182C090E0-0x0000000182C09180

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25350
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25351
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3064
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetScenePerformanceRsp() {} // 0x0000000182C0BB60-0x0000000182C0BBC0
	static GetScenePerformanceRsp() {} // 0x0000000182C0BAA0-0x0000000182C0BB60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetScenePerformanceRsp Clone() => default; // 0x0000000182C0AA40-0x0000000182C0AB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetScenePerformanceRsp ShallowCopy() => default; // 0x0000000182C0A2A0-0x0000000182C0A340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182C09690-0x0000000182C09710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C0AC50-0x0000000182C0ACD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C0ACD0-0x0000000182C0AD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182C09710-0x0000000182C098A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182C09BE0-0x0000000182C09CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetScenePerformanceRsp other) => default; // 0x0000000182C099E0-0x0000000182C09BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182C0A430-0x0000000182C0A6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182C0B4E0-0x0000000182C0BAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182C0AEF0-0x0000000182C0B1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182C09CB0-0x0000000182C0A040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetScenePerformanceRsp other) {} // 0x0000000182C09360-0x0000000182C095F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182C08E80-0x0000000182C09080
}

