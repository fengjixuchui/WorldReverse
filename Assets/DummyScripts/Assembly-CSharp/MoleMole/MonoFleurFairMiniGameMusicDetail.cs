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
	public class MonoFleurFairMiniGameMusicDetail : MonoBehaviour // TypeDefIndex: 30379
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _titleText; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _descText; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _musicDescText; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _scroll; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text[] _score; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform[] _notChallenged; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform[] _locked; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _selectTrans; // 0x50
	
		// Properties
		public ScrollRect scroll { /* [XID] */ /* 0x00000001897174D0-0x00000001897174F0 */ get => default; } // 0x0000000184ADB0D0-0x0000000184ADB170 
		public UnityEngine.UI.Text titleText { /* [XID] */ /* 0x000000018971EF50-0x000000018971EF70 */ get => default; } // 0x0000000184ADB170-0x0000000184ADB210 
		public UnityEngine.UI.Text descText { /* [XID] */ /* 0x0000000189726580-0x00000001897265A0 */ get => default; } // 0x0000000184ADAF90-0x0000000184ADB030 
		public UnityEngine.UI.Text musigDescText { /* [XID] */ /* 0x000000018972DAF0-0x000000018972DB10 */ get => default; } // 0x0000000184ADB030-0x0000000184ADB0D0 
	
		// Constructors
		public MonoFleurFairMiniGameMusicDetail() {} // 0x0000000184ADAF00-0x0000000184ADAF90
	
		// Methods
		// [XID] // 0x0000000189735270-0x0000000189735290
		public void SetState(int idx, int state) {} // 0x0000000184ADAD60-0x0000000184ADAF00
		// [XID] // 0x000000018973CCF0-0x000000018973CD10
		public void SetScore(int idx, uint score) {} // 0x0000000184ADAB60-0x0000000184ADAC80
		// [XID] // 0x0000000189744270-0x0000000189744290
		public void SetSelected(bool bSelected) {} // 0x0000000184ADAC80-0x0000000184ADAD60
	}
}
