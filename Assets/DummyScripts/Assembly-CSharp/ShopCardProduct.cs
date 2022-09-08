/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ShopCardProduct : MessageBase, IMessage<ShopCardProduct> // TypeDefIndex: 26095
{
	// Fields
	private static readonly MessageParser<ShopCardProduct> _parser; // 0x00
	public const int ProductIdFieldNumber = 1; // Metadata: 0x00B0B1CF
	private string productId_; // 0x18
	public const int PriceTierFieldNumber = 2; // Metadata: 0x00B0B1D3
	private string priceTier_; // 0x20
	public const int McoinBaseFieldNumber = 3; // Metadata: 0x00B0B1D7
	private uint mcoinBase_; // 0x28
	public const int HcoinPerDayFieldNumber = 4; // Metadata: 0x00B0B1DB
	private uint hcoinPerDay_; // 0x2C
	public const int DaysFieldNumber = 5; // Metadata: 0x00B0B1DF
	private uint days_; // 0x30
	public const int RemainRewardDaysFieldNumber = 6; // Metadata: 0x00B0B1E3
	private uint remainRewardDays_; // 0x34
	public const int CardProductTypeFieldNumber = 7; // Metadata: 0x00B0B1E7
	private uint cardProductType_; // 0x38
	public const int ResinCardFieldNumber = 101; // Metadata: 0x00B0B1EB
	private object extraCardData_; // 0x40
	private ExtraCardDataOneofCase extraCardDataCase_; // 0x48

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ShopCardProduct> Parser { get => default; } // 0x0000000183B54AC0-0x0000000183B54B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183B542E0-0x0000000183B54370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183B53D20-0x0000000183B53DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183B52E70-0x0000000183B52ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183B552A0-0x0000000183B55390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183B54E00-0x0000000183B54E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183B54510-0x0000000183B54600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183B55250-0x0000000183B552A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183B53E40-0x0000000183B53F30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ProductId { get => default; set {} } // 0x0000000183B546F0-0x0000000183B54790 0x0000000183B54830-0x0000000183B548E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string PriceTier { get => default; set {} } // 0x0000000183B54980-0x0000000183B54A20 0x0000000183B53620-0x0000000183B536D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint McoinBase { get => default; set {} } // 0x0000000183B541A0-0x0000000183B54240 0x0000000183B54470-0x0000000183B54510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint HcoinPerDay { get => default; set {} } // 0x0000000183B54A20-0x0000000183B54AC0 0x0000000183B54240-0x0000000183B542E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Days { get => default; set {} } // 0x0000000183B52ED0-0x0000000183B52F70 0x0000000183B54790-0x0000000183B54830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RemainRewardDays { get => default; set {} } // 0x0000000183B548E0-0x0000000183B54980 0x0000000183B53220-0x0000000183B532C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CardProductType { get => default; set {} } // 0x0000000183B54CA0-0x0000000183B54D40 0x0000000183B53580-0x0000000183B53620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.ResinCard ResinCard { get => default; set {} } // 0x0000000183B534B0-0x0000000183B53580 0x0000000183B543D0-0x0000000183B54470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExtraCardDataOneofCase ExtraCardDataCase { get => default; } // 0x0000000183B54370-0x0000000183B543D0 

	// Nested types
	public enum ExtraCardDataOneofCase // TypeDefIndex: 26096
	{
		None = 0,
		ResinCard = 101
	}

	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 26097
	{
		// Nested types
		public sealed class ResinCard : MessageBase, IMessage<ResinCard> // TypeDefIndex: 26098
		{
			// Fields
			private static readonly MessageParser<ResinCard> _parser; // 0x00
			public const int BaseItemListFieldNumber = 1; // Metadata: 0x00B0B1F7
			private static readonly FieldCodec<ItemParam> _repeated_baseItemList_codec; // 0x08
			private readonly RepeatedMessageField<ItemParam> baseItemList_; // 0x18
			public const int PerDayItemListFieldNumber = 2; // Metadata: 0x00B0B1FB
			private static readonly FieldCodec<ItemParam> _repeated_perDayItemList_codec; // 0x10
			private readonly RepeatedMessageField<ItemParam> perDayItemList_; // 0x20

			// Properties
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageParser<ResinCard> Parser { get => default; } // 0x0000000183B37070-0x0000000183B37100 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183B36D40-0x0000000183B36DD0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override MessageDescriptor Descriptor { get => default; } // 0x0000000183B36A40-0x0000000183B36AC0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticClassName { get => default; } // 0x0000000183B363F0-0x0000000183B36450 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ClassName { get => default; } // 0x0000000183B374B0-0x0000000183B375A0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticFullClassName { get => default; } // 0x0000000183B372D0-0x0000000183B37330 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string FullClassName { get => default; } // 0x0000000183B36E30-0x0000000183B36F20 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static ushort StaticCmdId { get => default; } // 0x0000000183B37460-0x0000000183B374B0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override ushort CmdId { get => default; } // 0x0000000183B36B60-0x0000000183B36C50 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public RepeatedMessageField<ItemParam> BaseItemList { get => default; } // 0x0000000183B36DD0-0x0000000183B36E30 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public RepeatedMessageField<ItemParam> PerDayItemList { get => default; } // 0x0000000183B37010-0x0000000183B37070 

			// Constructors
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public ResinCard() {} // 0x0000000183B378A0-0x0000000183B37950
			static ResinCard() {} // 0x0000000183B37760-0x0000000183B378A0

			// Methods
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public ResinCard Clone() => default; // 0x0000000183B36F20-0x0000000183B37010
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public ResinCard ShallowCopy() => default; // 0x0000000183B36AC0-0x0000000183B36B60
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalSetInPool(bool value) {} // 0x0000000183B365B0-0x0000000183B36600
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B37190-0x0000000183B37230
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B37230-0x0000000183B372D0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void Reset() {} // 0x0000000183B36600-0x0000000183B36720
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override bool Equals(object other) => default; // 0x0000000183B36720-0x0000000183B367F0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public bool Equals(ResinCard other) => default; // 0x0000000183B367F0-0x0000000183B36920
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int GetHashCode() => default; // 0x0000000183B36C50-0x0000000183B36D40
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ToString() => default; // 0x0000000183B375A0-0x0000000183B37760
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void WriteTo(CodedOutputStream output) {} // 0x0000000183B37330-0x0000000183B37460
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int CalculateSize() => default; // 0x0000000183B36920-0x0000000183B36A40
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public void CopyFrom(ResinCard other) {} // 0x0000000183B36450-0x0000000183B365B0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void MergeFrom(CodedInputStream input) {} // 0x0000000183B36250-0x0000000183B363F0
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShopCardProduct() {} // 0x0000000183B55A30-0x0000000183B55AB0
	static ShopCardProduct() {} // 0x0000000183B55970-0x0000000183B55A30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShopCardProduct Clone() => default; // 0x0000000183B54600-0x0000000183B546F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShopCardProduct ShallowCopy() => default; // 0x0000000183B53DA0-0x0000000183B53E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183B532C0-0x0000000183B53380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B54BE0-0x0000000183B54CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B54D40-0x0000000183B54E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183B53380-0x0000000183B53450
	public void resetExtraCardData() {} // 0x0000000183B54E60-0x0000000183B54F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearExtraCardData() {} // 0x0000000183B53450-0x0000000183B534B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183B536D0-0x0000000183B537A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ShopCardProduct other) => default; // 0x0000000183B537A0-0x0000000183B53A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183B53F30-0x0000000183B541A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183B55390-0x0000000183B55970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183B54F80-0x0000000183B55250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183B53A00-0x0000000183B53D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ShopCardProduct other) {} // 0x0000000183B52F70-0x0000000183B53220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183B52C30-0x0000000183B52E70
}

