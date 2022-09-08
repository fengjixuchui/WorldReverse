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
	public class MonoTheatreMechanicusCardSelectionPage : MonoUIProxy // TypeDefIndex: 31275
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _title; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _buildingTime; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _buildingPoints; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _monsterScroller; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _cardScroller; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Animator _skipAnimator; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _skipIconPlayer1; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _skipIconPlayer2; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _skipIconSinglePlayer; // 0x88
	
		// Properties
		public Text title { /* [XID] */ /* 0x0000000189BD2D60-0x0000000189BD2D80 */ get => default; } // 0x0000000183B6C430-0x0000000183B6C4D0 
		public Text buildingTime { /* [XID] */ /* 0x0000000189BDA440-0x0000000189BDA460 */ get => default; } // 0x0000000183B6BD70-0x0000000183B6BE10 
		public Text buildingPoints { /* [XID] */ /* 0x00000001895E6ED0-0x00000001895E6EF0 */ get => default; } // 0x0000000183B6BCD0-0x0000000183B6BD70 
		public MonoGridScroller monsterScroller { /* [XID] */ /* 0x00000001895EE860-0x00000001895EE880 */ get => default; } // 0x0000000183B6C030-0x0000000183B6C0D0 
		public MonoSimpleReusableList cardScroller { /* [XID] */ /* 0x00000001895F6200-0x00000001895F6220 */ get => default; } // 0x0000000183B6BE10-0x0000000183B6BEB0 
		public Animator skipAnimator { /* [XID] */ /* 0x00000001895FD540-0x00000001895FD560 */ get => default; } // 0x0000000183B6C0D0-0x0000000183B6C170 
		public Transform skipIconPlayer1 { /* [XID] */ /* 0x0000000189604E80-0x0000000189604EA0 */ get => default; } // 0x0000000183B6C230-0x0000000183B6C2D0 
		public Transform skipIconPlayer2 { /* [XID] */ /* 0x000000018960C890-0x000000018960C8B0 */ get => default; } // 0x0000000183B6C2D0-0x0000000183B6C380 
		public Transform skipIconSinglePlayer { /* [XID] */ /* 0x0000000189613DF0-0x0000000189613E10 */ get => default; } // 0x0000000183B6C380-0x0000000183B6C430 
		public MonoUIContainer confirmBtn { /* [XID] */ /* 0x000000018961B7C0-0x000000018961B7E0 */ get => default; } // 0x0000000183B6BEB0-0x0000000183B6BF70 
		public MonoUIContainer infoBtn { /* [XID] */ /* 0x0000000189622D40-0x0000000189622D60 */ get => default; } // 0x0000000183B6BF70-0x0000000183B6C030 
		public MonoUIContainer skipBtn { /* [XID] */ /* 0x000000018962A530-0x000000018962A550 */ get => default; } // 0x0000000183B6C170-0x0000000183B6C230 
	
		// Constructors
		public MonoTheatreMechanicusCardSelectionPage() {} // 0x0000000183B6BC40-0x0000000183B6BCD0
	}
}
