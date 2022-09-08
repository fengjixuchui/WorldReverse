/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetActivityScheduleRsp : MessageBase, IMessage<GetActivityScheduleRsp> // TypeDefIndex: 21853
{
	// Fields
	private static readonly MessageParser<GetActivityScheduleRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B00243
	private int retcode_; // 0x18
	public const int ActivityScheduleListFieldNumber = 2; // Metadata: 0x00B00247
	private static readonly FieldCodec<ActivityScheduleInfo> _repeated_activityScheduleList_codec; // 0x08
	private readonly RepeatedMessageField<ActivityScheduleInfo> activityScheduleList_; // 0x20
	public const int RemainFlySeaLampNumFieldNumber = 3; // Metadata: 0x00B0024B
	private uint remainFlySeaLampNum_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetActivityScheduleRsp> Parser { get => default; } // 0x000000018448AC10-0x000000018448ACA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018448A8A0-0x000000018448A930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018448A560-0x000000018448A5E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184489D40-0x0000000184489DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018448B120-0x000000018448B210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018448AE50-0x000000018448AEB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018448AA30-0x000000018448AB20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018448B0D0-0x000000018448B120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018448A680-0x000000018448A770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018448A4C0-0x000000018448A560 0x000000018448A070-0x000000018448A110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ActivityScheduleInfo> ActivityScheduleList { get => default; } // 0x000000018448A930-0x000000018448A990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RemainFlySeaLampNum { get => default; set {} } // 0x000000018448A990-0x000000018448AA30 0x000000018448AEB0-0x000000018448AF50

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21854
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21855
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2002
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetActivityScheduleRsp() {} // 0x000000018448B590-0x000000018448B620
	static GetActivityScheduleRsp() {} // 0x000000018448B480-0x000000018448B590

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetActivityScheduleRsp Clone() => default; // 0x000000018448AB20-0x000000018448AC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetActivityScheduleRsp ShallowCopy() => default; // 0x000000018448A5E0-0x000000018448A680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184489F30-0x0000000184489F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018448AD30-0x000000018448ADC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018448ADC0-0x000000018448AE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184489F80-0x000000018448A070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018448A260-0x000000018448A330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetActivityScheduleRsp other) => default; // 0x000000018448A110-0x000000018448A260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018448A770-0x000000018448A8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018448B210-0x000000018448B480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018448AF50-0x000000018448B0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018448A330-0x000000018448A4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetActivityScheduleRsp other) {} // 0x0000000184489DA0-0x0000000184489F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184489BC0-0x0000000184489D40
}

