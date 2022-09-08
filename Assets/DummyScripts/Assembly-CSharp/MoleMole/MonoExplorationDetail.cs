/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoExplorationDetail : MonoBehaviour // TypeDefIndex: 30460
	{
		// Fields
		public UnityEngine.UI.Text title; // 0x18
		public UnityEngine.UI.Text description; // 0x20
		public Image image; // 0x28
		public MonoGridScroller scroller; // 0x30
		public GameObject explore; // 0x38
		public List<MonoUIContainer> listUIContainer; // 0x40
		public GameObject exploring; // 0x48
		public UnityEngine.UI.Text textExploring; // 0x50
		public GameObject explored; // 0x58
		public ScrollRect srDesc; // 0x60
		// [Header] // 0x0000000189BC2920-0x0000000189BC2960
		[Space] // 0x0000000189BC2920-0x0000000189BC2960
		public GameObject grpIntroduce; // 0x68
		public GameObject grpInvestigatorsActivity; // 0x70
		public GameObject grpUnExploreActivity; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _txtTimeCTR; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _txtMinRequireNumCTR; // 0x88
		public MonoSimpleReusableList monoActivityOngoingAvatarList; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtSendedPlayer; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _txtSuccProb; // 0xA0
	
		// Properties
		public UnityEngine.UI.Text txtSendedPlayer { /* [XID] */ /* 0x00000001895F17B0-0x00000001895F17D0 */ get => default; } // 0x000000018562A400-0x000000018562A4B0 
		public UnityEngine.UI.Text txtSuccProb { /* [XID] */ /* 0x00000001895F9250-0x00000001895F9270 */ get => default; } // 0x000000018562A4B0-0x000000018562A560 
		public MonoUIContainer txtTimeCTR { /* [XID] */ /* 0x0000000189600880-0x00000001896008A0 */ get => default; } // 0x000000018562A560-0x000000018562A620 
		public MonoUIContainer txtMinRequireNumCTR { /* [XID] */ /* 0x00000001896081A0-0x00000001896081C0 */ get => default; } // 0x000000018562A340-0x000000018562A400 
	
		// Constructors
		public MonoExplorationDetail() {} // 0x000000018562A280-0x000000018562A340
	
		// Methods
		// [XID] // 0x000000018960FB40-0x000000018960FB60
		public void RefreshData() {} // 0x000000018562A1E0-0x000000018562A280
	}
}
