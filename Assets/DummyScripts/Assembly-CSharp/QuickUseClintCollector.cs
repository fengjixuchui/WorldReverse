/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QuickUseClintCollector : QuickWidgetBase // TypeDefIndex: 31350
{
	// Fields
	private BagItemSlot _equippedBagItemSlot; // 0x28
	private ClientCollector _currentCollector; // 0x30

	// Properties
	public ClientCollector currentCollector { /* [XID] */ /* 0x000000018994C770-0x000000018994C790 */ get => default; } // 0x000000018359F0C0-0x000000018359F160 

	// Nested types
	public class ClientCollector // TypeDefIndex: 31351
	{
		// Fields
		public ElementType elementType; // 0x10
		public CollectorType collectType; // 0x14
		public uint maxPoint; // 0x18
		public uint currentPoint; // 0x1C

		// Constructors
		public ClientCollector() {} // 0x000000018359D4F0-0x000000018359D550

		// Methods
		// [XID] // 0x00000001899BDAA0-0x00000001899BDAC0
		public void Reset(ElementType eleType, CollectorType cType, uint max, uint current) {} // 0x000000018359D280-0x000000018359D370
		// [XID] // 0x00000001899C51A0-0x00000001899C51C0
		public void ResetCurrentNum(uint current) {} // 0x000000018359D440-0x000000018359D4F0
		// [XID] // 0x00000001899CC870-0x00000001899CC890
		public float GetRatio() => default; // 0x000000018359D370-0x000000018359D440
	}

	// Constructors
	public QuickUseClintCollector() {} // 0x000000018359F480-0x000000018359F550

	// Methods
	// [XID] // 0x0000000189953E80-0x0000000189953EA0
	public override LCWidgetBagActionPara DoBag(LCWidget lcWidget) => default; // 0x000000018359D630-0x000000018359D770
	// [XID] // 0x000000018995B6A0-0x000000018995B6C0
	public override void InitOnAttach(WidgetSlotTag tag) {} // 0x000000018359F160-0x000000018359F480
	// [XID] // 0x0000000189963280-0x00000001899632A0
	public override void ClearOnUnAttach(WidgetSlotTag tag) {} // 0x000000018359E180-0x000000018359E230
	// [XID] // 0x000000018996A640-0x000000018996A660
	public override LCWidgetButtonActionPara DoActionPanel(LCWidget lcWidget) => default; // 0x000000018359DD80-0x000000018359DFA0
	// [XID] // 0x0000000189972380-0x00000001899723A0
	public override void DoActionPanelPostAction(LCWidget lcWidget, bool success, object additionalPara = null) {} // 0x000000018359ED90-0x000000018359F030
	// [XID] // 0x0000000189979B20-0x0000000189979B40
	public override string GetBagPageButtonText(LCWidget lcWidget) => default; // 0x000000018359E080-0x000000018359E180
	// [XID] // 0x0000000189981350-0x0000000189981370
	public override bool OnNotify(Notify ntf) => default; // 0x000000018359DFA0-0x000000018359E080
	// [XID] // 0x0000000189988B20-0x0000000189988B40
	public override void InitButtonGrp(MonoQuickUseButton button) {} // 0x000000018359EA40-0x000000018359ED90
	// [XID] // 0x00000001899902C0-0x00000001899902E0
	public override void GetActionPanelNumGrp(GameObject numGrp, SimpleText text) {} // 0x000000018359E4D0-0x000000018359E6A0
	// [XID] // 0x0000000189997E50-0x0000000189997E70
	public override BagItemSlot GetCurrentEquippedBagItemSlot() => default; // 0x000000018359E230-0x000000018359E2D0
	// [XID] // 0x000000018999F580-0x000000018999F5A0
	public override void TickActionPanel(MonoQuickUseButton mono) {} // 0x000000018359DA50-0x000000018359DC10
	// [XID] // 0x00000001899A70B0-0x00000001899A70D0
	private float GetCurClientCollectorEnergyChargeAmount() => default; // 0x000000018359E3F0-0x000000018359E4D0
	// [XID] // 0x00000001899AE9E0-0x00000001899AEA00
	private void OnCollector(CollectorType type) {} // 0x000000018359D770-0x000000018359DA50
	// [XID] // 0x00000001899B5D40-0x00000001899B5D60
	public void OnCollectSuccess() {} // 0x000000018359E6A0-0x000000018359E8A0
}

