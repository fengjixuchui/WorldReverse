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
	public class MonoHomeWorldBuildingPage : MonoUIProxy // TypeDefIndex: 30242
	{
		// Fields
		// [Header] // 0x0000000189B82BD0-0x0000000189B82C00
		public uint distanceUnderConstruct; // 0x40
		public uint distanceUnderDyestuff; // 0x44
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MonoElementSwitch _elementSwitch; // 0x48
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text _tabLabel; // 0x50
		// [Header] // 0x0000000189B9FF60-0x0000000189B9FFC0
		[SerializeField] // 0x0000000189B9FF60-0x0000000189B9FFC0
		[Space] // 0x0000000189B9FF60-0x0000000189B9FFC0
		private MonoUIContainer _tabKeyLeft; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _tabKeyRight; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _subTabKeyLeft; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _subTabKeyRight; // 0x70
		// [Header] // 0x0000000189BC55F0-0x0000000189BC5640
		[SerializeField] // 0x0000000189BC55F0-0x0000000189BC5640
		[Space] // 0x0000000189BC55F0-0x0000000189BC5640
		private Transform _leftGrp; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _rightGrp; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _noContentGrp; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _noItemTipsGrp; // 0x90
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Transform _shopMaterialGrp; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoReusableList _shopMaterialList; // 0xA0
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Transform _furnitureListGrp; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _furnitureListGrp_SubTabGrp; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _furnitureListGrp_FormulaGrp; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _furnitureListGrp_FormulaScroller; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _furnitureListGrp_QueueGrp; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _furnitureListGrp_QueueScroller; // 0xD0
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Transform _furnitureConsoleGrp; // 0xD8
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoSimpleReusableList _furnitureConsoleIcon; // 0xE0
		// [Header] // 0x0000000189647000-0x0000000189647060
		[SerializeField] // 0x0000000189647000-0x0000000189647060
		[Space] // 0x0000000189647000-0x0000000189647060
		private Transform firstTimeGrp; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text firstTimeLabel; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image firstTimeIcon; // 0xF8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text firstTimeNum; // 0x100
		// [Header] // 0x000000018966C460-0x000000018966C4A0
		[SerializeField] // 0x000000018966C460-0x000000018966C4A0
		private Transform buildNameTipsGrp; // 0x108
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text buildNameTipLabel; // 0x110
		// [Header] // 0x0000000189680220-0x0000000189680270
		[SerializeField] // 0x0000000189680220-0x0000000189680270
		[Space] // 0x0000000189680220-0x0000000189680270
		private MonoHomeWorldBuildingPage_ConsoleConstruct _consoleConstruct; // 0x118
		// [Header] // 0x000000018968F830-0x000000018968F890
		[SerializeField] // 0x000000018968F830-0x000000018968F890
		[Space] // 0x000000018968F830-0x000000018968F890
		private MonoHomeWorldBuildingPage_ConsoleDyestuff _consoleDyestuff; // 0x120
		// [Header] // 0x000000018969E7A0-0x000000018969E800
		[SerializeField] // 0x000000018969E7A0-0x000000018969E800
		[Space] // 0x000000018969E7A0-0x000000018969E800
		private MonoHomeWorldBuildingPage_ConsoleProgress _consoleProgress; // 0x128
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Transform _furnitureNoItemTipsGrp; // 0x130
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _furnitureNoItemTips_Title; // 0x138
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _furnitureNoItemTips_Desc; // 0x140
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Transform _friendAssistGrp; // 0x148
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _friendAssistBGButton; // 0x150
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _friendAssist_NoContentGrp; // 0x158
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _friendAssist_Scroller; // 0x160
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private MonoCookGotPanel _furnitureGotPanel; // 0x168
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Transform _screenGrp; // 0x170
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _screenBGButton; // 0x178
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _screenScroller; // 0x180
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private Transform _opPs4Grp; // 0x188
	
		// Properties
		public Transform ScreenGrp { /* [XID] */ /* 0x0000000189714660-0x0000000189714680 */ get => default; } // 0x0000000184B641C0-0x0000000184B64270 
		public Button ScreenBgButton { /* [XID] */ /* 0x000000018971C070-0x000000018971C090 */ get => default; } // 0x0000000184B64110-0x0000000184B641C0 
		public MonoGridScroller ScreenScroller { /* [XID] */ /* 0x0000000189723520-0x0000000189723540 */ get => default; } // 0x0000000184B64270-0x0000000184B64320 
		public MonoElementSwitch ElementSwitch { /* [XID] */ /* 0x000000018972AC60-0x000000018972AC80 */ get => default; } // 0x0000000184B62F50-0x0000000184B62FF0 
		public UnityEngine.UI.Text TabLabel { /* [XID] */ /* 0x0000000189732390-0x00000001897323B0 */ get => default; } // 0x0000000184B648A0-0x0000000184B64940 
		public MonoUIContainer TabKeyLeft { /* [XID] */ /* 0x0000000189739A80-0x0000000189739AA0 */ get => default; } // 0x0000000184B64760-0x0000000184B64800 
		public MonoUIContainer TabKeyRight { /* [XID] */ /* 0x0000000189741640-0x0000000189741660 */ get => default; } // 0x0000000184B64800-0x0000000184B648A0 
		public MonoUIContainer SubTabKeyLeft { /* [XID] */ /* 0x0000000189748F00-0x0000000189748F20 */ get => default; } // 0x0000000184B64320-0x0000000184B643C0 
		public MonoUIContainer SubTabKeyRight { /* [XID] */ /* 0x00000001897503B0-0x00000001897503D0 */ get => default; } // 0x0000000184B643C0-0x0000000184B64460 
		public Transform LeftGrp { /* [XID] */ /* 0x0000000189757950-0x0000000189757970 */ get => default; } // 0x0000000184B63DB0-0x0000000184B63E50 
		public Transform RightGrp { /* [XID] */ /* 0x000000018975F370-0x000000018975F390 */ get => default; } // 0x0000000184B64060-0x0000000184B64110 
		public Transform NoContentGrp { /* [XID] */ /* 0x0000000189766800-0x0000000189766820 */ get => default; } // 0x0000000184B63E50-0x0000000184B63F00 
		public Transform shopMaterialGrp { /* [XID] */ /* 0x000000018976DE10-0x000000018976DE30 */ get => default; } // 0x0000000184B64940-0x0000000184B649F0 
		public MonoReusableList shopMaterialList { /* [XID] */ /* 0x0000000189775550-0x0000000189775570 */ get => default; } // 0x0000000184B649F0-0x0000000184B64AA0 
		public Transform FirstTimeGrp { /* [XID] */ /* 0x000000018977CDB0-0x000000018977CDD0 */ get => default; } // 0x0000000184B62FF0-0x0000000184B630A0 
		public UnityEngine.UI.Text FirstTimeLabel { /* [XID] */ /* 0x00000001897847D0-0x00000001897847F0 */ get => default; } // 0x0000000184B63150-0x0000000184B63200 
		public Image FirstTimeIcon { /* [XID] */ /* 0x000000018978BD60-0x000000018978BD80 */ get => default; } // 0x0000000184B630A0-0x0000000184B63150 
		public UnityEngine.UI.Text FirstTimeNum { /* [XID] */ /* 0x0000000189793210-0x0000000189793230 */ get => default; } // 0x0000000184B63200-0x0000000184B632B0 
		public Transform BuildNameTipsGrp { /* [XID] */ /* 0x000000018979B4E0-0x000000018979B500 */ get => default; } // 0x0000000184B62BD0-0x0000000184B62C80 
		public UnityEngine.UI.Text BuildNameTipLabel { /* [XID] */ /* 0x00000001897A29A0-0x00000001897A29C0 */ get => default; } // 0x0000000184B62B20-0x0000000184B62BD0 
		public Transform FurnitureListGrp { /* [XID] */ /* 0x00000001897A9EA0-0x00000001897A9EC0 */ get => default; } // 0x0000000184B63AF0-0x0000000184B63BA0 
		public Transform FurnitureListGrpSubTabGrp { /* [XID] */ /* 0x00000001897B18D0-0x00000001897B18F0 */ get => default; } // 0x0000000184B63A40-0x0000000184B63AF0 
		public Transform FurnitureListGrpFormulaGrp { /* [XID] */ /* 0x00000001897B9330-0x00000001897B9350 */ get => default; } // 0x0000000184B63780-0x0000000184B63830 
		public MonoGridScroller FurnitureListGrpFormulaScroller { /* [XID] */ /* 0x00000001897C13C0-0x00000001897C13E0 */ get => default; } // 0x0000000184B63830-0x0000000184B638E0 
		public Transform FurnitureListGrpQueueGrp { /* [XID] */ /* 0x00000001897C8E40-0x00000001897C8E60 */ get => default; } // 0x0000000184B638E0-0x0000000184B63990 
		public MonoGridScroller FurnitureListGrpQueueScroller { /* [XID] */ /* 0x00000001897D0440-0x00000001897D0460 */ get => default; } // 0x0000000184B63990-0x0000000184B63A40 
		public Transform FurnitureConsoleGrp { /* [XID] */ /* 0x00000001897D8160-0x00000001897D8180 */ get => default; } // 0x0000000184B63570-0x0000000184B63620 
		public MonoSimpleReusableList FurnitureConsoleIcon { /* [XID] */ /* 0x00000001897DF260-0x00000001897DF280 */ get => default; } // 0x0000000184B63620-0x0000000184B636D0 
		public MonoHomeWorldBuildingPage_ConsoleConstruct ConsoleConstruct { /* [XID] */ /* 0x00000001897E6B20-0x00000001897E6B40 */ get => default; } // 0x0000000184B62C80-0x0000000184B62D30 
		public MonoHomeWorldBuildingPage_ConsoleDyestuff ConsoleDyestuff { /* [XID] */ /* 0x00000001897EE690-0x00000001897EE6B0 */ get => default; } // 0x0000000184B62D30-0x0000000184B62DE0 
		public MonoHomeWorldBuildingPage_ConsoleProgress ConsoleProgress { /* [XID] */ /* 0x00000001897F5EE0-0x00000001897F5F00 */ get => default; } // 0x0000000184B62DE0-0x0000000184B62E90 
		public Transform NoItemTipsGrp { /* [XID] */ /* 0x00000001897FD600-0x00000001897FD620 */ get => default; } // 0x0000000184B63F00-0x0000000184B63FB0 
		public Transform FurnitureNoItemTipsGrp { /* [XID] */ /* 0x0000000189804BC0-0x0000000189804BE0 */ get => default; } // 0x0000000184B63C50-0x0000000184B63D00 
		public UnityEngine.UI.Text FurnitureNoItemTipsTitle { /* [XID] */ /* 0x000000018980C1F0-0x000000018980C210 */ get => default; } // 0x0000000184B63D00-0x0000000184B63DB0 
		public UnityEngine.UI.Text FurnitureNoItemTipsDesc { /* [XID] */ /* 0x00000001898139A0-0x00000001898139C0 */ get => default; } // 0x0000000184B63BA0-0x0000000184B63C50 
		public Transform FriendAssistGrp { /* [XID] */ /* 0x000000018981B4B0-0x000000018981B4D0 */ get => default; } // 0x0000000184B63360-0x0000000184B63410 
		public Button FriendAssistBGButton { /* [XID] */ /* 0x0000000189822B20-0x0000000189822B40 */ get => default; } // 0x0000000184B632B0-0x0000000184B63360 
		public Transform FriendAssistNoContentGrp { /* [XID] */ /* 0x000000018982A450-0x000000018982A470 */ get => default; } // 0x0000000184B63410-0x0000000184B634C0 
		public MonoGridScroller FriendAssistScroller { /* [XID] */ /* 0x0000000189831760-0x0000000189831780 */ get => default; } // 0x0000000184B634C0-0x0000000184B63570 
		public MonoCookGotPanel FurnitureGotPanel { /* [XID] */ /* 0x0000000189838E60-0x0000000189838E80 */ get => default; } // 0x0000000184B636D0-0x0000000184B63780 
		public Transform OpPs4Grp { /* [XID] */ /* 0x0000000189840480-0x00000001898404A0 */ get => default; } // 0x0000000184B63FB0-0x0000000184B64060 
		public MonoUIContainer BtnReturn { /* [XID] */ /* 0x0000000189847A70-0x0000000189847A90 */ get => default; } // 0x0000000184B62760-0x0000000184B62820 
		public MonoUIContainer TabBtnConstructContainer { /* [XID] */ /* 0x000000018984F1E0-0x000000018984F200 */ get => default; } // 0x0000000184B64460-0x0000000184B64520 
		public MonoUIContainer TabBtnDyestuffContainer { /* [XID] */ /* 0x0000000189856340-0x0000000189856360 */ get => default; } // 0x0000000184B646A0-0x0000000184B64760 
		public MonoUIContainer TabBtnConstructFormula { /* [XID] */ /* 0x000000018985D6D0-0x000000018985D6F0 */ get => default; } // 0x0000000184B64520-0x0000000184B645E0 
		public MonoUIContainer TabBtnConstructQueue { /* [XID] */ /* 0x0000000189865070-0x0000000189865090 */ get => default; } // 0x0000000184B645E0-0x0000000184B646A0 
		public MonoUIContainer BtnStartBuilding { /* [XID] */ /* 0x000000018986C5F0-0x000000018986C610 */ get => default; } // 0x0000000184B628E0-0x0000000184B629A0 
		public MonoUIContainer BtnStopBuilding { /* [XID] */ /* 0x0000000189873A40-0x0000000189873A60 */ get => default; } // 0x0000000184B629A0-0x0000000184B62A60 
		public MonoUIContainer BtnFetch { /* [XID] */ /* 0x000000018987B470-0x000000018987B490 */ get => default; } // 0x0000000184B620A0-0x0000000184B62160 
		public MonoUIContainer DropdownSort { /* [XID] */ /* 0x0000000189882670-0x0000000189882690 */ get => default; } // 0x0000000184B62E90-0x0000000184B62F50 
		public MonoUIContainer BtnSort { /* [XID] */ /* 0x0000000189889E20-0x0000000189889E40 */ get => default; } // 0x0000000184B62820-0x0000000184B628E0 
		public MonoUIContainer BtnFriendAssist { /* [XID] */ /* 0x00000001898912C0-0x00000001898912E0 */ get => default; } // 0x0000000184B62220-0x0000000184B622E0 
		public MonoUIContainer BtnFriendAssistBack { /* [XID] */ /* 0x00000001898988D0-0x00000001898988F0 */ get => default; } // 0x0000000184B62160-0x0000000184B62220 
		public MonoUIContainer BtnFriendDetail { /* [XID] */ /* 0x000000018989FB10-0x000000018989FB30 */ get => default; } // 0x0000000184B622E0-0x0000000184B623A0 
		public MonoUIContainer BtnSwitchMaterial { /* [XID] */ /* 0x00000001898A7540-0x00000001898A7560 */ get => default; } // 0x0000000184B62A60-0x0000000184B62B20 
		public MonoUIContainer BtnPlus { /* [XID] */ /* 0x00000001898AEF00-0x00000001898AEF20 */ get => default; } // 0x0000000184B626A0-0x0000000184B62760 
		public MonoUIContainer BtnMinus { /* [XID] */ /* 0x00000001898B6330-0x00000001898B6350 */ get => default; } // 0x0000000184B625E0-0x0000000184B626A0 
		public MonoUIContainer BtnClose_Settlement { /* [XID] */ /* 0x00000001898BDC00-0x00000001898BDC20 */ get => default; } // 0x0000000184B61F20-0x0000000184B61FE0 
		public MonoUIContainer BtnDetail_Settlement { /* [XID] */ /* 0x00000001898C54C0-0x00000001898C54E0 */ get => default; } // 0x0000000184B61FE0-0x0000000184B620A0 
		public MonoUIContainer BtnJumpDyestuff { /* [XID] */ /* 0x00000001898CCA00-0x00000001898CCA20 */ get => default; } // 0x0000000184B62460-0x0000000184B62520 
		public MonoUIContainer BtnItemDetail { /* [XID] */ /* 0x00000001898D4420-0x00000001898D4440 */ get => default; } // 0x0000000184B623A0-0x0000000184B62460 
		public MonoUIContainer BtnJumpFurniture { /* [XID] */ /* 0x00000001898DBBE0-0x00000001898DBC00 */ get => default; } // 0x0000000184B62520-0x0000000184B625E0 
	
		// Constructors
		public MonoHomeWorldBuildingPage() {} // 0x0000000184B61DA0-0x0000000184B61F20
	
		// Methods
		// [XID] // 0x00000001898E37C0-0x00000001898E37E0
		public void SetFirstTimeIcon(uint materialId) {} // 0x0000000184B61C90-0x0000000184B61DA0
	}
}
