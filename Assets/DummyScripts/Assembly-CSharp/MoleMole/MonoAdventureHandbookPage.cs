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
	public class MonoAdventureHandbookPage : MonoUIProxy // TypeDefIndex: 30985
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _travelBtn; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _taskBtn; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _dungeonBtn; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _monsterBtn; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _cityDropdown; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoAdventureTravelsPanel _travelPanel; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoAdventureTaskPanel _taskPanel; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoAdventureDungeonPanel _dungeonPanel; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoAdventureMonsterPanel _monsterPanel; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _dungeonEntryDropdown; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _trialDungeonEntryDropdown; // 0x98
	
		// Properties
		public MonoUIContainer travelBtn { /* [XID] */ /* 0x0000000189B36530-0x0000000189B36550 */ get => default; } // 0x0000000184C85920-0x0000000184C859C0 
		public MonoUIContainer taskBtn { /* [XID] */ /* 0x0000000189B3DD30-0x0000000189B3DD50 */ get => default; } // 0x0000000184C854E0-0x0000000184C85580 
		public MonoUIContainer dungeonBtn { /* [XID] */ /* 0x0000000189B45AB0-0x0000000189B45AD0 */ get => default; } // 0x0000000184C84710-0x0000000184C847B0 
		public MonoUIContainer monsterBtn { /* [XID] */ /* 0x0000000189B4CF50-0x0000000189B4CF70 */ get => default; } // 0x0000000184C84CD0-0x0000000184C84D70 
		public MonoUIContainer cityDropdown { /* [XID] */ /* 0x0000000189B54650-0x0000000189B54670 */ get => default; } // 0x0000000184C845A0-0x0000000184C84640 
		public MonoAdventureTravelsPanel travelPanel { /* [XID] */ /* 0x0000000189B5C220-0x0000000189B5C240 */ get => default; } // 0x0000000184C85A80-0x0000000184C85B20 
		public MonoAdventureTaskPanel taskPanel { /* [XID] */ /* 0x0000000189B63820-0x0000000189B63840 */ get => default; } // 0x0000000184C85700-0x0000000184C857A0 
		public MonoAdventureDungeonPanel dungeonPanel { /* [XID] */ /* 0x0000000189B6AFE0-0x0000000189B6B000 */ get => default; } // 0x0000000184C84870-0x0000000184C84910 
		public MonoAdventureMonsterPanel monsterPanel { /* [XID] */ /* 0x0000000189B72620-0x0000000189B72640 */ get => default; } // 0x0000000184C84EF0-0x0000000184C84FA0 
		public Transform cityDropDownImgArrow { /* [XID] */ /* 0x0000000189B79B70-0x0000000189B79B90 */ get => default; } // 0x0000000184C844D0-0x0000000184C845A0 
		public Transform dungeonAbyssusDropDownImgArrow { /* [XID] */ /* 0x0000000189B812E0-0x0000000189B81300 */ get => default; } // 0x0000000184C84640-0x0000000184C84710 
		public MonoUIContainer returnButton { /* [XID] */ /* 0x0000000189B88A70-0x0000000189B88A90 */ get => default; } // 0x0000000184C85360-0x0000000184C85420 
		public MonoUIContainer receiveButton { /* [XID] */ /* 0x0000000189B8FF20-0x0000000189B8FF40 */ get => default; } // 0x0000000184C852A0-0x0000000184C85360 
		public MonoUIContainer locationButton { /* [XID] */ /* 0x0000000189B97340-0x0000000189B97360 */ get => default; } // 0x0000000184C84C10-0x0000000184C84CD0 
		public MonoUIContainer fetchHintButton { /* [XID] */ /* 0x0000000189B9E7C0-0x0000000189B9E7E0 */ get => default; } // 0x0000000184C84910-0x0000000184C849D0 
		public MonoUIContainer travelDetailButton { /* [XID] */ /* 0x0000000189BA6170-0x0000000189BA6190 */ get => default; } // 0x0000000184C859C0-0x0000000184C85A80 
		public MonoUIContainer travelReturnButton { /* [XID] */ /* 0x0000000189BAD3E0-0x0000000189BAD400 */ get => default; } // 0x0000000184C85B20-0x0000000184C85BE0 
		public MonoUIContainer taskDetailButton { /* [XID] */ /* 0x0000000189BB4BD0-0x0000000189BB4BF0 */ get => default; } // 0x0000000184C85580-0x0000000184C85640 
		public MonoUIContainer taskGotoButton { /* [XID] */ /* 0x0000000189BBC180-0x0000000189BBC1A0 */ get => default; } // 0x0000000184C85640-0x0000000184C85700 
		public MonoUIContainer taskReturnButton { /* [XID] */ /* 0x0000000189BC3EE0-0x0000000189BC3F00 */ get => default; } // 0x0000000184C857A0-0x0000000184C85860 
		public MonoUIContainer abyssusHelpButton { /* [XID] */ /* 0x0000000189BCB7A0-0x0000000189BCB7C0 */ get => default; } // 0x0000000184C841D0-0x0000000184C84290 
		public MonoUIContainer abyssusDetailButton { /* [XID] */ /* 0x0000000189BD2DE0-0x0000000189BD2E00 */ get => default; } // 0x0000000184C84050-0x0000000184C84110 
		public MonoUIContainer abyssusGotoButton { /* [XID] */ /* 0x0000000189BDA4C0-0x0000000189BDA4E0 */ get => default; } // 0x0000000184C84110-0x0000000184C841D0 
		public MonoUIContainer abyssusCheckButton { /* [XID] */ /* 0x00000001895E6F50-0x00000001895E6F70 */ get => default; } // 0x0000000184C83F90-0x0000000184C84050 
		public MonoUIContainer abyssusReturnButton { /* [XID] */ /* 0x00000001895EE8C0-0x00000001895EE8E0 */ get => default; } // 0x0000000184C84290-0x0000000184C84350 
		public MonoUIContainer trialHelpButton { /* [XID] */ /* 0x00000001895F62A0-0x00000001895F62C0 */ get => default; } // 0x0000000184C85EE0-0x0000000184C85FA0 
		public MonoUIContainer trialDetailButton { /* [XID] */ /* 0x00000001895FD5E0-0x00000001895FD600 */ get => default; } // 0x0000000184C85CA0-0x0000000184C85D60 
		public MonoUIContainer trialGotoButton { /* [XID] */ /* 0x0000000189604F00-0x0000000189604F20 */ get => default; } // 0x0000000184C85E20-0x0000000184C85EE0 
		public MonoUIContainer trialCheckButton { /* [XID] */ /* 0x000000018960C950-0x000000018960C970 */ get => default; } // 0x0000000184C85BE0-0x0000000184C85CA0 
		public MonoUIContainer trialReturnButton { /* [XID] */ /* 0x0000000189613E70-0x0000000189613E90 */ get => default; } // 0x0000000184C85FA0-0x0000000184C86060 
		public MonoUIContainer obscuraeHelpButton { /* [XID] */ /* 0x000000018961B840-0x000000018961B860 */ get => default; } // 0x0000000184C85120-0x0000000184C851E0 
		public MonoUIContainer obscuraeReturnButton { /* [XID] */ /* 0x0000000189622DC0-0x0000000189622DE0 */ get => default; } // 0x0000000184C851E0-0x0000000184C852A0 
		public MonoUIContainer tipsButton { /* [XID] */ /* 0x000000018962A5B0-0x000000018962A5D0 */ get => default; } // 0x0000000184C85860-0x0000000184C85920 
		public MonoUIContainer monsterTrackButton { /* [XID] */ /* 0x0000000189631D30-0x0000000189631D50 */ get => default; } // 0x0000000184C85060-0x0000000184C85120 
		public MonoUIContainer monsterDetailButton { /* [XID] */ /* 0x0000000189639890-0x00000001896398B0 */ get => default; } // 0x0000000184C84D70-0x0000000184C84E30 
		public MonoUIContainer monsterReturnButton { /* [XID] */ /* 0x0000000189640D00-0x0000000189640D20 */ get => default; } // 0x0000000184C84FA0-0x0000000184C85060 
		public MonoUIContainer monsterOccupiedDetailButton { /* [XID] */ /* 0x0000000189648650-0x0000000189648670 */ get => default; } // 0x0000000184C84E30-0x0000000184C84EF0 
		public Dropdown dungeonEntryDropdown { /* [XID] */ /* 0x000000018964FD60-0x000000018964FD80 */ get => default; } // 0x0000000184C847B0-0x0000000184C84870 
		public Dropdown trialEntryDropdown { /* [XID] */ /* 0x00000001896575A0-0x00000001896575C0 */ get => default; } // 0x0000000184C85D60-0x0000000184C85E20 
		public MonoUIContainer rewardPreviewButton { /* [XID] */ /* 0x000000018965EC60-0x000000018965EC80 */ get => default; } // 0x0000000184C85420-0x0000000184C854E0 
		public MonoUIContainer gotoChallengeButton { /* [XID] */ /* 0x0000000189666300-0x0000000189666320 */ get => default; } // 0x0000000184C849D0-0x0000000184C84A90 
		public bool showWorldStaminaTipsButton { /* [XID] */ /* 0x000000018966DB00-0x000000018966DB20 */ set {} } // 0x0000000184C86120-0x0000000184C86210
		public MonoUIContainer worldStaminaTipsBtn { /* [XID] */ /* 0x00000001896758E0-0x0000000189675900 */ get => default; } // 0x0000000184C86060-0x0000000184C86120 
		public MonoUIContainer chapterNextBtn { /* [XID] */ /* 0x000000018967D1F0-0x000000018967D210 */ get => default; } // 0x0000000184C84350-0x0000000184C84410 
		public MonoUIContainer chapterPrevBtn { /* [XID] */ /* 0x00000001896848A0-0x00000001896848C0 */ get => default; } // 0x0000000184C84410-0x0000000184C844D0 
		public MonoUIContainer halfTipsDungeonTrialBtn { /* [XID] */ /* 0x000000018968C410-0x000000018968C430 */ get => default; } // 0x0000000184C84A90-0x0000000184C84B50 
		public MonoUIContainer halfTipsMonsterBtn { /* [XID] */ /* 0x0000000189693EE0-0x0000000189693F00 */ get => default; } // 0x0000000184C84B50-0x0000000184C84C10 
	
		// Constructors
		public MonoAdventureHandbookPage() {} // 0x0000000184C83EF0-0x0000000184C83F90
	}
}
