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
	public class MonoChannellerSlabStagePage : MonoUIProxy // TypeDefIndex: 30055
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _stageTitle; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _subTitle; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _normalStageTrans; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _waveList; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _campList; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _coinTrans; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform[] _stageImgs; // 0x78
		[SerializeField] // 0x000000018975D800-0x000000018975D840
		[Space] // 0x000000018975D800-0x000000018975D840
		private Transform _loopDungeonTrans; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _loopDungeonCurScoreDesc; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _missionList; // 0x90
	
		// Properties
		public Transform coinRoot { /* [XID] */ /* 0x0000000189776E60-0x0000000189776E80 */ get => default; } // 0x000000018480CED0-0x000000018480CF70 
		public MonoUIContainer prevBtn { /* [XID] */ /* 0x000000018977E520-0x000000018977E540 */ get => default; } // 0x000000018480D9D0-0x000000018480DA90 
		public MonoUIContainer nextBtn { /* [XID] */ /* 0x0000000189785C50-0x0000000189785C70 */ get => default; } // 0x000000018480D650-0x000000018480D710 
		public MonoUIContainer okBtn { /* [XID] */ /* 0x000000018978D3B0-0x000000018978D3D0 */ get => default; } // 0x000000018480D710-0x000000018480D7D0 
		public MonoUIContainer gotoBtn { /* [XID] */ /* 0x0000000189794730-0x0000000189794750 */ get => default; } // 0x000000018480D030-0x000000018480D0F0 
		public MonoUIContainer itemDetail { /* [XID] */ /* 0x000000018979CBC0-0x000000018979CBE0 */ get => default; } // 0x000000018480D430-0x000000018480D4F0 
		public MonoUIContainer closeBtn { /* [XID] */ /* 0x00000001897A4020-0x00000001897A4040 */ get => default; } // 0x000000018480CE10-0x000000018480CED0 
		public MonoUIContainer backBtn { /* [XID] */ /* 0x00000001897AB580-0x00000001897AB5A0 */ get => default; } // 0x000000018480CCB0-0x000000018480CD70 
		public MonoUIContainer itemDetail_Dungeon { /* [XID] */ /* 0x00000001897B3370-0x00000001897B3390 */ get => default; } // 0x000000018480D370-0x000000018480D430 
		public MonoUIContainer goto_Dungeon { /* [XID] */ /* 0x00000001897BB290-0x00000001897BB2B0 */ get => default; } // 0x000000018480D2B0-0x000000018480D370 
		public MonoUIContainer gotoQuest_Dungeon { /* [XID] */ /* 0x00000001897C2A70-0x00000001897C2A90 */ get => default; } // 0x000000018480D1F0-0x000000018480D2B0 
		public MonoUIContainer fetch_Dungeon { /* [XID] */ /* 0x00000001897CA2D0-0x00000001897CA2F0 */ get => default; } // 0x000000018480CF70-0x000000018480D030 
		public MonoUIContainer BtnCourse { /* [XID] */ /* 0x00000001897D1910-0x00000001897D1930 */ get => default; } // 0x000000018480CBF0-0x000000018480CCB0 
		public UnityEngine.UI.Text stageTitle { /* [XID] */ /* 0x00000001897D9730-0x00000001897D9750 */ get => default; } // 0x000000018480DA90-0x000000018480DB30 
		public UnityEngine.UI.Text subTitle { /* [XID] */ /* 0x00000001897E0AD0-0x00000001897E0AF0 */ get => default; } // 0x000000018480DB30-0x000000018480DBD0 
		public UnityEngine.UI.Text loopDungeonCurScoreDesc { /* [XID] */ /* 0x00000001897E8170-0x00000001897E8190 */ get => default; } // 0x000000018480D4F0-0x000000018480D5A0 
		public MonoSimpleReusableList waveList { /* [XID] */ /* 0x00000001897EFE50-0x00000001897EFE70 */ get => default; } // 0x000000018480DBD0-0x000000018480DC70 
		public MonoSimpleReusableList campList { /* [XID] */ /* 0x00000001897F7640-0x00000001897F7660 */ get => default; } // 0x000000018480CD70-0x000000018480CE10 
		public MonoSimpleReusableList missionList { /* [XID] */ /* 0x00000001897FED30-0x00000001897FED50 */ get => default; } // 0x000000018480D5A0-0x000000018480D650 
		public UnityEngine.UI.Text oneOffDungeonTitle { /* [XID] */ /* 0x0000000189824130-0x0000000189824150 */ get => default; } // 0x000000018480D8D0-0x000000018480D9D0 
		public UnityEngine.UI.Text oneOffDungeonProgress { /* [XID] */ /* 0x000000018982BB80-0x000000018982BBA0 */ get => default; } // 0x000000018480D7D0-0x000000018480D8D0 
		public Button gotoOneOffDungeonDialog { /* [XID] */ /* 0x00000001898330F0-0x0000000189833110 */ get => default; } // 0x000000018480D0F0-0x000000018480D1F0 
	
		// Constructors
		public MonoChannellerSlabStagePage() {} // 0x000000018480CB50-0x000000018480CBF0
	
		// Methods
		// [XID] // 0x0000000189806490-0x00000001898064B0
		public void ShowPage(int pageIndex) {} // 0x000000018480C9C0-0x000000018480CB50
		// [XID] // 0x000000018980DB70-0x000000018980DB90
		public void SetOneOffDungeonState(int state) {} // 0x000000018480C8C0-0x000000018480C9C0
		// [XID] // 0x00000001898152F0-0x0000000189815310
		public void SetOneOffDungeonRow(bool show) {} // 0x000000018480C750-0x000000018480C8C0
		// [XID] // 0x000000018981CCF0-0x000000018981CD10
		private MonoChannellerSlabWaveRow GetOneOffRow() => default; // 0x000000018480C600-0x000000018480C750
	}
}
