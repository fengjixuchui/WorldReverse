/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Config
{
	[CSharpCallLua] // 0x000000018998DB20-0x000000018998DB60
	[RecycleType] // 0x000000018998DB20-0x000000018998DB60
	public class ConfigLCBaseIntee : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18448
	{
		// Fields
		private string _triggerShapeIn; // 0x10
		private float _triggerShapeInHeight; // 0x18
		private string _triggerShapeOut; // 0x20
		private float _triggerShapeOutHeight; // 0x28
		private Vector _triggerShapeInOffset; // 0x2C
		private Vector _triggerShapeOutOffset; // 0x38
		private string _triggerShapeFreeInteraction; // 0x48
		private float _triggerShapeFreeInteractionHeight; // 0x50
		private Vector _triggerShapeFreeInteractionOffset; // 0x54
	
		// Properties
		public string triggerShapeIn { /* [XID] */ /* 0x0000000189744950-0x0000000189744970 */ get => default; /* [XID] */ /* 0x000000018974C6A0-0x000000018974C6C0 */ private set {} } // 0x000000018882FFC0-0x0000000188830060 0x0000000188830640-0x00000001888306F0
		public float triggerShapeInHeight { /* [XID] */ /* 0x0000000189A7AFB0-0x0000000189A7AFD0 */ get => default; /* [XID] */ /* 0x000000018975AF20-0x000000018975AF40 */ private set {} } // 0x000000018882FE30-0x000000018882FEE0 0x00000001888304C0-0x0000000188830570
		public string triggerShapeOut { /* [XID] */ /* 0x00000001897628D0-0x00000001897628F0 */ get => default; /* [XID] */ /* 0x0000000189769ED0-0x0000000189769EF0 */ private set {} } // 0x00000001888301F0-0x0000000188830290 0x0000000188830870-0x0000000188830920
		public float triggerShapeOutHeight { /* [XID] */ /* 0x0000000189A99280-0x0000000189A992A0 */ get => default; /* [XID] */ /* 0x0000000189778E40-0x0000000189778E60 */ private set {} } // 0x0000000188830060-0x0000000188830110 0x00000001888306F0-0x00000001888307A0
		public Vector triggerShapeInOffset { /* [XID] */ /* 0x0000000189A89E40-0x0000000189A89E60 */ get => default; /* [XID] */ /* 0x0000000189787CC0-0x0000000189787CE0 */ private set {} } // 0x000000018882FEE0-0x000000018882FFC0 0x0000000188830570-0x0000000188830640
		public Vector triggerShapeOutOffset { /* [XID] */ /* 0x000000018978F1E0-0x000000018978F200 */ get => default; /* [XID] */ /* 0x0000000189796A10-0x0000000189796A30 */ private set {} } // 0x0000000188830110-0x00000001888301F0 0x00000001888307A0-0x0000000188830870
		public string triggerShapeFreeInteraction { /* [XID] */ /* 0x0000000189AA0270-0x0000000189AA0290 */ get => default; /* [XID] */ /* 0x00000001897A6240-0x00000001897A6260 */ private set {} } // 0x000000018882FD90-0x000000018882FE30 0x0000000188830410-0x00000001888304C0
		public float triggerShapeFreeInteractionHeight { /* [XID] */ /* 0x0000000189AE16A0-0x0000000189AE16C0 */ get => default; /* [XID] */ /* 0x00000001897B5810-0x00000001897B5830 */ private set {} } // 0x000000018882FC00-0x000000018882FCB0 0x0000000188830290-0x0000000188830340
		public Vector triggerShapeFreeInteractionOffset { /* [XID] */ /* 0x00000001897BD540-0x00000001897BD560 */ get => default; /* [XID] */ /* 0x00000001897C4920-0x00000001897C4940 */ private set {} } // 0x000000018882FCB0-0x000000018882FD90 0x0000000188830340-0x0000000188830410
	
		// Constructors
		public ConfigLCBaseIntee() {} // 0x000000018882FBA0-0x000000018882FC00
	
		// Methods
		// [XID] // 0x00000001897CC0F0-0x00000001897CC110
		public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018882F010-0x000000018882F230
		// [XID] // 0x00000001897D3A20-0x00000001897D3A40
		public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018882D0B0-0x000000018882D1C0
		// [XID] // 0x00000001897DB4B0-0x00000001897DB4D0
		public virtual ConfigLCBaseIntee Clone(bool useObjectPool = false /* Metadata: 0x00AF98C9 */) => default; // 0x000000018882CFD0-0x000000018882D0B0
		// [XID] // 0x00000001897E2B80-0x00000001897E2BA0
		public virtual int GetHashNum() => default; // 0x000000018882D840-0x000000018882D910
		// [XID] // 0x00000001897EA340-0x00000001897EA360
		public virtual void InitEmpty() {} // 0x000000018882D910-0x000000018882DA40
		[BlackList] // 0x00000001897F2010-0x00000001897F2050
		// [XID] // 0x00000001897F2010-0x00000001897F2050
		public virtual bool FromJson(JSONNode node) => default; // 0x000000018882D4C0-0x000000018882D840
		// [XID] // 0x00000001897FC8E0-0x00000001897FC900
		private bool InternalFromJson(JSONNode node) => default; // 0x000000018882E0F0-0x000000018882E930
		[BlackList] // 0x0000000189803DF0-0x0000000189803E30
		// [XID] // 0x0000000189803DF0-0x0000000189803E30
		public static ConfigLCBaseIntee ParseFromJson(JSONNode node) => default; // 0x000000018882F540-0x000000018882F740
		// [XID] // 0x000000018980E390-0x000000018980E3B0
		public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF98CA */, bool useObjectPool = false /* Metadata: 0x00AF98CE */) => default; // 0x000000018882D1C0-0x000000018882D4C0
		// [XID] // 0x0000000189815A90-0x0000000189815AB0
		private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF98CF */, bool useObjectPool = false /* Metadata: 0x00AF98D3 */) => default; // 0x000000018882DA40-0x000000018882E0F0
		// [XID] // 0x000000018981D510-0x000000018981D530
		public static ConfigLCBaseIntee ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF98D4 */, bool useObjectPool = false /* Metadata: 0x00AF98D8 */) => default; // 0x000000018882F370-0x000000018882F540
		[BlackList] // 0x00000001898249A0-0x00000001898249E0
		// [XID] // 0x00000001898249A0-0x00000001898249E0
		public virtual bool ToBinary(ByteArray byteArray) => default; // 0x000000018882F8D0-0x000000018882FBA0
		// [XID] // 0x000000018982EF40-0x000000018982EF60
		private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018882E930-0x000000018882F010
		[BlackList] // 0x0000000189836850-0x0000000189836890
		// [XID] // 0x0000000189836850-0x0000000189836890
		public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018882F7E0-0x000000018882F8D0
		[BlackList] // 0x0000000189840C00-0x0000000189840C40
		// [XID] // 0x0000000189840C00-0x0000000189840C40
		public virtual void AutoAllocTypeFields() {} // 0x000000018882CE40-0x000000018882CEE0
		[BlackList] // 0x000000018984B210-0x000000018984B250
		// [XID] // 0x000000018984B210-0x000000018984B250
		public virtual void AutoRecycleTypeFields() {} // 0x000000018882CEE0-0x000000018882CFD0
		[BlackList] // 0x00000001898552F0-0x0000000189855330
		// [XID] // 0x00000001898552F0-0x0000000189855330
		public virtual void ReturnToObjectPool() {} // 0x000000018882F740-0x000000018882F7E0
		[BlackList] // 0x000000018985F5D0-0x000000018985F610
		// [XID] // 0x000000018985F5D0-0x000000018985F610
		public virtual void OnPoolAllocated() {} // 0x000000018882F2D0-0x000000018882F370
		[BlackList] // 0x0000000189869E40-0x0000000189869E80
		// [XID] // 0x0000000189869E40-0x0000000189869E80
		public virtual void OnBeforePoolRecycled() {} // 0x000000018882F230-0x000000018882F2D0
	}
}
