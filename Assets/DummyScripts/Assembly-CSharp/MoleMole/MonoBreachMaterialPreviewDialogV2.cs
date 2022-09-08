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
	public class MonoBreachMaterialPreviewDialogV2 : MonoUIProxy // TypeDefIndex: 31120
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _prevButton; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _prevButtonPs4; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _nextButton; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _nextButtonPs4; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button[] _starButton; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _starRateText; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _imageLineGrp; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject[] _imageLine; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _materialText; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _materialScroller; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _molaNeed; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _molaNum; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _rewardTextGrp; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _rewardScrollerGrp; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rewardText; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _rewardScroller; // 0xC8
	
		// Properties
		public UnityEngine.UI.Text title { /* [XID] */ /* 0x0000000189A59C60-0x0000000189A59C80 */ get => default; } // 0x00000001847FCE50-0x00000001847FCEF0 
		public MonoUIContainer prevButton { /* [XID] */ /* 0x0000000189A61400-0x0000000189A61420 */ get => default; } // 0x00000001847FC930-0x00000001847FC9D0 
		public MonoUIContainer prevButtonPs4 { /* [XID] */ /* 0x0000000189A692F0-0x0000000189A69310 */ get => default; } // 0x00000001847FC890-0x00000001847FC930 
		public bool showPrevButton { /* [XID] */ /* 0x0000000189A706A0-0x0000000189A706C0 */ set {} } // 0x00000001847FD1F0-0x00000001847FD310
		public bool showNextButton { /* [XID] */ /* 0x0000000189A77F70-0x0000000189A77F90 */ set {} } // 0x00000001847FD0D0-0x00000001847FD1F0
		public MonoUIContainer nextButton { /* [XID] */ /* 0x0000000189A7F540-0x0000000189A7F560 */ get => default; } // 0x00000001847FC7F0-0x00000001847FC890 
		public MonoUIContainer nextButtonPs4 { /* [XID] */ /* 0x0000000189A87280-0x0000000189A872A0 */ get => default; } // 0x00000001847FC750-0x00000001847FC7F0 
		public Button[] starButtons { /* [XID] */ /* 0x0000000189A8EA80-0x0000000189A8EAA0 */ get => default; } // 0x00000001847FCD10-0x00000001847FCDB0 
		public UnityEngine.UI.Text starRateText { /* [XID] */ /* 0x0000000189A960B0-0x0000000189A960D0 */ get => default; } // 0x00000001847FCDB0-0x00000001847FCE50 
		public UnityEngine.UI.Text materialText { /* [XID] */ /* 0x0000000189A9D600-0x0000000189A9D620 */ get => default; } // 0x00000001847FC540-0x00000001847FC5F0 
		public MonoSimpleReusableList materialScroller { /* [XID] */ /* 0x0000000189AA4E40-0x0000000189AA4E60 */ get => default; } // 0x00000001847FC490-0x00000001847FC540 
		public UnityEngine.UI.Text molaNeedText { /* [XID] */ /* 0x0000000189AAC6D0-0x0000000189AAC6F0 */ get => default; } // 0x00000001847FC5F0-0x00000001847FC6A0 
		public UnityEngine.UI.Text molaNumText { /* [XID] */ /* 0x0000000189AB3EB0-0x0000000189AB3ED0 */ get => default; } // 0x00000001847FC6A0-0x00000001847FC750 
		public UnityEngine.UI.Text rewardText { /* [XID] */ /* 0x0000000189ABBC10-0x0000000189ABBC30 */ get => default; } // 0x00000001847FCC60-0x00000001847FCD10 
		public MonoSimpleReusableList rewardScroller { /* [XID] */ /* 0x0000000189AC3380-0x0000000189AC33A0 */ get => default; } // 0x00000001847FCBB0-0x00000001847FCC60 
		public bool showRewardGrp { /* [XID] */ /* 0x0000000189ACAAA0-0x0000000189ACAAC0 */ set {} } // 0x00000001847FD310-0x00000001847FD420
		public Button receiveButton { /* [XID] */ /* 0x0000000189AD24E0-0x0000000189AD2500 */ get => default; } // 0x00000001847FC9D0-0x00000001847FCBB0 
		public string setReceiveButtonText { /* [XID] */ /* 0x0000000189AD9FB0-0x0000000189AD9FD0 */ set {} } // 0x00000001847FCEF0-0x00000001847FD0D0
		public Button detailButton { /* [XID] */ /* 0x0000000189AE18F0-0x0000000189AE1910 */ get => default; } // 0x00000001847FC2B0-0x00000001847FC490 
		public Button backButton { /* [XID] */ /* 0x0000000189AE90A0-0x0000000189AE90C0 */ get => default; } // 0x00000001847FC0D0-0x00000001847FC2B0 
	
		// Constructors
		public MonoBreachMaterialPreviewDialogV2() {} // 0x00000001847FC000-0x00000001847FC0D0
	
		// Methods
		// [XID] // 0x0000000189AF0E00-0x0000000189AF0E20
		public void SetStarShow(int currBreakLevel) {} // 0x00000001847FBDA0-0x00000001847FC000
		// [XID] // 0x0000000189AF8310-0x0000000189AF8330
		public void SetImageLine(uint showBreakLevel) {} // 0x00000001847FBBF0-0x00000001847FBDA0
	}
}
