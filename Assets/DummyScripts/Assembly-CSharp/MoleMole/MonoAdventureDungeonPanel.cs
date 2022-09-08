/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoAdventureDungeonPanel : MonoBehaviour // TypeDefIndex: 30682
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _entryScroller; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _dungeonScroller; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _trialDungeonScroller; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoMaterialItemRow _resinRow; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _dailyDungeonPanel; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _towerDungeonPanel; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _trialDungeonPanel; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _starCount; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _bestScore; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _desc; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _starRoot; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _towerImage; // 0x70
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text _trialHalfNumTxt; // 0x78
	
		// Properties
		public UnityEngine.UI.Text starCount { /* [XID] */ /* 0x00000001896244F0-0x0000000189624510 */ get => default; } // 0x0000000184C835A0-0x0000000184C83640 
		public UnityEngine.UI.Text bestScore { /* [XID] */ /* 0x000000018962BBA0-0x000000018962BBC0 */ get => default; } // 0x0000000184C83280-0x0000000184C83320 
		public UnityEngine.UI.Text desc { /* [XID] */ /* 0x0000000189633710-0x0000000189633730 */ get => default; } // 0x0000000184C83320-0x0000000184C833C0 
		public bool showStarRoot { /* [XID] */ /* 0x00000001896514D0-0x00000001896514F0 */ set {} } // 0x0000000184C83780-0x0000000184C83870
		public Sprite towerImage { /* [XID] */ /* 0x0000000189658CF0-0x0000000189658D10 */ set {} } // 0x0000000184C83870-0x0000000184C83930
		public MonoGridScroller entryScroller { /* [XID] */ /* 0x00000001896603E0-0x0000000189660400 */ get => default; } // 0x0000000184C83460-0x0000000184C83500 
		public MonoGridScroller dungeonScroller { /* [XID] */ /* 0x0000000189667DA0-0x0000000189667DC0 */ get => default; } // 0x0000000184C833C0-0x0000000184C83460 
		public MonoGridScroller trialDungeonScroller { /* [XID] */ /* 0x000000018966F810-0x000000018966F830 */ get => default; } // 0x0000000184C83640-0x0000000184C836E0 
		public MonoMaterialItemRow resinRow { /* [XID] */ /* 0x0000000189677160-0x0000000189677180 */ get => default; } // 0x0000000184C83500-0x0000000184C835A0 
		public UnityEngine.UI.Text trialHalfNumTxt { /* [XID] */ /* 0x000000018967E710-0x000000018967E730 */ get => default; } // 0x0000000184C836E0-0x0000000184C83780 
	
		// Constructors
		public MonoAdventureDungeonPanel() {} // 0x0000000184C831E0-0x0000000184C83280
	
		// Methods
		// [XID] // 0x000000018963AFB0-0x000000018963AFD0
		public void ShowDailyDungeonPanel(bool show) {} // 0x0000000184C82F10-0x0000000184C83000
		// [XID] // 0x00000001896426A0-0x00000001896426C0
		public void ShowTowerDungeonPanel(bool show) {} // 0x0000000184C83000-0x0000000184C830F0
		// [XID] // 0x0000000189649DB0-0x0000000189649DD0
		public void ShowTrialDungeonPanel(bool show) {} // 0x0000000184C830F0-0x0000000184C831E0
	}
}
