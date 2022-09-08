/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MaterialDeleteInfo : MessageBase, IMessage<MaterialDeleteInfo> // TypeDefIndex: 25974
{
	// Fields
	private static readonly MessageParser<MaterialDeleteInfo> _parser; // 0x00
	public const int HasDeleteConfigFieldNumber = 1; // Metadata: 0x00B0A89F
	private bool hasDeleteConfig_; // 0x18
	public const int CountDownDeleteFieldNumber = 2; // Metadata: 0x00B0A8A3
	public const int DateDeleteFieldNumber = 3; // Metadata: 0x00B0A8A7
	public const int DelayWeekCountDownDeleteFieldNumber = 4; // Metadata: 0x00B0A8AB
	private object deleteInfo_; // 0x20
	private DeleteInfoOneofCase deleteInfoCase_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MaterialDeleteInfo> Parser { get => default; } // 0x00000001865837B0-0x0000000186583840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000186583540-0x00000001865835D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001865831C0-0x0000000186583240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001865821E0-0x0000000186582240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000186583E90-0x0000000186583F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000186583BB0-0x0000000186583C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001865835D0-0x00000001865836C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000186583E40-0x0000000186583E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001865832E0-0x00000001865833D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool HasDeleteConfig { get => default; set {} } // 0x00000001865828D0-0x0000000186582970 0x0000000186582970-0x0000000186582A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.CountDownDelete CountDownDelete { get => default; set {} } // 0x00000001865822E0-0x00000001865823B0 0x0000000186583DA0-0x0000000186583E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.DateTimeDelete DateDelete { get => default; set {} } // 0x0000000186582410-0x00000001865824E0 0x0000000186583F80-0x0000000186584020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.DelayWeekCountDownDelete DelayWeekCountDownDelete { get => default; set {} } // 0x00000001865830F0-0x00000001865831C0 0x0000000186582240-0x00000001865822E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DeleteInfoOneofCase DeleteInfoCase { get => default; } // 0x00000001865823B0-0x0000000186582410 

	// Nested types
	public enum DeleteInfoOneofCase // TypeDefIndex: 25975
	{
		None = 0,
		CountDownDelete = 2,
		DateDelete = 3,
		DelayWeekCountDownDelete = 4
	}

	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25976
	{
		// Nested types
		public sealed class CountDownDelete : MessageBase, IMessage<CountDownDelete> // TypeDefIndex: 25977
		{
			// Fields
			private static readonly MessageParser<CountDownDelete> _parser; // 0x00
			public const int DeleteTimeNumMapFieldNumber = 1; // Metadata: 0x00B0A8BF
			private static readonly MapField<uint, uint> _map_deleteTimeNumMap_codec; // 0x08
			private readonly MapField<uint, uint> deleteTimeNumMap_; // 0x18
			public const int ConfigCountDownTimeFieldNumber = 2; // Metadata: 0x00B0A8C3
			private uint configCountDownTime_; // 0x20

			// Properties
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageParser<CountDownDelete> Parser { get => default; } // 0x00000001857A37E0-0x00000001857A3870 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001857A3570-0x00000001857A3600 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override MessageDescriptor Descriptor { get => default; } // 0x00000001857A3230-0x00000001857A32B0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticClassName { get => default; } // 0x00000001857A2B30-0x00000001857A2B90 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ClassName { get => default; } // 0x00000001857A3C30-0x00000001857A3D20 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticFullClassName { get => default; } // 0x00000001857A3A40-0x00000001857A3AA0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string FullClassName { get => default; } // 0x00000001857A3600-0x00000001857A36F0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static ushort StaticCmdId { get => default; } // 0x00000001857A3BE0-0x00000001857A3C30 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override ushort CmdId { get => default; } // 0x00000001857A3350-0x00000001857A3440 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public MapField<uint, uint> DeleteTimeNumMap { get => default; } // 0x00000001857A2AD0-0x00000001857A2B30 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public uint ConfigCountDownTime { get => default; set {} } // 0x00000001857A2DE0-0x00000001857A2E80 0x00000001857A39A0-0x00000001857A3A40

			// Constructors
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public CountDownDelete() {} // 0x00000001857A4030-0x00000001857A40C0
			static CountDownDelete() {} // 0x00000001857A3F00-0x00000001857A4030

			// Methods
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public CountDownDelete Clone() => default; // 0x00000001857A36F0-0x00000001857A37E0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public CountDownDelete ShallowCopy() => default; // 0x00000001857A32B0-0x00000001857A3350
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalSetInPool(bool value) {} // 0x00000001857A2CC0-0x00000001857A2D10
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001857A3900-0x00000001857A3950
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001857A3950-0x00000001857A39A0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void Reset() {} // 0x00000001857A2D10-0x00000001857A2DE0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override bool Equals(object other) => default; // 0x00000001857A3020-0x00000001857A30F0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public bool Equals(CountDownDelete other) => default; // 0x00000001857A2E80-0x00000001857A3020
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int GetHashCode() => default; // 0x00000001857A3440-0x00000001857A3570
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ToString() => default; // 0x00000001857A3D20-0x00000001857A3F00
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void WriteTo(CodedOutputStream output) {} // 0x00000001857A3AA0-0x00000001857A3BE0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int CalculateSize() => default; // 0x00000001857A30F0-0x00000001857A3230
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public void CopyFrom(CountDownDelete other) {} // 0x00000001857A2B90-0x00000001857A2CC0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void MergeFrom(CodedInputStream input) {} // 0x00000001857A2970-0x00000001857A2AD0
		}

		public sealed class DateTimeDelete : MessageBase, IMessage<DateTimeDelete> // TypeDefIndex: 25978
		{
			// Fields
			private static readonly MessageParser<DateTimeDelete> _parser; // 0x00
			public const int DeleteTimeFieldNumber = 1; // Metadata: 0x00B0A8C7
			private uint deleteTime_; // 0x18

			// Properties
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageParser<DateTimeDelete> Parser { get => default; } // 0x00000001857A4C90-0x00000001857A4D20 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001857A4A20-0x00000001857A4AB0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override MessageDescriptor Descriptor { get => default; } // 0x00000001857A4730-0x00000001857A47B0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticClassName { get => default; } // 0x00000001857A41A0-0x00000001857A4200 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ClassName { get => default; } // 0x00000001857A4FE0-0x00000001857A50D0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticFullClassName { get => default; } // 0x00000001857A4E50-0x00000001857A4EB0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string FullClassName { get => default; } // 0x00000001857A4AB0-0x00000001857A4BA0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static ushort StaticCmdId { get => default; } // 0x00000001857A4F90-0x00000001857A4FE0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override ushort CmdId { get => default; } // 0x00000001857A4850-0x00000001857A4940 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public uint DeleteTime { get => default; set {} } // 0x00000001857A50D0-0x00000001857A5170 0x00000001857A4360-0x00000001857A4400

			// Constructors
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public DateTimeDelete() {} // 0x00000001857A53A0-0x00000001857A5C80
			static DateTimeDelete() {} // 0x00000001857A52E0-0x00000001857A53A0

			// Methods
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public DateTimeDelete Clone() => default; // 0x00000001857A4BA0-0x00000001857A4C90
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public DateTimeDelete ShallowCopy() => default; // 0x00000001857A47B0-0x00000001857A4850
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalSetInPool(bool value) {} // 0x00000001857A4310-0x00000001857A4360
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001857A4DB0-0x00000001857A4E00
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001857A4E00-0x00000001857A4E50
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void Reset() {} // 0x00000001857A4400-0x00000001857A4470
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override bool Equals(object other) => default; // 0x00000001857A4570-0x00000001857A4640
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public bool Equals(DateTimeDelete other) => default; // 0x00000001857A4470-0x00000001857A4570
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int GetHashCode() => default; // 0x00000001857A4940-0x00000001857A4A20
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ToString() => default; // 0x00000001857A5170-0x00000001857A52E0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void WriteTo(CodedOutputStream output) {} // 0x00000001857A4EB0-0x00000001857A4F90
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int CalculateSize() => default; // 0x00000001857A4640-0x00000001857A4730
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public void CopyFrom(DateTimeDelete other) {} // 0x00000001857A4200-0x00000001857A4310
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void MergeFrom(CodedInputStream input) {} // 0x00000001857A40C0-0x00000001857A41A0
		}

		public sealed class DelayWeekCountDownDelete : MessageBase, IMessage<DelayWeekCountDownDelete> // TypeDefIndex: 25979
		{
			// Fields
			private static readonly MessageParser<DelayWeekCountDownDelete> _parser; // 0x00
			public const int DeleteTimeNumMapFieldNumber = 1; // Metadata: 0x00B0A8CB
			private static readonly MapField<uint, uint> _map_deleteTimeNumMap_codec; // 0x08
			private readonly MapField<uint, uint> deleteTimeNumMap_; // 0x18
			public const int ConfigDelayWeekFieldNumber = 2; // Metadata: 0x00B0A8CF
			private uint configDelayWeek_; // 0x20
			public const int ConfigCountDownTimeFieldNumber = 3; // Metadata: 0x00B0A8D3
			private uint configCountDownTime_; // 0x24

			// Properties
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageParser<DelayWeekCountDownDelete> Parser { get => default; } // 0x000000018579F650-0x000000018579F6E0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018579F3E0-0x000000018579F470 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override MessageDescriptor Descriptor { get => default; } // 0x000000018579EFD0-0x000000018579F050 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticClassName { get => default; } // 0x000000018579E820-0x000000018579E880 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ClassName { get => default; } // 0x000000018579FB80-0x000000018579FC70 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticFullClassName { get => default; } // 0x000000018579F8B0-0x000000018579F910 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string FullClassName { get => default; } // 0x000000018579F470-0x000000018579F560 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static ushort StaticCmdId { get => default; } // 0x000000018579FA90-0x000000018579FAE0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override ushort CmdId { get => default; } // 0x000000018579F0F0-0x000000018579F1E0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public MapField<uint, uint> DeleteTimeNumMap { get => default; } // 0x000000018579E7C0-0x000000018579E820 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public uint ConfigDelayWeek { get => default; set {} } // 0x000000018579F340-0x000000018579F3E0 0x000000018579FAE0-0x000000018579FB80
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public uint ConfigCountDownTime { get => default; set {} } // 0x000000018579EB10-0x000000018579EBB0 0x000000018579F810-0x000000018579F8B0

			// Constructors
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public DelayWeekCountDownDelete() {} // 0x00000001857A0010-0x00000001857A00A0
			static DelayWeekCountDownDelete() {} // 0x000000018579FEE0-0x00000001857A0010

			// Methods
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public DelayWeekCountDownDelete Clone() => default; // 0x000000018579F560-0x000000018579F650
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public DelayWeekCountDownDelete ShallowCopy() => default; // 0x000000018579F050-0x000000018579F0F0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalSetInPool(bool value) {} // 0x000000018579E9E0-0x000000018579EA30
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018579F770-0x000000018579F7C0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018579F7C0-0x000000018579F810
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void Reset() {} // 0x000000018579EA30-0x000000018579EB10
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override bool Equals(object other) => default; // 0x000000018579EBB0-0x000000018579EC80
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public bool Equals(DelayWeekCountDownDelete other) => default; // 0x000000018579EC80-0x000000018579EE40
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int GetHashCode() => default; // 0x000000018579F1E0-0x000000018579F340
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ToString() => default; // 0x000000018579FC70-0x000000018579FEE0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void WriteTo(CodedOutputStream output) {} // 0x000000018579F910-0x000000018579FA90
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int CalculateSize() => default; // 0x000000018579EE40-0x000000018579EFD0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public void CopyFrom(DelayWeekCountDownDelete other) {} // 0x000000018579E880-0x000000018579E9E0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void MergeFrom(CodedInputStream input) {} // 0x000000018579E640-0x000000018579E7C0
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MaterialDeleteInfo() {} // 0x0000000186584420-0x0000000186584490
	static MaterialDeleteInfo() {} // 0x0000000186584360-0x0000000186584420

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MaterialDeleteInfo Clone() => default; // 0x00000001865836C0-0x00000001865837B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MaterialDeleteInfo ShallowCopy() => default; // 0x0000000186583240-0x00000001865832E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001865826E0-0x0000000186582860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001865838D0-0x0000000186583A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000186583A40-0x0000000186583BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000186582860-0x00000001865828D0
	public void resetDeleteInfo() {} // 0x0000000186582E70-0x00000001865830F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearDeleteInfo() {} // 0x0000000186582C90-0x0000000186582CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000186582BC0-0x0000000186582C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MaterialDeleteInfo other) => default; // 0x0000000186582A10-0x0000000186582BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001865833D0-0x0000000186583540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000186584020-0x0000000186584360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000186583C10-0x0000000186583DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000186582CF0-0x0000000186582E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MaterialDeleteInfo other) {} // 0x00000001865824E0-0x00000001865826E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000186581F60-0x00000001865821E0
}

