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
	public class MonoActivityBlessingCameraSubPage : MonoUIProxy // TypeDefIndex: 31151
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x40
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private UnityEngine.UI.Text _targetTypeName; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _refreshTime; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _scanTimes; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _scanInfoGrp; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _limitInfoGrp; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _limitInfoText; // 0x70
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private UnityEngine.UI.Text _activityCloseTime; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoGridScroller _albumScroller; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoJoypadScrollRect _scrollRect; // 0x88
	
		// Properties
		public string targetTypeName { /* [XID] */ /* 0x000000018992D440-0x000000018992D460 */ set {} } // 0x0000000184C79A40-0x0000000184C79B10
		public string refreshTime { /* [XID] */ /* 0x0000000189934990-0x00000001899349B0 */ set {} } // 0x0000000184C79780-0x0000000184C79850
		public string scanTimes { /* [XID] */ /* 0x000000018993C460-0x000000018993C480 */ set {} } // 0x0000000184C79850-0x0000000184C79920
		public string activityCloseTime { /* [XID] */ /* 0x0000000189943AB0-0x0000000189943AD0 */ set {} } // 0x0000000184C795D0-0x0000000184C796A0
		public string limitInfoText { /* [XID] */ /* 0x000000018994B050-0x000000018994B070 */ set {} } // 0x0000000184C796A0-0x0000000184C79780
		public MonoGridScroller albumScroller { /* [XID] */ /* 0x00000001899529F0-0x0000000189952A10 */ get => default; } // 0x0000000184C79470-0x0000000184C79520 
		public MonoJoypadScrollRect textScroller { /* [XID] */ /* 0x0000000189959F90-0x0000000189959FB0 */ get => default; } // 0x0000000184C79520-0x0000000184C795D0 
		public MonoUIContainer BtnDesc { /* [XID] */ /* 0x00000001899619A0-0x00000001899619C0 */ get => default; } // 0x0000000184C78FF0-0x0000000184C790B0 
		public MonoUIContainer BtnSwitch { /* [XID] */ /* 0x0000000189969050-0x0000000189969070 */ get => default; } // 0x0000000184C793B0-0x0000000184C79470 
		public MonoUIContainer BtnGoto { /* [XID] */ /* 0x0000000189970A90-0x0000000189970AB0 */ get => default; } // 0x0000000184C79170-0x0000000184C79230 
		public MonoUIContainer BtnReward { /* [XID] */ /* 0x0000000189978490-0x00000001899784B0 */ get => default; } // 0x0000000184C792F0-0x0000000184C793B0 
		public MonoUIContainer BtnExit { /* [XID] */ /* 0x000000018997F590-0x000000018997F5B0 */ get => default; } // 0x0000000184C790B0-0x0000000184C79170 
		public MonoUIContainer BtnBack { /* [XID] */ /* 0x0000000189986EE0-0x0000000189986F00 */ get => default; } // 0x0000000184C78F30-0x0000000184C78FF0 
		public MonoUIContainer BtnOK { /* [XID] */ /* 0x000000018998E990-0x000000018998E9B0 */ get => default; } // 0x0000000184C79230-0x0000000184C792F0 
		public bool showScanInfo { /* [XID] */ /* 0x00000001899965D0-0x00000001899965F0 */ set {} } // 0x0000000184C79920-0x0000000184C79A40
	
		// Constructors
		public MonoActivityBlessingCameraSubPage() {} // 0x0000000184C78EA0-0x0000000184C78F30
	}
}
