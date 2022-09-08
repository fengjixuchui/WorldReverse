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
	public class MonoActivitySubPageHideAndSeek : MonoUIProxy // TypeDefIndex: 31177
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _timeDesc; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _desc; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _rewardPreviewList; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _rewardPreviewGrp; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _scoreGrp; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _scoreCountText; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _btnSkill; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _skillBtnGrp; // 0x88
	
		// Properties
		public string timeDesc { /* [XID] */ /* 0x0000000189AD6FF0-0x0000000189AD7010 */ set {} } // 0x00000001852E4040-0x00000001852E4110
		public string Desc { /* [XID] */ /* 0x0000000189ADE9F0-0x0000000189ADEA10 */ set {} } // 0x00000001852E3E80-0x00000001852E3F60
		public string title { /* [XID] */ /* 0x0000000189AE63B0-0x0000000189AE63D0 */ set {} } // 0x00000001852E4110-0x00000001852E41E0
		public string scoreCount { /* [XID] */ /* 0x0000000189AEDB50-0x0000000189AEDB70 */ set {} } // 0x00000001852E3F60-0x00000001852E4040
		public MonoGridScroller rewardPreviewList { /* [XID] */ /* 0x0000000189AF5380-0x0000000189AF53A0 */ get => default; } // 0x00000001852E3C90-0x00000001852E3D30 
		public Button BtnSkill { /* [XID] */ /* 0x0000000189AFC8D0-0x0000000189AFC8F0 */ get => default; } // 0x00000001852E3B40-0x00000001852E3BF0 
		public GameObject rewardPreviewGrp { /* [XID] */ /* 0x0000000189B04010-0x0000000189B04030 */ get => default; } // 0x00000001852E3BF0-0x00000001852E3C90 
		public GameObject scoreGrp { /* [XID] */ /* 0x0000000189B0B8D0-0x0000000189B0B8F0 */ get => default; } // 0x00000001852E3D30-0x00000001852E3DD0 
		public GameObject skillBtnGrp { /* [XID] */ /* 0x0000000189B12E00-0x0000000189B12E20 */ get => default; } // 0x00000001852E3DD0-0x00000001852E3E80 
		public MonoUIContainer BtnGotoQuest { /* [XID] */ /* 0x0000000189B1A490-0x0000000189B1A4B0 */ get => default; } // 0x00000001852E36C0-0x00000001852E3780 
		public MonoUIContainer BtnExit { /* [XID] */ /* 0x0000000189B219B0-0x0000000189B219D0 */ get => default; } // 0x00000001852E3540-0x00000001852E3600 
		public MonoUIContainer BtnBack { /* [XID] */ /* 0x0000000189B290E0-0x0000000189B29100 */ get => default; } // 0x00000001852E33C0-0x00000001852E3480 
		public MonoUIContainer BtnOK { /* [XID] */ /* 0x0000000189B30510-0x0000000189B30530 */ get => default; } // 0x00000001852E3840-0x00000001852E3900 
		public MonoUIContainer BtnItemDetail { /* [XID] */ /* 0x0000000189B37E30-0x0000000189B37E50 */ get => default; } // 0x00000001852E3780-0x00000001852E3840 
		public MonoUIContainer BtnReward { /* [XID] */ /* 0x0000000189B3F760-0x0000000189B3F780 */ get => default; } // 0x00000001852E39C0-0x00000001852E3A80 
		public MonoUIContainer BtnGotoChallenge { /* [XID] */ /* 0x0000000189B470C0-0x0000000189B470E0 */ get => default; } // 0x00000001852E3600-0x00000001852E36C0 
		public MonoUIContainer BtnDescription { /* [XID] */ /* 0x0000000189B4E7C0-0x0000000189B4E7E0 */ get => default; } // 0x00000001852E3480-0x00000001852E3540 
		public MonoUIContainer BtnPreview { /* [XID] */ /* 0x0000000189B56020-0x0000000189B56040 */ get => default; } // 0x00000001852E3900-0x00000001852E39C0 
		public MonoUIContainer BtnSkill_PS4 { /* [XID] */ /* 0x0000000189B5D900-0x0000000189B5D920 */ get => default; } // 0x00000001852E3A80-0x00000001852E3B40 
	
		// Constructors
		public MonoActivitySubPageHideAndSeek() {} // 0x00000001852E3330-0x00000001852E33C0
	
		// Methods
		// [XID] // 0x0000000189B64E60-0x0000000189B64E80
		public void ShowGrpByQuestFinished(bool isFinished) {} // 0x00000001852E3110-0x00000001852E3330
	}
}
