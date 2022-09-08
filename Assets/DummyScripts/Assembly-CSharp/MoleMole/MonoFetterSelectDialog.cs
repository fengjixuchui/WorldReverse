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
	public class MonoFetterSelectDialog : MonoUIProxy // TypeDefIndex: 29712
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _title; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _cv; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoElementSwitch _elementSwitch; // 0x50
		// [Header] // 0x00000001896635C0-0x0000000189663610
		[SerializeField] // 0x00000001896635C0-0x0000000189663610
		private MonoGridScroller _leftGridScroll; // 0x58
		// [Header] // 0x000000018966F990-0x000000018966F9E0
		[SerializeField] // 0x000000018966F990-0x000000018966F9E0
		private GameObject _rightDetail; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rightTitleText; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rightDescText; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _rightDescScrollRect; // 0x78
		// [Header] // 0x0000000189692A00-0x0000000189692A50
		[SerializeField] // 0x0000000189692A00-0x0000000189692A50
		private GameObject _rightLockInfo; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _rightLockTitle; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoSimpleReusableList _unLockSimpleScroll; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _rightTipsScrollRect; // 0x98
	
		// Properties
		public UnityEngine.UI.Text title { /* [XID] */ /* 0x00000001896B4720-0x00000001896B4740 */ get => default; } // 0x0000000185631E00-0x0000000185631EA0 
		public MonoGridScroller leftGridScroll { /* [XID] */ /* 0x00000001896BB990-0x00000001896BB9B0 */ get => default; } // 0x00000001856316F0-0x0000000185631790 
		public UnityEngine.UI.Text rightTitleText { /* [XID] */ /* 0x00000001896C2E50-0x00000001896C2E70 */ get => default; } // 0x0000000185631CB0-0x0000000185631D50 
		public UnityEngine.UI.Text rightDescText { /* [XID] */ /* 0x00000001896CA2E0-0x00000001896CA300 */ get => default; } // 0x0000000185631AB0-0x0000000185631B50 
		public MonoSimpleReusableList unLockSimpleScroll { /* [XID] */ /* 0x00000001896D1990-0x00000001896D19B0 */ get => default; } // 0x0000000185631EA0-0x0000000185631F50 
		public GameObject rightDescGameObject { /* [XID] */ /* 0x00000001896D91A0-0x00000001896D91C0 */ get => default; } // 0x0000000185631970-0x0000000185631A10 
		public GameObject rightUnlockTipsGameObject { /* [XID] */ /* 0x00000001896E0970-0x00000001896E0990 */ get => default; } // 0x0000000185631D50-0x0000000185631E00 
		public UnityEngine.UI.Text rightLockTitle { /* [XID] */ /* 0x00000001896E7C20-0x00000001896E7C40 */ get => default; } // 0x0000000185631B50-0x0000000185631C00 
		public Button closeButton { /* [XID] */ /* 0x00000001896EF310-0x00000001896EF330 */ get => default; } // 0x0000000185631470-0x0000000185631650 
		public Button ps4PlayButton { /* [XID] */ /* 0x00000001896F6CA0-0x00000001896F6CC0 */ get => default; } // 0x0000000185631790-0x0000000185631970 
		public Button CheckButton { /* [XID] */ /* 0x00000001896FE610-0x00000001896FE630 */ get => default; } // 0x0000000185631290-0x0000000185631470 
		public ScrollRect rightDescScrollRect { /* [XID] */ /* 0x0000000189705720-0x0000000189705740 */ get => default; } // 0x0000000185631A10-0x0000000185631AB0 
		public ScrollRect rightTipsScrollRect { /* [XID] */ /* 0x000000018970D260-0x000000018970D280 */ get => default; } // 0x0000000185631C00-0x0000000185631CB0 
		public UnityEngine.UI.Text cv { /* [XID] */ /* 0x000000018972ACE0-0x000000018972AD00 */ get => default; } // 0x0000000185631650-0x00000001856316F0 
	
		// Constructors
		public MonoFetterSelectDialog() {} // 0x00000001856311F0-0x0000000185631290
	
		// Methods
		// [XID] // 0x0000000189714700-0x0000000189714720
		public void InitPS4ButtonText() {} // 0x0000000185630A00-0x0000000185630DF0
		// [XID] // 0x000000018971C110-0x000000018971C130
		public void SetButtonTextPlay() {} // 0x0000000185630DF0-0x0000000185630FF0
		// [XID] // 0x0000000189723560-0x0000000189723580
		public void SetButtonTextStop() {} // 0x0000000185630FF0-0x00000001856311F0
	}
}
