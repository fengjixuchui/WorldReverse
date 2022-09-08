/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoActivityWaterSpiritDialog : MonoUIProxy // TypeDefIndex: 30096
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _bgButton; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _dialogTitle; // 0x50
		// [Header] // 0x0000000189681A00-0x0000000189681A40
		[SerializeField] // 0x0000000189681A00-0x0000000189681A40
		private Button _recordBtn; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _leftTitle; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _leftDesc; // 0x68
		// [Header] // 0x000000018969CD90-0x000000018969CDD0
		[SerializeField] // 0x000000018969CD90-0x000000018969CDD0
		private Text _rightDesc; // 0x70
		// [Header] // 0x00000001896A8910-0x00000001896A8960
		[SerializeField] // 0x00000001896A8910-0x00000001896A8960
		private MonoUIContainer _taskRegionSearchBtn; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _taskRegionSearchGrp; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _regionSearchGridScroller; // 0x88
		// [Header] // 0x00000001896C2D40-0x00000001896C2D90
		[SerializeField] // 0x00000001896C2D40-0x00000001896C2D90
		private MonoUIContainer _taskFinalQuestBtn; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _taskFinalQuestGrp; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _taskFinalQuestTitle; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _taskFinalQuestDesc; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _taskFinalQuestDescScrollRect; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _taskFinalQuestRewardTips; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _taskFinalQuestRewardScroller; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _taskFinalQuestLockGrp; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _taskFinalQuestLockText; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _taskFinalQuestBtnGrp; // 0xD8
	
		// Properties
		public MonoElementSwitch elementSwitch { /* [XID] */ /* 0x0000000189711B90-0x0000000189711BB0 */ get => default; } // 0x00000001852EAB50-0x00000001852EABF0 
		public Button bgButton { /* [XID] */ /* 0x0000000189719030-0x0000000189719050 */ get => default; } // 0x00000001852EA710-0x00000001852EA7B0 
		public Text dialogTitle { /* [XID] */ /* 0x00000001897206F0-0x0000000189720710 */ get => default; } // 0x00000001852EAAB0-0x00000001852EAB50 
		public Button recordBtn { /* [XID] */ /* 0x0000000189727CC0-0x0000000189727CE0 */ get => default; } // 0x00000001852EAD30-0x00000001852EADD0 
		public Text leftTitle { /* [XID] */ /* 0x000000018972F360-0x000000018972F380 */ get => default; } // 0x00000001852EAC90-0x00000001852EAD30 
		public Text leftDesc { /* [XID] */ /* 0x0000000189736D40-0x0000000189736D60 */ get => default; } // 0x00000001852EABF0-0x00000001852EAC90 
		public Text rightDesc { /* [XID] */ /* 0x000000018973E8A0-0x000000018973E8C0 */ get => default; } // 0x00000001852EAE80-0x00000001852EAF20 
		public MonoUIContainer taskRegionSearchBtn { /* [XID] */ /* 0x0000000189745C00-0x0000000189745C20 */ get => default; } // 0x00000001852EB780-0x00000001852EB820 
		public Transform taskRegionSearchGrp { /* [XID] */ /* 0x000000018974D6D0-0x000000018974D6F0 */ get => default; } // 0x00000001852EB820-0x00000001852EB8D0 
		public MonoGridScroller regionSearchGridScroller { /* [XID] */ /* 0x0000000189754CF0-0x0000000189754D10 */ get => default; } // 0x00000001852EADD0-0x00000001852EAE80 
		public MonoUIContainer taskFinalQuestBtn { /* [XID] */ /* 0x000000018975BEA0-0x000000018975BEC0 */ get => default; } // 0x00000001852EB150-0x00000001852EB200 
		public Transform taskFinalQuestGrp { /* [XID] */ /* 0x0000000189763870-0x0000000189763890 */ get => default; } // 0x00000001852EB360-0x00000001852EB410 
		public Text taskFinalQuestTitle { /* [XID] */ /* 0x000000018976B030-0x000000018976B050 */ get => default; } // 0x00000001852EB6D0-0x00000001852EB780 
		public Text taskFinalQuestDesc { /* [XID] */ /* 0x0000000189772660-0x0000000189772680 */ get => default; } // 0x00000001852EB2B0-0x00000001852EB360 
		public ScrollRect taskFinalQuestDescScrollRect { /* [XID] */ /* 0x0000000189779CB0-0x0000000189779CD0 */ get => default; } // 0x00000001852EB200-0x00000001852EB2B0 
		public Text taskFinalQuestRewardTips { /* [XID] */ /* 0x0000000189781910-0x0000000189781930 */ get => default; } // 0x00000001852EB620-0x00000001852EB6D0 
		public MonoGridScroller taskFinalQuestRewardScroller { /* [XID] */ /* 0x0000000189788E50-0x0000000189788E70 */ get => default; } // 0x00000001852EB570-0x00000001852EB620 
		public Transform taskFinalQuestLockGrp { /* [XID] */ /* 0x0000000189790440-0x0000000189790460 */ get => default; } // 0x00000001852EB410-0x00000001852EB4C0 
		public Text taskFinalQuestLockText { /* [XID] */ /* 0x0000000189797DB0-0x0000000189797DD0 */ get => default; } // 0x00000001852EB4C0-0x00000001852EB570 
		public Transform taskFinalQuestBtnGrp { /* [XID] */ /* 0x000000018979FA90-0x000000018979FAB0 */ get => default; } // 0x00000001852EB0A0-0x00000001852EB150 
		public MonoUIContainer taskFinalQuestBtnGotoQuest { /* [XID] */ /* 0x00000001897A7090-0x00000001897A70B0 */ get => default; } // 0x00000001852EAFE0-0x00000001852EB0A0 
		public MonoUIContainer taskFinalQuestBtnGotoBag { /* [XID] */ /* 0x00000001897AEA00-0x00000001897AEA20 */ get => default; } // 0x00000001852EAF20-0x00000001852EAFE0 
		public MonoUIContainer btnClose { /* [XID] */ /* 0x00000001897B6890-0x00000001897B68B0 */ get => default; } // 0x00000001852EA7B0-0x00000001852EA870 
		public MonoUIContainer btnGoto { /* [XID] */ /* 0x00000001897BE6F0-0x00000001897BE710 */ get => default; } // 0x00000001852EA9F0-0x00000001852EAAB0 
		public MonoUIContainer btnDetailPS4 { /* [XID] */ /* 0x00000001897C5D80-0x00000001897C5DA0 */ get => default; } // 0x00000001852EA930-0x00000001852EA9F0 
		public MonoUIContainer btnCourse { /* [XID] */ /* 0x00000001897CD5A0-0x00000001897CD5C0 */ get => default; } // 0x00000001852EA870-0x00000001852EA930 
	
		// Constructors
		public MonoActivityWaterSpiritDialog() {} // 0x00000001852EA630-0x00000001852EA710
	}
}
