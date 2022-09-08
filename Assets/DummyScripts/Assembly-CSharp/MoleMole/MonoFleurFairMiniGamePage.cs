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
	public class MonoFleurFairMiniGamePage : MonoUIProxy // TypeDefIndex: 30380
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _coinRoot; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _prevTabBtn; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoUIContainer _nextTabBtn; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoFleurFairMiniGame[] _miniGames; // 0x60
		private MonoReusableList _tabContainer; // 0x68
	
		// Properties
		public MonoUIContainer BtnReturn { /* [XID] */ /* 0x0000000189770E50-0x0000000189770E70 */ get => default; } // 0x0000000184ADBBA0-0x0000000184ADBC60 
		public MonoUIContainer BtnGotoQuest { /* [XID] */ /* 0x00000001897787E0-0x0000000189778800 */ get => default; } // 0x0000000184ADBA20-0x0000000184ADBAE0 
		public MonoUIContainer BtnCourse { /* [XID] */ /* 0x000000018977FD20-0x000000018977FD40 */ get => default; } // 0x0000000184ADB8A0-0x0000000184ADB960 
		public MonoUIContainer BtnFetch { /* [XID] */ /* 0x0000000189787600-0x0000000189787620 */ get => default; } // 0x0000000184ADB960-0x0000000184ADBA20 
		public MonoUIContainer BtnGoto { /* [XID] */ /* 0x000000018978EC30-0x000000018978EC50 */ get => default; } // 0x0000000184ADBAE0-0x0000000184ADBBA0 
		public MonoUIContainer BtnCheck { /* [XID] */ /* 0x00000001897963E0-0x0000000189796400 */ get => default; } // 0x0000000184ADB7E0-0x0000000184ADB8A0 
		public Transform coinRoot { /* [XID] */ /* 0x000000018979E4B0-0x000000018979E4D0 */ get => default; } // 0x0000000184ADBC60-0x0000000184ADBD00 
		public MonoReusableList tabContainer { /* [XID] */ /* 0x00000001897A5C30-0x00000001897A5C50 */ get => default; } // 0x0000000184ADBE60-0x0000000184ADBF00 
		public Button prevTabBtn { /* [XID] */ /* 0x00000001897AD1A0-0x00000001897AD1C0 */ get => default; } // 0x0000000184ADBDB0-0x0000000184ADBE60 
		public Button nextTabBtn { /* [XID] */ /* 0x00000001897B51D0-0x00000001897B51F0 */ get => default; } // 0x0000000184ADBD00-0x0000000184ADBDB0 
	
		// Constructors
		public MonoFleurFairMiniGamePage() {} // 0x0000000184ADB760-0x0000000184ADB7E0
	
		// Methods
		// [XID] // 0x00000001897BCE40-0x00000001897BCE60
		public void CreateTabs(int count) {} // 0x0000000184ADB210-0x0000000184ADB3B0
		// [XID] // 0x00000001897C41C0-0x00000001897C41E0
		public MonoImgTab GetTabAt(int index) => default; // 0x0000000184ADB4A0-0x0000000184ADB600
		// [XID] // 0x00000001897CBA20-0x00000001897CBA40
		public MonoFleurFairMiniGame GetMiniGameMono(int miniGameIdx) => default; // 0x0000000184ADB3B0-0x0000000184ADB4A0
		// [XID] // 0x00000001897D3330-0x00000001897D3350
		public void ShowMiniGame(int index) {} // 0x0000000184ADB600-0x0000000184ADB760
	}
}
