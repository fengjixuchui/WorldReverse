/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneWeatherForcastRsp : MessageBase, IMessage<SceneWeatherForcastRsp> // TypeDefIndex: 25216
{
	// Fields
	private static readonly MessageParser<SceneWeatherForcastRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B083A7
	private int retcode_; // 0x18
	public const int NextClimateTimeFieldNumber = 2; // Metadata: 0x00B083AB
	private ulong nextClimateTime_; // 0x20
	public const int ForcastClimateListFieldNumber = 3; // Metadata: 0x00B083AF
	private static readonly FieldCodec<uint> _repeated_forcastClimateList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> forcastClimateList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneWeatherForcastRsp> Parser { get => default; } // 0x0000000181BAB620-0x0000000181BAB6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181BAB2B0-0x0000000181BAB340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181BAAF70-0x0000000181BAAFF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181BAA710-0x0000000181BAA770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181BABA10-0x0000000181BABB00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181BAB7E0-0x0000000181BAB840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181BAB440-0x0000000181BAB530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181BAB9C0-0x0000000181BABA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181BAB090-0x0000000181BAB180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181BAAED0-0x0000000181BAAF70 0x0000000181BAA9F0-0x0000000181BAAA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong NextClimateTime { get => default; set {} } // 0x0000000181BAB3A0-0x0000000181BAB440 0x0000000181BAACA0-0x0000000181BAAD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ForcastClimateList { get => default; } // 0x0000000181BAB340-0x0000000181BAB3A0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25217
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25218
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3006
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneWeatherForcastRsp() {} // 0x0000000181BABE50-0x0000000181BABEE0
	static SceneWeatherForcastRsp() {} // 0x0000000181BABD70-0x0000000181BABE50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneWeatherForcastRsp Clone() => default; // 0x0000000181BAB530-0x0000000181BAB620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneWeatherForcastRsp ShallowCopy() => default; // 0x0000000181BAAFF0-0x0000000181BAB090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181BAA8D0-0x0000000181BAA920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181BAB740-0x0000000181BAB790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181BAB790-0x0000000181BAB7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181BAA920-0x0000000181BAA9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181BAABD0-0x0000000181BAACA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneWeatherForcastRsp other) => default; // 0x0000000181BAAA90-0x0000000181BAABD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181BAB180-0x0000000181BAB2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181BABB00-0x0000000181BABD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181BAB840-0x0000000181BAB9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181BAAD40-0x0000000181BAAED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneWeatherForcastRsp other) {} // 0x0000000181BAA770-0x0000000181BAA8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181BAA590-0x0000000181BAA710
}

